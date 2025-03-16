using Haley.Enums;
using System;

namespace Haley.Models {
    public sealed class ResolveLoad : LoadBase {
        public string ContractName { get; set; }
        public Type ContractParent { get; set; }
        public IOCResolveMode Mode { get; set; }

        [HaleyIgnore]
        public ResolveLoad(IOCResolveMode mode, string priority_key, string contract_name, Type contract_type, Type contract_parent, Type concrete_type, TransientCreationLevel transient_level = TransientCreationLevel.None) : base(priority_key, contract_type, concrete_type, transient_level) {
            //Nullables
            ContractName = contract_name;
            ContractParent = contract_parent;
            Mode = mode;
        }
        [HaleyIgnore]
        public ResolveLoad() : base(null, null, null) {
            Mode = IOCResolveMode.AsRegistered;
        }
    }
}
