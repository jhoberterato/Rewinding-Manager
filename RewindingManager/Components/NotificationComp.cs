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
    public partial class NotificationComp : UserControl
    {
        private Guna.UI2.WinForms.Guna2TextBox _txtMachineID;
        private Guna.UI2.WinForms.Guna2TextBox _txtMCNo;
        private Guna.UI2.WinForms.Guna2TextBox _txtLine;
        private Guna.UI2.WinForms.Guna2Button _btn;
        private Guna.UI2.WinForms.Guna2Separator _separator;

        public Guna.UI2.WinForms.Guna2TextBox TxtMachineID
        {
            get { return _txtMachineID; }
            set { _txtMachineID = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox TxtMCNo
        {
            get { return _txtMCNo; }
            set { _txtMCNo = value; }
        }
        
        public Guna.UI2.WinForms.Guna2TextBox TxtLine
        {
            get { return _txtLine; }
            set { _txtLine = value; }
        }


        public Guna.UI2.WinForms.Guna2Button ButtonNotif
        {
            get { return _btn; }
            set { _btn = value; }
        }

        public Guna.UI2.WinForms.Guna2Separator SeparatorNotif
        {
            get { return _separator; }
            set { _separator = value; }
        }
        public NotificationComp()
        {
            InitializeComponent();
            _txtMachineID = txtMachineID;
            _txtMCNo = txtMCNo;
            _txtLine = txtLine;
            _btn = btnFinish;
            _separator = sepFinish;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            frmMachine machineInterface = new frmMachine();
            machineInterface.set_Line_McNo_McID(txtLine.Text, txtMCNo.Text, txtMachineID.Text);
            machineInterface.ShowDialog();
        }
    }
}
