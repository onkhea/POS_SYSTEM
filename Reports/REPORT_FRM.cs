using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using POS.DataLayer;
using POS.Reports.Inventory_Movement;
using POS.Reports.Movement_Listing;
using POS.Reports.Purchase;
using POS.Reports.Report_Design.Poit_Of_Sale;
using POS.Reports.Report_Design.Purchase;
using POS.Reports.Report_Design.Sale;
using POS.Reports.Sale_Report;
using POS.Reports.Supplier;
using POS.Transaction.Report;
using POS.Transaction.Security;
using POS.Utilities;
using POS.Connection;

namespace POS.Reports
{
    public partial class ReportFrm : Form
    {
        public ReportFrm()
        {
            InitializeComponent();
        }

        #region global varaible

        readonly OutLook _outLook = new OutLook();
        private string _strtmp = "";
        readonly Controls _controls = new Controls();
        readonly Transaction.Report.Report _reports = new Transaction.Report.Report();
        readonly DataManager _dataManager = new DataManager();
        readonly Connection.Connection _connection = new Connection.Connection();
        List<string> clone = new List<string>();
    
        #endregion

        private void REPORT_FRM_Load(object sender, EventArgs e)
        {
            _outLook.showDGV(dataGridViewX1, _reports.LoadData(), "REP_STAT");
            _outLook.loadSearch(dataGridViewX1, _reports.LoadData(), "REP_CODE", ListView1, ContextMenuStrip2, ToolStrip2, SplitContainer1, SearchPanel);
        }

        private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _outLook.addcreteria(ContextMenuStrip2, ToolStrip2, SearchPanel, RemoveToolStripMenuItem, e, _strtmp);
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
            SelectNextControl(dataGridViewX1, true, true, true, true);
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
            _strtmp = e.ClickedItem.Name;
        }

        #region  Export Excel

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _outLook.ExportToExcel(ListView1, bgwExcel);
        }

        private void chbS_CheckedChanged(object sender, EventArgs e)
        {
            _controls.CheckOnListView(ListView1, chbS);
        }

        private void bgwExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            _outLook.BackGround_DdWork(dataGridViewX1, ListView1);
        }

        private void bgwExcel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _outLook.BackGroud_ProgressChanged(e);
        }

        private void bgwExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _outLook.BackGround_RunWorkedCompleted();
        }

        #endregion

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                var addreportsFrm = new AddreportsFrm();
                lbl:
                if (addreportsFrm.ShowDialog() == DialogResult.OK)
                {
                    if (_dataManager.Exists("SIREPORT", addreportsFrm.txtCode.Text, "REP_CODE", "REP_TYPE", addreportsFrm.cboType.Text))
                    {
                        MessageBox.Show("Report code already!", "Existing", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                       goto lbl;
                    }
                    Cursor = Cursors.WaitCursor;
                    var value = new[]
                                    {
                                        addreportsFrm.txtCode.Text, addreportsFrm.cboType.Text,
                                        addreportsFrm.txtDes.Text,
                                        addreportsFrm.chbInactive.Checked ? "D" : "A", "","", "0",
                                        UserLogOn.Code, DateTime.Now.ToString()
                                    };
                    _reports.Save(value);
                    var i = dataGridViewX1.Rows.Add(addreportsFrm.txtCode.Text, addreportsFrm.txtDes.Text,
                                           addreportsFrm.cboType.Text,
                                           addreportsFrm.chbInactive.Checked ? "Disabled" : "Active", "", "", 0,
                                           UserLogOn.Code, DateTime.Now.ToString());
                    _outLook.ChangeColorOnDisabledAndActive(dataGridViewX1, addreportsFrm.chbInactive.Checked ? "Disabled" : "Active", i);
                    dataGridViewX1.SelectedRows[0].Selected = false;
                    dataGridViewX1.Rows[i].Selected = true;
                    Cursor = Cursors.Default;
                }
                addreportsFrm.Close();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }

        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                try
                {
                    var addreportsFrm = new AddreportsFrm();
                    addreportsFrm.Text = "Edit Report";
                    addreportsFrm.txtCode.Text = dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString();
                    addreportsFrm.txtCode.Enabled = false;
                    addreportsFrm.txtDes.Text = dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString();
                    addreportsFrm.cboType.Text = dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString();
                    addreportsFrm.cboType.Enabled = false;
                    addreportsFrm.chbInactive.Checked = dataGridViewX1.SelectedRows[0].Cells[3].Value.ToString() ==
                                                        "Disable"
                                                            ? true
                                                            : false;
                    if (addreportsFrm.ShowDialog() == DialogResult.OK)
                    {
                        var updt = DateTime.Now.Date.Year.ToString() + DateTime.Now.Date.Month.ToString() +
                                   DateTime.Now.Date.Day.ToString() + DateTime.Now.Hour.ToString() +
                                   DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString();

                        var values = new[]
                                         {
                                             "REP_TYPE", addreportsFrm.cboType.Text, "REP_DESC",
                                             addreportsFrm.txtDes.Text,
                                             "REP_STAT", addreportsFrm.chbInactive.Checked ? "D" : "A", "USER_UPDT",
                                             UserLogOn.Code,
                                             "DATE_UPDT",updt
                                         };

                        var conditions = new[] {"REP_CODE", addreportsFrm.txtCode.Text};

                        _reports.Update(values, conditions);

                        _controls.UpdateDataToGridView(dataGridViewX1, addreportsFrm.txtCode.Text,
                                                       addreportsFrm.txtDes.Text, addreportsFrm.cboType.Text,
                                                       addreportsFrm.chbInactive.Checked ? "Disabled" : "Active", "", "",
                                                       UserLogOn.Code, DateTime.Now.ToString());
                        var i = dataGridViewX1.SelectedRows[0].Index;
                        _outLook.ChangeColorOnDisabledAndActive(dataGridViewX1,
                                                                addreportsFrm.chbInactive.Checked ? "D" : "A", i);

                        MessageBox.Show("Edit successfully.", "Success", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                    }
                    addreportsFrm.Close();
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to detete this item?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    var condition = new[]
                                        {
                                            "REP_CODE", dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString(),
                                            "REP_TYPE", dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString()
                                        };

                    _reports.Delete(condition);
                    dataGridViewX1.Rows.Remove(dataGridViewX1.SelectedRows[0]);
                    Cursor = Cursors.Default;
                    MessageBox.Show("Delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                
            }
        }

        private void ExcelTool_Click(object sender, EventArgs e)
        {
//            if (security.CheckPermission(UserLogOn.Code, menuItems.Location, "V", "Export Data to Excel", true) ==
//           false)
//                return;
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
//            if (security.CheckPermission(UserLogOn.Code, menuItems.Location, "V", "Search Data", true) ==
//            false)
//                return;
            if (SearchTool.Checked == false)
            {
                SearchTool.Checked = true;
                ToolStrip3.Visible = true;
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
                _outLook.showDGV(dataGridViewX1, _reports.LoadData(), "REP_STAT");
                AllUsersToolStripMenuItem.Checked = true;
                ActiveToolStripMenuItem.Checked = false;
                InactiveToolStripMenuItem.Checked = false;
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

       
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            _outLook.searching(_connection.Connect(), dataGridViewX1,
                             "SELECT [REP_CODE],[REP_DESC],[REP_TYPE],[REP_STAT],[USER_UPDT],[DATE_UPDT],[USER_CREA],[DATE_CREA] FROM SIREPORT",
                              "REP_CODE", ToolStrip2, ToolStrip3, "REP_STAT");
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clone.Clear();
//            if (security.CheckPermission(UserLogOn.Code, menuItems.Location, "V", subMenuItems.CloneLine, true) ==
//         false)
//                return;
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                _outLook.CloneData(clone, dataGridViewX1);
                PasteToolStripMenuItem1.Enabled = true;
                PasteToolStripMenuItem.Enabled = true;
                
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _outLook.showDGV(dataGridViewX1, _reports.LoadData(), "REP_STAT");
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (clone.Count > 0)
                {
                    var addreportsFrm = new AddreportsFrm();
                    _outLook.PasteData(clone,addreportsFrm.txtCode,addreportsFrm.txtDes,addreportsFrm.cboType);
                    addreportsFrm.chbInactive.Checked = clone[3] == "Active" ? false : true;
                lbl:
                    if (addreportsFrm.ShowDialog() == DialogResult.OK)
                    {
                        if (_dataManager.Exists("SIREPORT", addreportsFrm.txtCode.Text, "REP_CODE", "REP_TYPE",
                                                addreportsFrm.cboType.Text))
                        {
                            MessageBox.Show("Report code already!", "Existing", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            goto lbl;
                        }
                        Cursor = Cursors.WaitCursor;
                        var value = new[]
                                        {
                                            addreportsFrm.txtCode.Text, addreportsFrm.cboType.Text,
                                            addreportsFrm.txtDes.Text,
                                            addreportsFrm.chbInactive.Checked ? "D" : "A", "", "", "0",
                                            UserLogOn.Code, DateTime.Now.ToString()
                                        };
                        _reports.Save(value);
                        var i = dataGridViewX1.Rows.Add(addreportsFrm.txtCode.Text, addreportsFrm.txtDes.Text,
                                                        addreportsFrm.cboType.Text,
                                                        addreportsFrm.chbInactive.Checked ? "Disabled" : "Active", "",
                                                        "", 0,
                                                        UserLogOn.Code, DateTime.Now.ToString());
                        _outLook.ChangeColorOnDisabledAndActive(dataGridViewX1,
                                                                addreportsFrm.chbInactive.Checked
                                                                    ? "Disabled"
                                                                    : "Active", i);
                        dataGridViewX1.SelectedRows.Clear();
                        dataGridViewX1.Rows[i].Selected = true;
                        Cursor = Cursors.Default;
                    }
                    addreportsFrm.Close();
                    
                }

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkLabel1_LinkClicked(null,null);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToolStripButton_Click(null,null);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditToolStripButton1_Click(null,null);
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteToolStripButton2_Click(null,null);
        }

        private void AllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AllUsersToolStripMenuItem.Checked == false)
            {
                try
                {
                    AllUsersToolStripMenuItem.Checked = true;
                    ActiveToolStripMenuItem.Checked = false;
                    InactiveToolStripMenuItem.Checked = false;
                    _outLook.showDGV(dataGridViewX1, _reports.LoadData(), "REP_STAT");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsersToolStripMenuItem.Checked = false;
            ActiveToolStripMenuItem.Checked = true;
            InactiveToolStripMenuItem.Checked = false;
            _outLook.Active_And_Disable_On_GridView(dataGridViewX1, "Disable");
        }

        private void InactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsersToolStripMenuItem.Checked = false;
            ActiveToolStripMenuItem.Checked = false;
            InactiveToolStripMenuItem.Checked = true;
            _outLook.Active_And_Disable_On_GridView(dataGridViewX1, "Active");
        }

        private void CloneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloneToolStripMenuItem_Click(null,null);
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(null,null);
        }

        private void ExportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LinkLabel1_LinkClicked(null,null);
        }

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelTool_Click(null,null);
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTool_Click(null,null);
        }

        private void ResetDesignFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to clear the format of the report?","Clear Report",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    var values = new[] {"REP_DATA",""};
                    var condition = new[]
                                        {
                                            "REP_TYPE", dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString(),
                                            "REP_CODE", dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString()
                                        };
                    DataAccess.UpdateData("SIREPORT", values, condition);
                    Cursor = Cursors.Default;
                    MessageBox.Show("The report have been reset to default format successfully.", "Clear Dsign",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewX1.SelectedRows.Count > 0)
            {

                var reportDesign = new REPORT_DESIGN();
                var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + "\\REPORTS";
                var File = Path.Combine(path, "report.repx");
                try
                {
                   
                    var tempdt = new DataTable();
                    var new_report = new XtraReport();
                    switch (dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString())
                    {
                        case "Print Sale Form":
                            new_report = new SALEPROCESSING_PRINT_FRM();
                            break;
                        case "Purchase Listing":
                            new_report = new PURCHASE_LISTING();
                            break;
                        case "Print Purchase Form":
                            new_report = new PURCHASE_ORDER_RPT();
                            break;
                        case "Print Debit Note Form":
                            new_report = new DEBITNOTE_PRINT_FRM();
                            break;
                        case "POS Print":
                            new_report = new POS_RPT();
                            break;
                        case "Print Credit Note Form":
                            new_report = new CREDITNOTE_RPT();
                            break;
                        case "Supplier Listing":
                            new_report = new SUPPLIER_LISTING_RPT();
                            break;
                        case "Movement Listing":
                            new_report = new MOVEMENT_LISTING_RPT();
                            break;
                        case "Inventory Movement":
                            new_report = new MOVEMENT_INVENTORY_RPT();
                            break;
                        case "Inventory Movement Amount":
                            new_report = new INVENTORY_MOVEMNET_AMOUNT_RPT();
                            break;
                        case "Inventory Transfer":
                            new_report = new INVENTORY_TRANSFER_RPT();
                            break;
                        case "Sale Listing":
                            new_report = new SALE_LISTING_RPT();
                            break;
                        case "Customer Listing":
                            new_report = new CUSTOMER_LISTING_RPT();
                            break;
                        case"Inventory Listing Items":
                            new_report = new INVENTORY_LISTING_ITEM_RPT();
                            break;
                        case "Inventory Listing Location":
                            new_report = new INVENTORY_LISTING_LOC_RPT();
                            break;
                        case "Print Barcode":
                            new_report = new PRINT_BARCODE_RPT();
                            break;

                            
                    }
                    var dt = _dataManager.GetData("SELECT REP_DATA FROM SIREPORT", "REP_TYPE", "REP_TYPE",
                                                  dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString(), "REP_CODE",
                                                  dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0][0].ToString().Trim() != "")
                        {
                            if (System.IO.File.Exists(File))
                            {
                                System.IO.File.Delete(File);
                            }
                            var fs = new FileStream(File, FileMode.CreateNew);
                            var fr = new StreamWriter(fs);
                            fr.Write(dt.Rows[0][0]);
                            fr.Close();
                            fs.Close();
                            reportDesign.xrDesignPanel1.OpenReport(File);
                            System.IO.File.Delete(File);
                        }
                        else
                        {
                            reportDesign.xrDesignPanel1.OpenReport(new_report);
                        }
                    }
                    else
                    {
                        reportDesign.xrDesignPanel1.OpenReport(new_report);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Your report have been corrupted please clear format and reformat.", "Currupted",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                reportDesign.WindowState = FormWindowState.Maximized;
                if (reportDesign.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        var rep_data = "";
                        if (System.IO.File.Exists(File))
                        {
                            var fs = new FileStream(File, FileMode.Open);
                            var fr = new StreamReader(fs);
                            rep_data = fr.ReadToEnd();
                            fr.Close();
                            fs.Close();
                            System.IO.File.Delete(File);
                        }
                        var year = DateTime.Now.Year.ToString();
                        var month = DateTime.Now.Month.ToString();
                        var hour = DateTime.Now.Hour.ToString();
                        var minute = DateTime.Now.Minute.ToString();
                        var second = DateTime.Now.Second.ToString();
                        var concat = year + month + hour + minute + second; 
                        var cmd = new SqlCommand("UPDATE SIREPORT SET REP_DATA=@REP_DATA, DATE_UPDT = @DATEUPDT WHERE REP_TYPE=@REP_TYPE AND REP_CODE=@REP_CODE",_connection.Connect());
                        cmd.Parameters.AddWithValue("@REP_TYPE", dataGridViewX1.SelectedRows[0].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@REP_CODE", dataGridViewX1.SelectedRows[0].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@DATEUPDT", Convert.ToInt64(concat));
                        cmd.Parameters.AddWithValue("@REP_DATA", rep_data);
                        cmd.ExecuteNonQuery();
                        Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
            }
          
        }
    }
}
