using Haley.Abstractions;
using System;

namespace Haley.Models
{
    public class IdentityBase : IIdentityBase {
        public Guid Guid { get; }
        public string Key { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public IdentityBase() : this(null) { }
        public IdentityBase(string key) {
            Key = key;
            Guid = Guid.NewGuid(); //Set a new GUID for this 
        }
    }
}
