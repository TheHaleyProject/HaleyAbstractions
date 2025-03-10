﻿using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface ISqlHandler :IDBCrudHandler, IDBTransaction {
        bool TransactionMode { get; }
        Task<object> ExecuteInternal(IDBInput input, Func<IDbCommand, Task<object>> processor, params (string key, object value)[] parameters);
    }
}
