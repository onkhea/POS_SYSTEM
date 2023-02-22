using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.GUI.POS
{
    public partial class CASHCOLLECTION_FRM : Form
    {
        public CASHCOLLECTION_FRM()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CASHCOLLECTION_FRM_Activated(object sender, EventArgs e)
        {

        }

        private void CASHCOLLECTION_FRM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
