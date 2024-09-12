using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewindingManager.Forms
{
    public partial class frmTemp : Form
    {
        private string line;
        private string machineNo;
        private string machineID;
        public frmTemp()
        {
            InitializeComponent();
        }

        public void set_LineNo_MNo_MID(string lineNo, string mcNo, string mcID)
        {
            line = lineNo;
            machineNo = mcNo;
            machineID = mcID;
        }

        private void MachineInput_Load(object sender, EventArgs e)
        {
            others();
        }

        private void others()
        {
            lblLine.Text = $"LINE: {line}";
            lblMachineNo.Text = $"RM #{machineNo}";
        }
    }
}
