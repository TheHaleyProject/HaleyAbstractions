using Haley.Enums;
using System;
using System.IO;

namespace Haley.Abstractions {
    public interface IVaultFileWriteRequest : IVaultFileReadRequest, ICloneable {
        int BufferSize { get; set; }
        Stream FileStream { get; set; }
        string FileOriginalName { get; set; }
        IVaultFileWriteRequest SetFileOriginalName(string name);
        ExistConflictResolveMode ResolveMode { get;  }
    }
}
