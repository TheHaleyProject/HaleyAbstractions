using System;
using System.Data;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface ITransactionHandler : IDBTransaction, IModuleExecution , IAdapterCrudHandler, IModuleStatus {
        P CreateDBInput<P>() where P : IModuleArgs,new();
        P CreateDBInput<P>(P arg) where P : IModuleArgs;
    }
}
