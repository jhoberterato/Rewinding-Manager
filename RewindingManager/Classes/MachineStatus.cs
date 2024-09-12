using RewindingManager.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewindingManager.Classes
{
    internal class MachineStatus: MainClass
    {
        private DataTable getMachineConditions;
        private DataTable getMachines;
        private DataTable getMachineColors;
        public List<String> linesList;
        public int selectedLine;
        private Classes.Theme theme = new Classes.Theme();
        //private Guna.UI2.WinForms.Guna2Button[] btnLines;

        public DataTable selectedMachine;
        
        public MachineStatus()
        {
            this.selectedLine = 0;
            DataTable tempTable = base.select("select distinct Line from tblRWManager_Machine");
            linesList = new List<String>();
            foreach (DataRow row in tempTable.Rows)
            {
                this.linesList.Add(row["Line"].ToString());
            }
        }

        public void plotMachineConditions(Guna.UI2.WinForms.Guna2Panel panel, string t)
        {
            this.getMachineConditions = base.select("select Condition, HexColor from tblRWManager_MachineCondition group by Condition, HexColor");
            panel.Controls.Clear();
            int x = 3;
            foreach (DataRow row in this.getMachineConditions.Rows)
            {
                Components.MachineStatusControl machineStatus = new Components.MachineStatusControl();

                machineStatus.BackColor = ColorTranslator.FromHtml(theme.getBackground1(t));
                machineStatus.LabelStatusCondition.ForeColor = ColorTranslator.FromHtml(theme.getForeColor(t));
                machineStatus.LabelStatusCondition.Text = row["Condition"].ToString().ToUpper();
                machineStatus.ButtonStatusColor.FillColor = ColorTranslator.FromHtml(row["HexColor"].ToString());
                machineStatus.Location = new Point(x, 7);
                panel.Controls.Add(machineStatus);
                x = x + 170;

            }
        }

        public void plotMachines(Guna.UI2.WinForms.Guna2Panel panel, string theme)
        {
            String line = this.linesList[this.selectedLine].ToString();
            this.getMachines = base.select("select * from tblRWManager_Machine where Line = '"+ line + "' order by LineSequence");
            panel.Controls.Clear();
            int machineX = 8;
            if (getMachines.Rows.Count < 4)
            {
                for (int i = 0; i < getMachines.Rows.Count; i++)
                {
                    //DataRow row = getMachines.Rows[i];
                    this.configurePlotMachines(
                        panel, "RM" + getMachines.Rows[i]["MCNo"],
                        machineX,
                        6,
                        this.objectToInt(getMachines.Rows[i]["L"]),
                        this.objectToInt(getMachines.Rows[i]["C"]),
                        this.objectToInt(getMachines.Rows[i]["R"]),
                        this.objectToInt(getMachines.Rows[i]["ID"]),
                        theme
                   );
                    machineX = machineX + 500;
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    this.configurePlotMachines(
                        panel,
                        "RM" + getMachines.Rows[i]["MCNo"],
                        machineX,
                        6,
                        this.objectToInt(getMachines.Rows[i]["L"]),
                        this.objectToInt(getMachines.Rows[i]["C"]),
                        this.objectToInt(getMachines.Rows[i]["R"]),
                        this.objectToInt(getMachines.Rows[i]["ID"]),
                        theme
                    );
                    machineX = machineX + 500;
                }
                if (getMachines.Rows.Count > 4)
                {
                    machineX = 8;
                    for (int i = 4; i < getMachines.Rows.Count; i++)
                    {
                        this.configurePlotMachines(
                            panel,
                            "RM" + getMachines.Rows[i]["MCNo"],
                            machineX,
                            160,
                            this.objectToInt(getMachines.Rows[i]["L"]),
                            this.objectToInt(getMachines.Rows[i]["C"]),
                            this.objectToInt(getMachines.Rows[i]["R"]),
                            this.objectToInt(getMachines.Rows[i]["ID"]),
                            theme
                        );
                        machineX = machineX + 500;
                    }
                }
            }
        }

        private void configurePlotMachines(Guna.UI2.WinForms.Guna2Panel panel, String machineName, int x, int y, int l, int c, int r, int machineID, string theme)
        {
            Components.UserControl1 machine = new Components.UserControl1();
            machine.MachineText.Text = machineName;
            machine.Location = new Point(x, y);

            Classes.Static.setMachineLeftFillColor(machine, this.getColor(l)); // Get Machine Left Fill Color
            Classes.Static.setMachineCenterFillColor(machine, this.getColor(c)); // Get Machine Center Fill Color
            Classes.Static.setMachineRightFillColor(machine, this.getColor(r)); // Get Machine Right Fill Color

            /*--------LCR Progress Timer--------*/
            if (this.getCondition(l) == "running" || this.getCondition(l) == "finished") //For Left
            {
                machine.TimerLeft.Start();
            }
            else
            {
                machine.LabelProgressLeft.Text = "0 %";
            }

            if (this.getCondition(c) == "running" || this.getCondition(c) == "finished") //For Center
            {
                machine.TimerCenter.Start();
            }
            else
            {
                machine.LabelProgressCenter.Text = "0 %";
            }

            if (this.getCondition(r) == "running" || this.getCondition(r) == "finished") //For Right
            {
                machine.TimerRight.Start();
            }
            else
            {
                machine.LabelProgressRight.Text = "0 %";
            }

            this.plotValue(machine, l, c, r, machineID, theme);
            panel.Controls.Add(machine);
        }

        private int objectToInt(Object obj)
        {
            return int.Parse(obj.ToString());
        }

        private String getColor(int i)
        {
            this.getMachineColors = base.select("select * from tblRWManager_MachineCondition where ID = '"+ i +"'");

            return this.getMachineColors.Rows[0]["HexColor"].ToString();
        }
        
        private String getCondition(int i)
        {
            this.getMachineColors = base.select("select * from tblRWManager_MachineCondition where ID = '" + i + "'");

            return this.getMachineColors.Rows[0]["Condition"].ToString();
        }

        private void plotValue(Components.UserControl1 machine, int l, int c, int r, int machineID, string theme)
        {
            machine.TxtMachineID.Text = machineID.ToString();
            if (l == 3 || l == 2)
            {
                Classes.Static.clearMachineTextLeft(machine);
              
            }
            else
            {
                DataTable dt = this.getMachineTextValue(machineID, "l");
                if(dt.Rows.Count > 0)
                {
                    DateTime dt2 = (DateTime)dt.Rows[0]["ETF"];
                    DateTime dateOnly = dt2.Date;
                    TimeSpan timeOnly = dt2.TimeOfDay;
                    machine.TxtLeftLotNo.Text = dt.Rows[0]["RWLotNo"].ToString();
                    machine.TxtLeftArticleNo.Text = dt.Rows[0]["RWArticleNo"].ToString();
                    machine.TxtLeftInst.Text = dt.Rows[0]["RWInstructionNo"].ToString();
                    machine.TxtLeftSpec.Text = dt.Rows[0]["RWSpecCode"].ToString();
                    machine.TxtLeftDia.Text = dt.Rows[0]["RWDiameter"].ToString();
                    machine.TxtLeftLength.Text = dt.Rows[0]["RWLength"].ToString();
                    if(dt.Rows[0]["ETF"] == null)
                    {
                        machine.TxtLeftDate.Text = "NA";
                        machine.TxtLeftTime.Text = "NA";
                    }
                    else
                    {
                        machine.TxtLeftDate.Text = dateOnly.ToString("MM/dd/yyyy");
                        machine.TxtLeftTime.Text = timeOnly.ToString();
                    }
                    
                    machine.TxtStartDate.Text = dt.Rows[0]["StartDate"].ToString();
                    
                }
                else
                {          
                    Classes.Static.setMachineLeftFillColor(machine, this.getColor(3));
                    Classes.Static.clearMachineTextLeft(machine);
                }
            }


            if(c == 3 || c == 2)
            {
                Classes.Static.clearMachineTextCenter(machine);
            }
            else
            {
                DataTable dt = this.getMachineTextValue(machineID, "c");
                if (dt.Rows.Count > 0)
                {
                    DateTime dt2 = (DateTime)dt.Rows[0]["ETF"];
                    DateTime dateOnly = dt2.Date;
                    TimeSpan timeOnly = dt2.TimeOfDay;
                    machine.TxtCenterLotNo.Text = dt.Rows[0]["RWLotNo"].ToString();
                    machine.TxtCenterArticleNo.Text = dt.Rows[0]["RWArticleNo"].ToString();
                    machine.TxtCenterInst.Text = dt.Rows[0]["RWInstructionNo"].ToString();
                    machine.TxtCenterSpec.Text = dt.Rows[0]["RWSpecCode"].ToString();
                    machine.TxtCenterDia.Text = dt.Rows[0]["RWDiameter"].ToString();
                    machine.TxtCenterLength.Text = dt.Rows[0]["RWLength"].ToString();
                    if(dt.Rows[0]["ETF"] == null)
                    {
                        machine.TxtCenterDate.Text = "NA";
                        machine.TxtCenterTime.Text = "NA";
                    }
                    else
                    {
                        machine.TxtCenterDate.Text = dateOnly.ToString("MM/dd/yyyy");
                        machine.TxtCenterTime.Text = timeOnly.ToString();
                    }
                    machine.TxtStartDate.Text = dt.Rows[0]["StartDate"].ToString();

                }
                else
                {
                    Classes.Static.setMachineCenterFillColor(machine, this.getColor(3));
                    Classes.Static.clearMachineTextCenter(machine);
                }
            }

            if(r == 3 || r == 2)
            {
                Classes.Static.clearMachineTextRight(machine);
            }
            else
            {
                DataTable dt = this.getMachineTextValue(machineID, "r");
                if (dt.Rows.Count > 0)
                {
                    DateTime dt2 = (DateTime)dt.Rows[0]["ETF"];
                    DateTime dateOnly = dt2.Date;
                    TimeSpan timeOnly = dt2.TimeOfDay;
                    machine.TxtRightLotNo.Text = dt.Rows[0]["RWLotNo"].ToString();
                    machine.TxtRightArticleNo.Text = dt.Rows[0]["RWArticleNo"].ToString();
                    machine.TxtRightInst.Text = dt.Rows[0]["RWInstructionNo"].ToString();
                    machine.TxtRightSpec.Text = dt.Rows[0]["RWSpecCode"].ToString();
                    machine.TxtRightDia.Text = dt.Rows[0]["RWDiameter"].ToString();
                    machine.TxtRightLength.Text = dt.Rows[0]["RWLength"].ToString();
                    if(dt.Rows[0]["ETF"] == null)
                    {
                        machine.TxtRightDate.Text = "NA";
                        machine.TxtRightTime.Text = "NA";
                    }
                    else
                    {
                        machine.TxtRightDate.Text = dateOnly.ToString("MM/dd/yyyy");
                        machine.TxtRightTime.Text = timeOnly.ToString();
                    }
                    machine.TxtStartDate.Text = dt.Rows[0]["StartDate"].ToString();

                }
                else
                {
                    Classes.Static.setMachineRightFillColor(machine, this.getColor(3));
                    Classes.Static.clearMachineTextRight(machine);
                }
            }
        }

        public String returnLCRColor(String i)
        {
            DataTable dt = new DataTable();
            dt = base.select("select * from tblRWManager_MachineCondition where ID = '" + i + "'");
            return dt.Rows[0]["HexColor"].ToString();
        }

        public void setSelectedMachineInfo(String line, String machinde)
        {
            this.selectedMachine = base.select("select * from tblRWManager_Machine where Line = '" + line + "' and MCNo = '" + machinde + "'");
        }

        private DataTable getMachineTextValue(int id, String machineLocation)
        {
            DataTable dt = base.select("select * from tblRWManager_TempLoad where MachineID = '" + id + "' and MachineLocation = '" + machineLocation + "'");
            return dt;
        }

        public void getLoadedArticles(string machineID, string machineLocation, Guna.UI2.WinForms.Guna2DataGridView dgv)
        {
            DataTable dt = base.select("select RWLotNo as LotNo, RWInstructionNo as InsNo, RWSpecCode as SpecCode, concat(RWDiameter, ' / ', RWLength) as DiaLength, RWType as Type, RWArticleNo as ArticleNo, case when PriorityNo = 0 Then 'Finished' when PriorityNo = 1 Then 'Running' else 'Waiting' end as Condition from tblRWManager_TempLoad where MachineID = '" + machineID + "' and MachineLocation = '" + machineLocation + "'");

            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(theme.cancelFore);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(this.returnLCRColor(this.selectedMachine.Rows[0][machineLocation].ToString()));
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml(theme.cancelFore);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(this.returnLCRColor(this.selectedMachine.Rows[0][machineLocation].ToString()));
            dgv.DataSource = dt;

        }

        public void deleteLoad(string machineLocation, string insNo, string lotNo, string articleNo)
        {
            base.actionQuery($"delete from tblRWManager_TempLoad where MachineLocation = '{machineLocation}' and RWInstructionNo = '{insNo}' and RWLotNo = '{lotNo}' and RWArticleNo = '{articleNo}'");
        }

        public void reArrangeLoad(string machineLocation, string machineID)
        {
            DataTable dt = base.select($"select * from tblRWManager_TempLoad where MachineID = '{machineID}' and MachineLocation = '{machineLocation}' and (not (ActualStartDate is null))");
            if(dt.Rows.Count == 0)
            {
                DataTable dtPending = base.select($"select * from tblRWManager_TempLoad where MachineID = '{machineID}' and MachineLocation = '{machineLocation}' and (ActualStartDate is null) order by PriorityNo");
                if(dtPending.Rows.Count > 0)
                {
                    int x = 1;
                    foreach(DataRow row in dtPending.Rows)
                    {
                        if(x == 1)
                        {
                            base.actionQuery($"update tblRWManager_TempLoad set PriorityNo = '{x}', ActualStartDate = getdate() where ID = {row["ID"]}");
                        }
                        else
                        {
                            base.actionQuery($"update tblRWManager_TempLoad set PriorityNo = '{x}' where ID = {row["ID"]}");
                        }
                        x++;
                    }
                    base.actionQuery($"update tblRWManager_Machine set {machineLocation} = 1 where ID = {machineID}");
                }
                else
                {
                    base.actionQuery($"update tblRWManager_Machine set {machineLocation} = 3 where ID = {machineID}");
                }
            }
        }

        private int computeDuration(string length, string type)
        {
            int duration = 0;
            DataTable dt = base.select("select * from tblRWManager_TimeDuration where LengthInMeters = '" + length + "'");
            if (type == "EX1")
            {
                duration = int.Parse(dt.Rows[dt.Rows.Count - 1]["EX1InMinutes"].ToString()) + int.Parse(dt.Rows[dt.Rows.Count - 1]["AdditionalTimeInMinutes"].ToString());
            }
            else
            {
                duration = int.Parse(dt.Rows[dt.Rows.Count - 1]["EX1PInMinutes"].ToString()) + int.Parse(dt.Rows[dt.Rows.Count - 1]["AdditionalTimeInMinutes"].ToString());
            }
            MessageBox.Show(duration.ToString());
            return duration;
        }

        public void completeLoad(string mcID, string mcLoc, string ins, string lot, string art, string spec, string type)
        {
            DataTable otherDetails = this.getOtherCompleteLoadInfo(mcID, mcLoc, ins, lot, art);
            string dia = otherDetails.Rows[0]["RWDiameter"].ToString();
            string length = otherDetails.Rows[0]["RWLength"].ToString();
            string pos = otherDetails.Rows[0]["RBSPosition"].ToString();
            string etf = otherDetails.Rows[0]["ETF"].ToString();
            string sdate = otherDetails.Rows[0]["StartDate"].ToString();
            string asdate = otherDetails.Rows[0]["ActualStartDate"].ToString();
            string pic = "";

            if (otherDetails.Rows[0]["PIC"].ToString() != null)
            {
                pic = otherDetails.Rows[0]["PIC"].ToString();
            }

            //MessageBox.Show($"'{mcID}', '{mcLoc}', '{ins}', '{lot}', '{art}', '{spec}', '{dia}', '{length}', '{type}', '{pos}', {etf}, {sdate}, {asdate}, getdate(), '{pic}'");
            base.actionQuery($"insert into tblRWManager_Logs(MachineID, MachineLocation, RWInstructionNo, RWLotNo, RWArticleNo, RWSpecCode, RWDiameter, RWLength, RWType, RBSPosition, ETF, StartDate, ActualStartDate, CompleteDate, PIC) values('{mcID}', '{mcLoc}', '{ins}', '{lot}', '{art}', '{spec}', '{dia}', '{length}', '{type}', '{pos}', '{etf}', '{sdate}', '{asdate}', getdate(), '{pic}')");
            base.actionQuery($"delete from tblRWManager_TempLoad where MachineID = {mcID} and MachineLocation = '{mcLoc}' and RWInstructionNo = '{ins}' and RWLotNo = '{lot}' and RWArticleNo = '{art}'");
            this.reArrangeLoad(mcLoc, mcID);
            this.setFinished();
        }

        private DataTable getOtherCompleteLoadInfo(string mcID, string mcLoc, string ins, string lot, string art)
        {
            DataTable dt = base.select($"select * from tblRWManager_TempLoad where MachineID = '{mcID}' and MachineLocation = '{mcLoc}' and  RWInstructionNo = '{ins}' and RWLotNo = '{lot}' and RWArticleNo = '{art}'");

            return dt;
        }

        public String countNotification()
        {
            int count = 0;
            DataTable dt = base.select("select * from  tblRWManager_TempLoad where PriorityNo = 0");
            count = dt.Rows.Count;
            return count.ToString();
        }

        public String getMachineCondition(string mcID, string LCR)
        {
            string query = "";
            switch (LCR)
            {
                case "L":
                    {
                        query = $"select L, b.Condition from tblRWManager_Machine as a inner join tblRWManager_MachineCondition as b on a.L = b.ID where a.ID = {mcID}";
                        break;
                    }
                case "C":
                    {
                        query = $"select C, b.Condition from tblRWManager_Machine as a inner join tblRWManager_MachineCondition as b on a.C = b.ID where a.ID = {mcID}";
                        break;
                    }
                case "R":
                    {
                        query = $"select R, b.Condition from tblRWManager_Machine as a inner join tblRWManager_MachineCondition as b on a.R = b.ID where a.ID = {mcID}";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            DataTable dt = base.select(query);
            return dt.Rows[0]["Condition"].ToString();
        }

        public void changeMachineConditon(string mcID, string LCR, string condition)
        {
            try
            {
                DataTable dt = base.select($"select ID from tblRWManager_MachineCondition where Condition = '{condition}'");
                string query = "";
                switch (LCR)
                {
                    case "L":
                        {
                            query = $"update tblRWManager_Machine set L = {dt.Rows[0]["ID"]} where ID = {mcID}";
                            break;
                        }
                    case "C":
                        {
                            query = $"update tblRWManager_Machine set C = {dt.Rows[0]["ID"]} where ID = {mcID}";
                            break;
                        }
                    case "R":
                        {
                            query = $"update tblRWManager_Machine set R = {dt.Rows[0]["ID"]} where ID = {mcID}";
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                base.actionQuery(query);
            }
            catch(Exception e)
            {
                Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                msg.Caption = "Error!";
                msg.Text = e.Message;
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.RetryCancel;
                msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
                msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            }
        }

        public String returnMachineConditionID (string condition)
        {
            DataTable dt = base.select($"select ID from tblRWManager_MachineCondition where Condition = '{condition}'");
            return dt.Rows[0]["ID"].ToString();
        }

        public void setFinished()
        {
            try
            {
                DataTable dt = base.select("select MachineID, MachineLocation, RWInstructionNo, RWLotNo, RWArticleNo from tblRWManager_TempLoad where PriorityNo = '1'");
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        Classes.Notification prog = new Classes.Notification();
                        if (prog.getProgressLabel(dr["RWInstructionNo"].ToString(), dr["RWArticleNo"].ToString()) == "100%")
                        {
                            prog.getProgress(dr["RWInstructionNo"].ToString(), dr["RWArticleNo"].ToString(), dr["RWLotNo"].ToString());
                            this.changeMachineConditon(dr["MachineID"].ToString(), dr["MachineLocation"].ToString(), "finished");
                        }

                    }
                }
            }
            catch(Exception e)
            {
                Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                msg.Caption = "Error!";
                msg.Text = e.Message;
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.RetryCancel;
                msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
                msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            }
            
            
        }
    }
}
