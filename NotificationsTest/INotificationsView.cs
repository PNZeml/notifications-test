using System.Collections.Generic;
using KbAis.Desktop.Notifications.Exp.Contracts;

namespace KbAis.Desktop.Notifications.Exp {
    internal interface INotificationView {
        void UpdateNotifications(IEnumerable<INotification> notifications);
    }
}