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
using POS.Transaction.Maintains;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class SICUSDELIVERY_FRM : DevComponents.DotNetBar.Office2007Form
    {
        public SICUSDELIVERY_FRM()
        {
            InitializeComponent();
        }

        #region Global Variable

        readonly Connection.Connection  connection = new Connection.Connection();
        readonly DataManager dataManager = new DataManager();
        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        readonly DateTimes dateTimes  = new DateTimes();
        readonly Controls controls = new Controls();
        readonly SICustomerDelivery _customerDelivery = new SICustomerDelivery();
        readonly List<string> Clone = new List<string>();
// ReSharper disable FieldCanBeMadeReadOnly
        OutLook outLook = new OutLook();
// ReSharper restore FieldCanBeMadeReadOnly

        #endregion

        private void SICUSDELIVERY_FRM_Load(object sender, EventArgs e)
        {
            TreeView1.Nodes[0].Expand();
        }

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var command = new SqlCommand("SELECT ADD_CODE,ADD_NAME FROM SIPADDR WHERE ADD_TYPE='0'",connection.Connect());
            var dt = dataManager.GetData(command);
            var N = new TreeNode();
            TreeView1.Nodes[0].Nodes.Clear();
            foreach (DataRow row in dt.Rows)
            {
                N = TreeView1.Nodes[0].Nodes.Add(row[0].ToString(),
                                                 row[0].ToString().PadRight(18 - row[0].ToString().Length) + row[1], 1, 1);
                N.Tag = "CUSTOMER";
                N.ToolTipText = row[1].ToString();
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                DataGridView1.Rows.Clear();
                if ((string) TreeView1.SelectedNode.Tag == "CUSTOMER")
                {
                    NewToolStripButton.Enabled = true;
                    var command = new SqlCommand("SELECT * FROM SIPDADD WHERE ADD_CODE='" + TreeView1.SelectedNode.Name + "' AND DEL_TYPE='0'",connection.Connect());
                    var dt = dataManager.GetData(command);
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

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.CustomerDeliveryAddresses, "V", subMenuItems.NewLine, true) ==
            false)
                    return;
                var adddelivery_FRM = new ADDDELIVERY_FRM();
                adddelivery_FRM.Text = "Add Customer Delivery Address";
                if ((string) TreeView1.SelectedNode.Tag == "CUSTOMER")
                {
                    if (adddelivery_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        var values = new string[]
                                         {
                                             TreeView1.SelectedNode.Name, adddelivery_FRM.txtCode.Text,
                                             adddelivery_FRM.txtName.Text, adddelivery_FRM.txtadd1.Text,
                                             adddelivery_FRM.txtadd2.Text, adddelivery_FRM.txtadd3.Text,
                                             adddelivery_FRM.txtadd4.Text, adddelivery_FRM.txtadd5.Text,
                                             adddelivery_FRM.txttel.Text,
                                             adddelivery_FRM.txtfax.Text, adddelivery_FRM.txtemail.Text,
                                             adddelivery_FRM.txtweb.Text,
                                             adddelivery_FRM.txtContName.Text, adddelivery_FRM.txtCom1.Text,
                                             adddelivery_FRM.txtCom2.Text,
                                             "0", dateTimes.Now(), dateTimes.Now(), UserLogOn.Code
                                         };
                        _customerDelivery.Save(values);
                        controls.AddToDataGridView(DataGridView1, TreeView1.SelectedNode.Name, adddelivery_FRM.txtCode.Text, adddelivery_FRM.txtName.Text,
                                               adddelivery_FRM.txtadd1.Text, adddelivery_FRM.txtadd2.Text,
                                               adddelivery_FRM.txtadd3.Text, adddelivery_FRM.txtadd4.Text,
                                               adddelivery_FRM.txtadd5.Text, adddelivery_FRM.txttel.Text,
                                               adddelivery_FRM.txtfax.Text, adddelivery_FRM.txtemail.Text,
                                               adddelivery_FRM.txtweb.Text, adddelivery_FRM.txtContName.Text,
                                               adddelivery_FRM.txtCom1.Text, adddelivery_FRM.txtCom2.Text, "0",
                                               UserLogOn.Code, UserLogOn.Code, UserLogOn.Code);
                        Cursor = Cursors.Default;
                        MessageBox.Show("Record have beem created!", "Successful Created", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        adddelivery_FRM.Close();
                    }
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
                if (security.CheckPermission(UserLogOn.Code, menuItems.CustomerDeliveryAddresses, "V", subMenuItems.EditLine, true) ==
           false)
                    return;
                var delivery_FRM = new ADDDELIVERY_FRM();
                delivery_FRM.Text = "Edit Customer Delivery Address";
                delivery_FRM.txtCode.Enabled = false;
                delivery_FRM.txtCode.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                delivery_FRM.txtName.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                delivery_FRM.txtadd1.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                delivery_FRM.txtadd2.Text = DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                delivery_FRM.txtadd3.Text = DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                delivery_FRM.txtadd4.Text = DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                delivery_FRM.txtadd5.Text = DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                delivery_FRM.txttel.Text = DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                delivery_FRM.txtfax.Text = DataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                delivery_FRM.txtemail.Text = DataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                delivery_FRM.txtweb.Text = DataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                delivery_FRM.txtContName.Text = DataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                delivery_FRM.txtCom1.Text = DataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                delivery_FRM.txtCom2.Text = DataGridView1.SelectedRows[0].Cells[14].Value.ToString();

                if (delivery_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                  var paramAndValue = new string[]
                                            {
                                                "DEL_NAME", delivery_FRM.txtName.Text, "DEL_ADD_1",
                                                delivery_FRM.txtadd1.Text, "DEL_ADD_2",delivery_FRM.txtadd2.Text,
                                                "DEL_ADD_3",delivery_FRM.txtadd3.Text,"DEL_ADD_4",delivery_FRM.txtadd4.Text,
                                                "DEL_ADD_5",delivery_FRM.txtadd5.Text,"DEL_TEL",delivery_FRM.txttel.Text,
                                                "DEL_FAX",delivery_FRM.txtfax.Text,"DEL_EMAIL",delivery_FRM.txtemail.Text,
                                                "DEL_WEB", delivery_FRM.txtweb.Text,"DEL_CONT",delivery_FRM.txtContName.Text,
                                                "DEL_COM_1",delivery_FRM.txtCom1.Text,"DEL_COM_2",delivery_FRM.txtCom2.Text,
                                                "USER_UPDT",dateTimes.Now(),"USER_CODE",UserLogOn.Code
                                            };
                    var conditions = new string[]
                                         {
                                             "ADD_CODE", TreeView1.SelectedNode.Name,
                                             "DEL_CODE",delivery_FRM.txtCode.Text,"DEL_TYPE","0"
                                         };

                    _customerDelivery.Update(paramAndValue, conditions);

                    controls.UpdateDataToGridView(DataGridView1, TreeView1.SelectedNode.Name, delivery_FRM.txtCode.Text,
                                                  delivery_FRM.txtName.Text, delivery_FRM.txtadd1.Text,
                                                  delivery_FRM.txtadd2.Text, delivery_FRM.txtadd3.Text,
                                                  delivery_FRM.txtadd4.Text, delivery_FRM.txtadd5.Text,
                                                  delivery_FRM.txttel.Text, delivery_FRM.txtfax.Text,
                                                  delivery_FRM.txtemail.Text, delivery_FRM.txtweb.Text,
                                                  delivery_FRM.txtContName.Text, delivery_FRM.txtCom1.Text,
                                                  delivery_FRM.txtCom2.Text, "0",
                                                  DataGridView1.SelectedRows[0].Cells[17].Value.ToString(),
                                                  dateTimes.Now(), UserLogOn.Code);
                    Cursor = Cursors.Default;
                    MessageBox.Show("Record have been edited!", "Successfull Edit", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    delivery_FRM.Close();
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
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.CustomerDeliveryAddresses, "V", subMenuItems.DeleteLine, true) ==
    false)
                    return;
                if (MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    var paraAndValue = new string[] { "ADD_CODE", TreeView1.SelectedNode.Name, "DEL_CODE", DataGridView1.SelectedRows[0].Cells[1].Value.ToString(), "DEL_TYPE", "0" };
                    _customerDelivery.Delete(paraAndValue);
                    DataGridView1.Rows.Remove(DataGridView1.SelectedRows[0]);
                    MessageBox.Show("Record was deleted successfully!", "Delete", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.CustomerDeliveryAddresses, "V", subMenuItems.CloneLine, true) ==
    false)
                return;
            Clone.Clear();
            if (DataGridView1.Rows.Count !=0)
            {
                outLook.CloneData(Clone, DataGridView1);
                PasteToolStripMenuItem1.Enabled = true;
                PasteToolStripMenuItem.Enabled = true;
            }
           
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
//                if (security.CheckPermission(UserLogOn.Code, menuItems.CustomerDeliveryAddresses, "V", subMenuItems.PasteLine, true) ==
//    false)
//                    return;
                var adddeliveryFrm = new ADDDELIVERY_FRM();
                adddeliveryFrm.Text = "Paste Item Record";
                var textBox = new TextBox() { };
                textBox.Text = "";
                outLook.PasteData(Clone, textBox, adddeliveryFrm.txtCode, adddeliveryFrm.txtName,
                                  adddeliveryFrm.txtadd1, adddeliveryFrm.txtadd2,
                                  adddeliveryFrm.txtadd3, adddeliveryFrm.txtadd4,
                                  adddeliveryFrm.txtadd5, adddeliveryFrm.txttel, adddeliveryFrm.txtfax,
                                  adddeliveryFrm.txtemail, adddeliveryFrm.txtweb, adddeliveryFrm.txtContName,
                                  adddeliveryFrm.txtCom1, adddeliveryFrm.txtCom2);
            lbl:
                if (adddeliveryFrm.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;

                    if (dataManager.Exists("SIPDADD",adddeliveryFrm.txtCode.Text,"DEL_CODE"))
                    {
                        MessageBox.Show("Code" + adddeliveryFrm.txtCode.Text + "Already.", "Existing Code",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            goto lbl;
                    }

                    var values = new[]
                                 {
                                     DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), adddeliveryFrm.txtCode.Text, adddeliveryFrm.txtName.Text,
                                     adddeliveryFrm.txtadd1.Text,adddeliveryFrm.txtadd2.Text,adddeliveryFrm.txtadd3.Text,
                                     adddeliveryFrm.txtadd4.Text,adddeliveryFrm.txtadd5.Text,adddeliveryFrm.txttel.Text,
                                     adddeliveryFrm.txtfax.Text,adddeliveryFrm.txtemail.Text,adddeliveryFrm.txtweb.Text,
                                     adddeliveryFrm.txtContName.Text,adddeliveryFrm.txtCom1.Text,adddeliveryFrm.txtCom2.Text,
                                     "0",dateTimes.Now(),dateTimes.Now(),UserLogOn.Code
                                     
                                 };
                    _customerDelivery.Save(values);
                    var val = new[]
                                  {
                                      TreeView1.SelectedNode.Name, adddeliveryFrm.txtCode.Text,
                                      adddeliveryFrm.txtName.Text, adddeliveryFrm.txtadd1.Text,
                                      adddeliveryFrm.txtadd2.Text, adddeliveryFrm.txtadd3.Text,
                                      adddeliveryFrm.txtadd4.Text, adddeliveryFrm.txtadd5.Text,
                                      adddeliveryFrm.txttel.Text, adddeliveryFrm.txtfax.Text,
                                      adddeliveryFrm.txtemail.Text, adddeliveryFrm.txtweb.Text,
                                      adddeliveryFrm.txtContName.Text, adddeliveryFrm.txtCom1.Text,
                                      adddeliveryFrm.txtCom2.Text, "0",UserLogOn.Code,dateTimes.Now(), UserLogOn.Code
                                  };
                    controls.AddToDataGridView(DataGridView1, val);
                    Cursor = Cursors.Default;
                    MessageBox.Show("Record have been pasted!", "Paste Successful", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    adddeliveryFrm.Close();
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           EditToolStripButton1_Click(sender,e);
        }

        #region Actions

        private void NewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToolStripButton_Click(sender,e);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditToolStripButton1_Click(sender,e);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
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

        #endregion

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                DataGridView1.Rows.Clear();
                if ((string) TreeView1.SelectedNode.Tag == "CUSTOMER")
                {
                    NewToolStripButton.Enabled = true;
                    var command =
                        new SqlCommand(
                            "SELECT * FROM SIPDADD WHERE ADD_CODE='" + TreeView1.SelectedNode.Name +
                            "' and DEL_TYPE='0'", connection.Connect());
                    var dt = dataManager.GetData(command);
                    foreach (DataRow row in dt.Rows)
                    {
                        int i;
                        i = DataGridView1.Rows.Add(row[0]);
                        for (int j = 1; j < dt.Columns.Count -1; j++)
                        {
                            DataGridView1.Rows[i].Cells[j].Value = row[j];
                        }
                    }
                }
                else
                {
                    NewToolStripButton.Enabled = false;
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseTool_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
