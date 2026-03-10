
namespace Haley.Abstractions {
    public interface IVaultFolderRoute : IVaultRoute {
        long Id { get; }
        string Cuid { get; set; }   // stored as compact-N string
        string Name { get; }
        IVaultFolderRoute Parent { get; }
    }
}
