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

namespace POS.GUI.POS
{
    public partial class TERMINAL_FRM : Form
    {
        public TERMINAL_FRM()
        {
            InitializeComponent();
        }

        DataManager dataManager = new DataManager();
        public string deliveryId = "";
        private bool btnClosing = false;
        
        private void btnLocCode_Click(object sender, EventArgs e)
        {
            try
            {
                var drop = new DROPLIST_FRM();
                drop.Width = 360;
                drop.DataGridView.DataSource =
                    dataManager.GetData("SELECT LOC_CODE [Location Code],LOC_NAME [Location Name] FROM SIPLOCA", "LOC_CODE",
                                        "LOC_CODE", txtLocCode.Text, "LOC_STAT", "A");
                drop.Top = this.Top + txtLocCode.Top + txtLocCode.Height + 1;
                drop.Left = this.Left + txtLocCode.Left + 1;
                drop.DataGridView.Columns[0].Width = drop.DataGridView.Width * 34 / 100;
                drop.DataGridView.Columns[1].Width = drop.DataGridView.Width * 60 / 100;
                if (drop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtLocCode.Text = drop.DataGridView.Rows[drop.SelectIndex].Cells[0].Value.ToString();
                    txtLocDesc.Text = drop.DataGridView.Rows[drop.SelectIndex].Cells[1].Value.ToString();
                    SelectNextControl(txtLocCode, true, true, true, true);
                }
                else
                {
                    txtLocCode.SelectAll();
                    txtLocCode.Focus();
                }
                drop.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void txtLocCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Condition.EmptyControl(txtLocCode))
                        return;
                    else
                    {
                        var dt = dataManager.GetData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA", "LOC_CODE", "LOC_CODE",
                                                     txtLocCode.Text);
                        if (dt.Rows.Count > 0)
                        {
                            txtLocCode.Text = dt.Rows[0][0].ToString();
                            txtLocDesc.Text = dt.Rows[0][1].ToString();
                            txtCustomer.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Data '" + txtLocCode.Text + "' not found", "Not Found",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtLocCode.SelectAll();
                            txtLocCode.Focus();
                        }
                    }
                }
                else if (e.KeyCode == Keys.F6)
                {
                    btnLocCode_Click(sender,e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Condition.EmptyControl(txtLocCode,txtCustomer))
                return;
            if (dataManager.Exists("SIPLOCA",  txtLocCode.Text,"LOC_CODE")== false)
            {
                MessageBox.Show("Data '" + txtLocCode.Text + "' not found!", "Not Found", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtLocCode.SelectAll();
                txtLocCode.Focus();
            }
            SITempData.Loc_Code_POS = txtLocCode.Text;
            SITempData.CUST_POS = txtCustomer.Text;
//            SITempData.DelcustPos = deliveryId;
            btnClosing = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var drop = new DROPLIST_FRM();
                drop.Width = 360;
                drop.DataGridView.DataSource =
                    dataManager.GetData("SELECT ADD_CODE,DEL_NAME,DEL_CODE FROM dbo.SIPDADD ", "ADD_CODE",
                                        "ADD_CODE", txtCustomer.Text, "DEL_TYPE", "0");
                drop.Top = this.Top + txtCustomer.Top + txtCustomer.Height + 1;
                drop.Left = this.Left + txtCustomer.Left + 1;
                drop.DataGridView.Columns[0].Width = drop.DataGridView.Width * 34 / 100;
                drop.DataGridView.Columns[1].Width = drop.DataGridView.Width * 60 / 100;
                drop.DataGridView.Columns[2].Visible = false;
                if (drop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtCustomer.Text = drop.DataGridView.Rows[drop.SelectIndex].Cells[0].Value.ToString();
                    txtCustName.Text = drop.DataGridView.Rows[drop.SelectIndex].Cells[1].Value.ToString();
                    SITempData.DelcustPos = drop.DataGridView.Rows[drop.SelectIndex].Cells[2].Value.ToString();                    
                    SelectNextControl(txtCustomer, true, true, true, true);
                }
                else
                {
                    txtCustomer.SelectAll();
                    txtCustomer.Focus();
                }
                drop.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TERMINAL_FRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnClosing == false)
            {
                e.Cancel = true;
                base.OnClosing(e);    
            }
            
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomer.Text != "")
                {
                    var dt = dataManager.GetData("SELECT ADD_CODE,DEL_NAME,DEL_CODE FROM dbo.SIPDADD ", "ADD_CODE",
                                                 "ADD_CODE", txtCustomer.Text, "DEL_TYPE", "0");
                    if (dt.Rows.Count > 0)
                    {
                        txtCustomer.Text = dt.Rows[0][0].ToString();
                        txtCustName.Text = dt.Rows[0][1].ToString();
                        SITempData.DelcustPos = dt.Rows[0][2].ToString();
                        btnOK_Click(null,null);
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnCustomer_Click(null,null);
            }

        }
    }
}
