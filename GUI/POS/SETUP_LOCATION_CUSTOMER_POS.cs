using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction;
using POS.Transaction.Sale;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.POS
{
    public partial class SetupLocationCustomerPos : Form
    {
        public SetupLocationCustomerPos()
        {
            InitializeComponent();
        }

        #region Global variable

        public bool isEdit = false;
        readonly OutLook outLook = new OutLook();
        private readonly List<string> clone = new List<string>();
        readonly SISecurity security = new SISecurity();
        SIMenuItems menuItems = new SIMenuItems();
        SISubMenuItems subMenuItems = new SISubMenuItems();

        #endregion

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                DataGridView1.Rows.Clear();
                if (TreeView1.SelectedNode.IsSelected && TreeView1.SelectedNode != null)
                {
                    NewToolStripButton.Enabled = true;
                    var dt =
                        dataManager.GetData(
                            "SELECT dbo.SIPCUSPOS.LOC_CODE, dbo.SIPLOCA.LOC_NAME, " +
                            "dbo.SIPCUSPOS.EMP_CODE, SUBSTRING(dbo.SIPDATA.SI_DATA,0,15) [Location Name], dbo.SIPCUSPOS.ADD_CODE, dbo.SIPADDR.ADD_NAME, " +
                            "dbo.SIPUSERS.USER_CODE, dbo.SIPUSERS.[USER_NAME] FROM dbo.SIPCUSPOS INNER JOIN dbo.SIPADDR ON dbo.SIPCUSPOS.ADD_CODE = dbo.SIPADDR.ADD_CODE " +
                            "INNER JOIN dbo.SIPLOCA ON dbo.SIPCUSPOS.LOC_CODE = dbo.SIPLOCA.LOC_CODE INNER JOIN dbo.SIPDATA " +
                            "ON dbo.SIPCUSPOS.EMP_CODE = dbo.SIPDATA.SI_CODE INNER JOIN dbo.SIPUSERS ON dbo.SIPCUSPOS.USER_CODE = dbo.SIPUSERS.USER_CODE WHERE dbo.SIPCUSPOS.LOC_CODE = '" + TreeView1.SelectedNode.Tag + "'");
                    foreach (DataRow row in dt.Rows)
                    {
                        int i;
                        i = DataGridView1.Rows.Add(row[0]);
                        for (int j = 1; j < dt.Columns.Count; j++)
                        {
                            DataGridView1.Rows[i].Cells[j].Value = row[j];
                        }
                    }
                }
                else
                {
                    DataGridView1.Rows.Clear();
                    NewsToolStripMenuItem.Enabled = false;
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
            var dt = dataManager.GetData("SELECT LOC_CODE, LOC_NAME FROM SIPLOCA ORDER BY LOC_CODE ASC");
            var N = new TreeNode();
            TreeView1.Nodes[0].Nodes.Clear();
            foreach (DataRow row in dt.Rows)
            {
                N = TreeView1.Nodes[0].Nodes.Add(row[0].ToString(),
                                                 row[0].ToString().PadRight(18 - row[0].ToString().Length) + row[1], 1, 1);
                N.Tag = row[0];
                N.ToolTipText = row[1].ToString();
            }
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.AddCustomerInPOS, "V", subMenuItems.NewLine, true) ==
           false)
                return;
            if ((string) TreeView1.SelectedNode.Tag == "ROOT")
            {
                MessageBox.Show("Please Select location to add data", "Blank Location", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var addcustomerPOS = new AddcustomerPos(this)
                                     {
                                         txtLocCode = {Text = TreeView1.SelectedNode.Tag.ToString()}
                                     };
            var condition = new[] {"LOC_CODE", TreeView1.SelectedNode.Tag.ToString()};
            addcustomerPOS.txtLocName.Text =
                DataAccess.ReturnField(
                    "SELECT LOC_NAME FROM SIPLOCA",
                    "LOC_CODE",condition , 0);
            addcustomerPOS.txtLocCode.Enabled = false;
            addcustomerPOS.txtLocName.Enabled = false;
            isEdit = false;
            addcustomerPOS.ShowDialog();
                
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.AddCustomerInPOS, "V", subMenuItems.EditLine, true) ==
          false)
                return;
           var addcustomerPOS = new AddcustomerPos(this);
            if (DataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Please select record to edit", "Selectioin", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }
            addcustomerPOS.txtLocCode.Text = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            addcustomerPOS.txtLocName.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            addcustomerPOS.txtEmpCode.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            addcustomerPOS.txtEmpName.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            addcustomerPOS.txtCustomerCode.Text = DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            addcustomerPOS.txtCustomerName.Text = DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            addcustomerPOS.txtUserCode.Text = DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            addcustomerPOS.txtUserName.Text = DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            addcustomerPOS.txtLocName.Enabled = false;
            addcustomerPOS.txtLocCode.Enabled = false;
            isEdit = true;
            addcustomerPOS.ShowDialog();
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.AddCustomerInPOS, "V", subMenuItems.DeleteLine, true) ==
          false)
                return;
            if (DataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Please select record to edit", "Selectioin", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Do you want to delete this record?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var setupCustomerPOS = new SetupCustomerPOS();
                var condition = new string[]
                                    {
                                        "LOC_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), "EMP_CODE",
                                        DataGridView1.SelectedRows[0].Cells[2].Value.ToString(), "ADD_CODE",
                                        DataGridView1.SelectedRows[0].Cells[4].Value.ToString()
                                    };
                setupCustomerPOS.Delete(condition);
                DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Delete Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CloseTool_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.AddCustomerInPOS, "V", subMenuItems.CloneLine, true) ==
          false)
                return;
            outLook.CloneData(clone, DataGridView1);
            PasteToolStripMenuItem.Enabled = true;
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addcustomerPOS = new AddcustomerPos(this);
            outLook.PasteData(clone, addcustomerPOS.txtLocCode, addcustomerPOS.txtLocName, addcustomerPOS.txtEmpCode,
                              addcustomerPOS.txtEmpName, addcustomerPOS.txtCustomerCode, addcustomerPOS.txtCustomerName,
                              addcustomerPOS.txtUserCode, addcustomerPOS.txtUserName);
            isEdit = false;
            addcustomerPOS.ShowDialog();
        }

        
    }
}
