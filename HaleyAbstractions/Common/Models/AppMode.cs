using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Models {
    public class AppMode {
        public bool EnvInDevelopment { get; set; }
        public bool AppInDevelopment { get; set; }
        public bool ThrowExceptions { get; set; }
    }
}
