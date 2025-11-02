using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IOSSSummary : IFeedback {
        int Passed { get; set; }
        int Failed { get; set; }
        string TotalSizeUploaded { get; set; }
        List<IOSSResponse> PassedObjects { get; set; }
        List<IOSSResponse> FailedObjects { get; set; }
    }
}
