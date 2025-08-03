using Haley.Abstractions;
using Haley.Enums;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
using System.Xml.Linq;

namespace Haley.Models {
    public class OSSName {
        public string Name { get; set; }
        public string TargetName { get; set; } //Should be the controlled name
        public OSSControlMode ControlMode { get; set; } //Parsing or create mode is defined at application level?
        public OSSParseMode ParseMode { get; set; } //If false, we fall back to parsing.
        public IFeedback Validate() {
            if (string.IsNullOrWhiteSpace(Name)) return new Feedback(false, "Name is empty");
            if (Name.Contains("..") || Name.Contains(@"\") || Name.Contains(@"/")) return new Feedback(false, "Name contains invalid characters");
            return new Feedback(true);
        }
        public OSSName() { }
        public OSSName(string name, OSSControlMode control = OSSControlMode.None, OSSParseMode parse = OSSParseMode.Parse) {
            Name = name;
            ControlMode = control;
            ParseMode = parse;
        }
    }
}
