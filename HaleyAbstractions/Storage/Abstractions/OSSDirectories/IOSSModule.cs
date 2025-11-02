using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IOSSModule : IOSSDirectory {
        IOSSInfo Client { get; set; }
        string DatabaseName { get; set; }
    }
}
