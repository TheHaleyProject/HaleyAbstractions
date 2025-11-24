using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IStorageSummaryResponse : IFeedback {
        int Passed { get; set; }
        int Failed { get; set; }
        string TotalSizeUploaded { get; set; }
        List<IStorageOperationResponse> PassedObjects { get; set; }
        List<IStorageOperationResponse> FailedObjects { get; set; }
    }
}
