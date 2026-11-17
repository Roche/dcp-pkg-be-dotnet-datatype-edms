using OpenDCP.Framework.Configuration.Model.Responses.Datasource;
using OpenDCP.Framework.DataTypes.ElectronicDocumentManagement.Entities;

namespace OpenDCP.Framework.DataTypes.ElectronicDocumentManagement.Responses
{
    public class DocumentMetaDataResponse : DatasourceResponse
    {
        public DocumentMetaData MetaData { get; set; }
    }
}
