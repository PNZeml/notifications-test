using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.NotificationsList.NotificationItems {
    internal partial class EmployeeHasEnteredDumptruckAreaElement {
        private LightVisualElement employeeLabel = null!;
        private LightVisualElement equipmentLabel = null!;

        protected override RadElement CreateMiddle() {
            return new StackLayoutPanel {
                Orientation = Orientation.Vertical,
                Margin = new Padding(6, 0, 6, 0),
                Children = { CreateSubjectElement(), CreateEquipmentElement() }
            };

            RadElement CreateSubjectElement() {
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

            RadElement CreateEquipmentElement() {
                var label = new LightVisualElement {
                    Text = "Оборудование:",
                    Font = new Font("Segoe UI", 9.75f),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(label, Dock.Left);

                equipmentLabel = new LightVisualElement {
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    TextAlignment = ContentAlignment.MiddleLeft
                };
                DockLayoutPanel.SetDock(equipmentLabel, Dock.Right);

                return new DockLayoutPanel {
                    Children = { label, equipmentLabel }
                };
            }
        }
    }
}