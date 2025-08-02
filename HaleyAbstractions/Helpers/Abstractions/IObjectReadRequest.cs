using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IObjectReadRequest {
        StorageNameInfo Client { get; }
        StorageNameInfo Module { get; }
        string TargetPath { get; }
        List<StorageRoute> StorageRoutes { get; }
    }
}
