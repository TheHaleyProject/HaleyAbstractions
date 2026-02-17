using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;

namespace Haley.Abstractions {
    public interface ISqlCrudHandler {
        Task<object> Read(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<object> Scalar(IAdapterArgs input, params (string key, object value)[] parameters);
        Task<object> NonQuery(IAdapterArgs input,  params (string key, object value)[] parameters);
    }
}
