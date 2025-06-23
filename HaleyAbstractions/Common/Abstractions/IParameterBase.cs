using System.Collections.Generic;

namespace Haley.Abstractions{
    public interface IParameterBase : IIdentityBase {
        IReadOnlyDictionary<string, object> Parameters { get; }
        IReadOnlyDictionary<string, object> GetGroupParameters(string key);
    }
}