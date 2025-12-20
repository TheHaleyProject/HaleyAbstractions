using Haley.Abstractions;
using Haley.Enums;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
using System.Xml.Linq;

namespace Haley.Abstractions {
    public interface IVaultInfo :IVaultBase {
        string StorageName { get; set; } //Should be the controlled name or a name compatible for the database 
        int Version { get; set; }
    }
}
