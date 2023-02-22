using System;
using System.Windows.Forms;
using POS.Utilities;
using POS.DataLayer;

namespace POS.GUI.Maintains
{
    public partial class ADDLOCATION_FRM : Form //DevComponents.DotNetBar.Office2007Form
    {
        public ADDLOCATION_FRM()
        {
            InitializeComponent();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            var dataManager = new DataManager();

            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(txtCode))
                    return;
                if (txtCode.Name == "txtCode")
                {
                    if (dataManager.Exists("SIPLOCA", txtCode.Text, "LOC_CODE"))
                    {
                        MessageBox.Show("This location code already exists!", "Exists", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        txtCode.Focus();
                        return;
                    }    
                }
                SelectNextControl(txtCode, true, true, true, true);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SelectNextControl(txtName, true, true, true, true);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtCode.Focus();

            }

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (!Condition.EmptyControl(txtCode,txtName))
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void ADDLOCATION_FRM_Load(object sender, EventArgs e)
        {

        }

        private void cboStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(cboStatus, true, true, true, true);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtName.Focus();
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
