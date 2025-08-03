using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDiskStorageService : IObjectStorageService {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        DSSConfig Config { get; }
        Task<IFeedback> RegisterClient(OSSName name, string password = null);
        Task<IFeedback> RegisterModule(OSSName name, OSSName client_name,OSSControlMode content_control = OSSControlMode.None, bool generate_cname = false); //If a client is not registered, we register it against "Default"
        Task<IFeedback> AuthorizeClient(object clientInfo, object clientSecret);
        string GetBasePath();
        bool EnableIndexing { get; set; }
        IDiskStorageService SetIndexer(IDSSIndexing service);
    }
}
