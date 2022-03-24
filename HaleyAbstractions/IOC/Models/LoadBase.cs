using System;
using System.Collections.Generic;
using System.Text;
using Haley.Abstractions;
using Haley.Enums;

namespace Haley.Models
{
    public class LoadBase : IPayLoad
    {
        public string PriorityKey { get; }
        public Type ContractType { get; }
        public Type ConcreteType { get; set; }
        public TransientCreationLevel TransientLevel { get; set; }

        [HaleyIgnore]
        public LoadBase(string priority_key, Type contract_type, Type concrete_type, TransientCreationLevel transient_level = TransientCreationLevel.None) 
        {
            PriorityKey = priority_key;
            ContractType = contract_type;
            ConcreteType = concrete_type ?? contract_type;
            TransientLevel = transient_level;
        }
    }
}
