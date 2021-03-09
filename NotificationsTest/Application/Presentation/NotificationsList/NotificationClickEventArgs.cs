using System;
using NotificationsTest.Application.Services.Dtos.NotificationDtos;

namespace NotificationsTest.Application.Presentation.NotificationsList {
    internal class NotificationClickEventArgs : EventArgs {
        public NotificationBase? Notification { get; }

        public NotificationClickEventArgs(NotificationBase? notification) =>
            Notification = notification;
    }
}