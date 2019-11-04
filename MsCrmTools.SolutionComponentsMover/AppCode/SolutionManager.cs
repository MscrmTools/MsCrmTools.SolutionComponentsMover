using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
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

        internal void CopyComponents(CopySettings settings, BackgroundWorker backgroundWorker)
        {
            backgroundWorker.ReportProgress(0, "Retrieving source solution(s) components...");

            var components = RetrieveComponentsFromSolutions(settings.SourceSolutions.Select(s => s.Id).ToList(), settings.ComponentsTypes);

            foreach (var target in settings.TargetSolutions)
            {
                backgroundWorker.ReportProgress(0,
                    $"Adding {components.Count} components to solution '{target.GetAttributeValue<string>("friendlyname")}'");

                AddSolutionComponentRequest request = new AddSolutionComponentRequest();

                try
                {
                    foreach (var component in components)
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
                            $"Component {request.ComponentId} of type {request.ComponentType} successfully added to solution '{request.SolutionUniqueName}'");
                    }
                }
                catch (Exception error)
                {
                    backgroundWorker.ReportProgress(-1,
                        $"Error when adding component {request.ComponentId} of type {request.ComponentType} to solution '{request.SolutionUniqueName}' : {error.Message}");
                }
            }
        }

        internal List<Entity> RetrieveComponentsFromSolutions(List<Guid> solutionsIds, List<int> componentsTypes)
        {
            var qe = new QueryExpression("solutioncomponent")
            {
                ColumnSet = new ColumnSet(true),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("solutionid", ConditionOperator.In, solutionsIds.ToArray()),
                        new ConditionExpression("componenttype", ConditionOperator.In, componentsTypes.ToArray())
                    }
                }
            };

            return service.RetrieveMultiple(qe).Entities.ToList();
        }
    }
}