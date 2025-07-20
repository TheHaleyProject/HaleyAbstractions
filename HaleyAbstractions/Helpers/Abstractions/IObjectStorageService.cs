using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IObjectStorageService {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        Task<IObjectCreateResponse> Upload(IObjectUploadRequest input);
        Task<IFileStreamResponse> Download(IObjectReadRequest input, bool auto_search_extension = true);
        Task<IFeedback> Delete(IObjectReadRequest input);
        IFeedback Exists(IObjectReadRequest input);
        long GetSize(IObjectReadRequest input);
        Task<IDirectoryInfoResponse> GetDirectoryInfo(IObjectReadRequest input);
        Task<IObjectCreateResponse> CreateDirectory(IObjectReadRequest input, string rawname);
        Task<IFeedback> DeleteDirectory(IObjectReadRequest input, bool recursive);
        Task<IFeedback> AuthorizeClient(object clientInfo, object clientSecret);
        string GetBasePath();
        //When you initiate with should not be based on Adapter gateway. It should be a separate service. The consumer should be able to inject any potential service. Not necssarily in localhost, may be externally also it could be present.
        void SetIndexingService(IStorageIndexingService service);
        IStorageIndexingService Indexer { get; }
        bool EnableIndexing { get; set; }
    }
}
