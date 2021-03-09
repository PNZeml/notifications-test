namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal class EmployeeHasLeftEnterpriseAreaNotificationDto : NotificationBase {
        public EmployeeDto Employee { get; set; }
        public StaticAreaDto StaticArea { get; set; }
    }
}
