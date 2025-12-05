
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IStorageFolderRoute  : IStorageRoute{
        bool CreateIfMissing { get; set; }
        IStorageRoute Parent { get; }
        bool IsVirutal { get; set; } 
    }
}
