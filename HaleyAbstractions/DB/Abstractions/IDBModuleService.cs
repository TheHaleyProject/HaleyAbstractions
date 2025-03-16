using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace Haley.Abstractions {
    public interface IDBModuleService : IDBService, IDBModuleExecution, IDBModuleFetchStatus {
        Task<IFeedback> TryRegisterAssembly(Assembly assembly);
        Task<IFeedback> TryRegisterModule<M>()
           where M : class,IDBModule,new(); //Register a module
        Task<IFeedback> TryRegisterModule<M>(Dictionary<string, object> seed)
           where M : class, IDBModule, new(); //Register a module
        Task<IFeedback> TryRegisterModule<M>(M module, Dictionary<string, object> seed)
            where M : class,IDBModule; //Register a module
        void SetDefaultAdapterKey(string adapterKey);
        void SetDefaultAdapterKey<P>(string adapterKey) where P : IDBModuleInput;
    }
}