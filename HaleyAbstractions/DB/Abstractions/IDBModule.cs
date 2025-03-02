using Haley.Models;
using System;
using System.Threading.Tasks;

namespace Haley.Abstractions {

    public interface IDBModule<P> : IDBModule
        where P : IModuleParameter {
    }

    public interface IDBModule {
        Task<IFeedback> Execute(Enum cmd); //Just to enable storing in a common dictionary
        Task<IFeedback> Execute(Enum cmd, IModuleParameter parameter); //Just to enable storing in a common dictionary
        event EventHandler<DBModuleInitializedArgs> ModuleInitialized;
        Task<IFeedback> Initialize(); //will happen only once. //Why is this needed?
        bool IsInitialized { get; }
        Type ParameterType { get; }
        IFeedback GetInvocationMethodName(Enum cmd);
    }
}
