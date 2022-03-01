using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Haley.Enums;

namespace Haley.Models
{
    public class InternalThemeData
    {
        public Dictionary<InternalThemeMode,ThemeInfo> InfoDic { get; private set; }
        public Dictionary<object,InternalThemeMode> Themes { get; } //User will only assign this value.

        public void SetInfoDic(Dictionary<InternalThemeMode, ThemeInfo> info_dic)
        {
            if (info_dic == null) info_dic = new Dictionary<InternalThemeMode, ThemeInfo>();
            InfoDic = info_dic;
        }

        public void AddTheme(object key,InternalThemeMode mode)
        {
            if (key == null) return;
            if (Themes.ContainsKey(key)) return;
            Themes.Add(key, mode);
        }

        public void DeleteTheme(object key)
        {
            if (key == null) return;
            if (!Themes.ContainsKey(key)) return;
            Themes.Remove(key);
        }

        public void ClearAllTheme()
        {
            Themes.Clear();
        }

        public InternalThemeData() 
        {
            InfoDic = new Dictionary<InternalThemeMode, ThemeInfo>();
            Themes = new Dictionary<object, InternalThemeMode>();
        }
    }
}
