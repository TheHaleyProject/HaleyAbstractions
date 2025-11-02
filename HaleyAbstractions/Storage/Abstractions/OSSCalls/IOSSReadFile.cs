using Haley.Enums;
using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IOSSReadFile : IOSSRead {
        IOSSFileRoute File { get; }
        IOSSReadFile SetFile(IOSSFileRoute file);
    }
}
