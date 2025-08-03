using Haley.Enums;
using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IObjectStorageService {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        Task<IOSSDirResponse> GetDirectoryInfo(IOSSRead input);
        Task<IOSSResponse> CreateDirectory(IOSSRead input, string rawname);
        Task<IFeedback> DeleteDirectory(IOSSRead input, bool recursive);
        Task<IOSSResponse> Upload(IOSSWrite input);
        Task<IOSSFileStreamResponse> Download(IOSSRead input, bool auto_search_extension = true);
        Task<IFeedback> Delete(IOSSRead input);
        IFeedback Exists(IOSSRead input);
        long GetSize(IOSSRead input);
        bool WriteMode { get; }
    }
}
