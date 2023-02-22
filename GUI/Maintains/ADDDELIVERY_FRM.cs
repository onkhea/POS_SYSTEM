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

namespace POS.GUI.Maintains
{
    public partial class ADDDELIVERY_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public ADDDELIVERY_FRM()
        {
            InitializeComponent();

        }

        readonly DataManager dataManager = new DataManager();
        Controls controls = new Controls();
        private void ADDDELIVERY_FRM_Load(object sender, EventArgs e)
        {
            controls.AddEventHandler(txtCode,txtweb,txtadd1,txtadd2,txtadd3,txtadd4,txtadd5,txtCom1,txtCom2,txtContName,txtemail,txtfax,txtName,txttel);
            txtCode.Focus();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Condition.EmptyControl(txtCode, txtName))
            {
                if (this.Text == "Customer Delivery Address" || this.Text == "Add Customer Delivery Address" || this.Text == "Paste Customer Delivery Address")
                {
                    if (dataManager.Exists("SIPDADD", "DEL_CODE", txtCode.Text, "DEL_TYPE", "0"))
                    {
                        MessageBox.Show("Address Code already exists!", "Existing", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        txtCode.Focus();
                        return;
                    }
                }
            }
            else if (this.Text == "Edit Customer Delivery Address")
            {
                if (txtCode.Text != txtCode.Text)
                {
                    MessageBox.Show("Address Code already exists!", "Existing Record", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtCode.Focus();
                    return;
                }
            }
            else if (this.Text == "Supplier Delivery Address " || this.Text == "Add Supplier Delivery Address" || this.Text == "Paste Item Record")
            {
                if (dataManager.Exists("SIPDADD", txtCode.Text, "DEL_CODE", "DEL_TYPE", "0"))
                {
                    MessageBox.Show("Address Code already exists!", "Existing Record", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    txtCode.Focus();
                    return;
                }
            }
            else if (this.Text == "Edit Supplier Delivery Address")
            {
                if (txtCode.Text != txtCode.Text)
                {
                    MessageBox.Show("Address Code already exists!", "Existing Record", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    txtCode.Focus();
                    return;
                }
            }

            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtCode.Focus();
            }
        }

        private void txtadd1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtName.Focus();
            }
        }

        private void txtadd2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtadd1.Focus();
            }
        }

        private void txtadd3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtadd2.Focus();
            }
        }

        private void txtadd4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtadd3.Focus();
            }
        }

        private void txtadd5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtadd4.Focus();
            }
        }

        private void txttel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtadd5.Focus();
            }
        }

        private void txtfax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txttel.Focus();
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtfax.Focus();
            }
        }

        private void txtweb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtemail.Focus();
            }
        }

        private void txtContName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtweb.Focus();
            }
        }

        private void txtCom1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtContName.Focus();
            }
        }

        private void txtCom2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtCom1.Focus();
            }
        }

        private void OK_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtCom2.Focus();
            }
        }
    }
}
