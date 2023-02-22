using System;
using System.Windows.Forms;
using POS.Utilities;

namespace POS.Reports.Unit_Conversion_Type
{
    public partial class ADDUNITTYPECONVERTREPORT : Form
    {
        public ADDUNITTYPECONVERTREPORT()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ADDUNITTYPECONVERTREPORT_Load(object sender, EventArgs e)
        {
            Controls controls = new Controls();
            controls.AddEventHandler(txtCode,txtComment1,txtComment2,txtDesc);
        }

        private void txtDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtCode.Focus();
            }

        }

        private void txtComment1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtDesc.Focus();
            }

        }

        private void txtComment2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtComment1.Focus();
            }

        }

        private void OK_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtComment2.Focus();
            }

        }
    }
}
