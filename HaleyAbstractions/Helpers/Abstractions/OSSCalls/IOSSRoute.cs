
using Haley.Enums;

namespace Haley.Abstractions {
    public interface IOSSRoute  {
        IOSSRoute Child { get; }
        long Id { get; } //Database ID ??
        string Name { get; } //Name of the folder or file?
        string Cuid { get; } //Collision resistance Unique Identifier 
        string Path { get; } //The transformed path??
        bool IsVirutal { get; }
        bool IsFile { get; }
        bool CreatingMissingParent { get; }
    }
}
