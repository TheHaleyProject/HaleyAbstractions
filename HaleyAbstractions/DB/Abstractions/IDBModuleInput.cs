using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;

namespace Haley.Abstractions
{
    public interface IDBModuleInput : IParameterBase {
        bool TransactionMode { get; }
        Enum Command { get;}
        object[] Arguments { get; }
        void ClearParameters();
        void ClearArguments();
    }
}
