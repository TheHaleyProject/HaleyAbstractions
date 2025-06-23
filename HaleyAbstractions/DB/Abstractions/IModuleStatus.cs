using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace Haley.Abstractions {
    public interface IModuleStatus {
        IDBModule GetModule<E>() where E : Enum;
        IDBModule GetModule(Type enumType);
        string GetAdapterKey<E>() where E : Enum;
        string GetAdapterKey(Type enumType);
        string GetAdapterKey();
        IFeedback GetCommandStatus(Enum cmd);
    }
}