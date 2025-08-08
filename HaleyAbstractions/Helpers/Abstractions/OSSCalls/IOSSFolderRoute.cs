
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IOSSFolderRoute  : IOSSRoute{
        IOSSRoute Parent { get; }
        bool IsVirutal { get; }
        bool CreateIfMissing { get; }
    }
}
