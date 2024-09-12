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
    public partial class MachineStatusControl : UserControl
    {
        private Guna.UI2.WinForms.Guna2TileButton _btnStatusColor;
        private Guna.UI2.WinForms.Guna2HtmlLabel _lblStatusCondition;

        public Guna.UI2.WinForms.Guna2TileButton ButtonStatusColor
        {
            get { return _btnStatusColor; }
            set { _btnStatusColor = value; }
        }

        public Guna.UI2.WinForms.Guna2HtmlLabel LabelStatusCondition
        {
            get { return _lblStatusCondition;}
            set { _lblStatusCondition = value; }
        }
        public MachineStatusControl()
        {
            InitializeComponent();
            _btnStatusColor = btnStatusColor;
            _lblStatusCondition = lblStatusCondition;
        }

        private void MachineStatusControl_Load(object sender, EventArgs e)
        {

        }
    }
}
