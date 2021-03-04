using NotificationsTest.Domain;

namespace NotificationsTest.Application.Services.Dtos {
    internal class NotificationADto : INotification {
        public long Id { get; }
        public string Description { get; }
        public string Employee { get; }
        public int HeartRateVariability { get; }

        public NotificationADto(
            long id,
            string description,
            string employee,
            int heartRateVariability
        ) =>
            (Id, Description, Employee, HeartRateVariability) =
            (id, description, employee, heartRateVariability);
    }
}
