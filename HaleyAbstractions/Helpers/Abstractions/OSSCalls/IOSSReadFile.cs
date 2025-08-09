using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IOSSReadFile : IOSSRead {
        IOSSFileRoute File { get; set; }
    }
}
