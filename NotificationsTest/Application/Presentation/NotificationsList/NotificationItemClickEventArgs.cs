using System;
using NotificationsTest.Application.Services.Dtos.NotificationDtos;

namespace NotificationsTest.Application.Presentation.NotificationsList {
    internal class NotificationItemClickEventArgs : EventArgs {
        public NotificationBase? Notification { get; }

        public NotificationItemClickEventArgs(NotificationBase? notification) =>
            Notification = notification;
    }
}