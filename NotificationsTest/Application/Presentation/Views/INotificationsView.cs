using System.Collections.Generic;
using NotificationsTest.Application.Services.Dtos.NotificationDtos;
using NotificationsTest.Domain;

namespace NotificationsTest.Application.Presentation.Views {
    internal interface INotificationView {
        void UpdateNotifications(IEnumerable<NotificationBase> notifications);
    }
}