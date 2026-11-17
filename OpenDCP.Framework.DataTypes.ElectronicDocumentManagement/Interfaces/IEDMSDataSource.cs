using OpenDCP.Framework.DataTypes.ElectronicDocumentManagement.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDCP.Framework.DataTypes.ElectronicDocumentManagement.Interfaces
{
    public interface IEDMSDataSource
    {
        Task<DocumentMetaDataResponse> GetDocumentMetadataAsync(string documentId, CancellationToken cancellationToken = default);
        Task<DocumentResponse> GetDocumentAsync(string documentId, CancellationToken cancellationToken = default);
    }
}
