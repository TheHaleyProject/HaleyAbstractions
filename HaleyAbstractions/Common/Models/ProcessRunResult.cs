using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haley.Models {
    public sealed class ProcessRunResult {
        public bool Success { get; set; }
        public int ExitCode { get; set; }
        public string StdOut { get; set; } = "";
        public string StdErr { get; set; } = "";
        public string Executable { get; set; } = "";
        public List<string> Arguments { get; set; } = new();
    }
}
