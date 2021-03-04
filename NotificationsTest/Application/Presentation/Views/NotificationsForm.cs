using System.Collections.Generic;
using NotificationsTest.Application.Presentation.Elements;
using NotificationsTest.Application.Presentation.Presenters;
using NotificationsTest.Domain;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.Views {
    internal partial class NotificationsForm : RadForm, INotificationView {
        public INotificationsPresenter? Presenter { get; set; }

        public NotificationsForm() {
            InitializeComponent();
            InitializeViewEvents();
            RadMessageBox.SetThemeName(thmFluent.ThemeName);
        }
        
        public void UpdateNotifications(IEnumerable<INotification> notifications) {
            lcNotifications.DataSource = notifications;
        }

        private void InitializeViewEvents() {
            lcNotifications.CreatingVisualListItem += (_, args) => {
                args.VisualItem = new NotificationHostingVisualItem(NotificationClick);
            };
        }

        private void NotificationClick(object _, NotificationItemClickEventArgs args) {
            RadMessageBox.Show($"{args.Notification?.Description}, {args.Notification?.Id}");
        }
    }
}
