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
        event EventHandler<object> ThemeChanged;
        /// <summary>
        /// The startup theme of all the registered assemblies. Should the reflect the actual value when building the code.
        /// </summary>
        object StartupTheme { get; }
        /// <summary>
        /// Active global theme. Cannot set it directly. This gets changed when theme change methods are called.
        /// </summary>
        object ActiveTheme { get; }
        /// <summary>
        /// How the errors should be handled when occurred. 
        /// </summary>
        ExceptionHandling ErrorHandling { get; set; }
        /// <summary>
        /// Apart from errors, there are few theme change notifications which could guide the development process. This flag shows/supresses the notifications.
        /// </summary>
        bool EnableNotifications { get; set; }
        /// <summary>
        /// Affects the themes replace mechanism
        /// </summary>
        ThemeReplaceMode ReplaceMode { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// Register a theme group.
        /// </summary>
        /// <param name="builder">Use any one of the three themeBuilders: AssemblyThemeBuilder, IndependentThemeBuilder, InternalThemeBuilder</param>
        /// <returns></returns>
        string RegisterGroup(ThemeBuilderBase builder);
        bool ChangeTheme(object newThemeKey);
        bool ChangeTheme(object newThemeKey, object frameworkElement, Assembly targetAssembly, ThemeSearchMode searchMode = ThemeSearchMode.Application);
        bool IsThemeKeyRegistered(object key, ThemeRegistrationMode dicType);
        bool IsThemeKeyRegistered(object key);
        List<ThemeInfo> GetThemeInfos(object key, ThemeRegistrationMode dicType);
        List<object> GetThemes(ThemeRegistrationMode dicType);
        List<object> GetAllThemeKeys();
        bool SetStartupTheme(object startupKey);
        bool SetupInternalTheme(Func<InternalThemeProvider> provider);
        bool BuildAndFillMissing();
        void SyncAllWithActiveTheme();
        List<ThemeInfo> GetAllRegisteredThemeInfos();
        #endregion
    }
}