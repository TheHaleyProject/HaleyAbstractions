using Haley.Abstractions;
using Haley.Enums;
using System;

namespace Haley.Models {
    public sealed class RegisterLoad : LoadBase, IRegisterLoad {
        public object ConcreteInstance { get; set; }
        public Func<object> InstanceCreator { get; private set; }
        public bool IsLazyRegister { get; private set; }
        public bool SetInstanceCreator(Func<object> creator) {
            if (InstanceCreator != null) return false; // We should not overwrite an existing creator during runtime.
            IsLazyRegister = true; //this is a lazy register call
            InstanceCreator = creator; //this could be null. If null, we try to resolve on demand.
            return true;
        }
        public RegisterMode Mode { get; }
        public ResolveLoad Convert(string contract_name, Type contract_parent, ResolveMode mode) {
            ResolveLoad _load = new ResolveLoad(mode, this.PriorityKey, contract_name, this.ContractType, contract_parent, this.ConcreteType, this.TransientLevel);
            return _load;
        }

        [HaleyIgnore]
        public RegisterLoad(RegisterMode mode, string priority_key, Type contract_type, Type concrete_type, object concrete_instance, TransientCreationLevel transient_level = TransientCreationLevel.None) : base(priority_key, contract_type, concrete_type, transient_level) {
            ConcreteInstance = concrete_instance;
            Mode = mode;
        }
        [HaleyIgnore]
        public RegisterLoad() : base(null, null, null) {
            Mode = RegisterMode.ContainerSingleton;
            IsLazyRegister = false; //default
        }
    }
}
