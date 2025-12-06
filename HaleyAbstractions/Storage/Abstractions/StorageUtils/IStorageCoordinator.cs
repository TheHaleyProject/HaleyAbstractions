using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IStorageCoordinator : IStorageOperations, IVaultRegistry, IDocFormatControl {
        IStorageCoordinator SetIndexer(IVaultIndexing service); // Important as the indexing is where we store all information in the database.
        IStorageCoordinator SetConfig(IVaultRegistryConfig config);
        bool ThrowExceptions { get; }
        string GetStorageRoot();
        Task<IVaultDirResponse> GetDirectoryInfo(IVaultReadRequest input);
        Task<IFeedback<string>> GetParent(IVaultFileReadRequest input);
        Task<IVaultResponse> CreateDirectory(IVaultReadRequest input, string rawname);
        Task<IFeedback> DeleteDirectory(IVaultReadRequest input, bool recursive);
        bool WriteMode { get; }
    }
}
