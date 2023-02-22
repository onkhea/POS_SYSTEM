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
using POS.GUI.Maintains;
using POS.Transaction;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.User
{
    public partial class GROUP_FRM : DevComponents.DotNetBar.Office2007Form
    {
        public GROUP_FRM()
        {
            InitializeComponent();
        }

        #region Global variable

        readonly DataManager dataManager = new DataManager();
        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems  = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        readonly ADDGROUP_FRM addgroup_FRM = new ADDGROUP_FRM();
        readonly DateTimes dateTimes = new DateTimes();
        readonly Controls controls = new Controls();
        #endregion

        private void GROUP_FRM_Load(object sender, EventArgs e)
        {
            var userGroup = new SIUserGroups();
            userGroup.ShowListView(ListView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
//            ====== NOTE: Testing user logon  to
//            UserLogOn.Code = "SISA";
//============================================================
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.GroupsManagement, "V", subMenuItems.NewGroup, true) ==
               false)
                    return;
                addgroup_FRM.cboStatus.SelectedIndex = 0;
            lbl:
                if (addgroup_FRM.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    var userGroup = new SIUserGroups();
                    var value = new string[] { "SI_CODE", addgroup_FRM.txtCode.Text, "SI_TYPE", "GROUP" };
                    if (dataManager.Exists("SIPDATA", value))
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show("Group code already exists!", "Existing", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        goto lbl;
                    }
                    var Val = new string[] { addgroup_FRM.txtCode.Text, "GROUP", addgroup_FRM.cboStatus.Text.Substring(0, 1), addgroup_FRM.txtDes.Text,UserLogOn.Code, dateTimes.Now(), UserLogOn.Code, dateTimes.Now() };
                    userGroup.Save(Val);
                    controls.Add_ListView(ListView1, 3, addgroup_FRM.txtCode.Text, addgroup_FRM.txtDes.Text, addgroup_FRM.cboStatus.Text.Substring(4));
                    Cursor = Cursors.Default;
                }

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void EditToolStrip_Click(object sender, EventArgs e)
        {
//            ================= Note: logonUser ===============
//            UserLogOn.Code = "SISA";

            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.GroupsManagement, "V", subMenuItems.EditGroup, true) ==
             false)
                    return;
                if (ListView1.Items.Count > 0)
                {
                    if (ListView1.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Please select on list");
                        return;
                    }
                    var group = new ADDGROUP_FRM();
                    group.Text = "Edit Group";
                    group.txtCode.Text = ListView1.SelectedItems[0].Text;
                    group.txtCode.Enabled = false;
                    group.txtDes.Text = ListView1.SelectedItems[0].SubItems[1].Text;
                    group.txtDes.Focus();
                    group.cboStatus.Text = ListView1.SelectedItems[0].SubItems[2].Text == "Disable" ? "D - Disable" : "A - Active";
                  

                    if (group.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var userGroup = new SIUserGroups();
                        var fields = new string[]
                             {
                                 "SI_LOOKUP", group.cboStatus.Text.Substring(0,1), "SI_DATA", group.txtDes.Text, "USER_UPDT", UserLogOn.Code, "DATE_UPDT",
                                 dateTimes.Now(),"DATE_CREA", dateTimes.Now()
                             };
                        var condition = new string[] { "SI_CODE", group.txtCode.Text, "SI_TYPE", "GROUP" };
                        userGroup.Update(fields, condition);
                        if (group.cboStatus.Text == "D - Disable")
                            ListView1.SelectedItems[0].ImageIndex = 1;
                        else
                            ListView1.SelectedItems[0].ImageIndex = 0;
                        ListView1.SelectedItems[0].SubItems[1].Text = group.txtDes.Text;
                        ListView1.SelectedItems[0].SubItems[2].Text = group.cboStatus.Text.Substring(4);
                        MessageBox.Show("Group was edited successfully", "Successful", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        group.Close();
//                        addgroup_FRM.Dispose();
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
            try
            {
//                ============= Note: Testing 
//                UserLogOn.Code = "SISA";
//========================================
                if (security.CheckPermission(UserLogOn.Code, menuItems.GroupsManagement, "V", subMenuItems.DeleteGroup, true) ==
            false)
                    return;
                if (ListView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select data on list");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this item ?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    var userGroup = new SIUserGroups();
                    userGroup.Delete(ListView1.SelectedItems[0].Text);
                    ListView1.SelectedItems[0].Remove();
                    MessageBox.Show("Group was deleted successfully!", "Delete", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PermissionToolStrip_Click(object sender, EventArgs e)
        {
           try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.GroupsManagement, "V", subMenuItems.Permission, true) ==
          false)
                    return;
                var permission_FRM = new PERMISSION_FRM();
                if (ListView1.SelectedItems.Count > 0)
                {
                    permission_FRM.TPGroups.Text = "Database";
                    permission_FRM.PanelGroup.Visible = false;
                    SIPermissionUser.SELECTED_USERCODE = ListView1.SelectedItems[0].Text;
                    permission_FRM.ShowDialog();
                    permission_FRM.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender,e);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditToolStrip_Click(sender,e);
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteToolStrip_Click(sender,e);
        }

        private void PermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermissionToolStrip_Click(null,null);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var userGroup = new SIUserGroups();
                userGroup.ShowListView(ListView1);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void AddUserToolStrip_Click(object sender, EventArgs e)
        {
            UserLogOn.Code = "SISA";
            try
            {
              var showinter = new SHOWINTER_FRM();
                if (security.CheckPermission(UserLogOn.Code, menuItems.GroupsManagement, "V", subMenuItems.AddUser, true) ==
          false)
                    return;
                if (ListView1.SelectedItems.Count > 0)
                {
                    showinter.Text = "Select Users";
                    showinter.ListView1.Columns[0].Text = "User Id";
                    showinter.ListView1.Columns[1].Text = "UserName";
                    var userGroup = new SIUserGroups();
                    userGroup.Show_Data_In_List_Of_ShowInter(showinter.ListView1,ListView1);
                    if (showinter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        userGroup.SaveUserGroup(showinter.ListView1,ListView1);
                        foreach (ListViewItem item in showinter.ListView1.CheckedItems)
                        {
                            ListViewItem ITM = ListView2.Items.Add(item.Text);
                            ITM.SubItems.Add(item.SubItems[1].Text);
                        }
                        Cursor = Cursors.Default;
                    }
                }
                showinter.Close();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message + " with INSERT SIPUSERG.");
            }
        }

        private void RemoveToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                UserLogOn.Code = "SISA";
                var showinter = new SHOWINTER_FRM();
                if (security.CheckPermission(UserLogOn.Code, menuItems.GroupsManagement, "V", subMenuItems.RemoveUser, true) ==
          false)
                    return;
                if (ListView2.SelectedItems.Count > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    var userGroup = new SIUserGroups();
                    userGroup.DeleteUserGroup(ListView2,ListView1);
                    ListView2.SelectedItems[0].Remove();
                    MessageBox.Show("This user have been removed successfully!", "Remove", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message + " with DELETE SIPUSERG.");
            }
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connection = new Connection.Connection();
            var cont = new Controls();
            try
            {
                Cursor = Cursors.WaitCursor;
                if (ListView1.SelectedItems.Count > 0)
                {
                    EditToolStripMenuItem.Enabled = true;
                    PermissionToolStrip.Enabled = true;
                    DeleteToolStripMenuItem1.Enabled = true;
                    PermissionToolStripMenuItem.Enabled = true;
                    ListView2.Items.Clear();
                    var command =
                        new SqlCommand(
                            "SELECT USER_CODE,(SELECT USER_NAME FROM SIPUSERS WHERE SIPUSERS.USER_CODE=SIPUSERG.USER_CODE) USER_NAME FROM SIPUSERG WHERE GR_DB_CODE=@GR_DB_CODE AND PER_TYPE='G'",
                            connection.Connect());
                    command.Parameters.AddWithValue("@GR_DB_CODE", ListView1.SelectedItems[0].Text);
                    var dataAdapter = new SqlDataAdapter(command);
                    var dt = new DataTable();
                    dataAdapter.Fill(dt);
                    cont.Add_ListView(dt,ListView2);
                }
                else
                {
                    EditToolStripMenuItem.Enabled = false;
                    DeleteToolStripMenuItem1.Enabled = false;
                    PermissionToolStripMenuItem.Enabled = false;
                    PermissionToolStrip.Enabled = false;
                    ListView2.Items.Clear();
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }
    }
}

