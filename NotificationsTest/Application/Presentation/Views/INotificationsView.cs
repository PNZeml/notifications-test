using System.Collections.Generic;
using NotificationsTest.Domain;

namespace NotificationsTest.Application.Presentation.Views {
    internal interface INotificationView {
        void UpdateNotifications(IEnumerable<INotification> notifications);
    }
}