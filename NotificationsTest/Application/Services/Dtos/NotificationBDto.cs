using NotificationsTest.Domain;

namespace NotificationsTest.Application.Services.Dtos
{
    internal class NotificationBDto : INotification {
        public long Id { get; }
        public string Description { get; }

        public NotificationBDto(long id, string description) =>
            (Id, Description) = (id, description);
    }
}
