using System.Threading.Tasks;
using System;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDSSIndexing {
        Task<IFeedback> RegisterClient(IOSSClient info);
        Task<IFeedback> RegisterModule(IOSSModule info);
        Task<IFeedback> RegisterWorkspace(IOSSWorkspace info);
        long IDGenerator(IOSSWorkspace wsInfo, string file_name);
        Guid GUIDGenerator(IOSSWorkspace wsInfo, string file_name);
        Task Validate();
        bool TryGetComponentInfo<T>(string key,out T component) where T : IOSSDirectory;
        bool TryAddInfo(IOSSDirectory dirInfo, bool replace = false);
    }
}
