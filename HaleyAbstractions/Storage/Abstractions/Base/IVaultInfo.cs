
using Haley.Enums;
using System;

namespace Haley.Abstractions {
    public interface IVaultInfo {
        long Id { get;  } //Database ID ??
        string Name { get;  } //Name
        string Cuid { get;  } //Collision resistance Unique Identifier 
        string DisplayName { get; }
        string Guid { get; } //Name with which it is identified
        IVaultInfo UpdateCUID(params string[] parentNames);
        bool TryValidate(out string message);
        IVaultInfo SetId(long setId);
        IVaultInfo SetCuid(string guid);
        IVaultInfo SetName(string name);
        IVaultInfo SetCuid(Guid guid);
    }
}
