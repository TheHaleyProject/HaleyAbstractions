using System.Threading.Tasks;
using System;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IStorageIndexingService {
        Task<IFeedback> RegisterClient(ClientDirectoryInfo info);
        Task Validate();
    }
}
