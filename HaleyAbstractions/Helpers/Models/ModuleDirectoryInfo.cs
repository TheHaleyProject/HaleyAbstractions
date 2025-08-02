using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Models {
    public class ModuleDirectoryInfo : StorageDirectoryInfo {
        public string ClientName { get; set; }
        public void Assert() {
            if (string.IsNullOrEmpty(DisplayName) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Path)) throw new ArgumentNullException("Name & Path Cannot be empty");
            if (string.IsNullOrEmpty(ClientName)) throw new ArgumentNullException("Client Name cannot be empty");
        }
        public ModuleDirectoryInfo(string clientName, string display_name) { 
            DisplayName = display_name;
            ClientName = clientName;
        }
    }
}
