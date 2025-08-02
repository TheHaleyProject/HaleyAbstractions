using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Haley.Models {
    public class StorageNameInfo {
        public string Name { get; set; }
        public bool IsControlled { get; set; }
        public StorageNameInfo() { }
        public StorageNameInfo(string name, bool iscontrolled) {
            Name = name;
            IsControlled = iscontrolled;
        }
    }
}
