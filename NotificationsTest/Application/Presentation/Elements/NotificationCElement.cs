using System.Drawing;
using System.Windows.Forms;
using NotificationsTest.Application.Services.Dtos;
using NotificationsTest.Domain;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.Elements {
    internal class NotificationCElement : NotificationElementBase {
        private StackLayoutPanel mainPanel = null!;
        private LightVisualElement titleText = null!;
        private LightVisualElement employeeNameText = null!;

        protected override void CreateChildElements() {
            mainPanel = new StackLayoutPanel {
                Orientation = Orientation.Vertical
            };
            titleText = new LightVisualElement {
                TextAlignment = ContentAlignment.MiddleLeft,
                Margin = new Padding(10),
                ForeColor = Color.Green
            };
            employeeNameText = new LightVisualElement {
                TextAlignment = ContentAlignment.MiddleLeft,
                Margin = new Padding(10),
                ForeColor = Color.Green
            };
            mainPanel.Children.AddRange(titleText, employeeNameText);

            Children.Add(mainPanel);
        }

        public override void UpdateContent(INotification newNotification) {
            var notificationC = (NotificationCDto)newNotification;
            titleText.Text = notificationC.Description;
            employeeNameText.Text = notificationC.Employee;
        }
    }
}