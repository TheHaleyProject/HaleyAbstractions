using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace Haley.Abstractions {
    public interface IModuleExecution {
        Task<IFeedback> Execute(Enum cmd);
        Task<IFeedback> Execute(Enum cmd, IParameterBase args); 
    }
}