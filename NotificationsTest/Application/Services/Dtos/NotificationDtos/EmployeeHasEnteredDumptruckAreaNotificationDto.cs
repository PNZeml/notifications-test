namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal class EmployeeHasEnteredDumptruckAreaNotificationDto : NotificationBase {
        public EmployeeDto Employee { get; set; }
        public WristbandDto Wristband { get; set; }
        public DumptruckDto Dumptruck { get; set; }
    }
}
