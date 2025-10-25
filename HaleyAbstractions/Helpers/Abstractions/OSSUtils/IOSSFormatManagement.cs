using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IOSSFormatManagement {
        IOSSFormatManagement AddAllowedFormat(string format);
        IOSSFormatManagement AddAllowedFormatRange(List<string> formats);
        IOSSFormatManagement RemoveAllowedFormat(string format);
        IOSSFormatManagement AddRestrictedFormat(string format);
        IOSSFormatManagement AddRestrictedFormatRange(List<string> formats);
        IOSSFormatManagement RemoveRestrictedFormat(string format);
        bool IsFormatAllowed(string format);
    }
}
