using Haley.Abstractions;
using Haley.Enums;
using System.Globalization;
using System.Collections.Generic;
using System;

namespace Haley.Models
{
	public class DbCreationArgs {
        public string Key { get; set; }
        public string FallBackDBName { get; set; }
        public string DBName { get; set; }
        public string SQLPath { get; set; }
        public string SQLContent { get; set; }
        public string? CloningAdapterKey { get; set; } //Sometimes, the adapter gateway might not have the kye.. in such cases.. we need to hceck if the cloningadpaterkey is present or not,, in this case, we can just duplicate the adapter and then just set new key and a new database name.. thats it.. Dbname and key are already present here.. if cloningadpater is present we just duplicate
        public Dictionary<string, string> VariablesToReplace { get; set; } = new Dictionary<string, string>();
        public Func<string ,string,string> ContentProcessor { get; set; }
        public DbCreationArgs(string adapter_key) { Key = adapter_key;}
	}
}
