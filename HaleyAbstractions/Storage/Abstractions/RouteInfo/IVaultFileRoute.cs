
using System;

namespace Haley.Abstractions {
    public interface IVaultFileRoute : IVaultRoute {
        long Id { get; }
        string Cuid { get; set; }   // stored as compact-N string
        string Name { get; }
        int Version { get; set; }
        long Size { get; set; }
        string SaveAsName { get; set; }
        IVaultFileRoute SetId(long id);
        IVaultFileRoute SetName(string name);
        IVaultFileRoute SetCuid(Guid cuid);
        IVaultFileRoute SetCuid(string cuid);
    }
}
