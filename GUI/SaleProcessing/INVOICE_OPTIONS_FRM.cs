using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Utilities;

namespace POS.GUI.SaleProcessing
{
    public partial class INVOICE_OPTIONS_FRM : Form
    {
        public INVOICE_OPTIONS_FRM()
        {
            InitializeComponent();
        }

        readonly Strings strings = new Strings();

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    txtDiscount.Text = "0";
                }
                if (strings.IsDecimal(txtDiscount.Text))
                {
                    txtDiscUSD.Text = string.Format("{0:0,0.00}",
                                                    Convert.ToDecimal(txtTotalInvoice.Text)*
                                                    Convert.ToDecimal(txtDiscount.Text)/100);
                }
                txtGrandTotal.Text = string.Format("{0:0,0.00}",
                                                   Convert.ToDecimal(txtTotalInvoice.Text) -
                                                   Convert.ToDecimal(txtDiscUSD.Text) + Convert.ToDecimal(txtVAT.Text));
                chkVAT.Focus();
            }
        }

        private void chkVAT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVAT.Checked)
            {
                txtVAT.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(txtGrandTotal.Text)*10/100);
                txtGrandTotal.Text = string.Format("{0:0,0.00}",
                                            Convert.ToDecimal(txtGrandTotal.Text) + Convert.ToDecimal(txtVAT.Text));
                txtDiscount.Enabled = false;
                txtDiscUSD.Enabled = false;
            }
            else
            {
                txtVAT.Text = "0";
                txtGrandTotal.Text = string.Format("{0:0,0.00}",
                                                 Convert.ToDecimal(txtTotalInvoice.Text) -
                                                 Convert.ToDecimal(txtDiscUSD.Text));
                txtDiscount.Enabled = true;
                txtDiscUSD.Enabled = true;
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "")
            {
                txtDiscUSD.Text = "0";
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void INVOICE_OPTIONS_FRM_Load(object sender, EventArgs e)
        {
           
        }
    }
}
