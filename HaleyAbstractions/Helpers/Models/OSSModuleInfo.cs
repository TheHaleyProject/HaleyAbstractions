using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Models {
    public class OSSModuleInfo : OSSDirectory {
        public string ClientName { get; set; }
        public OSSControlMode ContentControl { get; set; }
        public OSSParseMode ContentParse { get; set; }
        public void Assert() {
            if (string.IsNullOrEmpty(SaveAsName) || string.IsNullOrEmpty(DisplayName) || string.IsNullOrEmpty(Path)) throw new ArgumentNullException("Name & Path Cannot be empty");
            if (string.IsNullOrEmpty(ClientName)) throw new ArgumentNullException("Client Name cannot be empty");
        }
        public OSSModuleInfo(string clientName) { 
            ClientName = clientName;
        }
        public OSSModuleInfo() { }
    }
}
