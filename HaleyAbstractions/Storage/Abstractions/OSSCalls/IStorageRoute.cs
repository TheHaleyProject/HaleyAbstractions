
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IStorageRoute  {
        long Id { get; set; } //Database ID ??
        string Name { get; set; } //Name of the folder or file?
        string Cuid { get; set; } //Collision resistance Unique Identifier 
        string Path { get; set; } //The transformed path??
    }
}
