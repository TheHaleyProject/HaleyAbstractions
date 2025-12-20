
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IVaultFolderRoute  : IVaultRoute{
        IVaultFolderRoute Parent { get; } //We are not anyhow creating the folders physically, which means, we dont need to worry about the parent hierarchy (because anyhow this information is already available in the database.. So, we only need to take care of the parent GUID or ID.
    }
}
