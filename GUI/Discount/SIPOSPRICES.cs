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
    public partial class SIPOSPRICES : DevComponents.DotNetBar.Office2007Form
    {
        public SIPOSPRICES()
        {
            InitializeComponent();
        }
        #region global variable

        readonly OutLook outLook = new OutLook();
        private string STRTMP = "";
        readonly Controls controls = new Controls();
        readonly List<string> Clone = new List<string>();
        readonly DataManager dataManager = new DataManager();
        readonly Connection.Connection connection = new Connection.Connection();
        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();

        #endregion

        private void SIPOSPRICES_Load(object sender, EventArgs e)
        {
            var dt =
                dataManager.GetData(
                    "SELECT LOCATION,ITEM_CODE,ITEM_BCODE,(SELECT ITEM_DESC FROM SIPITEMS WHERE ITEM_CODE=SIPOSPRICE.ITEM_CODE) [Description],(CASE PRO_FDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_FDATE,101) END) [PRO_FDATE],(CASE PRO_TDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_TDATE,101) END) [PRO_TDATE],(CASE PRO_TIMES WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMES) END) [PRO_TIMES],(CASE PRO_TIMEE WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMEE) END) [PRO_TIMEE],PRO_RATE,UNIT_SALE,(CASE STATUS WHEN 'A' THEN 'Active' ELSE 'Disable' END) [Status] FROM SIPOSPRICE ",
                    "ITEM_CODE", "PRO_TYPE", "P");
            outLook.loadSearch(dataGridViewX1, dt, "ITEM_CODE",ListView1,ContextMenuStrip2,ToolStrip2,SplitContainer1,SearchPanel);
        }

        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveToolStripMenuItem.Visible = true;
            removesep.Visible = true;
            STRTMP = e.ClickedItem.Name;
        }

        private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            outLook.addcreteria(ContextMenuStrip2, ToolStrip2, SearchPanel, RemoveToolStripMenuItem, e, STRTMP);
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

        #region Export data to excel

        private void chbS_CheckedChanged(object sender, EventArgs e)
        {
            controls.CheckOnListView(ListView1, chbS);
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

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            outLook.ExportToExcel(ListView1,bgwExcel);
        }
        #endregion

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SetupPrice, "V", subMenuItems.CloneLine, true) ==
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

        private void ExcelTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SetupPrice, "V", subMenuItems.ExportDatatoExcel, true) ==
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

        #region contextManuToolstrip 1


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

        #region Tool
        private void CloneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloneToolStripMenuItem_Click(sender,e);
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(sender,e);
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
            ShowData();
        }

        #endregion

        private void SearchTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SetupPrice, "V", subMenuItems.SearchData, true) ==
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

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SetupPrice, "V", subMenuItems.PasteLine, true) ==
       false)
                return;
            if (Clone.Count > 0)
            {
                var siaddsetuppriceFrm = new SIADDSETUPPRICE_FRM();
                siaddsetuppriceFrm.Text = "Paste Price";
                siaddsetuppriceFrm.txtProID.Text = Clone[1];
                var condition = new[] {"ITEM_CODE", Clone[1]};
                siaddsetuppriceFrm.txtUnitofStock.Text = DataAccess.ReturnField("SELECT UNIT_STOCK FROM SIPITEMS",
                                                                                 "ITEM_CODE", condition, 0);
                siaddsetuppriceFrm.txtProName.Text = Clone[3];
                siaddsetuppriceFrm.txtSellingPrice.Text = Clone[8];
                siaddsetuppriceFrm.txtUnitofSale.Text = Clone[9];
                siaddsetuppriceFrm.cboStatus.Text = Clone[10].Substring(0, 1) + " - " + Clone[10];
                
            a:
                if (siaddsetuppriceFrm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        var command =
                        new SqlCommand(
                            "INSERT INTO SIPOSPRICE VALUES(@LOCATION,@ITEM_CODE,@ITEM_BCODE,@PRO_FDATE,@PRO_TDATE,@PRO_TIMES,@PRO_TIMEE,@PRO_RATE,@UNIT_SALE,@PRO_TYPE,@STATUS)",
                            connection.Connect());
                        if ((string) TreeView1.SelectedNode.Tag == "R")
                        {
                            if (dataManager.Exists("SIPOSPRICE", "ITEM_CODE", siaddsetuppriceFrm.txtProID.Text, "LOCATION", "",
                                                   "UNIT_SALE", siaddsetuppriceFrm.txtUnitofSale.Text, "PRO_TYPE", "P"))
                            {
                                Cursor = Cursors.Default;
                                MessageBox.Show("The unit sale of item have already exist.", "Exist", MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                                goto a;
                            }
                            var cond = new[] { "ITEM_CODE", siaddsetuppriceFrm.txtProID.Text };
                            Commands.CreateParameter(command, "LOCATION", "", "ITEM_CODE", siaddsetuppriceFrm.txtProID.Text,
                                                     "ITEM_BCODE",
                                                     DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_BCODE",
                                                                            cond, 0),
                                                     "PRO_FDATE", DBNull.Value, "PRO_TDATE", DBNull.Value, "PRO_TIMES", -1,
                                                     "PRO_TIMEE", -1, "PRO_RATE", Convert.ToDecimal(siaddsetuppriceFrm.txtSellingPrice.Text),
                                                     "UNIT_SALE", siaddsetuppriceFrm.txtUnitofSale.Text, "PRO_TYPE", "P",
                                                     "STATUS", siaddsetuppriceFrm.cboStatus.Text.Substring(0, 1));
                            command.ExecuteNonQuery();
                            var i = dataGridViewX1.Rows.Add("", siaddsetuppriceFrm.txtProID.Text,
                                                            DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS",
                                                                                   "ITEM_BCODE",
                                                                                   condition, 0),
                                                            siaddsetuppriceFrm.txtProName.Text,
                                                            "", "", "", "", siaddsetuppriceFrm.txtSellingPrice.Text,
                                                            siaddsetuppriceFrm.txtUnitofSale.Text,
                                                            siaddsetuppriceFrm.cboStatus.Text.Substring(4));
                            dataGridViewX1.SelectedRows[0].Selected = false;
                            dataGridViewX1.Rows[i].Selected = true;
                        }
                        else
                        {
                            if (dataManager.Exists("SIPOSPRICE", "ITEM_CODE", siaddsetuppriceFrm.txtProID.Text, "LOCATION",
                                                   TreeView1.SelectedNode.ToolTipText, "UNIT_SALE",
                                                   siaddsetuppriceFrm.txtUnitofSale.Text, "PRO_TYPE", "P"))
                            {
                                Cursor = Cursors.Default;
                                MessageBox.Show("The unit sale of item have already exist.", "Exist", MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                                goto a;
                            }
                            var cond = new[] { "ITEM_CODE", siaddsetuppriceFrm.txtProID.Text };
                            Commands.CreateParameter(command, "LOCATION", TreeView1.SelectedNode.ToolTipText, "ITEM_CODE",
                                                     siaddsetuppriceFrm.txtProID.Text,
                                                     "ITEM_BCODE",
                                                     DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_BCODE",
                                                                            cond, 0),
                                                     "PRO_FDATE", DBNull.Value, "PRO_TDATE", DBNull.Value, "PRO_TIMES", "-1",
                                                     "PRO_TIMEE", -1, "PRO_RATE", Convert.ToDecimal(siaddsetuppriceFrm.txtSellingPrice.Text),
                                                     "UNIT_SALE", siaddsetuppriceFrm.txtUnitofSale.Text, "PRO_TYPE", "P",
                                                     "STATUS", siaddsetuppriceFrm.cboStatus.Text.Substring(0, 1));
                            command.ExecuteNonQuery();
                            var i = dataGridViewX1.Rows.Add(TreeView1.SelectedNode.ToolTipText,
                                                            siaddsetuppriceFrm.txtProID.Text,
                                                            DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS",
                                                                                   "ITEM_BCODE",
                                                                                   condition, 0),
                                                            siaddsetuppriceFrm.txtProName.Text,
                                                            "", "", "", "", siaddsetuppriceFrm.txtSellingPrice.Text,
                                                            siaddsetuppriceFrm.txtUnitofSale.Text,
                                                            siaddsetuppriceFrm.cboStatus.Text.Substring(4));
                            dataGridViewX1.SelectedRows[0].Selected = false;
                            dataGridViewX1.Rows[i].Selected = true;
                        }
                        outLook.Change_Color_On_Disabled_And_Active_On_Selected(dataGridViewX1,siaddsetuppriceFrm.cboStatus.Text);
                        MessageBox.Show("Record have been pasted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message);
                    }
                    siaddsetuppriceFrm.Close();
                }
                else
                {
                    MessageBox.Show("Please clone before paste data.", "Not Yet Clone", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.SetupPrice, "V", subMenuItems.NewLine, true) ==
          false)
                    return;
                var siaddsetuppriceFrm = new SIADDSETUPPRICE_FRM { cboStatus = { SelectedIndex = 0 } };
            a:
                if (siaddsetuppriceFrm.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.Default;
                    var command =
                        new SqlCommand(
                            "INSERT INTO SIPOSPRICE VALUES(@LOCATION,@ITEM_CODE,@ITEM_BCODE,@PRO_FDATE,@PRO_TDATE,@PRO_TIMES,@PRO_TIMEE,@PRO_RATE,@UNIT_SALE,@PRO_TYPE,@STATUS)",
                            connection.Connect());
                    if ((string) TreeView1.SelectedNode.Tag == "R")
                    {
                        if (dataManager.Exists("SIPOSPRICE", "ITEM_CODE", siaddsetuppriceFrm.txtProID.Text, "LOCATION", "",
                                               "UNIT_SALE", siaddsetuppriceFrm.txtUnitofSale.Text, "PRO_TYPE", "P"))
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("The unit sale of item have already exist.", "Exist", MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                            goto a;
                        }
                        var condition = new[] { "ITEM_CODE", siaddsetuppriceFrm.txtProID.Text };
                        Commands.CreateParameter(command, "LOCATION", "", "ITEM_CODE", siaddsetuppriceFrm.txtProID.Text,
                                                 "ITEM_BCODE",
                                                 DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_BCODE",
                                                                        condition, 0),
                                                 "PRO_FDATE", DBNull.Value, "PRO_TDATE", DBNull.Value, "PRO_TIMES", -1,
                                                 "PRO_TIMEE", -1, "PRO_RATE", Convert.ToDecimal(siaddsetuppriceFrm.txtSellingPrice.Text),
                                                 "UNIT_SALE", siaddsetuppriceFrm.txtUnitofSale.Text, "PRO_TYPE", "P",
                                                 "STATUS", siaddsetuppriceFrm.cboStatus.Text.Substring(0, 1));
                        command.ExecuteNonQuery();
                        var i = dataGridViewX1.Rows.Add("", siaddsetuppriceFrm.txtProID.Text,
                                                        DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS",
                                                                               "ITEM_BCODE",
                                                                               condition, 0),
                                                        siaddsetuppriceFrm.txtProName.Text,
                                                        "", "", "", "", siaddsetuppriceFrm.txtSellingPrice.Text,
                                                        siaddsetuppriceFrm.txtUnitofSale.Text,
                                                        siaddsetuppriceFrm.cboStatus.Text.Substring(4));
                        dataGridViewX1.SelectedRows[0].Selected = false;
                        dataGridViewX1.Rows[i].Selected = true;
                    }
                    else
                    {
                        if (dataManager.Exists("SIPOSPRICE", "ITEM_CODE", siaddsetuppriceFrm.txtProID.Text, "LOCATION",
                                               TreeView1.SelectedNode.ToolTipText, "UNIT_SALE",
                                               siaddsetuppriceFrm.txtUnitofSale.Text, "PRO_TYPE", "P"))
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("The unit sale of item have already exist.", "Exist", MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                            goto a;
                        }
                        var condition = new string[] { "ITEM_CODE", siaddsetuppriceFrm.txtProID.Text };
                        Commands.CreateParameter(command, "LOCATION", TreeView1.SelectedNode.ToolTipText, "ITEM_CODE",
                                                 siaddsetuppriceFrm.txtProID.Text,
                                                 "ITEM_BCODE",
                                                 DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS", "ITEM_BCODE",
                                                                        condition, 0),
                                                 "PRO_FDATE", DBNull.Value, "PRO_TDATE", DBNull.Value, "PRO_TIMES", -1,
                                                 "PRO_TIMEE", -1, "PRO_RATE", Convert.ToDecimal(siaddsetuppriceFrm.txtSellingPrice.Text),
                                                 "UNIT_SALE", siaddsetuppriceFrm.txtUnitofSale.Text, "PRO_TYPE", "P",
                                                 "STATUS", siaddsetuppriceFrm.cboStatus.Text.Substring(0, 1));
                        command.ExecuteNonQuery();
                        var i = dataGridViewX1.Rows.Add(TreeView1.SelectedNode.ToolTipText,
                                                        siaddsetuppriceFrm.txtProID.Text,
                                                        DataAccess.ReturnField("SELECT ITEM_BCODE FROM SIPITEMS",
                                                                               "ITEM_BCODE",
                                                                               condition, 0),
                                                        siaddsetuppriceFrm.txtProName.Text,
                                                        "", "", "", "", siaddsetuppriceFrm.txtSellingPrice.Text,
                                                        siaddsetuppriceFrm.txtUnitofSale.Text,
                                                        siaddsetuppriceFrm.cboStatus.Text.Substring(4));
                        dataGridViewX1.SelectedRows[0].Selected = false;
                        dataGridViewX1.Rows[i].Selected = true;
                    }
                    Cursor = Cursors.Default;
                }
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
                DataTable dt;
                if (TreeView1.SelectedNode.Tag == "R")
                {
                    var command =
                        new SqlCommand(
                            "SELECT * FROM (SELECT LOCATION,ITEM_CODE,ITEM_BCODE,(SELECT ITEM_DESC FROM SIPITEMS WHERE ITEM_CODE=SIPOSPRICE.ITEM_CODE) [Description],(CASE PRO_FDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_FDATE,101) END) [PRO_FDATE],(CASE PRO_TDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_TDATE,101) END) [PRO_TDATE],(CASE PRO_TIMES WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMES) END) [PRO_TIMES],(CASE PRO_TIMEE WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMEE) END) [PRO_TIMEE],PRO_RATE,UNIT_SALE,(CASE STATUS WHEN 'A' THEN 'Active' ELSE 'Disable' END) [Status] FROM SIPOSPRICE WHERE LOCATION='' AND PRO_TYPE='P' ) [S] ORDER BY ITEM_CODE",
                            connection.Connect());
                    dt = dataManager.GetData(command);

                }
                else
                {
                    dt =
                        dataManager.GetData(
                            "SELECT * FROM (SELECT LOCATION,ITEM_CODE,ITEM_BCODE,(SELECT ITEM_DESC FROM SIPITEMS WHERE ITEM_CODE=SIPOSPRICE.ITEM_CODE) [Description],(CASE PRO_FDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_FDATE,101) END) [PRO_FDATE],(CASE PRO_TDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_TDATE,101) END) [PRO_TDATE],(CASE PRO_TIMES WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMES) END) [PRO_TIMES],(CASE PRO_TIMEE WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMEE) END) [PRO_TIMEE],PRO_RATE,UNIT_SALE,(CASE STATUS WHEN 'A' THEN 'Active' ELSE 'Disable' END) [Status] FROM SIPOSPRICE WHERE PRO_TYPE='P' ) [S]",
                            "ITEM_CODE", "LOCATION", TreeView1.SelectedNode.ToolTipText);
                }
                foreach (DataRow row in dt.Rows)
                {
                    var j = dataGridViewX1.Rows.Add(row[0]);
                    for (int i = 0; i < dataGridViewX1.Columns.Count; i++)
                    {
                        dataGridViewX1.Rows[j].Cells[i].Value = row[i];
                    }
                    outLook.ChangeColorOnDisabledAndActive(dataGridViewX1,row[10].ToString(),j);
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
                    var node = TreeView1.Nodes[0].Nodes.Add(row[0].ToString().PadRight(7) + row[1]);
                    node.Tag = "I";
                    node.ToolTipText = row[0].ToString();
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
       }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            outLook.searching(connection.Connect(), dataGridViewX1,
                             "SELECT LOCATION,ITEM_CODE,ITEM_BCODE,(SELECT ITEM_DESC FROM SIPITEMS WHERE ITEM_CODE=SIPOSPRICE.ITEM_CODE) [Description],(CASE PRO_FDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_FDATE,101) END) [PRO_FDATE],(CASE PRO_TDATE WHEN NULL THEN '' ELSE CONVERT(NVARCHAR(15),PRO_TDATE,101) END) [PRO_TDATE],(CASE PRO_TIMES WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMES) END) [PRO_TIMES],(CASE PRO_TIMEE WHEN -1 THEN '' ELSE CONVERT(NVARCHAR(2),PRO_TIMEE) END) [PRO_TIMEE],PRO_RATE,UNIT_SALE,(CASE STATUS WHEN 'A' THEN 'Active' ELSE 'Disable' END) [Status] FROM SIPOSPRICE ",
                             "ITEM_CODE", ToolStrip2, ToolStrip3, "STATUS", "PRO_TYPE", "P");
            for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
            {
                outLook.ChangeColorOnDisabledAndActive(dataGridViewX1,dataGridViewX1.Rows[i].Cells[10].Value.ToString(),i);
            }
        }

        private void ShowData()
        {
            TreeView1_AfterSelect(null, null);
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewX1.SelectedRows.Count > 0)
                {
                    if (security.CheckPermission(UserLogOn.Code, menuItems.SetupPrice, "V", subMenuItems.EditLine, true) ==
       false)
                        return;
                    var dg = dataGridViewX1.SelectedRows[0];
                    var siaddsetupprice_FRM = new SIADDSETUPPRICE_FRM();
                    siaddsetupprice_FRM.Text = "Edit Price";
                    siaddsetupprice_FRM.txtProID.Text = dg.Cells[1].Value.ToString();
                    siaddsetupprice_FRM.txtProID.Enabled = false;
                    siaddsetupprice_FRM.btnProID.Enabled = false;
                    var condition = new string[] {"ITEM_CODE", siaddsetupprice_FRM.txtProID.Text};
                    siaddsetupprice_FRM.txtUnitofStock.Text = DataAccess.ReturnField("SELECT UNIT_STOCK FROM SIPITEMS",
                                                                                     "ITEM_CODE", condition, 0);
                    siaddsetupprice_FRM.txtProName.Text = dg.Cells[3].Value.ToString();
                    siaddsetupprice_FRM.txtSellingPrice.Text = dg.Cells[8].Value.ToString();
                    siaddsetupprice_FRM.txtUnitofSale.Text = dg.Cells[9].Value.ToString();
                    siaddsetupprice_FRM.txtUnitofSale.Enabled = false;
                    siaddsetupprice_FRM.btnUnitofSale.Enabled = false;
                    siaddsetupprice_FRM.cboStatus.Text = dg.Cells[10].Value.ToString().Substring(0, 1) + " - " +
                                                         dg.Cells[10].Value.ToString();
                    if (siaddsetupprice_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        var command =
                            new SqlCommand(
                                "UPDATE SIPOSPRICE SET PRO_RATE=@PRO_RATE,STATUS=@STATUS WHERE PRO_TYPE='P' AND ITEM_CODE=@ITEM_CODE AND LOCATION=@LOCATION AND UNIT_SALE=@UNIT_SALE",
                                connection.Connect());
                        if (TreeView1.SelectedNode.Tag == "R")
                        {
                            Commands.CreateParameter(command, "LOCATION", "", "ITEM_CODE",
                                                     siaddsetupprice_FRM.txtProID.Text, "PRO_RATE",
                                                     siaddsetupprice_FRM.txtSellingPrice.Text, "UNIT_SALE",
                                                     siaddsetupprice_FRM.txtUnitofSale.Text, "STATUS",
                                                     siaddsetupprice_FRM.cboStatus.Text.Substring(0, 1));
                        }
                        else
                        {
                            Commands.CreateParameter(command, "LOCATION", TreeView1.SelectedNode.ToolTipText, "ITEM_CODE",
                                                     siaddsetupprice_FRM.txtProID.Text, "PRO_RATE",
                                                     siaddsetupprice_FRM.txtSellingPrice.Text, "UNIT_SALE",
                                                     siaddsetupprice_FRM.txtUnitofSale.Text, "STATUS",
                                                     siaddsetupprice_FRM.cboStatus.Text.Substring(0, 1));
                        }
                        command.ExecuteNonQuery();
                        dg.Cells[8].Value = siaddsetupprice_FRM.txtSellingPrice.Text;
                        dg.Cells[10].Value = siaddsetupprice_FRM.cboStatus.Text.Substring(4);
                        outLook.Change_Color_On_Disabled_And_Active_On_Selected(dataGridViewX1,dg.Cells[10].Value.ToString());
                        MessageBox.Show("Record have been edited.", "Successfully", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                    }
                    siaddsetupprice_FRM.Close();
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
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.SetupPrice, "V", subMenuItems.DeleteLine, true) ==
       false)
                    return;
                if (MessageBox.Show("Are you sure you want to delete this record ?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        var command =
                            new SqlCommand(
                                "DELETE FROM SIPOSPRICE WHERE ITEM_CODE=@ITEM_CODE AND LOCATION=@LOCATION AND UNIT_SALE=@UNIT_SALE AND PRO_TYPE='P'",
                                connection.Connect());
                        if (TreeView1.SelectedNode.Tag == "R")
                        {
                            Commands.CreateParameter(command, "ITEM_CODE", dataGridViewX1.SelectedRows[0].Cells[1].Value,
                                                     "LOCATION", "", "UNIT_SALE",
                                                     dataGridViewX1.SelectedRows[0].Cells[9].Value.ToString());
                        }
                        else
                        {
                            Commands.CreateParameter(command, "ITEM_CODE", dataGridViewX1.SelectedRows[0].Cells[1].Value,
                                                    "LOCATION", TreeView1.SelectedNode.ToolTipText, "UNIT_SALE",
                                                    dataGridViewX1.SelectedRows[0].Cells[9].Value.ToString());
                        }
                        command.ExecuteNonQuery();
                        dataGridViewX1.Rows.Remove(dataGridViewX1.SelectedRows[0]);
                        MessageBox.Show("Record have been deleted.", "", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message);
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Please select data first!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
