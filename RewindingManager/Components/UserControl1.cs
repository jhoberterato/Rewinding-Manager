using Guna.UI2.WinForms;
using RewindingManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewindingManager.Components
{
    public partial class UserControl1 : UserControl
    {
        Classes.Notification percentProg = new Classes.Notification();
        Classes.MachineStatus mcStat = new Classes.MachineStatus();
        private Guna.UI2.WinForms.Guna2TextBox _txtMachineID;
        
        private Guna.UI2.WinForms.Guna2Button _btn;

        private Guna.UI2.WinForms.Guna2TextBox _txtLeftLotNo;
        private Guna.UI2.WinForms.Guna2TextBox _txtLeftArticleNo;
        private Guna.UI2.WinForms.Guna2TextBox _txtCenterLotNo;
        private Guna.UI2.WinForms.Guna2TextBox _txtCenterArticleNo;
        private Guna.UI2.WinForms.Guna2TextBox _txtRightLotNo;
        private Guna.UI2.WinForms.Guna2TextBox _txtRightArticleNo;

        private Guna.UI2.WinForms.Guna2TextBox _txtLeftInst;
        private Guna.UI2.WinForms.Guna2TextBox _txtLeftSpec;
        private Guna.UI2.WinForms.Guna2TextBox _txtCenterInst;
        private Guna.UI2.WinForms.Guna2TextBox _txtCenterSpec;
        private Guna.UI2.WinForms.Guna2TextBox _txtRightInst;
        private Guna.UI2.WinForms.Guna2TextBox _txtRightSpec;

        private Guna.UI2.WinForms.Guna2TextBox _txtLeftDia;
        private Guna.UI2.WinForms.Guna2TextBox _txtLeftLength;
        private Guna.UI2.WinForms.Guna2TextBox _txtCenterDia;
        private Guna.UI2.WinForms.Guna2TextBox _txtCenterLength;
        private Guna.UI2.WinForms.Guna2TextBox _txtRightDia;
        private Guna.UI2.WinForms.Guna2TextBox _txtRightLength;

        private Guna.UI2.WinForms.Guna2TextBox _txtLeftDate;
        private Guna.UI2.WinForms.Guna2TextBox _txtLeftTime;
        private Guna.UI2.WinForms.Guna2TextBox _txtCenterDate;
        private Guna.UI2.WinForms.Guna2TextBox _txtCenterTime;
        private Guna.UI2.WinForms.Guna2TextBox _txtRightDate;
        private Guna.UI2.WinForms.Guna2TextBox _txtRightTime;

        public Guna.UI2.WinForms.Guna2Panel _panelLeft;
        public Guna.UI2.WinForms.Guna2Panel _panelCenter;
        public Guna.UI2.WinForms.Guna2Panel _panelRight;

        public Guna.UI2.WinForms.Guna2TextBox _txtStartDate;

        public Timer _timerLeft;
        public Timer _timerCenter;
        public Timer _timerRight;

        public Guna.UI2.WinForms.Guna2HtmlLabel _lblLeftProgress;
        public Guna.UI2.WinForms.Guna2HtmlLabel _lblCenterProgress;
        public Guna.UI2.WinForms.Guna2HtmlLabel _lblRightProgress;

        /*---------Machine ID---------*/
        public Guna.UI2.WinForms.Guna2TextBox TxtMachineID
        {
            get { return _txtMachineID; }
            set { _txtMachineID = value; }
        }

        /*---------Machine Button---------*/
        public Guna.UI2.WinForms.Guna2Button MachineText
        {
            get { return _btn; }
            set { _btn = value; }
        }

        /*---------LCR TextBox Lot/Article---------*/
        public Guna.UI2.WinForms.Guna2TextBox TxtLeftLotNo
        {
            get { return _txtLeftLotNo; }
            set { _txtLeftLotNo = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtCenterLotNo
        {
            get { return _txtCenterLotNo; }
            set { _txtCenterLotNo = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtRightLotNo
        {
            get { return _txtRightLotNo; }
            set { _txtRightLotNo = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtLeftArticleNo
        {
            get { return _txtLeftArticleNo; }
            set { _txtLeftArticleNo = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtCenterArticleNo
        {
            get { return _txtCenterArticleNo; }
            set { _txtCenterArticleNo = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtRightArticleNo
        {
            get { return _txtRightArticleNo; }
            set { _txtRightArticleNo = value; }
        }

        /*---------LCR TextBox Inst/Spec---------*/
        public Guna.UI2.WinForms.Guna2TextBox TxtLeftInst
        {
            get { return _txtLeftInst; }
            set { _txtLeftInst = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtLeftSpec
        {
            get { return _txtLeftSpec; }
            set { _txtLeftSpec = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtCenterInst
        {
            get { return _txtCenterInst; }
            set { _txtCenterInst = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtCenterSpec
        {
            get { return _txtCenterSpec; }
            set { _txtCenterSpec = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtRightInst
        {
            get { return _txtRightInst; }
            set { _txtRightInst = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtRightSpec
        {
            get { return _txtRightSpec; }
            set { _txtRightSpec = value; }
        }

        /*---------LCR TextBox Dia/Length---------*/
        public Guna.UI2.WinForms.Guna2TextBox TxtLeftDia
        {
            get { return _txtLeftDia; }
            set { _txtLeftDia = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtLeftLength
        {
            get { return _txtLeftLength; }
            set { _txtLeftLength = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtCenterDia
        {
            get { return _txtCenterDia; }
            set { _txtCenterDia = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtCenterLength
        {
            get { return _txtCenterLength; }
            set { _txtCenterLength = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtRightDia
        {
            get { return _txtRightDia; }
            set { _txtRightDia = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtRightLength
        {
            get { return _txtRightLength; }
            set { _txtRightLength = value; }
        }

        /*---------LCR TextBox Dia/Length---------*/
        public Guna.UI2.WinForms.Guna2TextBox TxtLeftDate
        {
            get { return _txtLeftDate; }
            set { _txtLeftDate = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtLeftTime
        {
            get { return _txtLeftTime; }
            set { _txtLeftTime = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtCenterDate
        {
            get { return _txtCenterDate; }
            set { _txtCenterDate = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtCenterTime
        {
            get { return _txtCenterTime; }
            set { _txtCenterTime = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtRightDate
        {
            get { return _txtRightDate; }
            set { _txtRightDate = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtRightTime
        {
            get { return _txtRightTime; }
            set { _txtRightTime = value; }
        }

        /*---------LCR Panel Circle Progress Bar---------*/
        public Guna.UI2.WinForms.Guna2Panel PanelLeft
        {
            get { return _panelLeft; }
            set { _panelLeft = value; }
        }
        public Guna.UI2.WinForms.Guna2Panel PanelCenter
        {
            get { return _panelCenter; }
            set { _panelCenter = value; }
        }
        public Guna.UI2.WinForms.Guna2Panel PanelRight
        {
            get { return _panelRight; }
            set { _panelRight = value; }
        }

        /*---------Start Date---------*/
        public Guna.UI2.WinForms.Guna2TextBox TxtStartDate
        {
            get { return _txtStartDate; }
            set { _txtStartDate = value; }
        }

        /*---------LCR Timer Dia/Length---------*/
        public Timer TimerLeft
        {
            get { return _timerLeft; }
            set { _timerLeft = value; }
        }
        public Timer TimerCenter
        {
            get { return _timerCenter; }
            set { _timerCenter = value; }
        }
        public Timer TimerRight
        {
            get { return _timerRight; }
            set { _timerRight = value; }
        }


        /*---------LCR Label Progress Bar---------*/
        public Guna.UI2.WinForms.Guna2HtmlLabel LabelProgressLeft
        {
            get { return _lblLeftProgress; }
            set { _lblLeftProgress = value; }
        }
        public Guna.UI2.WinForms.Guna2HtmlLabel LabelProgressCenter
        {
            get { return _lblCenterProgress; }
            set { _lblCenterProgress = value; }
        }
        public Guna.UI2.WinForms.Guna2HtmlLabel LabelProgressRight
        {
            get { return _lblRightProgress; }
            set { _lblRightProgress = value; }
        }

        public UserControl1()
        {
            InitializeComponent();
            _txtMachineID = txtMachineID;

            _btn = btnRMNo;

            _txtLeftLotNo = txtLeftLotNo;
            _txtLeftArticleNo = txtLeftArticleNo;
            _txtCenterLotNo = txtCenterLotNo;
            _txtCenterArticleNo = txtCenterArticleNo;
            _txtRightLotNo = txtRightLotNo;
            _txtRightArticleNo = txtRightArticleNo;

            _txtLeftInst = txtLeftInst;
            _txtLeftSpec = txtLeftSpec;
            _txtCenterInst = txtCenterInst;
            _txtCenterSpec = txtCenterSpec;
            _txtRightInst = txtRightInst;
            _txtRightSpec = txtRightSpec;

            _txtLeftDia = txtLeftDia;
            _txtLeftLength = txtLeftLength;
            _txtCenterDia = txtCenterDia;
            _txtCenterLength = txtCenterLength;
            _txtRightDia = txtRightDia;
            _txtRightLength = txtRightLength;

            _txtLeftDate = txtLeftDate;
            _txtLeftTime = txtLeftTime;
            _txtCenterDate = txtCenterDate;
            _txtCenterTime = txtCenterTime;
            _txtRightDate = txtRightDate;
            _txtRightTime = txtRightTime;

            _panelLeft = panelLeft;
            _panelCenter = panelCenter;
            _panelRight = panelRight;

            _txtStartDate = txtStartDate;

            _timerLeft = timerLeft;
            _timerCenter = timerCenter;
            _timerRight = timerRight;

            _lblLeftProgress = lblLeftProgress;
            _lblCenterProgress = lblCenterProgress;
            _lblRightProgress = lblRightProgress;
        }

        private void btnRMNo_Click(object sender, EventArgs e)
        {
            openMachine();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            txtLeft.ContextMenuStrip = cmsLeft;
            txtCenter.ContextMenuStrip = cmsCenter;
            txtRight.ContextMenuStrip = cmsRight;
        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            if(txtLeftArticleNo.Text != "")
            {
                progressBarTimer(progressLeft, lblLeftProgress, timerLeft, txtLeftInst.Text, txtLeftArticleNo.Text, txtLeftLotNo.Text, "Left");
            }
            
        }

        private void timerCenter_Tick(object sender, EventArgs e)
        {
            if(txtCenterArticleNo.Text != "")
            {
                progressBarTimer(progressCenter, lblCenterProgress, timerCenter, txtCenterInst.Text, txtCenterArticleNo.Text, txtCenterLotNo.Text, "Center");
            }
            
        }

        private void timerRight_Tick(object sender, EventArgs e)
        {
            if(txtRightArticleNo.Text != "")
            {
                progressBarTimer(progressRight, lblRightProgress, timerRight, txtRightInst.Text, txtRightArticleNo.Text, txtRightLotNo.Text, "Right");
            }
        }

        private void progressBarTimer(Guna.UI2.WinForms.Guna2CircleProgressBar progress, Guna.UI2.WinForms.Guna2HtmlLabel label, Timer timer, string ins, string art, string lot, string LCR)
        {
            if (progress.Value == progress.Maximum)
            {
                timer.Stop();
                SetFinished(LCR);
            } 
            else
            {
                progress.Value = (int)Math.Floor(percentProg.getProgress(ins, art, lot));
            }

            label.Text = percentProg.getProgressLabel(ins, art);
        }

        private void openMachine()
        {
            frmMachine machineInterface = new frmMachine();
            Form frmLine = Application.OpenForms["frmLines"];
            if (frmLine != null && frmLine is frmLines)
            {
                frmLines line = (frmLines)frmLine;
                machineInterface.set_Line_McNo_McID(line.returnLine(), MachineText.Text.Substring(2), txtMachineID.Text);
            }


            machineInterface.ShowDialog();
        }

        private void cmsLeft_Opening(object sender, CancelEventArgs e)
        {
            setCMS(cmsLeft, "L");
        }

        private void setCMS(Guna.UI2.WinForms.Guna2ContextMenuStrip cms, string LCR)
        {
            cms.Items[0].Enabled = true;
            cms.Items[1].Enabled = true;
            if (mcStat.getMachineCondition(txtMachineID.Text, LCR) == "maintenance")
            {
                cms.Items[0].Enabled = false;
                cms.Items[1].Enabled = true;
            }
            else if (mcStat.getMachineCondition(txtMachineID.Text, LCR) == "running" || mcStat.getMachineCondition(txtMachineID.Text, LCR) == "finished")
            {
                cms.Items[0].Enabled = false;
                cms.Items[1].Enabled = false;
            }
            else
            {
                cms.Items[0].Enabled = true;
                cms.Items[1].Enabled = false;
            }
        }
        private void changeMCCondition(string LCR, string condition)
        {
            mcStat.changeMachineConditon(txtMachineID.Text, LCR, condition);
            Form frmLines = Application.OpenForms["frmLines"];
            if (frmLines != null && frmLines is frmLines)
            {
                frmLines fLine = (frmLines)frmLines;
                fLine.refresh();
            }
        }

        private void cmsCenter_Opening(object sender, CancelEventArgs e)
        {
            setCMS(cmsCenter, "C");
        }

        private void cmsRight_Opening(object sender, CancelEventArgs e)
        {
            setCMS(cmsRight, "R");
        }

        private void switchToMaintenanceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            changeMCCondition("R", "maintenance");
        }

        private void nputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMCCondition("R", "no load / no mat");
        }

        private void switchToMaintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            changeMCCondition("C", "maintenance");
        }

        private void switchToMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMCCondition("L", "maintenance");
        }

        private void acceptInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeMCCondition("L", "no load / no mat");
        }

        private void acceptInputToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            changeMCCondition("C", "no load / no mat");
        }

        private void SetFinished (string LCR)
        {
            try
            {
                string finshedID = mcStat.returnMachineConditionID("finished");
                string color = mcStat.returnLCRColor(finshedID);
                mcStat.changeMachineConditon(txtMachineID.Text, LCR[0].ToString(), "finished");
                if (LCR == "Left")
                {
                    txtLeft.FillColor = ColorTranslator.FromHtml(color);
                    txtLeftArticleNo.FillColor = ColorTranslator.FromHtml(color);
                    txtLeftLotNo.FillColor = ColorTranslator.FromHtml(color) ;
                    txtLeftInst.FillColor = ColorTranslator.FromHtml(color) ;
                    txtLeftSpec.FillColor = ColorTranslator.FromHtml(color) ;
                    txtLeftDia.FillColor = ColorTranslator.FromHtml(color) ;
                    txtLeftLength.FillColor = ColorTranslator.FromHtml(color) ;
                    txtLeftDate.FillColor = ColorTranslator.FromHtml(color) ;
                    txtLeftTime.FillColor = ColorTranslator.FromHtml(color) ;
                    panelLeft.BackColor = ColorTranslator.FromHtml(color) ;         
                }
                else if (LCR == "Center")
                {
                    txtCenter.FillColor = ColorTranslator.FromHtml(color);
                    txtCenterArticleNo.FillColor = ColorTranslator.FromHtml(color);
                    txtCenterLotNo.FillColor = ColorTranslator.FromHtml(color);
                    txtCenterInst.FillColor = ColorTranslator.FromHtml(color);
                    txtCenterSpec.FillColor = ColorTranslator.FromHtml(color);
                    txtCenterDia.FillColor = ColorTranslator.FromHtml(color);
                    txtCenterLength.FillColor = ColorTranslator.FromHtml(color);
                    txtCenterDate.FillColor = ColorTranslator.FromHtml(color);
                    txtCenterTime.FillColor = ColorTranslator.FromHtml(color);
                    panelCenter.BackColor = ColorTranslator.FromHtml(color);
                }
                else
                {
                    txtRight.FillColor = ColorTranslator.FromHtml(color);
                    txtRightArticleNo.FillColor = ColorTranslator.FromHtml(color);
                    txtRightLotNo.FillColor = ColorTranslator.FromHtml(color);
                    txtRightInst.FillColor = ColorTranslator.FromHtml(color);
                    txtRightSpec.FillColor = ColorTranslator.FromHtml(color);
                    txtRightDia.FillColor = ColorTranslator.FromHtml(color);
                    txtRightLength.FillColor = ColorTranslator.FromHtml(color);
                    txtRightDate.FillColor = ColorTranslator.FromHtml(color);
                    txtRightTime.FillColor = ColorTranslator.FromHtml(color);
                    panelRight.BackColor = ColorTranslator.FromHtml(color);
                }

                //mcStat.changeMachineConditon(txtMachineID.Text, LCR[0].ToString(), "finished");
            }
            catch(Exception ex)
            {
                msgOK.Text = ex.Message;
                msgOK.Show();
            }
            
        }
    }                                   
}                                       
                                        