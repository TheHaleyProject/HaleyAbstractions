using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IOSSInfo  {
        long Id { get; set; }
        string Name { get;  }
        string DisplayName { get; }
        string Guid { get; } //Name with which it is identified
        string Cuid { get; } //Collision resistance Unique Identifier
        //IOSSInfo SetCUID(string uid);
        IOSSInfo UpdateCUID(params string[] parentNames);
        bool TryValidate(out string message);
    }
}
