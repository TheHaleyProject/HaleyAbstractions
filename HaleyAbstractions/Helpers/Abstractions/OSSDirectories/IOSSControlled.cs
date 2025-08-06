using Haley.Abstractions;
using Haley.Enums;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
using System.Xml.Linq;

namespace Haley.Abstractions {
    public interface IOSSControlled :IOSSInfo {
        string SaveAsName { get; set; } //Should be the controlled name or a name compatible for the database 
        OSSControlMode ControlMode { get; set; } //Parsing or create mode is defined at application level?
        OSSParseMode ParseMode { get; set; } //If false, we fall back to parsing.
    }
}
