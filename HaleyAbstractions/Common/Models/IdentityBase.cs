using Haley.Abstractions;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Haley.Models
{
    public class IdentityBase : IIdentityBase {
        [JsonPropertyName("guid")]
        [JsonPropertyOrder(3)]
        public Guid Guid { get; }
        [JsonPropertyName("key")]
        [JsonPropertyOrder(2)]
        public string Key { get; set; }
        [JsonPropertyName("id")]
        [JsonPropertyOrder(1)]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        [JsonPropertyOrder(4)]
        public string Name { get; set; }
        public IdentityBase() : this(null) { }
        public IdentityBase(string key) {
            Key = key;
            Guid = Guid.NewGuid(); //Set a new GUID for this 
        }
    }
}
