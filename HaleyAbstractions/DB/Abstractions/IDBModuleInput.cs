using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;

namespace Haley.Abstractions
{
    public interface IDBModuleInput : IParameterBase {
        bool TransactionModeOnly { get; }
        Enum Command { get;}
        object[] Arguments { get; }
        void ClearParameters();
    }
}
