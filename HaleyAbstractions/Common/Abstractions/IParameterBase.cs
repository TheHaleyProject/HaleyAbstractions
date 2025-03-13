using System.Collections.Generic;

namespace Haley.Abstractions{
    public interface IParameterBase {
        string Key { get; set; }
        Dictionary<string,object> Parameters { get; }
    }
}