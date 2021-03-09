using System.Collections.Generic;
using NotificationsTest.Application.Presentation.NotificationsList;
using NotificationsTest.Application.Presentation.Presenters;
using NotificationsTest.Application.Services.Dtos.NotificationDtos;
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

        public void UpdateNotifications(IEnumerable<NotificationBase> notifications) {
            lcNotifications.DataSource = notifications;
        }

        private void InitializeViewEvents() {
            lcNotifications.CreatingVisualListItem += (_, args) => {
                args.VisualItem = new NotificationVisualItem(
                    ShowNotificationLocationClick,
                    ShowSubjectLocationClick,
                    ProcessNotificationClick
                );
            };
        }

        private void ShowNotificationLocationClick(object _, NotificationClickEventArgs args) {
            RadMessageBox.Show($"{args.Notification?.Type.ToReadable()}, {args.Notification?.Id}");
        }

        private void ShowSubjectLocationClick(object _, NotificationClickEventArgs args) {

        }

        private void ProcessNotificationClick(object _, NotificationClickEventArgs args) {

        }
    }
}
