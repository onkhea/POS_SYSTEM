using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using POS.DataLayer;
using POS.GUI;
using POS.Transaction;
using POS.Transaction.Report.UnitConversion;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.Reports.Unit_Conversion_Type
{
    public partial class ADDNEWUNICONVREPORTDETAIL_FRM : Form
    {
        public ADDNEWUNICONVREPORTDETAIL_FRM()
        {
            InitializeComponent();
        }

        readonly DropDownList _dropDownList = new DropDownList();
        readonly DataManager _dataManager = new DataManager();
        UnitConvertReport _unitConvertReport = new UnitConvertReport();
        

        private void ADDNEWUNICONVREPORTDETAIL_FRM_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnItemCode_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 3;
            _dropDownList.BindingData(
                "SELECT ITEM_CODE,ITEM_DESC,UNIT_STOCK FROM SIPITEMS WHERE ITEM_STAT='A' AND ITEM_TYPE= 'S'",
                txtItemCode, this, droplistFrm, btnItemCode,i,2);
           
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtItemCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtItemDescription.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtUnitofStock.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[2].Value.ToString();
                txtUnitofSale.Focus();

            }
        }

        private void btnUnitofSale_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
           _dropDownList.BindingData(
                "SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV WHERE CONV_FROM >= '" +
                txtUnitofSale.Text + "' AND CONV_TO ='" + txtUnitofStock.Text + "'", txtUnitofSale, this, droplistFrm,
                btnUnitofSale, 2, 3, 4);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtUnitofSale.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtComment1.Focus();
            }
        }

        private void btnUnitofStock_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 3;
            _dropDownList.BindingData(
                "SELECT CONV_TO [Unit Stock], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV WHERE CONV_FROM >= '" +
                txtUnitofSale.Text + "' AND CONV_TO ='" + txtUnitofStock.Text + "'", txtUnitofSale, this, droplistFrm,
                btnUnitofSale,i, 2, 3, 4);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtUnitofStock.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
            }
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtItemCode.Text != "")
                {
                    var dt =
                        _dataManager.GetData(
                            "SELECT ITEM_CODE,ITEM_DESC,UNIT_STOCK FROM SIPITEMS WHERE ITEM_STAT='A' AND ITEM_TYPE= 'S' AND ITEM_CODE LIKE '" +
                            txtItemCode.Text + "%'");
                    foreach (DataRow row in dt.Rows)
                    {
                        
                        txtItemCode.Text = dt.Rows[0][0].ToString();
                        txtItemDescription.Text = dt.Rows[0][1].ToString();
                        txtUnitofStock.Text = dt.Rows[0][2].ToString();
                        txtUnitofSale.Focus();
                    }
                }
            }
            else if (e.KeyCode ==Keys.F6)
            {
                btnItemCode_Click(null,null);
            }
        }

        private void txtUnitofStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtItemCode.Focus();
            }

        }

        private void txtComment1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComment2.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtUnitofSale.Focus();
            }

        }

        private void txtComment2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                OK_Button.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtComment1.Focus();
            }

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (!Condition.EmptyControl(txtItemCode, txtUnitofStock))
            {
                if (!_dataManager.Exists("SIPITEMS", txtItemCode.Text, "ITEM_CODE"))
                {
                    MessageBox.Show("Data '" + txtItemCode.Text + "' not found!", "Not Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtItemCode.SelectAll();
                    txtItemCode.Focus();
                    return;
                }
                txtItemDescription.Text =
                    DataAccess.ReturnField(
                        "SELECT ITEM_DESC FROM SIPITEMS WHERE ITEM_CODE = '" + txtItemCode.Text + "'", 0);
                if (!_dataManager.Exists("SIPITEMS", txtItemCode.Text, "ITEM_CODE", "UNIT_STOCK", txtUnitofStock.Text))
                {
                    MessageBox.Show("Data '" + txtUnitofStock.Text + "' not found!", "Not Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtUnitofStock.SelectAll();
                    txtUnitofStock.Focus();
                    return;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void txtUnitofSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtUnitofSale.Text))
                {
                    var dt =
                        _dataManager.GetData(
                            "SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV WHERE CONV_FROM >= '" +
                            txtUnitofSale.Text + "' AND CONV_TO ='" + txtUnitofStock.Text + "'");
                    if (dt.Rows.Count > 0)
                    {
                        txtUnitofSale.Text = dt.Rows[0][0].ToString();
                        txtComment1.Focus();
                    }
                }
            }
            else if (e.KeyCode ==Keys.F6)
            {
                btnUnitofSale_Click(null,null);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtItemCode.Focus();
            }

        }

        private void OK_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtComment2.Focus();
            }

        }

       
    }
}
