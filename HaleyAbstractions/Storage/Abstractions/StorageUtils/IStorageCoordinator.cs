using Haley.Enums;
using System.IO;
using System.Threading.Tasks;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IStorageCoordinator : IStorageOperations, IVaultManagement, IFileFormatPolicy,IStorageProviderRegistry {
        IStorageCoordinator SetIndexer(IVaultIndexing service); // Important as the indexing is where we store all information in the database.
        IStorageCoordinator SetConfig(IVaultRegistryConfig config);
        bool ThrowExceptions { get; }
        string GetStorageRoot();
        Task<IVaultDirResponse> GetDirectoryInfo(IVaultReadRequest input);
        Task<IFeedback<string>> GetParent(IVaultFileReadRequest input);
        Task<IVaultResponse> CreateDirectory(IVaultReadRequest input, string rawname);
        Task<IFeedback> DeleteDirectory(IVaultReadRequest input, bool recursive);
        bool WriteMode { get; }

        // ── Provider / profile configuration ─────────────────────────────────
        /// <summary>
        /// Sets the runtime provider routing for a registered module without requiring a
        /// DB round-trip. Call this at startup (e.g. in Program.cs) after registration.
        /// <paramref name="storageProviderKey"/> — key of the primary provider (e.g. "FileSystem", "B2").
        /// <paramref name="stagingProviderKey"/> — key of the staging provider, or null for none.
        /// <paramref name="mode"/> — upload routing mode; defaults to DirectSave.
        /// Both provider keys must already be registered with <c>AddProvider</c>.
        /// Returns false if the module CUID is not found in the indexer cache.
        /// </summary>
        bool ConfigureModuleProviders(string moduleCuid, string storageProviderKey,
            string stagingProviderKey = null, StorageProfileMode mode = StorageProfileMode.DirectSave);

        // ── Chunked Upload ────────────────────────────────────────────────────
        /// <summary>
        /// Registers the document in DB, creates a temp chunk directory, and returns the
        /// versionId + versionCuid needed for subsequent part uploads and completion.
        /// </summary>
        Task<IFeedback<(long versionId, string versionCuid)>> InitiateChunkedUpload(IVaultFileWriteRequest request, long chunkSizeMb, int totalParts);

        /// <summary>Writes one chunk part to the temp directory and records it in DB.</summary>
        Task<IFeedback> UploadChunkPart(long versionId, int partNumber, Stream chunkStream, string hash = null);

        /// <summary>Assembles all parts into the final storage path, finalizes DB records, and cleans up temp files.</summary>
        Task<IFeedback> CompleteChunkedUpload(long versionId, string finalHash = null);

        /// <summary>Returns how many parts have been received for an active session.</summary>
        Task<IFeedback> GetChunkStatus(long versionId);

        /// <summary>
        /// Cancels an active chunk session: removes it from the in-memory cache and
        /// deletes the temp chunk directory. DB chunk records are left orphaned for
        /// offline cleanup. Returns success even when no session exists (idempotent).
        /// </summary>
        Task<IFeedback> AbortChunkedUpload(long versionId);
    }
}
