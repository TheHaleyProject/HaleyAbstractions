using Haley.Enums;
using System.Collections.Generic;

namespace Haley.Models {
    public struct GroupChangeData {
        public string GroupId { get; set; }
        public bool AddCopyAtRoot { get; set; }
        public object Themekey { get; set; }
        public List<ThemeInfo> PossibleOldThemes { get; set; }
        public ThemeInfo NewTheme { get; set; }
        public object Sender { get; set; }
        public ThemeSearchMode SearchMode { get; set; }
    }
}
