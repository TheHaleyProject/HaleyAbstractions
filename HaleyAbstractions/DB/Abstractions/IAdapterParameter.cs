using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;

namespace Haley.Abstractions
{
    public interface IAdapterParameter : IParameterBase
    {
        ResultFilter Filter { get; set; }
        //string Conn { get; set; }
        string Query { get; set; }
        ILogger Logger { get; set; }
        Func<string, object, bool> ParamHandler { get; set; }
        string OutputName { get; set; }
        bool Prepare { get; set; }
    }
}
