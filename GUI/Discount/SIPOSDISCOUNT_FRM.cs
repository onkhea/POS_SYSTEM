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
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Discount
{
    public partial class SIPOSDISCOUNT_FRM : DevComponents.DotNetBar.Office2007Form
    {
        public SIPOSDISCOUNT_FRM()
        {
            InitializeComponent();
        }

        readonly Connection.Connection connection = new Connection.Connection();
        readonly DataManager dataManager = new DataManager();
        readonly OutLook outLook = new OutLook();
        readonly Controls controls = new Controls();
        readonly List<string> Clone = new List<string>();
        private string STRTMP = "";
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        readonly SISecurity security = new SISecurity();

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.POSDiscount, "V", subMenuItems.NewLine, true) ==
           false)
                return;
            var addsiposdiscount = new ADDSIPOSDISCOUNT();
            addsiposdiscount.cboStatus.SelectedIndex = 0;
            addsiposdiscount.cboTimeF.SelectedIndex = 0;
            addsiposdiscount.cboTimeT.SelectedIndex = 0;
        A:
            if (addsiposdiscount.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    object DateF = addsiposdiscount.dtpDateF.Checked == true
                                        ? addsiposdiscount.dtpDateF.Value.ToShortDateString()
                                        : DBNull.Value.ToString();
                    object DateT = addsiposdiscount.dtpDateT.Checked == true
                                    ? addsiposdiscount.dtpDateT.Value.ToShortDateString()
                                    : DBNull.Value.ToString();
                    if (DateT == "")
                    {
                        DateT = DBNull.Value;
                    }
                    if (DateF == "")
                    {
                        DateF = DBNull.Value;
                    }
                    
                    var timeF = addsiposdiscount.cboTimeF.Text.Trim() == "" ? "-1" : addsiposdiscount.cboTimeF.Text;
                    var timeT = addsiposdiscount.cboTimeT.Text.Trim() == "" ? "-1" : addsiposdiscount.cboTimeT.Text;
                    var cond = new string[] { "ITEM_CODE", addsiposdiscount.txtProID.Text };
                    var item_BCode = DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_CODE",
                                                            cond,
                                                            0);
                    var command = new SqlCommand("INSERT INTO SIPOSPRICE VALUES(@LOCATION,@ITEM_CODE,@ITEM_BCODE,@PRO_FDATE,@PRO_TDATE,@PRO_TIMES,@PRO_TIMEE,@PRO_RATE,@UNIT_SALE,@PRO_TYPE,@STATUS)");
                    command.CommandType = CommandType.Text;
                    command.Connection = connection.Connect();
                    var d = addsiposdiscount.txtDiscount.Text;
                    var ddd = d;
                    if ((string)TreeView1.SelectedNode.Tag == "R")
                    {
                        if (dataManager.Exists("SIPOSPRICE", "ITEM_CODE", addsiposdiscount.txtProID.Text, "LOCATION", "",
                                               "UNIT_SALE", addsiposdiscount.txtUnitofSale.Text, "PRO_TYPE", "D"))
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("The discount of item have already exist.", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            goto A;
                        }
                        Commands.CreateParameter(command, "LOCATION", "", "ITEM_CODE", addsiposdiscount.txtProID.Text,
                                            "ITEM_BCODE",item_BCode
                                            , "PRO_FDATE", DateF, "PRO_TDATE", DateT,
                                            "PRO_TIMES", timeF, "PRO_TIMEE", timeT, "PRO_RATE",
                                            addsiposdiscount.txtDiscount.Text, "UNIT_SALE",
                                            addsiposdiscount.txtUnitofSale.Text, "PRO_TYPE", "D", "STATUS",
                                            addsiposdiscount.cboStatus.Text.Substring(0, 1));
                        command.ExecuteNonQuery();
                        var i = dataGridViewX1.Rows.Add(TreeView1.SelectedNode.ToolTipText,
                                                        addsiposdiscount.txtProID.Text, item_BCode,
                                                        addsiposdiscount.txtProName.Text,DateF,DateT,timeF,timeT,
                                                        addsiposdiscount.txtDiscount.Text,addsiposdiscount.txtUnitofSale.Text,
                                                        addsiposdiscount.cboStatus.Text.Substring(4));
                        dataGridViewX1.SelectedRows[0].Selected = false;
                        dataGridViewX1.Rows[i].Selected = true;
                    }
                    else 
                    {
                        if (dataManager.Exists("SIPOSPRICE", "ITEM_CODE", addsiposdiscount.txtProID.Text, "LOCATION", TreeView1.SelectedNode.ToolTipText,
                                               "UNIT_SALE", addsiposdiscount.txtUnitofSale.Text, "PRO_TYPE", "D"))
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("The discount of item have already exist.", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            goto A;
                        }
                        Commands.CreateParameter(command, "LOCATION", TreeView1.SelectedNode.ToolTipText, "ITEM_CODE", addsiposdiscount.txtProID.Text,
                                                 "ITEM_BCODE",
                                                 DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_CODE",
                                                                        cond,
                                                                        0), "PRO_FDATE", DateF, "PRO_TDATE", DateT,
                                                 "PRO_TIMES", timeF, "PRO_TIMEE", timeT, "PRO_RATE",
                                                 addsiposdiscount.txtDiscount.Text, "UNIT_SALE",
                                                 addsiposdiscount.txtUnitofSale.Text, "PRO_TYPE", "D", "STATUS",
                                                 addsiposdiscount.cboStatus.Text.Substring(0, 1));
                        command.ExecuteNonQuery();

                        var dateGridF = addsiposdiscount.dtpDateF.Checked == true
                                            ? addsiposdiscount.dtpDateF.Value.ToShortDateString()
                                            : "";
                        var dateGridT = addsiposdiscount.dtpDateT.Checked == true
                                            ? addsiposdiscount.dtpDateT.Value.ToShortDateString()
                                            : "";
                        var timeGridF = addsiposdiscount.cboTimeF.Text.Trim() == ""
                                            ? ""
                                            : addsiposdiscount.cboTimeF.Text;
                        var timeGridT = addsiposdiscount.cboTimeT.Text.Trim() == ""
                                            ? ""
                                            : addsiposdiscount.cboTimeT.Text;
                        var T = dataGridViewX1.Rows.Add(TreeView1.SelectedNode.ToolTipText,
                                                        addsiposdiscount.txtProID.Text,
                                                        DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS",
                                                                               "ITEM_BCODE", cond, 0),
                                                        addsiposdiscount.txtProName.Text, dateGridF, dateGridT,
                                                        timeGridF,
                                                        timeGridT, addsiposdiscount.txtDiscount.Text,
                                                        addsiposdiscount.txtUnitofStock.Text,
                                                        addsiposdiscount.cboStatus.Text.Substring(4));
                        dataGridViewX1.SelectedRows[0].Selected = false;
                        dataGridViewX1.Rows[T].Selected = true;
                    }
                    Cursor = Cursors.Default;
                    addsiposdiscount.Close();
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                dataGridViewX1.Rows.Clear();
                var dt = new DataTable();
                if ((string)TreeView1.SelectedNode.Tag == "R")
                {
                    var command =
                        new SqlCommand(
                            "SELECT * FROM (SELECT LOCATION,ITEM_CODE,ITEM_BCODE,(SELECT ITEM_DESC FROM SIPITEMS WHERE ITEM_CODE=SIPOSPRICE.ITEM_CODE) [Description],(CASE PRO_FDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_FDATE,101) END) [PRO_FDATE],(CASE PRO_TDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_TDATE,101) END) [PRO_TDATE],(CASE PRO_TIMES WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMES) END) [PRO_TIMES],(CASE PRO_TIMEE WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMEE) END) [PRO_TIMEE],PRO_RATE,UNIT_SALE,(CASE STATUS WHEN 'A' THEN 'Active' ELSE 'Disable' END) [Status] FROM SIPOSPRICE WHERE LOCATION='' AND PRO_TYPE='D') [S] ORDER BY ITEM_CODE",
                            connection.Connect());
                    dt = dataManager.GetData(command);
                }
                else
                {
                    var command =
                       new SqlCommand("SELECT * FROM (SELECT LOCATION,ITEM_CODE,ITEM_BCODE,(SELECT ITEM_DESC FROM SIPITEMS WHERE ITEM_CODE=SIPOSPRICE.ITEM_CODE) [Description],(CASE PRO_FDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_FDATE,101) END) [PRO_FDATE],(CASE PRO_TDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_TDATE,101) END) [PRO_TDATE],(CASE PRO_TIMES WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMES) END) [PRO_TIMES],(CASE PRO_TIMEE WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMEE) END) [PRO_TIMEE],PRO_RATE,UNIT_SALE,(CASE STATUS WHEN 'A' THEN 'Active' ELSE 'Disable' END) [Status] FROM SIPOSPRICE WHERE PRO_TYPE='D') [S] WHERE LOCATION ='" + TreeView1.SelectedNode.ToolTipText + "'"
                           , connection.Connect());
                    dt = dataManager.GetData(command);
                }
                foreach (DataRow row in dt.Rows)
                {
                    var j = dataGridViewX1.Rows.Add(row[0]);
                    for (int i = 0; i < dataGridViewX1.Columns.Count; i++)
                    {
                        dataGridViewX1.Rows[j].Cells[i].Value = row[i];
                    }
                    outLook.ChangeColorOnDisabledAndActive(dataGridViewX1, row[10].ToString(), j);
                }
                
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                TreeView1.Nodes[0].Nodes.Clear();
                var dt = dataManager.GetData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA", "LOC_CODE", "LOC_STAT", "A");
                foreach (DataRow row in dt.Rows)
                {
                    TreeNode N = TreeView1.Nodes[0].Nodes.Add(row[0].ToString().PadRight(7) + row[1]);
                    N.Tag = "I";
                    N.ToolTipText = row[0].ToString();
                    N.ImageIndex = 1;
                    N.SelectedImageIndex = 1;
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void ExcelTool_Click(object sender, EventArgs e)
        {
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
                try
                {
                    ShowData();
                    SearchTool.Checked = false;
                    SearchToolStripMenuItem.Checked = false;
                    SearchPanel.Visible = false;
                    if (ExcelTool.Checked == false)
                    {
                        SplitContainer1.Panel2Collapsed = true;
                    }
                    Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ShowData()
        {
           TreeView1_AfterSelect(null,null);
        }

        #region ContextManu

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                ShowData();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTool_Click(sender,e);
        }

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelTool_Click(sender,e);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToolStripButton_Click(sender,e);
        }

        private void CloneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloneToolStripMenuItem_Click(sender,e);
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(sender,e);
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

        #region ToolStrip

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.POSDiscount, "V", subMenuItems.EditLine, true) ==
           false)
                    return;
                DataGridViewRow dgRow = dataGridViewX1.SelectedRows[0];
                ADDSIPOSDISCOUNT addsiposdiscount = new ADDSIPOSDISCOUNT();
                addsiposdiscount.Text = "Edit Item Discount";
                addsiposdiscount.txtProID.Text = dgRow.Cells[1].Value.ToString();
                addsiposdiscount.txtProID.Enabled = false;
                addsiposdiscount.btnProID.Enabled = false;
                addsiposdiscount.txtUnitofStock.Text = returnUnitOfStock(addsiposdiscount.txtProID.Text);
                addsiposdiscount.txtProName.Text = dgRow.Cells[3].Value.ToString();
                addsiposdiscount.dtpDateF.Value = DateTime.Now;
                if (dgRow.Cells[4].Value.ToString() != "")
                {
                    addsiposdiscount.dtpDateF.Value = Convert.ToDateTime(dgRow.Cells[4].Value);
                    addsiposdiscount.dtpDateF.Checked = true;
                }
                addsiposdiscount.dtpDateT.Value = DateTime.Now;
                if (dgRow.Cells[5].Value.ToString() != "")
                {
                    addsiposdiscount.dtpDateT.Value = Convert.ToDateTime(dgRow.Cells[5].Value);
                    addsiposdiscount.dtpDateT.Checked = true;
                }
                if (dgRow.Cells[6].Value.ToString() != "")
                {
                    addsiposdiscount.cboTimeF.Text = dgRow.Cells[6].Value.ToString();
                }
                if (dgRow.Cells[7].Value.ToString() != "")
                {
                    addsiposdiscount.cboTimeT.Text = dgRow.Cells[7].Value.ToString();   
                }
                addsiposdiscount.txtDiscount.Text = dgRow.Cells[8].Value.ToString();
                addsiposdiscount.txtUnitofSale.Text = dgRow.Cells[9].Value.ToString();
                addsiposdiscount.txtUnitofSale.Enabled = false;
                addsiposdiscount.btnUnitofSale.Enabled = false;
                var condition = new string[] { "ITEM_CODE", addsiposdiscount.txtProID.Text };
                if (addsiposdiscount.txtUnitofSale.Text == addsiposdiscount.txtUnitofStock.Text)
                {
                    addsiposdiscount.txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE1 FROM SIPITEMS",
                                                                                   "ITEM_CODE", condition, 0);
                }
                else
                {
                    addsiposdiscount.txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE2 FROM SIPITEMS",
                                                                                   "ITEM_CODE", condition, 0);
                }
                if (dgRow.Cells[10].Value.ToString() == "Disable")
                {
                    addsiposdiscount.cboStatus.SelectedIndex = 1;
                }
                else
                {
                    addsiposdiscount.cboStatus.SelectedIndex = 0;
                }
                if (addsiposdiscount.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        SqlCommand command =
                            new SqlCommand(
                                "UPDATE SIPOSPRICE SET PRO_FDATE=@PRO_FDATE,PRO_TDATE=@PRO_TDATE,PRO_TIMES=@PRO_TIMES,PRO_TIMEE=@PRO_TIMEE,PRO_RATE=@PRO_RATE,STATUS=@STATUS WHERE PRO_TYPE='D' AND ITEM_CODE=@ITEM_CODE AND LOCATION=@LOCATION AND UNIT_SALE=@UNIT_SALE",connection.Connect());
                       
                        object DateF = addsiposdiscount.dtpDateF.Checked == true
                                       ? addsiposdiscount.dtpDateF.Value.ToShortDateString()
                                       : DBNull.Value.ToString();
                        object DateT = addsiposdiscount.dtpDateT.Checked == true
                                        ? addsiposdiscount.dtpDateT.Value.ToShortDateString()
                                        : DBNull.Value.ToString();
                        if (DateT == "")
                        {
                            DateT = DBNull.Value;
                        }
                        if (DateF == "")
                        {
                            DateF = DBNull.Value;
                        }

                        var timeF = addsiposdiscount.cboTimeF.Text.Trim() == "" ? "-1" : addsiposdiscount.cboTimeF.Text;
                        var timeT = addsiposdiscount.cboTimeT.Text.Trim() == "" ? "-1" : addsiposdiscount.cboTimeT.Text;
                        var cond = new string[] { "ITEM_CODE", addsiposdiscount.txtProID.Text };
                        var item_BCode = DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_CODE",
                                                                cond,
                                                                0);
                        if (TreeView1.SelectedNode.Tag == "R")
                        {
                            Commands.CreateParameter(command, "LOCATION", "", "ITEM_CODE", addsiposdiscount.txtProID.Text,
                                           "ITEM_BCODE", item_BCode
                                           , "PRO_FDATE", DateF, "PRO_TDATE", DateT,
                                           "PRO_TIMES", timeF, "PRO_TIMEE", timeT, "PRO_RATE",
                                           addsiposdiscount.txtDiscount.Text, "UNIT_SALE",
                                           addsiposdiscount.txtUnitofSale.Text, "PRO_TYPE", "D", "STATUS",
                                           addsiposdiscount.cboStatus.Text.Substring(0, 1));
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            Commands.CreateParameter(command, "LOCATION", TreeView1.SelectedNode.ToolTipText, "ITEM_CODE", addsiposdiscount.txtProID.Text,
                                                "ITEM_BCODE",
                                                DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_CODE",
                                                                       cond,
                                                                       0), "PRO_FDATE", DateF, "PRO_TDATE", DateT,
                                                "PRO_TIMES", timeF, "PRO_TIMEE", timeT, "PRO_RATE",
                                                addsiposdiscount.txtDiscount.Text, "UNIT_SALE",
                                                addsiposdiscount.txtUnitofSale.Text, "PRO_TYPE", "D", "STATUS",
                                                addsiposdiscount.cboStatus.Text.Substring(0, 1));
                            command.ExecuteNonQuery();
                        }
//                        ===========  update grid =======
                        var dateGridF = addsiposdiscount.dtpDateF.Checked == true
                                            ? addsiposdiscount.dtpDateF.Value.ToShortDateString()
                                            : "";
                        var dateGridT = addsiposdiscount.dtpDateT.Checked == true
                                            ? addsiposdiscount.dtpDateT.Value.ToShortDateString()
                                            : "";
                        var timeGridF = addsiposdiscount.cboTimeF.Text.Trim() == ""
                                            ? ""
                                            : addsiposdiscount.cboTimeF.Text;
                        var timeGridT = addsiposdiscount.cboTimeT.Text.Trim() == ""
                                            ? ""
                                            : addsiposdiscount.cboTimeT.Text;
                        dgRow.Cells[4].Value = dateGridF;
                        dgRow.Cells[5].Value = dateGridT;
                        dgRow.Cells[6].Value = timeGridF;
                        dgRow.Cells[7].Value = timeGridT;
                        dgRow.Cells[8].Value = addsiposdiscount.txtDiscount.Text;
                        dgRow.Cells[9].Value = addsiposdiscount.txtUnitofSale.Text;
                        dgRow.Cells[10].Value = addsiposdiscount.cboStatus.Text.Substring(4);
                        MessageBox.Show("Record was edited successfully", "Successfully", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        outLook.Change_Color_On_Disabled_And_Active_On_Selected(dataGridViewX1,
                                                                                addsiposdiscount.cboStatus.Text);
                        Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message);
                    }   
                }
                addsiposdiscount.Close();
            }
        }

        string  returnUnitOfStock(string proID)
        {
            var con = new string[] {"ITEM_CODE", proID};
            return DataAccess.ReturnField("SELECT UNIT_STOCK FROM SIPITEMS","ITEM_CODE",con,0);
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count >0)
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.POSDiscount, "V", subMenuItems.DeleteLine, true) ==
           false)
                    return;
                if (MessageBox.Show("Are you sure you want to delete this record ?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        SqlCommand command =
                            new SqlCommand(
                                "DELETE FROM SIPOSPRICE WHERE ITEM_CODE=@ITEM_CODE AND LOCATION=@LOCATION AND UNIT_SALE=@UNIT_SALE AND PRO_TYPE='D'",
                                connection.Connect());
                        if (TreeView1.SelectedNode.Tag == "R")
                        {
                            Commands.CreateParameter(command, "ITEM_CODE", dataGridViewX1.SelectedRows[0].Cells[1].Value,
                                                     "LOCATION", "", "UNIT_SALE",
                                                     dataGridViewX1.SelectedRows[0].Cells[9].Value);
                        }
                        else
                        {
                            Commands.CreateParameter(command,"ITEM_CODE", dataGridViewX1.SelectedRows[0].Cells[1].Value,
                                                     "LOCATION", TreeView1.SelectedNode.ToolTipText, "UNIT_SALE",
                                                     dataGridViewX1.SelectedRows[0].Cells[9].Value);
                        }
                        command.ExecuteNonQuery();
                        dataGridViewX1.Rows.Remove(dataGridViewX1.SelectedRows[0]);
                        MessageBox.Show("Record have been deleted", "Successfully", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                            );
                        Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }  
            }
            else
            {
                MessageBox.Show("Please select data first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.POSDiscount, "V", subMenuItems.CloneLine, true) ==
           false)
                return;
            Clone.Clear();
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                outLook.CloneData(Clone, dataGridViewX1);
                PasteToolStripMenuItem1.Checked = true;
                PasteToolStripMenuItem.Checked = true;
                PasteToolStripMenuItem1.Enabled = true;
                PasteToolStripMenuItem.Enabled = true;
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            if (security.CheckPermission(UserLogOn.Code, menuItems.POSDiscount, "V", subMenuItems.PasteLine, true) ==
//           false)
//                return;
            var addsiposdiscount = new ADDSIPOSDISCOUNT();
            addsiposdiscount.Text = "Paste Item Record";
            addsiposdiscount.txtProID.Text = Clone[1];
            addsiposdiscount.txtUnitofSale.Text =
                DataAccess.ReturnField(
                    "SELECT UNIT_STOCK FROM SIPITEMS WHERE ITEM_CODE ='" + addsiposdiscount.txtProID.Text + "'", 0);
            addsiposdiscount.txtProName.Text = Clone[3];
            addsiposdiscount.dtpDateF.Value = DateTime.Now;
            if (Clone[4] != "")
            {
                addsiposdiscount.dtpDateF.Value = Convert.ToDateTime(Clone[4]);
                addsiposdiscount.dtpDateF.Checked = true;
            }
            addsiposdiscount.dtpDateT.Value = DateTime.Now;
            if (Clone[5] != "")
            {
                addsiposdiscount.dtpDateT.Value = Convert.ToDateTime(Clone[5]);
                addsiposdiscount.dtpDateT.Checked = true;
            }
            if (Clone[6] != "")
            {
                addsiposdiscount.cboTimeF.Text = Clone[6];
            }
            if (Clone[7] != "")
            {
                addsiposdiscount.cboTimeT.Text = Clone[7];  
            }
            addsiposdiscount.txtDiscount.Text = Clone[8];
            addsiposdiscount.txtUnitofStock.Text = returnUnitOfStock(addsiposdiscount.txtProID.Text);
            addsiposdiscount.txtUnitofSale.Text = Clone[9];
            var cond = new string[] {"ITEM_CODE", addsiposdiscount.txtProID.Text};
            if (addsiposdiscount.txtUnitofSale.Text == addsiposdiscount.txtUnitofStock.Text)
            {
                addsiposdiscount.txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE1 FROM SIPITEMS",
                                                                               "ITEM_CODE", cond, 0);
            }
            else
            {
                addsiposdiscount.txtSellingPrice.Text = DataAccess.ReturnField("SELECT ITEM_PRICE2 FROM SIPITEMS",
                                                                               "ITEM_CODE", cond, 0);
            }
            addsiposdiscount.cboStatus.Text = Clone[10].Substring(0, 1) + " - " + Clone[10];
            a:
            if (addsiposdiscount.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    object DateF = addsiposdiscount.dtpDateF.Checked == true
                                        ? addsiposdiscount.dtpDateF.Value.ToShortDateString()
                                        : DBNull.Value.ToString();
                    object DateT = addsiposdiscount.dtpDateT.Checked == true
                                    ? addsiposdiscount.dtpDateT.Value.ToShortDateString()
                                    : DBNull.Value.ToString();
                    if (DateT == "")
                    {
                        DateT = DBNull.Value;
                    }
                    if (DateF == "")
                    {
                        DateF = DBNull.Value;
                    }

                    var timeF = addsiposdiscount.cboTimeF.Text.Trim() == "" ? "-1" : addsiposdiscount.cboTimeF.Text;
                    var timeT = addsiposdiscount.cboTimeT.Text.Trim() == "" ? "-1" : addsiposdiscount.cboTimeT.Text;
                    var condi = new string[] { "ITEM_CODE", addsiposdiscount.txtProID.Text };
                    var item_BCode = DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_CODE",
                                                            condi,
                                                            0);
                    var command = new SqlCommand("INSERT INTO SIPOSPRICE VALUES(@LOCATION,@ITEM_CODE,@ITEM_BCODE,@PRO_FDATE,@PRO_TDATE,@PRO_TIMES,@PRO_TIMEE,@PRO_RATE,@UNIT_SALE,@PRO_TYPE,@STATUS)");
                    command.CommandType = CommandType.Text;
                    command.Connection = connection.Connect();
                    var d = addsiposdiscount.txtDiscount.Text;
                    var ddd = d;
                    if ((string)TreeView1.SelectedNode.Tag == "R")
                    {
                        if (dataManager.Exists("SIPOSPRICE", "ITEM_CODE", addsiposdiscount.txtProID.Text, "LOCATION", "",
                                               "UNIT_SALE", addsiposdiscount.txtUnitofSale.Text, "PRO_TYPE", "D"))
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("The discount of item have already exist.", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            goto a;
                        }
                        Commands.CreateParameter(command, "LOCATION", "", "ITEM_CODE", addsiposdiscount.txtProID.Text,
                                            "ITEM_BCODE", item_BCode
                                            , "PRO_FDATE", DateF, "PRO_TDATE", DateT,
                                            "PRO_TIMES", timeF, "PRO_TIMEE", timeT, "PRO_RATE",
                                            addsiposdiscount.txtDiscount.Text, "UNIT_SALE",
                                            addsiposdiscount.txtUnitofSale.Text, "PRO_TYPE", "D", "STATUS",
                                            addsiposdiscount.cboStatus.Text.Substring(0, 1));
                        command.ExecuteNonQuery();
                        var i = dataGridViewX1.Rows.Add(TreeView1.SelectedNode.ToolTipText,
                                                        addsiposdiscount.txtProID.Text, item_BCode,
                                                        addsiposdiscount.txtProName.Text, DateF, DateT, timeF, timeT,
                                                        addsiposdiscount.txtDiscount.Text, addsiposdiscount.txtUnitofSale.Text,
                                                        addsiposdiscount.cboStatus.Text.Substring(4));
                        dataGridViewX1.SelectedRows[0].Selected = false;
                        dataGridViewX1.Rows[i].Selected = true;
                       
                    }
                    else
                    {
                        if (dataManager.Exists("SIPOSPRICE", "ITEM_CODE", addsiposdiscount.txtProID.Text, "LOCATION", TreeView1.SelectedNode.ToolTipText,
                                               "UNIT_SALE", addsiposdiscount.txtUnitofSale.Text, "PRO_TYPE", "D"))
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("The discount of item have already exist.", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            goto a;
                        }
                        Commands.CreateParameter(command, "LOCATION", TreeView1.SelectedNode.ToolTipText, "ITEM_CODE", addsiposdiscount.txtProID.Text,
                                                 "ITEM_BCODE",
                                                 DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_CODE",
                                                                        cond,
                                                                        0), "PRO_FDATE", DateF, "PRO_TDATE", DateT,
                                                 "PRO_TIMES", timeF, "PRO_TIMEE", timeT, "PRO_RATE",
                                                 addsiposdiscount.txtDiscount.Text, "UNIT_SALE",
                                                 addsiposdiscount.txtUnitofSale.Text, "PRO_TYPE", "D", "STATUS",
                                                 addsiposdiscount.cboStatus.Text.Substring(0, 1));
                        command.ExecuteNonQuery();

                        var dateGridF = addsiposdiscount.dtpDateF.Checked == true
                                            ? addsiposdiscount.dtpDateF.Value.ToShortDateString()
                                            : "";
                        var dateGridT = addsiposdiscount.dtpDateT.Checked == true
                                            ? addsiposdiscount.dtpDateT.Value.ToShortDateString()
                                            : "";
                        var timeGridF = addsiposdiscount.cboTimeF.Text.Trim() == ""
                                            ? ""
                                            : addsiposdiscount.cboTimeF.Text;
                        var timeGridT = addsiposdiscount.cboTimeT.Text.Trim() == ""
                                            ? ""
                                            : addsiposdiscount.cboTimeT.Text;
                        var T = dataGridViewX1.Rows.Add(TreeView1.SelectedNode.ToolTipText,
                                                        addsiposdiscount.txtProID.Text,
                                                        DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS",
                                                                               "ITEM_BCODE", cond, 0),
                                                        addsiposdiscount.txtProName.Text, dateGridF, dateGridT,
                                                        timeGridF,
                                                        timeGridT, addsiposdiscount.txtDiscount.Text,
                                                        addsiposdiscount.txtUnitofStock.Text,
                                                        addsiposdiscount.cboStatus.Text.Substring(4));
                        dataGridViewX1.SelectedRows[0].Selected = false;
                        dataGridViewX1.Rows[T].Selected = true;
                    }
                    outLook.Change_Color_On_Disabled_And_Active_On_Selected(dataGridViewX1, addsiposdiscount.cboStatus.Text);
                    Cursor = Cursors.Default;
                    addsiposdiscount.Close();
                }
                catch (Exception)
                {
                   
                    throw;
                }
            }

//            AA:
//                If .ShowDialog = Windows.Forms.DialogResult.OK Then
//                    Try
//                        Me.Cursor = Cursors.WaitCursor
//                        Dim Cmd As New SqlClient.SqlCommand("INSERT INTO SIPOSPRICE VALUES(@LOCATION,@ITEM_CODE,@ITEM_BCODE,@PRO_FDATE,@PRO_TDATE,@PRO_TIMES,@PRO_TIMEE,@PRO_RATE,@UNIT_SALE,@PRO_TYPE,@STATUS)", CN)
//                        If TreeView1.SelectedNode.Tag = "R" Then
//                            If Exists(CN, "SIPOSPRICE", "ITEM_CODE", .txtProID.Text, "LOCATION", "", "UNIT_SALE", .txtUnitofSale.Text, "PRO_TYPE", "D") Then
//                                Me.Cursor = Cursors.Default
//                                MsgBox("This record have been added.", MsgBoxStyle.Critical)
//                                GoTo AA
//                            End If
//                            CreatePar(Cmd, "LOCATION", "", "ITEM_CODE", .txtProID.Text, "ITEM_BCODE", ReturnField(CN, "SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_CODE", .txtProID.Text), "PRO_FDATE", IIf(.dtpDateF.Checked = True, .dtpDateF.Value.ToShortDateString, DBNull.Value), "PRO_TDATE", IIf(.dtpDateT.Checked = True, .dtpDateT.Value.ToShortDateString, DBNull.Value), "PRO_TIMES", IIf(.cboTimeF.Text.Trim = "", -1, .cboTimeF.Text), "PRO_TIMEE", IIf(.cboTimeT.Text.Trim = "", -1, .cboTimeT.Text), "PRO_RATE", .txtDiscount.Text, "UNIT_SALE", .txtUnitofSale.Text, "PRO_TYPE", "D", "STATUS", .cboStatus.Text.Substring(0, 1))
//                            Cmd.ExecuteNonQuery()
//                            Dim T As Integer = dataGridViewX1.Rows.Add(TreeView1.SelectedNode.ToolTipText, .txtProID.Text, ReturnField(CN, "SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_CODE", .txtProID.Text), .txtProName.Text, IIf(.dtpDateF.Checked = True, .dtpDateF.Value.ToShortDateString, ""), IIf(.dtpDateT.Checked = True, .dtpDateT.Value.ToShortDateString, ""), IIf(.cboTimeF.Text.Trim = "", "", .cboTimeF.Text), IIf(.cboTimeT.Text.Trim = "", "", .cboTimeT.Text), .txtDiscount.Text, .txtUnitofSale.Text, .cboStatus.Text.Substring(4))
//                            dataGridViewX1.Rows(T).Selected = True
//                        Else
//                            If Exists(CN, "SIPOSPRICE", "ITEM_CODE", .txtProID.Text, "LOCATION", TreeView1.SelectedNode.ToolTipText, "UNIT_SALE", .txtUnitofSale.Text, "PRO_TYPE", "D") Then
//                                Me.Cursor = Cursors.Default
//                                MsgBox("This record have been added.", MsgBoxStyle.Critical)
//                                GoTo AA
//                            End If
//                            CreatePar(Cmd, "LOCATION", TreeView1.SelectedNode.ToolTipText, "ITEM_CODE", .txtProID.Text, "ITEM_BCODE", ReturnField(CN, "SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_CODE", .txtProID.Text), "PRO_FDATE", IIf(.dtpDateF.Checked = True, .dtpDateF.Value.ToShortDateString, DBNull.Value), "PRO_TDATE", IIf(.dtpDateT.Checked = True, .dtpDateT.Value.ToShortDateString, DBNull.Value), "PRO_TIMES", IIf(.cboTimeF.Text.Trim = "", -1, .cboTimeF.Text), "PRO_TIMEE", IIf(.cboTimeT.Text.Trim = "", -1, .cboTimeT.Text), "PRO_RATE", .txtDiscount.Text, "UNIT_SALE", .txtUnitofSale.Text, "PRO_TYPE", "D", "STATUS", .cboStatus.Text.Substring(0, 1))
//                            Cmd.ExecuteNonQuery()
//                            Dim T As Integer = dataGridViewX1.Rows.Add(TreeView1.SelectedNode.ToolTipText, .txtProID.Text, ReturnField(CN, "SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_CODE", .txtProID.Text), .txtProName.Text, IIf(.dtpDateF.Checked = True, .dtpDateF.Value.ToShortDateString, ""), IIf(.dtpDateT.Checked = True, .dtpDateT.Value.ToShortDateString, ""), IIf(.cboTimeF.Text.Trim = "", "", .cboTimeF.Text), IIf(.cboTimeT.Text.Trim = "", "", .cboTimeT.Text), .txtDiscount.Text, .txtUnitofSale.Text, .cboStatus.Text.Substring(4))
//                            dataGridViewX1.Rows(T).Selected = True
//                        End If
//                        MsgBox("Record have been pasted!", MsgBoxStyle.Information)
//                        Me.Cursor = Cursors.Default
//                    Catch ex As Exception
//                        Me.Cursor = Cursors.Default
//                        MsgBox(ex.Message)
//                    End Try
//                End If
//                .Close()
//            End With
//        Else
//            MsgBox("Please clone before paste data.", MsgBoxStyle.Critical, "Paste Error")
//        End If
        }

        #endregion

        private void SIPOSDISCOUNT_FRM_Load(object sender, EventArgs e)
        {
            var dt =
                dataManager.GetData(
                    "SELECT LOCATION,ITEM_CODE,ITEM_BCODE,(SELECT ITEM_DESC FROM SIPITEMS WHERE ITEM_CODE=SIPOSPRICE.ITEM_CODE) [Description],(CASE PRO_FDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_FDATE,101) END) [PRO_FDATE],(CASE PRO_TDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_TDATE,101) END) [PRO_TDATE],(CASE PRO_TIMES WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMES) END) [PRO_TIMES],(CASE PRO_TIMEE WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMEE) END) [PRO_TIMEE],PRO_RATE,UNIT_SALE,(CASE STATUS WHEN 'A' THEN 'Active' ELSE 'Disable' END) [Status] FROM SIPOSPRICE",
                    "ITEM_CODE", "PRO_TYPE", "D", "LOCATION", "");
            outLook.loadSearch(dataGridViewX1, dt, "ITEM_CODE", ListView1, ContextMenuStrip2, ToolStrip2, SplitContainer1, SearchPanel);
           
                
            
        }

        #region Export Excel

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            outLook.ExportToExcel(ListView1,bgwExcel);
        }

        private void bgwExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            outLook.BackGround_DdWork(dataGridViewX1,ListView1);
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

        private void chbS_CheckedChanged(object sender, EventArgs e)
        {
            controls.CheckOnListView(ListView1,chbS);
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            outLook.searching(connection.Connect(), dataGridViewX1,
                              "SELECT LOCATION,ITEM_CODE,ITEM_BCODE,(SELECT ITEM_DESC FROM SIPITEMS WHERE ITEM_CODE=SIPOSPRICE.ITEM_CODE) [Description],(CASE PRO_FDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_FDATE,101) END) [PRO_FDATE],(CASE PRO_TDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_TDATE,101) END) [PRO_TDATE],(CASE PRO_TIMES WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMES) END) [PRO_TIMES],(CASE PRO_TIMEE WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMEE) END) [PRO_TIMEE],PRO_RATE,UNIT_SALE,(CASE STATUS WHEN 'A' THEN 'Active' ELSE 'Disable' END) [Status] FROM SIPOSPRICE ",
                              "ITEM_CODE", ToolStrip2, ToolStrip3, "STATUS", "PRO_TYPE", "D");
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            outLook.addcreteria(ContextMenuStrip2, ToolStrip2, SearchPanel, RemoveToolStripMenuItem, e, STRTMP);
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
    }
}
