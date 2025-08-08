using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;

namespace Haley.Abstractions {
    public interface IDiskStorageService : IObjectStorageService, IDSSClientManagement {
        IDiskStorageService SetIndexer(IDSSIndexing service);
    }
}
