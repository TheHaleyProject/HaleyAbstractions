using Haley.Enums;
using System.Threading.Tasks;
using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IDocFormatControl {
        IDocFormatControl AddFormat(string format, FormatControlMode type, bool restricted = false);
        IDocFormatControl AddFormatRange(List<string> formats, FormatControlMode type, bool restricted = false);
        IDocFormatControl RemoveFormat(string format, FormatControlMode type, bool restricted = false);
        bool IsFormatAllowed(string format, FormatControlMode type);
        bool IsFormatTypeControlled(FormatControlMode type);
    }
}
