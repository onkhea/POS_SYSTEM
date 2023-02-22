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
    public partial class SIUNITCONVERT_FRM : DevComponents.DotNetBar.Office2007Form
    {
        #region Global Variable

        private readonly OutLook outLook = new OutLook();
        private string STRTMP = "";
        readonly SISecurity security = new SISecurity();
        readonly SISubMenuItems  subMenuItems = new SISubMenuItems();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SIUnitConversion siUnitConversion = new SIUnitConversion();
        readonly DataManager dataManager = new DataManager();
// ReSharper disable FieldCanBeMadeReadOnly
        DateTimes dateTimes = new DateTimes();
// ReSharper restore FieldCanBeMadeReadOnly
        readonly Controls controls = new Controls();
        readonly Connection.Connection connection = new Connection.Connection();
        List<string> Clone = new List<string>();
        SIUnitConversion unitConversion = new SIUnitConversion();
        #endregion

        public SIUNITCONVERT_FRM()
        {
            InitializeComponent();
        }

        private void SIUNITCONVERT_FRM_Load(object sender, EventArgs e)
        {
            var dt = siUnitConversion.LoadData();
            outLook.showDGV(DataGridView1, dt, "");
            outLook.loadSearch(DataGridView1, dt, "CONV_FROM", ListView1, ContextMenuStrip2, ToolStrip2, SplitContainer1, SearchPanel);
        }

        #region ToolStrip1

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
//      
            
            var addunitconvert_FRM = new ADDUNITCONVERT_FRM();
            if (security.CheckPermission(UserLogOn.Code, menuItems.UnitConversion, "V", subMenuItems.NewLine, true) ==
              false)
                return;
            addunitconvert_FRM.Text = "Add Unit Conversion";
            addunitconvert_FRM.txtconvt.DataSource = unitConversion.GetConvertTo();
            addunitconvert_FRM.txtconvt.DisplayMember = "CONV_TO";
//            addunitconvert_FRM.cbooperator.SelectedIndex = 0;
            if (addunitconvert_FRM.ShowDialog()== DialogResult.OK)
            {
//                ============= sign values =================
                unitConversion.Conv_From = addunitconvert_FRM.cboconvf.Text;
                unitConversion.Convert_From_Desc = addunitconvert_FRM.TxtdescF1.Text;
                unitConversion.Convert_FromDescKh = addunitconvert_FRM.txtDescF2.Text;
                unitConversion.Convrt_To = addunitconvert_FRM.txtconvt.Text;
                unitConversion.Convert_To_Desc = addunitconvert_FRM.txtDescT1.Text;
                unitConversion.Convert_To_DescKh = addunitconvert_FRM.txtDescT2.Text;
                unitConversion.Aggregation = addunitconvert_FRM.cbooperator.Text;
                unitConversion.Factor = addunitconvert_FRM.txtfactor.Text;
                unitConversion.Trans_Pres = "N";
                unitConversion.UserCreate = dateTimes.Now();
                unitConversion.UserUPDT = dateTimes.Now();
              
//                ====================  Save Data ===================
                var value = new string[] {unitConversion.Conv_From,unitConversion.Convert_From_Desc,unitConversion.Convert_FromDescKh,
                            unitConversion.Convrt_To,unitConversion.Convert_To_Desc,unitConversion.Convert_To_DescKh,
                unitConversion.Aggregation.Substring(0,1),unitConversion.Factor,unitConversion.Trans_Pres,unitConversion.UserUPDT,unitConversion.UserCreate,UserLogOn.Code};
                unitConversion.Save(value);

//                ============ Add Data To Grid ===================== 
                var val = new string[] {unitConversion.Conv_From,unitConversion.Convert_From_Desc,unitConversion.Convert_FromDescKh,
                            unitConversion.Convrt_To,unitConversion.Convert_To_Desc,unitConversion.Convert_To_DescKh,
                unitConversion.Aggregation.Substring(4,unitConversion.Aggregation.Length - 4),unitConversion.Factor,unitConversion.Trans_Pres,unitConversion.UserUPDT,unitConversion.UserCreate,UserLogOn.Code};
                controls.AddToDataGridView(DataGridView1,val);
                MessageBox.Show("Record have been created!", "Successful", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                addunitconvert_FRM.Close();
           }
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.UnitConversion, "V", subMenuItems.EditUnitConvert, true) ==
             false)
                    return;
                var unitConversion = new SIUnitConversion();
                UserLogOn.Code = "SISA";
                if (DataGridView1.SelectedRows.Count > 0)
                {
                    var addunitconvertFrm = new ADDUNITCONVERT_FRM {Text = "Edit Unit Conversion"};

                    unitConversion.Conv_From = (string) DataGridView1.SelectedRows[0].Cells[0].Value;
                    unitConversion.Convert_From_Desc = (string)DataGridView1.SelectedRows[0].Cells[1].Value;
                    unitConversion.Convert_FromDescKh = (string)DataGridView1.SelectedRows[0].Cells[2].Value;
                    unitConversion.Convrt_To = (string)DataGridView1.SelectedRows[0].Cells[3].Value;
                    unitConversion.Convert_To_Desc = (string)DataGridView1.SelectedRows[0].Cells[4].Value;
                    unitConversion.Convert_To_DescKh = (string)DataGridView1.SelectedRows[0].Cells[5].Value;
                    unitConversion.Aggregation = (string)DataGridView1.SelectedRows[0].Cells[6].Value;
                    unitConversion.Factor = DataGridView1.SelectedRows[0].Cells[7].ToString();
                    unitConversion.Trans_Pres = "N";
                    unitConversion.UserCreate = dateTimes.Now();
                    unitConversion.UserUPDT = dateTimes.Now();
                    if (dataManager.Exists("SIUNITCONV", unitConversion.Conv_From, "CONV_FROM"))
                    {
                        addunitconvertFrm.cboconvf.Enabled = false;
                    }
                    
                    var ctls = new Control[]
                                   {
                                       addunitconvertFrm.cboconvf,addunitconvertFrm.TxtdescF1, addunitconvertFrm.txtDescF2,
                                       addunitconvertFrm.txtconvt,addunitconvertFrm.txtDescT1,addunitconvertFrm.txtDescT2,
                                       addunitconvertFrm.cbooperator,addunitconvertFrm.txtfactor,
                                   };
                    unitConversion.BindingDataToControl(ctls, DataGridView1);
                    if (addunitconvertFrm.ShowDialog() == DialogResult.OK)
                    {
                        unitConversion.Conv_From = addunitconvertFrm.cboconvf.Text;
                        unitConversion.Convert_From_Desc = addunitconvertFrm.TxtdescF1.Text;
                        unitConversion.Convert_FromDescKh = addunitconvertFrm.txtDescF2.Text;
                        unitConversion.Convrt_To = addunitconvertFrm.txtconvt.Text;
                        unitConversion.Convert_To_Desc = addunitconvertFrm.txtDescT1.Text;
                        unitConversion.Convert_To_DescKh = addunitconvertFrm.txtDescT2.Text;
                        unitConversion.Aggregation = addunitconvertFrm.cbooperator.Text;
                        unitConversion.Factor = addunitconvertFrm.txtfactor.Text;
                        unitConversion.Trans_Pres = "N";
                        unitConversion.UserCreate = dateTimes.Now();
                        unitConversion.UserUPDT = dateTimes.Now();

                        var value = new[]
                                        {
                                            "CONV_F_DESC", unitConversion.Convert_From_Desc,
                                            "CONV_F_DESCKH", unitConversion.Convert_FromDescKh,
                                            "CONV_TO", unitConversion.Convrt_To,
                                            "CONV_T_DESC", unitConversion.Convert_To_Desc,
                                            "CONV_T_DESCKH", unitConversion.Convert_To_DescKh,
                                            "OPERATOR", unitConversion.Aggregation.Substring(0, 1),
                                            "FACTOR", unitConversion.Factor,
                                            "USER_UPDT",dateTimes.Now(),"USER_CODE",UserLogOn.Code
                                        };

                        var condition = new[] { "CONV_FROM", unitConversion.Conv_From };
                        unitConversion.Update(value, condition);

                        var values = new[]
                                         {
                                             unitConversion.Conv_From, unitConversion.Convert_From_Desc,
                                             unitConversion.Convert_FromDescKh, unitConversion.Convrt_To,
                                             unitConversion.Convert_To_Desc,
                                             unitConversion.Convert_To_DescKh,
                                             unitConversion.Aggregation.Substring(4,
                                                                                  unitConversion.Aggregation.Length - 4),
                                             unitConversion.Factor
                                         };
                        controls.UpdateDataToGridView(DataGridView1, values);
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
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.UnitConversion, "V", subMenuItems.DeleteUnitConvert, true) ==
             false)
                    return;
                if (DataGridView1.SelectedRows.Count > 0)
                {
                    var values = new string[]
                                     {
                                         "CONV_FROM", DataGridView1.SelectedRows[0].Cells[1].ToString(), "CONV_TO",
                                         DataGridView1.SelectedRows[0].Cells[2].ToString(), "TRANS_PRES", "Y"
                                     };
                    if (dataManager.Exists("SIUNITCONV",values))
                    {
                        MessageBox.Show("Cannot delete this record. Transactions present!", "Confirm Delete",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Cursor = Cursors.WaitCursor;
                        var str = new string[]
                                      {
                                          "CONV_FROM",
                                          DataGridView1.SelectedRows[0].Cells[0].Value.ToString(),"CONV_TO",
                                          DataGridView1.SelectedRows[0].Cells[3].Value.ToString()
                                      };
                        siUnitConversion.Delete(str);
                        DataGridView1.Rows.Remove(DataGridView1.SelectedRows[0]);
                        MessageBox.Show("Record was deleted successfully!", "Successfull", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.UnitConversion, "V", subMenuItems.CloneLine, true) ==
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

            if (security.CheckPermission(UserLogOn.Code, menuItems.UnitConversion, "V", subMenuItems.PasteLine, true) ==
            false)
                return;
            if (this.Clone.Count > 0)
            {
                try
                {
                    var addunitconvert_FRM = new ADDUNITCONVERT_FRM();
                    addunitconvert_FRM.Text = "Past Item Record";
                    addunitconvert_FRM.cboconvf.Text = Clone[0];
                    addunitconvert_FRM.TxtdescF1.Text = Clone[1];
                    addunitconvert_FRM.txtDescF2.Text = Clone[2];
                    addunitconvert_FRM.txtconvt.Text = Clone[3];
                    addunitconvert_FRM.txtDescT1.Text = Clone[4];
                    addunitconvert_FRM.txtDescT2.Text = Clone[5];
                    if (Clone[6] == "Multiply")
                    {
                        addunitconvert_FRM.cbooperator.Text = "* - " + Clone[6];    
                    }
                    else
                    {
                        addunitconvert_FRM.cbooperator.Text = "/ - " + Clone[6];  
                    }
                    addunitconvert_FRM.txtfactor.Text = Clone[7];
                    if (addunitconvert_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
//                        ====== TODO: Not yet complete============
                        unitConversion.Conv_From = addunitconvert_FRM.cboconvf.Text;
                        unitConversion.Convert_From_Desc = addunitconvert_FRM.TxtdescF1.Text;
                        unitConversion.Convert_FromDescKh = addunitconvert_FRM.txtDescF2.Text;
                        unitConversion.Convrt_To = addunitconvert_FRM.txtconvt.Text;
                        unitConversion.Convert_To_Desc = addunitconvert_FRM.txtDescT1.Text;
                        unitConversion.Convert_To_DescKh = addunitconvert_FRM.txtDescT2.Text;
                        unitConversion.Aggregation = addunitconvert_FRM.cbooperator.Text;
                        unitConversion.Factor = addunitconvert_FRM.txtfactor.Text;
                        unitConversion.Trans_Pres = "N";
                        unitConversion.UserCreate = dateTimes.Now();
                        unitConversion.UserUPDT = dateTimes.Now();

                        //                ====================  Save Data ===================
                        var value = new string[] {unitConversion.Conv_From,unitConversion.Convert_From_Desc,unitConversion.Convert_FromDescKh,
                            unitConversion.Convrt_To,unitConversion.Convert_To_Desc,unitConversion.Convert_To_DescKh,
                unitConversion.Aggregation.Substring(0,1),unitConversion.Factor,unitConversion.Trans_Pres,unitConversion.UserUPDT,unitConversion.UserCreate,UserLogOn.Code};
                        unitConversion.Save(value);

                        controls.AddToDataGridView(DataGridView1, unitConversion.Conv_From,
                                                   unitConversion.Convert_From_Desc,"", unitConversion.Convrt_To, unitConversion.Convert_To_Desc,"",
                                                   unitConversion.Aggregation.Substring(4,unitConversion.Aggregation.Length - 4),unitConversion.Factor);

                    }
                    Cursor = Cursors.Default;
                    addunitconvert_FRM.Close();
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

        private void ExcelTool_Click(object sender, EventArgs e)
        {
             if (security.CheckPermission(UserLogOn.Code, menuItems.UnitConversion, "V", subMenuItems.ExportDatatoExcel, true) ==
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
            if (security.CheckPermission(UserLogOn.Code, menuItems.UnitConversion, "V", subMenuItems.SearchData, true) ==
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
//                outLook.showDGV(DataGridView1, employee.LoadData(), "SI_LOOKUP");
//                DefaultAllToolStripMenuItem.Checked = true;
//                ActiveToolStripMenuItem.Checked = false;
//                DisableToolStripMenuItem.Checked = false;
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

        #region Views

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
            LinkLabel1_LinkClicked(null,null);
        }

        #endregion

        #region ContextMenuStrip1

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTool_Click(sender,e);
        }

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelTool_Click(sender,e);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var unitConversion = new SIUnitConversion();
            outLook.showDGV(DataGridView1, unitConversion.LoadData(), "");
        }

        #endregion

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

        #region ToolStrip2

        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveToolStripMenuItem.Visible = true;
            removesep.Visible = true;
            STRTMP = e.ClickedItem.Name;
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

        #endregion

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            var ss = new string[] {};
            var cod = new OutLook();
            cod.searching(connection.Connect(), DataGridView1, "SELECT CONV_FROM, CONV_F_DESC, CONV_F_DESCKH, CONV_TO, CONV_T_DESC, CONV_T_DESCKH,(CASE WHEN OPERATOR='*' THEN 'Multiply' ELSE 'Divide' END) OPERATOR, FACTOR, TRANS_PRES, USER_CREA, USER_UPDT, USER_CODE FROM dbo.SIUNITCONV ", "CONV_FROM", ToolStrip2, ToolStrip3, "", ss);
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

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SelectNextControl(DataGridView1, true, true, true, true);
        }

        private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            outLook.addcreteria(ContextMenuStrip2, ToolStrip2, SearchPanel, RemoveToolStripMenuItem, e, STRTMP);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            controls.CheckOnListView(ListView1, chbS);
        }

        private void chbS_CheckedChanged(object sender, EventArgs e)
        {
            controls.CheckOnListView(ListView1,chbS);
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
