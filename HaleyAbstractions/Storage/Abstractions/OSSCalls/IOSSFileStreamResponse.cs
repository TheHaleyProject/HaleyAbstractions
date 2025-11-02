using System.IO;

namespace Haley.Abstractions {
    public interface IOSSFileStreamResponse : IFeedback {
        Stream Stream { get; set; }
        string Extension { get; set; }
        string SaveName { get; set; }
    }
}
