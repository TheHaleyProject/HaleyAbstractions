using Haley.Models;
using System;
using System.Threading.Tasks;

namespace Haley.Abstractions {

    //A module should be based on an Command Enum set. It would be easier that way. So, we just say which command points to which method inside a module. We just need to make sure we dont' repeat the command enum names.
    public interface IDBModule<P> : IDBModule
        where P : Enum {
    }

    public interface IDBModule : IModuleExecution {
        event EventHandler<DBModuleInitializedArgs> ModuleInitialized;
        Task<IFeedback> Initialize(); //will happen only once. //Why is this needed?
        bool IsInitialized { get; }
        Type ParameterType { get; }
        IFeedback GetInvocationMethodName(Enum cmd);
    }
}
