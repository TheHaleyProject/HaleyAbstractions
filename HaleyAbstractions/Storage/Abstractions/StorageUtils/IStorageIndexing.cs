using System.Threading.Tasks;
using System;
using Haley.Models;
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IStorageIndexing {
        bool ThrowExceptions { get; }
        Task<IFeedback> RegisterClient(IStorageClient info);
        Task<IFeedback> RegisterModule(IStorageModule info);
        Task<IFeedback> RegisterWorkspace(IStorageWorkspace info);
        (long id,Guid guid) RegisterDocuments(IStorageReadRequest request, IStorageInfo holder);
        Task<IFeedback> UpdateDocVersionInfo(string moduleCuid, IStorageFileRoute file, string callId = null);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, long id);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, string cuid);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, string wsCuid, string file_name, string dir_name = StorageConstants.DEFAULT_NAME, long dir_parent_id = 0);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, long wsId, string file_name, string dir_name = StorageConstants.DEFAULT_NAME, long dir_parent_id = 0);
        Task Validate();
        bool TryGetComponentInfo<T>(string key,out T component) where T : IStorageDirectory;
        bool TryAddInfo(IStorageDirectory dirInfo, bool replace = false);
        Task<IFeedback<string>> GetParentName(IStorageReadFileRequest request);
    }
}
