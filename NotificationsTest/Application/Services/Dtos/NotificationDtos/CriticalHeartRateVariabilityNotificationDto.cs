namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal class CriticalHeartRateVariabilityNotificationDto : NotificationBase {
        public EmployeeDto? Employee { get; set; }
        public WristbandDto? Wristband { get; set; }
        public int HeartRateVariability { get; set; }
    }
}
