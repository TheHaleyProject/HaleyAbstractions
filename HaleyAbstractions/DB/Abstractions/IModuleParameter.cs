using System.Collections.Generic;

namespace Haley.Abstractions{
    public interface IModuleParameter {
        string AdapterKey { get; set; }
        Dictionary<string,string> QueryParams { get; }
    }
}