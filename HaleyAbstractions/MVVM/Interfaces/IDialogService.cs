using Haley.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Haley.Abstractions
{
    public interface IDialogService
    {
        bool EnableBackgroundBlur { get; set; }
        double GlowRadius { get; set; }
        bool TopMost { get; set; }
        bool ShowInTaskBar { get; set; }

        INotification ShowDialog(string title, string message, NotificationIcon icon = NotificationIcon.Info, DialogMode mode = DialogMode.Notification, bool hideIcon = false,bool blurOtherWindows = false);
        INotification Info(string title, string message, DialogMode mode = DialogMode.Notification, bool blurOtherWindows = false);
        INotification Warning(string title, string message, DialogMode mode = DialogMode.Notification, bool blurOtherWindows = false);
        INotification Error(string title, string message, DialogMode mode = DialogMode.Notification, bool blurOtherWindows = false);
        INotification Success(string title, string message, DialogMode mode = DialogMode.Notification, bool blurOtherWindows = false);
        bool SendToast(string title, string message, NotificationIcon icon = NotificationIcon.Info, bool hideIcon = false, bool autoClose = true, int display_seconds = 7);

        //For fetching views from Container
        INotification ShowContainerView(string title, object key, object InputViewModel = null, ResolveMode mode = ResolveMode.AsRegistered,bool blurOtherWindows = false, IControlContainer container = null);
        INotification ShowContainerView<ViewOrVMType>(string title, object InputViewModel = null, ResolveMode mode = ResolveMode.AsRegistered, bool blurOtherWindows = false, IControlContainer container = null) where ViewOrVMType : class;

        #region Theme management
        bool SubscribeThemeService(IThemeService service);
        bool UnsubscribeThemeService();
        void ClearCurrentTheme();
        void RebaseTheme(bool defaultTheme = false);
        void RegisterThemeKey(DialogServiceProp propname, object resourceKey);
        void UnregisterThemeKey(DialogServiceProp propname);
        void RegisterThemeKeys(Dictionary<DialogServiceProp, object> keydictionary);
        void UnregisterThemeKeys(List<DialogServiceProp> propList);
        void UnregisterAllTheme();
        #endregion
    }
}
