using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Models {
    public class IOSSWorkspace : IOSSDirectory {
        public IOSSInfo Client { get; set; }
        public IOSSInfo Module { get; set; }
        public string DatabaseName { get; set; }
        public OSSControlMode ContentControl { get; set; }
        public OSSParseMode ContentParse { get; set; }
        public void Assert() {
            if (string.IsNullOrEmpty(SaveAsName) || string.IsNullOrEmpty(DisplayName) || string.IsNullOrEmpty(Path)) throw new ArgumentNullException("Name & Path Cannot be empty");
            if ( string.IsNullOrEmpty(ClientName)) throw new ArgumentNullException("Client Name cannot be empty");
        }
        public IOSSWorkspace(string clientName) { 
            ClientName = clientName;
        }
        public IOSSWorkspace() { }
    }
}
