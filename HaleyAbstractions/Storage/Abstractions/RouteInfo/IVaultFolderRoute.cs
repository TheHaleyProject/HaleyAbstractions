
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IVaultFolderRoute  : IVaultRoute{
        bool CreateIfMissing { get; set; }
        IVaultRoute Parent { get; }
        bool IsVirutal { get; set; } //Cchcek how this is useful, if not remove.
    }
}
