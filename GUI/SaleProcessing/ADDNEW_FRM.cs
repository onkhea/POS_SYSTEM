using System;
using System.Drawing;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction;
using POS.Transaction.Sale;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.SaleProcessing
{
    public partial class ADDNEW_FRM : Form
    {
        SALEPROCESSING_FRM salOrder_FRM = new SALEPROCESSING_FRM();
        public ADDNEW_FRM(SALEPROCESSING_FRM saleprocessing_FRM)
        {
            InitializeComponent();
            salOrder_FRM = saleprocessing_FRM;
        }

        readonly DropDownList _dropDownList = new DropDownList();
        readonly Controls controls = new Controls();
        readonly SaleOrder saleOrder = new SaleOrder();
        DataManager dataManager = new DataManager();
        private string operate = "";
        private Decimal factor;
        public Decimal item_Price1 = 0;
        public Decimal item_Price2 = 0;
        private string item_Bcode = "";
        private string unit_Sale = "";
        private Decimal pro_Rate;
        Strings strings = new Strings(); 

        private void btnItemCode_Click(object sender, EventArgs e)
        {
            
            var droplist_FRM = new DROPLIST_FRM();
            Int16 i = 6;
            _dropDownList.BindingData(
                "SELECT ITEM_CODE,ITEM_DESC,ITEM_BCODE,ITEM_CUS9_KH,UNIT_STOCK,UNIT_SALE,ITEM_TYPE,ITEM_PRICE1,ITEM_PRICE2 FROM SIPITEMS WHERE ITEM_STAT='A' AND ITEM_TYPE= 'S'",
                txtItemCode, this, droplist_FRM, btnItemCode,i,2,3, 4, 5, 6, 7, 8);
            if (droplist_FRM.ShowDialog() == DialogResult.OK)
            {
                txtItemCode.Text =
                    droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                item_Bcode = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                txtItemDesc.Text =
                    droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[1].Value.ToString();
                txtUnitOfSale.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[5].Value.ToString();
                txtUnitOfStock.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[4].Value.ToString();
                unit_Sale = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[5].Value.ToString();
                item_Price1 = Convert.ToDecimal(droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[7].Value.ToString());
                item_Price2 =
                    Convert.ToDecimal(droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[8].Value.ToString());

                controls.Enabled_Control_False(txtItemCode, btnItemCode);
                controls.EnabledControlTrue(txtlocat, btnLocation);
                SelectNextControl(txtItemCode, true, true, true, true);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            var droplist_frm = new DROPLIST_FRM();
            Int16 i = 6;
            _dropDownList.BindingData(
                "SELECT LOC_CODE [Location Code],LOC_NAME [Location Name] FROM SIPLOCA WHERE LOC_STAT = 'A' AND LOC_CODE LIKE '%" +
                txtlocat.Text + "'", txtlocat, this, droplist_frm, btnLocation,i);
            if (droplist_frm.ShowDialog() == DialogResult.OK)
            {
                txtlocat.Text = droplist_frm.DataGridView.Rows[droplist_frm.SelectIndex].Cells[0].Value.ToString();
                var physical = saleOrder.GetItem("", txtlocat.Text, txtItemCode.Text);
                var onOrder = saleOrder.GetItem("O", txtlocat.Text, txtItemCode.Text);
                var free = physical - onOrder;

                txtPhysical.Text = physical.ToString();
                txtOnOrder.Text = onOrder.ToString();
                txtFree.Text = free.ToString();

                controls.Enabled_Control_False(txtlocat, btnLocation);
                controls.EnabledControlTrue(txtEmployee, btnEmployee);
                txtEmployee.Focus();
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            var droplist_frm = new DROPLIST_FRM();
            Int16 i = 6;
            _dropDownList.BindingData(
                "SELECT  SI_CODE, RTRIM(SUBSTRING(SI_DATA, 1, 20)) [SI_NAME] FROM SIPDATA WHERE SI_TYPE = 'EMP' AND SI_LOOKUP ='A'",
                txtEmployee, this, droplist_frm, btnEmployee,i);
            if (droplist_frm.ShowDialog() == DialogResult.OK)
            {
                txtEmployee.Text = droplist_frm.DataGridView.Rows[droplist_frm.SelectIndex].Cells[0].Value.ToString();
                txtEmpName.Text = droplist_frm.DataGridView.Rows[droplist_frm.SelectIndex].Cells[1].Value.ToString();
                controls.Enabled_Control_False(txtEmployee, btnEmployee);
                controls.EnabledControlTrue(cboSaleType);
                SelectNextControl(btnEmployee, true, true, true, true);
                cboSaleType.Focus();
            }

        }

        private void ADDNEW_FRM_Load(object sender, EventArgs e)
        {
            if (txtlocat.Text == "")
            {
                txtlocat.Text = UserLogOn.Location;
            }
            controls.Only_Number_On_Control(txtQuantity,txtDiscP);
            //      controls.AddEventHandler(txtItemDesc,txtItemCode,txtLocation,txtEmployee,txtLineNo,txtEmployee,txtQuantity,txtPrice,txtDiscP,txtDiscUSD);
        }

        private void btnUnitOfSale_Click(object sender, EventArgs e)
        {
            var droplist_FRM = new DROPLIST_FRM();
            Int16 I = 6;
            _dropDownList.BindingData(
                "SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV WHERE CONV_FROM >= '" +
                txtUnitOfSale.Text + "' AND CONV_TO ='" + txtUnitOfStock.Text + "'", txtUnitOfSale, this, droplist_FRM,
                btnUnitOfSale,I, 2, 3, 4);
            if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtUnitOfSale.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                operate = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                factor =
                    Convert.ToDecimal(droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[3].Value.ToString());
                controls.Enabled_Control_False(txtUnitOfSale, btnUnitOfSale);
                controls.EnabledControlTrue(txtQuantity);
                txtQuantity.Focus();
            }
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var str = new string[] { "ITEM_STAT", "A", "ITEM_TYPE", "S", "ITEM_CODE", txtItemCode.Text };
                
                if (!dataManager.Exists("SIPITEMS",str))
                {
                    MessageBox.Show("Item code '" + txtItemCode.Text + "' not found.", "Not Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtItemCode.SelectionStart = 0;
                    txtItemCode.SelectionLength = txtItemCode.Text.Length;
                    txtItemCode.Focus();
                    return;
                }
                
                txtItemCode.Text =
                    DataAccess.ReturnField(
                        "SELECT ITEM_CODE [Item Code], ITEM_DESC [Description],UNIT_STOCK,ITEM_COST1,UNIT_SALE,ITEM_COST2 FROM SIPITEMS ",
                        "ITEM_CODE", str, 0);
                item_Bcode = DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_BCODE", str, 0);
                txtItemDesc.Text = DataAccess.ReturnField(
                        "SELECT ITEM_CODE [Item Code], ITEM_DESC [Description],UNIT_STOCK,ITEM_COST1,UNIT_SALE,ITEM_COST2 FROM SIPITEMS ",
                        "ITEM_CODE", str, 1);
                txtUnitOfSale.Text = DataAccess.ReturnField(
                        "SELECT ITEM_CODE [Item Code], ITEM_DESC [Description],UNIT_STOCK,ITEM_COST1,UNIT_SALE,ITEM_COST2 FROM SIPITEMS ",
                        "ITEM_CODE", str, 4);
                txtUnitOfStock.Text = DataAccess.ReturnField(
                        "SELECT ITEM_CODE [Item Code], ITEM_DESC [Description],UNIT_STOCK,ITEM_COST1,UNIT_SALE,ITEM_COST2 FROM SIPITEMS ",
                        "ITEM_CODE", str, 2);
                item_Price1 = Convert.ToDecimal(DataAccess.ReturnField("SELECT ITEM_PRICE1 FROM SIPITEMS","ITEM_CODE",str,0));
                item_Price2 =
                    Convert.ToDecimal(DataAccess.ReturnField("SELECT ITEM_PRICE2 FROM SIPITEMS", "ITEM_CODE", str, 0));
                if (string.IsNullOrEmpty(txtItemCode.Text))
                {
                    MessageBox.Show("No Item Code");
                    txtItemCode.Focus();
                    return;
                }
                controls.Enabled_Control_False(txtItemCode, btnItemCode);
                controls.EnabledControlTrue(txtlocat,btnLocation);
                txtlocat.Focus();
//                SelectNextControl(txtItemCode, true, true, true, true);

            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplist_FRM = new DROPLIST_FRM();
                Int16 i = 6;
                _dropDownList.BindingData(
                    "SELECT ITEM_CODE,ITEM_DESC,ITEM_BCODE,ITEM_CUS9_KH,UNIT_STOCK,UNIT_SALE,ITEM_TYPE,ITEM_PRICE1,ITEM_PRICE2 FROM SIPITEMS WHERE ITEM_STAT='A' AND ITEM_TYPE= 'S'",
                    txtItemCode, this, droplist_FRM, btnItemCode,i, 2, 3, 4, 5, 6, 7, 8);
                if (droplist_FRM.ShowDialog() == DialogResult.OK)
                {
                    txtItemCode.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    item_Bcode = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    txtItemDesc.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[1].Value.ToString();
                    txtUnitOfSale.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[5].Value.ToString();
                    txtUnitOfStock.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[4].Value.ToString();
                    unit_Sale = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[5].Value.ToString();
                    item_Price1 = Convert.ToDecimal(droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[7].Value.ToString());
                    item_Price2 =
                        Convert.ToDecimal(droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[8].Value.ToString());

                    controls.Enabled_Control_False(txtItemCode, btnItemCode);
                    controls.EnabledControlTrue(txtlocat, btnLocation);
                    txtlocat.Focus();
                }       
            }
            
         
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (salOrder_FRM.IS_EDIT == false)
            {
                
                
                
                if (Condition.EmptyControl(txtItemCode,txtlocat,txtEmployee,txtUnitOfSale,txtUnitOfStock,txtQuantity,txtPrice,cboSaleType))
                {
                    MessageBox.Show("Please, input data into the blank.", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                txtLineNo.Text = string.Format("{0:0000}", salOrder_FRM.dataGridViewX1.Rows.Count + 1);

                var i = SIDataGridView.CheckOnGrid(salOrder_FRM.dataGridViewX1, txtItemCode.Text, 2, txtUnitOfSale.Text,
                                                   4, cboSaleType.Text.Substring(0, 1), 11);
                if (i == -1)
                {
                    salOrder_FRM.dataGridViewX1.Rows.Add(
                        string.Format("{0:0000}", salOrder_FRM.dataGridViewX1.Rows.Count + 1),
                        txtlocat.Text,
                        txtItemCode.Text,
                        txtItemDesc.Text + " - " + txtUnitOfSale.Text,
                        txtUnitOfSale.Text, txtQuantity.Text,
                        txtStockQty.Text,
                        txtPrice.Text, txtAmount.Text,
                        txtDiscountTotal.Text,
                        txtGrandTotal.Text,
                        cboSaleType.Text.Substring(0, 1),
                        txtDiscP.Text, txtItemDesc.Text,
                        txtUnitOfSale.Text, txtEmployee.Text);
                }
                else
                {
                    salOrder_FRM.dataGridViewX1.Rows[i].Cells[5].Value = string.Format("{0:00.00}",
                                                                                       Convert.ToDecimal(
                                                                                           salOrder_FRM.dataGridViewX1.
                                                                                               Rows[i].Cells[5].Value) +
                                                                                       Convert.ToDecimal(
                                                                                           txtQuantity.Text));
                    salOrder_FRM.dataGridViewX1.Rows[i].Cells[6].Value = string.Format("{0:00.00}",
                                                                                       Convert.ToDecimal(
                                                                                           salOrder_FRM.dataGridViewX1.
                                                                                               Rows[i].Cells[6].Value) +
                                                                                       Convert.ToDecimal(
                                                                                           txtStockQty.Text));
                    salOrder_FRM.dataGridViewX1.Rows[i].Cells[8].Value = string.Format("{0:0,0.00}",
                                                                                       Convert.ToDecimal(
                                                                                           salOrder_FRM.dataGridViewX1.
                                                                                               Rows[i].Cells[8].Value) +
                                                                                       Convert.ToDecimal(txtAmount.Text));
                    salOrder_FRM.dataGridViewX1.Rows[i].Cells[9].Value = string.Format("{0:0,0.00}",
                                                                                       Convert.ToDecimal(
                                                                                           salOrder_FRM.dataGridViewX1.
                                                                                               Rows[i].Cells[9].Value) +
                                                                                       Convert.ToDecimal(
                                                                                           txtDiscountTotal.Text));
                    salOrder_FRM.dataGridViewX1.Rows[i].Cells[10].Value = string.Format("{0:0,0.00}",
                                                                                        Convert.ToDecimal(
                                                                                            salOrder_FRM.dataGridViewX1.
                                                                                                Rows[i].Cells[10].Value) +
                                                                                        Convert.ToDecimal(
                                                                                            txtGrandTotal.Text));
                }
                salOrder_FRM.txtInvoiceValue.Text = string.Format("{0:0,0.00}",
                                                                  SIDataGridView.Sum(salOrder_FRM.dataGridViewX1, 8));
                salOrder_FRM.txtTotalQty.Text = string.Format("{0:0,0.00}",
                                                              SIDataGridView.Sum(salOrder_FRM.dataGridViewX1, 5));
                salOrder_FRM.txtItemDisc.Text = string.Format("{0:0,0.00}",
                                                              SIDataGridView.Sum(salOrder_FRM.dataGridViewX1, 9));
                var grandTotal = Convert.ToDecimal(salOrder_FRM.txtInvoiceValue.Text) -
                                 Convert.ToDecimal(salOrder_FRM.txtItemDisc.Text) -
                                 Convert.ToDecimal(salOrder_FRM.txtInvoiceDisc.Text) +
                                 Convert.ToDecimal(salOrder_FRM.txtTotalVAT.Text);
                salOrder_FRM.txtGrandTotal.Text = string.Format("{0:0,0.00}", grandTotal);
                controls.ClearControl(txtItemCode, txtItemDesc, txtUnitOfStock, txtUnitOfSale, txtStockQty,
                                      txtUnitOfSale, txtAmount, txtGrandTotal, txtPrice, txtPhysical, txtOnOrder,
                                      txtFree,cboSaleType,txtDiscUSD,txtDiscP,txtDiscountTotal,txtQuantity);
                txtLineNo.Text = string.Format("{0:0000}", salOrder_FRM.dataGridViewX1.Rows.Count + 1);
                controls.EnabledControlTrue(txtItemCode,btnItemCode);
                txtItemCode.Focus();
              
            }
            else
            {
                if (Condition.EmptyControl(txtItemCode, txtlocat, txtEmployee, txtUnitOfSale, txtUnitOfStock, txtQuantity, txtPrice))
                {
                    MessageBox.Show("Please, input data into the blank.", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                var textBox = new TextBox();
                textBox.Text = txtItemDesc.Text + " - " + txtUnitOfStock.Text;
                SIDataGridView.BindingData_ToGrid_OnSelected(salOrder_FRM.dataGridViewX1, txtLineNo.Text, txtlocat.Text,
                                                                     txtItemCode.Text, textBox.Text, txtUnitOfStock.Text, txtQuantity.Text,
                                                                     txtStockQty.Text, txtPrice.Text, txtAmount.Text, txtDiscountTotal.Text,
                                                                     txtGrandTotal.Text, cboSaleType.Text, txtDiscP.Text, txtItemDesc.Text,
                                                                     txtUnitOfSale.Text, txtEmployee.Text);
                salOrder_FRM.txtInvoiceValue.Text = string.Format("{0:0,0.00}",
                                                                  SIDataGridView.Sum(salOrder_FRM.dataGridViewX1, 8));
                salOrder_FRM.txtTotalQty.Text = string.Format("{0:0,0.00}",
                                                              SIDataGridView.Sum(salOrder_FRM.dataGridViewX1, 5));
                salOrder_FRM.txtItemDisc.Text = string.Format("{0:0,0.00}",
                                                              SIDataGridView.Sum(salOrder_FRM.dataGridViewX1, 9));
                salOrder_FRM.txtGrandTotal.Text = string.Format("{0:0,0.00}",
                                                                Convert.ToDecimal(salOrder_FRM.txtInvoiceValue.Text) -
                                                                Convert.ToDecimal(salOrder_FRM.txtItemDisc.Text) -
                                                                Convert.ToDecimal(salOrder_FRM.txtInvoiceDisc.Text) +
                                                                Convert.ToDecimal(salOrder_FRM.txtTotalVAT.Text));
                salOrder_FRM.IS_EDIT = false;
                Close();

                
            }
        }

        private void txtLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var condition = new string[] { "LOC_STAT", "A", "LOC_CODE", txtlocat.Text };
                txtlocat.Text =
                    DataAccess.ReturnField("SELECT LOC_CODE [Location Code],LOC_NAME [Location Name] FROM SIPLOCA ",
                                           "LOC_CODE", condition, 0);
                if (string.IsNullOrEmpty(txtlocat.Text))
                {
                    txtlocat.Focus();
                    return;
                }
                controls.Enabled_Control_False(txtlocat, btnLocation);
                controls.EnabledControlTrue(txtEmployee, btnEmployee);
                SelectNextControl(txtlocat, true, true, true, true);
            }
        }

        private void cboSaleType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete || e.KeyCode != Keys.Back)
            {
//                var str = cboSaleType.GetItemText(cboSaleType.Items[cboSaleType.FindString(cboSaleType.Text)].ToString());
//                controls.ClearControl(cboSaleType);
//                cboSaleType.Text = str;
                if (e.KeyCode == Keys.Enter)
                {
                    if (string.IsNullOrEmpty(cboSaleType.Text))
                    {                                                                                              
                        return;
                    }
                    if (cboSaleType.Text == "Sale")
                    {
                        controls.EnabledControlTrue(txtUnitOfSale, btnUnitOfSale);
                        controls.Enabled_Control_False(cboSaleType);
                        SelectNextControl(cboSaleType, true, true, true, true);
                    }
                    else if (cboSaleType.Text == "Free")
                    {
                        controls.EnabledControlTrue(txtUnitOfSale, btnUnitOfSale);
                        controls.Enabled_Control_False(cboSaleType);
                        SelectNextControl(cboSaleType, true, true, true, true);                        
                    }
                    else if (cboSaleType.Text == "Coupon")
                    {
                        controls.EnabledControlTrue(txtUnitOfSale, btnUnitOfSale);
                        controls.Enabled_Control_False(cboSaleType);
                        SelectNextControl(cboSaleType, true, true, true, true);                        
                    }
                    else if(cboSaleType.Text == "Owner Used")
                    {
                        controls.EnabledControlTrue(txtUnitOfSale, btnUnitOfSale);
                        controls.Enabled_Control_False(cboSaleType);
                        SelectNextControl(cboSaleType, true, true, true, true);
                    }
                    
                   
                }
                else if (e.Control && e.KeyCode == Keys.B)
                {
                    cboSaleType.Enabled = false;
                    txtEmployee.Enabled = true;
                    btnEmployee.Enabled = true;
                    txtEmployee.Focus();
                }
            }
            
        }

        private void txtUnitOfSale_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(txtUnitOfSale.Text))
                    {
                        if (!dataManager.Exists("SIUNITCONV",txtUnitOfSale.Text,"CONV_FROM"))
                        {
                            MessageBox.Show("Unit of Sale '" + txtUnitOfSale.Text + "' not found.","Not Found", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            txtUnitOfSale.SelectionStart = 0;
                            txtUnitOfSale.SelectionLength = txtUnitOfSale.Text.Length;
                            txtUnitOfSale.Focus();
                            return;
                        }
                        else
                        {
                            var cond = new string[] {"CONV_TO",txtUnitOfStock.Text};
                            txtUnitOfSale.Text = DataAccess.ReturnField("SELECT CONV_FROM FROM SIUNITCONV", "CONV_FROM",
                                                                        cond, 0);
                        }
                        var condition = new string[] { "CONV_FROM", txtUnitOfSale.Text, "CONV_TO", txtUnitOfStock.Text };
                        operate =
                            DataAccess.ReturnField(
                                "SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV ",
                                "CONV_FROM", condition, 2);
                        factor = Convert.ToDecimal(DataAccess.ReturnField(
                                                       "SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV ",
                                                       "CONV_FROM", condition, 3));
                        if (string.IsNullOrEmpty(operate))
                        {
                            txtUnitOfSale.SelectionStart = 0;
                            txtUnitOfSale.SelectionLength = txtUnitOfSale.Text.Length;
                            txtUnitOfSale.Focus();
                            return;
                        }
                        controls.Enabled_Control_False(txtUnitOfSale, btnUnitOfSale);
                        controls.EnabledControlTrue(txtQuantity);
                        SelectNextControl(txtUnitOfSale, false, true, true, true);
                        txtQuantity.Focus();
                    }
                }
                else if(e.KeyCode ==Keys.F6)
                {
                    btnUnitOfSale_Click(null,null);
                }
                else if(e.KeyCode == Keys.B && e.Control)
                {
                    cboSaleType.Enabled = true;
                    txtUnitOfSale.Enabled = false;
                    btnUnitOfSale.Enabled = false;
                    cboSaleType.Focus();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    MessageBox.Show("Please, Input number into textbox exception 0", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtQuantity.SelectionStart = 0;
                    txtQuantity.SelectionLength = txtQuantity.Text.Length;
                    txtQuantity.Focus();
                    return;
                }
                if (txtFree.Text == "")
                {
                    txtFree.Text = "0";
                }
                var value = Convert.ToDecimal(txtFree.Text) -
                Convert.ToDecimal(txtQuantity.Text);
                if (value < 0)
                {
                    MessageBox.Show("Not enough stock quantity.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
//                =============  unit of stock ======
                
                if (operate == "*")
                {
                    txtStockQty.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(txtQuantity.Text)*factor);
                }
                else
                {
                    txtStockQty.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(txtQuantity.Text) / factor);                    
                }


                txtUnitOfSale.Text = txtUnitOfSale.Text;

                #region Get Price
                // select price for sale
                var dataManager = new DataManager();

                var dtPrice = dataManager.GetData("SELECT PRO_RATE FROM SIPOSPRICE", "ITEM_CODE", "ITEM_CODE",
                                                  txtItemCode.Text, "UNIT_SALE", txtUnitOfSale.Text, "PRO_TYPE",
                                                  "P");
                if (dtPrice.Rows.Count > 0)
                {
                    txtPrice.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(dtPrice.Rows[0][0]));
                }
                else
                {
                    if (txtUnitOfSale.Text == txtUnitOfStock.Text)
                    {
                        txtPrice.Text = string.Format("{0:0,0.00}", item_Price1);
                    }
                    else if (txtUnitOfSale.Text == txtUnitOfSale.Text)
                    {
                        txtPrice.Text = string.Format("{0:0,0.00}", item_Price2);
                    }
                    else
                    {
                        MessageBox.Show("There are no selling price on this unit of sale!");
                        txtUnitOfSale.Focus();
                        txtUnitOfSale.SelectAll();
                        return;
                    }
                } // end else if (dtPrice.rows.count > 0)
                // select discount for sale
                var dtDiscount =
                    dataManager.GetData(
                        "SELECT PRO_RATE,PRO_FDATE,PRO_TDATE,PRO_TIMES,PRO_TIMEE FROM SIPOSPRICE", "ITEM_BCODE",
                        "ITEM_BCODE", item_Bcode, "LOCATION", txtlocat.Text, "UNIT_SALE",
                        txtUnitOfSale.Text,
                        "PRO_TYPE", "D", "STATUS", "A");
                if (dtDiscount.Rows.Count > 0)
                {
                    var strings = new Strings();
                    if (strings.IsDateTime(dtDiscount.Rows[0][1].ToString()) &&
                        strings.IsDateTime(dtDiscount.Rows[0][2].ToString()))
                    {
                        if (
                            Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day,
                                                                       Convert.ToDateTime(
                                                                           dtDiscount.Rows[0][1].ToString()),
                                                                       DateTime.Now,
                                                                       Microsoft.VisualBasic.FirstDayOfWeek.System,
                                                                       Microsoft.VisualBasic.FirstWeekOfYear.System) >=
                            0 && Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day,
                                                                       Convert.ToDateTime(
                                                                           dtDiscount.Rows[0][2].ToString()),
                                                                       DateTime.Now,
                                                                       Microsoft.VisualBasic.FirstDayOfWeek.System,
                                                                       Microsoft.VisualBasic.FirstWeekOfYear.System) <= 0)
                        {

                             
                            pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                                Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                            {
                                var ddsdsfds = DateTime.Now.Hour;
                                if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                                    DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                                {
                                    pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                                }
                                // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                                else
                                {
                                    pro_Rate = 0;
                                }
                                // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....

                        } // end if ( DataDiff..........)
                        else
                        {
                            pro_Rate = 0;
                        }
                    }
                    else
                    {
                        if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                                        Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                        {
                            if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                                DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                            {
                                pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            }
                            // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            else
                            {
                                pro_Rate = 0;
                            }
                            // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                        } // end if (convert.todouble(double.row[0][3].tostring())
                    }
                }
                #endregion

                if (Convert.ToDecimal(txtFree.Text) <= 0 && Convert.ToDecimal(txtFree.Text) - Convert.ToDecimal(txtQuantity.Text) < 0)
                {
                    MessageBox.Show("Not Enough stock quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFree.Text = txtPhysical.Text;
                    txtQuantity.SelectionStart = txtQuantity.Text.Length;
                    txtQuantity.Focus();
                    return;
                }
                
                if (txtQuantity.Text.Trim() != "")
                {
                    if (strings.IsNumeric(txtQuantity.Text))
                    {
                        var Qty = Convert.ToDecimal(txtQuantity.Text);
                        if (strings.IsDecimal(txtPrice.Text))
                        {
                            var price = Convert.ToDecimal(txtPrice.Text);
                            var Amount = Qty * price;
                            txtAmount.Text = string.Format("{0:0,0.00}", Amount);
                            txtDiscountTotal.Text = string.Format("{0:0,0.00}", Amount * (pro_Rate / 100));
                            txtGrandTotal.Text = string.Format("{0:0,0.00}",Convert.ToDecimal(txtAmount.Text) - Convert.ToDecimal(txtDiscountTotal.Text));
                        }
                    }
                    else
                    {
                        txtQuantity.Text = txtQuantity.Text.Substring(0, txtQuantity.Text.Length - 1);
                        txtQuantity.SelectionStart = txtQuantity.Text.Length;

                    }
                }
                controls.Enabled_Control_False(txtQuantity);
                controls.EnabledControlTrue(txtDiscP);
                SelectNextControl(txtQuantity, false, true, true, true);
                txtDiscP.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtUnitOfSale.Enabled = true;
                btnUnitOfSale.Enabled = true;
                txtQuantity.Enabled = false;
                txtUnitOfSale.Focus();
            }
//            else
//            {
//                txtQuantity.SelectionStart = 0;
//                txtQuantity.SelectionLength = txtQuantity.ToString().Length;
//            }
        }



        private void txtDiscP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtDiscP.Text))
                {
                    txtDiscP.Text = "0";
                }
                txtDiscUSD.Text = string.Format("{0:0,0.00}",
                                                Convert.ToDecimal(txtGrandTotal.Text)*Convert.ToDecimal(txtDiscP.Text)/100);
                txtGrandTotal.Text = string.Format("{0:0,0.00}",
                                                   Convert.ToDecimal(txtGrandTotal.Text) -
                                                   Convert.ToDecimal(txtDiscUSD.Text));
                txtDiscountTotal.Text = string.Format("{0:0,0.00}",
                                                      Convert.ToDecimal(txtDiscountTotal.Text) +
                                                      Convert.ToDecimal(txtDiscUSD.Text));
                controls.Enabled_Control_False(txtDiscP);
                controls.EnabledControlTrue(btnOK);
                SelectNextControl(txtDiscP, false, true, true, true);
                btnOK.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtQuantity.Enabled = true;
                txtDiscP.Enabled = false;
                txtQuantity.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            controls.ClearControl(txtItemCode, txtItemDesc, txtlocat, txtUnitOfSale, txtUnitOfStock, txtPhysical,
                                  txtPrice, txtQuantity, txtOnOrder, txtGrandTotal, txtDiscUSD, txtDiscP,txtStockQty,txtAmount);
            controls.Enabled_Control_False(txtQuantity, txtUnitOfStock, txtUnitOfSale, txtDiscP, txtUnitOfStock,
                                           txtlocat, cboSaleType, txtEmployee);
            controls.EnabledControlTrue(txtItemCode, btnItemCode);
            txtItemCode.Focus();
        }

        private void txtEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtEmployee.Text))
                {
                    var condition = new string[] { "SI_TYPE", "EMP", "SI_LOOKUP", "A", "SI_CODE", txtEmployee.Text };
                    txtEmployee.Text = DataAccess.ReturnField(
                            "SELECT  SI_CODE, RTRIM(SUBSTRING(SI_DATA, 1, 20)) [SI_NAME] FROM SIPDATA", "SI_CODE",
                            condition, 0);
                    txtEmpName.Text =
                        DataAccess.ReturnField(
                            "SELECT  SI_CODE, RTRIM(SUBSTRING(SI_DATA, 1, 20)) [SI_NAME] FROM SIPDATA", "SI_CODE",
                            condition, 1);

                    if (string.IsNullOrEmpty(txtEmployee.Text))
                    {
                        txtEmployee.Focus();
                        txtEmployee.ForeColor = Color.Red;
                        return;
                    }
                    controls.Enabled_Control_False(txtEmployee, btnEmployee);
                    controls.EnabledControlTrue(cboSaleType);
                    cboSaleType.Focus();
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnEmployee_Click(null,null);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtEmployee.Enabled = false;
                btnEmployee.Enabled = false;
                txtlocat.Enabled = true;
                btnLocation.Enabled = true;
                txtlocat.Focus();
                    
            }
        }

        private void txtlocat_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtlocat.Text != "")
                {
                    var dt =
                        dataManager.GetData(
                            "SELECT LOC_CODE [Location Code],LOC_NAME [Location Name] FROM SIPLOCA WHERE LOC_STAT = 'A' AND UPPER(LOC_CODE) LIKE UPPER('" +
                            txtlocat.Text + "%')");
                    if (dt.Rows.Count > 0)
                    {
                        txtlocat.Text = dt.Rows[0][0].ToString();
                        var physical = saleOrder.GetItem("", txtlocat.Text, txtItemCode.Text);
                        var onOrder = saleOrder.GetItem("O", txtlocat.Text, txtItemCode.Text);
                        var free = physical - onOrder;

                        txtPhysical.Text = physical.ToString();
                        txtOnOrder.Text = onOrder.ToString();
                        txtFree.Text = free.ToString();
                        txtlocat.Enabled = false;
                        btnLocation.Enabled = false;
                        txtEmployee.Enabled = true;
                        btnEmployee.Enabled = true;
                        txtEmployee.Focus();
                        
                    }
                    
                        
                }
                
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnLocation_Click(null, null);
            }
            else if(e.KeyCode == Keys.B && e.Control)
            {
                txtItemCode.Enabled = true;
                btnItemCode.Enabled = true;
                txtlocat.Enabled = false;
                btnLocation.Enabled = false;
                txtItemCode.Focus();
            }

        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtDiscP.Enabled = true;
                btnOK.Enabled = false;
                txtDiscP.Focus();
                    
            }
        }
    }
}

