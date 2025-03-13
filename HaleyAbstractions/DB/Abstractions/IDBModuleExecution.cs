using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace Haley.Abstractions {
    public interface IDBModuleExecution {
        Task<IFeedback> Execute<P>(Enum cmd,P arg) where P : IParameterBase;
        IFeedback GetCommandStatus<P>(Enum cmd) where P : IParameterBase;
    }
}