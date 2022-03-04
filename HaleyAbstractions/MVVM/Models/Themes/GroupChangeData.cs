using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Haley.Enums;

namespace Haley.Models
{
    public struct GroupChangeData
    {
        public string GroupId { get; set; }
        public bool AddCopyAtRoot { get; set; }
        public object Themekey { get; set; }
        public ThemeInfo OldTheme { get; set; }
        public ThemeInfo NewTheme { get; set; }
        public object Sender { get; set; }
        public ThemeSearchMode SearchMode { get; set; }
    }
}
