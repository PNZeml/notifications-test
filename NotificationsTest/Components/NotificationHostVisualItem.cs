using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KbAis.Desktop.Notifications.Exp.Dtos;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace KbAis.Desktop.Notifications.Exp.Components {
    internal class NotificationHostVisualItem : RadListVisualItem {
        // TODO: Make factory.
        private IReadOnlyDictionary<Type, NotificationElementBase> itemElements = null!;

        protected override void CreateChildElements() {
            base.CreateChildElements();
            TuneVisualItemAppearance();
            itemElements = new Dictionary<Type, NotificationElementBase> {
                [typeof(NotificationADto)] = new NotificationAElement(),
                [typeof(NotificationBDto)] = new NotificationBElement(),
                [typeof(NotificationCDto)] = new NotificationCElement()
            };
            foreach (var radElement in itemElements.Values) {
                Children.Add(radElement);
            }
        }

        public override void Synchronize() {
            base.Synchronize();
            DrawText = false;
            foreach (var radElement in itemElements.Values) {
                radElement.Visibility = ElementVisibility.Collapsed;
            }
            itemElements.TryGetValue(Data.DataBoundItem.GetType(), out var itemElement);
            if (itemElement != null ) {
                itemElement.Visibility = ElementVisibility.Visible;
                itemElement.SetNotificationContent(Data.DataBoundItem);
            }
        }

        private void TuneVisualItemAppearance() {
            Padding = new Padding(5);
            Shape = new RoundRectShape(3);
            BorderColor = Color.FromArgb(255, 110, 153, 210);
            BorderGradientStyle = GradientStyles.Solid;
            DrawBorder = true;
            DrawFill = true;
            BackColor = Color.FromArgb(255, 230, 238, 254);
            GradientStyle = GradientStyles.Solid;
        }
    }
}
