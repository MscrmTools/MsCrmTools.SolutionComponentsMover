﻿using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MsCrmTools.SolutionComponentsMover.AppCode
{
    internal class SolutionManager
    {
        private readonly IOrganizationService service;

        public SolutionManager(IOrganizationService service)
        {
            this.service = service;
        }

        public IEnumerable<Entity> RetrieveSolutions()
        {
            var qe = new QueryExpression
            {
                EntityName = "solution",
                ColumnSet = new ColumnSet(new[]{
                                            "publisherid", "installedon", "version",
                                            "uniquename", "friendlyname", "description",
                                            "ismanaged"
                                        }),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("isvisible", ConditionOperator.Equal, true),
                        new ConditionExpression("uniquename", ConditionOperator.NotEqual, "Default")
                    }
                }
            };

            return service.RetrieveMultiple(qe).Entities;
        }

        internal void CopyComponents(CopySettings settings, OptionMetadataCollection omc, EntityMetadataCollection emds, List<Entity> solutionComponents, bool isOnline, BackgroundWorker backgroundWorker)
        {
            backgroundWorker.ReportProgress(0, "Retrieving source solution(s) components...");

            var components = RetrieveComponentsFromSolutions(settings.SourceSolutions.Select(s => s.Id).ToList(), settings.ComponentsTypes, settings.AllComponents);

            var entityComponents = components.Where(c =>
                c.GetAttributeValue<OptionSetValue>("componenttype").Value == 1
                && c.GetAttributeValue<OptionSetValue>("rootcomponentbehavior").Value == 0
                && (bool)c.GetAttributeValue<AliasedValue>("solution.ismanaged").Value == false).ToList();

            if (entityComponents.Any() && settings.CheckBestPractice)
            {
                backgroundWorker.ReportProgress(0, "Analyzing entities components behavior...");
                var managedEmds = GetManagedEntities(entityComponents.Select(ec => ec.GetAttributeValue<Guid>("objectid"))
                    .ToArray());

                if (managedEmds.Any())
                {
                    string entityList = string.Join(Environment.NewLine, emds.OrderBy(e => e.DisplayName?.UserLocalizedLabel?.Label ?? e.SchemaName).Take(10).Select(e => "- " + e.DisplayName?.UserLocalizedLabel?.Label ?? e.SchemaName)) + (managedEmds.Count > 10 ? Environment.NewLine + "- and more..." : "");
                    string message = $@"Best practices are not respected!

Managed entities should not be added in unmanaged solutions with all their assets.

Remove best practice check if you really want to copy the following entities to the target solution(s):
{entityList}";
                    throw new Exception(message);
                }
            }

            foreach (var target in settings.TargetSolutions)
            {
                backgroundWorker.ReportProgress(0,
                    $"Adding {components.Count} components to solution '{target.GetAttributeValue<string>("friendlyname")}'");

                AddSolutionComponentRequest request = new AddSolutionComponentRequest();

                foreach (var component in components)
                {
                    string componentName;
                    if (isOnline)
                    {
                        var entity = emds.FirstOrDefault(emd => emd.LogicalName == solutionComponents.FirstOrDefault(x => x.GetAttributeValue<int>("objecttypecode") == component.GetAttributeValue<OptionSetValue>("componenttype").Value)?.GetAttributeValue<string>("primaryentityname"));
                        if (entity == null)
                        {
                            componentName = omc.FirstOrDefault(o => o.Value == component.GetAttributeValue<OptionSetValue>("componenttype").Value)?.Label?.UserLocalizedLabel?.Label;
                        }
                        else
                        {
                            componentName = entity.DisplayName?.UserLocalizedLabel?.Label ?? entity.SchemaName;
                        }
                    }
                    else
                    {
                        componentName = omc.FirstOrDefault(o => o.Value == component.GetAttributeValue<OptionSetValue>("componenttype").Value)?.Label?.UserLocalizedLabel?.Label;
                    }

                    if (componentName == null)
                    {
                        componentName = $"No label (code:{component.GetAttributeValue<OptionSetValue>("componenttype").Value})";
                    }

                    try
                    {
                        request = new AddSolutionComponentRequest
                        {
                            AddRequiredComponents = false,
                            ComponentId = component.GetAttributeValue<Guid>("objectid"),
                            ComponentType = component.GetAttributeValue<OptionSetValue>("componenttype").Value,
                            SolutionUniqueName = target.GetAttributeValue<string>("uniquename"),
                        };

                        // If CRM 2016 or above, handle subcomponents behavior
                        if (settings.ConnectionDetail.OrganizationMajorVersion >= 8)
                        {
                            request.DoNotIncludeSubcomponents =
                                component.GetAttributeValue<OptionSetValue>("rootcomponentbehavior")?.Value == 1 ||
                                component.GetAttributeValue<OptionSetValue>("rootcomponentbehavior")?.Value == 2;
                        }

                        service.Execute(request);

                        backgroundWorker.ReportProgress(1,
                            $"Component {request.ComponentId} of type {componentName} successfully added to solution '{request.SolutionUniqueName}'");
                    }
                    catch (Exception error)
                    {
                        backgroundWorker.ReportProgress(-1,
                            $"Error when adding component {request.ComponentId} of type {componentName} to solution '{request.SolutionUniqueName}' : {error.Message}");
                    }
                }
            }
        }

        internal List<Entity> RetrieveComponentsFromSolutions(List<Guid> solutionsIds, List<int> componentsTypes, bool allComponents)
        {
            var qe = new QueryExpression("solutioncomponent")
            {
                ColumnSet = new ColumnSet(true),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("solutionid", ConditionOperator.In, solutionsIds.ToArray())
                    }
                },
                LinkEntities =
                {
                    new LinkEntity
                    {
                        LinkFromEntityName = "solutioncomponent",
                        LinkFromAttributeName = "solutionid",
                        LinkToAttributeName = "solutionid",
                        LinkToEntityName = "solution",
                        EntityAlias = "solution",
                        Columns = new ColumnSet("ismanaged")
                    }
                }
            };

            if (!allComponents)
            {
                var ce = new ConditionExpression("componenttype", ConditionOperator.In, componentsTypes);

                qe.Criteria.Conditions.Add(ce);
            }

            var queryResult = new List<Entity>();
            EntityCollection pageResult;

            do
            {
                pageResult = service.RetrieveMultiple(qe);

                queryResult.AddRange(pageResult.Entities);

                // prepare next request
                if (pageResult.MoreRecords)
                {
                    qe.PageInfo.PageNumber++;
                    qe.PageInfo.PagingCookie = pageResult.PagingCookie;
                }
            }
            while (pageResult.MoreRecords);

            return queryResult;
        }

        private List<EntityMetadata> GetManagedEntities(params Guid[] ids)
        {
            EntityQueryExpression entityQueryExpressionFull = new EntityQueryExpression
            {
                Properties = new MetadataPropertiesExpression
                {
                    AllProperties = false,
                    PropertyNames =
                    {
                        "DisplayName",
                        "LogicalName",
                        "SchemaName",
                    }
                },
                Criteria = new MetadataFilterExpression
                {
                    Conditions =
                    {
                        new MetadataConditionExpression("MetadataId", MetadataConditionOperator.In, ids),
                        new MetadataConditionExpression("IsManaged", MetadataConditionOperator.Equals, true)
                    }
                }
            };

            RetrieveMetadataChangesRequest request = new RetrieveMetadataChangesRequest
            {
                Query = entityQueryExpressionFull,
                ClientVersionStamp = null
            };

            var fullResponse = (RetrieveMetadataChangesResponse)service.Execute(request);
            return fullResponse.EntityMetadata.ToList();
        }
    }
}