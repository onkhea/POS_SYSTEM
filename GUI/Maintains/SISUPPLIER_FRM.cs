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
using POS.Transaction;
using POS.Transaction.Maintains;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class SISUPPLIER_FRM : DevComponents.DotNetBar.Office2007Form
    {
        #region Global Variable 

        readonly OutLook  outLook = new OutLook();
        readonly SISupplier supplier = new SISupplier();
        private string STRTMP = "";
        readonly Controls controls = new Controls();
        readonly Connection.Connection  connection = new Connection.Connection();
        readonly List<string> Clone = new List<string>();
        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        readonly DataManager dataManager = new DataManager();
        DateTimes dateTimes = new DateTimes();
//        readonly ADDSUPPLIER_FRM addsupplier_FRM = new ADDSUPPLIER_FRM();

        #endregion 

        public SISUPPLIER_FRM()
        {
            InitializeComponent();
        }

        private void SISUPPLIER_FRM_Load(object sender, EventArgs e)
        {
            outLook.showDGV(DataGridView1, supplier.LoadData(), "ADD_STAT");
            outLook.loadSearch(DataGridView1, supplier.LoadData(), "ADD_CODE", ListView1, ContextMenuStrip2, ToolStrip2, SplitContainer1, SearchPanel);
        }

        #region ToolStrip1

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Supplier, "V", subMenuItems.NewLine, true) ==
            false)
                    return;
                var addsupplier_FRM = new ADDSUPPLIER_FRM();
                addsupplier_FRM.Text = "New Supplier";
                addsupplier_FRM.cboStatus.SelectedIndex = 0;
                controls.Add_ListView(supplier.LoadDeleteSupplier(),addsupplier_FRM.ListView1);
                lbl:
                if (addsupplier_FRM.ShowDialog() == DialogResult.OK)
                {
                    var paraAndValue = new string[] {"ADD_CODE", addsupplier_FRM.txtCode.Text, "ADD_TYPE", "1"};
                    if (dataManager.Exists("SIPADDR",paraAndValue))
                    {
                        MessageBox.Show("This supplier code already exists!", "Existing", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        goto lbl;
                    }
                    #region get value

                    supplier.Code = addsupplier_FRM.txtCode.Text;
                    supplier.Suplookup = addsupplier_FRM.txtLookup.Text;
                    supplier.Name = addsupplier_FRM.txtSupName.Text;
                    supplier.Address1 = addsupplier_FRM.txtAdd1.Text;
                    supplier.Address2 = addsupplier_FRM.txtAdd2.Text;
                    supplier.Address3 = addsupplier_FRM.txtAdd3.Text;
                    supplier.Address4 = addsupplier_FRM.txtAdd4.Text;
                    supplier.Address5 = addsupplier_FRM.txtAdd5.Text;
                    supplier.Tel = addsupplier_FRM.txtTel.Text;
                    supplier.Fax = addsupplier_FRM.txtFax.Text;
                    supplier.Email = addsupplier_FRM.txtEmail.Text;
                    supplier.Web = addsupplier_FRM.txtWeb.Text;
                    supplier.Contact = addsupplier_FRM.txtContName.Text;
                    supplier.Commun1 = addsupplier_FRM.txtCom1.Text;
                    supplier.Commun2 = addsupplier_FRM.txtCom2.Text;
                    supplier.Status = addsupplier_FRM.cboStatus.Text;
                    supplier.Add_Type = "1";
                    supplier.TransPresent = "N";
                    supplier.UserCreate = dateTimes.Now();
                    supplier.UserCode = UserLogOn.Code;
                    supplier.UserUPDT = dateTimes.Now();

                    #endregion
                    var values = new string[]
                                     {
                                         supplier.Code, supplier.Suplookup, supplier.Name, supplier.Address1,
                                         supplier.Address2, supplier.Address3, supplier.Address4, supplier.Address5,
                                         supplier.Tel,supplier.Fax,supplier.Email,supplier.Web,supplier.Contact, supplier.Commun1,
                                         supplier.Commun2,supplier.Status.Substring(0,1),
                                         supplier.Add_Type,supplier.TransPresent,supplier.UserCreate,supplier.UserUPDT,supplier.UserCode
                                         
                                     };
                    supplier.Save(values);
                    var vals = new string[]
                                     {
                                         supplier.Code, supplier.Suplookup, supplier.Name, supplier.Address1,
                                         supplier.Address2, supplier.Address3, supplier.Address4, supplier.Address5,
                                         supplier.Tel,supplier.Fax,supplier.Email,supplier.Web,supplier.Contact, supplier.Commun1,
                                         supplier.Commun2,supplier.Status.Substring(4,supplier.Status.Length - 4),
                                         supplier.Add_Type,supplier.TransPresent,supplier.UserCreate,supplier.UserUPDT,supplier.UserCode
                                         
                                     };
                    controls.AddToDataGridView(DataGridView1,vals);
                    var i = DataGridView1.Rows.Count - 1;
                    outLook.ChangeColorOnDisabledAndActive(DataGridView1,addsupplier_FRM.cboStatus.Text.Substring(4,addsupplier_FRM.cboStatus.Text.Length -4),i);
                    var command = new SqlCommand("INSERT INTO SIPDELA VALUES(@ADD_CODE,@DEL_CODE)", connection.Connect());
                    foreach (ListViewItem item in addsupplier_FRM.ListView1.Items)
                    {
                        if (item.Checked )
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@ADD_CODE", addsupplier_FRM.txtCode.Text);
                            command.Parameters.AddWithValue("@DEL_CODE", item.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Supplier, "V", subMenuItems.EditLine, true) ==
           false)
                return;
            if (DataGridView1.SelectedRows.Count > 0)
            {
                var supplier_FRM = new ADDSUPPLIER_FRM();
                supplier_FRM.Text = "Edit Supplier";
                supplier_FRM.txtCode.Enabled = false;
                supplier_FRM.txtCode.Text = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                supplier_FRM.txtLookup.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                supplier_FRM.txtSupName.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                supplier_FRM.txtAdd1.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                supplier_FRM.txtAdd2.Text = DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                supplier_FRM.txtAdd3.Text = DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                supplier_FRM.txtAdd4.Text = DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                supplier_FRM.txtAdd5.Text = DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                supplier_FRM.txtTel.Text = DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                supplier_FRM.txtFax.Text = DataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                supplier_FRM.txtEmail.Text = DataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                supplier_FRM.txtWeb.Text = DataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                supplier_FRM.txtContName.Text = DataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                supplier_FRM.txtCom1.Text = DataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                supplier_FRM.txtCom2.Text = DataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                    supplier_FRM.cboStatus.Text =
                    DataGridView1.SelectedRows[0].Cells[15].Value.ToString().Substring(0, 1) + " - " +
                    DataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                var ls = new ListViewItem();
                foreach (DataRow row in supplier.LoadInEditSupplier(supplier_FRM.txtCode.Text).Rows)
                {
                     ls = supplier_FRM.ListView1.Items.Add(row[1].ToString().Trim());
                    for (int i = 0; i < supplier.LoadDeleteSupplier().Columns.Count  -1; i++)
                    {
                        if (string.IsNullOrEmpty(row[i].ToString()))
                        {
                            ls.SubItems.Add("");
                        }
                        else
                        {
                            ls.SubItems.Add(row[2].ToString());
                        }
                    }
                    var str = new[]
                                  {
                                      "ADD_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), "DEL_CODE",
                                      row[1].ToString()
                                  };
                    if (dataManager.Exists("SIPDELA", str))
                    {
                        ls.Checked = true;
                    }
                   
                }
                if (supplier_FRM.ListView1.Items.Count == 0)
                {
                    controls.Add_ListView(supplier.LoadDeleteSupplier(),supplier_FRM.ListView1);
                }

                if (supplier_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        supplier_FRM.Cursor = Cursors.WaitCursor;
                        var paramValue = new string[]
                                         {
                                             "ADD_LOOKUP",supplier_FRM.txtLookup.Text, "ADD_NAME",supplier_FRM.txtSupName.Text, "ADD_LINE_1",supplier_FRM.txtAdd1.Text, 
                                             "ADD_LINE_2",supplier_FRM.txtAdd2.Text, "ADD_LINE_3",supplier_FRM.txtAdd3.Text
                                             , "ADD_LINE_4",supplier_FRM.txtAdd4.Text, "ADD_LINE_5",supplier_FRM.txtAdd5.Text,
                                             "ADD_TEL",supplier_FRM.txtTel.Text,"ADD_FAX",supplier_FRM.txtFax.Text,"ADD_EMAIL",supplier_FRM.txtEmail.Text,"ADD_WEB",supplier_FRM.txtWeb.Text,
                                             "ADD_CONT",supplier_FRM.txtContName.Text,"ADD_COM_1",supplier_FRM.txtCom1.Text,"ADD_COM_2",supplier_FRM.txtCom2.Text,"ADD_STAT",supplier_FRM.cboStatus.Text.Substring(0,1)
                                             ,"TRANS_PRES","N",
                                            "USER_UPDT",dateTimes.Now(),"USER_CODE",UserLogOn.Code
                                         };
                        var condition = new string[] { "ADD_CODE", supplier_FRM.txtCode.Text, "ADD_TYPE", "1" };

                        supplier.Update(paramValue, condition);

                        controls.UpdateDataToGridView(DataGridView1, supplier_FRM.txtCode.Text, supplier_FRM.txtLookup.Text, supplier_FRM.txtSupName.Text, supplier_FRM.txtAdd1.Text, supplier_FRM.txtAdd2.Text, supplier_FRM.txtAdd3.Text,
                                    supplier_FRM.txtAdd4.Text, supplier_FRM.txtAdd5.Text, supplier_FRM.txtTel.Text, supplier_FRM.txtFax.Text, supplier_FRM.txtEmail.Text,
                                    supplier_FRM.txtWeb.Text, supplier_FRM.txtContName.Text, supplier_FRM.txtCom1.Text,
                                    supplier_FRM.txtCom2.Text, supplier_FRM.cboStatus.Text.Substring(4, supplier_FRM.cboStatus.Text.Length - 4), "0",
                                    DataGridView1.SelectedRows[0].Cells[18].Value.ToString(), DataGridView1.SelectedRows[0].Cells[19].Value.ToString(), UserLogOn.Code);
//                        var i = DataGridView1.SelectedRows.Count;
                        outLook.Change_Color_On_Disabled_And_Active_On_Selected(DataGridView1, supplier_FRM.cboStatus.Text);

                        var command =
                            new SqlCommand("DELETE FROM SIPDELA WHERE ADD_CODE='" +
                                           DataGridView1.SelectedRows[0].Cells[0].Value + "'", connection.Connect());
                        
                        command.ExecuteNonQuery();
                        command = new SqlCommand("INSERT INTO SIPDELA VALUES(@ADD_CODE,@DEL_CODE)",connection.Connect());
                        foreach (ListViewItem item in supplier_FRM.ListView1.Items)
                        {
                            if (item.Checked == true)
                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@ADD_CODE", supplier_FRM.txtCode.Text);
                                command.Parameters.AddWithValue("@DEL_CODE", item.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Record have been edited.", "Successful update", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    supplier_FRM.Close();
                }
            }
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Supplier, "V", subMenuItems.DeleteLine, true) ==
          false)
                    return;
                if (DataGridView1.SelectedRows.Count > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    var fieldAndValue = new string[]
                                        {
                                            "ADD_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), "ADD_TYPE"
                                            , "1"
                                        };
                    supplier.Delete(fieldAndValue);
                    supplier.Delete(DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    DataGridView1.Rows.Remove(DataGridView1.SelectedRows[0]);
                    MessageBox.Show("Record was deleted successfully!", "Successful Deleted", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Default;
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clone.Clear();
            CloneToolStripMenuItem1_Click(sender,e);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Clone.Count > 0)
            {
                try
                {
                    var supplierFrm = new ADDSUPPLIER_FRM();
                    supplierFrm.Text = "Paste Item Record";
                    var textBox = new TextBox();
                    textBox.Text = "";
                    outLook.PasteData(Clone,supplierFrm.txtCode, supplierFrm.txtLookup, supplierFrm.txtSupName,
                                      supplierFrm.txtAdd1, supplierFrm.txtAdd2, supplierFrm.txtAdd3, supplierFrm.txtAdd4,
                                      supplierFrm.txtAdd5, supplierFrm.txtTel, supplierFrm.txtFax, supplierFrm.txtWeb,
                                      supplierFrm.txtEmail, supplierFrm.txtContName, supplierFrm.txtCom1, supplierFrm.txtCom2);
                    supplierFrm.cboStatus.Text = Clone[15].Substring(0, 1) + " - " + Clone[15];
                    controls.Add_ListView(supplier.LoadDeleteSupplier(),supplierFrm.ListView1);
                    lbl:
                    if (supplierFrm.ShowDialog() == DialogResult.OK)
                    {
                        var str = new string[] { "ADD_CODE", supplierFrm.txtCode.Text, "ADD_TYPE", "1" };
                        if (dataManager.Exists("SIPADDR",str))
                        {
                            MessageBox.Show("This supplier code already exists!","Existing Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            goto lbl;
                        }

                        #region get data
                        supplier.Code = supplierFrm.txtCode.Text;
                        supplier.Suplookup = supplierFrm.txtLookup.Text;
                        supplier.Name = supplierFrm.txtSupName.Text;
                        supplier.Address1 = supplierFrm.txtAdd1.Text;
                        supplier.Address2 = supplierFrm.txtAdd2.Text;
                        supplier.Address3 = supplierFrm.txtAdd3.Text;
                        supplier.Address4 = supplierFrm.txtAdd4.Text;
                        supplier.Address5 = supplierFrm.txtAdd5.Text;
                        supplier.Tel = supplierFrm.txtTel.Text;
                        supplier.Fax = supplierFrm.txtFax.Text;
                        supplier.Email = supplierFrm.txtEmail.Text;
                        supplier.Web = supplierFrm.txtWeb.Text;
                        supplier.Contact = supplierFrm.txtContName.Text;
                        supplier.Commun1 = supplierFrm.txtCom1.Text;
                        supplier.Commun2 = supplierFrm.txtCom2.Text;
                        supplier.Status = supplierFrm.cboStatus.Text;
                        supplier.Add_Type = "1";
                        supplier.TransPresent = "N";
                        supplier.UserCreate = dateTimes.Now();
                        supplier.UserCode = UserLogOn.Code;
                        supplier.UserUPDT = dateTimes.Now();
                        #endregion

                        var values = new string[]
                                     {
                                         supplier.Code, supplier.Suplookup, supplier.Name, supplier.Address1,
                                         supplier.Address2, supplier.Address3, supplier.Address4, supplier.Address5,
                                         supplier.Tel,supplier.Fax,supplier.Email,supplier.Web,supplier.Contact, supplier.Commun1,
                                         supplier.Commun2,supplier.Status.Substring(0,1),
                                         supplier.Add_Type,supplier.TransPresent,supplier.UserCreate,supplier.UserUPDT,supplier.UserCode
                                         
                                     };
                        supplier.Save(values);
                        var vals = new string[]
                                     {
                                         supplier.Code, supplier.Suplookup, supplier.Name, supplier.Address1,
                                         supplier.Address2, supplier.Address3, supplier.Address4, supplier.Address5,
                                         supplier.Tel,supplier.Fax,supplier.Email,supplier.Web,supplier.Contact, supplier.Commun1,
                                         supplier.Commun2,supplier.Status.Substring(4,supplier.Status.Length - 4),
                                         supplier.Add_Type,supplier.TransPresent,supplier.UserCreate,supplier.UserUPDT,supplier.UserCode
                                         
                                     };
                        controls.AddToDataGridView(DataGridView1, vals);
                        var j = DataGridView1.Rows.Count -1;
                        outLook.ChangeColorOnDisabledAndActive(DataGridView1, supplierFrm.cboStatus.Text,j);
                        var command = new SqlCommand("INSERT INTO SIPDELA VALUES(@ADD_CODE,@DEL_CODE)",connection.Connect());
                        foreach (ListViewItem item in supplierFrm.ListView1.Items)
                        {
                            if (item.Checked)
                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@ADD_CODE", supplierFrm.txtCode.Text);
                                command.Parameters.AddWithValue("@DEL_CODE", item.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Record have been pasted successfully.", "Successful paste",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        supplierFrm.Close();
                    }
                }
                catch (Exception exception1)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(exception1.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Please clone before paste data.", "Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkLabel1_LinkClicked(null, null);
        }

        private void ExcelTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Supplier, "V", subMenuItems.ExportExcel, true) ==
          false)
                return;
            if (ExcelTool.Checked == false)
            {
                ExcelTool.Checked = true;
                ExcelToolStripMenuItem.Checked = true;
                ExcelPanel.Visible = true;
                if (SearchTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = false;
                }
            }
            else
            {
                ExcelTool.Checked = false;
                ExcelToolStripMenuItem.Checked = false;
                ExcelPanel.Visible = false;
                if (SearchTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = true;
                }
            }
        }

        private void SearchTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Supplier, "V", subMenuItems.SearchData, true) ==
          false)
                return;
            if (SearchTool.Checked == false)
            {
                SearchTool.Checked = true;
                SearchToolStripMenuItem.Checked = true;
                ToolStrip3.Visible = true;
                SearchPanel.Visible = true;
                Label5.Visible = true;
                if (ExcelTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = false;
                }
            }
            else
            {
                var siSupplier = new SISupplier();
                outLook.showDGV(DataGridView1, siSupplier.LoadData(), "ADD_STAT");
                DefaultAllToolStripMenuItem.Checked = true;
                ActiveToolStripMenuItem.Checked = false;
                DisableToolStripMenuItem.Checked = false;
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

        #endregion

        private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            outLook.addcreteria(ContextMenuStrip2, ToolStrip2, SearchPanel, RemoveToolStripMenuItem, e, STRTMP);
        }

        #region ContextMenu 1

        #region Action

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToolStripButton_Click(sender,e);
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
                var siSupplier = new SISupplier();
                try
                {
                    DefaultAllToolStripMenuItem.Checked = true;
                    ActiveToolStripMenuItem.Checked = false;
                    DisableToolStripMenuItem.Checked = false;
                    outLook.showDGV(DataGridView1, siSupplier.LoadData(), "ADD_STAT");
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
            DisableToolStripMenuItem.Checked = false;
            outLook.Active_And_Disable_On_GridView(DataGridView1, "Disable");
        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultAllToolStripMenuItem.Checked = false;
            ActiveToolStripMenuItem.Checked = false;
            DisableToolStripMenuItem.Checked = true;
            outLook.Active_And_Disable_On_GridView(DataGridView1, "Active");
        }

        #endregion

        #region Tools

        private void CloneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Supplier, "V", subMenuItems.CloneLine, true) ==
          false)
                return;
            Clone.Clear();
            if (this.DataGridView1.SelectedRows.Count > 0)
            {
                for (int I = 0; I < DataGridView1.Columns.Count; I++)
                {
                    var d = DataGridView1.SelectedRows[0].Cells[I].Value;
                    var dds = d;
                    this.Clone.Add(dds.ToString());
                }
                this.PasteToolStripMenuItem1.Enabled = true;
                this.PasteToolStripMenuItem.Enabled = true;
            }
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
            var outLook1 = new OutLook();
            var siSupplier = new SISupplier();
            outLook1.showDGV(DataGridView1, siSupplier.LoadData(), "ADD_STAT");
        }

        #endregion

        #region ToolStrip 2

        private void ToolStrip2_SizeChanged(object sender, EventArgs e)
        {
           outLook.ToolStrip2_SizeChanged(SearchPanel,ToolStrip2,ToolStrip3,Label4);
        }

        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveToolStripMenuItem.Visible = true;
            removesep.Visible = true;
            STRTMP = e.ClickedItem.Name;
        }

        #endregion

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SelectNextControl(DataGridView1, true, true, true, true);
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

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            var ss = new string[] {};
            var cod = new OutLook();
            cod.searching(connection.Connect(), DataGridView1, "SELECT * FROM SIPADDR", "ADD_CODE", ToolStrip2, ToolStrip3, "", ss);
        }

        private void chbS_CheckedChanged(object sender, EventArgs e)
        {
            controls.CheckOnListView(ListView1, chbS);
        }

        #region Export To Excel 

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Supplier, "V", subMenuItems.ExportDatatoExcel, true) ==
          false)
                return;
            outLook.ExportToExcel(ListView1, bgwExcel);
        }

        private void bgwExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            outLook.BackGround_DdWork(DataGridView1, ListView1);
        }

        private void bgwExcel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            outLook.BackGroud_ProgressChanged(e);
        }

        private void bgwExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            outLook.BackGround_RunWorkedCompleted();
        }

//        private void GetValue()
//        {
//            supplier.Code = addsupplier_FRM.txtCode.Text;
//            supplier.Suplookup = addsupplier_FRM.txtLookup.Text;
//            supplier.Name = addsupplier_FRM.txtSupName.Text;
//            supplier.Address1 = addsupplier_FRM.txtAdd1.Text;
//            supplier.Address2 = addsupplier_FRM.txtAdd2.Text;
//            supplier.Address3 = addsupplier_FRM.txtAdd3.Text;
//            supplier.Address4 = addsupplier_FRM.txtAdd4.Text;
//            supplier.Address5 = addsupplier_FRM.txtAdd5.Text;
//            supplier.Tel = addsupplier_FRM.txtTel.Text;
//            supplier.Fax = addsupplier_FRM.txtFax.Text;
//            supplier.Email = addsupplier_FRM.txtEmail.Text;
//            supplier.Web = addsupplier_FRM.txtWeb.Text;
//            supplier.Contact = addsupplier_FRM.txtContName.Text;
//            supplier.Commun1 = addsupplier_FRM.txtCom1.Text;
//            supplier.Commun2 = addsupplier_FRM.txtCom2.Text;
//            supplier.Status = addsupplier_FRM.cboStatus.Text;
//            supplier.Add_Type = "1";
//            supplier.TransPresent = "N";
//            supplier.UserCreate = dateTimes.Now();
//            supplier.UserCode = UserLogOn.Code;
//            supplier.UserUPDT = dateTimes.Now();
//        }

        #endregion

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
