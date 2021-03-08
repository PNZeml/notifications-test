namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal class EmployeeHasFallenNotificationDto : NotificationBase {
        public EmployeeDto Employee { get; set; }
        public WristbandDto Wristband { get; set; }
    }
}
