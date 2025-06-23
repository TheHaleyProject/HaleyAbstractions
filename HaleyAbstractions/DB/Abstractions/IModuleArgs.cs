using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;

namespace Haley.Abstractions
{
    public interface IModuleArgs : IParameterBase {
        bool TransactionMode { get; }
        object[] Arguments { get; }
        void ClearParameters();
    }
}
