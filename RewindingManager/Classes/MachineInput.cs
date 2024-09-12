using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RewindingManager.Classes
{
    internal class MachineInput: MainClass
    {
        public String instructionNo;
        public DataTable forInput;
        public DataTable machineInfo;
        public DataTable articleNos;

        public void setForInput()
        {
            this.forInput = base.select("select a.ロットNo as LotNo, a.仕様コード as SpecCode, a.実線径 as Diameter, a.巻長さ as Length, a.現品No as ArticleNo, a.巻き位置 as MachinePosition, a.巻き順 as Priority, a.ProgressTStart as ProgressStart, b. 品種 as Type from 巻替工程棚リスト as a join (select *, row_number() over(partition by  仕様コード order by  改訂番号 desc) as RowNum from 製品仕様マスタ) as b on a.仕様コード = b.仕様コード and b.RowNum = 1 WHERE        (製造指示No9 = '" + this.instructionNo + "') AND (出庫年月日 IS NULL) order by a.巻き順");
            if(this.forInput.Rows.Count > 0 )
            {
                this.articleNos = this.checkIfArticleExist(this.forInput.Rows[0]["LotNo"].ToString());
                
                if(this.articleNos.Rows.Count != this.forInput.Rows.Count)
                {
                    HashSet<string> valuesToRemove = new HashSet<string>(
                        this.articleNos.AsEnumerable().Select(row => row.Field<string>("ArticleNo"))
                    );

                    var filteredRows = this.forInput.AsEnumerable()
                        .Where(row => !valuesToRemove.Contains(row.Field<string>("ArticleNo")))
                        .CopyToDataTable();

                    this.forInput = filteredRows;
                }
                else
                {
                    this.forInput.Rows.Clear();
                }

            }
            
        }

        public void setMachineInfo(String machineID)
        {
            this.machineInfo = base.select("select * from tblRWManager_Machine where ID = '" + machineID + "'");
        }

        public String returnMachineColor(String LCR)
        {
            DataTable dt = base.select("select * from tblRWManager_MachineCondition where ID = '" + this.machineInfo.Rows[0][LCR] + "'");
            return dt.Rows[0]["HexColor"].ToString();
        }

        public String returnMachineStatus(String LCR)
        {
            DataTable dt = base.select("select * from tblRWManager_MachineCondition where ID = '" + this.machineInfo.Rows[0][LCR] + "'");
            return dt.Rows[0]["Condition"].ToString();
        }

        private DataTable checkIfArticleExist(String lot)
        {
            return base.select("select RWInstructionNo as InstructionNo, RWLotNo as LotNo, RWArticleNo as ArticleNo, PriorityNo from tblRWManager_TempLoad where RWInstructionNo = '" + this.instructionNo + "' and RWLotNo = '" + lot + "'");
        }

        private int getPriorityNo(int machineID, char location)
        {
            DataTable dt = base.select("select top(1) PriorityNo from tblRWManager_TempLoad where MachineID = " + machineID + " and MachineLocation = '" + location + "' order by PriorityNo desc");
            int temp = 0;
            if (dt.Rows.Count > 0)
            {
                temp = int.Parse(dt.Rows[0]["PriorityNo"].ToString()) + 1;
            }
            else
            {
                temp = 1;
            }

            return temp;
        }

        public int loadArticle(Guna.UI2.WinForms.Guna2DataGridView dgv, int machineID, String machineLocation, Guna.UI2.WinForms.Guna2MessageDialog msg, String ins, Guna.UI2.WinForms.Guna2MessageDialog msgAsk, string lineNo, string machineNo)
        {
            int status = 0;
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    int count = this.getPriorityNo(machineID, machineLocation[0]);
                    if (count > 1)
                    {
                        msgAsk.Caption = "Confirm Completion";
                        msgAsk.Text = $"Line {lineNo} RM # {machineNo} [{machineLocation}] is already running, do you want to start the first article at priority {count.ToString()}?";
                        DialogResult result = msgAsk.Show();
                        if (result == DialogResult.Yes)
                        {
                            this.load(msgAsk, dgv, machineLocation, count, machineID, ins);
                            status = 1;
                        }
                        else
                        {
                            status = 0;
                        }
                    }
                    else if(count == 1)
                    {
                        this.load(msgAsk, dgv, machineLocation, count, machineID, ins);
                        status = 1;
                    }
                    
                }
                else
                {
                    status = 0;
                }
            }
            catch (Exception e)
            {
                msg.Caption = "Error!";
                msg.Text = e.Message;
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                msg.Show();
            }
            return status;
        }

        private void load(Guna.UI2.WinForms.Guna2MessageDialog msg, Guna.UI2.WinForms.Guna2DataGridView dgv, string machineLocation, int prio, int machineID, string ins)
        {
            try
            {
                if(dgv.Rows.Count > 0)
                {
                    int count = prio;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        String query = "";
                        char ml = machineLocation[0];
                        string lot = row.Cells[0].Value.ToString();
                        string spec = row.Cells[1].Value.ToString();
                        string dia = row.Cells[2].Value.ToString();
                        string length = row.Cells[3].Value.ToString();
                        string article = row.Cells[4].Value.ToString();
                        string type = row.Cells[5].Value.ToString();
                        string startDate = row.Cells[8].Value.ToString();
                        string pic = "";
                        if (row.Cells[9].Value != null)
                        {
                            pic = row.Cells[9].Value.ToString();
                        }
                        char pos = Convert.ToChar(row.Cells[6].Value);
                        if (count == 1)
                        {
                            if (machineLocation[0] == pos)
                            {
                                query = $"insert into tblRWManager_TempLoad(MachineID, MachineLocation, PriorityNo, RWInstructionNo, RWLotNo, RWArticleNo, RWSpecCode, RWDiameter, RWLength, RWType, ETF, StartDate, RBSPosition, ActualStartDate) values ({machineID}, '{machineLocation[0].ToString()}', {count}, '{ins}', '{lot}', '{article}', '{spec}', '{dia}', '{length}', '{type}', dateadd(minute, {computeDuration(length, type)}, '{startDate}'), '{startDate}', '{pos}', getdate())";
                            }
                            else
                            {
                                query = $"insert into tblRWManager_TempLoad(MachineID, MachineLocation, PriorityNo, RWInstructionNo, RWLotNo, RWArticleNo, RWSpecCode, RWDiameter, RWLength, RWType, ETF, StartDate, RBSPosition, ActualStartDate, PIC) values ({machineID}, '{machineLocation[0].ToString()}', {count}, '{ins}', '{lot}', '{article}', '{spec}', '{dia}', '{length}', '{type}', dateadd(minute, {computeDuration(length, type)}, '{startDate}'), '{startDate}', '{pos}', getdate(), '{pic}')";
                            }

                            switch (machineLocation[0])
                            {
                                case 'L':
                                    base.actionQuery("update tblRWManager_Machine set L = '1' where ID = " + machineID);
                                    break;

                                case 'C':
                                    base.actionQuery("update tblRWManager_Machine set C = '1' where ID = " + machineID);
                                    break;

                                case 'R':
                                    base.actionQuery("update tblRWManager_Machine set R = '1' where ID = " + machineID);
                                    break;

                                default:
                                    break;
                            }

                        }
                        else
                        {
                            if (machineLocation[0] == pos)
                            {
                                query = $"insert into tblRWManager_TempLoad(MachineID, MachineLocation, PriorityNo, RWInstructionNo, RWLotNo, RWArticleNo, RWSpecCode, RWDiameter, RWLength, RWType, ETF, StartDate, RBSPosition) values ({machineID}, '{machineLocation[0]}', {count}, '{ins}', '{lot}', '{article}', '{spec}', '{dia}', '{length}', '{type}', dateadd(minute, {computeDuration(length, type)}, '{startDate}'), '{startDate}', '{pos}')";
                            }
                            else
                            {
                                query = $"insert into tblRWManager_TempLoad(MachineID, MachineLocation, PriorityNo, RWInstructionNo, RWLotNo, RWArticleNo, RWSpecCode, RWDiameter, RWLength, RWType, ETF, StartDate, RBSPosition, PIC) values ({machineID}, '{machineLocation[0]}', {count}, '{ins}', '{lot}', '{article}', '{spec}', '{dia}', '{length}', '{type}', dateadd(minute, {computeDuration(length, type)}, '{startDate}'), '{startDate}', '{pos}', '{pic}')";
                            }
                        }
                        base.actionQuery(query);
                        count++;
                    }
                    Classes.MachineStatus mcStat = new Classes.MachineStatus();
                    mcStat.setFinished();
                }
            }
            catch(Exception e)
            {
                msg.Caption = "Error!";
                msg.Text = $"Error ka: {e.Message}";
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                msg.Show();
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
            return duration;
        }
    }
}
