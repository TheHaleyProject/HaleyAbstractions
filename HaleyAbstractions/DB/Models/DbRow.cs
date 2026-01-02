using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Models {
    public sealed class DbRow : Dictionary<string, object> {
        public DbRow() : base(StringComparer.OrdinalIgnoreCase) { }
    }

    public sealed class DbRows : List<DbRow> {
        public DbRows() { }
        public DbRows(int capacity) : base(capacity) { }
    }
}
