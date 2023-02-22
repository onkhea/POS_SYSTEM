using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using POS.Connection;
using POS.DataLayer;
using POS.GUI.User;
using POS.Transaction;
using POS.Transaction.Maintains;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI
{
    public partial class LOGIN_FRM : DevComponents.DotNetBar.Office2007Form
    {
        public LOGIN_FRM()
        {
            InitializeComponent();
            loadLanguage();
        }

        private readonly IConnection _connection = new Connection.Connection();
        readonly DataManager _dataManager = new DataManager();
        
        DataTable dtLocat = new DataTable();
        readonly IControls _controls = new Controls();
        
        private void LOGIN_FRM_Load(object sender, EventArgs e)
        {
//            _controls.AddEventHandler(txtUserID,txtPwd,dtpdate);
            try
            {
                var connection = new Connection.Connection();
                connection.ReadConnectionFromFile();
                connection.Connect();
                var location = new SILocation();
                dtLocat = location.LoadData();
                dtpdate.Value = DateTime.Now;
                Activate();
            }
            catch (Exception)
            {
              var connectionFrm = new ConnectionFrm();
                connectionFrm.ShowDialog();
            }
           
            Cursor = Cursors.Default; 
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_FRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OK_Click(object sender, EventArgs e)
      {
//            try
//            {
                
//                SIUser user = new SIUser();
//                ADDUSER_FRM adduser_FRM = new ADDUSER_FRM();
//                if (Condition.EmptyControl(txtUserID)) return;
////                if (_dataManager.Exists("SIPUSERG", "D", "PER_TYPE", "USER_CODE",txtUserID.Text) && txtUserID.Text != "SISA")
////                {
////                    MessageBox.Show("This user id cannot access this database!", "Access Deny", MessageBoxButtons.OK,
////                                    MessageBoxIcon.Information);
////                    return;
////                }

//                var dtUser = _dataManager.Filter(user.LoadData(), "USER_CODE", txtUserID.Text.Trim());
//                if (dtUser.Rows.Count > 0)
//                {
//                    var dd = dtUser.Rows[0][6].ToString();
//                    if (System.Text.Encoding.UTF32.GetString((byte[])dtUser.Rows[0][6]).CompareTo(txtPwd.Text) !=0)
//                    {
//                        MessageBox.Show("Your password was not recognised. Please check and try again.", "Access Deny",
//                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        txtPwd.Focus();
//                        return;
//                    }
//                    if (txtUserID.Text != "SISA")
//                    {
//                        var d = dtUser.Rows[0][5].ToString();
//                        if (System.Text.Encoding.UTF32.GetString((byte[]) dtUser.Rows[0][5]).CompareTo("U") != 0)
//                        {
//                            MessageBox.Show(
//                                "Your id have been loged out. Please log in with another ID or check with admin users.",
//                                "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                            return;
//                        }
//                    }
//                    if (dtUser.Rows[0][5].ToString().CompareTo("0") == 0 )
//                    {
//                        MessageBox.Show("This user id was disabled. Please contact with admin users.","Disable User",MessageBoxButtons.OK,MessageBoxIcon.Warning);
//                        return;
//                    }
////                    ==========  assign value global =============

//                    UserLogOn.Code = null;
//                    UserLogOn.Name = null;
//                    UserLogOn.Code = txtUserID.Text;
//                    UserLogOn.Name = dtUser.Rows[0][1].ToString();
//                    UserLogOn.Date = Convert.ToDateTime(dtpdate.Value.ToShortDateString());
//                    SIUser.Code = txtUserID.Text;

////                    ==============================================

//                    if (dtUser.Rows[0][3].ToString().CompareTo("2") == 0)
//                    {
//                        adduser_FRM.Text = "Set Password for" + UserLogOn.Name;
//                        adduser_FRM.txtCode.Text = UserLogOn.Code;
//                        adduser_FRM.Panel2.Visible = false;
//                        adduser_FRM.Panel3.Visible = false;
//                        adduser_FRM.Panel1.Top = 10;
//                        adduser_FRM.Height = 180;
//                        if (adduser_FRM.ShowDialog() == DialogResult.OK)
//                        {
//                            SIUser.Password = System.Text.Encoding.UTF32.GetBytes(adduser_FRM.txtPass.Text);
//                            user.UpdateChangePassword(txtUserID.Text);
//                            MessageBox.Show("The password has been set.", "Change Password", MessageBoxButtons.OK,
//                                            MessageBoxIcon.Information);

//                        }
//                        else
//                        {
//                            return;
//                        }
//                    }
//                    adduser_FRM.Close();

//                        SIUser.ULog = System.Text.Encoding.UTF32.GetBytes("L");
//                        user.UpdateChangeUserLog();


//                        // TODO: This place deal with Group user account check it again when finish group account......
//                        if (!string.IsNullOrEmpty(txtLocation.Text))
//                        {
//                            if (!_dataManager.Exists("SIPLOCA", txtLocation.Text, "LOC_CODE", "LOC_STAT","A"))
//                            {
//                                MessageBox.Show("Data '" + txtLocation.Text + "' not found!", "", MessageBoxButtons.OK,
//                                                MessageBoxIcon.Information);
//                                txtLocation.SelectAll();
//                                txtLocation.Focus();
//                                return;
//                            }
//                        }
//                        UserLogOn.Location = txtLocation.Text;
////                       ===============  TODO: need to show MDI Form here ===========
//                    Hide();

//                    #region Language
//                    string selectedlangeuage = string.Empty;

//                    if (radioButtonEnglish.Checked)
//                        selectedlangeuage = "en-US";
//                    if(radioButtonKhmer.Checked)
//                        selectedlangeuage = "km-KH";

//                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedlangeuage);


//                    #endregion

                    var main_FRM = new MAIN_FRM_SI();                    
                    main_FRM.ShowDialog();
                    
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Cursor = Cursors.Default;
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            var downList = new DropDownList();
            DROPLIST_FRM droplistFrm = new DROPLIST_FRM();
            Int16 top = 8;
            downList.BindingData("SELECT * FROM dbo.SIPLOCA",txtLocation,this,droplistFrm,btnLocation,top,2,3);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtLocDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
            }

        }

        private void txtLocation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtLocation.Text == "")
                    {
                        MessageBox.Show("Please Input data.");
                        txtLocation.Focus();
                        return;
                    }
                    else
                    {
                        var command =
                            new SqlCommand(
                                "SELECT LOC_CODE, LOC_NAME FROM SIPLOCA WHERE UPPER(LOC_CODE) LIKE UPPER('" +
                                txtLocation.Text + "%')", _connection.Connect());

                        var dataAdapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            txtLocation.Text = dt.Rows[0][0].ToString();
                            txtLocDesc.Text = dt.Rows[0][1].ToString();
                            SelectNextControl(txtLocation, true, true, true, true);
                        }
                        else
                        {
                            MessageBox.Show("Data '" + txtLocation.Text + "' not found", "Not Found",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtLocation.SelectionStart = 0;
                            txtLocation.SelectionLength = txtLocation.Text.Length;
                            txtLocation.SelectAll();
                            txtLocation.Focus();
                            return;
                        }
                    }
                }
                else if (e.KeyCode == Keys.F6)
                {
                    btnLocation_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtUserID.Text))
                {
                    if (!_dataManager.Exists("SIPUSERS",txtUserID.Text,"USER_CODE"))
                    {
                        MessageBox.Show("This User '" + txtUserID.Text + "' not fount", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserID.SelectionStart = 0;
                        txtUserID.SelectionLength = txtUserID.Text.Length;
                        txtUserID.Focus();
                        return;
                    }
                    SelectNextControl(txtUserID, true, true, true, true);
                } 
            }
           
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              SelectNextControl(txtPwd, true, true, true, true);
            }
            
        }

        private void dtpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(dtpdate, true, true, true, true);
            }
           
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadLanguage()
        {
            imageComboBoxEdit1.SelectedIndex = 0;
        }
        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var setlanguage = imageComboBoxEdit1.SelectedIndex;
            if (setlanguage == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("km-KH");
                Thread.CurrentThread.CurrentCulture= new CultureInfo("km-KH");
             
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            }
            
        }
    }
}
