using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Utilities;

namespace POS.GUI.Inventory
{
    public partial class SECURITY_FRM : Form
    {
        public SECURITY_FRM()
        {
            InitializeComponent();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(txtCode))
                {
                    return;
                }
                SelectNextControl(sender as TextBox, true, true, true, true);
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(txtPass))
                    return;

                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }
    }
}
