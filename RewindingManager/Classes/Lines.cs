using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewindingManager.Classes
{
    
    internal class Lines: MainClass
    {
        private DataTable getLines;
        
        public void selectLine(Guna.UI2.WinForms.Guna2Panel panel)
        {
            this.getLines = base.select("select distinct Line from tblRWManager_Machine");
            panel.Controls.Clear();
            int x = 3;
            foreach(DataRow row in this.getLines.Rows)
            {
                Components.RadioLinesControl radioLines = new Components.RadioLinesControl();
                radioLines.RadioText.Text = "Line " + row["Line"].ToString();
                radioLines.Location = new Point(x, 5);
                if (int.Parse(row["Line"].ToString()) == 0)
                {
                    radioLines.RadioText.Checked = true;
                }
                radioLines.RadioText.Name = "radioLine" + x;
                panel.Controls.Add(radioLines);
                x = x + 98;
            }
        }
    }
}
