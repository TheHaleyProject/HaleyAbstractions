using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Haley.Enums;
using Haley.Abstractions;

namespace Haley.Models
{
    public class InternalThemeBuilder : ThemeBuilderBase
    {
        Dictionary<object, InternalThemeMode> themeGroup = new Dictionary<object, InternalThemeMode>();

        public InternalThemeBuilder Add(object key, InternalThemeMode mode)
        {
            if (!themeGroup.ContainsKey(key))
            {
                themeGroup.Add(key, mode);
            }
            return this;
        }

        public override object GetThemeGroup()
        {
            return themeGroup;
        }

        public InternalThemeBuilder() { }
    }
}
