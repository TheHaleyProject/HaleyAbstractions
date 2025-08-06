using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDiskStorageService : IObjectStorageService {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        IDSSConfig Config { get; }
        Task<IFeedback> RegisterClient(string name, string password = null);
        Task<IFeedback> RegisterClient(IOSSControlled name, string password = null);
        Task<IFeedback> RegisterModule(string name, string client_name = null); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterModule(IOSSControlled input, IOSSControlled client); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(string name, string client_name = null,string module_name = null); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(string name, string client_name, string module_name, OSSControlMode content_control = OSSControlMode.None, OSSParseMode content_pmode = OSSParseMode.Parse); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(IOSSControlled input, IOSSControlled client,IOSSControlled module, OSSControlMode content_control = OSSControlMode.None, OSSParseMode content_pmode = OSSParseMode.Parse); //If a client is not registered, we register it against "Default"
        Task<IFeedback> AuthorizeClient(object clientInfo, object clientSecret);
        string GetStorageRoot();
        IDiskStorageService SetIndexer(IDSSIndexing service);
    }
}
