
using Haley.Enums;
using System;

namespace Haley.Abstractions {
    public interface IVaultInfo {
        long Id { get;  } //Database ID ??
        string Name { get;  } //Name
        string Cuid { get;  } //Collision resistance Unique Identifier 
        IVaultInfo SetId(long setId);
        IVaultInfo SetCuid(string guid);
        IVaultInfo SetName(string name);
        IVaultInfo SetCuid(Guid guid);
    }
}
