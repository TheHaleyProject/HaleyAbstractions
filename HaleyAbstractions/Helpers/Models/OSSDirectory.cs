using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Models {
    public class OSSDirectory : OSSName {
        public string HashGuid { get; set; }
        public string Path { get; set; }
    }
}
