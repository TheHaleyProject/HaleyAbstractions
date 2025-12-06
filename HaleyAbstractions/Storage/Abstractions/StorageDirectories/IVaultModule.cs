using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IVaultModule : IVaultComponent {
        IVaultProfile Client { get; set; }
        string DatabaseName { get; set; }
        string StorageProfileName { get; set; }
    }
}
