using Haley.Enums;
using System;

namespace Haley.Abstractions
{
    public interface IPayLoad
    {
        string PriorityKey { get;  }
        Type ContractType { get;  }
        Type ConcreteType { get; set; }
        TransientCreationLevel TransientLevel { get; set; }
    }
}
