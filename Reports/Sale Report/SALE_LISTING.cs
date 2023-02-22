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

namespace POS.Reports.Sale_Report
{
    public partial class SALE_LISTING : Form
    {
        public SALE_LISTING()
        {
            InitializeComponent();
        }

        readonly DropDownList _downList = new DropDownList();
        readonly DataManager _dataManager = new DataManager();

        private void btnFormat_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 47;
            _downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Sale Listing'", txtFormatCode, this, droplistFrm, btnFormat, i, 2);
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
                    var dt = _dataManager.GetData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE UPPER(REP_CODE) LIKE UPPER('" + txtFormatCode.Text + "%') AND REP_TYPE = 'Sale Listing'");
                    if (dt.Rows.Count > 0)
                    {
                        txtFormatCode.Text = dt.Rows[0][0].ToString();
                        txtFormatDesc.Text = dt.Rows[0][1].ToString();
                        txtLocationFrom.Focus();
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
                _downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Sale Listing'", txtFormatCode, this, droplistFrm, btnFormat, i, 2);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtFormatCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtFormatDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
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
                txtLocDesFrom.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtLocationTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtLocDesTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
            }
        }

        private void txtLocationFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtLocationFrom.Text != "")
                {
                    var dt =
                        _dataManager.GetData(
                            "SELECT LOC_CODE,LOC_NAME FROM SIPLOCA WHERE UPPER(LOC_CODE) LIKE UPPER('" +
                            txtLocationFrom.Text + "%') ORDER BY LOC_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txtLocationFrom.Text = dt.Rows[0][0].ToString();
                        txtLocDesFrom.Text = dt.Rows[0][1].ToString();
                        txtLocationTo.Text = dt.Rows[0][0].ToString();
                        txtLocDesTo.Text = dt.Rows[0][1].ToString();
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
        }

        private void btnLocationTo_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 45;
            _downList.BindingData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA ORDER BY LOC_CODE ASC ", txtLocationTo,
                                  this, droplistFrm, btnLocationTo, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtLocationTo.Text =
                    droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtLocDesTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtItemCode.Focus();
            }
        }

        private void txtLocationTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtLocationTo.Text != "")
                {
                    var dt =
                        _dataManager.GetData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA WHERE UPPER(LOC_CODE) LIKE UPPER('" +
                                            txtLocationTo.Text + "%') ORDER BY LOC_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txtLocationTo.Text = dt.Rows[0][0].ToString();
                        txtItemCode.Focus();
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
                        _dataManager.GetData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS WHERE UPPER(ITEM_CODE) LIKE UPPER('" +
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
        }

        private void btnItemCode1_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 45;
            _downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txtItemCode, this, droplistFrm, btnItemCode, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtItemCode1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                                dtDateFrom.Focus();
            }
        }

        private void txtItemCode1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtItemCode.Text != "")
                {
                    var dt =
                        _dataManager.GetData(
                            "SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS WHERE UPPER(ITEM_CODE) LIKE UPPER('" +
                            txtItemCode1.Text + "%') ORDER BY ITEM_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txtItemCode1.Text = dt.Rows[0][0].ToString();
                        txtTransFrom.Focus();
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
                        _dataManager.GetData(
                            "SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP' AND UPPER(SI_CODE) LIKE UPPER('" +
                            txtUnitReport.Text + "%')");
                    if (dt.Rows.Count > 0)
                    {
                        txtUnitReport.Text = dt.Rows[0][0].ToString();
                        cboTransferInOut.Focus();
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
                    cboTransferInOut.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTransFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTranTo.Focus();
            }
        }

        private void txtTranTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtDateFrom.Focus();
            }
        }

        private void cboTransferInOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboTransferInOut.Text!= "")
                {
                    btnPreview.Focus();
                }
            }
        }

        private void SALE_LISTING_Load(object sender, EventArgs e)
        {
            cboTransferInOut.SelectedIndex = 0;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var item = "1";
            var loc = "1";
            var movRef = "1";
            if (txtItemCode.Text == "" && txtItemCode1.Text == "")
            {
                item = "";
            }
            if (txtLocationFrom.Text == "" && txtLocDesTo.Text =="")
            {
                loc = "";
            }
            if (txtTransFrom.Text == "" && txtTranTo.Text == "")
            {
                movRef = "";
            }
            var dataManager = new DataManager();
//            
            var dateFrom = string.Format("{0:MM/dd/yyyy}", dtDateFrom.Value);
            var dateTo = string.Format("{0:MM/dd/yyyy}", dtDateTo.Value);
            var saleType = cboTransferInOut.Text.Substring(0, 1);
            var dt = dataManager.GetData_Proc("SELECT_SALE_LISTING", "ITEM", item, "ITEM_FROM", txtItemCode.Text,
                                              "ITEM_TO", txtItemCode1.Text, "LOC", loc, "LOC_FROM", txtLocationFrom.Text,
                                              "LOC_TO", txtLocationTo.Text, "DATE_FROM", dateFrom, "DATE_TO", dateTo,
                                              "MOV", movRef, "MOV_FROM", txtTransFrom.Text, "MOV_TO", txtTranTo.Text,
                                              "SALE_TYPE", saleType,"REP_UNIT",txtUnitReport.Text);
           
            var report = new Report();
            report.Preview("Sale Listing",dt);

        }
    }
}
