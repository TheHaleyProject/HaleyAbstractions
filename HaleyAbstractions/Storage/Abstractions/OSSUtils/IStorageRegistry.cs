using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;
using Microsoft.Extensions.Configuration;

namespace Haley.Abstractions {
    public interface IStorageRegistry {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        IStorageRegistryConfig Config { get; }
        Task<IFeedback> RegisterClient(string client_name = null, string password = null);
        Task<IFeedback> RegisterModule(string module_name = null, string client_name = null); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(string workspace_name = null, string client_name = null, string module_name = null, StorageControlMode content_control = StorageControlMode.Number, StorageParseMode content_pmode = StorageParseMode.Generate, bool is_virtual = false); //If a client is not registered, we register it against "Default"

        Task<IFeedback> RegisterClient(IStorageInfo client, string password = null);
        Task<IFeedback> RegisterModule(IStorageInfo module, IStorageInfo client); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(IStorageInfo wspace, IStorageInfo client,IStorageInfo module, StorageControlMode content_control = StorageControlMode.Number, StorageParseMode content_pmode = StorageParseMode.Generate); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterFromSource(IConfigurationSection section = null);
        Task<IFeedback> AuthorizeClient(object clientInfo, object clientSecret);
    }
}
