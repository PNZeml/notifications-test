using NotificationsTest.Domain;

namespace NotificationsTest.Application.Services.Dtos {
    public class NotificationCDto : INotification {
        public long Id { get; }
        public string Description { get; }
        public string Employee { get; }

        public NotificationCDto(long id, string description, string employee) =>
            (Id, Description, Employee) = (id, description, employee);
    }
}