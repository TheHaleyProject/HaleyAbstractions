using Haley.Enums;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IObjectStorageService {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        bool ThrowExceptions { get; }
        string GetStorageRoot();
        Task<IOSSDirResponse> GetDirectoryInfo(IOSSRead input);
        Task<IFeedback<string>> GetParent(IOSSReadFile input);
        Task<IOSSResponse> CreateDirectory(IOSSRead input, string rawname);
        Task<IFeedback> DeleteDirectory(IOSSRead input, bool recursive);
        Task<IOSSResponse> Upload(IOSSWrite input);
        Task<IOSSFileStreamResponse> Download(IOSSReadFile input, bool auto_search_extension = true);
        Task<IOSSFileStreamResponse> Download(IOSSFileRoute input, bool auto_search_extension = true);
        Task<IFeedback> Delete(IOSSReadFile input);
        IFeedback Exists(IOSSRead input, bool isFilePath = false);
        long GetSize(IOSSRead input);
        bool WriteMode { get; }
    }
}
