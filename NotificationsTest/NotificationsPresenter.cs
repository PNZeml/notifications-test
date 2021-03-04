using System;
using System.Collections.Generic;
using KbAis.Desktop.Notifications.Exp.Contracts;
using KbAis.Desktop.Notifications.Exp.Dtos;

namespace KbAis.Desktop.Notifications.Exp {
    internal class NotificationsPresenter {
        private readonly INotificationView view;
        private readonly IList<INotification> notifications;

        public NotificationsPresenter(INotificationView view) {
            const int notificationsCapacity = 100000;

            this.view = view;
            notifications = new List<INotification>(notificationsCapacity);

            for (var idx = 1; idx <= notificationsCapacity; idx++) {
                INotification notification = idx switch {
                    > 30 and < 60 => new NotificationCDto(idx, $"Test notification {idx}", $"Some Dude {idx}"), 
                    { } when idx % 2 == 0 => new NotificationADto(idx, $"Test notification {idx}"),
                    { } when idx % 2 != 0 => new NotificationBDto(idx, $"Test notification {idx}"),
                    _ => throw new ArgumentOutOfRangeException()
                };
                notifications.Add(notification);
            }
            
            view.UpdateNotifications(notifications);
        }
    }
}