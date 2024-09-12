namespace RewindingManager.Forms
{
    partial class frmLines
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
            this.toggleDarkMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMachine = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMachineCondition = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMachines = new Guna.UI2.WinForms.Guna2Panel();
            this.scrollerMachines = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.panelLines = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblActiveLine = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.scrollerLines = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTheme = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnNotification = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtNotif = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.guna2HScrollBar1 = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.userControl15 = new RewindingManager.Components.UserControl1();
            this.userControl16 = new RewindingManager.Components.UserControl1();
            this.userControl17 = new RewindingManager.Components.UserControl1();
            this.userControl18 = new RewindingManager.Components.UserControl1();
            this.machineStatusControl2 = new RewindingManager.Components.MachineStatusControl();
            this.machineStatusControl1 = new RewindingManager.Components.MachineStatusControl();
            this.panelMachineCondition.SuspendLayout();
            this.panelMachines.SuspendLayout();
            this.panelLines.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // toggleDarkMode
            // 
            this.toggleDarkMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleDarkMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleDarkMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleDarkMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleDarkMode.Location = new System.Drawing.Point(1043, 24);
            this.toggleDarkMode.Name = "toggleDarkMode";
            this.toggleDarkMode.Size = new System.Drawing.Size(35, 20);
            this.toggleDarkMode.TabIndex = 6;
            this.toggleDarkMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleDarkMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleDarkMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleDarkMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleDarkMode.CheckedChanged += new System.EventHandler(this.toggleDarkMode_CheckedChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(18, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(302, 39);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "REWINDING MANAGER";
            // 
            // lblMachine
            // 
            this.lblMachine.BackColor = System.Drawing.Color.Transparent;
            this.lblMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMachine.Location = new System.Drawing.Point(18, 82);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(72, 18);
            this.lblMachine.TabIndex = 7;
            this.lblMachine.Text = "STATUS : ";
            // 
            // panelMachineCondition
            // 
            this.panelMachineCondition.AutoScroll = true;
            this.panelMachineCondition.Controls.Add(this.machineStatusControl2);
            this.panelMachineCondition.Controls.Add(this.machineStatusControl1);
            this.panelMachineCondition.Location = new System.Drawing.Point(100, 75);
            this.panelMachineCondition.Name = "panelMachineCondition";
            this.panelMachineCondition.Size = new System.Drawing.Size(816, 36);
            this.panelMachineCondition.TabIndex = 8;
            // 
            // panelMachines
            // 
            this.panelMachines.AutoScroll = true;
            this.panelMachines.BackColor = System.Drawing.Color.Transparent;
            this.panelMachines.Controls.Add(this.userControl15);
            this.panelMachines.Controls.Add(this.userControl16);
            this.panelMachines.Controls.Add(this.userControl17);
            this.panelMachines.Controls.Add(this.userControl18);
            this.panelMachines.Location = new System.Drawing.Point(18, 129);
            this.panelMachines.Name = "panelMachines";
            this.panelMachines.Size = new System.Drawing.Size(1173, 328);
            this.panelMachines.TabIndex = 9;
            // 
            // scrollerMachines
            // 
            this.scrollerMachines.AutoRoundedCorners = true;
            this.scrollerMachines.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollerMachines.BindingContainer = this.panelMachines;
            this.scrollerMachines.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.scrollerMachines.BorderRadius = 8;
            this.scrollerMachines.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.scrollerMachines.FillColor = System.Drawing.SystemColors.Control;
            this.scrollerMachines.InUpdate = false;
            this.scrollerMachines.LargeChange = 10;
            this.scrollerMachines.Location = new System.Drawing.Point(18, 439);
            this.scrollerMachines.Maximum = 3725;
            this.scrollerMachines.Name = "scrollerMachines";
            this.scrollerMachines.ScrollbarSize = 18;
            this.scrollerMachines.Size = new System.Drawing.Size(1173, 18);
            this.scrollerMachines.SmallChange = 5;
            this.scrollerMachines.TabIndex = 8;
            this.scrollerMachines.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.scrollerMachines.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPrevious.BorderRadius = 3;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(363, 484);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(83, 32);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "PREVIOUS";
            this.btnPrevious.EnabledChanged += new System.EventHandler(this.btnPrevious_EnabledChanged);
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNext.BorderRadius = 3;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(727, 484);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 32);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "NEXT";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelLines
            // 
            this.panelLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLines.AutoScroll = true;
            this.panelLines.Controls.Add(this.guna2Button5);
            this.panelLines.Controls.Add(this.guna2Button4);
            this.panelLines.Controls.Add(this.guna2Button3);
            this.panelLines.Controls.Add(this.guna2Button2);
            this.panelLines.Controls.Add(this.guna2Button1);
            this.panelLines.Location = new System.Drawing.Point(465, 472);
            this.panelLines.Name = "panelLines";
            this.panelLines.Size = new System.Drawing.Size(244, 68);
            this.panelLines.TabIndex = 12;
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button5.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button5.BorderRadius = 3;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.White;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button5.Location = new System.Drawing.Point(181, 12);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(32, 32);
            this.guna2Button5.TabIndex = 19;
            this.guna2Button5.Text = "1";
            this.guna2Button5.Visible = false;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button4.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button4.BorderRadius = 3;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button4.Location = new System.Drawing.Point(143, 12);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(32, 32);
            this.guna2Button4.TabIndex = 18;
            this.guna2Button4.Text = "1";
            this.guna2Button4.Visible = false;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button3.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button3.BorderRadius = 3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button3.Location = new System.Drawing.Point(105, 12);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(32, 32);
            this.guna2Button3.TabIndex = 17;
            this.guna2Button3.Text = "1";
            this.guna2Button3.Visible = false;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button2.BorderRadius = 3;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button2.Location = new System.Drawing.Point(67, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(32, 32);
            this.guna2Button2.TabIndex = 16;
            this.guna2Button2.Text = "1";
            this.guna2Button2.Visible = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button1.BorderRadius = 3;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button1.Location = new System.Drawing.Point(29, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(32, 32);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "1";
            this.guna2Button1.Visible = false;
            // 
            // lblActiveLine
            // 
            this.lblActiveLine.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveLine.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblActiveLine.Location = new System.Drawing.Point(1135, 82);
            this.lblActiveLine.Name = "lblActiveLine";
            this.lblActiveLine.Size = new System.Drawing.Size(56, 18);
            this.lblActiveLine.TabIndex = 13;
            this.lblActiveLine.Text = "LINE : 1";
            // 
            // scrollerLines
            // 
            this.scrollerLines.AutoRoundedCorners = true;
            this.scrollerLines.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollerLines.BindingContainer = this.panelLines;
            this.scrollerLines.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.scrollerLines.BorderRadius = 8;
            this.scrollerLines.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.scrollerLines.FillColor = System.Drawing.SystemColors.Control;
            this.scrollerLines.InUpdate = false;
            this.scrollerLines.LargeChange = 954;
            this.scrollerLines.Location = new System.Drawing.Point(465, 522);
            this.scrollerLines.Maximum = 1175;
            this.scrollerLines.Name = "scrollerLines";
            this.scrollerLines.ScrollbarSize = 18;
            this.scrollerLines.Size = new System.Drawing.Size(244, 18);
            this.scrollerLines.SmallChange = 5;
            this.scrollerLines.TabIndex = 14;
            this.scrollerLines.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.scrollerLines.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.btnTheme);
            this.guna2Panel1.Controls.Add(this.guna2CircleButton1);
            this.guna2Panel1.Controls.Add(this.btnNotification);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1211, 571);
            this.guna2Panel1.TabIndex = 15;
            // 
            // btnTheme
            // 
            this.btnTheme.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTheme.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTheme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTheme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTheme.FillColor = System.Drawing.SystemColors.Control;
            this.btnTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.Image = global::RewindingManager.Properties.Resources.Moon__Sleep__Night__Midnight__Bedtime_512_removebg_preview;
            this.btnTheme.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTheme.Location = new System.Drawing.Point(996, 20);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTheme.Size = new System.Drawing.Size(42, 32);
            this.btnTheme.TabIndex = 2;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2CircleButton1.Image = global::RewindingManager.Properties.Resources.f2584f450c74bee72c123c4184c58df7_removebg_preview;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.Location = new System.Drawing.Point(579, 266);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.PressedColor = System.Drawing.SystemColors.Control;
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(53, 39);
            this.guna2CircleButton1.TabIndex = 1;
            // 
            // btnNotification
            // 
            this.btnNotification.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotification.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotification.FillColor = System.Drawing.SystemColors.Control;
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnNotification.Image = global::RewindingManager.Properties.Resources.f2584f450c74bee72c123c4184c58df7_removebg_preview;
            this.btnNotification.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNotification.Location = new System.Drawing.Point(1094, 14);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.PressedColor = System.Drawing.SystemColors.Control;
            this.btnNotification.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNotification.Size = new System.Drawing.Size(53, 39);
            this.btnNotification.TabIndex = 0;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // txtNotif
            // 
            this.txtNotif.Location = new System.Drawing.Point(35, 0);
            this.txtNotif.TargetControl = this.btnNotification;
            // 
            // guna2HScrollBar1
            // 
            this.guna2HScrollBar1.AutoRoundedCorners = true;
            this.guna2HScrollBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2HScrollBar1.BindingContainer = this.panelMachines;
            this.guna2HScrollBar1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.guna2HScrollBar1.BorderRadius = 8;
            this.guna2HScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.guna2HScrollBar1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2HScrollBar1.InUpdate = false;
            this.guna2HScrollBar1.LargeChange = 1173;
            this.guna2HScrollBar1.Location = new System.Drawing.Point(18, 439);
            this.guna2HScrollBar1.Maximum = 3725;
            this.guna2HScrollBar1.Name = "guna2HScrollBar1";
            this.guna2HScrollBar1.ScrollbarSize = 18;
            this.guna2HScrollBar1.Size = new System.Drawing.Size(1173, 18);
            this.guna2HScrollBar1.SmallChange = 5;
            this.guna2HScrollBar1.TabIndex = 16;
            this.guna2HScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2HScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Interval = 10000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.Image = global::RewindingManager.Properties.Resources.signs_close_icon_png_removebg_preview;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Image = global::RewindingManager.Properties.Resources.signs_close_icon_png_removebg_preview;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1156, 17);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = global::RewindingManager.Properties.Resources.signs_close_icon_png_removebg_preview;
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Size = new System.Drawing.Size(34, 32);
            this.guna2ImageButton1.TabIndex = 5;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // userControl15
            // 
            this.userControl15.Location = new System.Drawing.Point(3341, 160);
            this.userControl15.Name = "userControl15";
            this.userControl15.Size = new System.Drawing.Size(385, 145);
            this.userControl15.TabIndex = 7;
            // 
            // userControl16
            // 
            this.userControl16.Location = new System.Drawing.Point(2950, 160);
            this.userControl16.Name = "userControl16";
            this.userControl16.Size = new System.Drawing.Size(385, 145);
            this.userControl16.TabIndex = 6;
            // 
            // userControl17
            // 
            this.userControl17.Location = new System.Drawing.Point(2559, 160);
            this.userControl17.Name = "userControl17";
            this.userControl17.Size = new System.Drawing.Size(385, 145);
            this.userControl17.TabIndex = 5;
            // 
            // userControl18
            // 
            this.userControl18.Location = new System.Drawing.Point(2168, 160);
            this.userControl18.Name = "userControl18";
            this.userControl18.Size = new System.Drawing.Size(385, 145);
            this.userControl18.TabIndex = 4;
            // 
            // machineStatusControl2
            // 
            this.machineStatusControl2.Location = new System.Drawing.Point(173, 7);
            this.machineStatusControl2.Name = "machineStatusControl2";
            this.machineStatusControl2.Size = new System.Drawing.Size(164, 22);
            this.machineStatusControl2.TabIndex = 1;
            // 
            // machineStatusControl1
            // 
            this.machineStatusControl1.BackColor = System.Drawing.Color.White;
            this.machineStatusControl1.Location = new System.Drawing.Point(3, 7);
            this.machineStatusControl1.Name = "machineStatusControl1";
            this.machineStatusControl1.Size = new System.Drawing.Size(164, 22);
            this.machineStatusControl1.TabIndex = 0;
            // 
            // frmLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 570);
            this.ControlBox = false;
            this.Controls.Add(this.guna2HScrollBar1);
            this.Controls.Add(this.scrollerLines);
            this.Controls.Add(this.panelLines);
            this.Controls.Add(this.lblActiveLine);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.panelMachines);
            this.Controls.Add(this.panelMachineCondition);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.toggleDarkMode);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Lines_Load);
            this.panelMachineCondition.ResumeLayout(false);
            this.panelMachines.ResumeLayout(false);
            this.panelLines.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleDarkMode;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMachine;
        private Guna.UI2.WinForms.Guna2Panel panelMachineCondition;
        private Components.MachineStatusControl machineStatusControl2;
        private Components.MachineStatusControl machineStatusControl1;
        private Guna.UI2.WinForms.Guna2Panel panelMachines;
        private Components.UserControl1 userControl15;
        private Components.UserControl1 userControl16;
        private Components.UserControl1 userControl17;
        private Components.UserControl1 userControl18;
        private Guna.UI2.WinForms.Guna2HScrollBar scrollerMachines;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Panel panelLines;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblActiveLine;
        private Guna.UI2.WinForms.Guna2HScrollBar scrollerLines;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2NotificationPaint txtNotif;
        private Guna.UI2.WinForms.Guna2HScrollBar guna2HScrollBar1;
        private System.Windows.Forms.Timer timerCheck;
        private Guna.UI2.WinForms.Guna2CircleButton btnTheme;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton btnNotification;
    }
}