using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IStorageWorkspace : IStorageDirectory {
        IStorageInfoBase Client { get; set; }
        IStorageInfoBase Module { get; set; }
        StorageControlMode ContentControl { get; set; }
        StorageParseMode ContentParse { get; set; }
        string DatabaseName { get; set; }
        void Assert();
    }
}
