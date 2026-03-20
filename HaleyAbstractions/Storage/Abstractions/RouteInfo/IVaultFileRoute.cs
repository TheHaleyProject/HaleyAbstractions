
using System;

namespace Haley.Abstractions {
    public interface IVaultFileRoute : IVaultRoute {
        long Id { get; }
        string Cuid { get; set; }   // stored as compact-N string
        string Name { get; }
        int Version { get; set; }
        long Size { get; set; }
        string SaveAsName { get; set; }
        /// <summary>
        /// Temporary path on the staging provider (e.g. B2 object key).
        /// Populated only while the file is in staging (flags bit 4 set, bit 8 not yet set).
        /// Cleared by the background sync worker once the file is promoted to primary storage.
        /// </summary>
        string StagingPath { get; set; }
        IVaultFileRoute SetId(long id);
        IVaultFileRoute SetName(string name);
        IVaultFileRoute SetCuid(Guid cuid);
        IVaultFileRoute SetCuid(string cuid);
    }
}
