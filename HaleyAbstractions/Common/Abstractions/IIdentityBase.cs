using System.Collections.Generic;
using System;

namespace Haley.Abstractions{
    public interface IIdentityBase {
        string Key { get; }
        Guid Guid { get; }
        long Id { get; set; }
        string Name { get; set; }
    }
}