using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NotificationsTest.Application.Services.Dtos.NotificationDtos;
using NotificationsTest.Domain;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.NotificationsList {
    internal abstract class NotificationElementBase : RadElement {
        protected LightVisualElement DateTimeLabel = null!;
        protected LightVisualElement TypePictureBox = null!;
        protected LightVisualElement DescriptionLabel = null!;
        protected RadButtonElement NotificationLocationButton = null!;
        protected RadButtonElement SubjectLocationButton = null!;
        protected RadButtonElement ProcessNotificationButton = null!;
        protected NotificationBase? Notification;

        public event EventHandler<NotificationClickEventArgs>? NotificationLocationClick;
        public event EventHandler<NotificationClickEventArgs>? SubjectLocationClick;
        public event EventHandler<NotificationClickEventArgs>? ProcessNotificationClick;

        public virtual void UpdateContent(NotificationBase notification) {
            Notification = notification;
            DateTimeLabel.Text = Notification.DateTime.ToLongDateString();
            DescriptionLabel.Text = Notification.Type.ToReadable();
        }

        protected abstract RadElement CreateMiddle();

        protected override void CreateChildElements() {
            Children.Add(CreateHostElement());
            NotificationLocationButton.Click += (_, _) => NotificationLocationClickInvoke();
            SubjectLocationButton.Click += (_, _) => SubjectLocationClickInvoke();
            ProcessNotificationButton.Click += (_, _) => ProcessNotificationClickInvoke();

            RadElement CreateHostElement() =>
                new StackLayoutPanel {
                    Orientation = Orientation.Vertical,
                    Children = { CreateHeader(), CreateMiddle(), CreateFooter() }
                };

            void NotificationLocationClickInvoke() => NotificationLocationClick?
                .Invoke(this, new NotificationClickEventArgs(Notification));

            void SubjectLocationClickInvoke() => SubjectLocationClick?
                .Invoke(this, new NotificationClickEventArgs(Notification));

            void ProcessNotificationClickInvoke() => ProcessNotificationClick?
                .Invoke(this, new NotificationClickEventArgs(Notification));
        }

        private RadElement CreateHeader() {
            return new StackLayoutPanel {
                Orientation = Orientation.Vertical,
                Margin = new Padding(6, 6, 6, 0),
                Children = { CreateDateTimeElement(), CreateDescriptionElement() }
            };

            RadElement CreateDateTimeElement() {
                DateTimeLabel = new LightVisualElement {
                    Font = new Font("Segoe UI", 9.75f),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(DateTimeLabel, Dock.Left);

                TypePictureBox = new LightVisualElement {
                    AutoSize = false,
                    Size = new Size(30, 30),
                    BackColor = Color.OrangeRed,
                    DrawFill = true,
                    GradientStyle = GradientStyles.Solid
                };
                DockLayoutPanel.SetDock(TypePictureBox, Dock.Right);

                return new DockLayoutPanel {
                    LastChildFill = false,
                    Children = { DateTimeLabel, TypePictureBox }
                };
            }

            RadElement CreateDescriptionElement() {
                DescriptionLabel = new LightVisualElement {
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    TextAlignment = ContentAlignment.MiddleCenter
                };

                return new BoxLayout { Children = { DescriptionLabel } };
            }
        }

        private RadElement CreateFooter() {
            NotificationLocationButton = new RadButtonElement {
                AutoSize = false,
                Size = new Size(42, 42),
                Padding = new Padding(0, 0, 4, 0),
                Shape = new RoundRectShape(8)
            };
            NotificationLocationButton.SetValue(GridLayout.ColumnIndexProperty, 0);

            SubjectLocationButton = new RadButtonElement {
                AutoSize = false,
                Size = new Size(42, 42),
                Padding = new Padding(4, 0, 4, 0),
                Shape = new RoundRectShape(8)
            };
            SubjectLocationButton.SetValue(GridLayout.ColumnIndexProperty, 1);

            ProcessNotificationButton = new RadButtonElement {
                AutoSize = false,
                Size = new Size(42, 42),
                Shape = new RoundRectShape(8)
            };
            ProcessNotificationButton.SetValue(GridLayout.ColumnIndexProperty, 3);

            return new GridLayout {
                StretchHorizontally = StretchVertically = false,
                Margin = new Padding(6, 0, 6, 6),
                Columns = new List<GridLayoutColumn> {
                    new() { SizingType = GridLayoutSizingType.Fixed, FixedWidth = 46 },
                    new() { SizingType = GridLayoutSizingType.Fixed, FixedWidth = 50 },
                    new(),
                    new() { SizingType = GridLayoutSizingType.Fixed, FixedWidth = 42 },
                },
                Children = {
                    NotificationLocationButton,
                    SubjectLocationButton,
                    ProcessNotificationButton
                }
            };
        }
    }
}