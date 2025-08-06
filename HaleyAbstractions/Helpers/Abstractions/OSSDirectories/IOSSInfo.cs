using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IOSSInfo  {
        string Name { get;  }
        string DisplayName { get; }
        string Guid { get; } //Name with which it is identified
        string Cuid { get; } //Collision resistance Unique Identifier
        bool TryValidate(out string message);
    }
}
