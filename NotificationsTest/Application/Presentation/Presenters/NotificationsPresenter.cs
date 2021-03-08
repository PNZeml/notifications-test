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
            yield return new CriticalPulseRateNotificationDto() {
                Id = 2,
                Type = NotificationType.CriticalOxygenSaturation,
                IsCritical = true,
                DateTime = new DateTime(2000, 01, 01, 00, 00, 00),
                Employee = null,
                Wristband = new WristbandDto { Id = 1, MacAddress = "FFFFFFF" },
                PulseRate = 97
            };
        }
    }
}