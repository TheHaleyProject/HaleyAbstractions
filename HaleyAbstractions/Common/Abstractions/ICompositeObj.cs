using System.Collections;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface ICompositeObj<T> : IIdentityBase where T : ICompositeObj<T> {
        List<T> Children { get; set; }
    }
}
