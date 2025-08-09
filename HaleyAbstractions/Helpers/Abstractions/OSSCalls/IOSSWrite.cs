using Haley.Enums;
using System;
using System.IO;

namespace Haley.Abstractions {
    public interface IOSSWrite : IOSSRead, ICloneable {
        int BufferSize { get; set; }
        Stream FileStream { get; set; }
        string FileOriginalName { get;  }
        IOSSWrite SetFileOriginalName(string name);
        OSSResolveMode ResolveMode { get;  }
    }
}
