using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IOSSRead {
        OSSName Client { get; }
        OSSName Module { get; }
        string TargetPath { get; }
        string TargetName { get; } //This could be like "a32fbc213..." but target path could be like "a3/2f/bc/..."
        List<OSSRoute> StorageRoutes { get; }
    }
}
