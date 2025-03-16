using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace Haley.Abstractions {
    public interface IDBModuleExecution {
        Task<IFeedback> Execute<P>(P arg) where P : IDBModuleInput;
    }
}