using Haley.Abstractions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Models
{
    public abstract class ParameterBase : IParameterBase {
        ConcurrentDictionary<string, object> _parameters = new ConcurrentDictionary<string, object>();
        public IReadOnlyDictionary<string, object> Parameters => _parameters; //Return as readonly
        public string Key { get; set; }
        protected bool AddParameterInternal (string key, object value, bool replace = true) {
            if (string.IsNullOrWhiteSpace(key)) return false;
            if (_parameters.ContainsKey(key)) {
                if (!replace) return false;//Contains the key and replace is also not allowed.
                _parameters[key] = value;
                return true;
            } else {
                return _parameters.TryAdd(key, value);
            }
        }
        protected virtual void SetParametersInternal(Dictionary<string,object> parameters) {
            _parameters = new ConcurrentDictionary<string, object>(parameters);
        }
        public string Id { get; }
        public ParameterBase() : this(null) { }
        public ParameterBase(string key) {
            Key = key;
            Id = Guid.NewGuid().ToString(); //Set a new GUID for this 
        }
    }
}
