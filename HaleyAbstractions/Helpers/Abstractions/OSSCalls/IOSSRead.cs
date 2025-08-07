using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IOSSRead {
        IOSSControlled Client { get; }
        IOSSControlled Module { get; }
        IOSSControlled Workspace { get; }
        string TargetPath { get; }
        int Version { get; }
        string TargetName { get; } //This could be like "a32fbc213..." but target path could be like "a3/2f/bc/..."
        IOSSRoute Route { get; }
    }
}
