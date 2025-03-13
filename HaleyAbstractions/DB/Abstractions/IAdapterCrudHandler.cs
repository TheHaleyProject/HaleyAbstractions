using Haley.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;

namespace Haley.Abstractions {
    public interface IAdapterCrudHandler {
        Task<object> Read(IAdapterParameter input, params (string key, object value)[] parameters);
        Task<object> Scalar(IAdapterParameter input, params (string key, object value)[] parameters);
        Task<object> NonQuery(IAdapterParameter input,  params (string key, object value)[] parameters);
    }
}
