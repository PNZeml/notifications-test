using NotificationsTest.Application.Services.Dtos.NotificationDtos;
using Telerik.WinControls;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial  class CriticalPulseRateElement : NotificationItemBase {
        public override void UpdateContent(NotificationBase notification) {
            Notification = notification;
        }
    }
}