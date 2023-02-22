using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Reports.Unit_Conversion_Type;
using POS.Transaction;
using POS.Transaction.Report.UnitConversion;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.Reports
{
    public partial class ReportUnitConversion : Form
    {
        public ReportUnitConversion()
        {
            InitializeComponent();
        }

        #region Global Variable

        readonly DataManager _dataManager = new DataManager();
        readonly UnitConvertReport _unitConvertReport = new UnitConvertReport();
        readonly OutLook _outLook = new OutLook();
        readonly List<string> _clone = new List<string>();
        readonly SISecurity _security = new SISecurity();
        readonly SIMenuItems _menuItems = new SIMenuItems();
        readonly SISubMenuItems _subMenuItems  = new SISubMenuItems();

        #endregion

        private void ToolNewUnitType_Click(object sender, EventArgs e)
        {
            if (_security.CheckPermission(UserLogOn.Code, _menuItems.ReportUnitConversion, "V", _subMenuItems.NewLine, true) ==
          false)
                return;
            var addunittypeconvertreport = new ADDUNITTYPECONVERTREPORT();
            try
            {
                lbl:
                if (addunittypeconvertreport.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    if (_dataManager.Exists("SIPDATA","UCREP","SI_TYPE","SI_CODE",addunittypeconvertreport.txtCode.Text))
                    {
                        MessageBox.Show("Data '" + addunittypeconvertreport.txtCode.Text + "' already exists.",
                                        "Already", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addunittypeconvertreport.txtCode.SelectAll();
                        addunittypeconvertreport.txtCode.Focus();
                        goto lbl;
                    }
                    var value = new[]
                                    {
                                        addunittypeconvertreport.txtCode.Text, "UCREP", "",
                                        addunittypeconvertreport.txtDesc.Text.PadRight(100, ' ') +
                                        addunittypeconvertreport.txtComment1.Text.PadRight(100, ' ') +
                                        addunittypeconvertreport.txtComment2.Text.PadRight(100, ' '), "",
                                        DateTime.Now.ToString(),
                                        UserLogOn.Code, DateTime.Now.ToString()};
                    _unitConvertReport.Save(value);
                    TreeNode tn = TreeView1.Nodes[0].Nodes.Add(addunittypeconvertreport.txtCode.Text,
                                                               addunittypeconvertreport.txtCode.Text, 1, 0);
                    tn.Tag = "ITEM";
                    tn.ToolTipText = addunittypeconvertreport.txtDesc.Text;
                    var i = dgMaster.Rows.Add(addunittypeconvertreport.txtCode.Text, addunittypeconvertreport.txtDesc.Text,
                                              addunittypeconvertreport.txtComment1.Text,
                                              addunittypeconvertreport.txtComment2.Text, "", "", UserLogOn.Code,
                                              DateTime.Now.ToString());
                    dgMaster.SelectedRows[0].Selected = false;
                    dgMaster.Rows[i].Selected = true;
                    MessageBox.Show("Record has been created successully", "Successfully", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                }
                addunittypeconvertreport.Close();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
//           
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            #region Master

            try
            {
                TreeView1.Cursor = Cursors.WaitCursor;
                dgMaster.Rows.Clear();
                dgDetail.Rows.Clear();
                ToolNewUnitType.Visible = false;
                toolStripEditUnitType.Visible = false;
                toolStripDeleteUnType.Visible = false;
                toolStripToolUnType.Visible = false;
                dgMaster.Visible = false;
                dgDetail.Visible = false;
                toolStripNewSubUnType.Visible = false;
                toolStripEditSubUnType.Visible = false;
                toolStripDeleteUnitType.Visible = false;
                toolStripToolSubUnType.Visible = false;
                if ((string) TreeView1.SelectedNode.Tag == "ITEM")
                {
                    toolStripNewSubUnType.Visible = true;
                    toolStripEditSubUnType.Visible = true;
                    toolStripDeleteUnType.Visible = true;
                    toolStripToolSubUnType.Visible = true;
                    label2.Text = "Unit convert Report Detail";
                    dgDetail.Visible = true;
                    var dt =
                        _dataManager.GetData(
                            "SELECT SI_CODE,RTRIM(SUBSTRING(SI_DATA,1,15)),RTRIM(SUBSTRING(SI_DATA,16,50)) [Item Description],RTRIM(SUBSTRING(SI_DATA,66,5)) [Unit of Report],RTRIM(SUBSTRING(SI_DATA,71,100)) [Comment],RTRIM(SUBSTRING(SI_DATA,171,100)) [Sec. Comments],USER_UPDT,CASE WHEN RTRIM(USER_UPDT)='' THEN '' ELSE CAST(DATE_UPDT AS NVARCHAR) END,USER_CREA,CAST(DATE_CREA AS NVARCHAR) FROM SIPDATA",
                            "SI_CODE", "SI_TYPE", "UCRED", "SI_LOOKUP", TreeView1.SelectedNode.Text);
                    var i = dt.Rows.Count;
                    foreach (DataRow row in dt.Rows)
                    {
                        dgDetail.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[6], row[7], row[8], row[9], row[5]);
                    }

                }
                else
                {
                    ToolNewUnitType.Visible = true;
                    toolStripEditUnitType.Visible = true;
                    toolStripDeleteUnitType.Visible = true;
                    toolStripToolUnType.Visible = true;
                    dgMaster.Visible = true;
                    var dtl =
                        _dataManager.GetData(
                            "SELECT SI_CODE,RTRIM(SUBSTRING(SI_DATA,1,100)) [Description],RTRIM(SUBSTRING(SI_DATA,101,100)) [First Comment],RTRIM(SUBSTRING(SI_DATA,201,100)) [Sec. Comments],USER_UPDT,CASE WHEN RTRIM(USER_UPDT)='' THEN '' ELSE CAST(DATE_UPDT AS NVARCHAR) END,USER_CREA,CAST(DATE_CREA AS NVARCHAR) FROM SIPDATA",
                            "SI_CODE", "SI_TYPE", "UCREP");
                    foreach (DataRow row in dtl.Rows)
                    {
                        dgMaster.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6],row[7]);
                    }
                }
                TreeView1.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                TreeView1.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }

            #endregion

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                TreeView1.Cursor = Cursors.WaitCursor;
                var dt =
                    _dataManager.GetData(
                        "SELECT SI_CODE,RTRIM(SUBSTRING(SI_DATA,1,100)) [Description],RTRIM(SUBSTRING(SI_DATA,101,100)) [First Comment],RTRIM(SUBSTRING(SI_DATA,201,100)) [Sec. Comments],USER_UPDT,CASE WHEN RTRIM(USER_UPDT)='' THEN '' ELSE CAST(DATE_UPDT AS NVARCHAR) END,USER_CREA,CAST(DATE_CREA AS NVARCHAR) FROM SIPDATA",
                        "SI_CODE", "SI_TYPE", "UCREP");
                TreeNode tn;
                TreeView1.Nodes[0].Nodes.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    tn = TreeView1.Nodes[0].Nodes.Add(row[0].ToString(), row[0].ToString(), 1, 0);
                    tn.Tag = "ITEM";
                    tn.ToolTipText = row[1].ToString();

                    var dtl = _dataManager.GetData("SELECT SI_CODE FROM SIPDATA", "SI_CODE", "SI_TYPE", "UCRED",
                                                  "SI_LOOKUP", row[0].ToString());
                    if (dtl.Rows.Count > 0)
                    {
                        tn.NodeFont = new Font("Microsoft Sans Serif",8,FontStyle.Bold);
                    }
                }
                TreeView1.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                TreeView1.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void ReportUnitConversion_Load(object sender, EventArgs e)
        {
            TreeView1.Nodes[0].Expand();
        }

        private void toolStripEditUnitType_Click(object sender, EventArgs e)
        {
            if (_security.CheckPermission(UserLogOn.Code, _menuItems.ReportUnitConversion, "V", _subMenuItems.EditLine, true) ==
          false)
                return;
            if (dgMaster.SelectedRows.Count > 0)
            {
                var addunittypeconvertreport = new ADDUNITTYPECONVERTREPORT();
                Cursor = Cursors.WaitCursor;
                var dgRow = dgMaster.SelectedRows[0];
                addunittypeconvertreport.Text = "Edit Convert Type";
                addunittypeconvertreport.txtCode.Text = dgRow.Cells[0].Value.ToString();
                addunittypeconvertreport.txtCode.Enabled = false;
                addunittypeconvertreport.txtDesc.Text = dgRow.Cells[1].Value.ToString();
                addunittypeconvertreport.txtComment1.Text = dgRow.Cells[2].Value.ToString();
                addunittypeconvertreport.txtComment2.Text = dgRow.Cells[3].Value.ToString();
                Cursor = Cursors.Default;
                if (addunittypeconvertreport.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        var paramAndValue = new[]
                                                {
                                                    "SI_DATA",
                                                    addunittypeconvertreport.txtDesc.Text.PadRight(100, ' ') +
                                                    addunittypeconvertreport.txtComment1.Text.PadRight(100, ' ') +
                                                    addunittypeconvertreport.txtComment2.Text.PadRight(100, ' '),
                                                    "USER_UPDT",UserLogOn.Code,"DATE_UPDT",DateTime.Now.ToString()
                                                };
                        var condition = new[]
                                            {
                                                "SI_CODE", addunittypeconvertreport.txtCode.Text, "SI_TYPE", "UCREP",
                                                "SI_LOOKUP", ""
                                            };

                        _unitConvertReport.Update(paramAndValue, condition);

                        SIDataGridView.BindingData_ToGrid_OnSelected(dgMaster, addunittypeconvertreport.txtCode.Text,
                                                                     addunittypeconvertreport.txtDesc.Text,
                                                                     addunittypeconvertreport.txtComment1.Text,
                                                                     addunittypeconvertreport.txtComment2.Text,
                                                                     UserLogOn.Code, DateTime.Now.ToString());
                        Cursor = Cursors.Default;
                        MessageBox.Show("Record have been edited successfully", "Successfully", MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message);
                    }
                    addunittypeconvertreport.Close();
                }
            }
        }

        private void toolStripDeleteUnitType_Click(object sender, EventArgs e)
        {
            if (_security.CheckPermission(UserLogOn.Code, _menuItems.ReportUnitConversion, "V", _subMenuItems.DeleteLine, true) ==
          false)
                return;
            if (MessageBox.Show("Do you want to remove this line?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                TreeNode N = null;
                foreach (TreeNode node in TreeView1.Nodes[0].Nodes)
                {
                    if (node.Text ==  dgMaster.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        N = node;
                        break;
                    }
                }
                if (N == null)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Delete fialed, refresh and try again!");
                    return;
                }
                
//                ============ Delete Master
                var condition = new[]
                                    {
                                        "SI_CODE", dgMaster.SelectedRows[0].Cells[0].Value.ToString(), "SI_TYPE",
                                        "UCREP", "SI_LOOKUP", ""
                                    };
                _unitConvertReport.Delete(condition);

//                ==============  Delete Detail ==========

                condition = new[]
                                 {
                                      "SI_CODE", dgMaster.SelectedRows[0].Cells[0].Value.ToString(), "SI_TYPE",
                                      "UCRED", "SI_LOOKUP", dgMaster.SelectedRows[0].Cells[0].Value.ToString()
                                  };
                _unitConvertReport.Delete(condition);

                N.Remove();
                dgMaster.Rows.RemoveAt(dgMaster.SelectedRows[0].Index);
                
                MessageBox.Show("Remove successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripCloneUnType_Click(object sender, EventArgs e)
        {
            if (_security.CheckPermission(UserLogOn.Code, _menuItems.ReportUnitConversion, "V", _subMenuItems.CloneLine, true) ==
         false)
                return;
            _clone.Clear();
            Cursor = Cursors.WaitCursor;
            _outLook.CloneData(_clone, dgMaster);
            toolStripPastUnType.Enabled = true;
            contextMastClone.Checked = true;
            contextMastPaste.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void contextMastClone_Click(object sender, EventArgs e)
        {
           toolStripCloneUnType_Click(null,null);
        }

        private void toolStripPastUnType_Click(object sender, EventArgs e)
        {
            try
            {
                 var addunittypeconvertreport = new ADDUNITTYPECONVERTREPORT();
            _outLook.PasteData(_clone, addunittypeconvertreport.txtCode, addunittypeconvertreport.txtDesc,
                               addunittypeconvertreport.txtComment1, addunittypeconvertreport.txtComment2);
            lbl:
            if (addunittypeconvertreport.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                if (_dataManager.Exists("SIPDATA", "UCREP", "SI_TYPE", "SI_CODE", addunittypeconvertreport.txtCode.Text))
                {
                    MessageBox.Show("Data '" + addunittypeconvertreport.txtCode.Text + "' already exists.",
                                    "Already", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    addunittypeconvertreport.txtCode.SelectAll();
                    addunittypeconvertreport.txtCode.Focus();
                    goto lbl;
                }
                var value = new[]
                                {
                                    addunittypeconvertreport.txtCode.Text, "UCREP", "",
                                    addunittypeconvertreport.txtDesc.Text.PadRight(100, ' ') +
                                    addunittypeconvertreport.txtComment1.Text.PadRight(100, ' ') +
                                    addunittypeconvertreport.txtComment2.Text.PadRight(100, ' '), "",
                                    DateTime.Now.ToString(),
                                    UserLogOn.Code, DateTime.Now.ToString()
                                };
                _unitConvertReport.Save(value);
                TreeNode tn = TreeView1.Nodes[0].Nodes.Add(addunittypeconvertreport.txtCode.Text,
                                                           addunittypeconvertreport.txtCode.Text, 1, 0);
                tn.Tag = "ITEM";
                tn.ToolTipText = addunittypeconvertreport.txtDesc.Text;
                var i = dgMaster.Rows.Add(addunittypeconvertreport.txtCode.Text, addunittypeconvertreport.txtDesc.Text,
                                          addunittypeconvertreport.txtComment1.Text,
                                          addunittypeconvertreport.txtComment2.Text, "", "", UserLogOn.Code,
                                          DateTime.Now.ToString());
                dgMaster.SelectedRows[0].Selected = false;
                dgMaster.Rows[i].Selected = true;
                MessageBox.Show("Record has been created successully", "Successfully", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                Cursor = Cursors.Default;
                addunittypeconvertreport.Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        #region Export To Excel

        private void toolStripExcelUnType_Click(object sender, EventArgs e)
        {

//            if (_security.CheckPermission(UserLogOn.Code, _menuItems.ReportUnitConversion, "V", _subMenuItems.ExportExcel, true) ==
//        false)
//                return;
            listView.Items.Clear();
            for (int i = 0; i < dgMaster.Columns.Count - 1; i++)
            {
                listView.Items.Add(dgMaster.Columns[i].HeaderText);
                if (dgMaster.Columns[i].Visible)
                {
                    listView.Items[listView.Items.Count - 1].Checked = true;
                }
            }
            _outLook.ExportToExcel(listView,bgWork);
        }

        private void bgWork_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _outLook.BackGround_DdWork(dgMaster,listView);
        }

        private void bgWork_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _outLook.BackGroud_ProgressChanged(e);
        }

        private void bgWork_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            _outLook.BackGround_RunWorkedCompleted();
        }

        private void contextMastExcel_Click(object sender, EventArgs e)
        {
            toolStripExcelUnType_Click(null,null);
        }

        #endregion

        //        =======================  Detail Unit Conversion ================

        #region  Unit Report details

        private void toolStripNewSubUnType_Click(object sender, EventArgs e)
        {
//            if (
//                _security.CheckPermission(UserLogOn.Code, _menuItems.ReportUnitConversion, "V", _subMenuItems.NewLine,
//                                          true) ==
//                false)
//                return;

            var addnewuniconvreportdetailFrm = new ADDNEWUNICONVREPORTDETAIL_FRM();
            lbl:
            if (addnewuniconvreportdetailFrm.ShowDialog() == DialogResult.OK)
            {

                if ((string) TreeView1.SelectedNode.Tag == "ITEM")
                {
                    Cursor = Cursors.WaitCursor;
                    var sicode =
                        DataAccess.ReturnField("SELECT MAX(SI_CODE) FROM dbo.SIPDATA WHERE SI_TYPE = 'UCRED'", 0) == ""
                            ? 1
                            : Convert.ToInt32(
                                  DataAccess.ReturnField(
                                      "SELECT MAX(SI_CODE) FROM dbo.SIPDATA WHERE SI_TYPE = 'UCRED'", 0)) + 1;
                    var data =
                        _dataManager.GetData("SELECT * FROM  dbo.SIPDATA WHERE SI_LOOKUP = '" +
                                             TreeView1.SelectedNode.Text +
                                             "' AND SI_TYPE = 'UCRED' AND SUBSTRING(SI_DATA,1,15) = '" +
                                             addnewuniconvreportdetailFrm.txtItemCode.Text +
                                             "'");
                    if (data.Rows.Count > 0)
                    {
                        Cursor = Cursors.WaitCursor;
                        MessageBox.Show("This item is already.", "Exist", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        addnewuniconvreportdetailFrm.txtItemCode.Focus();
                       goto lbl;
                    }

                    var values = new[]
                                     {
                                         sicode.ToString(), "UCRED", TreeView1.SelectedNode.Text,
                                         addnewuniconvreportdetailFrm.txtItemCode.Text.PadRight(15, ' ') +
                                         addnewuniconvreportdetailFrm.txtItemDescription.Text.PadRight(50, ' ') +
                                         addnewuniconvreportdetailFrm.txtUnitofSale.Text.PadRight(5,' ') +
                                         addnewuniconvreportdetailFrm.txtComment1.Text.PadRight(100, ' ') +
                                         addnewuniconvreportdetailFrm.txtComment2.Text.PadRight(100, ' '),
                                         "", DateTime.Now.ToString(), UserLogOn.Code, DateTime.Now.ToString()
                                     };

                    _unitConvertReport.Save(values);

                    var i = dgDetail.Rows.Add(sicode.ToString(), addnewuniconvreportdetailFrm.txtItemCode.Text,
                                              addnewuniconvreportdetailFrm.txtItemDescription.Text,
                                              addnewuniconvreportdetailFrm.txtUnitofSale.Text,
                                              addnewuniconvreportdetailFrm.txtComment1.Text,
                                              UserLogOn.Code,
                                              DateTime.Now.ToString(),"","",addnewuniconvreportdetailFrm.txtComment2.Text);
//                    dgDetail.SelectedRows.Clear();
                    dgDetail.Rows[0].Selected = false;
                    dgDetail.Rows[i].Selected = true;
                    if (dgDetail.Rows.Count > 0)
                    {
                        TreeView1.SelectedNode.NodeFont = new Font("Microsoft Sans Serif", 8,
                                                                   FontStyle.Bold);
                    }
                    MessageBox.Show("Record has been created successfully", "Successfully", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Please Select On Tree View to add new data", "Select", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }
            }
        }

        private void TreeView1_BeforeExpand_1(object sender, TreeViewCancelEventArgs e)
        {
            TreeView1_BeforeExpand(sender,e);
        }

        private void TreeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            TreeView1_AfterSelect(sender, e);
        }

        private void toolStripEditSubUnType_Click(object sender, EventArgs e)
        {
            if (dgDetail.Rows.Count > 0)
            {
                try
                {
                    var addnewuniconvreportdetail = new ADDNEWUNICONVREPORTDETAIL_FRM();

                    Cursor = Cursors.WaitCursor;
                    this.Text = "Edit Unit Convert Report";
                    var dg = dgDetail.SelectedRows[0];
                    addnewuniconvreportdetail.txtItemCode.Text = dg.Cells[1].Value.ToString();
                    addnewuniconvreportdetail.txtItemCode.Enabled = false;
                    addnewuniconvreportdetail.btnItemCode.Enabled = false;
                    addnewuniconvreportdetail.txtItemDescription.Text = dg.Cells[2].Value.ToString();
                    var cond = new[] {"ITEM_CODE", addnewuniconvreportdetail.txtItemCode.Text};
                    addnewuniconvreportdetail.txtUnitofStock.Text =
                        DataAccess.ReturnField("SELECT UNIT_STOCK FROM SIPITEMS", "ITEM_CODE", cond, 0);
                    addnewuniconvreportdetail.txtUnitofSale.Text = dg.Cells[3].Value.ToString();
                    addnewuniconvreportdetail.txtComment1.Text = dg.Cells[4].Value.ToString();
                    addnewuniconvreportdetail.txtComment2.Text = dg.Cells[5].Value.ToString();
                    Cursor = Cursors.Default;
                    if (addnewuniconvreportdetail.ShowDialog() == DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;

                        var paramAndValue = new[]
                                                {
                                                    "SI_DATA",
                                                    addnewuniconvreportdetail.txtItemCode.Text.PadRight(15, ' ') +
                                                    addnewuniconvreportdetail.txtItemDescription.Text.PadRight(50, ' ') +
                                                    addnewuniconvreportdetail.txtUnitofSale.Text.PadRight(5, ' ') +
                                                    addnewuniconvreportdetail.txtComment1.Text.PadRight(100, ' ') +
                                                    addnewuniconvreportdetail.txtComment2.Text.PadRight(100, ' '),
                                                    "USER_UPDT", UserLogOn.Code, "DATE_UPDT", DateTime.Now.ToString()

                                                };
                        var condition = new[]
                                            {
                                                "SI_TYPE", "UCRED", "SI_CODE", dg.Cells[0].Value.ToString(), "SI_LOOKUP",
                                                TreeView1.SelectedNode.Text
                                            };
                        _unitConvertReport.Update(paramAndValue,condition);
                        dgDetail.SelectedRows[0].Cells[1].Value = addnewuniconvreportdetail.txtItemCode.Text;
                        dgDetail.SelectedRows[0].Cells[2].Value = addnewuniconvreportdetail.txtItemDescription.Text;
                        dgDetail.SelectedRows[0].Cells[3].Value = addnewuniconvreportdetail.txtUnitofSale.Text;
                        dgDetail.SelectedRows[0].Cells[4].Value = addnewuniconvreportdetail.txtComment1.Text;
                        dgDetail.SelectedRows[0].Cells[6].Value = UserLogOn.Code;
                        dgDetail.SelectedRows[0].Cells[7].Value = DateTime.Now.ToString();
                        Cursor = Cursors.Default;
                        MessageBox.Show("Record has been edited successfully");
                        addnewuniconvreportdetail.Close();
                    }
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripDeleteUnType_Click(object sender, EventArgs e)
        {
            if (dgDetail.Rows.Count > 0)
            {
                if (MessageBox.Show("Do you want to remove this line?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        var condition = new[]
                                            {
                                                "SI_TYPE", "UCRED", "SI_CODE",
                                                dgDetail.SelectedRows[0].Cells[0].Value.ToString()
                                            };
                        _unitConvertReport.Delete(condition);
                        dgDetail.Rows.Remove(dgDetail.SelectedRows[0]);
                        MessageBox.Show("Record was deleted successfully!", "Successfully", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        dgDetail.Focus();
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

        private void toolStripCloneSubUnType_Click(object sender, EventArgs e)
        {
            if (dgDetail.Rows.Count > 0)
            {
                _clone.Clear();
                _outLook.CloneData(_clone, dgDetail);
                toolStripPasteSubUnType.Enabled = true;
            }
        }

        private void toolStripPasteSubUnType_Click(object sender, EventArgs e)
        {
            try
            {
                var addnewuniconvreportdetailFrm = new ADDNEWUNICONVREPORTDETAIL_FRM();
                var text = new TextBox();
                _outLook.PasteData(_clone, text, addnewuniconvreportdetailFrm.txtItemCode,
                                   addnewuniconvreportdetailFrm.txtItemDescription,
                                   addnewuniconvreportdetailFrm.txtUnitofSale, addnewuniconvreportdetailFrm.txtComment1,
                                   text, text, text, text, addnewuniconvreportdetailFrm.txtComment2);
                addnewuniconvreportdetailFrm.txtUnitofStock.Text =
                    DataAccess.ReturnField(
                        "SELECT UNIT_STOCK FROM SIPITEMS WHERE ITEM_STAT='A' AND ITEM_TYPE= 'S' AND ITEM_CODE = '" +
                        addnewuniconvreportdetailFrm.txtItemCode.Text + "'",0 );
                lbl:
                if (addnewuniconvreportdetailFrm.ShowDialog() == DialogResult.OK)
                {
                    if ((string)TreeView1.SelectedNode.Tag == "ITEM")
                    {
                        Cursor = Cursors.WaitCursor;
                        var sicode =
                            DataAccess.ReturnField("SELECT MAX(SI_CODE) FROM dbo.SIPDATA WHERE SI_TYPE = 'UCRED'", 0) == ""
                                ? 1
                                : Convert.ToInt32(
                                      DataAccess.ReturnField(
                                          "SELECT MAX(SI_CODE) FROM dbo.SIPDATA WHERE SI_TYPE = 'UCRED'", 0)) + 1;
                        var data =
                            _dataManager.GetData("SELECT * FROM  dbo.SIPDATA WHERE SI_LOOKUP = '" +
                                                 TreeView1.SelectedNode.Text +
                                                 "' AND SI_TYPE = 'UCRED' AND SUBSTRING(SI_DATA,1,15) = '" +
                                                 addnewuniconvreportdetailFrm.txtItemCode.Text + "'");
                        if (data.Rows.Count > 0)
                        {
                            Cursor = Cursors.WaitCursor;
                            MessageBox.Show("This item is already.", "Exist", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            addnewuniconvreportdetailFrm.txtItemCode.Focus();
                           
                            goto lbl;
                        }

                        var values = new[]
                                     {
                                         sicode.ToString(), "UCRED", TreeView1.SelectedNode.Text,
                                         addnewuniconvreportdetailFrm.txtItemCode.Text.PadRight(15, ' ') +
                                         addnewuniconvreportdetailFrm.txtItemDescription.Text.PadRight(50, ' ') +
                                         addnewuniconvreportdetailFrm.txtUnitofSale.Text.PadRight(5,' ') +
                                         addnewuniconvreportdetailFrm.txtComment1.Text.PadRight(100, ' ') +
                                         addnewuniconvreportdetailFrm.txtComment2.Text.PadRight(100, ' '),
                                         "", DateTime.Now.ToString(), UserLogOn.Code, DateTime.Now.ToString()
                                     };

                        _unitConvertReport.Save(values);

                        var i = dgDetail.Rows.Add(sicode.ToString(), addnewuniconvreportdetailFrm.txtItemCode.Text,
                                                  addnewuniconvreportdetailFrm.txtItemDescription.Text,
                                                  addnewuniconvreportdetailFrm.txtUnitofSale.Text,
                                                  addnewuniconvreportdetailFrm.txtComment1.Text,
                                                  UserLogOn.Code,
                                                  DateTime.Now.ToString(), "", "", addnewuniconvreportdetailFrm.txtComment2.Text);
                        dgDetail.Rows[dgDetail.SelectedRows[0].Index].Selected = false;
                        dgDetail.Rows[i].Selected = true;
                        if (dgDetail.Rows.Count > 0)
                        {
                            TreeView1.SelectedNode.NodeFont = new Font("Microsoft Sans Serif", 8,
                                                                       FontStyle.Bold);
                        }
                        MessageBox.Show("Record has been created successfully", "Successfully", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Please Select On Tree View to add new data", "Select", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    }
                    
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripExcelSubUnType_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            for (int i = 0; i < dgDetail.Columns.Count ; i++)
            {
                listView.Items.Add(dgDetail.Columns[i].HeaderText);
                if (dgDetail.Columns[i].Visible)
                {
                    listView.Items[listView.Items.Count - 1].Checked = true;
                }
            }
            _outLook.ExportToExcel(listView,bgDetails);
        }

        private void bgDetails_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _outLook.BackGround_DdWork(dgDetail,listView);
        }

        private void bgDetails_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            _outLook.BackGroud_ProgressChanged(e);
        }

        private void bgDetails_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            _outLook.BackGround_RunWorkedCompleted();
        }

        #endregion
    }
}
