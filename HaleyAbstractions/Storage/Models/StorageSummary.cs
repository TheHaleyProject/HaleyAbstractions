using Haley.Abstractions;
using System.Collections.Generic;

namespace Haley.Models {
    public class StorageSummary :Feedback, IStorageSummaryResponse {
        public int Passed { get; set; }
        public int Failed { get; set; }
        public string TotalSizeUploaded { get; set; }
        public List<IStorageOperationResponse> PassedObjects { get; set; } = new List<IStorageOperationResponse>();
        public List<IStorageOperationResponse> FailedObjects { get; set; } = new List<IStorageOperationResponse>();
        public StorageSummary() {  }
    }
}
