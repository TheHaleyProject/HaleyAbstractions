using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IVaultWorkSpace : IVaultObject {
        IVaultBase Client { get; set; }
        IVaultBase Module { get; set; }
        VaultControlMode StorageNameMode { get; set; }
        VaultParseMode StorageNameParseMode { get; set; }
        string DatabaseName { get; set; }
        void Assert();
    }
}
