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
    public partial class PICInput : Form
    {
        Classes.PIC PIC = new Classes.PIC();
        public PICInput()
        {
            InitializeComponent();
        }

        private void lblLineNo_Click(object sender, EventArgs e)
        {

        }

        private void txtPIC_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(PIC.setPIC(txtPIC.Text) == "success")
                {
                    Form machineInput = Application.OpenForms["MachineInput"];
                    if (machineInput != null && machineInput is MachineInput)
                    {
                        MachineInput input = (MachineInput)machineInput;
                        input.setPIC(PIC.pic);
                    }

                    this.Close();
                }
            }
        }

        public String returnPIC()
        {
            return PIC.pic.ToString();
        }

        private void PICInput_Load(object sender, EventArgs e)
        {
            txtPIC.Focus();
        }

        private void PICInput_Shown(object sender, EventArgs e)
        {

        }
    }
}
