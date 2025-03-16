using System;

namespace Haley.Abstractions {
    public interface IIOCKeyBase {
        string id { get; }
        string priority { get; }
        Type contract_type { get; }
    }
}
