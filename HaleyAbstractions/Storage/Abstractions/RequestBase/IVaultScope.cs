using Haley.Enums;
using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IVaultScope {
        //The upload or the download request is scoped to this specific request.
        IVaultInfo Client { get; }
        IVaultInfo Module { get; }
        IVaultInfo Workspace { get; }
        IVaultFolderRoute Folder { get; }
    }
}
