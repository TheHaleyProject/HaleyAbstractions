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
        void UpsertParameter(string key, object value, bool replace = true);
        void UpsertParameter(string groupKey, string key, object value, bool replace = true);
        void SetParameters(Dictionary<string, object> parameters);
        void SetParameters(string groupKey, Dictionary<string, object> parameters);
    }
}
