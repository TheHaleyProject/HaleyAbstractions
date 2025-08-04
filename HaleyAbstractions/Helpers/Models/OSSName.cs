using Haley.Abstractions;
using Haley.Enums;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
using System.Xml.Linq;

namespace Haley.Models {
    public class OSSName {
        public const string DEFAULTNAME = "default";
        public string Name { get; private set; }
        private string _displayName;

        public string DisplayName {
            get { return _displayName; }
            set { _displayName = value;
                if (!string.IsNullOrWhiteSpace(value)) {
                    Name = value.Trim().ToLower().Replace(" ", "_");
                }
            }
        }
        public string SaveAsName { get; set; } //Should be the controlled name or a name compatible for the database 
        public OSSControlMode ControlMode { get; set; } //Parsing or create mode is defined at application level?
        public OSSParseMode ParseMode { get; set; } //If false, we fall back to parsing.
        public IFeedback Validate() {
            if (string.IsNullOrWhiteSpace(DisplayName)) return new Feedback(false, "Name is empty");
            if (DisplayName.Contains("..") || DisplayName.Contains(@"\") || DisplayName.Contains(@"/")) return new Feedback(false, "Name contains invalid characters");
            return new Feedback(true);
        }
        public OSSName():this(null) { }
        public OSSName(string name, OSSControlMode control = OSSControlMode.None, OSSParseMode parse = OSSParseMode.Parse) {
            DisplayName = name ?? DEFAULTNAME; //Don't accept null values.
            ControlMode = control;
            ParseMode = parse;
        }
    }
}
