using Haley.Abstractions;
using Haley.Enums;
using System.Collections.Generic;

namespace Haley.Models {
    public class InternalThemeBuilder : ThemeBuilderBase {
        Dictionary<object, InternalThemeMode> themeGroup = new Dictionary<object, InternalThemeMode>();

        public InternalThemeBuilder Add(object key, InternalThemeMode mode) {
            if (!themeGroup.ContainsKey(key)) {
                themeGroup.Add(key, mode);
            }
            return this;
        }

        public override object GetThemeGroup() {
            return themeGroup;
        }

        public InternalThemeBuilder() { }
    }
}
