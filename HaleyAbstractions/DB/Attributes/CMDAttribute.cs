using System;

namespace Haley.Models {

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class CMDAttribute : Attribute {
        public object Name { get; set; }
        public bool ParametersRequired { get; set; }
        public CMDAttribute(object name, bool paramsRequired = true) {
            Name = name;
            ParametersRequired = paramsRequired;
        }
    }
}