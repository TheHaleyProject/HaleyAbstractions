using Haley.Enums;
using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IVaultReadRequest {
        string CallID { get;  }
        bool GenerateCallId();
        IVaultProfile Client { get; }
        IVaultProfile Module { get; }
        IVaultProfile Workspace { get; }
        string TargetPath { get; }
        string TargetName { get;  } //This could be like "a32fbc213..." but target path could be like "a3/2f/bc/..."
        bool ReadOnlyMode { get; }
        IVaultReadRequest SetMode(bool readOnly);
        IVaultReadRequest SetTargetName(string name);
        IVaultReadRequest SetTargetPath(string path);
        IVaultReadRequest SetFolder(IVaultFolderRoute folder);
        IVaultReadRequest SetComponent(IVaultProfile input, VaultComponent type);
        IVaultFolderRoute Folder { get; }
    }
}
