using System;
using NotificationsTest.Application.Services.Dtos.NotificationDtos;
using NotificationsTest.Domain;
using Telerik.WinControls;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class CriticalHeartRateVariabilityElement : NotificationItemBase {
        public override void UpdateContent(NotificationBase notification) {
            Notification = notification;
            var n = (CriticalHeartRateVariabilityNotificationDto)Notification;
            DateTimeLabel.Text = n.DateTime.ToLongDateString();
            DescriptionLabel.Text = n.Type.ToReadable();
            if (n.Employee != null) {
                subjectTypeLabel.Text = "ФИО:";
                subjectValueLabel.Text = n.Employee.ToString();
                SubjectLocationButton.Visibility = ElementVisibility.Visible;
            } else {
                subjectTypeLabel.Text = "Браслет не назначен:";
                subjectValueLabel.Text = n.Wristband!.MacAddress;
                SubjectLocationButton.Visibility = ElementVisibility.Collapsed;
            }
            heartRateVariabilityLabel.Text = $"{n.HeartRateVariability}%";   
        }
    }
}