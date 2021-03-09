using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class EmployeeHasImmobilizedElement {
        private LightVisualElement subjectTypeLabel = null!;
        private LightVisualElement subjectValueLabel = null!;

        protected override RadElement CreateMiddle() {
            return new StackLayoutPanel {
                Orientation = Orientation.Vertical,
                Margin = new Padding(6, 0, 6, 0),
                Children = { CreateSubjectElement() }
            };

            RadElement CreateSubjectElement() {
                subjectTypeLabel = new LightVisualElement {
                    Text = "ФИО:",
                    Font = new Font("Segoe UI", 9.75f),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(subjectTypeLabel, Dock.Left);

                subjectValueLabel = new LightVisualElement {
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(subjectValueLabel, Dock.Right);

                return new DockLayoutPanel {
                    Children = { subjectTypeLabel, subjectValueLabel }
                };
            }
        }
    }
}