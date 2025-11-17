using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Models {
    public class AppFlags {
        public bool DevEnvironment { get; set; }
        public bool Mock { get; set; } = true; //By default Mock is always true //We control few things like emails etc, and modify the settings accordingly. 
        public bool ConsoleLog { get; set; }
        public bool Debug { get; set; }
        public bool ThrowExceptions { get; set; }

        public override string ToString() {
            return $@"Dev={DevEnvironment} | Mock={Mock} | ConsoleLog={ConsoleLog} | Debug={Debug} | ThrowExceptions={ThrowExceptions}";
        }
    }
}
