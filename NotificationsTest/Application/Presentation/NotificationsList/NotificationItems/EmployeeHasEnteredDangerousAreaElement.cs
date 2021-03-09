using NotificationsTest.Application.Services.Dtos.NotificationDtos;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class EmployeeHasEnteredDangerousAreaElement : NotificationElementBase {
        public override void UpdateContent(NotificationBase notification) {
            base.UpdateContent(notification);
            var n = (EmployeeHasEnteredDangerousAreaNotificationDto)Notification!;
            employeeLabel.Text = n.Employee.ToString();
            staticAreaLabel.Text = n.StaticArea.Name;
        }
    }
}