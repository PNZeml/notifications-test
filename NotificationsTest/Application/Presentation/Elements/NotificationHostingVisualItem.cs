using System;
using System.Collections.Generic;
using System.Drawing;
using NotificationsTest.Application.Services.Dtos;
using NotificationsTest.Domain;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.Elements {
    internal class NotificationHostingVisualItem : RadListVisualItem {
        private readonly EventHandler<NotificationItemClickEventArgs> notificationClick;
        private IDictionary<Type, NotificationElementBase> notificationItemElements = null!;

        public NotificationHostingVisualItem(
            EventHandler<NotificationItemClickEventArgs> notificationClick
        ) {
            this.notificationClick = notificationClick;
        }

        protected override void CreateChildElements() {
            base.CreateChildElements();
            SetupAppearance();
            notificationItemElements = new Dictionary<Type, NotificationElementBase> {
                [typeof(NotificationADto)] = new NotificationAElement(),
                [typeof(NotificationBDto)] = new NotificationBElement(),
                [typeof(NotificationCDto)] = new NotificationCElement()
            };
            foreach (var el in notificationItemElements.Values) Children.Add(el);

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
            var notification = (INotification)Data.DataBoundItem;
            if (!notificationItemElements.TryGetValue(notification.GetType(), out var el)) return;
            ShowNotificationItem(el);

            void ResetVisibility() {
                foreach (var el in notificationItemElements.Values) {
                    el.Visibility = ElementVisibility.Collapsed;
                    el.NotificationLocationClick -= notificationClick;
                }
            }

            void ShowNotificationItem(NotificationElementBase el) {
                el.Visibility = ElementVisibility.Visible;
                el.NotificationLocationClick += notificationClick;
                el.UpdateContent(notification);
            }
        }
    }
}
