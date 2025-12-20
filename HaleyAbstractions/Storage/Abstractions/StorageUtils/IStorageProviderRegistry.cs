using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IStorageProviderRegistry : IDictionary<string,IStorageProvider> {
        //Should contain a dictionary of different File Storage Providers based on their names (like DSS, Disk storage provider or the default one.
        //We also need to capture the storage profiles.. How???
    }
}
