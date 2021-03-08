namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal class LowBatteryChargeLevelDto : NotificationBase {
        public int BatteryChargeLevel { get; set; }
        public WristbandDto Wristband { get; set; }
        public EmployeeDto Employee { get; set; }
    }
}
