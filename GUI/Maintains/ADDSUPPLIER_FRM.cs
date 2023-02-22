using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class ADDSUPPLIER_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public ADDSUPPLIER_FRM()
        {
            InitializeComponent();
        }

        readonly Controls controls = new Controls();
        private void ADDSUPPLIER_FRM_Load(object sender, EventArgs e)
        {
            controls.AddEventHandler(txtCode,txtSupName,txtTel,txtCom1,txtCom2,txtContName,txtEmail,txtFax,txtLookup,txtWeb,txtAdd1,txtAdd2,txtAdd3,txtAdd4,txtAdd5);
            txtCode.Focus();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Condition.EmptyControl(txtCode, txtSupName, cboStatus))
                return;
            var have_delivery = false;
            foreach (ListViewItem lv in ListView1.Items)
            {
                if (lv.Checked)
                {
                    have_delivery = true;
                    break;
                }
            }
            if (have_delivery == false)
            {
                if (MessageBox.Show("Are you sure you want to add supplier without delivery?","Supplier",MessageBoxButtons.YesNo) == DialogResult.OK)
                {
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (Condition.EmptyControl(txtCode))
                    return;
            }
        }

        private void cboStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                SelectNextControl(cboStatus, true, true, true, true);
            }
        }
    }
}
