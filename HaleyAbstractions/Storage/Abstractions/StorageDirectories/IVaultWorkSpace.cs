using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IVaultWorkSpace : IVaultComponent {
        IVaultProfile Client { get; set; }
        IVaultProfile Module { get; set; }
        VaultControlMode ContentControl { get; set; }
        VaultParseMode ContentParse { get; set; }
        string DatabaseName { get; set; }
        void Assert();
    }
}
