using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Abstractions
{
    public interface IKeyBase
    {
        string id { get; }
        string priority { get; }
        Type contract_type { get; }
    }
}
