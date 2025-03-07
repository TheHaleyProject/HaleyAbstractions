﻿using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Haley.Abstractions
{
    public interface IDisposableDBConnection : IDisposable {
        DbCommand CreateCommand(string commandText = null);
    }
}
