using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.GUI;
using POS.Transaction;

namespace POS.Reports.Inventory_Movement
{
    public partial class INVENTORY_MOVEMENT_FRM : Form
    {
        public INVENTORY_MOVEMENT_FRM()
        {
            InitializeComponent();
        }

        readonly DropDownList _downList = new DropDownList();
        DataManager dataManager  = new DataManager();

        private void btnFormat_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 47;
            _downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Inventory Movement' OR REP_TYPE = 'Inventory Movement Amount'", txtFormatCode, this, droplistFrm, btnFormat, i, 2);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtFormatCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtFormatDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
            }

        }

        private void txtFormatCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFormatCode.Text != "")
                {
                    var dt = dataManager.GetData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE UPPER(REP_CODE) LIKE UPPER('" + txtFormatCode.Text + "%') AND REP_TYPE = 'Inventory Movement' OR REP_TYPE = 'Inventory Movement Amount'");
                    if (dt.Rows.Count > 0)
                    {
                        txtFormatCode.Text = dt.Rows[0][0].ToString();
                        txtFormatDesc.Text = dt.Rows[0][1].ToString();
                        txtItemCode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Not found code '" + txtFormatCode.Text + "'", "Not Found", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        txtFormatCode.SelectAll();
                        txtFormatCode.SelectionStart = 0;
                        txtFormatCode.SelectionLength = txtFormatCode.Text.Length;
                        txtFormatCode.Focus();
                        return;
                    }

                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                const short i = 47;
                _downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Inventory Movement' OR REP_TYPE = 'Inventory Movement Amount'", txtFormatCode, this, droplistFrm, btnFormat, i, 2);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtFormatCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtFormatDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                }
            }
        }

        private void btnItemCode_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 45;
            _downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txtItemCode, this, droplistFrm, btnItemCode, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtItemCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtItemCode1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
            }
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtItemCode.Text != "")
                {
                    var dt =
                        dataManager.GetData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS WHERE UPPER(ITEM_CODE) LIKE UPPER('" +
                                            txtItemCode.Text + "%') ORDER BY ITEM_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txtItemCode.Text = dt.Rows[0][0].ToString();
                        txtItemCode1.Text = dt.Rows[0][0].ToString();
                        txtItemCode1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Item code '" + txtItemCode.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtItemCode.SelectionStart = 0;
                        txtItemCode.SelectionLength = txtItemCode.Text.Length;
                        return;
                    }
                } 
            }
            else if(e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                const short i = 45;
                _downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txtItemCode, this, droplistFrm, btnItemCode, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtItemCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtItemCode1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                }
            }
        }

        private void btnLocationFrom_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 45;
            _downList.BindingData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA ORDER BY LOC_CODE ASC ", txtLocationFrom, this, droplistFrm, btnLocationFrom, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtLocationFrom.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtLocationTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
            }
        }

        private void txtLocationFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtLocationFrom.Text != "")
                {
                    var dt =
                        dataManager.GetData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA WHERE UPPER(LOC_CODE) LIKE UPPER('" +
                                            txtLocationFrom.Text + "%') ORDER BY LOC_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txtLocationFrom.Text = dt.Rows[0][0].ToString();
                        txtLocationFrom.Text = dt.Rows[0][0].ToString();
                        txtLocationTo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Location code '" + txtLocationFrom.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLocationFrom.SelectionStart = 0;
                        txtLocationFrom.SelectionLength = txtLocationFrom.Text.Length;
                        return;
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                const short i = 45;
                _downList.BindingData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA ORDER BY LOC_CODE ASC ", txtLocationFrom, this, droplistFrm, btnLocationFrom, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtLocationFrom.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtLocationTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                }
            }
        }

        private void btnItemCode1_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 45;
            _downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txtItemCode, this, droplistFrm, btnItemCode, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtItemCode1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtLocationFrom.Focus();
            }
        }

        private void txtItemCode1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtItemCode.Text != "")
                {
                    var dt =
                        dataManager.GetData(
                            "SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS WHERE UPPER(ITEM_CODE) LIKE UPPER('" +
                            txtItemCode1.Text + "%') ORDER BY ITEM_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txtItemCode1.Text = dt.Rows[0][0].ToString();
                        txtLocationFrom.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Item code '" + txtItemCode1.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtItemCode1.SelectionStart = 0;
                        txtItemCode1.SelectionLength = txtItemCode1.Text.Length;
                        return;
                    }
                }

            }
            else if(e.KeyCode == Keys.F6 )
            {
                var droplistFrm = new DROPLIST_FRM();
                const short i = 45;
                _downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txtItemCode, this, droplistFrm, btnItemCode, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtItemCode1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtLocationFrom.Focus();
                }
            }
        }

        private void btnLocationTo_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 45;
            _downList.BindingData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA ORDER BY LOC_CODE ASC ", txtLocationTo, this, droplistFrm, btnLocationTo, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtLocationTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
            }
        }

        private void txtLocationTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtLocationTo.Text != "")
                {
                    var dt =
                        dataManager.GetData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA WHERE UPPER(LOC_CODE) LIKE UPPER('" +
                                            txtLocationTo.Text + "%') ORDER BY LOC_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txtLocationTo.Text = dt.Rows[0][0].ToString();
                        dtDateFrom.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Location code '" + txtLocationTo.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLocationTo.SelectionStart = 0;
                        txtLocationTo.SelectionLength = txtLocationTo.Text.Length;
                        return;
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                const short i = 45;
                _downList.BindingData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA ORDER BY LOC_CODE ASC ", txtLocationTo, this, droplistFrm, btnLocationTo, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtLocationTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                }
            }
        }

        private void btnUnitReport_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 47;
            _downList.BindingData("SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP'", txtUnitReport, this, droplistFrm, btnUnitReport, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtUnitReport.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
            }
        }

        private void txtUnitReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUnitReport.Text != "")
                {
                    var dt =
                        dataManager.GetData(
                            "SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP' AND UPPER(SI_CODE) LIKE UPPER('" +
                            txtUnitReport.Text + "%')");
                    if (dt.Rows.Count > 0)
                    {
                        txtUnitReport.Text = dt.Rows[0][0].ToString();
                        btnPreview.Focus();
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                const short i = 47;
                _downList.BindingData("SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP'", txtUnitReport, this, droplistFrm, btnUnitReport, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtUnitReport.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    btnPreview.Focus();
                }
            }
        }

        private void dtDateFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtDateTo.Focus();
            }
        }

        private void dtDateTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUnitReport.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var allLoc = "1";
            var item = "1";
            if (txtLocationFrom.Text == "" && txtLocationTo.Text == "")
            {
                allLoc = "";
            }
            else if (txtItemCode.Text == "" & txtItemCode1.Text == "")
            {
                item = "";
            }

            var dFrom = string.Format("{0:MM/dd/yyyy}", dtDateFrom.Value);
            var dTo = string.Format("{0:MM/dd/yyyy}", dtDateTo.Value);
            var dt = dataManager.GetData_Proc("SELECT_MOVEMENT_INVENTORY", "ITEM", item, "ITEM_FROM", txtItemCode.Text,
                                              "ITEM_TO", txtItemCode1.Text, "LOC", allLoc, "LOC_FROM",
                                              txtLocationFrom.Text, "LOC_TO", txtLocationTo.Text, "DATE_FROM",
                                              dFrom, "DATE_TO",
                                              dTo, "REPCONV", txtUnitReport.Text, "All_LOC", allLoc);
            var report = new Report();
            if (txtFormatDesc.Text == "Inventory Movement Amount")
            {
                report.Preview("Inventory Movement Amount",dt);
            }
            else
            {
                report.Preview("Inventory Movement", dt);    
            }
            

        }
    }
}
