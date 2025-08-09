using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDSSClientManagement {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        IDSSConfig Config { get; }
        Task<IFeedback> RegisterClient(string client_name = null, string password = null);
        Task<IFeedback> RegisterModule(string module_name = null, string client_name = null); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(string workspace_name = null, string client_name = null, string module_name = null, OSSControlMode content_control = OSSControlMode.Number, OSSParseMode content_pmode = OSSParseMode.Generate, bool is_virtual = false); //If a client is not registered, we register it against "Default"

        Task<IFeedback> RegisterClient(IOSSControlled client, string password = null);
        Task<IFeedback> RegisterModule(IOSSControlled module, IOSSControlled client); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(IOSSControlled wspace, IOSSControlled client,IOSSControlled module, OSSControlMode content_control = OSSControlMode.Number, OSSParseMode content_pmode = OSSParseMode.Generate); //If a client is not registered, we register it against "Default"

        Task<IFeedback> AuthorizeClient(object clientInfo, object clientSecret);
    }
}
