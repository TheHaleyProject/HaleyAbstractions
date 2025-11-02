using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface IVaultManager : IDictionary<string, IObjectStorageService> {
        //We need Store, Fetch, Delete

    }
}
