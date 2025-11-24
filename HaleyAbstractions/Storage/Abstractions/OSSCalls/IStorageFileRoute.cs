
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IStorageFileRoute : IStorageRoute{
        int Version { get; set; }
        long Size { get; set; }
        string SaveAsName { get; set; }
    }
}
