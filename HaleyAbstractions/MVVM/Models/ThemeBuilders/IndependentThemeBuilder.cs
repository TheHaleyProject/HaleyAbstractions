using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Haley.Enums;
using Haley.Abstractions;

namespace Haley.Models
{
    public class IndependentThemeBuilder : ThemeBuilderBase
    {
        Dictionary<object, Uri> themeGroup = new Dictionary<object, Uri>();

        public IndependentThemeBuilder Add(object key, Uri value)
        {
            if (!themeGroup.ContainsKey(key))
            {
                themeGroup.Add(key, value);
            }
            return this;
        }

        public override object GetThemeGroup()
        {
            return themeGroup;
        }

        public IndependentThemeBuilder() { }
    }
}
