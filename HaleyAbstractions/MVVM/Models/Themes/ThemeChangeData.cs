using Haley.Enums;
using System.Collections.Generic;

namespace Haley.Models {
    public struct ThemeChangeData {
        public object Themekey { get; set; }
        public List<ThemeInfo> NewThemes { get; set; }
        public object Sender { get; set; }
        public ThemeSearchMode SearchMode { get; set; }
    }
}
