using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using POS.Connection;
using POS.DataLayer;
using POS.GUI.User;
using POS.Transaction;
using POS.Transaction.Security;
using POS.Utilities;
using Application=Microsoft.Office.Interop.Excel.Application;
using Excel = Microsoft.Office.Interop.Excel;
using DataTable=System.Data.DataTable;

namespace POS.GUI.Maintains
{
    public partial class SICAT_FRM : DevComponents.DotNetBar.Office2007Form
    {
        #region Global Variable 
//

        public String STRTMP = "";
        public Boolean[] Col_Sel;
        private IConnection cn = new Connection.Connection();
        readonly IControlOutLook outLook = new OutLook();
        readonly PROGRESSBAR_FRM progressbar_FRM = new PROGRESSBAR_FRM();
        ADDCATEGORY_FRM addcategory_FRM = new ADDCATEGORY_FRM();
        private readonly List<string> Clone = new List<string>();
        readonly DataManager dataManager = new DataManager();
        readonly Controls controls = new Controls();
// ReSharper disable FieldCanBeMadeReadOnly
        DateTimes dateTimes = new DateTimes();
// ReSharper restore FieldCanBeMadeReadOnly
        SIMenuItems menuItems = new SIMenuItems();
        SISubMenuItems subMenuItems = new SISubMenuItems();
        SISecurity security = new SISecurity();

        #endregion

        #region Constructor

        public SICAT_FRM(PROGRESSBAR_FRM frmProgress)
        {
            InitializeComponent();
            progressbar_FRM = frmProgress;
        }

        #endregion

        private void ToolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveToolStripMenuItem.Visible=false;
            removesep.Visible=false;
            foreach (ToolStripItem item in ContextMenuStrip2.Items)
            {
                item.Enabled=true;
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var siCategory = new SICategory("CATE");
            var dt = siCategory.LoadData();
            outLook.showDGV(dataGridView1, dt, "SI_LOOKUP");
            outLook.loadSearch(dataGridView1, dt, "SI_CODE", ListView1, ContextMenuStrip2, ToolStrip2, SplitContainer1, SearchPanel);

        }

        private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            outLook.addcreteria(ContextMenuStrip2, ToolStrip2, SearchPanel, RemoveToolStripMenuItem, e, STRTMP);

        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SelectNextControl(dataGridView1, true, true, true, true);
        }

        #region ToolStrip1

        private void ExcelTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Category, "V", subMenuItems.ExportDatatoExcel, true) ==
          false)
                return;
            if (ExcelTool.Checked == false)
            {
                ExcelTool.Checked = true;
                excelToolStripMenuItem.Checked = true;
                ExcelPanel.Visible = true;
                if (SearchTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = false;
                }
            }
            else
            {
                ExcelTool.Checked = false;
                excelToolStripMenuItem.Checked = false;
                ExcelPanel.Visible = false;
                if (SearchTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = true;
                }
            }
        }

        private void SearchTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Category, "V", subMenuItems.SearchData, true) ==
          false)
                return;
            if (SearchTool.Checked == false)
            {
                SearchTool.Checked = true;
                searchToolStripMenuItem.Checked = true;
                SearchPanel.Visible = true;
                ToolStrip3.Visible = true;
//                ExcelPanel.Visible = false;
                Label5.Visible = true;
                if (ExcelTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = false;
                }
            }
            else
            {
                
                var siCategory = new SICategory("CATE");
                outLook.showDGV(dataGridView1,siCategory.LoadData(),"SI_LOOKUP");
                DefaultAllToolStripMenuItem.Checked = true;
                activeToolStripMenuItem.Checked = false;
                disabledToolStripMenuItem.Checked = false;
                SearchTool.Checked = false;
                searchToolStripMenuItem.Checked = false;
                SearchPanel.Visible = false;
                Label5.Visible = false;

                if (ExcelTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = true;
                }
                Cursor = Cursors.Default;
            }
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem_Click(sender, e);
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Category, "V", subMenuItems.NewLine, true) ==
          false)
                    return;
                var categoryfrm = new ADDCATEGORY_FRM();
                
                categoryfrm.Text = "New Item Record";
                categoryfrm.cboStatus.SelectedIndex = 0;
                if (categoryfrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var siCategory = new SICategory("CATE");
                    var value = new string[]
                                    {
                                        categoryfrm.txtCode.Text, "CATE",
                                        categoryfrm.cboStatus.Text.Substring(0, 1), categoryfrm.txtDes.Text,
                                        UserLogOn.Code, dateTimes.Now(), UserLogOn.Code, dateTimes.Now()
                                    };
                    siCategory.Save(value);
                    controls.AddToDataGridView(dataGridView1, categoryfrm.txtCode.Text, categoryfrm.txtDes.Text,
                                               categoryfrm.cboStatus.Text.Substring(4,
                                                                                        categoryfrm.cboStatus.Text.Length - 4));
                    var i = dataGridView1.Rows.Count - 1;
                    outLook.ChangeColorOnDisabledAndActive(dataGridView1, categoryfrm.cboStatus.Text.Substring(0, 1),i);

                }
                categoryfrm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem_Click(sender, e);
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cloneToolStripMenuItem1_Click(sender, e);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem1_Click(sender, e);
        }
        #endregion

        #region ToolStrip2

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

        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveToolStripMenuItem.Visible = true;
            removesep.Visible = true;
            STRTMP = e.ClickedItem.Name;
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importToolStripMenuItem1_Click(sender, e);
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Category, "V", subMenuItems.ExportExcel, true) ==
        false)
                return;
            LBLEXPORTEXCEL_LinkClicked(null, null);
        }

        #endregion

        // ========== Export Excel =====================

        #region Excel

        private void LBLEXPORTEXCEL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            outLook.ExportToExcel(ListView1,bgwExcel);
        }

//        public static Array[] Redim(Array[] origArray, Int32 desiredSize)
//        {
//            System.Type t = origArray.GetType().GetElementType();
//            Array newArray = Array.CreateInstance(t, desiredSize);
//            Array.Copy(origArray, 0, newArray, 0, Math.Min(origArray.Length, desiredSize));
//            return newArray;
//        }


        private void bgwExcel_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            outLook.BackGround_DdWork(dataGridView1,ListView1);
        }

        private void bgwExcel_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            outLook.BackGroud_ProgressChanged(e);
        }

        private void bgwExcel_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            outLook.BackGround_RunWorkedCompleted();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelTool_Click(null, null);
        }


        #endregion

        #region Tools

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var category = new SICategory("CATE");
            outLook.showDGV(dataGridView1, category.LoadData(), "SI_LOOKUP");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTool_Click(null,null);
        }

        private void cloneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Category, "V", subMenuItems.CloneLine, true) ==
            false)
                return;
            Clone.Clear();
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                for (int I = 0; I < dataGridView1.Columns.Count; I++)
                {
                    var d = dataGridView1.SelectedRows[0].Cells[I].Value;
                    var dds = d;
                    this.Clone.Add(dds.ToString());
                }
                this.pasteToolStripMenuItem1.Enabled = true;
                this.PasteToolStripMenuItem.Enabled = true;
            }
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
//            if (security.CheckPermission(UserLogOn.Code, menuItems.Category, "V", subMenuItems.PasteLine, true) ==
//            false)
//                return;
             if (this.Clone.Count > 0)
             {
                 try
                 {
                     var category_FRM = new ADDCATEGORY_FRM();
                     category_FRM.Text = "Paste Item Record";
                     category_FRM.txtCode.Text = this.Clone[0];
                     category_FRM.txtDes.Text = this.Clone[1];
                     category_FRM.cboStatus.Text = this.Clone[2].ToString().Substring(0, 1) + " - " + this.Clone[2];
                     if (category_FRM.ShowDialog() == DialogResult.OK)
                     {
                         SICategory siCategory = new SICategory("CATE");
                         this.Cursor = Cursors.WaitCursor;
                         var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00");
                         var values = new string[]
                                          {
                                              category_FRM.txtCode.Text, "CATE",
                                              category_FRM.cboStatus.Text.Substring(0, 1),
                                              category_FRM.txtDes.Text, "", date, "", date
                                          };
                         siCategory.Save(values);
                         int j =
                         this.dataGridView1.Rows.Add(new object[]
                                                         {
                                                             category_FRM.txtCode.Text, category_FRM.txtDes.Text,
                                                             category_FRM.cboStatus.Text.Substring(4,
                                                                                                      category_FRM.
                                                                                                          cboStatus.Text
                                                                                                          .Length - 4)
                                                         }
                             )
                         ;
                         string comboStatus = category_FRM.cboStatus.Text.Substring(0, 1);
                         if (comboStatus == "D")
                         {
                             this.dataGridView1.Rows[j].DefaultCellStyle.ForeColor = Color.DarkGray;
                             this.dataGridView1.Rows[j].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                         }
                         this.Cursor = Cursors.Default;
                         MessageBox.Show("Record have been pasted!", "Paste", MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                         category_FRM.Close();
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
                MessageBox.Show("Please clone before paste data.","Paste" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void importToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

#endregion

        #region Action

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToolStripButton_Click(sender,e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Category, "V", subMenuItems.EditLine, true) ==
          false)
                    return;
                SICategory siCategory = new SICategory("CATE");
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var categoryfrm = new ADDCATEGORY_FRM();
                    categoryfrm.Text = "Edit Item Record";
                    siCategory.Code = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                    siCategory.Desc = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                    siCategory.Statu = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                    categoryfrm.txtCode.Text = siCategory.Code;
                    if (dataManager.Exists("SIPDATA", siCategory.Code, "SI_CODE"))
                    {
                        categoryfrm.txtCode.Enabled = false;
                    }
                    categoryfrm.txtCode.Text = siCategory.Code;
                    categoryfrm.txtDes.Text = siCategory.Desc;
                    categoryfrm.cboStatus.Text = siCategory.Statu.Substring(0, 1) + " - " + siCategory.Statu;
                    categoryfrm.Text = "Edit Category";
                    if (categoryfrm.ShowDialog() == DialogResult.OK)
                    {
                        var val = new string[]
                                        {
                                            "SI_LOOKUP", categoryfrm.cboStatus.Text.Substring(0, 1), "SI_DATA",
                                            categoryfrm.txtDes.Text
                                        };
                        var condition = new string[] { "SI_CODE", categoryfrm.txtCode.Text, "SI_TYPE", "CATE" };
                        siCategory.Update(val, condition);

                        var value = new string[]
                                        {
                                            categoryfrm.txtCode.Text, categoryfrm.txtDes.Text,
                                            categoryfrm.cboStatus.Text.Substring(4,
                                                                                     categoryfrm.cboStatus.Text.Length -
                                                                                     4)
                                        };
                        controls.UpdateDataToGridView(dataGridView1, value);
                     
                        outLook.Change_Color_On_Disabled_And_Active_On_Selected(dataGridView1,
                                                               categoryfrm.cboStatus.Text);
                        MessageBox.Show("Record have been edited!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Category, "V", subMenuItems.DeleteLine, true) ==
          false)
                return;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var d = dataGridView1.SelectedRows[0].Cells[0].Value;
                if (dataManager.Exists("SIPITEMS", d.ToString(), "CAT_CODE"))
                {
                    MessageBox.Show("Cannot delete this record. Transactions present!", "Fail Delete",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        SICategory siCategory = new SICategory("CATE");
                        Cursor = Cursors.WaitCursor;
                        var str = dataGridView1.SelectedRows[0].Cells[0].Value;
                        siCategory.Delete(d.ToString());
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
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

        #endregion

        #region ToolStrip3

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            var ss = new string[] { "SI_TYPE", "CATE" };
            var cod = new OutLook();
            cod.searching(cn.Connect(), dataGridView1, "SELECT SI_CODE,SI_DATA,SI_LOOKUP FROM SIPDATA", "[SI_CODE]",
                          ToolStrip2, ToolStrip3, "SI_LOOKUP", ss);
        }

        #endregion

        #region Views

        private void DefaultAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DefaultAllToolStripMenuItem.Checked == false)
            {
                var category = new SICategory("CATE");
                try
                {
                    DefaultAllToolStripMenuItem.Checked = true;
                    activeToolStripMenuItem.Checked = false;
                    disabledToolStripMenuItem.Checked = false;
                    outLook.showDGV(dataGridView1, category.LoadData(), "SI_LOOKUP");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultAllToolStripMenuItem.Checked = false;
            activeToolStripMenuItem.Checked = true;
            disabledToolStripMenuItem.Checked = false;
            outLook.Active_And_Disable_On_GridView(dataGridView1,"Disable");

        }

        private void disabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultAllToolStripMenuItem.Checked = false;
            activeToolStripMenuItem.Checked = false;
            disabledToolStripMenuItem.Checked = true;
            outLook.Active_And_Disable_On_GridView(dataGridView1,"Active");
        }

        #endregion

        private void chbS_CheckedChanged(object sender, EventArgs e)
        {
            controls.CheckOnListView(ListView1,chbS);
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}