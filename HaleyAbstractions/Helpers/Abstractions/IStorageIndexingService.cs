using System.Threading.Tasks;
using System;

namespace Haley.Abstractions {
    public interface IStorageIndexingService {
        Task<IFeedback> RegisterClient(string display_name, string password, string path = null);
        Task Validate();
    }
}
