using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IAdapterCrudHandler : ISqlCrudHandler {
        // With Args
        Task<IFeedback<DbRows>> ReadAsync(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<IFeedback<DbRow>> ReadSingleAsync(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<IFeedback<T>> ScalarAsync<T>(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<IFeedback<int>> NonQueryAsync(IAdapterArgs input,  params (string key, object value)[] parameters);
    }
}
