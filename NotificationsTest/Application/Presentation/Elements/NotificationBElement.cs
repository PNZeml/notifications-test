using System.Drawing;
using System.Windows.Forms;
using NotificationsTest.Application.Services.Dtos;
using NotificationsTest.Domain;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace NotificationsTest.Application.Presentation.Elements {
    internal class NotificationBElement : NotificationElementBase {
        private StackLayoutPanel mainPanel = null!;
        private LightVisualElement titleText = null!;

        protected override void CreateChildElements() {
            mainPanel = new StackLayoutPanel {
                Orientation = Orientation.Vertical
            };
            titleText = new LightVisualElement {
                TextAlignment = ContentAlignment.MiddleLeft,
                Margin = new Padding(10),
                ForeColor = Color.Blue
            };
            mainPanel.Children.Add(titleText);

            Children.Add(mainPanel);
        }

        public override void UpdateContent(INotification newNotification) {
            var notificationB = (NotificationBDto)newNotification;
            titleText.Text = notificationB.Description;
        }
    }
}