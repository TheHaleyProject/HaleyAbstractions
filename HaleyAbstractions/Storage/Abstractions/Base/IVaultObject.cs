using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions {
    public interface IVaultObject : IVaultInfo, IVaultRoute {
       bool IsGuidControlled { get; } // To make sure that the components; client/module/wspace are GUID controlled or not.. If yes, then we take the CUID and then create folders with predefined split
    }
}
