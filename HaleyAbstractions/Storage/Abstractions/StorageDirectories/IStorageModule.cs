using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IStorageModule : IStorageDirectory {
        IStorageInfoBase Client { get; set; }
        string DatabaseName { get; set; }
    }
}
