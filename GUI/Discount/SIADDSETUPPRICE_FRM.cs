using System;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction;
using POS.Utilities;

namespace POS.GUI.Discount
{
    public partial class SIADDSETUPPRICE_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public SIADDSETUPPRICE_FRM()
        {
            InitializeComponent();
        }

        readonly Controls _controls = new Controls();
        DataManager dataManager = new DataManager();

        private void SIADDSETUPPRICE_FRM_Load(object sender, EventArgs e)
        {
//            _controls.AddEventHandler(txtProID,txtSellingPrice,txtUnitofSale,txtUnitofStock,cboStatus);
        }

        private void btnProID_Click(object sender, EventArgs e)
        {
            var dropDownList = new DropDownList();
            var droplistFrm = new DROPLIST_FRM();
            const Int16 i = 3;
//            txtProID.Text = "TIGER";
            dropDownList.BindingData(
                "SELECT ITEM_CODE [Item Code],ITEM_DESC [Description],UNIT_STOCK,UNIT_SALE FROM SIPITEMS WHERE ITEM_CODE Like '" +
                txtProID.Text + "%' AND ITEM_STAT='A'", txtProID, this, droplistFrm,btnProID,i,2, 3);
            if (droplistFrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtProID.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtProName.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtUnitofStock.Text =
                    droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[2].Value.ToString();
                txtUnitofSale.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[3].Value.ToString();
                SelectNextControl(btnProID, true, true, true, true);
//                
            }
        }

        private void btnUnitofSale_Click(object sender, EventArgs e)
        {
            var dropDownList = new DropDownList();
            var droplist_FRM = new DROPLIST_FRM();
            const Int16 i = 3;
            dropDownList.BindingData("SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description] FROM dbo.SIUNITCONV  WHERE CONV_TO = '" +txtUnitofStock.Text + "'",txtUnitofSale,this,droplist_FRM,btnUnitofSale,i);
            if (droplist_FRM.ShowDialog() == DialogResult.OK)
            {
                txtUnitofSale.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
            }
            else
            {
                txtUnitofSale.Focus();
                txtUnitofSale.SelectAll();
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Condition.EmptyControl(txtProID, txtUnitofStock, txtUnitofSale, txtSellingPrice, cboStatus))
                return;
            if (txtProID.Text != "")
            {
//                if (DataManager.Exists("SIPITEMS", txtProID.Text, "ITEM_CODE"))
//                {
//                    MessageBox.Show("Data '" + txtProID.Text + "' not found!", "Not Found", MessageBoxButtons.OK,
//                                    MessageBoxIcon.Exclamation);
//                    txtProID.SelectAll();
//                    txtProID.Focus();
//                    return;
//                }
                var condition = new string[] {"ITEM_CODE",txtProID.Text};
                txtProName.Text = DataAccess.ReturnField("SELECT ITEM_DESC FROM SIPITEMS", "ITEM_CODE", condition,0);
                txtUnitofStock.Text = DataAccess.ReturnField("SELECT UNIT_STOCK FROM SIPITEMS", "ITEM_CODE", condition,
                                                             0);
            }
            if(txtUnitofSale.Text != "")
            {
//                if (DataManager.Exists("SIUNITCONV", txtUnitofSale.Text, "CONV_FROM", "CONV_TO",txtUnitofStock.Text))
//                {
//                    MessageBox.Show("Data '" + txtUnitofSale.Text + "' not found!", "Not Found", MessageBoxButtons.OK,
//                                    MessageBoxIcon.Exclamation);
//                    txtUnitofSale.SelectAll();
//                    txtUnitofSale.Focus();
//                    return;
//                }
            }
            if (Condition.Check_Decimal(txtSellingPrice))
            {
                if ( Convert.ToDecimal(txtSellingPrice.Text) > 9999999)
                {
                    MessageBox.Show("Value must be less than " + "9,999,999", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtSellingPrice.SelectAll();
                    txtSellingPrice.Focus();
                    return;
                }
            }
            txtProID.SelectAll();
            txtProID.Focus();
            DialogResult = DialogResult.OK;
        }

        private void txtProID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                if (txtProID.Text != "")
                {
                    var dt =
                        dataManager.GetData(
                            "SELECT ITEM_CODE [Item Code],ITEM_DESC [Description],UNIT_STOCK,UNIT_SALE FROM SIPITEMS WHERE UPPER(ITEM_CODE) Like UPPER('" +
                            txtProID.Text + "%') AND ITEM_STAT='A'");
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
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtProID.SelectionStart = 0;
                        txtProID.SelectionLength = txtProID.Text.Length;
                        txtProID.Focus();

                    }
                }    
            }
            else if (e.KeyCode == Keys.F6)
            {
                var dropDownList = new DropDownList();
                var droplistFrm = new DROPLIST_FRM();
                const Int16 i = 3;
                
                dropDownList.BindingData(
                    "SELECT ITEM_CODE [Item Code],ITEM_DESC [Description],UNIT_STOCK,UNIT_SALE FROM SIPITEMS WHERE ITEM_CODE Like '" +
                    txtProID.Text + "%' AND ITEM_STAT='A'", txtProID, this, droplistFrm, btnProID, i,2, 3);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtProID.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtProName.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                    txtUnitofStock.Text =
                        droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[2].Value.ToString();
                    txtUnitofSale.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[3].Value.ToString();
                    SelectNextControl(btnProID, true, true, true, true);
                                   
                }
            }
           
        }

        private void txtUnitofSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtUnitofSale.Text))
                {
                    var dt =
                        dataManager.GetData(
                            "SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description] FROM dbo.SIUNITCONV WHERE UPPER(CONV_FROM) LIKE UPPER('" +
                            txtUnitofSale.Text + "%') AND CONV_TO ='" + txtUnitofStock.Text + "'");
                    if (dt.Rows.Count > 0)
                    {
                        txtUnitofSale.Text = dt.Rows[0][0].ToString();
                        txtSellingPrice.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Unit of Sale '" + txtUnitofSale.Text + "Not Found", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUnitofSale.SelectionStart = 0;
                        txtUnitofSale.SelectionLength = txtUnitofSale.Text.Length;
                        txtUnitofSale.Focus();
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnUnitofSale_Click(null,null);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtProID.Focus();
            }

        }

        private void txtSellingPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboStatus.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtUnitofSale.Focus();
            }

        }

        private void cboStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OK_Button.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtSellingPrice.Focus();
            }

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
