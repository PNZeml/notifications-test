using System;
using System.Drawing;
using NotificationsTest.Application.Services.Dtos.NotificationDtos;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.NotificationsList {
    internal class NotificationVisualItem : RadListVisualItem {
        private readonly NotificationElementsProvider provider;

        public NotificationVisualItem(
            EventHandler<NotificationClickEventArgs> notificationLocationClick,
            EventHandler<NotificationClickEventArgs> subjectLocationClick,
            EventHandler<NotificationClickEventArgs> processNotificationClick
        ) {
            provider = new NotificationElementsProvider(
                notificationLocationClick,
                subjectLocationClick,
                processNotificationClick
            );
        }

        protected override void CreateChildElements() {
            SetupAppearance();

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
            provider.ProvideHost(this);
            var notification = Data.DataBoundItem as NotificationBase;
            provider[notification!.GetType()].UpdateContent(notification);
        }
    }
}
