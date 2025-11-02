using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDiskStorageService : IObjectStorageService, IDSSClientManagement, IOSSFormatManagement {
        IDiskStorageService SetIndexer(IDSSIndexing service);
        IDiskStorageService SetConfig(IDSSConfig config);
    }
}
