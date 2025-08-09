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
        Task<IFeedback> UpdateDocumentInfo(string moduleCuid,IOSSFileRoute file, string savedName);
        Task Validate();
        bool TryGetComponentInfo<T>(string key,out T component) where T : IOSSDirectory;
        bool TryAddInfo(IOSSDirectory dirInfo, bool replace = false);
    }
}
