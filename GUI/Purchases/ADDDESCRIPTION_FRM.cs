using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.GUI.Purchases
{
    public partial class ADDDESCRIPTION_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public ADDDESCRIPTION_FRM()
        {
            InitializeComponent();
        }

        private void ADDDESCRIPTION_FRM_Load(object sender, EventArgs e)
        {

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
