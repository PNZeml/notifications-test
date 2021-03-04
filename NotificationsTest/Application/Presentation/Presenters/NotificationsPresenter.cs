using System;
using System.Collections.Generic;
using NotificationsTest.Application.Presentation.Views;
using NotificationsTest.Application.Services.Dtos;
using NotificationsTest.Domain;

namespace NotificationsTest.Application.Presentation.Presenters {
    internal class NotificationsPresenter : INotificationsPresenter {
        private const int NOTIFICATIONS_CAPACITY = 100;

        private readonly INotificationView view;

        public NotificationsPresenter(INotificationView view) {
            this.view = view;
            this.view.UpdateNotifications(GenerateNotifications());
        }

        private static IEnumerable<INotification> GenerateNotifications() {
            for (var idx = 1; idx <= NOTIFICATIONS_CAPACITY; idx++) {
                yield return idx switch {
                    >= 30 and <= 60 =>
                        new NotificationCDto(idx, $"Test notification {idx}", "Phoenix Wright"),
                    { } when idx % 2 == 0 =>
                        new NotificationADto(idx, "Low HRV Level", "Miles Edgeworth", 97),
                    { } when idx % 2 != 0 =>
                        new NotificationBDto(idx, $"Test notification {idx}"),
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }
    }
}