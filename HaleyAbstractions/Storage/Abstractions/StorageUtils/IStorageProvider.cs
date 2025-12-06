
namespace Haley.Abstractions {
    public interface IStorageProvider : IStorageOperations {
        string Key { get; set; }
    }
}
