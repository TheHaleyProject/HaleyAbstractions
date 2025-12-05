using Haley.Enums;
using Haley.Models;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IStorageReadFileRequest : IStorageReadRequest {
        IStorageFileRoute File { get; }
        IStorageReadFileRequest SetFile(IStorageFileRoute file);
    }
}
