using System.Collections.Generic;
using KbAis.Desktop.Notifications.Exp.Components;
using KbAis.Desktop.Notifications.Exp.Contracts;
using Telerik.WinControls.UI;

namespace KbAis.Desktop.Notifications.Exp {
    internal partial class NotificationsForm : RadForm, INotificationView {
        private readonly NotificationsPresenter presenter;

        public NotificationsForm() {
            InitializeComponent();
            InitializeViewEvents();
            presenter = new NotificationsPresenter(this);
        }

        private void InitializeViewEvents() {
            lcNotifications.CreatingVisualListItem += (_, args) => {
                args.VisualItem = new NotificationHostVisualItem();
            };
        }

        public void UpdateNotifications(IEnumerable<INotification> notifications) {
            // TODO: Remove expired notification, add new... 
            lcNotifications.DataSource = notifications;
        }
    }
}
