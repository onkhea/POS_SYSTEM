using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction;
using POS.Transaction.Maintains;
using POS.Utilities;

namespace POS.GUI.Purchases
{
    public partial class ADDSIPOPURCHASEORDER_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        SIPOPURCHASEORDER_FRM frmPurchaseOrder = new SIPOPURCHASEORDER_FRM();
        
        public ADDSIPOPURCHASEORDER_FRM(SIPOPURCHASEORDER_FRM sipopurchaseorder_FRM)
        {
            InitializeComponent();
            frmPurchaseOrder = sipopurchaseorder_FRM;
        }

        #region Global Variable 

        DataManager dataManager = new DataManager();
        Connection.Connection  connection = new Connection.Connection();
        SIFormats formats = new SIFormats();
        private string STOCK_UNIT = "";
        private decimal STOCK_COST = 0;
        private string SALE_UNIT = "";
        private decimal SALE_COST = 0;
        private string UNIT_OPER = "";
        private decimal UNIT_FACTOR = 0;
        SIItems items = new SIItems();
        private string STOCK_TYPE = "";
        Controls controls = new Controls();

        #endregion

        private void ADDSIPOPURCHASEORDER_FRM_Load(object sender, EventArgs e)
        {

        }

        private void btnItem_Code_Click(object sender, EventArgs e)
        {
            try
            {
                var droplist_FRM = new DROPLIST_FRM();
                droplist_FRM.DataGridView.DataSource =
                    dataManager.GetData(
                        "SELECT ITEM_CODE [Item Code], ITEM_DESC [Description],UNIT_STOCK,ITEM_COST1,UNIT_SALE,ITEM_COST2 FROM SIPITEMS",
                        "ITEM_CODE", "ITEM_STAT", "A", "ITEM_TYPE", "S");
                droplist_FRM.Top = this.Top + txtItem_Code.Top + txtItem_Code.Height + 25;
                droplist_FRM.Left = this.Left + txtItem_Code.Left + 3;
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width * 34 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width * 60 / 100;
                droplist_FRM.DataGridView.Columns[2].Visible = false;
                droplist_FRM.DataGridView.Columns[3].Visible = false;
                droplist_FRM.DataGridView.Columns[4].Visible = false;
                droplist_FRM.DataGridView.Columns[5].Visible = false;
                if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtItem_Code.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    txtItem_Desc.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[1].Value.ToString();
                    txtUnitofStock.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    txtUnitOfPurchase.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[4].Value.ToString();
                    STOCK_UNIT = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    STOCK_COST = Convert.ToDecimal(droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[3].Value.ToString());
                    SALE_UNIT = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[4].Value.ToString();
                    SALE_COST = Convert.ToDecimal(droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[5].Value.ToString());
                    txtItem_Code.Enabled = false;
                    txtItem_Code.BackColor = Color.WhiteSmoke;
                    btnItem_Code.Enabled = false;
                    txtLoc_Desc.Enabled = false;
                    txtLoc_Code.Enabled = true;
                    txtLoc_Code.BackColor = Color.White;
                    btnLoc_Code.Enabled = true;
                    SelectNextControl(txtItem_Code, true, true, true, true);
                }
                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtItem_Code_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtItem_Code.Text != "")
                    {
                        if (Condition.EmptyControl(txtItem_Code))
                            return;
                        else
                        {
                            var dt =
                                dataManager.GetData(
                                    "SELECT ITEM_CODE [Item Code], ITEM_DESC [Description],UNIT_STOCK,ITEM_COST1,UNIT_SALE,ITEM_COST2 FROM SIPITEMS",
                                    "ITEM_CODE", "ITEM_CODE", txtItem_Code.Text, "ITEM_STAT", "A");
                            if (dt.Rows.Count > 0)
                            {
                                txtItem_Code.Text = dt.Rows[0][0].ToString();
                                txtItem_Desc.Text = dt.Rows[0][1].ToString();
                                txtUnitofStock.Text = dt.Rows[0][2].ToString();
                                txtUnitOfPurchase.Text = dt.Rows[0][4].ToString();
                                STOCK_UNIT = dt.Rows[0][2].ToString();
                                STOCK_COST = Convert.ToDecimal(dt.Rows[0][3].ToString());
                                SALE_UNIT = dt.Rows[0][4].ToString();
                                SALE_COST = Convert.ToDecimal(dt.Rows[0][5].ToString());
                                txtItem_Code.Enabled = false;
                                txtItem_Code.BackColor = Color.WhiteSmoke;
                                btnItem_Code.Enabled = false;
                                txtLoc_Code.Enabled = true;
                                txtLoc_Code.BackColor = Color.White;
                                btnLoc_Code.Enabled = true;
                                SelectNextControl(txtItem_Code, true, true, true, true);
                            }
                            else
                            {
                                MessageBox.Show("Data '" + txtItem_Code.Text + " ' not found!", "Not Found",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtItem_Code.SelectionStart = 0;
                                txtItem_Code.SelectionLength = txtItem_Code.ToString().Length;
                                txtItem_Code.Focus();
                                return;
                            }
                          
                        }
                    }
                }
                else if (e.KeyCode == Keys.F6)
                {
                    btnItem_Code_Click(sender, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoc_Code_Click(object sender, EventArgs e)
        {
            try
            {
                DROPLIST_FRM droplist_FRM = new DROPLIST_FRM();
                droplist_FRM.DataGridView.DataSource =
                    dataManager.GetData("SELECT LOC_CODE [Location Code], LOC_NAME [Location Name] FROM dbo.SIPLOCA",
                                        "LOC_CODE", "LOC_STAT", "A"); //"LOC_CODE", txtLoc_Code.Text,
                droplist_FRM.Top = this.Top + txtLoc_Code.Top + txtLoc_Code.Height + 25;
                droplist_FRM.Left = this.Left + txtLoc_Code.Left + 3;
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width * 34 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width * 60 / 100;
                if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtLoc_Code.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    txtLoc_Desc.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[1].Value.ToString();
                    txtLoc_Code.Enabled = false;
                    txtLoc_Code.BackColor = Color.WhiteSmoke;
                    btnLoc_Code.Enabled = false;
                    txtUnitOfPurchase.Enabled = true;
                    txtUnitOfPurchase.BackColor = Color.White;
                    BTN_U_PURCHASE.Enabled = true;
                    txtLoc_Desc.Enabled = true;
                    SelectNextControl(txtLoc_Code, true, true, true, true);
                }
                else
                {
                    txtLoc_Desc.SelectAll();
                    txtLoc_Desc.Focus();
                }
                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtLoc_Code_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtLoc_Code.Text == "")
                    {
                        if (Condition.EmptyControl(txtLoc_Code))
                            return;
                        SelectNextControl(txtLoc_Code, true, true, true, true);
                    }
                    else
                    {
                        var dt =
                            dataManager.GetData(
                                "SELECT LOC_CODE [Location Code], LOC_NAME [Location Name] FROM dbo.SIPLOCA", "LOC_CODE",
                                "LOC_CODE", txtLoc_Code.Text, "LOC_STAT", "A");
                        if (dt.Rows.Count > 0)
                        {
                            txtLoc_Code.Text = dt.Rows[0][0].ToString();
                            txtLoc_Desc.Text = dt.Rows[0][1].ToString();
                            txtLoc_Code.Enabled = false;
                            txtLoc_Code.BackColor = Color.WhiteSmoke;
                            btnLoc_Code.Enabled = false;
                            txtUnitOfPurchase.Enabled = true;
                            txtUnitOfPurchase.BackColor = Color.White;
                            BTN_U_PURCHASE.Enabled = true;
                            SelectNextControl(txtLoc_Code, true, true, true, true);
                        }
                        else
                        {
                            MessageBox.Show("Data '" + txtLoc_Code.Text + " ' not found", "Not Found",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtLoc_Code.SelectionStart = 0;
                            txtLoc_Code.SelectionLength = txtLoc_Code.ToString().Length;
                            return;
                        }
                        SelectNextControl(txtLoc_Code, true, true, true, true);
                    }
                }
                else if(e.KeyCode == Keys.F6)
                {
                    btnLoc_Code_Click(sender,null);
                }
                else if (e.Control && e.KeyCode == Keys.B)
                {
                    txtItem_Code.Enabled = true;
                    txtItem_Code.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_U_PURCHASE_Click(object sender, EventArgs e)
        {
            try
            {
                DROPLIST_FRM droplist_FRM = new DROPLIST_FRM();
                droplist_FRM.DataGridView.DataSource =
                    dataManager.GetData(
                        "SELECT CONV_FROM [Unit Purchase],CONV_F_DESC [Description],OPERATOR,FACTOR FROM SIUNITCONV",
                        "CONV_FROM", "CONV_TO", txtUnitofStock.Text); //"CONV_FROM", txtUnitOfPurchase.Text,
                droplist_FRM.Top = this.Top + txtUnitOfPurchase.Top + txtUnitOfPurchase.Height + 26;
                droplist_FRM.Left = this.Left + txtUnitOfPurchase.Left + 3;
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width * 34 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width * 60 / 100;
                droplist_FRM.DataGridView.Columns[2].Visible = false;
                droplist_FRM.DataGridView.Columns[3].Visible = false;
                if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtUnitOfPurchase.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    UNIT_OPER = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    UNIT_FACTOR = Convert.ToDecimal(droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[3].Value.ToString());
                    txtUnitOfPurchase.Enabled = false;
                    txtUnitOfPurchase.BackColor = Color.WhiteSmoke;
                    BTN_U_PURCHASE.Enabled = false;
                    cboPType.Enabled = true;
                    SelectNextControl(BTN_U_PURCHASE, true, true, true, true);
                }
                else
                {
                    txtLoc_Desc.SelectAll();
                    txtLoc_Desc.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUnitOfPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtUnitOfPurchase.Text == "")
                    {
                        if (Condition.EmptyControl(txtUnitOfPurchase))
                        {
                            return;
                        }
                    }

                    else
                    {
                        var dt =
                            dataManager.GetData(
                                "SELECT CONV_FROM [Unit Purchase],CONV_F_DESC [Description],OPERATOR,FACTOR FROM SIUNITCONV",
                                "CONV_FROM", "CONV_FROM", txtUnitOfPurchase.Text, "CONV_TO", txtUnitofStock.Text);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Data '" + txtUnitOfPurchase.Text + "' not found", "Not Found",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUnitOfPurchase.SelectionStart = 0;
                            txtUnitOfPurchase.SelectionLength = txtUnitOfPurchase.ToString().Length;
                            return;
                        }
                        txtUnitOfPurchase.Text = dt.Rows[0][0].ToString();
                        UNIT_OPER = dt.Rows[0][2].ToString();
                        UNIT_FACTOR = Convert.ToDecimal(dt.Rows[0][3].ToString());
                        txtUnitOfPurchase.Enabled = false;
                        txtUnitOfPurchase.BackColor = Color.WhiteSmoke;
                        BTN_U_PURCHASE.Enabled = false;
                        cboPType.Enabled = true;
                        SelectNextControl(txtUnitOfPurchase, true, true, true, true);
                    }
                }
                else if(e.KeyCode == Keys.F6)
                {
                    BTN_U_PURCHASE_Click(sender,null);
                }
                else if (e.Control && e.KeyCode == Keys.B)
                {
                    txtLoc_Code.Enabled = true;
                    txtLoc_Code.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboPType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboPType.SelectedIndex ==1)
                {
                    txtCost.Text = string.Format(formats.PO_Format,0);
                    txtCost.ReadOnly = true;
                }
                else
                {
                    txtCost.Text = txtUnitOfPurchase.Text == STOCK_UNIT
                                       ? string.Format(formats.PO_Format, STOCK_COST)
                                       : (txtUnitOfPurchase.Text == SALE_UNIT
                                              ? string.Format(formats.PO_Format, SALE_COST)
                                              : string.Format(formats.PO_Format, 0));

                }
                cboPType.Enabled = false;
                dtpE.Enabled = true;
                SelectNextControl(cboPType, true, true, true, true);
            }
            else if(e.Control == true && e.KeyCode == Keys.B)
            {
                cboPType.Enabled = false;
                txtUnitOfPurchase.Enabled = true;
                txtUnitOfPurchase.BackColor = Color.White;
                BTN_U_PURCHASE.Enabled = true;
                SelectNextControl(cboPType, false, true, true, true);
            }
        }

        private void dtpE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpE.Enabled = false;
                txtQTY.Enabled = true;
                txtQTY.BackColor = Color.White;
                SelectNextControl(dtpE, true, true, true, true);
            }
            else if(e.Control == true && e.KeyCode == Keys.B)
            {
                dtpE.Enabled = false;
                cboPType.Enabled = true;
                SelectNextControl(dtpE, false, true, true, true);
            }
        }

        private void txtQTY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                if (Condition.Check_Decimal(txtQTY)) return;
                if (Convert.ToDecimal(txtQTY.Text) < 0)
                {
                    MessageBox.Show("Quanity must be greater than zero.", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
                txtStockQ.Text = UNIT_OPER == "*" ? string.Format("{0:0,0}", Convert.ToDecimal(txtQTY.Text) * UNIT_FACTOR) : string.Format("{0:0,0}", Convert.ToDecimal(txtQTY.Text) / 100);
                if (Condition.Check_Decimal(txtCost))
                {
                    txtSubTotal.Text = string.Format(formats.PO_Format,
                                                     Convert.ToDecimal(txtQTY.Text)*Convert.ToDecimal(txtCost.Text));

                }
                txtQTY.Enabled = false;
                txtQTY.BackColor = Color.WhiteSmoke;
                txtCost.Enabled = true;
                txtCost.BackColor = Color.White;
                SelectNextControl(txtQTY, true, true, true, true);
            }
            else if(e.Control == true && e.KeyCode == Keys.B)
            {
                txtQTY.Enabled = false;
                txtQTY.BackColor = Color.WhiteSmoke;
                dtpE.Enabled = true;
                SelectNextControl(txtQTY, false, true, true, true);
            }
        }

        private void txtCost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.Check_Decimal(txtCost)) return;
                if (cboPType.SelectedIndex == 0)
                {
                    if (Convert.ToDecimal(txtCost.Text) <= 0)
                    {
                        MessageBox.Show("Purchase cost must be greater than zero.", "", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }
                    txtSubTotal.Text = string.Format(formats.PO_Format,
                                                     Convert.ToDecimal(txtQTY.Text)*Convert.ToDecimal(txtCost.Text));
                }
                txtCost.Enabled = false;
                txtCost.BackColor = Color.WhiteSmoke;
                txtDisP.Enabled = true;
                txtDisP.BackColor = Color.White;
                SelectNextControl(txtCost, true, true, true, true);
            }
            else if(e.Control == true && e.KeyCode == Keys.B)
            {
                txtCost.Enabled = false;
                txtCost.BackColor = Color.WhiteSmoke;
                txtQTY.Enabled = true;
                txtQTY.BackColor = Color.White;
                SelectNextControl(txtCost, false, true, true, true);
            }
        }

        private void txtDisP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.Check_Decimal(txtDisP))
                    return;
                txtDisAmt.Text = string.Format(formats.PO_Format,
                                             Convert.ToDecimal(txtSubTotal.Text)*(Convert.ToDecimal(txtDisP.Text)/100));
                txtTotal.Text = string.Format(formats.PO_Format,
                                              Convert.ToDecimal(txtSubTotal.Text) - Convert.ToDecimal(txtDisAmt.Text));
                txtDisP.Enabled = false;
                txtDisP.BackColor = Color.WhiteSmoke;
                txtDisAmt.Enabled = true;
                txtDisAmt.BackColor = Color.White;
                SelectNextControl(txtDisP, true, true, true, true);
            }
            else if (e.Control == true && e.KeyCode == Keys.B)
            {
                txtDisP.Enabled = false;
                txtDisP.BackColor = Color.WhiteSmoke;
                txtCost.Enabled = true;
                txtCost.BackColor = Color.White;
                SelectNextControl(txtDisP, false, true, true, true);
            }
        }

        private void txtDisAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.Check_Decimal(txtDisAmt))
                    return;
                txtTotal.Text = string.Format(formats.PO_Format,
                                              Convert.ToDecimal(txtSubTotal.Text) - Convert.ToDecimal(txtDisAmt.Text));
                txtDisAmt.Enabled = false;
                txtDisAmt.BackColor = Color.WhiteSmoke;
                OK_Button.Enabled = true;
                SelectNextControl(txtDisAmt, true, true, true, true);
            }
            else if(e.Control == true && e.KeyCode == Keys.B)
            {
                txtDisAmt.Enabled = false;
                txtDisAmt.BackColor = Color.WhiteSmoke;
                txtDisP.Enabled = true;
                txtDisP.BackColor = Color.White;
                SelectNextControl(txtDisAmt, false, true, true, true);
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
//            ==============  Check exist item ==========
            if (txtItem_Code.Visible == true)
            {
                if (Condition.EmptyControl(txtItem_Code))
                    return;
                if (!dataManager.Exists("SIPITEMS", txtItem_Code.Text, "ITEM_CODE"))
                {
                    MessageBox.Show("Data '" + txtItem_Code.Text + "' not found", "Not Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtItem_Code.SelectAll();
                    txtItem_Code.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(txtLoc_Code.Text))
                {
                    if (!dataManager.Exists("SIPLOCA", txtLoc_Code.Text,"LOC_CODE"))
                    {
                        MessageBox.Show("Data '" + txtLoc_Code.Text + "'  not found!", "Not Found", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        txtLoc_Code.SelectAll();
                        txtLoc_Code.Focus();
                        return;
                    }
                }
                
            }
            if (Condition.EmptyControl(txtLoc_Code))
            {
//                ========== check item Type Stock or Non-Stock
                var STR_IT_TYPE = items.ReturnField_Item_Type(txtItem_Code.Text);
                if (txtItem_Code.Text != "")
                {
                    if (STR_IT_TYPE.Trim() == "S")
                    {
                        STOCK_TYPE = "Y";
                    }
                }
            }
            var sipopurchaseorder_FRM = new SIPOPURCHASEORDER_FRM();
            if (SITempData.Is_Edit == false)
            {
                frmPurchaseOrder.dataGridView.Rows.Add(
                    string.Format("{0:000}", frmPurchaseOrder.dataGridView.Rows.Count + 1), txtLoc_Code.Text,
                    txtItem_Code.Text, txtItem_Desc.Text, txtUnitOfPurchase.Text, cboPType.Text.Substring(0, 1),
                    txtQTY.Text, txtStockQ.Text, txtCost.Text, txtSubTotal.Text, txtDisP.Text, txtDisAmt.Text,
                    txtTotal.Text, "A",dtpE.Value.ToShortDateString(),txtUnitofStock.Text);
               
                txtPhysical.Text = "0.00";
                txtOnOrder.Text = "0.00";
                txtStockQ.Text = "0";
                txtItem_Code.Enabled = true;
                txtItem_Code.BackColor = Color.White;
                btnItem_Code.Enabled = true;
                txtItem_Code.Focus();
                OK_Button.Enabled = false;
                frmPurchaseOrder.txtTotalA.Text = SIDataGridView.Sum(frmPurchaseOrder.dataGridView, 9).ToString();
                frmPurchaseOrder.txtDiscountA.Text = SIDataGridView.Sum(frmPurchaseOrder.dataGridView, 11).ToString();
                frmPurchaseOrder.MAKE_CHANGE = true;
            }
            else  // ==================== Edit Item
            {
                // Note: Not Yet Testing Here.......
                SIDataGridView.BindingData_ToGrid_OnSelected(frmPurchaseOrder.dataGridView, frmPurchaseOrder.dataGridView.SelectedRows[0].Cells[0].Value.ToString(),txtLoc_Code.Text,
                                                             txtItem_Code.Text, txtItem_Desc.Text,
                                                             txtUnitOfPurchase.Text, cboPType.Text.Substring(0,1),
                                                             txtQTY.Text,txtStockQ.Text,txtCost.Text,txtSubTotal.Text,txtDisP.Text,
                                                             txtDisAmt.Text,txtTotal.Text,"A",dtpE.Value.ToShortDateString(),txtUnitofStock.Text);
                frmPurchaseOrder.txtTotalA.Text = Convert.ToString(SIDataGridView.Sum(frmPurchaseOrder.dataGridView, 12));
                Close();
                SITempData.Is_Edit = false;
            }
            frmPurchaseOrder.txtVAT.Text = "0.00";
//            frmPurchaseOrder.txtVAT.Text =
//                        Convert.ToString(Convert.ToDecimal(frmPurchaseOrder.txtTotalA.Text) * 10 / 100);
//            frmPurchaseOrder.txtDiscountA.Text = txtDisAmt.Text;
            frmPurchaseOrder.txtGrandTotal.Text =
                Convert.ToString(Convert.ToDecimal(frmPurchaseOrder.txtTotalA.Text) - Convert.ToDecimal(frmPurchaseOrder.txtDiscountA.Text));//+
                                 //Convert.ToDecimal(frmPurchaseOrder.txtVAT.Text));
            controls.ClearControl(txtItem_Code, txtItem_Desc, txtLoc_Code, txtLoc_Desc, txtUnitOfPurchase, txtUnitofStock,
               txtQTY, txtCost, txtSubTotal, txtDisP, txtDisAmt, txtTotal);
           
        }

        private void OK_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                OK_Button.Enabled = false;
                txtDisAmt.Enabled = true;
                txtDisAmt.BackColor = Color.White;
                SelectNextControl(OK_Button, false, true, true,true);
            }

        }

        private void txtLoc_Desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(txtLoc_Desc, true, true, true, true);
            }
        }
    }
}
