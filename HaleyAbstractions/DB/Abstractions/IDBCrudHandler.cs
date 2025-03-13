using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;

namespace Haley.Abstractions {
    public interface IDBCrudHandler {
        Task<object> Read(IDBInput input, params (string key, object value)[] parameters);
        Task<object> Read(string adapterkey,string query, params (string key, object value)[] parameters);
        Task<object> Scalar(IDBInput input, params (string key, object value)[] parameters);
        Task<object> Scalar(string adapterkey, string query, params (string key, object value)[] parameters);
        Task<object> NonQuery(IDBInput input,  params (string key, object value)[] parameters);
        Task<object> NonQuery(string adapterkey, string query, params (string key, object value)[] parameters);
    }
}
