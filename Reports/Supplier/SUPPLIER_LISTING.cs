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

namespace POS.Reports.Supplier
{
    public partial class SUPPLIER_LISTING : Form
    {
        public SUPPLIER_LISTING()
        {
            InitializeComponent();
        }
        DropDownList downList = new DropDownList();
        DataManager dataManager = new DataManager();

        private void btnFormat_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 47;
            downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Supplier Listing'", txtFormatCode, this, droplistFrm, btnFormat, i, 2);
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
                    var dt = dataManager.GetData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE UPPER(REP_CODE) LIKE UPPER('" + txtFormatCode.Text + "%') AND REP_TYPE = 'Supplier Listing'");
                    if (dt.Rows.Count > 0)
                    {
                        txtFormatCode.Text = dt.Rows[0][0].ToString();
                        txtFormatDesc.Text = dt.Rows[0][1].ToString();
                        txtSupplierFrom.Focus();
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
                Int16 i = 47
                    ;
                downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Supplier Listing'", txtFormatCode, this, droplistFrm, btnFormat, i, 2);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtFormatCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtFormatDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();

                }

            }
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 47;
            downList.BindingData("SELECT ADD_CODE, ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '1' ORDER BY ADD_CODE ASC ", txtSupplierFrom,
                                 this, droplistFrm, btnSupplier, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtSupplierFrom.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtSupFromDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtSupTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtSupDescTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtSupTo.Focus();
            }
        }

        private void btnItemCode_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 47;
            downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txtItemCode, this, droplistFrm, btnItemCode, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtItemCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtItemCode1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtItemCode1.Focus();
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
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                Int16 i = 45;
                downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txtItemCode, this, droplistFrm, btnItemCode, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtItemCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtItemCode1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtItemCode1.Focus();
                }
            }
        }

        private void txtItemCode1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtItemCode1.Text != "")
                {
                    var dt =
                        dataManager.GetData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS WHERE UPPER(ITEM_CODE) LIKE UPPER('" +
                                            txtItemCode1.Text + "%') ORDER BY ITEM_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txtItemCode1.Text = dt.Rows[0][0].ToString();
                        txtUnitReport.Focus();
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
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                Int16 i = 45;
                downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txtItemCode1, this, droplistFrm, btnItemCode1, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtItemCode1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtUnitReport.Focus();
                }
            }
        }

        private void btnItemCode1_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 45;
            downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txtItemCode1, this, droplistFrm, btnItemCode1, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtItemCode1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
            }
        }

        private void btnSupTo_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 47;
            downList.BindingData("SELECT ADD_CODE, ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '1' ORDER BY ADD_CODE ASC ", txtSupTo,
                                 this, droplistFrm, btnSupTo, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtSupTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtSupDescTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtItemCode.Focus();
            }
        }

        private void txtSupplierFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSupplierFrom.Text != "")
                {
                    var dt = dataManager.GetData("SELECT ADD_CODE, ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '1' AND UPPER(ADD_CODE) LIKE UPPER('"+ txtSupplierFrom.Text + "%') ORDER BY ADD_CODE ASC");
                    if (dt.Rows.Count > 0)
                    {
                        txtSupplierFrom.Text = dt.Rows[0][0].ToString();
                        txtSupFromDesc.Text = dt.Rows[0][1].ToString();
                        txtSupTo.Text = dt.Rows[0][0].ToString();
                        txtSupDescTo.Text = dt.Rows[0][1].ToString();
                        txtSupTo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Supplier code '" + txtSupplierFrom.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSupplierFrom.SelectionStart = 0;
                        txtSupplierFrom.SelectionLength = txtSupplierFrom.Text.Length;
                        txtSupplierFrom.Focus();
                        return;
                    }
                }
            }
            else if(e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                Int16 i = 47;
                downList.BindingData("SELECT ADD_CODE, ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '1' ORDER BY ADD_CODE ASC ", txtSupplierFrom,
                                     this, droplistFrm, btnSupplier, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtSupplierFrom.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtSupFromDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                    txtSupTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtSupDescTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                    txtSupTo.Focus();
                }
            }
        }

        private void txtSupTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSupTo.Text != "")
                {
                    var dt = dataManager.GetData("SELECT ADD_CODE, ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '1' AND UPPER(ADD_CODE) LIKE UPPER('" + txtSupTo.Text + "%') ORDER BY ADD_CODE ASC");
                    if (dt.Rows.Count > 0)
                    {
                        txtSupTo.Text = dt.Rows[0][0].ToString();
                        txtSupDescTo.Text = dt.Rows[0][1].ToString();
                        txtItemCode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Supplier code '" + txtSupTo.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSupTo.SelectionStart = 0;
                        txtSupTo.SelectionLength = txtSupTo.Text.Length;
                        txtSupTo.Focus();
                        return;
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                Int16 i = 47;
                downList.BindingData("SELECT ADD_CODE, ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '1' ORDER BY ADD_CODE ASC ", txtSupTo,
                                     this, droplistFrm, btnSupTo, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtSupTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtSupDescTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                    txtItemCode.Focus();
                }
            }
        }

        private void btnUnitReport_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 47;
            downList.BindingData("SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP'", txtUnitReport, this, droplistFrm, btnUnitReport, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtUnitReport.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                cboPurchaseType.Focus();
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
                            "SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP' AND UPPER(SI_CODE) LIKE UPPER ('" +
                            txtUnitReport.Text + "%')");
                    if (dt.Rows.Count > 0)
                    {
                        txtUnitReport.Text = dt.Rows[0][0].ToString();
                        cboPurchaseType.Focus();
                    }
 
                }
            }
            else if(e.KeyCode ==Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                Int16 i = 47;
                downList.BindingData("SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP'", txtUnitReport, this, droplistFrm, btnUnitReport, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtUnitReport.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    cboPurchaseType.Focus();
                }
            }
        }

        private void cboPurchaseType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                if (cboPurchaseType.Text != "")
                {
                    btnPreview.Focus();        
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var report = new Report();
            var d = "";
            d = cboPurchaseType.Text.Substring(0, 1);

            var i = "1";
            var j = "1";
            var supFrom = "";
            var supTo = "";
            var itemFrom = txtItemCode.Text;
            var itemTo = txtItemCode1.Text;
            if (txtSupplierFrom.Text == "" && txtSupTo.Text == "")
            {
                supFrom = "";
                supTo = "";
                i = "";
            }
            else
            {
                supFrom = txtSupplierFrom.Text;
                supTo = txtSupTo.Text;
            }
            if (txtItemCode.Text == "" && txtItemCode1.Text == "")
            {
                itemFrom = "";
                itemTo = "";
                j = "";
            }
            var unitType = txtUnitReport.Text;
            var obj = new object[]
                          {
                              "REP", d, "ITEM", j, "ITEM_FROM", itemFrom, "ITEM_TO"
                              , itemTo,"SUP",i,"SUPPLIER_FROM",supFrom,"SUPPLIER_TO",supTo
                              ,"REP_UNIT_CONV",unitType
                          };
            var dt = dataManager.GetData_Proc("SI_SELECT_SUPPLIER_LISTING", obj);

            switch (d)
            {
                case "O":
                    report.Preview("Supplier Listing", dt);
                    break;
                case "I":
                    report.Preview("Supplier Listing", dt);
                    break;
                case "D":
                    report.Preview("Supplier Listing", dt);
                    break;
            }   

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
