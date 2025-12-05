using Haley.Enums;
using System;
using System.IO;

namespace Haley.Abstractions {
    public interface IStorageWriteRequest : IStorageReadFileRequest, ICloneable {
        int BufferSize { get; set; }
        Stream FileStream { get; set; }
        string FileOriginalName { get; set; }
        IStorageWriteRequest SetFileOriginalName(string name);
        StorageResolveMode ResolveMode { get;  }
    }
}
