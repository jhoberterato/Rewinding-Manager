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
    public partial class RadioLinesControl : UserControl
    {
        private Guna.UI2.WinForms.Guna2RadioButton _radio;

        public Guna.UI2.WinForms.Guna2RadioButton RadioText
        {
            get { return _radio; }
            set { _radio = value; }
        }
        public RadioLinesControl()
        {
            InitializeComponent();
            _radio = radioLine;
        }

        private void radioLine_CheckedChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2RadioButton radioButton = sender as Guna.UI2.WinForms.Guna2RadioButton;
            if(radioButton.Checked)
            {
                foreach (Control control in radioButton.Parent.Controls)
                {
                    if (control is Guna.UI2.WinForms.Guna2RadioButton radioBtn && radioBtn != radioButton)
                    {
                        radioBtn.Checked = false;
                    }
                }
            }
        }
    }
}
