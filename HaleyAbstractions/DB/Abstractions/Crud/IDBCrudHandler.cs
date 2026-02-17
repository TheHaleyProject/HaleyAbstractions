using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;

namespace Haley.Abstractions {
    public interface IDBCrudHandler  {
        Task<object> Read(IParameterBase input,string query, params (string key, object value)[] parameters);
        Task<object> Scalar(IParameterBase input, string query, params (string key, object value)[] parameters);
        Task<object> NonQuery(IParameterBase input, string query, params (string key, object value)[] parameters);
    }
}
