using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using Haley.Models;

namespace Haley.Abstractions
{
    public delegate bool ThemeChangeHandler(ThemeInfoBase theme, out ThemeInfoBase newTheme);
    public interface IThemeService
    {
        event EventHandler<(object newTheme, object oldTheme)> ThemeChanged;
        object StartupTheme { get; }
        object ActiveTheme { get; }
        InternalThemeData InternalThemes { get;}
        /// <summary>
        /// Global registration irrespective of the assembly that calls.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        bool RegisterGlobal(object key, ThemeInfoBase value);

        /// <summary>
        /// Register a specific theme against a key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        bool Register(object key, ThemeInfoBase value);
        bool AttachInternalTheme(InternalThemeData internal_data);
        /// <summary>
        /// Register a theme against a key that affects an assembly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="targetAssembly"></param>
        /// <returns></returns>
        bool Register(object key, ThemeInfoBase value, Assembly targetAssembly);
        /// <summary>
        /// Before the theme gets changed, raises a call back.
        /// </summary>
        /// <param name="ChangeCallBack"></param>
        bool AttachCallBack(ThemeChangeHandler ChangeCallBack,bool callBeforeChange = false);
        /// <summary>
        /// Before the theme gets changed, raises a call back.
        /// </summary>
        /// <param name="ChangeCallBack"></param>
        /// <param name="targetAssembly"></param>
        bool AttachCallBack(ThemeChangeHandler ChangeCallBack,Assembly targetAssembly, bool callBeforeChange = false);
        bool ChangeTheme(object newThemeKey, bool showNotifications = false);
        bool ChangeTheme(object newThemeKey,object oldThemeKey,object frameworkElement,Assembly targetAssembly, ThemeSearchMode priority = ThemeSearchMode.Application, bool raiseChangeEvents = true, bool showNotifications = false);
        bool IsThemeKeyRegistered(object key, ThemeDictionary dicType);
        bool IsThemeKeyRegistered(object key);
        List<ThemeInfoBase> GetThemeInfos(object key);
        List<string> GetThemes();
        void SetStartupTheme(object startupKey);
        bool ThrowExceptionsOnFailure { get; set; }
    }
}