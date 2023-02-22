using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using POS.DataLayer;
using POS.Transaction;
using POS.Transaction.Maintains;
using POS.Transaction.Security;
using POS.Utilities;
using Application = Microsoft.Office.Interop.Excel.Application;
using Excel = Microsoft.Office.Interop.Excel;

namespace POS.GUI.Maintains
{
    public partial class LOCATION_FRM : DevComponents.DotNetBar.Office2007Form
    {
        ADDLOCATION_FRM addlocation_FRM = new ADDLOCATION_FRM();
        
        #region Constructor

        public LOCATION_FRM()
        {
            InitializeComponent();
        }

        #endregion

        #region Global varaible

        private readonly OutLook outLook = new OutLook();
        SILocation location = new SILocation();
        private string STRTMP = "";
        readonly Connection.Connection connection = new Connection.Connection();
        readonly PROGRESSBAR_FRM progressbar_FRM = new PROGRESSBAR_FRM();
        public Boolean[] Col_Sel;
        private List<string> Clone = new List<string>();
        DataManager dataManager = new DataManager();
        SILocation siLocation = new SILocation();
        SISecurity security = new SISecurity();
        SIMenuItems menuItems = new SIMenuItems();
        SISubMenuItems subMenuItems = new SISubMenuItems();
        Controls controls = new Controls();
        #endregion

        private void LOCATION_FRM_Load(object sender, EventArgs e)
        {
            outLook.showDGV(dataGridViewX1, location.LoadData(), "LOC_STAT");
            outLook.loadSearch(dataGridViewX1, location.LoadData(), "LOC_CODE", ListView1, contextMenuStrip2, ToolStrip2,
                               splitContainer1, SearchPanel);
        }

        #region ToolStrip1

        private void ExcelTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Location, "V", "Export Data to Excel", true) ==
           false)
                return;
            if (ExcelTool.Checked == false)
            {
                ExcelTool.Checked = true;
                ExportToolStripMenuItem1.Checked = true;
                ExcelPanel.Visible = true;
                if (SearchTool.Checked == false)
                {
                    splitContainer1.Panel2Collapsed = false;
                }
            }
            else
            {
                ExcelTool.Checked = false;
                ExportToolStripMenuItem1.Checked = false;
                ExcelPanel.Visible = false;
                if (SearchTool.Checked == false)
                {
                    splitContainer1.Panel2Collapsed = true;
                }
            }
        }

        private void SearchTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Location, "V", "Search Data", true) ==
            false)
                return;
            if (SearchTool.Checked == false)
            {
                SearchTool.Checked = true;
                ToolStrip3.Visible = true;
                SearchToolStripMenuItem.Checked = true;
                SearchPanel.Visible = true;
                Label5.Visible = true;
                if (ExcelTool.Checked == false)
                {
                    splitContainer1.Panel2Collapsed = false;
                }
            }
            else
            {
                location = new SILocation();
                outLook.showDGV(dataGridViewX1, location.LoadData(), "LOC_STAT");
                DefaultAllToolStripMenuItem.Checked = true;
                ActiveToolStripMenuItem.Checked = false;
                disableToolStripMenuItem.Checked = false;
                SearchTool.Checked = false;
                SearchToolStripMenuItem.Checked = false;
                SearchPanel.Visible = false;
                Label5.Visible = false;

                if (ExcelTool.Checked == false)
                {
                    splitContainer1.Panel2Collapsed = true;
                }
                Cursor = Cursors.Default;
            }
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Location, "V", subMenuItems.NewLine, true) ==
            false)
                    return;
                var locationfrm = new ADDLOCATION_FRM {Text = "New Item Record", cboStatus = {SelectedIndex = 0}};
                lbl:
                if (locationfrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (dataManager.Exists("SIPLOCA", locationfrm.txtCode.Text,"LOC_CODE"))
                    {
                        MessageBox.Show("This location code already exists!");
                        goto lbl;
                    }
                    var value = new string[]
                                    {
                                        locationfrm.txtCode.Text, locationfrm.txtName.Text,
                                        locationfrm.cboStatus.Text.Substring(0, 1), UserLogOn.Code
                                    };
                    location.Save(value);
                    controls.AddToDataGridView(dataGridViewX1, locationfrm.txtCode.Text, locationfrm.txtName.Text,
                                               locationfrm.cboStatus.Text.Substring(4,
                                                                                    locationfrm.cboStatus.Text.Length -
                                                                                    4), UserLogOn.Code);
                    var i = dataGridViewX1.Rows.Count - 1;
                    outLook.ChangeColorOnDisabledAndActive(dataGridViewX1, locationfrm.cboStatus.Text, i);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Location, "V", subMenuItems.EditLine, true) ==
            false)
                    return;
                Cursor = Cursors.WaitCursor;
                var location_frm = new ADDLOCATION_FRM();
                location_frm.Text = "Edit Location";
                location_frm.txtCode.Text = dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString();
                location_frm.txtCode.Enabled = false;
                location_frm.txtName.Text = dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString();
                var d = dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString();
                location_frm.cboStatus.Text = d.Substring(0,1) + " - " + d;
                if (location_frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var value = new[]{"LOC_NAME",location_frm.txtName.Text,"LOC_STAT",location_frm.cboStatus.Text.Substring(0,1)};
                    var condition = new[] {"LOC_CODE", location_frm.txtCode.Text};
                    location.Update(value,condition);
                    controls.UpdateDataToGridView(dataGridViewX1, location_frm.txtCode.Text, location_frm.txtName.Text,
                                                  location_frm.cboStatus.Text == "A - Active" ? "Active" : "Disabled",
                                                  UserLogOn.Code);
                    outLook.Change_Color_On_Disabled_And_Active_On_Selected(dataGridViewX1,location_frm.cboStatus.Text);
                    MessageBox.Show("Location was edited successfully");
                    Cursor = Cursors.Default;
                    location_frm.Close();
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Default;
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            DeleteToolStripMenuItem1_Click(sender, e);
        }

        #endregion

        #region Toolstrip2

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
            removeToolStripMenuItem.Visible = true;
            removesep.Visible = true;
            STRTMP = e.ClickedItem.Name;
        }

        #endregion

        private void ToolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            removeToolStripMenuItem.Visible = false;
            removesep.Visible = false;
            foreach (ToolStripItem item in contextMenuStrip2.Items)
            {
                item.Enabled = true;
            }            
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            outLook.addcreteria(contextMenuStrip2,ToolStrip2,SearchPanel,removeToolStripMenuItem,e,STRTMP);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SelectNextControl(dataGridViewX1, true, true, true, true);
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            outLook.searching(connection.Connect(), dataGridViewX1,
                              "SELECT LOC_CODE, LOC_NAME, LOC_STAT FROM dbo.SIPLOCA",
                              "LOC_CODE", ToolStrip2, ToolStrip3, "LOC_STAT");
        }

        #region Export Excel

        private Application Ea;
        private Workbook workbook ;
        private Worksheet worksheet;

        private void ExportExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Ea = new Application();
                int i = 0;
                foreach (ListViewItem item in ListView1.Items)
                    if (item.Checked == true)
                        i += 1;

                if (i <= 0)
                {
                    MessageBox.Show(Messages.ExportToExcel, "Error Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ListView1.Focus();
                }
                var d = 0;
                // ===============Header of excel=============
               
                object misValue = System.Reflection.Missing.Value;
                workbook = Ea.Workbooks.Add(misValue);
                worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                Col_Sel = new bool[ListView1.Items.Count];
                for (int j = 0; j < ListView1.Items.Count; j++)
                {
                    if (ListView1.Items[j].Checked == true)
                    {
                        Col_Sel[j] = true;
                        d += 1;
                        worksheet.Cells[1, d] = ListView1.Items[j].Text;
                    }
                    else
                    {
                        Col_Sel[j] = false;
                    }
                }

                progressbar_FRM.Text = "Export to excel...";
                progressbar_FRM.progressBar1.Value = 0;
                bgwExcel.RunWorkerAsync();
                if (progressbar_FRM.ShowDialog() == DialogResult.Cancel)
                {
                    bgwExcel.CancelAsync();
                    progressbar_FRM.Close();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Excel");
            }
        }

        private void bgwExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewX1.Rows.Count ; i++)
                {
                    int k = 0;

                    for (int j = 0; j < ListView1.Items.Count; j++)
                    {
                        if (Col_Sel[j] == true)
                        {
                            k += 1;
                            worksheet.Cells[i + 2, k] = dataGridViewX1.Rows[i].Cells[j].Value;
                        }
                    }
                    var rowGrid = dataGridViewX1.Rows.Count - 1;
                    if (rowGrid == 0)
                    {
                        rowGrid = 1;
                        i = 1;
                    }
                    bgwExcel.ReportProgress((int)Math.Round((Double)((((double)i) / ((double)rowGrid)) * 100.0)));
                    if (bgwExcel.CancellationPending)
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bgwExcel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressbar_FRM.progressBar1.Value = e.ProgressPercentage;
            progressbar_FRM.Text = "Export to excel... (" + e.ProgressPercentage;
            progressbar_FRM.Refresh();
        }

        private void bgwExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressbar_FRM.Close();
            Ea.Visible = true;
//            Ea.Application.Quit();
            worksheet.Columns.AutoFit();
            worksheet = null;
            workbook = null;
            Ea = null;
        }

        #endregion

        #region ContextMenu 2

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelTool_Click(null, null);
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTool_Click(sender,e);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Locat = new SILocation();
            outLook.showDGV(dataGridViewX1, Locat.LoadData(), "LOC_STAT");
        }

        #endregion

        #region Tools

        private void CloneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clone.Clear();
            if (security.CheckPermission(UserLogOn.Code, menuItems.Location, "V", subMenuItems.CloneLine, true) ==
         false)
                return;
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                outLook.CloneData(Clone, dataGridViewX1);
                PasteToolStripMenuItem1.Enabled = true;
            }
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.Clone.Count > 0)
            {
                try
                {
                    var addlocation = new ADDLOCATION_FRM();
                    addlocation.Text = "Paste Item Record";
                    addlocation.txtCode.Text = this.Clone[0];
                    addlocation.txtName.Text = this.Clone[1];
                    addlocation.cboStatus.Text = this.Clone[2].ToString().Substring(0, 1) + " - " + this.Clone[2];
                    a:
                    if (addlocation.ShowDialog() == DialogResult.OK)
                    {
                        if (dataManager.Exists("SIPLOCA", addlocation.txtCode.Text, "LOC_CODE"))
                        {
                            MessageBox.Show("Location code already.", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            goto a;
                        }
                        Cursor = Cursors.WaitCursor;
                        var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00");
                        var values = new[]
                                          {
                                              addlocation.txtCode.Text,addlocation.txtName.Text,addlocation.cboStatus.Text.Substring(0, 1),
                                             "SISA"
                                          };
                        siLocation.Save(values);
                        int j =
                       dataGridViewX1.Rows.Add(new object[]
                                                         {
                                                             addlocation.txtCode.Text, addlocation.txtName.Text,
                                                             addlocation.cboStatus.Text.Substring(4,
                                                                                                      addlocation.
                                                                                                          cboStatus.Text
                                                                                                          .Length - 4)
                                                         }
                           )
                       ;
                        string comboStatus = addlocation.cboStatus.Text.Substring(0, 1);
                        if (comboStatus == "D")
                        {
                            this.dataGridViewX1.Rows[j].DefaultCellStyle.ForeColor = Color.DarkGray;
                            this.dataGridViewX1.Rows[j].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                        }
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Record have been pasted!", "Paste", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        addlocation.Close();
                    }
                   
                }
                catch (Exception exception1)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(exception1.Message, "Error");
                }
                addlocation_FRM = null;
            }
            else
            {
                MessageBox.Show("Please clone before paste data.", "Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           ExcelTool_Click(sender,e);
        }

        #endregion
        
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
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Location, "V", subMenuItems.DeleteLine, true) ==
          false)
                    return;
                var d = dataGridViewX1.SelectedRows[0].Cells[0].Value;
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
                        Cursor = Cursors.WaitCursor;
                        var str = dataGridViewX1.SelectedRows[0].Cells[0].Value;
                        siLocation.Delete(d.ToString());
                        dataGridViewX1.Rows.Remove(dataGridViewX1.SelectedRows[0]);
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

        private void chbS_CheckedChanged(object sender, EventArgs e)
        {
            controls.CheckOnListView(ListView1, chbS);
        }

        private void AllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DefaultAllToolStripMenuItem.Checked == false)
            {
                var locat = new SILocation();
                try
                {
                    DefaultAllToolStripMenuItem.Checked = true;
                    ActiveToolStripMenuItem.Checked = false;
                    disableToolStripMenuItem.Checked = false;
                    outLook.showDGV(dataGridViewX1, locat.LoadData(), "LOC_STAT");
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
            disableToolStripMenuItem.Checked = false;
            outLook.Active_And_Disable_On_GridView(dataGridViewX1, "Disable");
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultAllToolStripMenuItem.Checked = false;
            ActiveToolStripMenuItem.Checked = false;
            disableToolStripMenuItem.Checked = true;
            outLook.Active_And_Disable_On_GridView(dataGridViewX1, "Active");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
