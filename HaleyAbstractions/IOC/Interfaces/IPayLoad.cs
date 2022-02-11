using Haley.Enums;
using System;

namespace Haley.Abstractions
{
    public interface IPayLoad
    {
        string priority_key { get; set; }
        Type contract_type { get; set; }
        Type concrete_type { get; set; }
        TransientCreationLevel transient_level { get; set; }
    }
}
