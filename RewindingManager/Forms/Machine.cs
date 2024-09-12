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
    public partial class frmMachine : Form
    {
        Classes.Theme theme = new Classes.Theme();
        Classes.MachineStatus machineStatus = new Classes.MachineStatus();
        private String line {  get; set; }
        private String machine { get; set; }
        private String machineID { get; set; }
        public frmMachine()
        {
            InitializeComponent();
        }

        private void frmMachine_Load(object sender, EventArgs e)
        {
            others();
            start();
        }

        public void set_Line_McNo_McID(String l, String mcNo, String mcID)
        {
            line = l;
            machine = mcNo;
            machineID = mcID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmLines = Application.OpenForms["frmLines"];
            if(frmLines != null && frmLines is frmLines)
            {
                frmLines fLine = (frmLines)frmLines;
                fLine.refresh();
            }

            Form Notification = Application.OpenForms["Notification"];
            if (Notification != null && Notification is Notification)
            {
                Notification notif = (Notification)Notification;
                notif.start();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MachineInput m = new MachineInput();
            m.set_LineNo_MNo_MID(line, machine, machineID);
            m.ShowDialog();
            
        }

        private void others()
        {
            this.BackColor = ColorTranslator.FromHtml(theme.background2);
            btnCancel.ForeColor = ColorTranslator.FromHtml(theme.cancelFore);
            btnCancel.FillColor = ColorTranslator.FromHtml(theme.cancelFill);
            lblLine.Text = "LINE: " + line;
            lblMachine.Text = "RM # " + machine;

            machineStatus.setSelectedMachineInfo(line, machine);

            dgvLeft.ContextMenuStrip = cmsLeft;
            dgvCenter.ContextMenuStrip = cmsCenter;
            dgvRight.ContextMenuStrip = cmsRight;


            //grpbxLeft.CustomBorderColor = ColorTranslator.FromHtml(machineStatus.returnLCRColor(machineStatus.selectedMachine.Rows[0]["L"].ToString()));
            //grpbxCenter.CustomBorderColor = ColorTranslator.FromHtml(machineStatus.returnLCRColor(machineStatus.selectedMachine.Rows[0]["C"].ToString()));
            //grpbxRight.CustomBorderColor = ColorTranslator.FromHtml(machineStatus.returnLCRColor(machineStatus.selectedMachine.Rows[0]["R"].ToString()));
        }

        public void start()
        {
            machineStatus.setSelectedMachineInfo(line, machine);
            machineStatus.getLoadedArticles(machineID, "L", dgvLeft);
            machineStatus.getLoadedArticles(machineID, "C", dgvCenter);
            machineStatus.getLoadedArticles(machineID, "R", dgvRight);
        }

        private void dgvLeft_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvRightClick(e, dgvLeft);
        }

        private void cmsLeft_Opening(object sender, CancelEventArgs e)
        {
            //MessageBox.Show(dgvLeft.SelectedRows[0].Index.ToString());
            loadCMS(dgvLeft, cmsLeft);
        }

        private void dgvRightClick(DataGridViewCellMouseEventArgs e, Guna.UI2.WinForms.Guna2DataGridView dgv)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && dgv.SelectedRows.Count == 1)
            {
                dgv.ClearSelection();
                dgv.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgvCenter_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvRightClick(e, dgvCenter);
        }

        private void dgvRight_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvRightClick(e, dgvRight);
        }

        private void loadCMS(Guna.UI2.WinForms.Guna2DataGridView dgv, Guna.UI2.WinForms.Guna2ContextMenuStrip cms)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                cms.Items.Clear();
            }
            else if (dgv.SelectedRows.Count > 1)
            {
                cms.Items[1].Enabled = false;
            }
            else
            {
                cms.Items[1].Enabled = false;
                if (dgv.SelectedRows[0].Cells[6].Value.ToString() == "Finished")
                {
                    cms.Items[1].Enabled = true;
                }
                
            }
        }

        private void cmsCenter_Opening(object sender, CancelEventArgs e)
        {
            loadCMS(dgvCenter, cmsCenter);
        }

        private void cmsRight_Opening(object sender, CancelEventArgs e)
        {
            loadCMS(dgvRight, cmsRight);
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            confirmRemove(dgvCenter, "C");
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirmRemove(dgvLeft, "L");
        }

        private void removeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            confirmRemove(dgvRight, "R");
        }

        private void confirmRemove(Guna.UI2.WinForms.Guna2DataGridView dgv, String LCR)
        {
            try
            {
                msgYesNo.Text = "Are you sure you want to delete the selected data?";
                DialogResult res = msgYesNo.Show();
                if (res == DialogResult.Yes)
                {
                    if(dgv.Rows.Count > 0)
                    {
                        foreach(DataGridViewRow row in dgv.SelectedRows)
                        {
                            machineStatus.deleteLoad(LCR, row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), row.Cells[5].Value.ToString());
                        }
                        machineStatus.reArrangeLoad(LCR, machineID.ToString());

                        msgOk.Caption = "Success!";
                        msgOk.Text = "Selected data deleted successfully.";
                        msgOk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        msgOk.Show();
                        start();
                    }
                }
            }
            catch (Exception ex)
            {
                msgOk.Caption = "Error!";
                msgOk.Text = ex.Message;
                msgOk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                msgOk.Buttons = Guna.UI2.WinForms.MessageDialogButtons.RetryCancel;
                msgOk.Show();
            }
            
        }

        private void completeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            completeLoad(dgvLeft, "L");
        }

        private void completeLoad(Guna.UI2.WinForms.Guna2DataGridView dgv, string LCR)
        {
            try
            {

                string lot = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string ins = dgv.SelectedRows[0].Cells[1].Value.ToString();
                string spec = dgv.SelectedRows[0].Cells[2].Value.ToString();
                string type = dgv.SelectedRows[0].Cells[4].Value.ToString();
                string art = dgv.SelectedRows[0].Cells[5].Value.ToString();

                machineStatus.completeLoad(machineID, LCR, ins, lot, art, spec, type);
                start();
            }
            catch(Exception ex)
            {
                msgOk.Caption = "Error!";
                msgOk.Text = ex.Message;
                msgOk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                msgOk.Show();
            }
            
        }

        private void completeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            completeLoad(dgvCenter, "C");
        }

        private void completeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            completeLoad(dgvRight, "R");
        }
    }
}
