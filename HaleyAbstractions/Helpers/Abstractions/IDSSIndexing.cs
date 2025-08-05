using System.Threading.Tasks;
using System;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDSSIndexing {
        Task<IFeedback> RegisterClient(OSSClientInfo info);
        Task<IFeedback> RegisterModule(OSSModuleInfo info);
        Task Validate();
        OSSClientInfo GetClientInfo(string name);
        OSSModuleInfo GetModuleInfo(string name,string client_name);
        bool TryAddInfo(OSSDirectory dirInfo);
        bool TryCreateModuleKey(string name, string client_name, out string modKey);
    }
}
