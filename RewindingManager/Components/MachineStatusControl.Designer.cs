namespace RewindingManager.Components
{
    partial class MachineStatusControl
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
            this.lblStatusCondition = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnStatusColor = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // lblStatusCondition
            // 
            this.lblStatusCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusCondition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCondition.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStatusCondition.Location = new System.Drawing.Point(27, 1);
            this.lblStatusCondition.Name = "lblStatusCondition";
            this.lblStatusCondition.Size = new System.Drawing.Size(118, 19);
            this.lblStatusCondition.TabIndex = 8;
            this.lblStatusCondition.Text = "NO LOAD/NO MAT";
            // 
            // btnStatusColor
            // 
            this.btnStatusColor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatusColor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatusColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatusColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatusColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatusColor.ForeColor = System.Drawing.Color.White;
            this.btnStatusColor.Location = new System.Drawing.Point(3, 3);
            this.btnStatusColor.Name = "btnStatusColor";
            this.btnStatusColor.Size = new System.Drawing.Size(18, 16);
            this.btnStatusColor.TabIndex = 9;
            // 
            // MachineStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStatusColor);
            this.Controls.Add(this.lblStatusCondition);
            this.Name = "MachineStatusControl";
            this.Size = new System.Drawing.Size(164, 22);
            this.Load += new System.EventHandler(this.MachineStatusControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatusCondition;
        private Guna.UI2.WinForms.Guna2TileButton btnStatusColor;
    }
}
