using System.Threading.Tasks;
using System;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDSSIndexing {
        Task<IFeedback> RegisterClient(IOSSClient info);
        Task<IFeedback> RegisterModule(IOSSModule info);
        Task Validate();
        IOSSClient GetClientInfo(string name);
        IOSSModule GetModuleInfo(string name,string client_name);
        bool TryAddInfo(IOSSDirectory dirInfo);
        bool TryCreateModuleKey(string name, string client_name, out string modKey);
    }
}
