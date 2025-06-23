using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace Haley.Abstractions {
    public interface IDBModuleService : IDBService, IModuleExecution, IModuleStatus {
        Task<IFeedback> TryRegisterAssembly(Assembly assembly,string defaultAdapterKey = null);
        Task<IFeedback> TryRegisterAssembly(string defaultAdapterKey = null); //Just register the Calling Assembly
        Task<IFeedback> TryRegisterModule<M>()
           where M : class,IDBModule,new(); //Register a module
        Task<IFeedback> TryRegisterModule<M>(Dictionary<string, object> seed)
           where M : class, IDBModule, new(); //Register a module
        Task<IFeedback> TryRegisterModule<M>(M module, Dictionary<string, object> seed)
            where M : class,IDBModule; //Register a module
        void SetDefaultAdapterKey(string adapterKey);
        void SetDefaultAdapterKey<E>(string adapterKey) where E : Enum;
        ITransactionHandler GetTransactionHandler<E>() where E : Enum;
    }
}