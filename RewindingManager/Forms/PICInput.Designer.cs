namespace RewindingManager.Forms
{
    partial class PICInput
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
            this.lblLineNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPIC = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblLineNo
            // 
            this.lblLineNo.BackColor = System.Drawing.Color.Transparent;
            this.lblLineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLineNo.Location = new System.Drawing.Point(12, 12);
            this.lblLineNo.Name = "lblLineNo";
            this.lblLineNo.Size = new System.Drawing.Size(35, 18);
            this.lblLineNo.TabIndex = 17;
            this.lblLineNo.Text = "PIC : ";
            this.lblLineNo.Click += new System.EventHandler(this.lblLineNo_Click);
            // 
            // txtPIC
            // 
            this.txtPIC.BorderRadius = 5;
            this.txtPIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPIC.DefaultText = "";
            this.txtPIC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPIC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPIC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPIC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPIC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPIC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPIC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPIC.Location = new System.Drawing.Point(53, 12);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.PasswordChar = '\0';
            this.txtPIC.PlaceholderText = "Enter PIC. . .";
            this.txtPIC.SelectedText = "";
            this.txtPIC.Size = new System.Drawing.Size(216, 36);
            this.txtPIC.TabIndex = 18;
            this.txtPIC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPIC_KeyDown);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "Success!";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // PICInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 67);
            this.ControlBox = false;
            this.Controls.Add(this.txtPIC);
            this.Controls.Add(this.lblLineNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PICInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PICInput_Load);
            this.Shown += new System.EventHandler(this.PICInput_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLineNo;
        private Guna.UI2.WinForms.Guna2TextBox txtPIC;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}