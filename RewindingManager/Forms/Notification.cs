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
    public partial class Notification : Form
    {
        Classes.Notification notifClass = new Classes.Notification();
        Classes.Theme theme = new Classes.Theme();
        public Notification()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notification_Load(object sender, EventArgs e)
        {
            btnCancel.ForeColor = ColorTranslator.FromHtml(theme.cancelFore);
            btnCancel.FillColor = ColorTranslator.FromHtml(theme.cancelFill);
            start();
        }

        public void start()
        {
            notifClass.plotNotification(panelNotif, lblNoNotification);
        }

        private void Notification_Deactivate(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
