using System;
using System.Collections.Generic;
using System.Text;
using Haley.Enums;
using Haley.Abstractions;

namespace Haley.Models
{
    public sealed class RegisterLoad :LoadBase, IRegisterLoad
    {
        public object ConcreteInstance { get; set; }
        public Func<object> InstanceCreator { get; private set; }
        public bool SetInstanceCreator(Func<object> creator)
        {
            if (InstanceCreator != null || creator == null) return false;
            InstanceCreator = creator;
            return true;
        }
        public RegisterMode Mode { get; }
        public ResolveLoad Convert(string contract_name, Type contract_parent, ResolveMode mode)
        {
            ResolveLoad _load = new ResolveLoad(mode, this.PriorityKey, contract_name, this.ContractType, contract_parent, this.ConcreteType, this.TransientLevel);
            return _load;
        }

        [HaleyIgnore]
        public RegisterLoad(RegisterMode mode,string priority_key, Type contract_type, Type concrete_type,object concrete_instance, TransientCreationLevel transient_level = TransientCreationLevel.None):base(priority_key,contract_type,concrete_type, transient_level)
        {
            ConcreteInstance = concrete_instance;
            Mode = mode;
        }
        [HaleyIgnore]
        public RegisterLoad():base(null,null,null)
        {
            Mode = RegisterMode.ContainerSingleton;
        }
    }
}
