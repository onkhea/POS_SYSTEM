using System;
using System.Windows.Forms;

namespace POS.Reports
{
    public partial class AddreportsFrm : Form
    {
        public AddreportsFrm()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chbInactive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chbInactive.Name == "chbInactive")
                {
                    if (chbInactive.Checked == false)
                    {
                        return;
                    }
                    OK_Button.Focus();
                }
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCode.Text == "")
                {
                    MessageBox.Show("Please Input data", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtDes.Focus();
            }
        }

        private void txtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboType.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtCode.Focus();
            }

        }

        private void cboType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboType.Text == "")
                {
                    MessageBox.Show("Please Select On Report Type", "Empty", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
                chbInactive.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtDes.Focus();
            }

        }
    }
}
