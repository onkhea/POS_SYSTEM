using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction.Maintains;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class ADDUNITCONVERT_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public ADDUNITCONVERT_FRM()
        {
            InitializeComponent();
        }

        readonly Controls controls = new Controls();
        readonly Strings str = new Strings();
        readonly SIUNITCONVERT_FRM siunitconvert_FRM = new SIUNITCONVERT_FRM();

        private void ADDUNITCONVERT_FRM_Load(object sender, EventArgs e)
        {
            controls.Only_Number_On_Control(txtfactor);
            cbooperator.SelectedIndex = 0;
        }

        private void TxtdescF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SelectNextControl(TxtdescF1, true, true, true, true);
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                cboconvf.Focus();
            }
        }

        private void txtfactor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!Condition.EmptyControl(txtfactor))
                {
                    if (!str.IsDecimal(txtfactor.Text))
                    {
                        MessageBox.Show("Factor have too much value.", "Too Much", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        txtfactor.Focus();
                        return;
                    }
                    SelectNextControl(txtfactor, true, true, true, true);
                }
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                cbooperator.Focus();
            }
        }

        private void cbooperator_KeyDown(object sender, KeyEventArgs e)
        {
            if (Condition.EmptyControl(cbooperator)) return;
            if (e.KeyData == Keys.Enter)
            {
                SelectNextControl(cbooperator, true, true, true, true);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtDescT2.Focus();
            }
           
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            var dataManager = new DataManager();
            var value = new string[] { "CONV_FROM", cboconvf.Text, "CONV_TO", txtconvt.Text };

            if (!Condition.EmptyControl(cboconvf, txtconvt, cbooperator, txtfactor))
            {
                if (this.Text != "Edit Unit Conversion")
                {
                    var paraAndValue = new string[] { "CONV_FROM", cboconvf.Text, "CONV_TO", txtconvt.Text };
                    if (dataManager.Exists("SIUNITCONV", paraAndValue))
                    {
                        MessageBox.Show("Conversion already exists!", "Existing", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        cboconvf.Focus();
                        return;
                    }
                }

                if (!str.IsNumeric(txtfactor.Text))
                {
                    if (Convert.ToDecimal(txtfactor.Text) > Numbers.Maximum)
                    {
                        MessageBox.Show("Factor have too much value.");
                        txtfactor.SelectAll();
                        txtfactor.Focus();
                        return;
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ADDUNITCONVERT_FRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            //            e.Cancel = true;
        }

        private void cboconvf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboconvf.Text == "")
                {
                    cboconvf.Focus();
                    return;
                }
                SelectNextControl(cboconvf, true, true, true, true);
            }
        }

        private void txtconvt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtconvt.Text == "")
                {
                    return;
                }
               SelectNextControl(txtconvt, true, true, true, true);
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtDescF2.Focus();
            }
            
        }

        private void txtDescT1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(txtDescT1, true, true, true, true);
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtconvt.Focus();
            }
        }

        private void txtDescT2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(txtDescT2, true, true, true, true);
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtDescT1.Focus();
            }
        }

        private void txtDescF2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(txtDescF2, true, true, true, true);
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                TxtdescF1.Focus();
            }
        }

        private void txtconvt_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void OK_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtfactor.Focus();
            }
        }
    }
}
