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
    public partial class ButtonLine : UserControl
    {
        private Guna.UI2.WinForms.Guna2Button _btn;

        public Guna.UI2.WinForms.Guna2Button ButtonText
        {
            get { return _btn; }
            set { _btn = value; }
        }
        public ButtonLine()
        {
            InitializeComponent();
            _btn = btnLines;
        }

        private void btnLines_Click(object sender, EventArgs e)
        {
            //frmLines.selectedLines = int.Parse(ButtonText.Text.Substring(5));
            //frmLines lines = new frmLines();
            //lines.ShowDialog();
            //Form1 form1 = new Form1();
            //form1.Close();  
        }
    }
}
