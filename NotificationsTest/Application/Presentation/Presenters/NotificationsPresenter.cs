using System;
using System.Collections.Generic;
using NotificationsTest.Application.Presentation.Views;
using NotificationsTest.Application.Services.Dtos;
using NotificationsTest.Application.Services.Dtos.NotificationDtos;
using NotificationsTest.Domain;

namespace NotificationsTest.Application.Presentation.Presenters {
    internal class NotificationsPresenter : INotificationsPresenter {
        private const int NOTIFICATIONS_CAPACITY = 100;

        private readonly INotificationView view;

        public NotificationsPresenter(INotificationView view) {
            this.view = view;
            this.view.UpdateNotifications(GenerateNotifications());
        }

        private static IEnumerable<NotificationBase> GenerateNotifications() {
            yield return new CriticalHeartRateVariabilityNotificationDto {
                Id = 1,
                Type = NotificationType.CriticalHeartRateVariability,
                IsCritical = true,
                DateTime = new DateTime(2000, 01, 01, 00, 00, 00),
                Employee = new EmployeeDto { Id = 1, FirstName = "Goro", LastName = "Majima" },
                Wristband = new WristbandDto { Id = 1, MacAddress = "FFFFFFF" }
            };
            yield return new CriticalHeartRateVariabilityNotificationDto {
                Id = 2,
                Type = NotificationType.CriticalHeartRateVariability,
                IsCritical = true,
                DateTime = new DateTime(2000, 01, 01, 00, 00, 00),
                Employee = null,
                Wristband = new WristbandDto { Id = 1, MacAddress = "FFFFFFF" },
                HeartRateVariability = 100
            };
            yield return new CriticalOxygenSaturationNotificationDto {
                Id = 2,
                Type = NotificationType.CriticalOxygenSaturation,
                IsCritical = true,
                DateTime = new DateTime(2000, 01, 01, 00, 00, 00),
                Employee = null,
                Wristband = new WristbandDto { Id = 1, MacAddress = "FFFFFFF" },
                OxygenSaturation = 97
            };
            yield return new CriticalPulseRateNotificationDto {
                Id = 2,
                Type = NotificationType.CriticalPulseRate,
                IsCritical = true,
                DateTime = new DateTime(2000, 01, 01, 00, 00, 00),
                Employee = null,
                Wristband = new WristbandDto { Id = 1, MacAddress = "FFFFFFF" },
                PulseRate = 97
            };
            yield return new EmployeeHasEnteredDangerousAreaNotificationDto {
                Id = 2,
                Type = NotificationType.EmployeeHasEnteredDangerousArea,
                IsCritical = true,
                DateTime = new DateTime(2000, 01, 01, 00, 00, 00),
                Employee = new EmployeeDto { Id = 1, FirstName = "Goro", LastName = "Majima" },
                StaticArea = new StaticAreaDto { Id = 1, Name = "Опасная зона" }
            };
            yield return new EmployeeHasEnteredDumptruckAreaNotificationDto {
                Id = 2,
                Type = NotificationType.EmployeeHasEnteredDumptruckArea,
                IsCritical = true,
                DateTime = new DateTime(2000, 01, 01, 00, 00, 00),
                Employee = new EmployeeDto { Id = 1, FirstName = "Goro", LastName = "Majima" },
                Dumptruck = new DumptruckDto { Id = "100", Model = "Foo", VehName = "Bar" },
            };
            yield return new EmployeeHasFallenNotificationDto() {
                Id = 2,
                Type = NotificationType.EmployeeHasFallen,
                IsCritical = true,
                DateTime = new DateTime(2000, 01, 01, 00, 00, 00),
                Employee = new EmployeeDto { Id = 1, FirstName = "Goro", LastName = "Majima" },
            };
            yield return new LowBatteryChargeLevelDto() {
                Id = 2,
                Type = NotificationType.LowBatteryChargeLevel,
                IsCritical = true,
                DateTime = new DateTime(2000, 01, 01, 00, 00, 00),
                Employee = new EmployeeDto { Id = 1, FirstName = "Goro", LastName = "Majima" },
                BatteryChargeLevel = 99
            };
            yield return new WristbandIsNotAssignedNotificationDto {
                Id = 2,
                Type = NotificationType.WristbandIsNotAssigned,
                IsCritical = true,
                DateTime = new DateTime(2000, 01, 01, 00, 00, 00),
                Wristband = new WristbandDto { Id = 1, MacAddress = "FF-FF-FF-FF-FF-00" }
            };
            for (var i = 0; i < NOTIFICATIONS_CAPACITY; i++)
            {
                yield return new EmployeeHasImmobilizedNotificationDto
                {
                    Id = i,
                    Type = NotificationType.EmployeeHasImmobilized,
                    IsCritical = false,
                    Employee = new EmployeeDto {Id = 2, FirstName = "Phoenix", LastName = "Wright"}
                };
            }
        }
    }
}