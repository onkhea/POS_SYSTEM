using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Utilities;

namespace POS.GUI.User
{
    public partial class ADDGROUP_FRM : Form //DevComponents.DotNetBar.Office2007Form
    {
        public ADDGROUP_FRM()
        {
            InitializeComponent();
        }

        private void GROUP_FRM_Load(object sender, EventArgs e)
        {
            IControls controls = new Controls();
            controls.AddEventHandler(txtCode,txtDes);
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Condition.EmptyControl(txtCode,txtDes))
                return;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void ADDGROUP_FRM_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cboStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(cboStatus, true, true, true, true);
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtDes.Focus();
            }

        }

        private void txtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtCode.Focus();
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
