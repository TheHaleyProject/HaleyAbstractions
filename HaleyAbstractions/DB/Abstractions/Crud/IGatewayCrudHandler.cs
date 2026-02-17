using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IGatewayCrudHandler : IAdapterCrudHandler, ITypedCrudHandler {
        Task<int> ExecAsync(string key, string sql, DbExecutionLoad load = default, params DbArg[] args);
        Task<T?> ScalarAsync<T>(string key, string sql, DbExecutionLoad load = default, params DbArg[] args);
        Task<DbRow?> RowAsync(string key, string sql, DbExecutionLoad load = default, params DbArg[] args);
        Task<DbRows> RowsAsync(string key, string sql, DbExecutionLoad load = default, params DbArg[] args);
    }
}
