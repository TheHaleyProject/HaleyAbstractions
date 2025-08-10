
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IOSSFolderRoute  : IOSSRoute{
        bool CreateIfMissing { get; set; }
        IOSSRoute Parent { get; }
        bool IsVirutal { get; set; } 
    }
}
