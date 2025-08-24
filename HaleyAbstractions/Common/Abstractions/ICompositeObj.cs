using System.Collections;
using System.Collections.Generic;

namespace Haley.Abstractions {
    public interface ICompositeObj<T> : IIdentityBase where T : ICompositeObj<T> {
        long ParentId { get; set; }
        List<T> Children { get; set; }
    }
}
