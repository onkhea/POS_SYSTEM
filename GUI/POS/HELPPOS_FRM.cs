using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace POS.GUI.POS
{
    public partial class HELPPOS_FRM : Form
    {
        public HELPPOS_FRM()
        {
            InitializeComponent();
        }

        private void HELPPOS_FRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 27)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                SystemSounds.Beep.Play();
            }
        }
    }
}
