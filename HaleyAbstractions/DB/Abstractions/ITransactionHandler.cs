using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface ITransactionHandler : IDBTransaction, IModuleExecution , IAdapterCrudHandler, IModuleStatus {
        IModuleArgs CreateDBInput();
        IModuleArgs CreateDBInput(IParameterBase args);
    }
}
