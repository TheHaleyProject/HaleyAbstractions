using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Models {
    public class StorageDirectoryInfo : StorageNameInfo {
        public string DisplayName { get; set; }
        public string HashGuid { get; set; }
        public string Path { get; set; }
    }
}
