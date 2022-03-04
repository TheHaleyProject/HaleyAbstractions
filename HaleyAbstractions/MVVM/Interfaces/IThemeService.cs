using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using Haley.Models;

namespace Haley.Abstractions
{
    public interface IThemeService
    {

        #region Properties
        /// <summary>
        /// Event that gets raised whenever the theme is changed.
        /// </summary>
        event EventHandler<(object newTheme, object oldTheme)> ThemeChanged;
        /// <summary>
        /// The startup theme of all the registered assemblies. Should the reflect the actual value when building the code.
        /// </summary>
        object StartupTheme { get; }
        /// <summary>
        /// Active global theme. Cannot set it directly. This gets changed when theme change methods are called.
        /// </summary>
        object ActiveTheme { get; }
        ExceptionHandling ErrorHandling { get; set; }
        bool EnableNotifications { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// Use any one of the three themeBuilders: AssemblyThemeBuilder, IndependentThemeBuilder, InternalThemeBuilder
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        string Register(ThemeBuilderBase builder);
        bool ChangeTheme(object newThemeKey);
        bool ChangeTheme(object newThemeKey, object oldThemeKey, object frameworkElement, Assembly targetAssembly, ThemeSearchMode searchMode = ThemeSearchMode.Application);
        bool IsThemeKeyRegistered(object key, ThemeRegistrationMode dicType);
        bool IsThemeKeyRegistered(object key);
        List<ThemeInfo> GetThemeInfos(object key, ThemeRegistrationMode dicType);
        List<object> GetThemes(ThemeRegistrationMode dicType);
        List<object> GetAllThemeKeys();
        bool SetStartupTheme(object startupKey);
        bool SetupInternalTheme(Func<InternalThemeProvider> provider);
        bool BuildAndFillMissing();
        #endregion
    }
}