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
using POS.Utilities;

namespace POS.Reports.Purchase
{
    public partial class PURCHASELISTING_FRM : Form
    {
        public PURCHASELISTING_FRM()
        {
            InitializeComponent();
        }

        #region Global Varaible 

        Controls controls  = new Controls();
        readonly DropDownList downList = new DropDownList();
        DataManager dataManager = new DataManager();
        #endregion

        private void btnFormat_Click(object sender, EventArgs e)
        {
           
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 45;
            downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Purchase Listing'",txtFormatCode,this,droplistFrm,btnFormat,i,2);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtFormatCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtFormatDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
            }

        }

        private void btnItemCode_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 45;
            downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ",txtItemCode,this,droplistFrm,btnItemCode,i);
            if (droplistFrm.ShowDialog()== DialogResult.OK)
            {
                txtItemCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtItemCode1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
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

        private void btnUnitReport_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 47;
            downList.BindingData("SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP'",txtUnitReport,this,droplistFrm,btnUnitReport,i);
            if (droplistFrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtUnitReport.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var report = new Report();
            var d = "";
            d = cboPurhcaseType.Text.Substring(0,1);
            
            var i = "1";
            var tranFrom = "";
            var tranTo = "";
            var itemFrom = txtItemCode.Text;
            var itemTo = txtItemCode1.Text;
            var item = "1";
            if (txtItemCode.Text == "" && txtItemCode1.Text == "")
            {
                item = "";
            }
           if (txtTranFrom.Text == "" && txtTranTo.Text == "")
            {
               tranFrom = "";
               tranTo = "";
               i = "";
            }
           else
           {
               tranFrom = txtTranFrom.Text;
               tranTo = txtTranTo.Text;
           }
            var unitType = txtUnitReport.Text;
            var obj = new object[]
                          {
                              "REF", i, "REP", d, "REF_FROM", tranFrom, "REF_TO", tranTo, "ITEM", item, "ITEM_FROM", itemFrom, "ITEM_TO"
                              , itemTo,"DATE",1,"TRANDATE_FROM",string.Format("{0:MM/dd/yyyy}",dtDateFrom.Value),"TRANDATE_TO",string.Format("{0:MM/dd/yyyy}", dtDateTo.Value)
                              ,"REP_UNIT_CONV",unitType
                          };
            var dt = dataManager.GetData_Proc("SI_SELECT_PURCHASE_LISTING", obj);
            
            switch (d)
            {
                    case "O":
                    report.Preview("Purchase Listing", dt);//,"fromDate",dtDateFrom.Value.ToShortDateString(),"toDate",dtDateTo.Value.ToShortDateString());
                    break;
                    case "I":
                    report.Preview("Purchase Listing", dt);//, "fromDate", dtDateFrom.Value.ToShortDateString(), "toDate", dtDateTo.Value.ToShortDateString());
                    break;
                    case "D":
                    report.Preview("Purchase Listing", dt);//, "fromDate", dtDateFrom.Value.ToShortDateString(), "toDate", dtDateTo.Value.ToShortDateString());
                    break;
            }   
        }

        private void txtFormatCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFormatCode.Text != "")
                {
                    var dt = dataManager.GetData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE UPPER(REP_CODE) LIKE UPPER('" + txtFormatCode.Text + "%') AND REP_TYPE = 'Purchase Listing'");
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
                Int16 i = 45;
                downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Purchase Listing'", txtFormatCode, this, droplistFrm, btnFormat, i, 2);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtFormatCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtFormatDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                    
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
                        txtTranFrom.Focus();
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
                    txtTranFrom.Focus();
                }
            }
        }

        private void txtTranFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTranTo.Focus();
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
                Int16 i = 47;
                downList.BindingData("SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP'", txtUnitReport, this, droplistFrm, btnUnitReport, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtUnitReport.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    btnPreview.Focus();
                }
            }
        }

        private void txtTranTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboPurhcaseType.Focus();
            }
        }

        private void cboPurhcaseType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboPurhcaseType.Text != "")
                {
                    dtDateFrom.Focus();    
                }
                else
                {
                    MessageBox.Show("Please select on purhcase type", "Empty", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    cboPurhcaseType.Focus();
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

        private void PURCHASELISTING_FRM_Load(object sender, EventArgs e)
        {
            cboPurhcaseType.SelectedItem = 0;
        }



    }
}
