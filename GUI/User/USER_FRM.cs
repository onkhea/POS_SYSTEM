using System;
using System.Data;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.User
{
    public partial class USER_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public USER_FRM()
        {
            InitializeComponent();
        }

        #region global variable

        private Connection.Connection connection = new Connection.Connection();
        readonly DataManager dataManager = new DataManager();
        readonly SISecurity security = new SISecurity();
//        readonly ADDUSER_FRM adduser_FRM = new ADDUSER_FRM();
        readonly SIMenuItems manuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
       

        #endregion

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void USER_FRM_Load(object sender, EventArgs e)
        {
            var siUser = new SIUser();
            siUser.ShowListView(ListView1);
        }

        private void NewToolStrip_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, manuItems.UsersManagement, "V", subMenuItems.NewUser, true) ==
                false)
                return;
            var adduser = new ADDUSER_FRM();

        lbl:
            if (adduser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(adduser.txtCode.Text))
                    goto lbl;

                if (string.Compare(adduser.txtPass.Text, adduser.txtConfirm.Text, false) == 0)
                {
                    if (dataManager.Exists("SIPUSERS", adduser.txtCode.Text, "USER_CODE"))
                    {
                        MessageBox.Show("This user code already exists in user management.", "Exist", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        goto lbl;
                    }
                    IControls controls = new Controls();
                    var user = new SIUser();
                    var dateTimes = new DateTimes();
                    SIUser.Code = adduser.txtCode.Text;
                    SIUser.Name = adduser.txtUserName.Text;
                    SIUser.Description = adduser.txtDes.Text;
                    SIUser.Password = System.Text.Encoding.UTF32.GetBytes(adduser.txtPass.Text);
                    SIUser.Description = adduser.txtDes.Text;
                    SIUser.CPAS = (adduser.chbLog.Checked ? 2 : adduser.chbChange.Checked ? 0 : 1);
                    SIUser.UState = (adduser.chbDisable.Checked ? 0 : 1);
                    SIUser.ULog = System.Text.Encoding.UTF32.GetBytes("U");
                    SIUser.CreateDate = dateTimes.Now();
                    string ustrate = adduser.chbDisable.Checked ? "0" : "1";
                    string cPas = adduser.chbLog.Checked ? "2" : adduser.chbChange.Checked ? "0" : "1";

                    var values = new string[]
                                 {
                                     SIUser.Code, SIUser.Name, SIUser.Description, cPas,
                                     ustrate, "Logout"
                                 };
                    user.Save();
                    controls.Add_ListView(ListView1, 6, values);
                }
                else
                {
                    MessageBox.Show("The password was not correctly confirmed.", "Not Correct", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    goto lbl;
                }
            }
            adduser.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToolStrip_Click(sender, e);
        }

        private void EditToolStrip_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, manuItems.UsersManagement, "V", subMenuItems.EditUser, true) ==
                false)
                return;
            ADDUSER_FRM adduserFRM = new ADDUSER_FRM();
            try
            {
                if (ListView1.SelectedItems.Count > 0)
                {
                    adduserFRM.Text = "Edit User";
                    adduserFRM.txtCode.Text = ListView1.SelectedItems[0].Text;
                    adduserFRM.txtCode.Enabled = false;
                    adduserFRM.txtUserName.Text = ListView1.SelectedItems[0].SubItems[1].Text;
                    adduserFRM.chbLog.Checked = (ListView1.SelectedItems[0].SubItems[3].Text == "2" ? true : false);
                    adduserFRM.chbChange.Checked = (ListView1.SelectedItems[0].SubItems[3].Text == "0" ? true : false);
                    adduserFRM.chbDisable.Checked = (ListView1.SelectedItems[0].SubItems[4].Text == "0" ? true : false);
                    adduserFRM.Panel1.Visible = false;
                    adduserFRM.Panel3.Top = 110;
                    adduserFRM.Height = 280;
                    
                    if (adduserFRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        IControls controls = new Controls();
                        var user = new SIUser();
                        var dateTimes = new DateTimes();
                        SIUser.Code = adduserFRM.txtCode.Text;
                        SIUser.Name = adduserFRM.txtUserName.Text;
                        SIUser.Password = System.Text.Encoding.UTF32.GetBytes(adduserFRM.txtPass.Text);
                        SIUser.Description = adduserFRM.txtDes.Text;
                        SIUser.CPAS = (adduserFRM.chbLog.Checked ? 2 : adduserFRM.chbChange.Checked ? 0 : 1);
                        SIUser.UState = (adduserFRM.chbDisable.Checked ? 0 : 1);
                        SIUser.ULog = System.Text.Encoding.UTF32.GetBytes("U");
                        SIUser.CreateDate = dateTimes.Now();
                        string ustrate = adduserFRM.chbDisable.Checked ? "0" : "1";
                        string cPas = adduserFRM.chbLog.Checked ? "2" : adduserFRM.chbChange.Checked ? "0" : "1";

                        var values = new string[]
                                          {
                                              SIUser.Code, SIUser.Name, SIUser.Description, cPas,
                                              ustrate, "Logout"
                                          };
//                        user.Update(values, SIUser.Code);
                        user.Update();
                        controls.Update_ListView(ListView1,values);
                        MessageBox.Show("User was edited successfully", "Successful", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        adduserFRM.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DeleteToolStrip_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, manuItems.UsersManagement, "V", subMenuItems.DeleteUser, true) ==
              false)
                return;
            if (ListView1.SelectedItems.Count > 0)
            {
                if (ListView1.SelectedItems[0].Text != "SISA")
                {
                    MessageBox.Show("This user is and administrator user. You cannot delete this user!", "Delete Fail",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (ListView1.SelectedItems[0].SubItems[5].Text != "Logon")
                    {
                        try
                        {
                            var siUser = new SIUser();
                            siUser.Delete(ListView1.SelectedItems[0].Text);
                            ListView1.Items.RemoveAt(ListView1.SelectedItems[0].Index);
                            MessageBox.Show("The user have been deleted successfully!", "Successful", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            ListView1.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                //TODO: not yet complete 30/09/2009 : and  not testing
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteToolStrip_Click(sender, e);
        }

        private void clearLogedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var siUser = new SIUser();
                if (ListView1.SelectedItems.Count > 0)
                {
                    if (security.CheckPermission(UserLogOn.Code, manuItems.UsersManagement, "V", subMenuItems.ClearLoged, true) ==
              false)
                        return;
                    if (MessageBox.Show("Are you sure you want to clear this user id loged?", "Clear Loged",
                                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        siUser.UpdateClearLoged(System.Text.Encoding.UTF32.GetBytes("U"), ListView1.SelectedItems[0].Text);
                        ListView1.SelectedItems[0].SubItems[5].Text = "Logout";
                        MessageBox.Show("User ID have been successfully cleared!", "Clear Loged", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditToolStrip_Click(sender, e);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var siUser = new SIUser();
                if (allUsersToolStripMenuItem.Checked == true)
                    siUser.ShowListView(ListView1);
                else if (logonToolStripMenuItem.Checked == true)
                    logonToolStripMenuItem_Click(sender, e);
                else
                {
                    logoutToolStripMenuItem_Click(sender,e);
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message,"Error Refresh",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logonToolStripMenuItem.Checked == false)
            {
                var siUser = new SIUser();
                allUsersToolStripMenuItem.Checked = false;
                logonToolStripMenuItem.Checked = true;
                logoutToolStripMenuItem.Checked = false;
                ListView1.Items.Clear();
                var ls = new ListViewItem();
                foreach (DataRow row in siUser.LoadData().Rows)
                {
                    if (System.Text.Encoding.UTF32.GetString((byte[])row[5]).CompareTo("L") == 0)
                    {
                        ls = ListView1.Items.Add(row[0].ToString());
                        ls.SubItems.Add(row[1].ToString());
                        ls.SubItems.Add(row[2].ToString());
                        ls.SubItems.Add(row[3].ToString());
                        ls.SubItems.Add(row[4].ToString());
//                        ls.ImageIndex = 1;
                        ls.SubItems.Add("Logon");
                        ls.Tag = row[2];
                    } 
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logoutToolStripMenuItem.Checked == false)
            {
                allUsersToolStripMenuItem.Checked = false;
                actionToolStripMenuItem.Checked = false;
                logoutToolStripMenuItem.Checked = true;
                ListView1.Items.Clear();
                var ls = new ListViewItem();
                var siUser = new SIUser();
                foreach (DataRow row in siUser.LoadData().Rows)
                {
                    if (System.Text.Encoding.UTF32.GetString((byte[])row[5]).CompareTo("U") == 0)
                    {
                        ls = ListView1.Items.Add(row[0].ToString());
                        ls.SubItems.Add(row[1].ToString());
                        ls.SubItems.Add(row[2].ToString());
                        ls.SubItems.Add(row[3].ToString());
                        ls.SubItems.Add(row[4].ToString());
//                        ls.ImageIndex = 0;
                        ls.SubItems.Add("Logout");
                        ls.Tag = row[2];
                    }
                }
            }
        }

        private void ChangePasswordToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                var adduser_FRM = new ADDUSER_FRM();
                if (security.CheckPermission(UserLogOn.Code, manuItems.GroupsManagement, "V", subMenuItems.ChangePassword, true) ==
              false)
                    return;
                if (ListView1.SelectedItems.Count > 0)
                {
                    adduser_FRM.Text = "Set Password for" + ListView1.SelectedItems[0].SubItems[1].Text;
                    adduser_FRM.txtCode.Text = ListView1.SelectedItems[0].Text;
                    adduser_FRM.txtUserName.Text = ListView1.SelectedItems[0].SubItems[1].Text;
                    adduser_FRM.Panel2.Visible = false;
                    adduser_FRM.Panel3.Visible = false;
                    adduser_FRM.Panel1.Top = 10;
                    adduser_FRM.Height = 180;
                    var siUser = new SIUser();
                    if (adduser_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        SIUser.Password = System.Text.Encoding.UTF32.GetBytes(adduser_FRM.txtPass.Text);
                        siUser.UpdateChangePassword(ListView1.SelectedItems[0].Text);
                        MessageBox.Show("The password has been set.", "User Logon", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    adduser_FRM.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PermissionToolStrip_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, manuItems.GroupsManagement, "V", subMenuItems.ChangePassword, true) ==
            false)
                return;
            if (ListView1.SelectedItems.Count > 0)
            {
                var permission_FRM = new PERMISSION_FRM();
                SIPermissionUser.SELECTED_USERCODE = ListView1.SelectedItems[0].Text;
                permission_FRM.ShowDialog();
                permission_FRM.Close();
//                ==== TODO: ===
//                .SELECTED_USERCODE = ListView1.SelectedItems(0).Text
//                permission_FRM.Close();
            }
        }

        private void permissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermissionToolStrip_Click(sender,e);
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allUsersToolStripMenuItem.Checked == false)
            {
                var siUser = new SIUser();
                allUsersToolStripMenuItem.Checked = true;
                logonToolStripMenuItem.Checked = false;
                logoutToolStripMenuItem.Checked = false;
                siUser.ShowListView(ListView1);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordToolStrip_Click(sender,e);
        }

    }
}
