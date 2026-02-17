using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDALUtilBase : IAsyncDisposable, ITypedCrudHandler {
        ITransactionHandler CreateNewTransaction();
    }
}
