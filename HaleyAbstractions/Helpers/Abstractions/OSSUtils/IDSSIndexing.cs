using System.Threading.Tasks;
using System;
using Haley.Models;
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IDSSIndexing {
        bool ThrowExceptions { get; }
        Task<IFeedback> RegisterClient(IOSSClient info);
        Task<IFeedback> RegisterModule(IOSSModule info);
        Task<IFeedback> RegisterWorkspace(IOSSWorkspace info);
        (long id,Guid guid) RegisterDocuments(IOSSRead request, IOSSControlled holder);
        Task<IFeedback> UpdateDocVersionInfo(string moduleCuid, IOSSFileRoute file, string callId = null);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, long id);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, string cuid);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, string wsCuid, string file_name, string dir_name = OSSConstants.DEFAULT_NAME, long dir_parent_id = 0);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, long wsId, string file_name, string dir_name = OSSConstants.DEFAULT_NAME, long dir_parent_id = 0);
        Task Validate();
        bool TryGetComponentInfo<T>(string key,out T component) where T : IOSSDirectory;
        bool TryAddInfo(IOSSDirectory dirInfo, bool replace = false);
        Task<IFeedback<string>> GetParentName(IOSSRead request);
    }
}
