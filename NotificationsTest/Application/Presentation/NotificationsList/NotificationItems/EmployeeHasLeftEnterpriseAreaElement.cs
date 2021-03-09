using NotificationsTest.Application.Services.Dtos.NotificationDtos;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class EmployeeHasLeftEnterpriseAreaElement : NotificationElementBase {
        public override void UpdateContent(NotificationBase notification) {
            base.UpdateContent(notification);
            var n = (EmployeeHasLeftEnterpriseAreaNotificationDto)Notification!;
            employeeLabel.Text = n.Employee.ToString();
        }
    }
}