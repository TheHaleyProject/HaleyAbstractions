using Haley.Abstractions;
using Haley.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Haley.Models {
    public class AdapterArgs : ParameterBase, IAdapterArgs {
        public IDBAdapter Adapter { get; set; }
        public bool IsDevelopment { get; set; }
        public ResultFilter Filter { get; set; }
        public object Query { get; set; }
        public bool ExcludeDBInConString { get; set; }
        public ILogger  Logger { get; set; }
        public bool ReturnsResult { get; set; }
        public bool IsScalar { get; set; }
        public Func<string, object, bool> ParamHandler { get; set; }
        public string OutputName { get; set; }
        public bool Prepare { get; set; } = false;
        public bool TransactionMode { get; set; }
        public IAdapterArgs SetAdapterKey(string key) {
            Key = key;
            return this;
        }

        public IAdapterArgs SetFilter(ResultFilter filter) {
            Filter = filter;
            return this;
        }

        public IAdapterArgs SetParameters(Dictionary<string, object> parameters) {
             SetParametersInternal(parameters);
            return this;
        }

        public IAdapterArgs UpsertParameter(string key, object value, bool replace = true) {
            AddParameterInternal(key, value, replace);
            return this;
        }
        public IAdapterArgs UpsertParameter(string groupKey, string key, object value, bool replace = true) {
            AddParameterInternal(groupKey, key, value, replace);
            return this;
        }
        public IAdapterArgs SetParameters(string groupKey, Dictionary<string, object> parameters) {
            SetParametersInternal(groupKey, parameters);
            return this;
        }
        public AdapterArgs(string key) :base (key){
            Filter = ResultFilter.None; }
    }
}
