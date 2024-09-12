namespace RewindingManager.Forms
{
    partial class Notification
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panelNotif = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNoNotification = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.notificationComp2 = new RewindingManager.Components.NotificationComp();
            this.notificationComp1 = new RewindingManager.Components.NotificationComp();
            this.guna2Panel1.SuspendLayout();
            this.panelNotif.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.btnCancel);
            this.guna2Panel1.Controls.Add(this.panelNotif);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(309, 307);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCancel.BorderRadius = 3;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(211, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 32);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "CLOSE";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelNotif
            // 
            this.panelNotif.AutoScroll = true;
            this.panelNotif.Controls.Add(this.lblNoNotification);
            this.panelNotif.Controls.Add(this.notificationComp2);
            this.panelNotif.Controls.Add(this.notificationComp1);
            this.panelNotif.Location = new System.Drawing.Point(13, 13);
            this.panelNotif.Name = "panelNotif";
            this.panelNotif.Size = new System.Drawing.Size(281, 241);
            this.panelNotif.TabIndex = 1;
            // 
            // lblNoNotification
            // 
            this.lblNoNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNoNotification.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNoNotification.Location = new System.Drawing.Point(89, 119);
            this.lblNoNotification.Name = "lblNoNotification";
            this.lblNoNotification.Size = new System.Drawing.Size(109, 15);
            this.lblNoNotification.TabIndex = 2;
            this.lblNoNotification.Text = "No new notification. . .";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelNotif;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // notificationComp2
            // 
            this.notificationComp2.Location = new System.Drawing.Point(3, 54);
            this.notificationComp2.Name = "notificationComp2";
            this.notificationComp2.Size = new System.Drawing.Size(273, 45);
            this.notificationComp2.TabIndex = 1;
            // 
            // notificationComp1
            // 
            this.notificationComp1.Location = new System.Drawing.Point(3, 3);
            this.notificationComp1.Name = "notificationComp1";
            this.notificationComp1.Size = new System.Drawing.Size(273, 45);
            this.notificationComp1.TabIndex = 0;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 306);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.Notification_Deactivate);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelNotif.ResumeLayout(false);
            this.panelNotif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelNotif;
        private Components.NotificationComp notificationComp1;
        private Components.NotificationComp notificationComp2;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoNotification;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}