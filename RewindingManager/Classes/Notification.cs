using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewindingManager.Classes
{
    internal class Notification: MainClass
    {
        public string getProgressLabel(string insNo, string artNo)
        {
            string percent = "0%";
            DataTable dt = base.select($"select sum(case when ArticleCheck = 'OK' then 1 else 0 end) as Done, sum(case when ArticleCheck = 'No' then 1 else 0 end) as Ongoing from RW_TemporaryBox where InnerBarcode LIKE N'%{insNo}%' AND ArticleNo LIKE N'%{artNo}%'");
            if (dt.Rows.Count > 0)
            {
                float done = int.Parse(dt.Rows[0]["Done"].ToString());
                int total = int.Parse(dt.Rows[0]["Ongoing"].ToString());

                percent = (Math.Floor((done / (done + total)) * 100)).ToString() + "%";
            }
            return percent;
        }

        public float getProgress(string insNo, string artNo, string lot)
        {
            float percent = 0;
            DataTable dt = base.select($"select sum(case when ArticleCheck = 'OK' then 1 else 0 end) as Done, sum(case when ArticleCheck = 'No' then 1 else 0 end) as Ongoing from RW_TemporaryBox where InnerBarcode LIKE N'%{insNo}%' AND ArticleNo LIKE N'%{artNo}%'");
            if (dt.Rows.Count > 0)
            {
                float done = int.Parse(dt.Rows[0]["Done"].ToString());
                int total = int.Parse(dt.Rows[0]["Ongoing"].ToString());
                percent = (done / (done + total)) * 100;

                if (percent == 100)
                {
                    this.setAsFinish(insNo, artNo, lot);
                }
            }
            return percent;
        }

        private void setAsFinish(string ins, string art, string lot)
        {
            try
            {
                base.actionQuery($"update tblRWManager_TempLoad set PriorityNo = 0 where RWInstructionNo = '{ins}' and RWArticleNo = '{art}' and RWLotNo = '{lot}'");
            }
            catch (Exception e)
            {
                this.ExceptError(e);
            }
        }

        public void plotNotification(Guna.UI2.WinForms.Guna2Panel panel, Guna.UI2.WinForms.Guna2HtmlLabel label)
        {
            try
            {
                int x = 3;
                int y = 3;
                DataTable dtCheckPossibleNotif = base.select("select a.*, b.MCNo, b.Line, case when a.MachineLocation = 'L' then 'Left' when a.MachineLocation = 'C' then 'Center' else 'Right' end as Position from tblRWManager_TempLoad as a inner join tblRWManager_Machine as b on a.MachineID = b.ID where a.PriorityNo = 0");
                panel.Controls.Clear();
                if (dtCheckPossibleNotif.Rows.Count > 0)
                {
                    foreach(DataRow row in dtCheckPossibleNotif.Rows)
                    {
                        Components.NotificationComp notif = new Components.NotificationComp();
                        notif.TxtMachineID.Text = row["MachineID"].ToString();
                        notif.TxtMCNo.Text = row["MCNo"].ToString();
                        notif.TxtLine.Text = row["Line"].ToString();
                        notif.ButtonNotif.Text = $"RM#{row["MCNo"].ToString()} Line {row["Line"].ToString()} [{row["Position"].ToString()}] is finished.";
                        notif.Location = new Point(x, y);
                        panel.Controls.Add(notif);
                        y = y + 51;
                    }
                }
                else
                {
                    label.Location = new Point(89, 119);
                    panel.Controls.Add(label);
                }
            }
            catch(Exception e)
            {
                this.ExceptError(e);
            }
           
        }

        private void ExceptError(Exception e)
        {
            Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            msg.Caption = "Error";
            msg.Text = e.Message;
            msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.RetryCancel;
            msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
        }
    }
}
