using Haley.Abstractions;
using Haley.Enums;

namespace Haley.Models {

    public class StorageProfileConfig  {
        public string Name { get; set; }                         // e.g. "khopu-primary"
        public StorageProfileMode Mode { get; set; }
        public string PrimaryProviderKey { get; set; }           // e.g. "fs-main"
        public string SecondaryProviderKey { get; set; }         // e.g. "b2-staging"

        // Optional tuning for background worker
        public int? MoveDelayMinutes { get; set; }
        public StorageProfileConfig() {
        }
    }
}