using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDiskStorageService : IObjectStorageService {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        IDSSConfig Config { get; }
        Task<IFeedback> RegisterClient(string name, string password = null);
        Task<IFeedback> RegisterClient(IOSSCtrld name, string password = null);
        Task<IFeedback> RegisterModule(string name, string client_name = IOSSCtrld.DEFAULTNAME); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterModule(IOSSCtrld input, IOSSCtrld client_input); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(string name, string client_name = IOSSCtrld.DEFAULTNAME,string module_name = IOSSCtrld.DEFAULTNAME); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(string name, string client_name = IOSSCtrld.DEFAULTNAME, string module_name = IOSSCtrld.DEFAULTNAME, OSSControlMode content_control = OSSControlMode.None, OSSParseMode content_pmode = OSSParseMode.Parse); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(IOSSCtrld input, IOSSCtrld client_input,IOSSCtrld modul_input, OSSControlMode content_control = OSSControlMode.None, OSSParseMode content_pmode = OSSParseMode.Parse); //If a client is not registered, we register it against "Default"
        Task<IFeedback> AuthorizeClient(object clientInfo, object clientSecret);
        string GetStorageRoot();
        bool EnableIndexing { get; set; }
        IDiskStorageService SetIndexer(IDSSIndexing service);
    }
}
