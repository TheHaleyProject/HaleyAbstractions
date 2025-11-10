using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;

namespace Haley.Abstractions {
    public interface IAdapterCrudHandlerEx {
        Task<IFeedback<List<Dictionary<string, object>>>> ReadAsync(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<IFeedback<List<Dictionary<string, object>>>> ReadAsync(string key, string query, params (string key, object value)[] parameters);
        Task<IFeedback<Dictionary<string, object>>> ReadSingleAsync(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<IFeedback<Dictionary<string, object>>> ReadSingleAsync(string key, string query, params (string key, object value)[] parameters);
        Task<IFeedback<T>> ScalarAsync<T>(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<IFeedback<T>> ScalarAsync<T>(string key, string query, params (string key, object value)[] parameters);
        Task<IFeedback<bool>> NonQueryAsync(IAdapterArgs input,  params (string key, object value)[] parameters);
        Task<IFeedback<bool>> NonQueryAsync(string key, string query, params (string key, object value)[] parameters);
    }
}
