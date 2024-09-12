using Guna.UI2.WinForms;
using RewindingManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewindingManager.Forms
{
    public partial class MachineInput : Form
    {
        Classes.MachineInput machineInput = new Classes.MachineInput();
        Classes.Theme theme = new Classes.Theme();
        private String machineID {  get; set; }
        private String lineNo {  get; set; }
        private String machineNo { get; set; }

        private String PICLoad { get; set; }

        public MachineInput()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form frmMachine = Application.OpenForms["frmMachine"];
            if(frmMachine != null && frmMachine is frmMachine)
            {
                frmMachine mch = (frmMachine)frmMachine;
                mch.start();
            }
            this.Close();
        }

        private void txtInstructionNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    machineInput.instructionNo = txtInstructionNo.Text;
                    machineInput.setForInput();

                    dgvLots.DataSource = null;
                    dgvLots.Rows.Clear();
                    if (machineInput.forInput.Rows.Count > 0)
                    {
                        dgvLots.AutoGenerateColumns = false;
                        dgvLots.DataSource = machineInput.forInput;
                    }
                    else
                    {
                        msgOk.Caption = "No Lots Found!";
                        msgOk.Text = "Please try another Instruction Number.";
                        msgOk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                        msgOk.Show();
                    }
                }
            }
            catch(Exception ex)
            {
                Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
                msg.Caption = "Error!";
                msg.Text = ex.Message;
                msg.Parent = this;
                msg.Icon = MessageDialogIcon.Error;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Style = MessageDialogStyle.Light;
                msg.Show();
            }
        }

        private void txtInstructionNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void moveSelectedArticle(Guna.UI2.WinForms.Guna2DataGridView dgv, string LCR)
        {
            int count = 0;
            foreach(DataGridViewRow posRow in dgvLots.SelectedRows)
            {
                if (posRow.Cells[6].Value.ToString() != LCR)
                {
                    count++;
                }
            }
            if(count > 0)
            {
                msgYesNo.Caption = "Warning...";
                msgYesNo.Text = "You are about to load article/s that is not recommended by RBS System. Are you sure you want to proceed?";
                DialogResult isProceed = msgYesNo.Show();
                if (isProceed == DialogResult.Yes)
                {
                    PICInput picinput = new PICInput();
                    picinput.ShowDialog();
                    foreach (DataGridViewRow row in dgvLots.SelectedRows)
                    {
                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            newRow.Cells[i].Value = row.Cells[i].Value;
                        }

                        dgv.Rows.Add(newRow);

                        dgvLots.Rows.Remove(row);
                    }
                    foreach (DataGridViewRow dgvRow in dgv.Rows)
                    {
                        if (dgvRow.Cells[6].Value.ToString() != LCR)
                        {
                            for (int i = 0; i < dgvRow.Cells.Count; i++)
                            {
                                if (i == dgvRow.Cells.Count - 1)
                                {
                                    dgvRow.Cells[i].Value = PICLoad;
                                }
                            }
                        }
                    }
                    dgv.Sort(dgv.Columns[7], ListSortDirection.Ascending);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvLots.SelectedRows)
                {
                    DataGridViewRow newRow = (DataGridViewRow)row.Clone();

                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        newRow.Cells[i].Value = row.Cells[i].Value;
                    }

                    dgv.Rows.Add(newRow);

                    dgvLots.Rows.Remove(row);
                }
                //foreach(DataGridViewRow dgvRow in dgv.Rows)
                //{
                //    for (int i = 0;i < dgvRow.Cells.Count; i++)
                //    {
                //        if(i == dgvRow.Cells.Count - 1 && dgvRow.Cells[i].Value.ToString() != "")
                //        {
                //            dgvRow.Cells[i].Value = "";
                //        }
                //    }
                //}
                dgv.Sort(dgv.Columns[7], ListSortDirection.Ascending);
            }
        }

        private void removeSelectedArticle(Guna.UI2.WinForms.Guna2DataGridView datagridview)
        {
            if(dgvLots.DataSource is DataTable dataTable)
            {
                foreach(DataGridViewRow row in datagridview.SelectedRows)
                {
                    object[] rowData =
                    {
                        row.Cells[0].Value,
                        row.Cells[1].Value,
                        row.Cells[2].Value,
                        row.Cells[3].Value,
                        row.Cells[4].Value,
                        //row.Cells[5].Value,
                        row.Cells[6].Value,
                        row.Cells[7].Value,
                        row.Cells[8].Value,
                        row.Cells[5].Value,
                    };

                    DataRow newRow = dataTable.NewRow();
                    newRow.ItemArray = rowData;
                    dataTable.Rows.Add(newRow);
                }
                dgvLots.Sort(dgvLots.Columns[7], ListSortDirection.Ascending);
                foreach(DataGridViewRow row1 in datagridview.SelectedRows)
                {
                    datagridview.Rows.Remove(row1);
                }
            }
            
        }

        private void MachineInput_Load(object sender, EventArgs e)
        {
            others();
        }

        private void others()
        {
            machineInput.setMachineInfo(machineID);
            lblLineNo.Text = "LINE: " + lineNo;
            lblMachineNo.Text = "RM # " + machineNo;
            this.BackColor = ColorTranslator.FromHtml(theme.background2);
            btnCancel.ForeColor = ColorTranslator.FromHtml(theme.cancelFore);
            btnCancel.FillColor = ColorTranslator.FromHtml(theme.cancelFill);

            setMachine(dgvL, "L", lblLeft, btnAddToL);
            setMachine(dgvC, "C", lblCenter, btnAddToC);
            setMachine(dgvR, "R", lblRight, btnAddToR);
        }
        private void setMachine(Guna.UI2.WinForms.Guna2DataGridView dgv, String LCR, Guna.UI2.WinForms.Guna2HtmlLabel lbl, Guna.UI2.WinForms.Guna2Button btn)
        {
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(theme.cancelFore);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(
                machineInput.returnMachineColor(LCR)
            );
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml(theme.cancelFore);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(
                machineInput.returnMachineColor( LCR )
            );
            //lbl.Text = $"{lbl.Text} ({Classes.Static.toCapitalFWEL(machineInput.returnMachineStatus(LCR))})";
            if (machineInput.returnMachineStatus(LCR) == "maintenance")
            {
                theme.disableButton(btn);
            }
        }

        public void set_LineNo_MNo_MID(String line, String mcNo, String mcID)
        {
            lineNo = line;
            machineNo = mcNo;
            machineID = mcID;
        }

        private void arrangeArticle(Guna.UI2.WinForms.Guna2DataGridView dgv, String direction)
        {
            if(dgv.SelectedRows.Count > 0)
            {
                int rowIndex;
                if (direction == "up")
                {
                    rowIndex = dgv.SelectedRows[0].Index;
                    if (rowIndex == 0)
                        return;
                }
                else
                {
                    rowIndex = dgv.SelectedRows[dgv.SelectedRows.Count - 1].Index;
                    if (rowIndex == dgv.RowCount - 1)
                        return;
                }

                DataGridViewRowCollection rows = dgv.Rows;
                DataGridViewRow selectedRow = rows[rowIndex];
                rows.RemoveAt(rowIndex);

                if (direction == "up")
                {
                    rows.Insert(rowIndex - 1, selectedRow);
                    dgv.ClearSelection();
                    dgv.Rows[rowIndex - 1].Selected = true;
                }
                else
                {
                    rows.Insert(rowIndex + 1, selectedRow);
                    dgv.ClearSelection();
                    dgv.Rows[rowIndex + 1].Selected = true;
                }
            }
        }

        private void btnLeftUp_Click(object sender, EventArgs e)
        {
            arrangeArticle(dgvL, "up");
        }

        private void btnLeftDown_Click(object sender, EventArgs e)
        {
            arrangeArticle(dgvL, "down");
        }

        private void btnCenterUp_Click(object sender, EventArgs e)
        {
            arrangeArticle(dgvC, "up");
        }

        private void btnCenterDown_Click(object sender, EventArgs e)
        {
            arrangeArticle(dgvC, "down");
        }

        private void btnRightUp_Click(object sender, EventArgs e)
        {
            arrangeArticle(dgvR, "up");
        }

        private void btnRightDown_Click(object sender, EventArgs e)
        {
            arrangeArticle(dgvR, "down");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            msgYesNo.Caption = "Confirm action...";
            msgYesNo.Text = "Are you sure you want to proceed?";
            msgYesNo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            DialogResult confirm = msgYesNo.Show();
            if(confirm == DialogResult.Yes)
            {
                int status = 0;
                if (dgvL.Rows.Count > 0 || dgvC.Rows.Count > 0 || dgvR.Rows.Count > 0)
                {
                    status += complete(lblLeft, dgvL, "Left");
                    status += complete(lblCenter, dgvC, "Center");
                    status += complete(lblRight, dgvR, "Right");

                    if (status != 0)
                    {
                        msgOk.Caption = "Success!";
                        msgOk.Text = "Successfully Loaded.";
                        msgOk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        msgOk.Show();
                        dgvL.Rows.Clear();
                        dgvC.Rows.Clear();
                        dgvR.Rows.Clear();
                    }
                }
                else
                {
                    msgOk.Caption = "No loaded article!";
                    msgOk.Text = "Kindly input Instruction Number and  load Articles to the machine.";
                    msgOk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    msgOk.Show();
                }
            }
            others();
        }

        private int complete(Guna.UI2.WinForms.Guna2HtmlLabel lbl, Guna.UI2.WinForms.Guna2DataGridView dgv, String LCR)
        {
            int status = 0;
            if (dgv.Rows.Count > 0)
            {
                try
                {
                    status = machineInput.loadArticle(dgv, int.Parse(machineID), LCR, msgOk, txtInstructionNo.Text, msgYesNo, lineNo, machineNo);
                }
                catch (Exception ex)
                {
                    msgOk.Caption = "Error!";
                    msgOk.Text = ex.Message;
                    msgOk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    msgOk.Show();
                }
            }
            return status;
        }

        private void btnRemoveFromL_Click(object sender, EventArgs e)
        {
            removeSelectedArticle(dgvL);
        }

        private void btnRemoveFromC_Click(object sender, EventArgs e)
        {
            removeSelectedArticle(dgvC);
        }

        private void btnRemoveFromR_Click(object sender, EventArgs e)
        {
            removeSelectedArticle(dgvR);
        }

        private void btnAddToC_Click_1(object sender, EventArgs e)
        {
            moveSelectedArticle(dgvC, "C");
        }

        private void btnAddToR_Click(object sender, EventArgs e)
        {
            moveSelectedArticle(dgvR, "R");
        }

        private void btnAddToL_Click(object sender, EventArgs e)
        {
            moveSelectedArticle(dgvL, "L");
        }

        public void setPIC(string pic)
        {
            PICLoad = pic;
        }
    }
}
