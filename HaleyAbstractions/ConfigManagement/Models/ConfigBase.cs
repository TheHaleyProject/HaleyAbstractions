using Haley.Abstractions;
using System;


namespace Haley.Models {
    public class ConfigBase : IConfig {
        public string Id { get; }

        public string FileName { get; set; }

        public ConfigBase() {
            Id = Guid.NewGuid().ToString();
        }
    }
}
