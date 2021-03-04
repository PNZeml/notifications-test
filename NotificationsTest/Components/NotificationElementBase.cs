using Telerik.WinControls;

namespace KbAis.Desktop.Notifications.Exp.Components
{
    internal abstract class NotificationElementBase : RadElement, INotificationItemElement {
        public abstract void SetNotificationContent(object obj);
    }
}