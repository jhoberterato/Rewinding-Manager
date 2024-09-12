using RewindingManager.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RewindingManager.Classes
{
    internal class PIC: MainClass
    {
        public string pic;

        public String setPIC(string p)
        {
            string status = "error";
            DataTable dataTable = base.select($"select * from tblUser where (section = N'Rewinding') AND (Active = 1) and (UserName = '{p}')");
            if(dataTable.Rows.Count > 0 )
            {
                this.pic = dataTable.Rows[0]["UserName"].ToString();
                status = "success";
            }
            else
            {
                Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                msg.Caption = "Error!";
                msg.Text = "No PIC found.";
                msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
                msg.Show();
            }
            return status;
        }
    }
}
