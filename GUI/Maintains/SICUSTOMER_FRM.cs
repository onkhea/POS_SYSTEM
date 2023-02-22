using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction;
using POS.Transaction.Maintains;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class SICUSTOMER_FRM : DevComponents.DotNetBar.Office2007Form
    {
        public SICUSTOMER_FRM()
        {
            InitializeComponent();
        }

        private readonly OutLook outLook = new OutLook();
        readonly SICustomer customer = new SICustomer();
        private string STRTMP = "";
        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
// ReSharper disable FieldCanBeMadeReadOnly
        DateTimes dateTimes = new DateTimes();
// ReSharper restore FieldCanBeMadeReadOnly
        readonly Controls controls = new Controls();
        readonly DataManager dataManager = new DataManager();
        private readonly List<string> Clone = new List<string>();
        readonly Connection.Connection connection = new Connection.Connection();
        private void SICUSTOMER_FRM_Load(object sender, EventArgs e)
        {

            outLook.showDGV(DataGridView1, customer.LoadData(), "ADD_STAT");
            outLook.loadSearch(DataGridView1, customer.LoadData(), "ADD_CODE", ListView1, ContextMenuStrip2, ToolStrip2,
                               SplitContainer1, SearchPanel);
        }

        #region Toolstrip1

        private void ExcelTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Customer, "V", subMenuItems.ExportDatatoExcel, true) ==
         false)
                return;
            
            if (ExcelTool.Checked == false)
            {
                ExcelTool.Checked = true;
                ExportToolStripMenuItem1.Checked = true;
                ExcelPanel.Visible = true;
                if (SearchTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = false;
                }
            }
            else
            {
                ExcelTool.Checked = false;
                ExportToolStripMenuItem1.Checked = false;
                ExcelPanel.Visible = false;
                if (SearchTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = true;
                }
            }
        }

        private void SearchTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Customer, "V", subMenuItems.SearchData, true) ==
        false)
                return;
            if (SearchTool.Checked == false)
            {
                SearchTool.Checked = true;
                SearchToolStripMenuItem.Checked = true;
                SearchPanel.Visible = true;
                Label5.Visible = true;
                if (ExcelTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = false;
                }
            }
            else
            {
                outLook.showDGV(DataGridView1, customer.LoadData(), "ADD_STAT");
                DefaultAllToolStripMenuItem.Checked = true;
                ActiveToolStripMenuItem.Checked = false;
                DisabledToolStripMenuItem.Checked = false;
                SearchTool.Checked = false;
                SearchToolStripMenuItem.Checked = false;
                SearchPanel.Visible = false;
                Label5.Visible = false;

                if (ExcelTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = true;
                }
                Cursor = Cursors.Default;
            }
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Customer, "V", subMenuItems.NewLine, true) ==
           false)
                    return;
                var addcustomer_FRM = new ADDCUSTOMER_FRM();
                addcustomer_FRM.Text = "New Customer";
                addcustomer_FRM.cboStatus.Text = "A - Active";
                if (addcustomer_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                   
                    var value = new[]
                                    {
                                        addcustomer_FRM.txtCode.Text, addcustomer_FRM.txtLookup.Text,
                                        addcustomer_FRM.txtName.Text, addcustomer_FRM.txtadd1.Text,
                                        addcustomer_FRM.txtadd2.Text, addcustomer_FRM.txtadd3.Text,
                                        addcustomer_FRM.txtadd4.Text, addcustomer_FRM.txtadd5.Text,
                                        addcustomer_FRM.txttel.Text, addcustomer_FRM.txtfax.Text,
                                        addcustomer_FRM.txtemail.Text, addcustomer_FRM.txtweb.Text,
                                        addcustomer_FRM.txtContName.Text, addcustomer_FRM.txtCom1.Text,
                                        addcustomer_FRM.txtCom2.Text, addcustomer_FRM.cboStatus.Text.Substring(0,1), "0", "N",
                                        dateTimes.Now(), dateTimes.Now(),UserLogOn.Code
                                    };
                    customer.Save(value);
                    var val = new[]
                                  {
                                      addcustomer_FRM.txtCode.Text, addcustomer_FRM.txtLookup.Text,
                                      addcustomer_FRM.txtName.Text, addcustomer_FRM.txtadd1.Text,
                                      addcustomer_FRM.txtadd2.Text, addcustomer_FRM.txtadd3.Text,
                                      addcustomer_FRM.txtadd4.Text, addcustomer_FRM.txtadd5.Text,
                                      addcustomer_FRM.txttel.Text, addcustomer_FRM.txtfax.Text,
                                      addcustomer_FRM.txtemail.Text, addcustomer_FRM.txtweb.Text,
                                      addcustomer_FRM.txtContName.Text, addcustomer_FRM.txtCom1.Text,
                                      addcustomer_FRM.txtCom2.Text,
                                      addcustomer_FRM.cboStatus.Text.Substring(4, addcustomer_FRM.cboStatus.Text.Length - 4)
                                      , "0", "N", dateTimes.Now(), dateTimes.Now(), UserLogOn.Code
                                  };
                    controls.AddToDataGridView(DataGridView1,val);
                    var i = DataGridView1.Rows.Count - 1;
                    outLook.ChangeColorOnDisabledAndActive(DataGridView1,addcustomer_FRM.cboStatus.Text,i);
                    MessageBox.Show("Record have been created!","Already Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                    
                }
                addcustomer_FRM.Close();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.WaitCursor;
                MessageBox.Show(ex.Message);
            }
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Customer, "V", subMenuItems.EditLine, true) ==
           false)
                    return;
                Cursor = Cursors.WaitCursor;
                var addcustomer_FRM = new ADDCUSTOMER_FRM();
                addcustomer_FRM.Text = "Edit Customer Information";
                addcustomer_FRM.txtCode.Text = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var val = new string[]
                              {
                                  "ADD_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), "ADD_TYPE", "0",
                                  "TRANS_PRES", "Y"
                              };
                if (dataManager.Exists("SIPADDR",val))
                {
                    addcustomer_FRM.txtCode.Enabled = false; 
                }
                addcustomer_FRM.txtCode.Enabled = false;
                addcustomer_FRM.txtLookup.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    addcustomer_FRM.txtName.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    addcustomer_FRM.txtadd1.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    addcustomer_FRM.txtadd2.Text = DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    addcustomer_FRM.txtadd3.Text = DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    addcustomer_FRM.txtadd4.Text = DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    addcustomer_FRM.txtadd5.Text = DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    addcustomer_FRM.txttel.Text = DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    addcustomer_FRM.txtfax.Text = DataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                    addcustomer_FRM.txtemail.Text = DataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                    addcustomer_FRM.txtweb.Text = DataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                    addcustomer_FRM.txtContName.Text = DataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                    addcustomer_FRM.txtCom1.Text = DataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                    addcustomer_FRM.txtCom2.Text = DataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                addcustomer_FRM.cboStatus.Text =
                    DataGridView1.SelectedRows[0].Cells[15].Value.ToString().Substring(0, 1) + " - " +
                    DataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                SITempData.Code = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (addcustomer_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var values = new[]
                                     {
                                         "ADD_LOOKUP", addcustomer_FRM.txtLookup.Text, "ADD_NAME",
                                         addcustomer_FRM.txtName.Text, "ADD_LINE_1", addcustomer_FRM.txtadd1.Text,
                                         "ADD_LINE_2", addcustomer_FRM.txtadd2.Text, "ADD_LINE_3",
                                         addcustomer_FRM.txtadd3.Text, "ADD_LINE_4", addcustomer_FRM.txtadd4.Text,
                                         "ADD_LINE_5", addcustomer_FRM.txtadd5.Text, "ADD_TEL",
                                         addcustomer_FRM.txttel.Text
                                         , "ADD_FAX", addcustomer_FRM.txtfax.Text, "ADD_EMAIL",
                                         addcustomer_FRM.txtemail.Text, "ADD_WEB", addcustomer_FRM.txtweb.Text,
                                         "ADD_CONT", addcustomer_FRM.txtContName.Text, "ADD_COM_1",
                                         addcustomer_FRM.txtCom1.Text, "ADD_COM_2", addcustomer_FRM.txtCom2.Text,
                                         "ADD_STAT", addcustomer_FRM.cboStatus.Text.Substring(0,1), "TRANS_PRES", "N",
                                         "USER_CODE", UserLogOn.Code, "USER_UPDT", dateTimes.Now()
                                     };
                    var condition = new string[] {"ADD_CODE", addcustomer_FRM.txtCode.Text, "ADD_TYPE", "0"};
                    customer.Update(values, condition);
                    var vals = new[]
                                   {
                                       addcustomer_FRM.txtCode.Text, addcustomer_FRM.txtLookup.Text,
                                       addcustomer_FRM.txtName.Text, addcustomer_FRM.txtadd1.Text,
                                       addcustomer_FRM.txtadd2.Text, addcustomer_FRM.txtadd3.Text,
                                       addcustomer_FRM.txtadd4.Text, addcustomer_FRM.txtadd5.Text,
                                       addcustomer_FRM.txttel.Text, addcustomer_FRM.txtfax.Text,
                                       addcustomer_FRM.txtemail.Text, addcustomer_FRM.txtweb.Text,
                                       addcustomer_FRM.txtContName.Text, addcustomer_FRM.txtCom1.Text,
                                       addcustomer_FRM.txtCom2.Text,
                                       addcustomer_FRM.cboStatus.Text.Substring(4,
                                                                                addcustomer_FRM.cboStatus.Text.Length -
                                                                                4),
                                       "0", DataGridView1.SelectedRows[0].Cells[18].Value.ToString(),
                                       DataGridView1.SelectedRows[0].Cells[19].Value.ToString(), dateTimes.Now(),
                                       UserLogOn.Code
                                   };

                    controls.UpdateDataToGridView(DataGridView1, vals);
                    outLook.Change_Color_On_Disabled_And_Active_On_Selected(DataGridView1,addcustomer_FRM.cboStatus.Text);
                    MessageBox.Show("Record have been edited!",
                                    "Successfull Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                    addcustomer_FRM.Close();
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);

            }
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Customer, "V", subMenuItems.DeleteLine, true) ==
          false)
                    return;
                if (DataGridView1.SelectedRows.Count > 0)
                {
                    var val = new[]
                                  {
                                      "ADD_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), "ADD_TYPE", "0",
                                      "TRANS_PRES", "Y"
                                  };
                    if (dataManager.Exists("SIPADDR",val))
                    {
                        MessageBox.Show("Cannot delete this record. Transactions present!");
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to delete this item?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Cursor = Cursors.WaitCursor;
                        var condition = new string[]
                                            {
                                                "ADD_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                                                "ADD_TYPE", "0"
                                            };

                        customer.Delete(condition);
                        DataGridView1.Rows.Remove(DataGridView1.SelectedRows[0]);
                        MessageBox.Show("Record was deleted successfully!", "Delete", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Cursor = Cursors.Default;

                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clone.Clear();
            if (security.CheckPermission(UserLogOn.Code, menuItems.Customer, "V", subMenuItems.CloneLine, true) ==
         false)
                return;
            outLook.CloneData(Clone,DataGridView1);
            PasteToolStripMenuItem.Enabled = true;
            PasteToolStripMenuItem1.Enabled = true;
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clone.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                var addcustomer_FRM = new ADDCUSTOMER_FRM();
                addcustomer_FRM.Text = "Paste Customer Information";
                outLook.PasteData(Clone, addcustomer_FRM.txtCode, addcustomer_FRM.txtLookup, addcustomer_FRM.txtName,
                                  addcustomer_FRM.txtadd1, addcustomer_FRM.txtadd2, addcustomer_FRM.txtadd3,
                                  addcustomer_FRM.txtadd4, addcustomer_FRM.txtadd5, addcustomer_FRM.txttel,
                                  addcustomer_FRM.txtfax, addcustomer_FRM.txtemail, addcustomer_FRM.txtweb,
                                  addcustomer_FRM.txtContName,
                                  addcustomer_FRM.txtCom1, addcustomer_FRM.txtCom2
                    );
                addcustomer_FRM.cboStatus.Text = Clone[15].Substring(0, 1) + " - " + Clone[15];
                lbl:
                if (addcustomer_FRM.ShowDialog() == DialogResult.OK)
                {
                    if (dataManager.Exists("SIPADDR", addcustomer_FRM.txtCode.Text, "SIPADDR"))
                    {
                        MessageBox.Show("Code" + addcustomer_FRM.txtCode.Text + "already.", "Existing Record",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        goto lbl;
                    }

                    var value = new[]
                                    {
                                        addcustomer_FRM.txtCode.Text, addcustomer_FRM.txtLookup.Text,
                                        addcustomer_FRM.txtName.Text, addcustomer_FRM.txtadd1.Text,
                                        addcustomer_FRM.txtadd2.Text, addcustomer_FRM.txtadd3.Text,
                                        addcustomer_FRM.txtadd4.Text, addcustomer_FRM.txtadd5.Text,
                                        addcustomer_FRM.txttel.Text, addcustomer_FRM.txtfax.Text,
                                        addcustomer_FRM.txtemail.Text, addcustomer_FRM.txtweb.Text,
                                        addcustomer_FRM.txtContName.Text, addcustomer_FRM.txtCom1.Text,
                                        addcustomer_FRM.txtCom2.Text, addcustomer_FRM.cboStatus.Text.Substring(0, 1),
                                        "0", "N",
                                        dateTimes.Now(), dateTimes.Now(), UserLogOn.Code
                                    };
                    customer.Save(value);
                    var val = new[]
                                  {
                                      addcustomer_FRM.txtCode.Text, addcustomer_FRM.txtLookup.Text,
                                      addcustomer_FRM.txtName.Text, addcustomer_FRM.txtadd1.Text,
                                      addcustomer_FRM.txtadd2.Text, addcustomer_FRM.txtadd3.Text,
                                      addcustomer_FRM.txtadd4.Text, addcustomer_FRM.txtadd5.Text,
                                      addcustomer_FRM.txttel.Text, addcustomer_FRM.txtfax.Text,
                                      addcustomer_FRM.txtemail.Text, addcustomer_FRM.txtweb.Text,
                                      addcustomer_FRM.txtContName.Text, addcustomer_FRM.txtCom1.Text,
                                      addcustomer_FRM.txtCom2.Text,
                                      addcustomer_FRM.cboStatus.Text.Substring(4,
                                                                               addcustomer_FRM.cboStatus.Text.Length - 4)
                                      , "0", "N", dateTimes.Now(), dateTimes.Now(), UserLogOn.Code
                                  };
                    controls.AddToDataGridView(DataGridView1, val);
                    var i = DataGridView1.Rows.Count - 1;
                    outLook.ChangeColorOnDisabledAndActive(DataGridView1, addcustomer_FRM.cboStatus.Text, i);
                    MessageBox.Show("Record have been pasted!", "Paste", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                }
                addcustomer_FRM.Close();
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Customer, "V", subMenuItems.ExportExcel, true) ==
         false)
                return;
            LinkLabel1_LinkClicked(null,null);
        }

        #endregion

        #region Action

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToolStripButton_Click( sender,e);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditToolStripButton1_Click(sender,e);
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteToolStripButton2_Click(sender,e);
        }

        #endregion

        #region View

        private void DefaultAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DefaultAllToolStripMenuItem.Checked == false)
            {
                var siCustomer = new SICustomer();
                try
                {
                    DefaultAllToolStripMenuItem.Checked = true;
                    ActiveToolStripMenuItem.Checked = false;
                    DisabledToolStripMenuItem.Checked = false;
                    outLook.showDGV(DataGridView1, siCustomer.LoadData(), "ADD_STAT");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultAllToolStripMenuItem.Checked = false;
            ActiveToolStripMenuItem.Checked = true;
            DisabledToolStripMenuItem.Checked = false;
            outLook.Active_And_Disable_On_GridView(DataGridView1, "Disable");
        }

        private void DisabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultAllToolStripMenuItem.Checked = false;
            ActiveToolStripMenuItem.Checked = false;
            DisabledToolStripMenuItem.Checked = true;
            outLook.Active_And_Disable_On_GridView(DataGridView1, "Active");
        }
        #endregion

        #region Tool in ContextMenu1

        private void CloneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloneToolStripMenuItem_Click(sender,e);
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(sender,e);
        }

        private void ImportToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ExportToolStripMenuItem1_Click(object sender, EventArgs e) 
        {
            ExcelTool_Click(null,null);
        }

        #endregion

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelTool_Click(sender,e);
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTool_Click(sender,e);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customers = new SICustomer();
            outLook.showDGV(DataGridView1, customers.LoadData(), "ADD_STAT");
        }

        private void ToolStrip2_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                var j = 0;
                var i = 0;
                var k = SearchPanel.Width / 200;
                if (k == 0) { j = 1; }
                else if (k < 3) { j = k; }
                else { j = 3; }
                for (i = 0; i <= ToolStrip2.Items.Count - 1; i++)
                {
                    if (ToolStrip2.Items[i].Name.Substring(0, 4) == "ttxt")
                    {
                        ToolStrip2.Items[i].Width = ((SearchPanel.Width - 125) * j) / j;
                        if (ToolStrip2.Height + ToolStrip3.Height + Label5.Height <= 380)
                        {
                            SearchPanel.Height = ToolStrip2.Height + ToolStrip3.Height + Label5.Height;
                        }
                        else
                        {
                            SearchPanel.Height = 380;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveToolStripMenuItem.Visible = true;
            removesep.Visible = true;
            STRTMP = e.ClickedItem.Name;
        }

        private void ToolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveToolStripMenuItem.Visible = false;
            removesep.Visible = false;
            foreach (ToolStripItem item in ContextMenuStrip2.Items)
            {
                item.Enabled = true;
            }
        }

        private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            outLook.addcreteria(ContextMenuStrip2, ToolStrip2, SearchPanel, RemoveToolStripMenuItem, e, STRTMP);
        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SelectNextControl(DataGridView1, true, true, true, true);
        }

        #region Export To Excel

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            outLook.ExportToExcel(ListView1,bgwExcel);
        }
//
        private void bgwExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            outLook.BackGround_DdWork(DataGridView1,ListView1);
        }

        private void bgwExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            outLook.BackGround_RunWorkedCompleted();
        }
//
        private void bgwExcel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            outLook.BackGroud_ProgressChanged(e);
        }

        #endregion 

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            var ss = new string[] { "ADD_TYPE","0" };
            var cod = new OutLook();
            cod.searching(connection.Connect(), DataGridView1, "SELECT * FROM SIPADDR ", "ADD_CODE", ToolStrip2, ToolStrip3, "D", ss);
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
       }
}
