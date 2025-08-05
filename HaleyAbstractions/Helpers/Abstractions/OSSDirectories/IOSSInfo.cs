using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IOSSInfo  {
        string Name { get;  }
        string DisplayName { get; set; }
        string Guid { get; set; } //Name with which it is identified
    }
}
