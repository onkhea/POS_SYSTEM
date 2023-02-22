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

namespace POS.Reports
{
    public partial class PRINT_BARCODE : Form
    {
        public PRINT_BARCODE()
        {
            InitializeComponent();
        }

        DropDownList _downList = new DropDownList();
        DataManager _dataManager = new DataManager();

        private void btn_Item_codeF_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 48;
            _downList.BindingData("SELECT ITEM_CODE [Item code],ITEM_BCODE[Item Barcode],ITEM_DESC [Item Description] FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txt_Item_codeF, this, droplistFrm, btn_Item_codeF, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txt_Item_codeF.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[2].Value.ToString();
                txtBarcode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtNumBarcode.Focus();
                
            }
        }

        private void txt_Item_codeF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Item_codeF.Text != "")
                {
                    var dt =
                        _dataManager.GetData("SELECT ITEM_CODE,ITEM_BCODE,ITEM_DESC FROM SIPITEMS WHERE UPPER(ITEM_CODE) LIKE UPPER('" +
                                            txt_Item_codeF.Text + "%') ORDER BY ITEM_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txt_Item_codeF.Text = dt.Rows[0][0].ToString();
                        txtDesc.Text = dt.Rows[0][2].ToString();
                        txtBarcode.Text = dt.Rows[0][1].ToString();
                        txtNumBarcode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Item code '" + txt_Item_codeF.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Item_codeF.SelectionStart = 0;
                        txt_Item_codeF.SelectionLength = txt_Item_codeF.Text.Length;
                        return;
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                const short i = 48;
                _downList.BindingData("SELECT ITEM_CODE,ITEM_BCODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txt_Item_codeF, this, droplistFrm, btn_Item_codeF, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txt_Item_codeF.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[2].Value.ToString();
                    txtBarcode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                    txtNumBarcode.Focus();
                }

            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var printBarcodeRpt = new PRINT_BARCODE_RPT();
            var dataManager = new DataManager();
            var dt = dataManager.Create("Barcode");
            
            for (int i = 0; i < Convert.ToInt32(txtNumBarcode.Text); i++)
            {
                DataRow row = dt.NewRow();
                row[0] =  "*" + txtBarcode.Text + "*";
                dt.Rows.Add(row);
            }
            var report = new Report();
            report.Preview("Print Barcode",dt);
        }
        Controls _controls = new Controls();
        private void PRINT_BARCODE_Load(object sender, EventArgs e)
        {
            _controls.Only_Number_On_Control_Except_Dot(txtNumBarcode);
        }

        private void txtNumBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPreview.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
