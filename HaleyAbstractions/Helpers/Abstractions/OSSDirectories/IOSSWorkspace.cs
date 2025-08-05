using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IOSSWorkspace : IOSSDirectory {
        IOSSInfo Client { get; set; }
        IOSSInfo Module { get; set; }
        string DatabaseName { get; set; }
        OSSControlMode ContentControl { get; set; }
        OSSParseMode ContentParse { get; set; }
        void Assert();
    }
}
