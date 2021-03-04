using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.Elements {
    internal partial class NotificationAElement {
        // TOP
        private LightVisualElement dateTimeLabel = null!;
        private LightVisualElement typePictureBox = null!;
        private LightVisualElement descriptionLabel = null!;
        // MIDDLE
        private LightVisualElement employeeLabel = null!;
        private LightVisualElement heartRateVariabilityLabel = null!;
        // BOTTOM
        private RadButtonElement notificationLocButton = null!;
        private RadButtonElement subjectLocButton = null!;
        private RadButtonElement notificationResButton = null!;

        protected override void CreateChildElements() {
            var host = new StackLayoutPanel {
                Orientation = Orientation.Vertical,
                Children = { CreateHeader(), CreateMiddle(), CreateFooter() }
            };
            Children.Add(host);

            notificationLocButton.Click += (_, _) => NotificationLocationClickInvoke();
        }

        private LayoutPanel CreateHeader() {
            return new StackLayoutPanel {
                Orientation = Orientation.Vertical,
                Margin = new Padding(6, 6, 6, 0),
                Children = { CreatePanelA(), CreatePanelB() }
            };

            LayoutPanel CreatePanelA() {
                dateTimeLabel = new LightVisualElement {
                    Font = new Font("Segoe UI", 9.75f),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(dateTimeLabel, Dock.Left);

                typePictureBox = new LightVisualElement {
                    AutoSize = false,
                    Size = new Size(30, 30),
                    BackColor = Color.OrangeRed,
                    DrawFill = true,
                    GradientStyle = GradientStyles.Solid
                };
                DockLayoutPanel.SetDock(typePictureBox, Dock.Right);

                return new DockLayoutPanel {
                    LastChildFill = false,
                    Children = { dateTimeLabel, typePictureBox }
                };
            }

            LayoutPanel CreatePanelB() {
                descriptionLabel = new LightVisualElement {
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    TextAlignment = ContentAlignment.MiddleCenter
                };

                return new BoxLayout {
                    Children = {descriptionLabel}
                };
            }
        }

        private LayoutPanel CreateMiddle() {
            return new StackLayoutPanel {
                Orientation = Orientation.Vertical,
                Margin = new Padding(6, 0, 6, 0),
                Children = { CreatePanelA(), CreatePanelB() }
            };

            LayoutPanel CreatePanelA() {
                var label = new LightVisualElement {
                    Text = "Name:",
                    Font = new Font("Segoe UI", 9.75f),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(label, Dock.Left);

                employeeLabel = new LightVisualElement {
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(employeeLabel, Dock.Right);

                return new DockLayoutPanel {
                    Children = { label, employeeLabel }
                };
            }

            LayoutPanel CreatePanelB() {
                var label = new LightVisualElement {
                    Text = "HRV:",
                    Font = new Font("Segoe UI", 9.75f),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(label, Dock.Left);

                heartRateVariabilityLabel = new LightVisualElement {
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(heartRateVariabilityLabel, Dock.Right);

                return new DockLayoutPanel {
                    Children = { label, heartRateVariabilityLabel }
                };
            }
        }

        private LayoutPanel CreateFooter() {
            notificationLocButton = new RadButtonElement {
                AutoSize = false,
                Size = new Size(42, 42),
                Padding = new Padding(0, 0, 4, 0)
            };
            notificationLocButton.SetValue(GridLayout.ColumnIndexProperty, 0);

            subjectLocButton = new RadButtonElement {
                AutoSize = false,
                Size = new Size(42, 42),
                Padding = new Padding(4, 0, 4, 0)
            };
            subjectLocButton.SetValue(GridLayout.ColumnIndexProperty, 1);

            notificationResButton = new RadButtonElement {
                AutoSize = false,
                Size = new Size(42, 42)
            };
            notificationResButton.SetValue(GridLayout.ColumnIndexProperty, 3);

            return new GridLayout {
                StretchHorizontally = StretchVertically = false,
                Margin = new Padding(6, 0, 6, 6),
                Columns = new List<GridLayoutColumn> {
                    new() { SizingType = GridLayoutSizingType.Fixed, FixedWidth = 46 },
                    new() { SizingType = GridLayoutSizingType.Fixed, FixedWidth = 50 },
                    new(),
                    new() { SizingType = GridLayoutSizingType.Fixed, FixedWidth = 42 },
                },
                Children = { notificationLocButton, subjectLocButton, notificationResButton }
            };
        }
    }
}