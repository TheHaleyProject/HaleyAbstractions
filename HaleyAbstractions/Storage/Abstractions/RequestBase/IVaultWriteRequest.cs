using Haley.Enums;
using System;
using System.IO;

namespace Haley.Abstractions {
    public interface IVaultWriteRequest : IVaultFileReadRequest, ICloneable {
        int BufferSize { get; set; }
        Stream FileStream { get; set; }
        string FileOriginalName { get; set; }
        IVaultWriteRequest SetFileOriginalName(string name);
        ExistConflictResolveMode ResolveMode { get;  }
    }
}
