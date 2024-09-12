namespace RewindingManager.Components
{
    partial class ButtonLine
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
            this.btnLines = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnLines
            // 
            this.btnLines.BorderRadius = 5;
            this.btnLines.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLines.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLines.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLines.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLines.ForeColor = System.Drawing.Color.White;
            this.btnLines.Location = new System.Drawing.Point(3, 3);
            this.btnLines.Name = "btnLines";
            this.btnLines.Size = new System.Drawing.Size(180, 45);
            this.btnLines.TabIndex = 3;
            this.btnLines.Text = "LINE 0";
            this.btnLines.Click += new System.EventHandler(this.btnLines_Click);
            // 
            // ButtonLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLines);
            this.Name = "ButtonLine";
            this.Size = new System.Drawing.Size(187, 52);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLines;
    }
}
