
namespace Haley.Abstractions {
    // Lightweight path descriptor — does NOT inherit IVaultBase.
    // Entity identity (Cuid as Guid, Guid, Key, etc.) comes through IVaultInfo/IVaultBase.
    // Route identity (Id, Cuid as string, Name) is declared on the concrete route interfaces.
    public interface IVaultRoute {
        string Path { get; set; }
    }
}
