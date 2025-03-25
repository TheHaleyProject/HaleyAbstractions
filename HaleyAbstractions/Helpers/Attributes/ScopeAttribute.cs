using System;

namespace Haley.Models {
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class ScopeAttribute : Attribute {
        public override string ToString() {
            return Value?.ToString();
        }
        public string Value { get; private set; }
        public ScopeAttribute(string value) { Value = value;  }
    }
}
