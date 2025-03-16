using Haley.Models;
using System;
using System.Threading.Tasks;

namespace Haley.Abstractions {

    public interface IDBModule<P> : IDBModule
        where P : IDBModuleInput {
    }

    public interface IDBModule : IDBModuleExecution {
        event EventHandler<DBModuleInitializedArgs> ModuleInitialized;
        Task<IFeedback> Initialize(); //will happen only once. //Why is this needed?
        bool IsInitialized { get; }
        Type ParameterType { get; }
        IFeedback GetInvocationMethodName(Enum cmd);
    }
}
