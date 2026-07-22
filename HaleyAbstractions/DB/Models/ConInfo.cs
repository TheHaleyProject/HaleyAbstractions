using Haley.Enums;
using System;

namespace Haley.Models {
    public class ConInfo : ICloneable {
        public string ConString { get; set; } = string.Empty;
        public TargetDB Target { get; set; } = TargetDB.unknown;
        public bool? IgnoreSsl { get; set; }

        public object Clone() {
            return new ConInfo() {
                ConString = ConString,
                Target = Target,
                IgnoreSsl = IgnoreSsl
            };
        }
    }
}
