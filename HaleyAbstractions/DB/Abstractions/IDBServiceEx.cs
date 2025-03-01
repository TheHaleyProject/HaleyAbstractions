using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IDBServiceEx : IDBService{
        Task<IFeedback> TryRegisterModule<M>()
           where M : IDBModule, new(); //Register a module
        Task<IFeedback> TryRegisterModule<M>(Dictionary<string, object> seed)
           where M : IDBModule, new(); //Register a module
        Task<IFeedback> TryRegisterModule<M>(M module, Dictionary<string, object> seed)
            where M : IDBModule; //Register a module
        Task<IFeedback> Execute<P>(P arg) where P : IModuleParameter;
        IFeedback GetCommandStatus<P>(Enum cmd) where P : IModuleParameter;
    }
}