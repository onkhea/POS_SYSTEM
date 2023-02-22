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
    public partial class PERMISSION_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public PERMISSION_FRM()
        {
            InitializeComponent();
        }

        readonly SIPermissionUser usersGroup = new SIPermissionUser();
        readonly Controls controls = new Controls();
        DataManager _dataManager = new DataManager();
        Connection.Connection connection = new Connection.Connection();
        SIMenuItems menuItems = new SIMenuItems();
        SISubMenuItems subMenuItems = new SISubMenuItems();

        private string PERTYPEDET;

        public string PERTYPEDET_
        {
            get { return PERTYPEDET; }
        }

        private void PERMISSION_FRM_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                lvwGroup.Items.Clear();
                if (UserLogOn.Code != "SISA")
                    usersGroup.ShowListViewSISA(lvwGroup);
                else
                    usersGroup.ShowListView(lvwGroup);

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Group

        private void btnAddG_Click(object sender, EventArgs e)
        {
            var showinter_FRM = new SHOWINTER_FRM();
            try
            {
                showinter_FRM = new SHOWINTER_FRM { Text = "Select Groups" };
                showinter_FRM.ListView1.Columns[0].Text = "Group Code";
                showinter_FRM.ListView1.Columns[1].Text = "Description";
                var command = new SqlCommand("SELECT SI_CODE,RTRIM(SUBSTRING(SI_DATA,1,50)) FROM SIPDATA WHERE SI_TYPE='GROUP' AND SI_CODE NOT IN(SELECT GR_DB_CODE FROM SIPUSERG WHERE PER_TYPE='G' AND USER_CODE='" + UserLogOn.Code + "') ORDER BY 1", connection.Connect());
                var dtUser = _dataManager.GetData(command);
                controls.Add_ListView(dtUser, showinter_FRM.ListView1);
                if (showinter_FRM.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    foreach (ListViewItem items in showinter_FRM.ListView1.CheckedItems)
                    {
                        var ITM = new ListViewItem();
                        ITM = lvwGroup.Items.Add(items.Text);
                        ITM.SubItems.Add(items.SubItems[1].Text);
                    }
                    usersGroup.SaveUserGroup(showinter_FRM.ListView1);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message + " with INSERT SIPUSERG.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            
            showinter_FRM.Close();
           
        }

        private void btnRemoveG_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwGroup.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to apply any changes?", "Apply Change", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cursor = Cursors.WaitCursor;
                        foreach (ListViewItem item in lvwGroup.SelectedItems)
                        {
                            item.Remove();
                            SIPermissionUser.GR_DB_CODE = item.Text;
                            usersGroup.DeleteUserGroup();
                        }
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message + " with delete SIPUSERG.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        #endregion

        #region System

        private void btnApplySystem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                usersGroup.DeleteUserPermission();
                usersGroup.SaveUserPermission(SYSTEMLVWDETAIL);
                btnApplySystem.Enabled = false;
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in SYSTEMLVWMAIN.Items)
            {
                if (item.Checked != CheckBox5.Checked)
                {
                    item.Checked = CheckBox5.Checked;
                }
            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in SYSTEMLVWMAIN.Items)
            {
                    item.Checked = CheckBox7.Checked;
            }
        }

        private void SYSTEMLVWDETAIL_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (SIPermissionUser.Action_Check)
            {
                btnApplySystem.Enabled = true;
                SIPermissionUser.Action_Check = false;
            }
        }

        private void SYSTEMLVWMAIN_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (SIPermissionUser.Show_SYSTEM)
            {
                SIPermissionUser.Show_SYSTEM = false;
                return;
            }
            Cursor = Cursors.WaitCursor;
            usersGroup.LVWMainOnEachTab(e);
            Cursor = Cursors.Default;
        }

        private void SYSTEMLVWMAIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (btnApplySystem.Enabled)
                {
                    if (MessageBox.Show("Are you sure you want to apply any changes?","Apply Change",MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        btnApplySystem_Click(null,null);
                    }
                }
                Cursor = Cursors.WaitCursor;
                SIPermissionUser.Action_Check = false;
                btnApplySystem.Enabled = false;
                SYSTEMLVWDETAIL.Items.Clear();
                SYSTEMLVWDETAIL.Groups.Clear();
                var lvItem = new ListViewItem();
                lvItem = null;
                var lvGroup = new ListViewGroup();
                lvGroup = null;
                var is_Selected = false;
                foreach (ListViewItem lvwItem in SYSTEMLVWMAIN.Items)
                {
                    if (lvwItem.Selected == true)
                    {
                        lvItem = lvwItem;
                        is_Selected = true;
                        break;
                    }  
                }
                if (is_Selected == false)
                {
                    Cursor = Cursors.Default;
                    return;
                }
                var menuItems = new SIMenuItems();
                SIPermissionUser.GR_DB_CODE = lvItem.Text;
                SIPermissionUser.PER_TYPE = "V";
                switch (SIPermissionUser.GR_DB_CODE)
                {
                    case "Groups Management":
                        PERTYPEDET = "GRPMA";
                        lvGroup = SYSTEMLVWDETAIL.Groups.Add("KO", "General");
                        controls.AddItemToLVGroup(SYSTEMLVWDETAIL,lvGroup,"New Group","Edit Group","Delete Group","Permission","Add User","Remove User");
                        break;
                    case "Users Management":
                        PERTYPEDET = "URSMA";
                        lvGroup = SYSTEMLVWDETAIL.Groups.Add("KO", "General");
                        controls.AddItemToLVGroup(SYSTEMLVWDETAIL, lvGroup, "New User", "Edit User", "Delete User","Change Password", "Permission", "Clear Loged");
                        break;
                }
                SIPermissionUser.Action_Check = true;
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Transaction

        private void chkAll1_CheckedChanged(object sender, EventArgs e)
        {
            if (TRANSLVWMAIN.Items.Count > 0)
            {
                foreach (ListViewItem item in TRANSLVWMAIN.Items)
                {
                    item.Checked = chkAll1.Checked;
                }
            }
        }

        private void chkAll2_CheckedChanged(object sender, EventArgs e)
        {
            if (TRANSLVWDETAIL.Items.Count > 0)
            {
                foreach (ListViewItem item in TRANSLVWDETAIL.Items)
                {
                    item.Checked = chkAll2.Checked;
                }
            }
        }

        private void TRANSLVWMAIN_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                if (SIPermissionUser.Show_SYSTEM == true)
                {
                    SIPermissionUser.Show_SYSTEM = false;
                    return;
                }
                Cursor = Cursors.WaitCursor;
                usersGroup.LVWMainOnEachTab(e);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void TRANSLVWDETAIL_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (SIPermissionUser.Action_Check == true)
            {
                btnApplyTransaction.Enabled = true;
                SIPermissionUser.Action_Check = false;
            }
        }

        private void TRANSLVWMAIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (btnApplyTransaction.Enabled == true)
                {
                    if (MessageBox.Show("Are you sure you want to apply any changes?","Changed",MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
                    {
                        btnApplyTransaction_Click(null,null);
                    }
                }
                Cursor = Cursors.WaitCursor;
                SIPermissionUser.Action_Check = false;
                btnApplyTransaction.Enabled = false;
                TRANSLVWDETAIL.Items.Clear();
                TRANSLVWDETAIL.Groups.Clear();
                bool is_Selected = false;
                var lvwItem = new ListViewItem();
                var lvGroup = new ListViewGroup();
                foreach (ListViewItem item in TRANSLVWMAIN.Items)
                {
                    if (item.Selected == true)
                    {
                        lvwItem.Text = item.Text;
                        is_Selected = true;
                        break;
                    }
                }
                if (is_Selected == false)
                {
                    Cursor = Cursors.Default;
                    return;
                }
                SIPermissionUser.GR_DB_CODE = lvwItem.Text;
                SIPermissionUser.PER_TYPE = "V";

                #region Switch listview
                switch (lvwItem.Text)
                {

                    #region Purchase Processing

                    case "Purchase Order" :
                        PERTYPEDET = "PUROR";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL,lvGroup,"Hold","Release");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K1", "View");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL,lvGroup,"Purchase Order");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Add New Line", " Edit Line", "Remove Line");
                        break;
                    case "Purchase Matching":
                        PERTYPEDET = "PURMA";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Release");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K1", "View");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Purchase Order");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Actions");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Split Line", " Cancel Line");
                        break;
//                    case "Purchase Invoice":
//                        PERTYPEDET = "PURIN";
//                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
//                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Hold Invoice", "Release Invoice","Post Invoice");
//                        lvGroup = TRANSLVWDETAIL.Groups.Add("K1", "View");
//                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "View Purchase Order");
//                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Actions");
//                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Add New Line", " Edit Line", "Remove Line");
//                        break;
//                    case "Void Purchase Invoice":
//                        PERTYPEDET = "VOIPI";
//                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
//                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Search Data");
//                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Actions");
//                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Void");
//                        break;
                    case "Debit Note":
                        PERTYPEDET = "DETNO";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Post Debit Note","Print Debit Note");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K1", "View");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Purchase Invoice");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Actions");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Split Line");
                        break;
                    #endregion
                        
                    case "Sales Order":
                        PERTYPEDET = "SALOR";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Hold","Release");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K1", "View");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Transaction Order", "Print Sale Order", "Print Invoice");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Actions");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Remove Line","Invoice Options");
                        break;
                   
                    #region Inventory Control

                    case "Stock Adjustment":
                        PERTYPEDET = "STOCKA";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, subMenuItems.HeldBatch , subMenuItems.PostBatch);
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K1", "View");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, subMenuItems.HeldMovement);
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Actions");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, subMenuItems.NewLine, subMenuItems.EditLine, subMenuItems.DeleteLine);
                        break;
                    case "Movement Entry":
                        PERTYPEDET = "MOVEN";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, subMenuItems.HeldBatch, subMenuItems.PostBatch);
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K1", "View");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, subMenuItems.HeldMovement);
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Actions");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, subMenuItems.NewLine,subMenuItems.EditLine,subMenuItems.DeleteLine);
                        break;
                    case "Inventory Balance":
                        PERTYPEDET = "INTBA";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Export Data to Excel");
                        break;

                    #endregion

                    #region Sale Processing

                    case "Credit Note":
                        PERTYPEDET = "CRDNO";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Post");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K1", "View");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Sales Invoice");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Actions");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Split Line");
                        break;
//                    case "Sales Type Definition":
//                        PERTYPEDET = "SALTD";
//                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
//                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Delete Line", "Export Data to Excel", "Search Data");
//                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
//                        controls.AddItemToLVGroup(TRANSLVWDETAIL, lvGroup, "Clone Line", " Import Data", "Export Data", "Auto Number Format");
//                        break;

                    #endregion

                    #region Point Of Sale
                    case "Barcode" :
                        PERTYPEDET = "BARCD";
                        break;
                    case "Exchange Rate":
                        PERTYPEDET = "EXCHR";
                        break;
                    case "Setup Customer In POS":
                        PERTYPEDET = "CUSPOS";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL,lvGroup,"New Line","Edit Line", "Delete Line");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K1", "Tools");
                        controls.AddItemToLVGroup(TRANSLVWDETAIL,lvGroup,
                            "Clone Line");
                        break;
                    #endregion
                    //                        ====Note: not yet complete
                }

                    #endregion
                //                == check tick value from DB
                _dataManager = new DataManager();
                if (TRANSLVWDETAIL.Items.Count > 0)
                {
                    foreach (ListViewItem item in TRANSLVWDETAIL.Items)
                    {
                        var str = new string[]
                                      {
                                          "USER_CODE", SIPermissionUser.SELECTED_USERCODE, "GR_DB_CODE",
                                          SIPermissionUser.GR_DB_CODE, "PER_TYPE", SIPermissionUser.PER_TYPE, "PER_ACTION",
                                          item.Text
                                      };
                        if (_dataManager.Exists("SIPUSERP", str))
                            item.Checked = true;
                        else
                            item.Checked = false;
                    }
                    SIPermissionUser.Action_Check = true;
                   
                }
                Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnApplyTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                usersGroup.DeleteUserPermission();
                usersGroup.SaveUserPermission(TRANSLVWDETAIL);
                btnApplyTransaction.Enabled = false;
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region Maintains

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MAITAINSLVWMAIN.Items)
            {
                if (item.Checked != CheckBox3.Checked)
                {
                    item.Checked = CheckBox3.Checked;
                }
            }
        }

        private void chbMaintains_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MAITAINSLVWDETAIL.Items)
            {
                item.Checked = chbMaintains.Checked;
            }
        }

        private void MAITAINSLVWMAIN_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                if (SIPermissionUser.Show_SYSTEM == true)
                {
                    SIPermissionUser.Show_SYSTEM = false;
                    return;
                }
                Cursor = Cursors.WaitCursor;
                usersGroup.LVWMainOnEachTab(e);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
            

        }

        private void MAITAINSLVWDETAIL_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (SIPermissionUser.Action_Check == true)
            {
                btnApplyMaintains.Enabled = true;
                SIPermissionUser.Action_Check = false;
            }

        }

        private void MAITAINSLVWMAIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (btnApplyMaintains.Enabled == true)
                {
                    if (MessageBox.Show("Are you sure you want to apply any changes?", "Changed", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        btnApplyMaintains_Click(null, null);
                    }
                }
                Cursor = Cursors.WaitCursor;
                SIPermissionUser.Action_Check = false;
                MAITAINSLVWDETAIL.Items.Clear();
                MAITAINSLVWDETAIL.Groups.Clear();

                var lvItem = new ListViewItem();
                var lvGroup = new ListViewGroup();
                bool is_Select = false;
                foreach (ListViewItem item in MAITAINSLVWMAIN.Items)
                {
                    if (item.Selected)
                    {
                        lvItem = item;
                        is_Select = true;
                     break;  
                    }
                    
                }
                if (is_Select == false)
                {
                    Cursor = Cursors.Default;
                    return;
                }
                SIPermissionUser.GR_DB_CODE = lvItem.Text;
                SIPermissionUser.PER_TYPE = "V";

                #region Switch ListView

                switch (lvItem.Text)
                {
                    #region Maintain
                    case "Locations":
                        PERTYPEDET = "LOCAT";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Delete Line", "Export Data to Excel", "Search Data");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line", "Import Data", "Export Data");
                        break;

                    #region Item Setup

                    case "Unit Conversion":
                        PERTYPEDET = "UNITC";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "New Line", subMenuItems.EditUnitConvert, subMenuItems.DeleteUnitConvert, subMenuItems.ExportDatatoExcel, subMenuItems.SearchData);
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line", "Import Data", "Export Data");
                        break;
                    case "Item Category":
                        PERTYPEDET = "ITEMC";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, subMenuItems.NewLine, subMenuItems.EditLine, "Delete Line", subMenuItems.ExportDatatoExcel, subMenuItems.SearchData);
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line", "Import Data", "Export Data");
                        break;
                    case "Item Record":
                        PERTYPEDET = "ITEMR";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Delete Line", "Export Data to Excel", "Search Data");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line");
                        break;
                    case "Item Price":
                        PERTYPEDET = "ITMPL";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Delete Line", "Export Data to Excel", "Search Data");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line", "Import Data", "Export Data");
                        break;
                    case "Item Promotion":
                        PERTYPEDET = "ITMPT";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Delete Line", "Export Data to Excel", "Search Data");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line", "Import Data", "Export Data");
                        break;

                    #endregion

                    #region Supplier
                    case "Supplier Setup":
                        PERTYPEDET = "SUPDE";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Delete Line", "Export Data to Excel", "Search Data");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line", "Import Data", "Export Data");
                        break;
                    case "Deliveries Supplier":
                        PERTYPEDET = "SUPRE";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Delete Line");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line", "Import Data", "Export Data");
                        break;
                    #endregion

                    #region Customer
                    case "Deliveries Customer":
                        PERTYPEDET = "CUSDE";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Delete Line", "Export Data to Excel", "Search Data");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line", "Import Data", "Export Data");
                        break;
                    case "Customer Setup":
                        PERTYPEDET = "CUSRE";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Delete Line");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line");
                        break;
                    #endregion

                    case "Employee Setup":
                        PERTYPEDET = "EMPDE";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "New Line", "Edit Line", "Delete Line", "Export Data to Excel", "Search Data");
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K2", "Tools");
                        controls.AddItemToLVGroup(MAITAINSLVWDETAIL, lvGroup, "Clone Line", "Export Data");
                        break;
                    #region Design Report
                    case "Design Report":
                        PERTYPEDET = "DESRE";
                        break;
                    #endregion

                    #region Options
                    case "Options":
                        PERTYPEDET = "OPTN";
                        break;
                    #endregion

                    #endregion

                }
                #endregion

                var dataManager = new DataManager();
                //=========== check Tick Value From DB ============
                if (MAITAINSLVWDETAIL.Items.Count > 0)
                {
                    foreach (ListViewItem item in MAITAINSLVWDETAIL.Items)
                    {
                        var str = new string[]
                                      {
                                          "USER_CODE", SIPermissionUser.SELECTED_USERCODE, "GR_DB_CODE",
                                          SIPermissionUser.GR_DB_CODE, "PER_TYPE", SIPermissionUser.PER_TYPE, "PER_ACTION",
                                          item.Text
                                      };

                        if (dataManager.Exists("SIPUSERP", str))
                            item.Checked = true;
                        else
                            item.Checked = false;

                        SIPermissionUser.Action_Check = true;
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnApplyMaintains_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                usersGroup.DeleteUserPermission();
                usersGroup.SaveUserPermission(MAITAINSLVWDETAIL);
                btnApplyMaintains.Enabled = false;
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TabGrant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                // first_load = false;
                var tab = TabGrant.TabPages[TabGrant.SelectedIndex];
                var lv = new ListView();
                switch (tab.Text)
                {

                    case "Groups":
                        lv = lvwGroup;
                        break;
                    case "System":
                        lv = SYSTEMLVWMAIN;
                        break;
                    case "Maintains":
                        lv = MAITAINSLVWMAIN;
                        break;
                    case "Transaction":
                        lv = TRANSLVWMAIN;
                        break;
                    case "Reports":
                        lv = REPORTLVWMAIN;
                        break;
                }
                if (lv.Items.Count != 0)
                {
                    foreach (ListViewItem item in lv.Items)
                    {
                        SIPermissionUser.Show_SYSTEM = true;
                        if (_dataManager.Exists("SIPUSERG", "USER_CODE", SIPermissionUser.SELECTED_USERCODE, "GR_DB_CODE", item.Text, "PER_TYPE", "V"))
                        {
                            item.Checked = true; 
                        }
                        else
                        {
                            item.Checked = false;
                        }
                        var dd = SIPermissionUser.SELECTED_USERCODE;
                        if (_dataManager.Exists("SIPUSERP", "USER_CODE", SIPermissionUser.SELECTED_USERCODE, "GR_DB_CODE", item.Text, "PER_TYPE", "V"))
                        {
                            item.Font = new Font(item.Font.Name,item.Font.Size,FontStyle.Bold);
                        }
                    }
                }
                SIPermissionUser.Show_SYSTEM = false;

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
         
        }

        private void REPORTLVWMAIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (btnApplyReport.Enabled == true)
                {
                    if (MessageBox.Show("Are you sure you want to apply any changes?", "Changed", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        btnApplyReport_Click(null, null);
                    }
                }
                Cursor = Cursors.WaitCursor;
                SIPermissionUser.Action_Check = false;
                lvwREPORTDETAIL.Items.Clear();
                lvwREPORTDETAIL.Groups.Clear();

                var lvItem = new ListViewItem();
                var lvGroup = new ListViewGroup();
                bool is_Select = false;
                foreach (ListViewItem item in REPORTLVWMAIN.Items)
                {
                    if (item.Selected)
                    {
                        lvItem = item;
                        is_Select = true;
                        break;
                    }

                }
                if (is_Select == false)
                {
                    Cursor = Cursors.Default;
                    return;
                }
                SIPermissionUser.GR_DB_CODE = lvItem.Text;
                SIPermissionUser.PER_TYPE = "V";

                #region Switch ListView

                switch (lvItem.Text)
                {
                    #region Reports
                    case "Purchase Listing":
                        PERTYPEDET = "PUSLI";
                        lvGroup = lvwREPORTDETAIL.Groups.Add("K0", "General");
                        var dt = _dataManager.GetData("select REP_CODE from SIREPORT WHERE REP_TYPE = 'Purchase Listing'");
                       
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            controls.AddItemToLVGroup(lvwREPORTDETAIL, lvGroup, dt.Rows[i][0].ToString());    
                        }
                        break;
                    case "Supplier Listing":
                        PERTYPEDET = "SUPLI";
                        lvGroup = lvwREPORTDETAIL.Groups.Add("K0", "General");
                        dt = _dataManager.GetData("select REP_CODE from SIREPORT WHERE REP_TYPE = 'Supplier Listing'");

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            controls.AddItemToLVGroup(lvwREPORTDETAIL, lvGroup, dt.Rows[i][0].ToString());
                        }
                        break;
                    case "Sale Listing":
                        PERTYPEDET = "SALLI";
                        lvGroup = lvwREPORTDETAIL.Groups.Add("K0", "General");
                        dt = _dataManager.GetData("select REP_CODE from SIREPORT WHERE REP_TYPE = 'Sale Listing'");

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            controls.AddItemToLVGroup(lvwREPORTDETAIL, lvGroup, dt.Rows[i][0].ToString());
                        }
                        break;
                    case "Customer Listing":
                        PERTYPEDET = "CUSLI";
                        lvGroup = lvwREPORTDETAIL.Groups.Add("K0", "General");
                        dt = _dataManager.GetData("select REP_CODE from SIREPORT WHERE REP_TYPE = 'Customer Listing'");

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            controls.AddItemToLVGroup(lvwREPORTDETAIL, lvGroup, dt.Rows[i][0].ToString());
                        }
                        break;
                    case "Print Barcode":
                        PERTYPEDET = "PBCODE";
                        lvGroup = lvwREPORTDETAIL.Groups.Add("K0", "General");
                        dt = _dataManager.GetData("select REP_CODE from SIREPORT WHERE REP_TYPE = 'Print Barcode'");

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            controls.AddItemToLVGroup(lvwREPORTDETAIL, lvGroup, dt.Rows[i][0].ToString());
                        }
                        break;
                    case "Movement Listing":
                        PERTYPEDET = "MOVLI";
                        lvGroup = lvwREPORTDETAIL.Groups.Add("K0", "General");
                        dt = _dataManager.GetData("select REP_CODE from SIREPORT WHERE REP_TYPE = 'Movement Listing'");

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            controls.AddItemToLVGroup(lvwREPORTDETAIL, lvGroup, dt.Rows[i][0].ToString());
                        }
                        break;
                    case"Inventory Listing":
                        PERTYPEDET = "INVLI";
                        lvGroup = lvwREPORTDETAIL.Groups.Add("K0", "General");
                        dt = _dataManager.GetData("select REP_CODE from SIREPORT WHERE REP_TYPE = 'Inventory Listing'");

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            controls.AddItemToLVGroup(lvwREPORTDETAIL, lvGroup, dt.Rows[i][0].ToString());
                        }
                        break;

                    case"Inventory Movement":
                        PERTYPEDET = "INVMO";
                        lvGroup = lvwREPORTDETAIL.Groups.Add("K0", "General");
                        dt = _dataManager.GetData("select REP_CODE from SIREPORT WHERE REP_TYPE = 'Inventory Movement'");

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            controls.AddItemToLVGroup(lvwREPORTDETAIL, lvGroup, dt.Rows[i][0].ToString());
                        }
                        break;
                    case "Inventory Transfer":
                        PERTYPEDET = "INVTR";
                        lvGroup = lvwREPORTDETAIL.Groups.Add("K0", "General");
                        dt = _dataManager.GetData("select REP_CODE from SIREPORT WHERE REP_TYPE = 'Inventory Transfer'");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            controls.AddItemToLVGroup(lvwREPORTDETAIL, lvGroup, dt.Rows[i][0].ToString());
                        }
                        break;
                    case "Setup Customer In POS":
                        PERTYPEDET = "CUSPOS";
                        lvGroup = TRANSLVWDETAIL.Groups.Add("K0", "General");
                        dt = _dataManager.GetData("select REP_CODE from SIREPORT WHERE REP_TYPE = 'Setup Customer In POS'");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            controls.AddItemToLVGroup(lvwREPORTDETAIL, lvGroup, dt.Rows[i][0].ToString());
                        }
                        break;

                   #endregion

                }
                #endregion

                var dataManager = new DataManager();
                //=========== check Tick Value From DB ============
                if (lvwREPORTDETAIL.Items.Count > 0)
                {
                    foreach (ListViewItem item in lvwREPORTDETAIL.Items)
                    {
                        var str = new string[]
                                      {
                                          "USER_CODE", SIPermissionUser.SELECTED_USERCODE, "GR_DB_CODE",
                                          SIPermissionUser.GR_DB_CODE, "PER_TYPE", SIPermissionUser.PER_TYPE, "PER_ACTION",
                                          item.Text
                                      };

                        if (dataManager.Exists("SIPUSERP", str))
                            item.Checked = true;
                        else
                            item.Checked = false;

                        SIPermissionUser.Action_Check = true;
                        Cursor = Cursors.Default;
                    }
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnApplyReport_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                usersGroup.DeleteUserPermission();
                usersGroup.SaveUserPermission(lvwREPORTDETAIL);
                btnApplyReport.Enabled = false;
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void REPORTLVWMAIN_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                if (SIPermissionUser.Show_SYSTEM == true)
                {
                    SIPermissionUser.Show_SYSTEM = false;
                    return;
                }
                Cursor = Cursors.WaitCursor;
                usersGroup.LVWMainOnEachTab(e);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvwREPORTDETAIL_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (SIPermissionUser.Action_Check == true)
            {
                btnApplyReport.Enabled = true;
                SIPermissionUser.Action_Check = false;
            }
        }

       
    }
}
