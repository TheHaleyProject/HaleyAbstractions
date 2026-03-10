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

        // ── Chunked Upload ────────────────────────────────────────────────────
        /// <summary>
        /// Registers the document in DB, creates a temp chunk directory, and returns the
        /// docVersionId + fileCuid needed for subsequent part uploads and completion.
        /// </summary>
        Task<IFeedback<(long docVersionId, string fileCuid)>> InitiateChunkedUpload(IVaultFileWriteRequest request, long chunkSizeMb, int totalParts);

        /// <summary>Writes one chunk part to the temp directory and records it in DB.</summary>
        Task<IFeedback> UploadChunkPart(long docVersionId, int partNumber, Stream chunkStream, string hash = null);

        /// <summary>Assembles all parts into the final storage path, finalizes DB records, and cleans up temp files.</summary>
        Task<IFeedback> CompleteChunkedUpload(long docVersionId, string finalHash = null);

        /// <summary>Returns how many parts have been received for an active session.</summary>
        Task<IFeedback> GetChunkStatus(long docVersionId);
    }
}
