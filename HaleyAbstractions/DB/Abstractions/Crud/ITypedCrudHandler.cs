using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using Haley.Models;

namespace Haley.Abstractions {
    public interface ITypedCrudHandler {
        public Task<int> ExecAsync(string sql, DbExecutionLoad load = default, params DbArg[] args);
        public Task<T?> ScalarAsync<T>(string sql, DbExecutionLoad load = default, params DbArg[] args);
        public Task<IReadOnlyList<T>> ListAsync<T>(string sql, DbExecutionLoad load = default, params DbArg[] args);
        public Task<DbRow?> RowAsync(string sql, DbExecutionLoad load = default, params DbArg[] args);
        public Task<DbRows> RowsAsync(string sql, DbExecutionLoad load = default, params DbArg[] args);
    }
}
