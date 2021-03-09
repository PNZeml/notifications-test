using NotificationsTest.Application.Services.Dtos.NotificationDtos;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class EmployeeHasEnteredDumptruckAreaElement : NotificationElementBase {
        public override void UpdateContent(NotificationBase notification) {
            base.UpdateContent(notification);
            var n = (EmployeeHasEnteredDumptruckAreaNotificationDto)Notification!;
            employeeLabel.Text = n.Employee.ToString();
            equipmentLabel.Text = n.Dumptruck.ToString();
        }
    }
}