using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IStorageDirectory : IStorageInfo {
        string Path { get; set; }
    }
}
