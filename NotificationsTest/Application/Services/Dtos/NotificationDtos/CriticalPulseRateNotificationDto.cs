namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal class CriticalPulseRateNotificationDto : NotificationBase {
        public EmployeeDto Employee { get; set; }
        public WristbandDto Wristband { get; set; }
        public int PulseRate { get; set; }
    }
}
