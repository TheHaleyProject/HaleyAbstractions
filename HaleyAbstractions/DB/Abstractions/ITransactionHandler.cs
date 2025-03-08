using System;
using System.Data;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface ITransactionHandler : IDBAdapter, IDBTransaction {
        
    }
}
