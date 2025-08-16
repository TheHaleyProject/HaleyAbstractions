using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Haley.Abstractions
{
    public interface IModuleArgs : IParameterBase {
        bool IsDevelopment { get; }
        bool TransactionMode { get; }
        Dictionary<string,object> Arguments { get; }
        void ClearParameters();
        void ClearParameters(string groupKey);
        IModuleArgs UpsertParameter(string key, object value, bool replace = true);
        IModuleArgs UpsertParameter(string groupKey, string key, object value, bool replace = true);
        IModuleArgs SetParameters(Dictionary<string, object> parameters);
        IModuleArgs SetParameters(string groupKey, Dictionary<string, object> parameters);
        IModuleArgs SetArguments(params (string, object)[] arguments);
    }
}
