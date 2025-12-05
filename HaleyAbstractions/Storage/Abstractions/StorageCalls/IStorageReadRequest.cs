using Haley.Enums;
using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IStorageReadRequest {
        string CallID { get;  }
        bool GenerateCallId();
        IStorageInfo Client { get; }
        IStorageInfo Module { get; }
        IStorageInfo Workspace { get; }
        string TargetPath { get; }
        string TargetName { get;  } //This could be like "a32fbc213..." but target path could be like "a3/2f/bc/..."
        bool ReadOnlyMode { get; }
        IStorageReadRequest SetMode(bool readOnly);
        IStorageReadRequest SetTargetName(string name);
        IStorageReadRequest SetTargetPath(string path);
        IStorageReadRequest SetFolder(IStorageFolderRoute folder);
        IStorageReadRequest SetComponent(IStorageInfo input, StorageComponent type);
        IStorageFolderRoute Folder { get; }
    }
}
