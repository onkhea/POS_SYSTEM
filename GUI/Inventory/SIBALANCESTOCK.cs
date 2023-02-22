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
using POS.Transaction.Inventory;
using POS.Transaction.Maintains;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Inventory
{
    public partial class SIBALANCESTOCK : DevComponents.DotNetBar.Office2007Form
    {
        public SIBALANCESTOCK()
        {
            InitializeComponent();
        }

        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        readonly OutLook outLook = new OutLook();
        readonly Controls controls = new Controls();
        readonly DataManager dataManager = new DataManager();
        Connection.Connection connection = new Connection.Connection();

        private void SIBALANCESTOCK_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                TreeView1.Nodes[0].Expand();
                ListView1.Items.Clear();
                for (int i = 0; i < dataGridViewX1.Columns.Count - 1; i++)
                {
                    ListViewItem lv = ListView1.Items.Add(dataGridViewX1.Columns[i].HeaderText);
                    if (dataGridViewX1.Columns[i].Visible == true)
                    {
                        lv.Checked = true;
                    }
                }
                if (SplitContainer1.Width > 200)
                {
                    SplitContainer1.SplitterDistance = SplitContainer1.Width - 200;
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dataGridViewX1.Rows.Clear();
                var location = "";
                var sqlCommand = new SqlCommand();
                var dt = new DataTable();
                if ((string) TreeView1.SelectedNode.Tag != "ALL")
                {
                        location = TreeView1.SelectedNode.Name;    
//                    ================= Note: Refactoring in here when sale finish ============
                        sqlCommand = new SqlCommand(
                           "SELECT dbo.SIPINMOV.LOCATION as LOCATION, dbo.SIPINMOV.ITEM_CODE, dbo.SIPITEMS.ITEM_DESC, dbo.SIPINMOV.MOV_UNITS, SUM(dbo.SIPINMOV.QUANTITY) AS Quantity FROM dbo.SIPINMOV INNER JOIN dbo.SIPITEMS ON dbo.SIPINMOV.ITEM_CODE = dbo.SIPITEMS.ITEM_CODE Where  dbo.SIPINMOV.LOCATION = @LOCATION GROUP BY dbo.SIPINMOV.LOCATION, dbo.SIPINMOV.ITEM_CODE, dbo.SIPITEMS.ITEM_DESC, dbo.SIPINMOV.MOV_UNITS"
                          , connection.Connect());
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Parameters.AddWithValue("@LOCATION", location);
                        var dataAdapter = new SqlDataAdapter(sqlCommand);
                        dataAdapter.Fill(dt);
                }
                else
                {
                    sqlCommand =
                        new SqlCommand(
                            "SELECT dbo.SIPINMOV.LOCATION as LOCATION, dbo.SIPINMOV.ITEM_CODE, dbo.SIPITEMS.ITEM_DESC, dbo.SIPINMOV.MOV_UNITS, SUM(dbo.SIPINMOV.QUANTITY) AS Quantity FROM  dbo.SIPINMOV INNER JOIN dbo.SIPITEMS ON dbo.SIPINMOV.ITEM_CODE = dbo.SIPITEMS.ITEM_CODE GROUP BY dbo.SIPINMOV.LOCATION, dbo.SIPINMOV.ITEM_CODE, dbo.SIPITEMS.ITEM_DESC, dbo.SIPINMOV.MOV_UNITS",
                            connection.Connect());
                    dt = dataManager.GetData(sqlCommand);
                }
                Cursor = Cursors.Default;
                if (chbList.Checked)
                {
                    SqlCommand command =
                        new SqlCommand(
                            "SELECT dbo.SIPINMOV.LOCATION, dbo.SIPINMOV.ITEM_CODE, dbo.SIPITEMS.ITEM_DESC, dbo.SIPINMOV.MOV_UNITS, SUM(dbo.SIPINMOV.QUANTITY) AS Quantity FROM dbo.SIPINMOV INNER JOIN dbo.SIPITEMS ON dbo.SIPINMOV.ITEM_CODE = dbo.SIPITEMS.ITEM_CODE GROUP BY dbo.SIPINMOV.LOCATION, dbo.SIPINMOV.ITEM_CODE, dbo.SIPITEMS.ITEM_DESC, dbo.SIPINMOV.MOV_UNITS",
                            connection.Connect());
                    dt = dataManager.GetData(command);
                }
                var movementEntry = new MovementEntry();
                foreach (DataRow row in dt.Rows)
                {
//                    ==================Note : refactoring Here 
                    var onOrder = movementEntry.GetItem("O", row[0].ToString(), row[1].ToString());
                    var free = Convert.ToDecimal(row[4].ToString()) - onOrder;
                    dataGridViewX1.Rows.Add(row[0], row[1], row[2], row[3], row[4],onOrder, free);
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
   
            }
        }

        private void TreeView1_Resize(object sender, EventArgs e)
        {
            if (ListView1.Width > 25)
            {
                ListView1.Columns[0].Width = ListView1.Width - 25;
            }
        }

        private void ExcelTool_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.InventoryBalance, "V", subMenuItems.ExcelInventoryBalance, true) ==
          false)
                    return;
                if (ExcelTool.Checked == false)
                {
                    ExcelTool.Checked = true;
                    ExcelToolStripMenuItem.Checked = true;
                    ExcelPanel.Visible = true;
                    if (RefreshTool.Checked == false)
                    {
                        SplitContainer1.Panel2Collapsed = false;
                    }
                }
                else
                {
                    ExcelTool.Checked = false;
                    ExcelToolStripMenuItem.Checked = false;
                    ExcelPanel.Visible = false;
                    if (RefreshTool.Checked== false)
                    {
                        SplitContainer1.Panel2Collapsed = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshTool_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Clear();
            var command =
                         new SqlCommand(
                             "SELECT dbo.SIPINMOV.LOCATION, dbo.SIPINMOV.ITEM_CODE, dbo.SIPITEMS.ITEM_DESC, dbo.SIPINMOV.MOV_UNITS, SUM(dbo.SIPINMOV.QUANTITY) AS Quantity FROM dbo.SIPINMOV INNER JOIN dbo.SIPITEMS ON dbo.SIPINMOV.ITEM_CODE = dbo.SIPITEMS.ITEM_CODE GROUP BY dbo.SIPINMOV.LOCATION, dbo.SIPINMOV.ITEM_CODE, dbo.SIPITEMS.ITEM_DESC, dbo.SIPINMOV.MOV_UNITS",
                             connection.Connect());
            var dt = dataManager.GetData(command);
            foreach (DataRow row in dt.Rows)
            {
                //                    ==================Note : refactoring Here 
                var movementEntry = new MovementEntry();
                var onOrder = movementEntry.GetItem("O", row[0].ToString(), row[1].ToString());
                var free = Convert.ToDecimal(row[4].ToString()) - onOrder;
                dataGridViewX1.Rows.Add(row[0], row[1], row[2], row[3], row[4], onOrder, free);
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshTool_Click(sender,e);
        }

        private void chbList_CheckedChanged(object sender, EventArgs e)
        {
            TreeView1_AfterSelect(null,null);
        }

        #region Export To Excel

        private void chbS_CheckedChanged(object sender, EventArgs e)
        {
            controls.CheckOnListView(ListView1,chbS);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            outLook.ExportToExcel(ListView1, bgExcel);
        }

        private void bgExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            outLook.BackGround_DdWork(dataGridViewX1,ListView1);
        }

        private void bgExcel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            outLook.BackGroud_ProgressChanged(e);
        }

        private void bgExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            outLook.BackGround_RunWorkedCompleted();
        }

        #endregion

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var command = new SqlCommand("SELECT LOC_CODE, LOC_NAME FROM dbo.SIPLOCA", connection.Connect());
                var dt = dataManager.GetData(command);
                TreeNode node;
                TreeView1.Nodes[0].Nodes.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    node = TreeView1.Nodes[0].Nodes.Add(row[0].ToString(),
                                                        row[0] +
                                                        row[1].ToString().PadLeft(18 - row[0].ToString().Length)
                                                        , 1, 1);
                    node.Tag = "LOCATION";
                    node.ToolTipText = row[1].ToString();
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelTool_Click(null,null);
        }

        private void CloseToolStripButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
