using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction.Maintains;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class SIOPTIONS_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public SIOPTIONS_FRM()
        {
            InitializeComponent();
        }
        Utilities.Controls control = new Controls();
        Strings strings = new Strings();
        readonly Connection.Connection connection = new Connection.Connection();
        readonly DateTimes dateTimes = new DateTimes();
        readonly SIOptions siOptions = new SIOptions();
        DataManager dataManager = new DataManager();

        private void SIOPTIONS_FRM_Load(object sender, EventArgs e)
        {

        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            COB_PPRE.BackColor = Color.White;
            COB_PPRE1.BackColor = Color.White;
            COB_PSUF.BackColor = Color.White;
            COB_PSUF1.BackColor = Color.White;
            COB_SPRE.BackColor = Color.White;
            COB_SPRE1.BackColor = Color.White;
            COB_SSUF.BackColor = Color.White;
            COB_SSUF1.BackColor = Color.White;
               
                 
            var PO = COB_PPRE.Text + COB_PSUF.Text + TXT_PINT.Text + TXT_PLEA.Text + TXT_PSTA.Text;
            var PM = COB_PPRE1.Text + COB_PSUF1.Text + TXT_PINT1.Text + TXT_PLEA1.Text + TXT_PSTA1.Text;
            var SIV = COB_SPRE.Text + COB_SSUF.Text + TXT_SINT.Text + TXT_SLEA.Text + TXT_SSTA.Text;
            var POS = COB_SPRE1.Text + COB_SSUF1.Text + TXT_SINT1.Text + TXT_SLEA1.Text + TXT_SSTA1.Text;

            if (PO == PM)
            {
                MessageBox.Show(
                    "Automatic Purchase Order Number and Automatic Purchase Matching Number are the same,Please Check to change it again.",
                    "The Same", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                COB_PPRE.BackColor = Color.Khaki;
                COB_PSUF.BackColor = Color.Khaki;
                COB_PPRE1.BackColor = Color.Khaki;
                COB_PSUF1.BackColor = Color.Khaki;
                Cursor = Cursors.Default;
                return;
            }
            else if (PO == SIV)
            {
                MessageBox.Show(
                    "Automatic Purchase Order Number and Automatic Sale Invoice Number are the same,Please Check to change it again.",
                    "The Same", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                COB_PPRE.BackColor = Color.Khaki;
                COB_PSUF.BackColor = Color.Khaki;
                COB_SPRE.BackColor = Color.Khaki;
                COB_SSUF.BackColor = Color.Khaki;
                Cursor = Cursors.Default;
                return;
            }
            else if (PO == POS)
            {
                MessageBox.Show(
                   "Automatic Purchase Order Number and Automatic POS Invoice Number are the same,Please Check to change it again.",
                   "The Same", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                COB_PPRE.BackColor = Color.Khaki;
                COB_PSUF.BackColor = Color.Khaki;
                COB_SPRE1.BackColor = Color.Khaki;
                COB_SSUF1.BackColor = Color.Khaki;
                Cursor = Cursors.Default;
                return;
                
            }
            else if(PM == SIV)
            {
                MessageBox.Show(
                   "Automatic Purchase Matching Number and Automatic Sale Invoice Number are the same,Please Check to change it again.",
                   "The Same", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                COB_PPRE1.BackColor = Color.Khaki;
                COB_PSUF1.BackColor = Color.Khaki;
                COB_SPRE.BackColor = Color.Khaki;
                COB_SSUF.BackColor = Color.Khaki;
                Cursor = Cursors.Default;
                return;
            }
            else if (PM == POS)
            {
                MessageBox.Show(
                   "Automatic Purchase Matching Number and Automatic POS Invoice Number are the same,Please Check to change it again.",
                   "The Same", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                COB_PPRE1.BackColor = Color.Khaki;
                COB_PSUF1.BackColor = Color.Khaki;
                COB_SPRE1.BackColor = Color.Khaki;
                COB_SSUF1.BackColor = Color.Khaki;
                Cursor = Cursors.Default;
                return;

            }
            else if(SIV == POS)
            {
                MessageBox.Show(
                   "Automatic Sale Invoice Number and Automatic POS Invoice Number are the same,Please Check to change it again.",
                   "The Same", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                COB_SPRE1.BackColor = Color.Khaki;
                COB_SSUF1.BackColor = Color.Khaki;
                COB_SPRE.BackColor = Color.Khaki;
                COB_SSUF.BackColor = Color.Khaki;
                Cursor = Cursors.Default;
                return;
            }
            
            #region ================= Purchase Order Number ====================

            if (CB_PORDER.Checked)
            {
                if (Condition.EmptyControl(TXT_PINT, TXT_PSTA, TXT_PLEA) == false)
                {
                    if (Convert.ToInt16(TXT_PINT.Text) <= 0)
                    {
                        MessageBox.Show("You must enter interval greater than zero!", "", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        TXT_PINT.Focus();
                        TXT_PINT.SelectAll();
                        return;
                    }
                    else
                    {
                        if (Convert.ToInt16(TXT_PLEA.Text) > 15)
                        {
                            MessageBox.Show(
                                "You must enter purchase lenght between zero and 15 charater!\r\n" +
                                "Purchase lenght include prefix and suffix.", "Warning", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            TXT_PLEA.Focus();
                            TXT_PLEA.SelectAll();
                            return;
                        }
                        else
                        {
                            if (Convert.ToInt16(TXT_PLEA.Text) <
                                (COB_PPRE.Text.Replace("!", "").Length + COB_PSUF.Text.Replace("!", "").Length))
                            {
                                MessageBox.Show(
                                    "You must enter purchase lenght between zero and  15 charater!\r\nPurchase lenght include prefix and suffix. and it must greater than sum leght of prefix and suffix",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TXT_PLEA.Focus();
                                TXT_PLEA.SelectAll();
                                return;
                            }
                        }
                    }
                    if (Convert.ToInt16(TXT_PSTA.Text) <= 0)
                    {
                        MessageBox.Show("You must enter start number greater than zero!", "Warning",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_PSTA.Focus();
                        TXT_PSTA.SelectAll();
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            #endregion

            #region ================= Matching Order Number ============

            if (CB_PMATCHING.Checked)
            {
                if (Condition.EmptyControl(TXT_PINT1, TXT_PLEA1, TXT_PSTA1)== false)
                {
                    if (Convert.ToInt16(TXT_PINT1.Text) <= 0)
                    {
                        MessageBox.Show("You must enter interval greater than zero!", "Warning", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        TXT_PINT1.Focus();
                        TXT_PINT1.SelectAll();
                        return;
                    }
                    else
                    {
                        if (Convert.ToInt16(TXT_PLEA1.Text) > 15)
                        {
                            MessageBox.Show(
                                "You must enter purchase matching lenght between zero and 15 charater!\r\npurchase matching lenght include prefix and suffix.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TXT_PLEA1.Focus();
                            TXT_PSTA1.SelectAll();
                            return;
                        }
                        else
                        {
                            if (Convert.ToInt16(TXT_PLEA1.Text) < (COB_PPRE1.Text.Replace("!","").Length + COB_PSUF1.Text.Replace("!","").Length) + TXT_PSTA1.Text.Length)
                            {
                                MessageBox.Show("You must enter purchase matching lenght between zero and  15 charater!\r\npurchase matching lenght include prefix and suffix.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                TXT_PLEA1.Focus();
                                TXT_PLEA1.SelectAll();
                                return;
                            }
                        }
                    }
                    if (Convert.ToInt16(TXT_PSTA1.Text) <= 0)
                    {
                        MessageBox.Show("You must enter start number greater than zero!", "Warning",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_PLEA1.Focus();
                        TXT_PLEA1.SelectAll();
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            

            #endregion

            #region ================= Save To Database =================

            try
            {


                var command = new SqlCommand("DELETE FROM SIPDATA WHERE SI_TYPE='AUTON'", connection.Connect());
                command.ExecuteNonQuery();

                if (CB_PORDER.Checked == true)
                {
                    var values = new string[]
                                     {
                                         "PO", "AUTON", "Y",
                                         COB_PPRE.Text.PadRight(10) + COB_PSUF.Text.PadRight(10) +
                                         TXT_PINT.Text.PadRight(5) +
                                         TXT_PLEA.Text.PadRight(2) + TXT_PSTA.Text.PadRight(5), "", dateTimes.Now(),
                                         UserLogOn.Code, dateTimes.Now()
                                     };
                    siOptions.Save(values);
//                MessageBox.Show("Saved successfull");
                }
                if (CB_PMATCHING.Checked)
                {
                    var values = new string[]
                                     {
                                         "PM", "AUTON", "Y",
                                         COB_PPRE1.Text.PadRight(10) + COB_PSUF1.Text.PadRight(10) +
                                         TXT_PINT1.Text.PadRight(5) +
                                         TXT_PLEA1.Text.PadRight(2) + TXT_PSTA1.Text.PadRight(5), "", dateTimes.Now(),
                                         UserLogOn.Code, dateTimes.Now()
                                     };
                    siOptions.Save(values);
//                MessageBox.Show("Saved successfull");
                }
                if (CB_S.Checked)
                {
                    var values = new string[]
                                     {
                                         "SO", "AUTON", "Y",
                                         COB_SPRE.Text.PadRight(10) + COB_SSUF.Text.PadRight(10) +
                                         TXT_SINT.Text.PadRight(5) +
                                         TXT_SLEA.Text.PadRight(2) + TXT_SSTA.Text.PadRight(5), "", dateTimes.Now(),
                                         UserLogOn.Code, dateTimes.Now()
                                     };
                    siOptions.Save(values);
//                MessageBox.Show("Saved successfull");
                }

                if (CB_POS.Checked)
                {
                    var values = new string[]
                                     {
                                         "OS", "AUTON", "Y",
                                         COB_SPRE1.Text.PadRight(10) + COB_SSUF1.Text.PadRight(10) +
                                         TXT_SINT1.Text.PadRight(5) +
                                         TXT_SLEA1.Text.PadRight(2) + TXT_SSTA1.Text.PadRight(5), "", dateTimes.Now(),
                                         UserLogOn.Code, dateTimes.Now()
                                     };
                    siOptions.Save(values);
//                MessageBox.Show("Saved successfull");
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);   
            }
            #endregion
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in TreeView1.Nodes)
            {
                if (node.IsSelected)
                {
                    switch (node.Index)
                    {
                        case 0:
                            var command =
                                new SqlCommand("SELECT SI_DATA FROM SIPDATA WHERE SI_CODE = 'PO' AND SI_TYPE = 'AUTON'",
                                               connection.Connect());
                            var dt = dataManager.GetData(command);
                            if (dt.Rows.Count > 0)
                            {
                                CB_PORDER.Checked = true;
                                var str = dt.Rows[0][0].ToString();
                                //                              ===========  purchase order =========
                                COB_PPRE.Text = str.Substring(0, 10).Trim();
                                COB_PSUF.Text = str.Substring(10, 10).Trim();
                                TXT_PINT.Text = str.Substring(20, 5).Trim();
                                TXT_PLEA.Text = str.Substring(25, 2).Trim();
                                TXT_PSTA.Text = str.Substring(27, 5).Trim();
                            }
                            command =
                                new SqlCommand("SELECT SI_DATA FROM SIPDATA WHERE SI_CODE = 'PM'AND SI_TYPE = 'AUTON'",
                                               connection.Connect());
                            dt = dataManager.GetData(command);
                            if (dt.Rows.Count > 0)
                            {
                                CB_PMATCHING.Checked = true;
                                var str = dt.Rows[0][0].ToString();
                                //                          ========  Purchase Matching    
                                COB_PPRE1.Text = str.Substring(0, 10).Trim();
                                COB_PSUF1.Text = str.Substring(10, 10).Trim();
                                TXT_PINT1.Text = str.Substring(20, 5).Trim();
                                TXT_PLEA1.Text = str.Substring(25, 2).Trim();
                                TXT_PSTA1.Text = str.Substring(27, 5).Trim();

                            }

                            command =
                                new SqlCommand("SELECT SI_DATA FROM SIPDATA WHERE SI_CODE = 'SO' AND SI_TYPE = 'AUTON'",
                                               connection.Connect());
                            dt = dataManager.GetData(command);
                            if (dt.Rows.Count > 0)
                            {
                                CB_S.Checked = true;
                                var str = dt.Rows[0][0].ToString();
                                //                                ============ purchase order =========
                                COB_SPRE.Text = str.Substring(0, 10).Trim();
                                COB_SSUF.Text = str.Substring(10, 10).Trim();
                                TXT_SINT.Text = str.Substring(20, 5).Trim();
                                TXT_SLEA.Text = str.Substring(25, 2).Trim();
                                TXT_SSTA.Text = str.Substring(27, 5).Trim();
                            }

                            command =
                                new SqlCommand("SELECT SI_DATA FROM SIPDATA WHERE SI_CODE = 'OS' AND SI_TYPE = 'AUTON'",
                                               connection.Connect());
                            dt = dataManager.GetData(command);
                            if (dt.Rows.Count > 0)
                            {
                                CB_POS.Checked = true;
                                var str = dt.Rows[0][0].ToString();
                                //                                ============ purchase matching =========
                                COB_SPRE1.Text = str.Substring(0, 10).Trim();
                                COB_SSUF1.Text = str.Substring(10, 10).Trim();
                                TXT_SINT1.Text = str.Substring(20, 5).Trim();
                                TXT_SLEA1.Text = str.Substring(25, 2).Trim();
                                TXT_SSTA1.Text = str.Substring(27, 5).Trim();
                            }
                            break;
                    }
                }
            }
        }

        #region Enable

        private void Enable_PurchaseOrder()
        {
            control.EnabledControlTrue(COB_PPRE, COB_PSUF, TXT_PINT, TXT_PLEA, TXT_PSTA);
        }
        private void Enable_PurchaseMatching()
        {
            control.EnabledControlTrue(COB_PPRE1, COB_PSUF1, TXT_PINT1, TXT_PLEA1, TXT_PSTA1);
        }

        private void Enable_Sale()
        {
            control.EnabledControlTrue(COB_SPRE, COB_SSUF, TXT_SINT, TXT_SLEA, TXT_SSTA);            
        }
        
        private void Enable_SaleMatching()
        {
            control.EnabledControlTrue(COB_SPRE1, COB_SSUF1, TXT_SINT1, TXT_SLEA1, TXT_SSTA1);
        }

        #endregion

        #region Disable

        private void Disable_PurchaseOrder()
        {
            control.Enabled_Control_False(COB_PPRE, COB_PSUF, TXT_PINT, TXT_PLEA, TXT_PSTA);
        }

        private void Disable_PurchaseMatching()
        {
            control.Enabled_Control_False(COB_PPRE1, COB_PSUF1, TXT_PINT1, TXT_PLEA1, TXT_PSTA1);
        }

        private void Disable_Sale()
        {
            control.Enabled_Control_False(COB_SPRE, COB_SSUF, TXT_SINT, TXT_SLEA, TXT_SSTA);
        }

        private void Disable_SaleMatching()
        {
            control.Enabled_Control_False(COB_SPRE1, COB_SSUF1, TXT_SINT1, TXT_SLEA1, TXT_SSTA1);
        }


        #endregion

        #region Check box

        private void CB_PORDER_CheckedChanged(object sender, EventArgs e)
        {
            switch (CB_PORDER.Checked)
            {
                case false:
                    Disable_PurchaseOrder();
                    break;
                default:
                    Enable_PurchaseOrder();
                    break;
            }
        }

        private void CB_PMATCHING_CheckedChanged(object sender, EventArgs e)
        {
            switch (CB_PMATCHING.Checked)
            {
                case false:
                    Disable_PurchaseMatching();
                    break;
                default:
                    Enable_PurchaseMatching();
                    break;
            }
        }

        private void CB_S_CheckedChanged(object sender, EventArgs e)
        {
            switch (CB_S.Checked)
            {
                case false:
                    Disable_Sale();
                    break;
                default:
                    Enable_Sale();
                    break;
            }
        }

        private void CB_POS_CheckedChanged(object sender, EventArgs e)
        {
            switch (CB_POS.Checked)
            {
                case false:
                    Disable_SaleMatching();
                    break;
                default:
                    Enable_SaleMatching();
                    break;
            }
        }

        #endregion
    }
}
