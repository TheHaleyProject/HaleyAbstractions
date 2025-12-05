using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IStorageDirectoryResponse : IFeedback {
        string Path { get; set; }
        List<string> FoldersList { get; set; }
        List<string> FilesList { get; set; }
    }
}
