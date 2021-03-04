using System.Drawing;
using System.Windows.Forms;
using KbAis.Desktop.Notifications.Exp.Dtos;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace KbAis.Desktop.Notifications.Exp.Components {
    internal class NotificationAElement : NotificationElementBase {
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
                ForeColor = Color.Red
            };
            mainPanel.Children.Add(titleText);

            Children.Add(mainPanel);
        }

        public override void SetNotificationContent(object obj) {
            var notification = (NotificationADto)obj;
            titleText.Text = notification.Title;
        }
    }
}