using Haley.Abstractions;
using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Haley.Models {
    public readonly struct DbExecutionLoad {
        public ITransactionHandler? Handler { get; }
        public CancellationToken Ct { get; }
        public bool ThrowErrors { get; }

        public DbExecutionLoad(CancellationToken ct, ITransactionHandler? th = null, bool throwErrors = true) {
            Ct = ct;
            Handler = th;
            ThrowErrors = throwErrors; //By default, lets throw.
        }
        public static DbExecutionLoad None => default;
    }
}
