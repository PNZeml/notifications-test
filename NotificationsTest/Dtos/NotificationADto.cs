using KbAis.Desktop.Notifications.Exp.Contracts;
using System;

namespace KbAis.Desktop.Notifications.Exp.Dtos
{
    internal class NotificationADto : INotification {
        public long Id { get; }
        public string Title { get; }

        public NotificationADto(long id, string title) {
            Id = id;
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }
    }
}
