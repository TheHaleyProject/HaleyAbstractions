using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Haley.Abstractions{
    public interface IParameterBase : IIdentityBase {
        IReadOnlyDictionary<string, object> Parameters { get; }
        IReadOnlyDictionary<string, object> GetGroupParameters(string key);
        object this[string key] { get;  }
        object this[string key, string nested_key] { get; }
    }
}