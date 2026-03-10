using System.Threading.Tasks;
using System;
using Haley.Models;
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IVaultIndexing {
        bool ThrowExceptions { get; }
        Task<IFeedback> RegisterClient(IVaultClient info);
        Task<IFeedback> RegisterModule(IVaultModule info);
        Task<IFeedback> RegisterWorkspace(IVaultWorkSpace info);
        Task<(long id, Guid guid)> RegisterDocuments(IVaultReadRequest request, IVaultInfo holder);
        Task<IFeedback> UpdateDocVersionInfo(string moduleCuid, IVaultFileRoute file, string callId = null);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, long id);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, string cuid);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, string wsCuid, string file_name, string dir_name = VaultConstants.DEFAULT_NAME, long dir_parent_id = 0);
        Task<IFeedback> GetDocVersionInfo(string moduleCuid, long wsId, string file_name, string dir_name = VaultConstants.DEFAULT_NAME, long dir_parent_id = 0);
        Task Validate();
        bool TryGetComponentInfo<T>(string key, out T component) where T : IVaultObject;
        bool TryAddInfo(IVaultObject dirInfo, bool replace = false);
        Task<IFeedback<string>> GetParentName(IVaultFileReadRequest request);
        // Chunking
        Task<IFeedback> UpsertChunkInfo(string moduleCuid, long docVersionId, long chunkSizeMb, int totalParts, string chunkFolderName, string chunkFolderPath, bool isCompleted = false, string callId = null);
        Task<IFeedback> UpsertChunkPart(string moduleCuid, long docVersionId, long partNumber, int sizeMb, string hash = null, string callId = null);
        Task<IFeedback> MarkChunkCompleted(string moduleCuid, long docVersionId, string callId = null);
        // Storage profiles
        Task<long> UpsertProvider(string name, string description = null);
        Task<long> UpsertProfile(string name);
        Task<long> UpsertProfileInfo(int profileId, int version, int mode, int? storageProviderId, int? stagingProviderId, string metadataJson);
        Task<bool> SetModuleStorageProfile(string moduleCuid, int profileId);
    }
}
