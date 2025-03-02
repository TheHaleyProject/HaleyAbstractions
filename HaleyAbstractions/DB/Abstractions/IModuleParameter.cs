using System.Collections.Generic;

namespace Haley.Abstractions{
    public interface IModuleParameter {
        Dictionary<string,string> QueryParams { get; }
    }
}