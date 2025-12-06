using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IVaultProfile : IVaultInfo {
        string DisplayName { get; }
        string Guid { get; } //Name with which it is identified
        IVaultProfile UpdateCUID(params string[] parentNames);
        //new IVaultBaseEx SetId(long setId);
        //new IVaultBaseEx SetCuid(string guid);
        //new IVaultBaseEx SetCuid(Guid guid);
        bool TryValidate(out string message);
    }
}
