namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal class EmployeeGotHitNotificationDto : NotificationBase {
        public EmployeeDto Employee { get; set; }
        public WristbandDto Wristband { get; set; }
    }
}
