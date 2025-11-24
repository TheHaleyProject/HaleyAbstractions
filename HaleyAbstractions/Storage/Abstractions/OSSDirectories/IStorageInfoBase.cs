using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IStorageInfoBase  {
        long Id { get; }
        string Name { get;  }
        string DisplayName { get; }
        string Guid { get; } //Name with which it is identified
        string Cuid { get; } //Collision resistance Unique Identifier
        //IOSSInfo SetCUID(string uid);
        IStorageInfoBase UpdateCUID(params string[] parentNames);
        IStorageInfoBase ForceSetId(long setId);
        IStorageInfoBase ForceSetCuid(string guid);
        IStorageInfoBase ForceSetCuid(Guid guid);
        bool TryValidate(out string message);
    }
}
