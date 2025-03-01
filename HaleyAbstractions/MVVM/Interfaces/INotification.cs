using Haley.Enums;

namespace Haley.Abstractions {
    public interface INotification {
        #region Properties
        object ViewModel { get; }
        string Id { get; }
        DisplayType Type { get; set; }
        string Message { get; set; }
        NotificationIcon NotificationIcon { get; set; }
        bool ShowNotificationIcon { get; set; }
        string UserInput { get; set; }
        bool? DialogResult { get; set; }
        string AppName { get; set; }
        bool AutoClose { get; set; }
        int CountDown { get; set; }
        double GlowRadius { get; set; }
        #endregion
    }
}
