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
using POS.Utilities;

namespace POS.GUI.Discount
{
    public partial class ADDSIPOSDISCOUNT : Form//DevComponents.DotNetBar.Office2007Form
    {
        public ADDSIPOSDISCOUNT()
        {
            InitializeComponent();
        }

        readonly DropDownList dropDownList = new DropDownList();
        Controls controls = new Controls();
        
        DataManager dataManager = new DataManager();

        private void ADDSIPOSDISCOUNT_Load(object sender, EventArgs e)
        {
        }

        private void btnProID_Click(object sender, EventArgs e)
        {
            try
            {
                var droplist_FRM = new DROPLIST_FRM();
                const Int16 i = 3;
                dropDownList.BindingData(
                    "SELECT ITEM_CODE [Code],ITEM_DESC [Description],UNIT_STOCK,UNIT_SALE FROM SIPITEMS WHERE ITEM_CODE>='" +
                    txtProID.Text + "' ORDER BY ITEM_CODE ASC", txtProID, this, droplist_FRM, btnProID, i,2, 3);
                if (droplist_FRM.ShowDialog() == DialogResult.OK)
                {
                    txtProID.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    txtProName.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[1].Value.ToString();
                    txtUnitofStock.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    txtUnitofSale.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[3].Value.ToString();
                    if (txtUnitofSale.Text == txtUnitofStock.Text)
                    {
                        var cond = new string[] { "ITEM_CODE", txtProID.Text };
                        txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE1 FROM SIPITEMS ", "ITEM_CODE", cond, 0);
                    }
                    else
                    {
                        var cond = new string[] { "ITEM_CODE", txtProID.Text };
                        txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE2 FROM SIPITEMS ", "ITEM_CODE", cond,
                                                                      0);
                    }
                    SelectNextControl(btnProID, true, true, true, true);
                }
                else
                {
                    txtProID.SelectAll();
                    txtProID.Focus();
                }
                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnUnitofSale_Click(object sender, EventArgs e)
        {
            try
            {
                var droplist_FRM = new DROPLIST_FRM();
                const Int16 i = 3;
                dropDownList.BindingData(
                    "SELECT CONV_FROM [Unit of Sale], CONV_TO [Unit of Stock] FROM dbo.SIUNITCONV WHERE CONV_FROM>='" + txtUnitofSale.Text +"' AND CONV_TO= '" + txtUnitofStock.Text + "' ORDER BY CONV_FROM",
                    txtUnitofSale, this, droplist_FRM, btnUnitofSale,i);
                if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtUnitofSale.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    if (txtUnitofSale.Text == txtUnitofStock.Text)
                    {
                        var cond = new string[] {"ITEM_CODE", txtProID.Text};
                        txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE1 FROM SIPITEMS", "ITEM_CODE",
                                                                      cond, 0);
                    }
                    else
                    {
                        var cond = new string[] { "ITEM_CODE", txtProID.Text };
                        txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE2 FROM SIPITEMS", "ITEM_CODE",
                                                                      cond, 0);
                    }
                    SelectNextControl(btnUnitofSale, true, true, true,true);
                }
                else
                {
                    txtUnitofSale.Focus();
                    txtUnitofSale.SelectAll();
                }
                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUnitofSale_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Condition.EmptyControl(txtUnitofSale))
                        txtUnitofSale.Focus();
                    else
                    {
                        var dt =
                            dataManager.GetData("SELECT CONV_FROM FROM SIUNITCONV WHERE CONV_TO = '" +
                                                txtUnitofStock.Text + "' AND UPPER(CONV_FROM) LIKE UPPER('" +
                                                txtUnitofSale.Text + "%')");

                        if (dt.Rows.Count > 0)
                        {
                            if (txtUnitofSale.Text == txtUnitofStock.Text)
                            {
                                var cond = new string[] { "ITEM_CODE", txtProID.Text };
                                txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE1 FROM SIPITEMS", "ITEM_CODE",
                                                                              cond, 0);
                            }
                            else
                            {
                                var cond = new string[] { "ITEM_CODE", txtProID.Text };
                                txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE2 FROM SIPITEMS", "ITEM_CODE",
                                                                              cond, 0);
                            }
                            txtUnitofSale.Text = dt.Rows[0][0].ToString();
                            SelectNextControl(btnUnitofSale, true, true, true, true);
                        }
                        else
                        {
                            MessageBox.Show("Data '" + txtUnitofSale + "' not found!", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            txtUnitofSale.SelectionStart = 0;
                            txtUnitofSale.SelectionLength = txtUnitofSale.ToString().Length;
                        }
                    }
               
                }
                else if(e.KeyCode == Keys.F6)
                {
                    btnUnitofSale_Click(sender,null);
                }
                else if (e.Control && e.KeyCode == Keys.B)
                {
                    txtProID.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpDateF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(dtpDateF))
                {
                    return;
                }
                SelectNextControl(dtpDateF, true, true, true, true);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtUnitofSale.Focus();
            }

        }

        private void dtpDateT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(dtpDateT))
                {
                    return;
                }
                SelectNextControl(dtpDateT, true, true, true, true);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                dtpDateF.Focus();
            }

        }

        private void cboTimeF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(cboTimeF))
                {
                    return;
                }
                SelectNextControl(cboTimeF, true, true, true, true);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                dtpDateT.Focus();
            }

        }

        private void cboStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(cboStatus))
                {
                    return;
                }
                SelectNextControl(cboStatus, true, true, true, true);

              //             If e.KeyCode = Keys.Enter Then
                //            If sender.name = "txtID" Or sender.name = "cboTimeF" Or sender.name = "cboTimeT" Then
                //                If CheckEmpty(sender) Then Exit Sub
                //            End If
                //            SelectNextControl(sender, True, True, True, True)
                //        End If
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtDiscount.Focus();
            }

        }

        private void cboTimeT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(cboTimeT))
                {
                    return;
                }
                SelectNextControl(cboTimeT, true, true, true, true);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                cboTimeF.Focus();
            }

        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(txtDiscount))
                {
                    return;
                }
                SelectNextControl(txtDiscount, true, true, true, true);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                cboTimeT.Focus();
            }

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtDiscount.Text == "")
                {
                    if (Condition.EmptyControl(txtDiscount)) return;
                }
                else
                {
                    if (Condition.Check_Decimal(txtDiscount))
                        return;
                    if (Convert.ToDecimal(txtDiscount.Text) > 100)
                    {
                        MessageBox.Show("Value must be less than or equal tto 100.", "", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        txtDiscount.SelectAll();
                        txtDiscount.Focus();
                        return;
                    }
                    SelectNextControl(txtDiscount, true, true, true, true);
                }
           
            }
            else
            {
                controls.Only_Number_On_Control_Except_Dot(txtDiscount);
            }
        }

        private void txtUnitofStock_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtUnitofStock.Text == "")
                    {
                        if (Condition.EmptyControl(txtUnitofStock))
                            return;
                    }
                    else
                    {
                        var dt =
                            dataManager.GetData(
                                "SELECT ITEM_CODE [Code],ITEM_DESC [Description],UNIT_STOCK,UNIT_SALE FROM SIPITEMS",
                                "ITEM_CODE", "ITEM_CODE", txtProID.Text);
                        if (dt.Rows.Count > 0)
                        {
                            txtUnitofStock.Text = dt.Rows[0][0].ToString();
                            txtProName.Text = dt.Rows[0][1].ToString();
                            txtUnitofStock.Text = dt.Rows[0][2].ToString();
                            txtUnitofSale.Text = dt.Rows[0][3].ToString();
                            if (txtUnitofStock.Text == txtUnitofSale.Text)
                            {
                                var condition = new string[] {"ITEM_CODE", txtProID.Text};
                                txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE1 FROM SIPITEMS",
                                                                              "ITEM_CODE", condition, 0);
                            }
                            else
                            {
                                var condition = new string[] { "ITEM_CODE", txtProID.Text };
                                txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE2 FROM SIPITEMS",
                                                                              "ITEM_CODE", condition, 0);
                            }
                            SelectNextControl(txtUnitofStock, true, true, true, true);
                        }
                        else
                        {
                            MessageBox.Show("Data '" + txtUnitofStock.Text + "' not found", "Not Found",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUnitofStock.SelectAll();
                            txtUnitofStock.Focus();
                        }
                    }
                }
                else if (e.KeyCode == Keys.F6)
                {
                   btnProID_Click(sender,e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }   
        }

        private void txtProID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProID.Text != "")
                {
                    var dt =
                        dataManager.GetData("SELECT ITEM_CODE,ITEM_DESC,UNIT_STOCK FROM SIPITEMS WHERE UPPER(ITEM_CODE) LIKE UPPER('" +
                                            txtProID.Text + "%') ORDER BY ITEM_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txtProID.Text = dt.Rows[0][0].ToString();
                        txtProName.Text = dt.Rows[0][1].ToString();
                        txtUnitofStock.Text = dt.Rows[0][2].ToString();
                        txtUnitofSale.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Item code '" + txtProID.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtProID.SelectionStart = 0;
                        txtProID.SelectionLength = txtProID.Text.Length;
                        return;
                    }
                }
            }
            else if(e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                const short i = 4;
                dropDownList.BindingData("SELECT ITEM_CODE,ITEM_DESC,UNIT_STOCK FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txtProID, this, droplistFrm, btnProID, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtProID.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtProName.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                    txtUnitofStock.Text =
                        droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[2].Value.ToString();

                }    
            }
            
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Condition.EmptyControl(txtProID,txtUnitofStock,txtUnitofSale,cboStatus))
            {
                return;
            }
            if (txtSellingPrice.Text == "")
                txtSellingPrice.Text = "0";
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
            }

            if (txtProID.Text != "")
            {
                if (dataManager.Exists("SIPITEMS", txtProID.Text, "ITEM_CODE") == false)
                {
                    MessageBox.Show("Data '" + txtProID.Text + "' not found!", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtProID.SelectAll();
                    txtProID.Focus();
                    return;
                }
                var condition = new[] {"ITEM_CODE", txtProID.Text};
                txtProName.Text = DataAccess.ReturnField("SELECT ITEM_DESC FROM SIPITEMS", "ITEM_CODE", condition, 0);
                txtUnitofStock.Text = DataAccess.ReturnField("SELECT UNIT_STOCK FROM SIPITEMS", "ITEM_CODE", condition,
                                                             0);
            }
            if (txtUnitofSale.Text != "")
            {
                if (dataManager.Exists("SIUNITCONV", txtUnitofSale.Text, "CONV_FROM", "CONV_TO", txtUnitofStock.Text) == false)
                {
                    MessageBox.Show("Data '" + txtUnitofSale.Text + "' not found!", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Question);
                    txtUnitofSale.SelectAll();
                    txtUnitofSale.Focus();
                    return;
                }
                if (txtUnitofSale.Text == txtUnitofStock.Text)
                {
                    var condition = new string[] {"ITEM_CODE", txtProID.Text};
                    txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE1 FROM SIPITEMS", "ITEM_CODE",
                                                                  condition, 0);
                }
                else
                {
                    var condition = new string[] { "ITEM_CODE", txtProID.Text };
                    txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE2 FROM SIPITEMS", "ITEM_CODE",
                                                                  condition, 0);
                }
            }
            if (dtpDateF.Checked == true && dtpDateT.Checked == true)
            {
                if (dtpDateF.Value > dtpDateT.Value)
                {
                    MessageBox.Show("Date From must be less than date To", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    dtpDateF.Focus();
                    return;
                }
            }
            if (cboTimeF.Text.Trim() != "" && cboTimeT.Text.Trim() != "")
            {
                if (Convert.ToInt32(cboTimeF.Text) > Convert.ToInt32(cboTimeT.Text))
                {
                    MessageBox.Show("Value must be less than or equal to 100.", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    cboTimeF.Focus();
                    return;
                }
            }
            if (Condition.Check_Decimal(txtDiscount))
                return;
            if (Convert.ToDecimal(txtDiscount.Text) > 100 )
            {
                MessageBox.Show("Value must be less than or equal to 100.", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtDiscount.SelectAll();
                txtDiscount.Focus();
                return;
            }
            
            txtProID.SelectAll();
            txtProID.Focus();
            DialogResult = DialogResult.OK;
        }

        private void OK_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                cboStatus.Focus();
            }

        }
    }
}
