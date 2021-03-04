using System;
using NotificationsTest.Application.Services.Dtos;
using NotificationsTest.Domain;

namespace NotificationsTest.Application.Presentation.Elements {
    internal partial class NotificationAElement : NotificationElementBase {
        public override void UpdateContent(INotification newNotification) {
            Notification = newNotification;
            var notificationA = (NotificationADto)Notification;

            dateTimeLabel.Text = DateTime.Now.ToString("f");
            descriptionLabel.Text = notificationA.Description;
            employeeLabel.Text = notificationA.Employee;
            heartRateVariabilityLabel.Text = Convert.ToString(notificationA.HeartRateVariability);
        }
    }
}