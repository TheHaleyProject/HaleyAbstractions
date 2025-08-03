using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Models {
    public class DSSConfig {
        //All suffix are applicable only when dealing with controlled names.
        public string ClientSuffix { get; set; } = "c";
        public string ModuleSuffix { get; set; } = "m";
        public string DirectorySuffix { get; set; } = "d";
        public string FileSuffix { get; set; } = "f";
        public int NumberSplitLength = 2; //For numbers
        public int HashSplitLength = 1; //For numbers
        public int NumberDepth = 0;
        public int HashDepth = 8; 
    }
}
