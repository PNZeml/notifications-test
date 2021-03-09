using NotificationsTest.Application.Services.Dtos.NotificationDtos;
using Telerik.WinControls;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class WristbandIsNotAssignedElement : NotificationElementBase {
        public override void UpdateContent(NotificationBase notification) {
            base.UpdateContent(notification);
            var n = (WristbandIsNotAssignedNotificationDto)Notification!;
            SubjectLocationButton.Visibility = ElementVisibility.Collapsed;
            wristbandLabel.Text = n.Wristband.MacAddress;
        }
    }
}