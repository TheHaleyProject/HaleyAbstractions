using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Haley.Abstractions
{
    public interface IModuleArgs : IParameterBase {
        bool TransactionMode { get; }
        object[] Arguments { get; }
        void ClearParameters();
        void ClearParameters(string groupKey);
        IModuleArgs UpsertParameter(string key, object value, bool replace = true);
        IModuleArgs UpsertParameter(string groupKey, string key, object value, bool replace = true);
        IModuleArgs SetParameters(Dictionary<string, object> parameters);
        IModuleArgs SetParameters(string groupKey, Dictionary<string, object> parameters);
    }
}
