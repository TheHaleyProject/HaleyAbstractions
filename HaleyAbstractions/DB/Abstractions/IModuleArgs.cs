using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;

namespace Haley.Abstractions
{
    public interface IModuleArgs : IParameterBase {
        bool TransactionMode { get; }
        Enum Command { get;}
        object[] Arguments { get; }
        void ClearParameters();
        void ClearArguments();
    }
}
