using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IOSSFormatManagement {
        IOSSFormatManagement AddFormat(string format, OSSFormatType type, bool restricted = false);
        IOSSFormatManagement AddFormatRange(List<string> formats, OSSFormatType type, bool restricted = false);
        IOSSFormatManagement RemoveFormat(string format, OSSFormatType type, bool restricted = false);
        bool IsFormatAllowed(string format, OSSFormatType type);
        bool IsFormatTypeControlled(OSSFormatType type);
    }
}
