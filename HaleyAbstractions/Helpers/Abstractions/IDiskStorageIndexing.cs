using System.Threading.Tasks;
using System;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDiskStorageIndexing {
        Task<IFeedback> RegisterClient(ClientDirectoryInfo info);
        Task<IFeedback> RegisterModule(ModuleDirectoryInfo info);
        Task Validate();
    }
}
