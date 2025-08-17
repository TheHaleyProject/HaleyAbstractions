using Haley.Abstractions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Models
{
    public class ParameterBase : IdentityBase, IParameterBase {
        #region Attributes
        Dictionary<string, Dictionary<string, object>> _groupParameters = new Dictionary<string, Dictionary<string, object>>(StringComparer.InvariantCultureIgnoreCase);
        Dictionary<string, object> _parameters = new Dictionary<string, object>(StringComparer.InvariantCultureIgnoreCase);
        #endregion
        
        public IReadOnlyDictionary<string, object> Parameters => _parameters; //Return as readonly
        public IReadOnlyDictionary<string, object> GetGroupParameters(string key) {
            if (string.IsNullOrWhiteSpace(key) ||! _groupParameters.ContainsKey(key)) return null;
            IReadOnlyDictionary<string,object> result= _groupParameters[key];
            return result;
        }
        public object this[string key, string nested_key] {
            get {
                if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(nested_key) || !_groupParameters.ContainsKey(key)) return null;
                var groupP = _groupParameters[key];
                if (!groupP.ContainsKey(nested_key)) return null;
                return groupP[nested_key];
            }
        }
        public object this[string key] { 
            get {
                if (string.IsNullOrWhiteSpace(key) || !_parameters.ContainsKey(key)) return null; //Should we throw exception??
                return _parameters[key];
            }
        }

        #region Protected Methods
        protected virtual bool AddParameterInternal(string key, object value, bool replace = true) {
            if (string.IsNullOrWhiteSpace(key)) return false;
            if (_parameters.ContainsKey(key)) {
                if (!replace) return false;//Contains the key and replace is also not allowed.
                _parameters[key] = value;
            } else {
                //return _parameters.TryAdd(key, value); //For concurrency. At the moment, lets focus only on direct dictionaries
                _parameters.Add(key, value);
            }
            return true;
        }
        protected virtual void SetParametersInternal(Dictionary<string, object> parameters) {
            _parameters = new Dictionary<string, object>(parameters, StringComparer.InvariantCultureIgnoreCase);
        }
        protected void ClearParametersInternal(bool includeGroups = false) {
            _parameters = new Dictionary<string, object>(StringComparer.InvariantCultureIgnoreCase);
            if (includeGroups) {
                _groupParameters = new Dictionary<string, Dictionary<string, object>>(StringComparer.InvariantCultureIgnoreCase);
            }
        } 

        protected void AddParameterInternal(string groupKey, string key, object value, bool replace = true) {
            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(groupKey)) throw new ArgumentNullException($@"Group parameter add failed. GroupKey & Key are mandatory");
            if (!_groupParameters.ContainsKey(groupKey)) _groupParameters.Add(groupKey, new Dictionary<string, object>(StringComparer.InvariantCultureIgnoreCase));

            if (_groupParameters[groupKey].ContainsKey(key)) {
                if (!replace) return;//Contains the key and replace is also not allowed.
                _groupParameters[groupKey][key] = value;
            } else {
                //return _parameters.TryAdd(key, value); //For concurrency. At the moment, lets focus only on direct dictionaries
                _groupParameters[groupKey].Add(key, value);
            }
        }

        protected void SetParametersInternal(string groupKey, Dictionary<string, object> parameters) {
            if (string.IsNullOrWhiteSpace(groupKey)) throw new ArgumentNullException($@"Group parameter set failed. GroupKey is mandatory");
            if (parameters == null) parameters = new Dictionary<string, object>();

            if (!_groupParameters.ContainsKey(groupKey)) {
                _groupParameters.Add(groupKey, new Dictionary<string, object>(parameters, StringComparer.InvariantCultureIgnoreCase));
            } else {
                _groupParameters[groupKey] = new Dictionary<string, object>(parameters, StringComparer.InvariantCultureIgnoreCase);
            }
        }

        protected void ClearParametersInternal(string groupKey) {
            if (groupKey == null) return;
            if (!_groupParameters.ContainsKey(groupKey)) return;
            _groupParameters[groupKey].Clear();
        }

        #endregion

        public ParameterBase() : base() { }
        public ParameterBase(string key) : base(key) {
        }
    }
}
