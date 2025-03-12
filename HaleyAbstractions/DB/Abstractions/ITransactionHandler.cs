using System;
using System.Data;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface ITransactionHandler : IDBTransaction, IDBModuleExecution {
        //Should be able to call modules, also directly call adapters, and most importantly based on transaction.
    }
}
