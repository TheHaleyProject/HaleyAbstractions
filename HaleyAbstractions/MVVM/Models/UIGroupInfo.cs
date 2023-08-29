using Haley.Abstractions;
using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Models {
    public sealed class UIGroupInfo  {
        public Type ViewModelType { get; set; }
        public Type ViewType { get; set; }
        public bool KeyDependent { get; set; }
        public RegisterMode Mode { get; set; }
       
        [HaleyIgnore]
        public UIGroupInfo(Type vm_type, Type view_type, bool groupByKey, RegisterMode mode) {
            Mode = mode;
            KeyDependent = groupByKey;
            ViewModelType = vm_type;
            ViewType = view_type;
        }
    }
}
