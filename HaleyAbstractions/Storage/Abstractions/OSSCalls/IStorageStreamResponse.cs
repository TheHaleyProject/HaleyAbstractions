using System.IO;

namespace Haley.Abstractions {
    public interface IStorageStreamResponse : IFeedback {
        Stream Stream { get; set; }
        string Extension { get; set; }
        string SaveName { get; set; }
    }
}
