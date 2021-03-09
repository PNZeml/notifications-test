using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class WristbandIsNotAssignedElement {
        private LightVisualElement wristbandLabel = null!;

        protected override RadElement CreateMiddle() {
            return new StackLayoutPanel {
                Orientation = Orientation.Vertical,
                Margin = new Padding(6, 0, 6, 0),
                Children = { CreateWristbandElement() }
            };

            RadElement CreateWristbandElement() {
                var label = new LightVisualElement {
                    Text = "Идент. браслета:",
                    Font = new Font("Segoe UI", 9.75f),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(label, Dock.Left);

                wristbandLabel = new LightVisualElement {
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(wristbandLabel, Dock.Right);

                return new DockLayoutPanel {
                    Children = { label, wristbandLabel }
                };
            }
        }
    }
}