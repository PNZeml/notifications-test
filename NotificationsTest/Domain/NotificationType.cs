using System.Collections.Generic;

namespace NotificationsTest.Domain {
    public enum NotificationType {
        WristbandIsNotAssigned = 0,
        EmployeeHasLeftEnterpriseArea = 1,
        EmployeeHasEnteredDangerousArea = 2,
        EmployeeHasEnteredDumptruckArea = 3,
        CriticalPulseRate = 4,
        CriticalHeartRateVariability = 5,
        CriticalOxygenSaturation = 6,
        LowBatteryChargeLevel = 7,
        EmployeeHasImmobilized = 8,
        EmployeeGotHit = 9,
        EmployeeHasFallen = 10
    }

    public static class Extensions {
        private static readonly Dictionary<NotificationType, string> readableNotificationTypes =
            new() {
                [NotificationType.WristbandIsNotAssigned] =
                    "Браслет не назначен",
                [NotificationType.EmployeeHasLeftEnterpriseArea] =
                    "Сотрудник вышел за зону предприятия",
                [NotificationType.EmployeeHasEnteredDangerousArea] =
                    "Сотрудник вошел в зону опасных работ",
                [NotificationType.EmployeeHasEnteredDumptruckArea] =
                    "Сотрудник в опасной близости от техники",
                [NotificationType.CriticalPulseRate] = "Критические показатели пульса",
                [NotificationType.CriticalHeartRateVariability] =
                    "Критические показатели вариаб. сердечного ритма",
                [NotificationType.CriticalOxygenSaturation] =
                    "Критические показатели насыщенности крови кислородом",
                [NotificationType.LowBatteryChargeLevel] =
                    "Низкий заряд батареии браслета",
                [NotificationType.EmployeeHasImmobilized] =
                    "Сотрудник был обездвижен",
                [NotificationType.EmployeeGotHit] =
                    "Сотрудник получил удар",
                [NotificationType.EmployeeHasFallen] =
                    "Сотрудник упал"
            };

        public static string ToReadable(this NotificationType type) =>
            readableNotificationTypes[type];
    }
}