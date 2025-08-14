using Haley.Enums;
using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IOSSRead {
        string CallID { get;  }
        bool GenerateCallId();
        IOSSControlled Client { get; }
        IOSSControlled Module { get; }
        IOSSControlled Workspace { get; }
        string TargetPath { get; }
        string TargetName { get;  } //This could be like "a32fbc213..." but target path could be like "a3/2f/bc/..."
        bool ReadOnlyMode { get; }
        IOSSRead SetMode(bool readOnly);
        IOSSRead SetTargetName(string name);
        IOSSRead SetTargetPath(string path);
        IOSSRead SetFolder(IOSSFolderRoute folder);
        IOSSRead SetComponent(IOSSControlled input, OSSComponent type);
        IOSSFolderRoute Folder { get; }
    }
}
