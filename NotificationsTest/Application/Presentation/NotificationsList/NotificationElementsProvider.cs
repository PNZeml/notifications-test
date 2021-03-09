using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NotificationsTest.Application.Services.Dtos.NotificationDtos;
using Telerik.WinControls;

namespace NotificationsTest.Application.Presentation.NotificationsList {
    internal class NotificationElementsProvider {
        private readonly EventHandler<NotificationClickEventArgs> notificationLocationClick;
        private readonly EventHandler<NotificationClickEventArgs> subjectLocationClick;
        private readonly EventHandler<NotificationClickEventArgs> processNotificationClick;
        private readonly IDictionary<Type, NotificationElementBase> elements;
        private bool hasHostBeenProvided;

        public NotificationElementsProvider(
            EventHandler<NotificationClickEventArgs> notificationLocationClick,
            EventHandler<NotificationClickEventArgs> subjectLocationClick,
            EventHandler<NotificationClickEventArgs> processNotificationClick
        ) {
            this.notificationLocationClick = notificationLocationClick;
            this.subjectLocationClick = subjectLocationClick;
            this.processNotificationClick = processNotificationClick;
            elements = BuildElements();
        }

        public void ProvideHost(RadElement host) {
            if (hasHostBeenProvided) return;

            foreach (var element in elements.Values) host.Children.Add(element);
            hasHostBeenProvided = true;
        }

        public NotificationElementBase this[Type type] {
            get {
                if (type == null) throw new ArgumentNullException(nameof(type));

                foreach (var elementToHide in elements.Values) HideElement(elementToHide);
                var elementToShow = elements[type];
                ShowElement(elementToShow);

                return elementToShow;

                void HideElement(NotificationElementBase element) {
                    element.Visibility = ElementVisibility.Collapsed;
                    element.NotificationLocationClick -= notificationLocationClick;
                    element.SubjectLocationClick -= subjectLocationClick;
                    element.ProcessNotificationClick -= processNotificationClick;
                }

                void ShowElement(NotificationElementBase element) {
                    element.Visibility = ElementVisibility.Visible;
                    element.NotificationLocationClick += notificationLocationClick;
                    element.SubjectLocationClick += subjectLocationClick;
                    element.ProcessNotificationClick += processNotificationClick;
                }
            }
        }

        private static IDictionary<Type, NotificationElementBase> BuildElements() {
            var elements = new Dictionary<Type, NotificationElementBase>();
            var notificationsTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.BaseType != null && x.BaseType == typeof(NotificationBase))
                .ToList();
            var notificationElementTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.BaseType != null && x.BaseType == typeof(NotificationElementBase))
                .ToList();
            var removeLength = "NotificationDto".Length;
            foreach (var keyType in notificationsTypes) {
                // Get notification type name and remove 'Dto' from string.
                var keyTypeName =
                    keyType.Name.Remove(keyType.Name.Length - removeLength, removeLength);
                // Find corresponding item control type.
                var valueType =
                    notificationElementTypes.Single(x => x.Name.StartsWith(keyTypeName));
                elements[keyType] = (NotificationElementBase)Activator.CreateInstance(valueType);
            }

            return elements;
        }
    }
}