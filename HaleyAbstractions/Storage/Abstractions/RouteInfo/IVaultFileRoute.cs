
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IVaultFileRoute : IVaultRoute{
        int Version { get; set; }
        long Size { get; set; }
        string SaveAsName { get; set; }
    }
}
