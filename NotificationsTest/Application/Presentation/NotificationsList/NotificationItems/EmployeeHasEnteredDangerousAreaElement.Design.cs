using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class EmployeeHasEnteredDangerousAreaElement {
        private LightVisualElement employeeLabel = null!;
        private LightVisualElement staticAreaLabel = null!;

        protected override RadElement CreateMiddle() {
            return new StackLayoutPanel {
                Orientation = Orientation.Vertical,
                Margin = new Padding(6, 0, 6, 0),
                Children = { CreateEmployeeElement(), CreateStaticAreaElement() }
            };

            RadElement CreateEmployeeElement() {
                var label = new LightVisualElement {
                    Text = "ФИО:",
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

            RadElement CreateStaticAreaElement() {
                var label = new LightVisualElement {
                    Text = "Зона:",
                    Font = new Font("Segoe UI", 9.75f),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(label, Dock.Left);

                staticAreaLabel = new LightVisualElement {
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(staticAreaLabel, Dock.Right);

                return new DockLayoutPanel {
                    Children = { label, staticAreaLabel }
                };
            }
        }
    }
}