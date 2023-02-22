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
    public partial class DELETE_FRM : Form
    {
        public DELETE_FRM()
        {
            InitializeComponent();
        }

        private void txtbcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                if (txtbcode.Text != "")
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        private void txtbcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Shift == false && e.Control == false && e.Alt == false)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
        }
    }
}
