using Haley.Abstractions;
using Haley.Enums;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
using System.Xml.Linq;

namespace Haley.Abstractions {
    public interface IStorageProfile  {
        string Name { get;  }
        int Version { get; }//Which version is being used for this specific module
        StorageProfileMode Mode { get; }
        IStorageProvider Primary { get; }
        IStorageProvider Staging { get;  }
    }
}
