using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IOSSDirectory : IOSSControlled {
        string Path { get; set; }
    }
}
