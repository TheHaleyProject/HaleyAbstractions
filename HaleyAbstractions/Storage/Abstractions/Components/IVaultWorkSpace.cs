using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IVaultWorkSpace : IVaultObject {
        IVaultBase Client { get; set; }
        IVaultBase Module { get; set; }
        VaultControlMode ContentControl { get; set; } //Only based on this, we decide the content control mode.
        VaultParseMode ContentParse { get; set; }
        string DatabaseName { get; set; }
        void Assert();
    }
}
