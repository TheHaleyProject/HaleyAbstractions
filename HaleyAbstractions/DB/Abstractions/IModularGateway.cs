using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace Haley.Abstractions {
    public interface IModularGateway : IAdapterGateway, IModuleExecution, IModuleStatus {
        Task<IFeedback> TryRegisterAssembly(Assembly assembly,string defaultAdapterKey = null);
        Task<IFeedback> TryRegisterAssembly<T>(string defaultAdapterKey = null) where T : class;
        Task<IFeedback> TryRegisterAssembly(Type type, string defaultAdapterKey = null);
        Task<IFeedback> TryRegisterAssembly(string defaultAdapterKey = null); //Just register the Calling Assembly
        Task<IFeedback> TryRegisterModule<M>()
           where M : class,IDBModule,new(); //Register a module
        Task<IFeedback> TryRegisterModule<M>(Dictionary<string, object> seed)
           where M : class, IDBModule, new(); //Register a module
        Task<IFeedback> TryRegisterModule<M>(M module, Dictionary<string, object> seed)
            where M : class,IDBModule; //Register a module
       
        void SetDefaultAdapterKey<E>(string adapterKey) where E : Enum;
        ITransactionHandler GetTransactionHandler<E>() where E : Enum;
    }
}