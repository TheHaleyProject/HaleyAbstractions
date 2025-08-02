using Haley.Enums;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IObjectStorageService {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        Task<IDirectoryInfoResponse> GetDirectoryInfo(IObjectReadRequest input);
        Task<IObjectCreateResponse> CreateDirectory(IObjectReadRequest input, string rawname);
        Task<IFeedback> DeleteDirectory(IObjectReadRequest input, bool recursive);
        Task<IObjectCreateResponse> Upload(IObjectUploadRequest input);
        Task<IFileStreamResponse> Download(IObjectReadRequest input, bool auto_search_extension = true);
        Task<IFeedback> Delete(IObjectReadRequest input);
        IFeedback Exists(IObjectReadRequest input);
        long GetSize(IObjectReadRequest input);
        bool WriteMode { get; }
    }
}
