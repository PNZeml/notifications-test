using System;
using NotificationsTest.Domain;
using Telerik.WinControls;

namespace NotificationsTest.Application.Presentation.Elements {
    internal abstract class NotificationElementBase : RadElement {
        protected INotification? Notification;

        public event EventHandler<NotificationItemClickEventArgs>? NotificationLocationClick;

        public abstract void UpdateContent(INotification newNotification);

        protected void NotificationLocationClickInvoke() => NotificationLocationClick?.Invoke(
            this,
            new NotificationItemClickEventArgs(Notification)
        );
    }

    internal class NotificationItemClickEventArgs : EventArgs {
        public INotification? Notification { get; }

        public NotificationItemClickEventArgs(INotification? notification) {
            Notification = notification;
        }
    }
}