using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace Haley.Abstractions {
    public interface IModuleStatus {
        IDBModule GetModule<P>() where P : IModuleArgs;
        string GetAdapterKey<P>() where P : IModuleArgs;
        string GetAdapterKey();
        IFeedback GetCommandStatus<P>(Enum cmd) where P : IModuleArgs;
    }
}