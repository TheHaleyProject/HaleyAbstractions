using Haley.Enums;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IStorageCRUD {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        Task<IStorageOperationResponse> Upload(IStorageWriteRequest input);
        Task<IStorageStreamResponse> Download(IStorageReadFileRequest input, bool auto_search_extension = true);
        Task<IStorageStreamResponse> Download(IStorageFileRoute input, bool auto_search_extension = true);
        Task<IFeedback> Delete(IStorageReadFileRequest input);
        IFeedback Exists(IStorageReadRequest input, bool isFilePath = false);
        long GetSize(IStorageReadRequest input);
    }
}
