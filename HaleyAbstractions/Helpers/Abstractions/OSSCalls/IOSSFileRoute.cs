
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IOSSFileRoute : IOSSRoute{
        int Version { get; set; }
        long Size { get; set; }
    }
}
