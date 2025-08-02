using Haley.Enums;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IDiskStorageService : IObjectStorageService {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        Task<IDirectoryInfoResponse> GetDirectoryInfo(IObjectReadRequest input);
        Task<IObjectCreateResponse> CreateDirectory(IObjectReadRequest input, string rawname);
        Task<IFeedback> DeleteDirectory(IObjectReadRequest input, bool recursive);
        Task<IFeedback> RegisterClient(string name, bool iscontrolled, string password = null);
        Task<IFeedback> RegisterModule(string name, bool iscontrolled, string client_name,bool isclient_controlled); //If a client is not registered, we register it against "Default"
        Task<IFeedback> AuthorizeClient(object clientInfo, object clientSecret);
        string GetBasePath();
        bool EnableIndexing { get; set; }
        IDiskStorageService SetIndexer(IDiskStorageIndexing service);
    }
}
