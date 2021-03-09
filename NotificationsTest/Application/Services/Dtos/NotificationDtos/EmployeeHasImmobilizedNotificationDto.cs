namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal class EmployeeHasImmobilizedNotificationDto : NotificationBase {
        public EmployeeDto? Employee { get; set; }
        public WristbandDto? Wristband { get; set; }
    }
}
