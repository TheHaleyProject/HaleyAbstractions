using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IObjectReadRequest {
        string ObjectLocation { get; }
        List<StorageRoute> StorageRoutes { get; }
    }
}
