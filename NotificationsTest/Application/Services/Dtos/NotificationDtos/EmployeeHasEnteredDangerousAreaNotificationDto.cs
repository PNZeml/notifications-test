namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal class EmployeeHasEnteredDangerousAreaNotificationDto : NotificationBase {
        public EmployeeDto Employee { get; set; }
        public StaticAreaDto StaticArea { get; set; }
    }
}
