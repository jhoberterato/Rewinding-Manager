namespace RewindingManager.Components
{
    partial class RadioLinesControl
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
            this.radioLine = new Guna.UI2.WinForms.Guna2RadioButton();
            this.SuspendLayout();
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioLine.CheckedState.BorderThickness = 0;
            this.radioLine.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioLine.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioLine.CheckedState.InnerOffset = -4;
            this.radioLine.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLine.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioLine.Location = new System.Drawing.Point(3, 3);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(64, 21);
            this.radioLine.TabIndex = 0;
            this.radioLine.Text = "LINE 0";
            this.radioLine.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioLine.UncheckedState.BorderThickness = 2;
            this.radioLine.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioLine.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioLine.CheckedChanged += new System.EventHandler(this.radioLine_CheckedChanged);
            // 
            // RadioLinesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioLine);
            this.Name = "RadioLinesControl";
            this.Size = new System.Drawing.Size(66, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RadioButton radioLine;
    }
}
