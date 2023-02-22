using System;
using System.Windows.Forms;
using POS.Utilities;

namespace POS.GUI.Purchases
{
    public partial class SISOSPLIT_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public SISOSPLIT_FRM()
        {
            InitializeComponent();
        }

        public Decimal AMT = 0;

        private void SISOSPLIT_FRM_Load(object sender, EventArgs e)
        {

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Condition.EmptyControl(txtSplit) == false)
            {
                if (Decimal.Parse(txtSplit.Text) < AMT )
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Split amount must be smaller than original amount.", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtSplit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(txtSplit))
                {
                    MessageBox.Show("Please input value.", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Condition.Check_Decimal(txtSplit))
                {
                    OK_Button_Click(null,null);
                }
            }
        }
    }
}
