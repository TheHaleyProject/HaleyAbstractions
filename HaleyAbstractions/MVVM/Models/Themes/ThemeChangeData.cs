using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Haley.Enums;

namespace Haley.Models
{
    public struct ThemeChangeData
    {
        public object Themekey { get; set; }
        public List<ThemeInfo> OldThemes { get; set; }
        public List<ThemeInfo> NewThemes { get; set; }
        public object Sender { get; set; }
        public ThemeSearchMode SearchMode { get; set; }
    }
}
