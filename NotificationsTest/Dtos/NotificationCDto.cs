using System;
using KbAis.Desktop.Notifications.Exp.Contracts;

namespace KbAis.Desktop.Notifications.Exp.Dtos {
    public class NotificationCDto : INotification {
        public long Id { get; }
        public string Title { get; }
        public string EmployeeName { get; }

        public NotificationCDto(long id, string title, string employeeName) {
            Id = id;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            EmployeeName = employeeName ?? throw new ArgumentNullException(nameof(employeeName));
        }
    }
}