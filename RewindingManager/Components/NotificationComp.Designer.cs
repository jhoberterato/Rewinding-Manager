namespace RewindingManager.Components
{
    partial class NotificationComp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFinish = new Guna.UI2.WinForms.Guna2Button();
            this.sepFinish = new Guna.UI2.WinForms.Guna2Separator();
            this.txtMachineID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMCNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLine = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnFinish.BorderRadius = 3;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinish.FillColor = System.Drawing.SystemColors.Control;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.Gray;
            this.btnFinish.Location = new System.Drawing.Point(3, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(266, 33);
            this.btnFinish.TabIndex = 23;
            this.btnFinish.Text = "RM#45 Line 2 [Left] is finished.";
            this.btnFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // sepFinish
            // 
            this.sepFinish.Location = new System.Drawing.Point(3, 32);
            this.sepFinish.Name = "sepFinish";
            this.sepFinish.Size = new System.Drawing.Size(266, 18);
            this.sepFinish.TabIndex = 22;
            // 
            // txtMachineID
            // 
            this.txtMachineID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMachineID.DefaultText = "4XXXX";
            this.txtMachineID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMachineID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMachineID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMachineID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMachineID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMachineID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMachineID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMachineID.Location = new System.Drawing.Point(181, 16);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.PasswordChar = '\0';
            this.txtMachineID.PlaceholderText = "";
            this.txtMachineID.ReadOnly = true;
            this.txtMachineID.SelectedText = "";
            this.txtMachineID.Size = new System.Drawing.Size(88, 20);
            this.txtMachineID.TabIndex = 44;
            this.txtMachineID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMachineID.Visible = false;
            // 
            // txtMCNo
            // 
            this.txtMCNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMCNo.DefaultText = "4XXXX";
            this.txtMCNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMCNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMCNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMCNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMCNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMCNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMCNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMCNo.Location = new System.Drawing.Point(87, 16);
            this.txtMCNo.Name = "txtMCNo";
            this.txtMCNo.PasswordChar = '\0';
            this.txtMCNo.PlaceholderText = "";
            this.txtMCNo.ReadOnly = true;
            this.txtMCNo.SelectedText = "";
            this.txtMCNo.Size = new System.Drawing.Size(88, 20);
            this.txtMCNo.TabIndex = 45;
            this.txtMCNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMCNo.Visible = false;
            // 
            // txtLine
            // 
            this.txtLine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLine.DefaultText = "4XXXX";
            this.txtLine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLine.Location = new System.Drawing.Point(3, 16);
            this.txtLine.Name = "txtLine";
            this.txtLine.PasswordChar = '\0';
            this.txtLine.PlaceholderText = "";
            this.txtLine.ReadOnly = true;
            this.txtLine.SelectedText = "";
            this.txtLine.Size = new System.Drawing.Size(88, 20);
            this.txtLine.TabIndex = 46;
            this.txtLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLine.Visible = false;
            // 
            // NotificationComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.txtMCNo);
            this.Controls.Add(this.txtMachineID);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.sepFinish);
            this.Name = "NotificationComp";
            this.Size = new System.Drawing.Size(273, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnFinish;
        private Guna.UI2.WinForms.Guna2Separator sepFinish;
        private Guna.UI2.WinForms.Guna2TextBox txtMachineID;
        private Guna.UI2.WinForms.Guna2TextBox txtMCNo;
        private Guna.UI2.WinForms.Guna2TextBox txtLine;
    }
}
