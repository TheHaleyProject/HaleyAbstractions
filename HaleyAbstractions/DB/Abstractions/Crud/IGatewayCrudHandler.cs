using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IGatewayCrudHandler : IAdapterCrudHandler, ITypedCrudHandler {
        //Key and query
        Task<IFeedback<DbRows>> ReadAsync(string key, string query,  params (string key, object value)[] parameters);
        Task<IFeedback<DbRow>> ReadSingleAsync(string key, string query,  params (string key, object value)[] parameters);
        Task<IFeedback<T>> ScalarAsync<T>(string key, string query,  params (string key, object value)[] parameters);
        Task<IFeedback<int>> NonQueryAsync(string key, string query,  params (string key, object value)[] parameters);
    }
}
