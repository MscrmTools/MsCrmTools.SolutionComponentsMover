using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;

namespace MsCrmTools.SolutionComponentsMover.AppCode
{
    /// <summary>
    /// Class for querying Crm Metadata
    /// </summary>
    internal class MetadataHelper
    {
        private static readonly string[] EntityMetadataProperties = { "LogicalName", "DisplayName", "SchemaName" };

        public static EntityMetadataCollection LoadEntities(IOrganizationService service)
        {
            var entityQueryExpression = new EntityQueryExpression()
            {
                Properties = new MetadataPropertiesExpression(EntityMetadataProperties),
            };
            var retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
            {
                Query = entityQueryExpression,
                ClientVersionStamp = null
            };

            return ((RetrieveMetadataChangesResponse)service.Execute(retrieveMetadataChangesRequest)).EntityMetadata;
        }
    }
}