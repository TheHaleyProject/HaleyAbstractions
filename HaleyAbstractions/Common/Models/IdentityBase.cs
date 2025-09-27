using Haley.Abstractions;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Haley.Models
{
    public class IdentityBase : IIdentityBase {

        [JsonPropertyName("id")]
        [JsonPropertyOrder(0)]
        public long Id { get; set; }
        [JsonPropertyName("key")]
        [JsonPropertyOrder(0)]
        public string Key { get; set; }
        [JsonPropertyName("guid")]
        [JsonPropertyOrder(0)]
        public Guid Guid { get; protected set; }
        [JsonPropertyName("name")]
        [JsonPropertyOrder(1)]
        public string Name { get; set; }

        public void SetGuid(Guid guid) {
            Guid = guid;
        }

        public IdentityBase() : this(null) { }
        public IdentityBase(string key) {
            Key = key;
            Guid = Guid.NewGuid(); //Set a new GUID for this 
        }
    }
}
