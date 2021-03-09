using NotificationsTest.Application.Services.Dtos.NotificationDtos;
using Telerik.WinControls;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class CriticalOxygenSaturationElement : NotificationElementBase {
        public override void UpdateContent(NotificationBase notification) {
            base.UpdateContent(notification);
            var n = (CriticalOxygenSaturationNotificationDto)Notification!;
            if (n.Employee != null) {
                subjectTypeLabel.Text = "ФИО:";
                subjectValueLabel.Text = n.Employee.ToString();
                SubjectLocationButton.Visibility = ElementVisibility.Visible;
            } else {
                subjectTypeLabel.Text = "Браслет не назначен:";
                subjectValueLabel.Text = n.Wristband!.MacAddress;
                SubjectLocationButton.Visibility = ElementVisibility.Collapsed;
            }
            oxygenSaturationLabel.Text = $"{n.OxygenSaturation}%";
        }
    }
}