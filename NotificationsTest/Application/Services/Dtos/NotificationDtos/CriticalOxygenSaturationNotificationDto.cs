namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal class CriticalOxygenSaturationNotificationDto : NotificationBase {
        public EmployeeDto Employee { get; set; }
        public WristbandDto Wristband { get; set; }
        public int OxygenSaturation { get; set; }
    }
}
