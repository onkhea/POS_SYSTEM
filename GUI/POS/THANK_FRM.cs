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
    public partial class THANK_FRM : Form
    {
        public THANK_FRM()
        {
            InitializeComponent();
        }

        private void THANK_FRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
               Close(); 
            }
        }
    }
}
