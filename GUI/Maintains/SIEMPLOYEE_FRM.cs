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
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using Excel = Microsoft.Office.Interop.Excel;

namespace POS.GUI.Maintains
{
    public partial class SIEMPLOYEE_FRM : DevComponents.DotNetBar.Office2007Form
    {
        public SIEMPLOYEE_FRM()
        {
            InitializeComponent();
        }
        
        #region Global Variable

//        Application Ea
//        private Workbook workbook;
//        private Worksheet worksheet;
        private readonly IControlOutLook outLook = new OutLook();
        readonly SIEmployee employee = new SIEmployee();
        private string STRTMP = "";
        readonly Connection.Connection  connection = new Connection.Connection();
        readonly DateTimes dateTimes = new DateTimes();
        readonly Controls controls = new Controls();
        readonly DataManager dataManager = new DataManager();
        private readonly List<string> Clone = new List<string>();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        readonly SISecurity security = new SISecurity();
        DataManager DataManager = new DataManager();
        #endregion

        private void SIEMPLOYEE_FRM_Load(object sender, EventArgs e)
        {
            outLook.showDGV(DataGridView1, employee.LoadData(), "SI_LOOKUP");
            outLook.loadSearch(DataGridView1, employee.LoadData(), "SI_CODE", ListView1, ContextMenuStrip2, ToolStrip2, SplitContainer1, SearchPanel);
        }

        private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            outLook.addcreteria(ContextMenuStrip2, ToolStrip2, SearchPanel, RemoveToolStripMenuItem, e, STRTMP);
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
                        if (ToolStrip2.Height + ToolStrip3.Height + Label4.Height <= 380)
                        {
                            SearchPanel.Height = ToolStrip2.Height + ToolStrip3.Height + Label4.Height;
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

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SelectNextControl(DataGridView1, true, true, true, true);
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            var ss = new string[] { "SI_TYPE", "EMP" };
            var cod = new OutLook();
            cod.searching(connection.Connect(), DataGridView1, "SELECT  SI_CODE, RTRIM(SUBSTRING(SI_DATA, 1, 20)) [SI_NAME], RTRIM(SUBSTRING(SI_DATA, 21, 120)) [SI_Address], RTRIM(SUBSTRING(SI_DATA, 141, 15))[SI_Phone],  SI_LOOKUP FROM SIPDATA ", "[SI_CODE]", ToolStrip2, ToolStrip3, "SI_LOOKUP", ss);
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

        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveToolStripMenuItem.Visible = true;
            removesep.Visible = true;
            STRTMP = e.ClickedItem.Name;
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //        ======================= Export Data To Excel ==============================

        #region Export Data To Excel

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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

        #endregion 

        #region Action

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToolStripButton_Click(sender,e);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditToolStripButton1_Click(sender, e);
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteToolStripButton2_Click(sender, e);
        }

        #endregion

        #region ToolStrip1

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Employee, "V", subMenuItems.NewLine, true) ==
            false)
                    return;
                var employeefrm = new ADDEMPLOYEE {Text = "New Item Record", cboEmp_Status = {SelectedIndex = 0}};
                if (employeefrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    employee.Code = employeefrm.txtEmp_Code.Text;
                    employee.Name = employeefrm.txtEmp_Name.Text +
                                    employeefrm.txtEmp_Name.Text.PadRight(20 - employeefrm.txtEmp_Name.Text.Length);
                    employee.Address = employeefrm.txtEmp_add.Text + employeefrm.txtEmp_add.Text.PadRight(120 - employeefrm.txtEmp_add.Text.Length);
                    employee.Tell = employeefrm.txtEmp_tel.Text +
                                    employeefrm.txtEmp_tel.Text.PadRight(15 - employeefrm.txtEmp_tel.Text.Length);
                    employee.Status = employeefrm.cboEmp_Status.Text.Substring(0, 1);
                    var value = new string[]
                                    {
                                        employee.Code, "EMP",
                                        employee.Status, employee.Name + employee.Address + employee.Tell
                                        ,
                                        UserLogOn.Code, dateTimes.Now(), UserLogOn.Code, dateTimes.Now()
                                    };
                    employee.Save(value);
                    controls.AddToDataGridView(DataGridView1, employee.Code, employeefrm.txtEmp_Name.Text, employeefrm.txtEmp_add.Text,employeefrm.txtEmp_tel.Text,
                                               employeefrm.cboEmp_Status.Text.Substring(4,
                                                                                        employeefrm.cboEmp_Status.Text.Length - 4));
                    var i = DataGridView1.Rows.Count -1;
                    outLook.ChangeColorOnDisabledAndActive(DataGridView1, employeefrm.cboEmp_Status.Text.Substring(0, 1),i);

                }
                employeefrm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Employee, "V", subMenuItems.EditLine, true) ==
            false)
                    return;
                if (DataGridView1.SelectedRows.Count > 0)
                {
                    var addemployee = new ADDEMPLOYEE { Text = "Edit Employee" };
                    employee.Code = Convert.ToString(DataGridView1.SelectedRows[0].Cells[0].Value);
                    employee.Name = Convert.ToString(DataGridView1.SelectedRows[0].Cells[1].Value);
                    employee.Address = Convert.ToString(DataGridView1.SelectedRows[0].Cells[2].Value);
                    employee.Tell = Convert.ToString(DataGridView1.SelectedRows[0].Cells[3].Value);
                    employee.Status = Convert.ToString(DataGridView1.SelectedRows[0].Cells[4].Value);
                    if (dataManager.Exists("SIPDATA", employee.Code, "SI_CODE"))
                    {
                        addemployee.txtEmp_Code.Enabled = false;
                    }
                    var ctls = new Control[]
                                       {
                                           addemployee.txtEmp_Code, addemployee.txtEmp_Name, addemployee.txtEmp_add,
                                           addemployee.txtEmp_tel, addemployee.cboEmp_Status
                                       };
                    employee.BindingDataToControl(ctls,DataGridView1);
                    if (addemployee.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                      employee.Code = addemployee.txtEmp_Code.Text;
                      employee.Name = addemployee.txtEmp_Name.Text +
                                    addemployee.txtEmp_Name.Text.PadRight(20 - addemployee.txtEmp_Name.Text.Length);
                      employee.Address = addemployee.txtEmp_add.Text + addemployee.txtEmp_add.Text.PadRight(120 - addemployee.txtEmp_add.Text.Length);
                      employee.Tell = addemployee.txtEmp_tel.Text +
                                    addemployee.txtEmp_tel.Text.PadRight(15 - addemployee.txtEmp_tel.Text.Length);
                        employee.Status = addemployee.cboEmp_Status.Text;
                        var SI_Data = employee.Name + employee.Address + employee.Tell;
                             var val = new string[]
                                        {
                                            "SI_LOOKUP", addemployee.cboEmp_Status.Text.Substring(0, 1), "SI_DATA",
                                            SI_Data
                                        };
                        var condition = new string[] { "SI_CODE", employee.Code, "SI_TYPE", "EMP" };
                        employee.Update(val, condition);

                        var values = new string[]
                                         {
                                             employee.Code, employee.Name, employee.Address, employee.Tell,
                                             employee.Status.Substring(4, employee.Status.Length - 4)
                                         };
                        controls.UpdateDataToGridView(DataGridView1,values);
                        var i = DataGridView1.SelectedRows.Count -1;
                        outLook.ChangeColorOnDisabledAndActive(DataGridView1,employee.Status.Substring(0,1),i);
                        MessageBox.Show("Record have been edited!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Employee, "V", subMenuItems.DeleteLine, true) ==
             false)
                return;
            if (DataGridView1.SelectedRows.Count > 0)
            {
                var d = DataGridView1.SelectedRows[0].Cells[0].Value;
                if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        var str = DataGridView1.SelectedRows[0].Cells[0].Value;
                        employee.Delete(d.ToString());
                        DataGridView1.Rows.Remove(DataGridView1.SelectedRows[0]);
                        MessageBox.Show("Record was deleted successfully!", "Successfull", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Employee, "V", subMenuItems.CloneLine, true) ==
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

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Clone.Count > 0)
            {
                try
                {
                    ADDEMPLOYEE addemployee = new ADDEMPLOYEE();
                    addemployee.Text = "Paste Item Record";
                    addemployee.txtEmp_Code.Text = this.Clone[0];
                    addemployee.txtEmp_Name.Text = this.Clone[1];
                    addemployee.txtEmp_add.Text = Clone[2];
                    addemployee.txtEmp_tel.Text = Clone[3];
                    addemployee.cboEmp_Status.Text = Clone[4].Substring(0, 1) + " - " + this.Clone[4];
                    lbl:
                    if (addemployee.ShowDialog() == DialogResult.OK)
                    {
                        if (DataManager.Exists("SIPDATA", "EMP", "SI_TYPE", "SI_CODE",addemployee.txtEmp_add.Text))
                        {
                            MessageBox.Show("Code " + addemployee.txtEmp_add.Text + " already.", "Existing Record",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            goto lbl;
                        }
                        this.Cursor = Cursors.WaitCursor;
                        var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00");
                        employee.Code = addemployee.txtEmp_Code.Text;
                        employee.Name = addemployee.txtEmp_Name.Text +
                                        addemployee.txtEmp_Name.Text.PadRight(20 - addemployee.txtEmp_Name.Text.Length);
                        employee.Address = addemployee.txtEmp_add.Text + addemployee.txtEmp_add.Text.PadRight(120 - addemployee.txtEmp_add.Text.Length);
                        employee.Tell = addemployee.txtEmp_tel.Text +
                                        addemployee.txtEmp_tel.Text.PadRight(15 - addemployee.txtEmp_tel.Text.Length);
                        employee.Status = addemployee.cboEmp_Status.Text.Substring(0, 1);
                        var value = new[]
                                    {
                                        employee.Code, "EMP",
                                        employee.Status, employee.Name + employee.Address + employee.Tell
                                        ,
                                        UserLogOn.Code, dateTimes.Now(), UserLogOn.Code, dateTimes.Now()
                                    };
                        employee.Save(value);
                        int j = 0;
                        controls.AddToDataGridView(DataGridView1, employee.Code, addemployee.txtEmp_Name.Text, addemployee.txtEmp_add.Text,addemployee.txtEmp_tel.Text,
                                               addemployee.cboEmp_Status.Text.Substring(4,
                                                                                        addemployee.cboEmp_Status.Text.Length - 4));
                        var i = DataGridView1.Rows.Count -1;
                        outLook.ChangeColorOnDisabledAndActive(DataGridView1, addemployee.cboEmp_Status.Text.Substring(0,1),i);
                      
                        MessageBox.Show("Record have been pasted!", "Paste", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                       
                    }
                    Cursor = Cursors.Default;
                    addemployee.Close();
                }
                catch (Exception exception1)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(exception1.Message, "Error");
                }
            }
//            else
//            {
//                MessageBox.Show("Please clone before paste data.", "Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }

        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Employee, "V", subMenuItems.ExportDatatoExcel, true) ==
            false)
                return;
            LinkLabel1_LinkClicked(null,null);
        }

        private void ExcelTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Employee, "V", subMenuItems.ExportExcel, true) ==
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

            if (security.CheckPermission(UserLogOn.Code, menuItems.Employee, "V", subMenuItems.SearchData, true) ==
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
                var siEmployee = new SIEmployee();
                outLook.showDGV(DataGridView1, siEmployee.LoadData(), "SI_LOOKUP");
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

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var siEmployee = new SIEmployee();
            outLook.showDGV(DataGridView1, siEmployee.LoadData(), "SI_LOOKUP");
        }

        private void chbS_CheckedChanged(object sender, EventArgs e)
        {
            controls.CheckOnListView(ListView1, chbS);
        }

        #region View

        private void DefaultAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DefaultAllToolStripMenuItem.Checked == false)
            {
                var SIemployee = new SIEmployee();
                try
                {
                    DefaultAllToolStripMenuItem.Checked = true;
                    ActiveToolStripMenuItem.Checked = false;
                    DisableToolStripMenuItem.Checked = false;
                    outLook.showDGV(DataGridView1, SIemployee.LoadData(), "SI_LOOKUP");
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
            CloneToolStripMenuItem_Click(sender,e);
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(sender,e);
        }

        private void ExportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LinkLabel1_LinkClicked(null,null);
        }

        #endregion 




    }
}