using NotificationsTest.Application.Services.Dtos.NotificationDtos;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class CriticalOxygenSaturationElement : NotificationItemBase {
        public override void UpdateContent(NotificationBase notification) {
            Notification = notification;
        }
    }
}