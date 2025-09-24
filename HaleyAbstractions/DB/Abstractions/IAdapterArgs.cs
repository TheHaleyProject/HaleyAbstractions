using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Haley.Abstractions
{
    public interface IAdapterArgs : IParameterBase
    {
        IAdapterArgs SetAdapterKey(string key);
        bool TransactionMode { get; }
        ResultFilter Filter { get; set; }
        bool JsonStringAsNode { get; set; }
        bool ExcludeDBInConString { get; set; }
        //string Conn { get; set; }
        object Query { get; set; }
        ILogger Logger { get; set; }
        Func<string, object, bool> ParamHandler { get; set; }
        string OutputName { get; set; }
        bool Prepare { get; set; }
        IAdapterArgs SetFilter(ResultFilter filter);
        IAdapterArgs UpsertParameter(string key, object value, bool replace = true);
        IAdapterArgs UpsertParameter(string groupKey, string key, object value, bool replace = true);
        IAdapterArgs SetParameters(Dictionary<string, object> parameters);
        IAdapterArgs SetParameters(string groupKey, Dictionary<string, object> parameters);
    }
}
