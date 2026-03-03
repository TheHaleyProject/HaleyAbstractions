using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Models {
    public sealed class PgExportRequest {
        public PgExportKind Kind { get; set; }
        public string? Schema { get; set; }
        public List<string> Tables { get; set; } = new();
        public string OutputFilePath { get; set; } = "";
        public bool UseInserts { get; set; } 
        public bool UseColumnInserts { get; set; } 
        public bool NoOwner { get; set; } = true;
        public bool NoPrivileges { get; set; } = true;
        public string Encoding { get; set; } = "UTF8";
    }
}
