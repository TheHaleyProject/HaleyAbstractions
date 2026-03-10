using Haley.Enums;
using Haley.Models;
using System.IO;
using System.Threading.Tasks;
using System;

namespace Haley.Abstractions {
    /// <summary>
    /// Pure byte-storage abstraction. A provider knows only how to store, retrieve,
    /// and delete bytes at a given storage reference (path or object key).
    ///
    /// The provider owns ALL implementation-specific I/O details including:
    ///   - Ensuring storage prerequisites exist (e.g., directories for FileSystem)
    ///   - Conflict resolution (Skip / ReturnError / Replace / Revise)
    ///   - Extension-search fallback during reads (FileSystem: scan dir; B2/Azure: list prefix)
    ///
    /// The coordinator owns:
    ///   - Path / key generation (sharding, CUID)
    ///   - Security validation (path is within storage root)
    ///   - Indexer (DB) operations
    ///   - Format policy
    /// </summary>
    public interface IStorageProvider {
        string Key { get; set; }

        /// <summary>
        /// Writes the stream to the given storage reference.
        /// The provider handles conflict resolution and any necessary prerequisites.
        /// </summary>
        Task<ProviderWriteResult> WriteAsync(string storagePath, Stream dataStream, int bufferSize, ExistConflictResolveMode conflictMode);

        /// <summary>
        /// Opens a read stream for the given storage reference.
        /// When <paramref name="autoSearchExtension"/> is true and the reference has no extension,
        /// the provider may search for a matching entry by name.
        /// </summary>
        Task<ProviderReadResult> ReadAsync(string storagePath, bool autoSearchExtension = true, StringComparison nameComparison = StringComparison.OrdinalIgnoreCase);

        /// <summary>Deletes the content at the given storage reference.</summary>
        Task<bool> DeleteAsync(string storagePath);

        /// <summary>Returns true if content exists at the given storage reference.</summary>
        bool Exists(string storagePath);

        /// <summary>Returns the size in bytes of the content at the given storage reference.</summary>
        long GetSize(string storagePath);
    }
}
