using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IStorageCoordinator : IStorageCRUD, IStorageRegistry, IFormatControl {
        IStorageCoordinator SetIndexer(IStorageIndexing service);
        IStorageCoordinator SetConfig(IStorageRegistryConfig config);
        bool ThrowExceptions { get; }
        string GetStorageRoot();
        Task<IStorageDirectoryResponse> GetDirectoryInfo(IStorageReadRequest input);
        Task<IFeedback<string>> GetParent(IStorageReadFileRequest input);
        Task<IStorageOperationResponse> CreateDirectory(IStorageReadRequest input, string rawname);
        Task<IFeedback> DeleteDirectory(IStorageReadRequest input, bool recursive);
        bool WriteMode { get; }
    }
}
