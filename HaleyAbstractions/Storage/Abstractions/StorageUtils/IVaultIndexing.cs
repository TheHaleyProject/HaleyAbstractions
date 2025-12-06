using System.Threading.Tasks;
using System;
using Haley.Models;
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IVaultIndexing {
        bool ThrowExceptions { get; }
        Task<IFeedback> RegisterClient(IVaultClient info);
        Task<IFeedback> RegisterModule(IVaultModule info);
        Task<IFeedback> RegisterWorkspace(IVaultWorkSpace info);
        (long id,Guid guid) RegisterDocuments(IVaultReadRequest request, IVaultProfile holder);
        Task<IFeedback> UpdateDocVersionInfo(string moduleCuid, IVaultFileRoute file, string callId = null);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, long id);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, string cuid);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, string wsCuid, string file_name, string dir_name = VaultConstants.DEFAULT_NAME, long dir_parent_id = 0);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, long wsId, string file_name, string dir_name = VaultConstants.DEFAULT_NAME, long dir_parent_id = 0);
        Task Validate();
        bool TryGetComponentInfo<T>(string key,out T component) where T : IVaultComponent;
        bool TryAddInfo(IVaultComponent dirInfo, bool replace = false);
        Task<IFeedback<string>> GetParentName(IVaultFileReadRequest request);
    }
}
