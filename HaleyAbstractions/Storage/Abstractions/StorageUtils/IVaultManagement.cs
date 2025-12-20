using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;
using Microsoft.Extensions.Configuration;

namespace Haley.Abstractions {
    public interface IVaultManagement {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        IVaultRegistryConfig Config { get; }
        Task<IFeedback> RegisterClient(string client_name = null, string password = null);
        Task<IFeedback> RegisterModule(string module_name = null, string client_name = null); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(string workspace_name = null, string client_name = null, string module_name = null, VaultControlMode content_control = VaultControlMode.Number, VaultParseMode content_pmode = VaultParseMode.Generate, bool is_virtual = false); //If a client is not registered, we register it against "Default"

        Task<IFeedback> RegisterClient(IVaultInfo client, string password = null);
        Task<IFeedback> RegisterModule(IVaultInfo module, IVaultInfo client); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterWorkSpace(IVaultInfo wspace, IVaultInfo client,IVaultInfo module, VaultControlMode content_control = VaultControlMode.Number, VaultParseMode content_pmode = VaultParseMode.Generate); //If a client is not registered, we register it against "Default"
        Task<IFeedback> RegisterFromSource(IConfigurationSection section = null);
        Task<IFeedback> AuthorizeClient(object clientInfo, object clientSecret);
    }
}
