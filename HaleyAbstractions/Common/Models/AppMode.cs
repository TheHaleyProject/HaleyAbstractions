using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Models {
    public class AppMode {
        public bool IsDevelopment { get; set; }
        public bool DebugMode { get; set; }
        public bool ThrowExceptions { get; set; }

        public override string ToString() {
            return $@"Dev={IsDevelopment} | Debug={DebugMode} | ThrowExceptions={ThrowExceptions}";
        }
    }
}
