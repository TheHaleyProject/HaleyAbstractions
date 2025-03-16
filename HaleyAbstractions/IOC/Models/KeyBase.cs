using Haley.Abstractions;
using System;

namespace Haley.Models {
    public class KeyBase : IIOCKeyBase, IEquatable<KeyBase> {
        public string id { get; }
        public string priority { get; }
        public Type contract_type { get; }

        public static string Generate(Type contract_type, string priority_key) {
            //Key = $contractType##$priority_key
            string _key = "";
            if (contract_type != null) {
                _key = $@"{contract_type.ToString()}";
            }
            if (!string.IsNullOrWhiteSpace(priority_key)) {
                _key += $@"###{priority_key.ToLower()}";
            }
            return _key;
        }
        public override bool Equals(object obj) {
            var item = obj as KeyBase;
            if (item == null) {
                return false;
            }
            return this.id.Equals(item.id);
        }
        public override int GetHashCode() {
            return this.id.GetHashCode();
        }
        public override string ToString() {
            return id;
        }
        public bool Equals(KeyBase other) {
            if (other == null) {
                return false;
            }
            return this.id == other.id;
        }

        [HaleyIgnore]
        public KeyBase(Type _contract_type, string _priority_key) {
            var _key = Generate(_contract_type, _priority_key);
            id = _key;
            priority = _priority_key;
            contract_type = _contract_type;
        }
    }
}
