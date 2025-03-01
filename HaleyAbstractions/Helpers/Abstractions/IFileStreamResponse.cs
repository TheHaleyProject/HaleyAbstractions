using System.IO;

namespace Haley.Abstractions {
    public interface IFileStreamResponse : IFeedback {
        Stream Stream { get; set; }
        string Extension { get; set; }
    }
}
