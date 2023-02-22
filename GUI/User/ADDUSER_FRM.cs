using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Transaction;
using POS.Utilities;

namespace POS.GUI.User
{
    public partial class ADDUSER_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public ADDUSER_FRM()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Condition.EmptyControl(txtCode))
                return;
            if (String.Compare(txtPass.Text,txtPass.Text,false) == 0)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("The password was not correctly confirmed.", "Logon User", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error);
                txtConfirm.SelectAll();
                txtConfirm.Focus();
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void chbLog_CheckedChanged(object sender, EventArgs e)
        {
            chbLog.Enabled = !chbLog.Checked;
        }

        private void chbChange_CheckedChanged(object sender, EventArgs e)
        {
            chbLog.Enabled = !chbChange.Checked;
        }

        private void ADDUSER_FRM_Load(object sender, EventArgs e)
        {
            IControls controls = new Controls();
            controls.AddEventHandler(txtCode,txtDes,txtPass,txtUserName,txtConfirm);
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtCode.Focus();
            }

        }

        private void txtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtUserName.Focus();
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtDes.Focus();
            }

        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtPass.Focus();
            }

        }

        private void OK_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtConfirm.Focus();
            }

        }
    }
}
