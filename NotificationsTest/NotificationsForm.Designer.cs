namespace KbAis.Desktop.Notifications.Exp
{
    partial class NotificationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.RadButton btnRemoveNotficiation;
            this.thmFluent = new Telerik.WinControls.Themes.FluentTheme();
            this.lcNotifications = new Telerik.WinControls.UI.RadListControl();
            this.btnAddNotification = new Telerik.WinControls.UI.RadButton();
            btnRemoveNotficiation = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.lcNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnRemoveNotficiation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lcNotifications
            // 
            this.lcNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lcNotifications.ItemHeight = 60;
            this.lcNotifications.AutoSizeItems = false;
            this.lcNotifications.Location = new System.Drawing.Point(12, 12);
            this.lcNotifications.Name = "lcNotifications";
            this.lcNotifications.Size = new System.Drawing.Size(387, 453);
            this.lcNotifications.TabIndex = 0;
            this.lcNotifications.ThemeName = "Fluent";
            // 
            // btnAddNotification
            // 
            this.btnAddNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNotification.Location = new System.Drawing.Point(12, 471);
            this.btnAddNotification.Name = "btnAddNotification";
            this.btnAddNotification.Size = new System.Drawing.Size(110, 24);
            this.btnAddNotification.TabIndex = 1;
            this.btnAddNotification.Text = "Add";
            this.btnAddNotification.ThemeName = "Fluent";
            // 
            // btnRemoveNotficiation
            // 
            btnRemoveNotficiation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            btnRemoveNotficiation.Location = new System.Drawing.Point(128, 471);
            btnRemoveNotficiation.Name = "btnRemoveNotficiation";
            btnRemoveNotficiation.Size = new System.Drawing.Size(110, 24);
            btnRemoveNotficiation.TabIndex = 2;
            btnRemoveNotficiation.Text = "Remove";
            btnRemoveNotficiation.ThemeName = "Fluent";
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 507);
            this.Controls.Add(btnRemoveNotficiation);
            this.Controls.Add(this.btnAddNotification);
            this.Controls.Add(this.lcNotifications);
            this.Name = "NotificationsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "NotificationsForm";
            this.ThemeName = "Fluent";
            ((System.ComponentModel.ISupportInitialize)(this.lcNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnRemoveNotficiation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.FluentTheme thmFluent;
        private Telerik.WinControls.UI.RadListControl lcNotifications;
        private Telerik.WinControls.UI.RadButton btnAddNotification;
    }
}
