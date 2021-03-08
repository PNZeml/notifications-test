using System;
using System.Collections.Generic;
using System.Drawing;
using NotificationsTest.Application.Presentation.NotificationsList.NotificationItems;
using NotificationsTest.Application.Services.Dtos.NotificationDtos;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.NotificationsList {
    internal class NotificationVisualItem : RadListVisualItem {
        private readonly EventHandler<NotificationItemClickEventArgs> showNotificationLocationClick;
        private readonly EventHandler<NotificationItemClickEventArgs> showSubjectLocationClick;
        private readonly EventHandler<NotificationItemClickEventArgs> processNotificationClick;

        private IDictionary<Type, NotificationItemBase> notificationItemElements = null!;

        public NotificationVisualItem(
            EventHandler<NotificationItemClickEventArgs> showNotificationLocationClick,
            EventHandler<NotificationItemClickEventArgs> showSubjectLocationClick,
            EventHandler<NotificationItemClickEventArgs> processNotificationClick
        ) {
            this.showNotificationLocationClick = showNotificationLocationClick;
            this.showSubjectLocationClick = showSubjectLocationClick;
            this.processNotificationClick = processNotificationClick;
        }

        protected override void CreateChildElements() {
            base.CreateChildElements();
            SetupAppearance();
            notificationItemElements = new Dictionary<Type, NotificationItemBase> {
                [typeof(CriticalHeartRateVariabilityNotificationDto)] =
                    new CriticalHeartRateVariabilityElement(),
                [typeof(CriticalOxygenSaturationNotificationDto)] =
                    new CriticalOxygenSaturationElement(),
                [typeof(CriticalPulseRateNotificationDto)] = new CriticalPulseRateElement()
            };
            foreach (var element in notificationItemElements.Values) {
                Children.Add(element);
            }

            void SetupAppearance() {
                DrawText = false;
                Shape = new RoundRectShape(3);
                DrawBorder = true;
                BorderColor = Color.LightBlue;
                BorderGradientStyle = GradientStyles.Solid;
                DrawFill = true;
                BackColor = Color.White;
                GradientStyle = GradientStyles.Solid;
            }
        }

        public override void Synchronize() {
            base.Synchronize();

            ResetVisibility();
            var notification = (NotificationBase)Data.DataBoundItem;
            if (!notificationItemElements.TryGetValue(notification.GetType(), out var el)) return;
            ShowNotificationItem(el);

            void ResetVisibility() {
                foreach (var element in notificationItemElements.Values) {
                    element.Visibility = ElementVisibility.Collapsed;
                    element.ShowNotificationLocationClick -= showNotificationLocationClick;
                    element.ShowSubjectLocationClick -= showSubjectLocationClick;
                    element.ProcessNotificationClick -= processNotificationClick;
                }
            }

            void ShowNotificationItem(NotificationItemBase element) {
                element.Visibility = ElementVisibility.Visible;
                element.ShowNotificationLocationClick += showNotificationLocationClick;
                element.ShowSubjectLocationClick += showSubjectLocationClick;
                element.ProcessNotificationClick += processNotificationClick;
                element.UpdateContent(notification);
            }
        }
    }
}
