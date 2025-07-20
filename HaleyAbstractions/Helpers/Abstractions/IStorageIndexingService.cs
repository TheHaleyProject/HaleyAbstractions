using System.Threading.Tasks;

namespace Haley.Abstractions {
    public interface IStorageIndexingService {
        IFeedback GetFile();
        bool UpsertClient();
        bool UpsertDirectory();
        bool UpsertFile();
    }
}
