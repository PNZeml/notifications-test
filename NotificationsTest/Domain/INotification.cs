namespace NotificationsTest.Domain {
    internal interface INotification {
        long Id { get; }
        string Description { get; }
    }
}
