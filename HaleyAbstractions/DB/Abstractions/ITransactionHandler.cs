using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface ITransactionHandler : IDBTransaction, IModuleExecution , IAdapterCrudHandler, IModuleStatus {
        IModuleArgs CreateDBInput(Enum cmd);
        IModuleArgs CreateDBInput(Enum cmd, IParameterBase args);
    }
}
