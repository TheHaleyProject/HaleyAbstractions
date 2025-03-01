using Haley.Enums;
using System;
using System.Collections.Generic;

namespace Haley.Models {
    public class InternalThemeProvider {
        public Dictionary<InternalThemeMode, Uri> Location { get; private set; }
        public void SetInfoDic(Dictionary<InternalThemeMode, Uri> info_dic) {
            if (info_dic == null) info_dic = new Dictionary<InternalThemeMode, Uri>();
            Location = info_dic;
        }
        public InternalThemeProvider() {
            Location = new Dictionary<InternalThemeMode, Uri>();
        }
    }
}
