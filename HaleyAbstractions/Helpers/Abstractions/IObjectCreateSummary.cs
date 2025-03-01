using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IObjectCreateSummary : IFeedback {
        int Passed { get; set; }
        int Failed { get; set; }
        string TotalSizeUploaded { get; set; }
        List<IObjectCreateResponse> PassedObjects { get; set; }
        List<IObjectCreateResponse> FailedObjects { get; set; }
    }
}
