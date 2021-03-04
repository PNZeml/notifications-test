using System.Drawing;
using System.Windows.Forms;
using KbAis.Desktop.Notifications.Exp.Dtos;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace KbAis.Desktop.Notifications.Exp.Components
{
    internal class NotificationBElement : NotificationElementBase {
        private StackLayoutPanel mainPanel = null!;
        private LightVisualElement titleText = null!;

        protected override void CreateChildElements() {
            base.CreateChildElements();

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

        public override void SetNotificationContent(object obj) {
            var notification = (NotificationBDto)obj;
            titleText.Text = notification.Title;
        }
    }
}