using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace Haley.Abstractions {
    public interface IDBModuleFetchStatus {
        IDBModule GetModule<P>() where P : IDBModuleInput;
        string GetAdapterKey<P>() where P : IDBModuleInput;
        string GetAdapterKey();
        IFeedback GetCommandStatus<P>(Enum cmd) where P : IDBModuleInput;
    }
}