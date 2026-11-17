using OpenDCP.Framework.Configuration.Model.Responses.Datasource;

namespace OpenDCP.Framework.DataTypes.ElectronicDocumentManagement.Responses
{
    public class DocumentResponse : DatasourceResponse
    {
        public byte[] Document { get; set; }
    }
}
