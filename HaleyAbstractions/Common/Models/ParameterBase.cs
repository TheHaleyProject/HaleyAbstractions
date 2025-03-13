using Haley.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Models
{
    public abstract class ParameterBase : IParameterBase{
        public string Key { get; set; } 
        public Dictionary<string, object> Parameters { get; protected set; }
        public ParameterBase(): this (null) { } 
        public ParameterBase(string key) {
            Key = key;
            Parameters = new Dictionary<string, object>(); } 
    }
}
