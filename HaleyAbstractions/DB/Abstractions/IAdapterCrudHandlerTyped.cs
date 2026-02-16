using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IAdapterCrudHandlerTyped : IAdapterCrudHandler {
        //Key and query
        Task<IFeedback<DbRows>> ReadAsync(string key, string query,  params (string key, object value)[] parameters);
        Task<IFeedback<DbRow>> ReadSingleAsync(string key, string query,  params (string key, object value)[] parameters);
        Task<IFeedback<T>> ScalarAsync<T>(string key, string query,  params (string key, object value)[] parameters);
        Task<IFeedback<int>> NonQueryAsync(string key, string query,  params (string key, object value)[] parameters);

        // With Args
        Task<IFeedback<DbRows>> ReadAsync(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<IFeedback<DbRow>> ReadSingleAsync(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<IFeedback<T>> ScalarAsync<T>(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<IFeedback<int>> NonQueryAsync(IAdapterArgs input,  params (string key, object value)[] parameters);

        //With Execution load
        Task<int> ExecAsync(string key, string sql, DbExecutionLoad load = default, params DbArg[] args);
        Task<T?> ScalarAsync<T>(string key, string sql, DbExecutionLoad load = default, params DbArg[] args);
        Task<DbRow?> RowAsync(string key, string sql, DbExecutionLoad load = default, params DbArg[] args);
        Task<DbRows> RowsAsync(string key, string sql, DbExecutionLoad load = default, params DbArg[] args);
    }
}
