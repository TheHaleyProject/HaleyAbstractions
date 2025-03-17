using System;
using System.Data;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface ITransactionHandler : IDBTransaction, IDBModuleExecution , IAdapterCrudHandler, IDBModuleFetchStatus {
        P CreateDBInput<P>() where P : IDBModuleInput,new();
        P CreateDBInput<P>(P arg) where P : IDBModuleInput;
    }
}
