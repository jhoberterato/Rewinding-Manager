using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewindingManager.Forms
{
    public partial class frmLines : Form
    {
        Classes.MainClass mainClass = new Classes.MainClass();
        Classes.MachineStatus machines = new Classes.MachineStatus();
        Classes.Lines lines = new Classes.Lines();
        Classes.Theme Theme = new Classes.Theme();
        public static string theme = "light";
        //public static int selectedLines { get; set; }
        public frmLines()
        {
            InitializeComponent();
        }

        private void Lines_Load(object sender, EventArgs e)
        {
            timer1.Start();
            plotMachines();
            plotLinesButton();
            setNotification();
            setTheme();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void others()
        {
            lblActiveLine.Text = "LINE : " + machines.linesList[machines.selectedLine];
            checkBtnNextPrev();
            colorBtnLiine();
        }

        public void plotMachines()
        {
            machines.plotMachineConditions(panelMachineCondition, theme);
            machines.plotMachines(panelMachines, theme);
            others();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            machines.selectedLine--;
            plotMachines();
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            machines.selectedLine++;
            plotMachines();
            btnPrevious.Enabled = true;
        }

        public void plotLinesButton()
        {
            Guna.UI2.WinForms.Guna2Button btnLines = new Guna.UI2.WinForms.Guna2Button();
            panelLines.Controls.Clear();
            int x = 0;
            int locationX = 12;
            foreach (String line in machines.linesList)
            {
                btnLines = new Guna.UI2.WinForms.Guna2Button();
                btnLines.Name = "btnLine" + line;
                btnLines.Text = x.ToString();
                btnLines.Size = new System.Drawing.Size(32, 32);
                btnLines.BorderRadius = 3;
                btnLines.Cursor = Cursors.Hand;
                btnLines.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
                
                btnLines.Location = new Point(locationX, 12);
                btnLines.Click += BtnLines_Click;
                if (x == machines.selectedLine)
                {
                    btnLines.BorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                    btnLines.FillColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                    btnLines.ForeColor = ColorTranslator.FromHtml(Theme.getForeColor("dark"));
                }
                else
                {
                    btnLines.BorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                    btnLines.FillColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
                    btnLines.ForeColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                    btnLines.BorderThickness = 1;
                }

                panelLines.Controls.Add(btnLines);
                locationX = locationX + 38;
                x++;
            }
        }

        private void BtnLines_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button clickedLineButton = sender as Guna.UI2.WinForms.Guna2Button;

            clickedLineButton.ForeColor = ColorTranslator.FromHtml(Theme.getForeColor("dark"));
            clickedLineButton.BorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
            clickedLineButton.FillColor = Color.Red;
            machines.selectedLine = machines.linesList.IndexOf(clickedLineButton.Text);
      
            plotMachines();

            foreach(Control control in panelLines.Controls)
            {
                if(control is Guna.UI2.WinForms.Guna2Button)
                {
                    Guna.UI2.WinForms.Guna2Button btnTemp = (Guna.UI2.WinForms.Guna2Button)control;
                    if(btnTemp.Name != "btnLine" + machines.linesList[machines.selectedLine])
                    {
                        btnTemp.BorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                        btnTemp.FillColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
                        btnTemp.ForeColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                        btnTemp.BorderThickness = 1;
                    }                    
                }
            }
        }

        private void checkBtnNextPrev()
        {
            if (machines.selectedLine == 0)
            {
                btnPrevious.Enabled = false;
                btnPrevious.DisabledState.FillColor = ColorTranslator.FromHtml(Theme.getDisabled(theme));
                btnPrevious.DisabledState.ForeColor = ColorTranslator.FromHtml(Theme.getForeColor("dark"));
                btnPrevious.DisabledState.BorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                btnPrevious.DisabledState.CustomBorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                //btnPrevious.DisabledState.BackColor = ColorTranslator.FromHtml(Theme.getDisabled(theme));
            }
            else
            {
                btnPrevious.Enabled = true;
                btnPrevious.FillColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                btnPrevious.ForeColor = ColorTranslator.FromHtml(Theme.getForeColor("dark"));
                btnPrevious.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            }
            if (machines.selectedLine == machines.linesList.Count - 1)
            {
                btnNext.Enabled = false;
                btnNext.DisabledState.FillColor = ColorTranslator.FromHtml(Theme.getDisabled(theme));
                btnNext.DisabledState.ForeColor = ColorTranslator.FromHtml(Theme.getForeColor("dark"));
                btnNext.DisabledState.BorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                btnNext.DisabledState.CustomBorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
            }
            else
            {
                btnNext.Enabled = true;
                btnNext.FillColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
                btnNext.ForeColor = ColorTranslator.FromHtml(Theme.getForeColor("dark"));
                btnNext.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            }
        }

        private void colorBtnLiine()
        {
            foreach (Control control in panelLines.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button)
                {
                    Guna.UI2.WinForms.Guna2Button btnTemp = (Guna.UI2.WinForms.Guna2Button)control;
                    if (btnTemp.Name != "btnLine" + machines.linesList[machines.selectedLine])
                    {
                        btnTemp.ForeColor = Color.Gray;
                        btnTemp.BorderColor = Color.Gray;
                        btnTemp.FillColor = Color.White;
                    }
                    else
                    {
                        btnTemp.ForeColor = Color.White;
                        btnTemp.BorderColor = ColorTranslator.FromHtml("#5E94FF");
                        btnTemp.FillColor = ColorTranslator.FromHtml("#5E94FF");
                    }
                }
            }
        }

        public String returnLine()
        {
            return machines.selectedLine.ToString();
        }

        public void refresh()
        {
            plotMachines();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setNotification();
        }

        private void setNotification()
        {
            if (machines.countNotification() == "0")
            {
                txtNotif.Visible = false;
            }
            else
            {
                txtNotif.Visible = true;
                txtNotif.Text = machines.countNotification();
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            machines.setFinished();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            //if(txtNotif.Visible == true)
            //{
            //    Notification notif = new Notification();
            //    int x = btnNotification.Location.X;
            //    int y = btnNotification.Location.Y;
            //    notif.Location = new Point(x + 100, y + 300);
            //    notif.ShowDialog();
            //}

            Notification notif = new Notification();
            int x = btnNotification.Location.X;
            int y = btnNotification.Location.Y;
            notif.Location = new Point(x + 100, y + 300);
            notif.ShowDialog();
        }

        private void toggleDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if(theme == "light")
            {
                theme = "dark";
            }
            else
            {
                theme = "light";
            }
            setTheme();
        }

        public void setTheme()
        {
            guna2Panel1.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            guna2Panel1.BorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
      
            guna2HtmlLabel1.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            guna2HtmlLabel1.ForeColor = ColorTranslator.FromHtml(Theme.getForeColor(theme));

            btnTheme.FillColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            toggleDarkMode.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            btnNotification.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            btnNotification.FillColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            guna2ImageButton1.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));

            lblMachine.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            lblMachine.ForeColor = ColorTranslator.FromHtml(Theme.getForeColor(theme));

            lblActiveLine.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            lblActiveLine.ForeColor = ColorTranslator.FromHtml(Theme.getForeColor(theme));

            panelMachineCondition.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            plotMachines();

            panelMachines.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            scrollerMachines.ThumbColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
            scrollerMachines.BorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));
            guna2HScrollBar1.FillColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            guna2HScrollBar1.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            guna2HScrollBar1.BorderColor = ColorTranslator.FromHtml(Theme.getBorderColor(theme));

            

            panelLines.BackColor = ColorTranslator.FromHtml(Theme.getBackground1(theme));
            plotLinesButton();

            checkBtnNextPrev();
        }

        private void btnPrevious_EnabledChanged(object sender, EventArgs e)
        {
            checkBtnNextPrev();
        }
    }
}
