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
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Inventory
{
    public partial class SIMOVEMENTLINE_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public SIMOVEMENTLINE_FRM()
        {
            InitializeComponent();
        }

        #region Global Variable

        public bool MAKE_CHANGE = false;
        public string CURRENT_PRD = "";
        readonly Connection.Connection connection = new Connection.Connection();
        Server server = new Server();
        public int OPEN_HELD_SEQ;
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        readonly SISecurity security = new SISecurity();
        readonly DataManager dataManager = new DataManager();
        private Decimal PHYSICAL;
        private Decimal OnHold;
        public bool IS_EDIT = false;
        readonly MovementEntry movement = new MovementEntry();
        Utilities.Controls controls = new Controls();

        #endregion

        private void SIMOVEMENTLINE_FRM_Load(object sender, EventArgs e)
        {

        }

        private void MovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.MovementEntry, "V", subMenuItems.PurchaseInvoice, true) ==
                   false)
                return;
            try
            {
                if (MAKE_CHANGE)
                {
                    if (
                        MessageBox.Show("Are you sure you want to clear current change?", "Clear", MessageBoxButtons.OK,
                                        MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                        return;
                }
                var siheldmovement_FRM = new SIHELDMOVEMENT_FRM();
                var dt = dataManager.GetData("SELECT DISTINCT MOV_PRD FROM SIPINMOH ", "MOV_PRD", "STATUS", "10", "IR_STAT","T");
//                siheldmovement_FRM.TreeView1.Nodes[0].Text = CURRENT_PRD;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        siheldmovement_FRM.TreeView1.Nodes[0].Nodes.Add(row[0].ToString(), row[0].ToString(), 1);
                    }
                }
                siheldmovement_FRM.TreeView1.Tag = "Tran";
                if (siheldmovement_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    StartMovement();
                    txtMov_Ref.Text =
                        siheldmovement_FRM.dataGridViewX1.Rows[siheldmovement_FRM.SELECT_INDEX].Cells[1].Value.ToString();
                    var ddd = siheldmovement_FRM.dataGridViewX1.Rows[siheldmovement_FRM.SELECT_INDEX].Cells[3].Value.ToString();
                    dtpMov_Date.Value =
                        Convert.ToDateTime(
                            siheldmovement_FRM.dataGridViewX1.Rows[siheldmovement_FRM.SELECT_INDEX].Cells[3].Value.
                                ToString());
                    txtPrd.Text = siheldmovement_FRM.TreeView1.SelectedNode.Nodes[0].Text;

                    controls.Enabled_Control_False(txtItem_Code, btnItem_Code, txtLoc_Code1, btnLoc_Code1, txtLoc_Code2,
                                                   btnLoc_Code2, txtOnHold,txtFree,txtQTY);
                    OPEN_HELD_SEQ =
                        Convert.ToInt16(siheldmovement_FRM.dataGridViewX1.Rows[siheldmovement_FRM.SELECT_INDEX].Cells[0].Value.ToString());

                    var cmd =
                        new SqlCommand(
                            "SELECT  H.MOV_LINE, H.LOCATION,H.LOC_TRAN,H.ITEM_CODE, dbo.SIPITEMS.ITEM_DESC, H.QUANTITY, H.COST, H.TOTAL, H.MOV_UNITS,H.MOV_PRD FROM  SIPINMOH H INNER JOIN dbo.SIPITEMS ON H.ITEM_CODE = dbo.SIPITEMS.ITEM_CODE WHERE SEQUENCE = @SEQUENCE AND STATUS =@STATUS ",
                            connection.Connect());
                    cmd.Parameters.AddWithValue("@SEQUENCE", OPEN_HELD_SEQ);
                    cmd.Parameters.AddWithValue("@STATUS", "10");
                    var dtMov = new DataTable();
                    var dataAdapter = new SqlDataAdapter(cmd).Fill(dtMov);
                    dataGridViewX1.Rows.Clear();
                    foreach (DataRow row in dtMov.Rows)
                    {
                        dataGridViewX1.Rows.Add(row[0], row[1], row[2],row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
                    }
                    lblInvoiceValue.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 7));
                    lblTotalQuantity.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 5));
                    txtMov_Ref.Enabled = false;
                    txtPrd.Enabled = false;
                    dtpMov_Date.Enabled = false;
                    Cursor = Cursors.Default;    
                }
                siheldmovement_FRM.Close();

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void StartToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.Rows.Count > 0)
            {
                if (MessageBox.Show("without saving some change?", "Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            txtMov_Ref.Text = "";
            OPEN_HELD_SEQ = 0;
            txtMov_Ref.Enabled = true;
            dataGridViewX1.Rows.Clear();
            controls.ClearControl(txtLoc_Code2,txtItem_Code,txtItem_Desc,txtUnitofStock,txtOnHold,txtFree,txtTotalAmount);
            txtMov_Ref.Focus();
            StartMovement();
        }

        private void btnItem_Code_Click(object sender, EventArgs e)
        {
            try
            {
                var droplist_FRM = new DROPLIST_FRM
                                       {
                                           DataGridView =
                                               {
                                                   DataSource = dataManager.GetData(
                                                       "SELECT ITEM_CODE [Item Code], ITEM_DESC [Description],UNIT_STOCK,ITEM_COST1,UNIT_SALE,ITEM_COST2 FROM SIPITEMS",
                                                       "ITEM_CODE", "ITEM_STAT", "A", "ITEM_TYPE", "S")
                                               },
                                           Top = (this.Top + txtItem_Code.Top + txtItem_Code.Height + 70),
                                           Left = (this.Left + txtItem_Code.Left )
                                       };
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width * 27 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width * 27 / 100;
                droplist_FRM.DataGridView.Columns[2].Width = droplist_FRM.DataGridView.Width * 40 / 100;
                droplist_FRM.DataGridView.Columns[3].Visible = false;
                droplist_FRM.DataGridView.Columns[4].Visible = false;
                droplist_FRM.DataGridView.Columns[5].Visible = false;
                if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtItem_Code.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    txtItem_Desc.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[1].Value.ToString();
                    txtUnitofStock.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    txtLoc_Code1.Enabled = true;
                    btnLoc_Code1.Enabled = true;
                    txtItem_Code.Enabled = false;
                    btnItem_Code.Enabled = false;
                    SelectNextControl(txtItem_Code, true, true, true, true);
                }
                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLoc_Code1_Click(object sender, EventArgs e)
        {
            try
            {
                var droplist_FRM = new DROPLIST_FRM
                                                {
                                                    DataGridView =
                                                        {
                                                            DataSource =
                                                                dataManager.GetData(
                                                                "SELECT LOC_CODE [Location Code], LOC_NAME [Location Name] FROM dbo.SIPLOCA",
                                                                "LOC_CODE", "LOC_STAT", "A")
                                                        },
                                                    Top = (this.Top + txtLoc_Code1.Top + txtLoc_Code1.Height + 71),
                                                    Left = (this.Left + txtLoc_Code1.Left )
                                                };
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width * 34 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width * 60 / 100;
                if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtLoc_Code1.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    lblLoc.Enabled = true;
                    PHYSICAL = movement.GetItem("P", txtLoc_Code1.Text, txtItem_Code.Text);
                    OnHold = movement.GetItem("O", txtLoc_Code1.Text, txtItem_Code.Text);
                    var d = SIDataGridView.Sum(dataGridViewX1, 5, txtLoc_Code1.Text,"1",txtItem_Code.Text,"3");
                    d = d + OnHold;
                    txtPhysical.Text = PHYSICAL.ToString();
                    txtOnHold.Text = d.ToString();
                    txtFree.Text = Convert.ToString(PHYSICAL - d);
                    txtLoc_Code1.Enabled = false;
                    btnLoc_Code1.Enabled = false;
                    txtLoc_Code2.Enabled = true;
                    btnLoc_Code2.Enabled = true;
                    SelectNextControl(txtLoc_Code1, true, true, true, true);
                }
                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoc_Code2_Click(object sender, EventArgs e)
        {
            var droplist_FRM = new DROPLIST_FRM
                                   {
                                       DataGridView =
                                           {
                                               DataSource =
                                                   dataManager.GetData(
                                                   "SELECT LOC_CODE [Location Code], LOC_NAME [Location Name] FROM dbo.SIPLOCA",
                                                   "LOC_CODE", "LOC_STAT", "A")
                                           },
                                       Top = (Top + txtLoc_Code2.Top + txtLoc_Code1.Height + 71),
                                       Left = (Left + txtLoc_Code2.Left)
                                   };
            droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width * 34 / 100;
            droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width * 60 / 100;
            if (droplist_FRM.ShowDialog() == DialogResult.OK)
            {
                if (txtLoc_Code1.Text == droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Transfer location cannot the same as location!");
                    txtLoc_Code2.Focus();
                    txtQTY.Enabled = false;
                    txtLoc_Code2.SelectAll();
                    return;
                }
                else
                {
                    txtLoc_Code2.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    txtLoc_Code2.Enabled = true;
                    btnLoc_Code2.Enabled = true;
                    txtQTY.Enabled = true;
                    txtQTY.BackColor = Color.White;
                    SelectNextControl(btnLoc_Code2, true, true, true, true);
                }
            }
        }

        private void txtItem_Code_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtItem_Code.Text == "")
                    {
                        if (Condition.EmptyControl(txtItem_Code))
                            return;
                    }
                    else
                    {
                        var dt = dataManager.GetData(
                            "SELECT ITEM_CODE [Item Code], ITEM_DESC [Description],UNIT_STOCK,ITEM_COST1,UNIT_SALE,ITEM_COST2 FROM SIPITEMS",
                            "ITEM_CODE", "ITEM_STAT", "A", "ITEM_TYPE", "S", "ITEM_CODE", txtItem_Code.Text);
                        if (dt.Rows.Count > 0)
                        {
                            txtItem_Code.Text = dt.Rows[0][0].ToString();
                            txtItem_Desc.Text = dt.Rows[0][1].ToString();
                            txtUnitofStock.Text = dt.Rows[0][2].ToString();
                            txtItem_Desc.Enabled = false;
                            txtItem_Code.BackColor = Color.WhiteSmoke;
                            btnItem_Code.Enabled = false;
                            txtItem_Code.Enabled = false;
                            txtLoc_Code1.Enabled = true;
                            txtLoc_Code1.BackColor = Color.White;
                            btnLoc_Code1.Enabled = true;
                            txtPrd.Enabled = false;
                            SelectNextControl(txtItem_Code, true, true, true, true);
                        }
                        else
                        {
                            MessageBox.Show("Data ' " + txtItem_Code.Text + "' not found!", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            txtItem_Code.SelectionStart = 0;
                            txtItem_Code.SelectionLength = txtItem_Code.ToString().Length;
                        }
                    }
                }
                else if (e.KeyCode == Keys.F6)
                {
                    btnItem_Code_Click(sender, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQTY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtQTY.Text == ""))
                {
                    MessageBox.Show("Please input data.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtQTY.Enabled = false;
                txtCost.Enabled = true;
                txtQTY.SelectNextControl(txtQTY, true, true, true, true);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtLoc_Code2.Enabled = true;
                btnLoc_Code2.Enabled = true;
                txtQTY.Enabled = false;
                SelectNextControl(txtQTY, false, true, true, true);
            }
        }

        private void txtQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            var strings = new Strings();
            if (e.KeyChar == (char)13)
            {
                if (Condition.EmptyControl(txtQTY))
                {
                    txtQTY.Focus();
                    return;
                }
                    
                if (!strings.IsNumeric(txtQTY.Text))
                    return;
                if (Convert.ToDecimal(txtQTY.Text) > Convert.ToDecimal("9999999999"))
                {
                    MessageBox.Show("Value is too large.", "Larg Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQTY.SelectionStart = 0;
                    txtQTY.SelectionLength = txtQTY.Text.Length;
                    txtQTY.SelectAll();
                    txtQTY.Focus();
                    return;
                }
                if (txtCost.Text == "")
                    txtCost.Text = "0";
                txtQTY.Enabled = false;
                txtTotalAmount.Text = Convert.ToString(Convert.ToDecimal(txtQTY.Text)*Convert.ToDecimal(txtCost.Text));
                toolStripButton5.Select();
                txtCost.Enabled = true;
                txtCost.Focus();
                button1.Focus();
            }
        }

        private void StartMovement()
        {
            try
            {
                dtpMov_Date.Value = UserLogOn.Date;
                Panel1.Enabled = true;
                MAKE_CHANGE = false;
                //                txtMov_Ref.Text = "";
                //                dataGridViewX1.Rows.Clear();
                // Total
                //                lblInvoiceValue.Text = "";
                //                lblTotalQuantity.Text = "";
                var main_Frm = new MAIN_FRM();
                main_Frm.StatusStrip.Items[0].Text = "Ready";
                //                OPEN_HELD_SEQ = 0; // reset open status to default
                controls.ClearControl(txtItem_Code, txtItem_Desc, txtLoc_Code1, txtLoc_Code2, txtLineNo, txtUnitofStock,
                                      txtQTY, txtPhysical, txtCost, txtTotalAmount);
                txtTotalAmount.Text = "0.00";
                txtFree.Text = "0";
                txtPhysical.Text = "0";
                txtQTY.Text = "0";
                txtCost.Text = "0.00";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (security.CheckPermission(UserLogOn.Code, menuItems.MovementEntry, "V", subMenuItems.NewLine, true) ==
                  false)
                return;
            if (txtMov_Ref.Text == "")
            {
                txtMov_Ref.BackColor = Color.Red;
                MessageBox.Show("Please input into Move_Ref", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMov_Ref.Focus();
                return;
            }
//            if (txtItem_Code.Text == "" && txtLoc_Code1.Text =="" && dataGridViewX1.Rows.Count != 0)
//            {
//               return;
//            }
            if (dataGridViewX1.Rows.Count > 0)
            {
                if (MessageBox.Show("Do you want to clear change this transaction?","Clear Data",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                   return;
                }
            }
            txtPrd.Text = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString();
            controls.EnabledControlTrue(txtItem_Code, btnItem_Code);
            txtMov_Ref.Enabled = false;
            controls.ClearControl(txtItem_Code, txtItem_Desc, txtLoc_Code1, txtLoc_Code2, txtLineNo, txtUnitofStock,
                                      txtQTY, txtPhysical, txtCost, txtTotalAmount);
            txtFree.Text = "";
            txtOnHold.Text = "";
            txtLoc_Code2.Enabled = false;
            btnLoc_Code2.Enabled = false;
            dtpMov_Date.Enabled = true;
            txtQTY.Enabled = false;
            txtCost.Enabled = false;
            dtpMov_Date.Enabled = false;
            txtLoc_Code1.Enabled = false;
            btnLoc_Code1.Enabled = false;
            txtLineNo.Text = string.Format("{0:000}", dataGridViewX1.Rows.Count + 1);
            txtItem_Code.Focus();
            IS_EDIT = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Condition.EmptyControl(txtItem_Code, txtLoc_Code1, txtLoc_Code2) && txtQTY.Text == "0")
                {
                    MessageBox.Show("Plaese Input data to add new line", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (IS_EDIT == false)
                {
                    #region Add New Line

                    
                    if (Convert.ToDecimal(txtTotalAmount.Text) != 0)
                    {
                        if (Convert.ToDecimal(txtTotalAmount.Text) > Convert.ToDecimal("9999999999"))
                        {
                            MessageBox.Show("Value is too large.", "Large Number", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            txtQTY.SelectAll();
                            txtQTY.Focus();
                            return;
                        }
                    }
                    if (Convert.ToDecimal(txtFree.Text) < Convert.ToDecimal(txtQTY.Text))
                    {
                        MessageBox.Show("There are not enough stock for this item!", "", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        txtQTY.Focus();
                        txtQTY.SelectAll();
                        txtQTY.Enabled = true;
                        return;
                    }

                    Decimal lineNo = 0;
                    if (dataGridViewX1.Rows.Count != 0)
                    {
                        var line = dataGridViewX1.Rows[dataGridViewX1.Rows.Count - 1].Cells[0].Value;

                        if (line != "")
                        {
                            lineNo = Convert.ToInt16(line);
                        }
                    }
                    
                    dataGridViewX1.Rows.Add(string.Format("{0:000}", lineNo + 1), txtLoc_Code1.Text, txtLoc_Code2.Text, txtItem_Code.Text,
                                            txtItem_Desc.Text, txtQTY.Text, txtCost.Text, txtTotalAmount.Text,
                                            txtUnitofStock.Text,txtPrd.Text);
                    lblInvoiceValue.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 7));
                    lblTotalQuantity.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 5));
                    txtFree.Text = Convert.ToString(Convert.ToDecimal(txtFree.Text) - Convert.ToDecimal(txtQTY.Text));
                  
                    #endregion
                }
                else
                {
                    SIDataGridView.BindingData_ToGrid_OnSelected(dataGridViewX1, txtLineNo.Text, txtLoc_Code1.Text,
                                                                 txtLoc_Code2.Text,
                                                                 txtItem_Code.Text, txtItem_Desc.Text, txtQTY.Text,
                                                                 txtCost.Text, txtTotalAmount.Text,
                                                                 txtUnitofStock.Text);
                }
                txtMov_Ref.Enabled = false;
                txtPrd.Enabled = false;
                dtpMov_Date.Enabled = false;
                txtLoc_Code2.Enabled = false;
                btnLoc_Code2.Enabled = false;
                txtItem_Code.Enabled = true;
                btnItem_Code.Enabled = true;
                StartMovement();
                txtLineNo.Text = string.Format("{0:000}", dataGridViewX1.Rows.Count + 1);
                txtFree.Text = "";
                txtOnHold.Text = "";
                lblInvoiceValue.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 7));
                lblTotalQuantity.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 5));
                txtCost.Enabled = false;
                txtItem_Code.Enabled = false;
                btnItem_Code.Enabled = false;
                     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            txtItem_Code.Enabled = false;
            txtItem_Code.Focus();
            txtQTY.Enabled = false;
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.MovementEntry, "V", subMenuItems.EditLine, true) ==
                false)
                    return;
                if (Condition.EmptyControl(txtMov_Ref))
                    return;

                if (dataGridViewX1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("There are no selected item in the list!", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
                Cursor = Cursors.WaitCursor;
                SIDataGridView.BindingDataGird_OnSelect_Into_Textbox(dataGridViewX1, txtLineNo, txtLoc_Code1, txtLoc_Code2,
                                                                     txtItem_Code, txtItem_Desc, txtQTY, txtCost,
                                                                     txtTotalAmount);
                txtUnitofStock.Text = dataGridViewX1.SelectedRows[0].Cells[8].Value.ToString();
                PHYSICAL = movement.GetItem("P", txtLoc_Code1.Text, txtItem_Code.Text);//,"T");
                OnHold = movement.GetItem("O", txtLoc_Code1.Text, txtItem_Code.Text);//,"");
                var d = SIDataGridView.Sum(dataGridViewX1, 5, txtLoc_Code1.Text, "1", txtItem_Code.Text, "3");
                d = d + OnHold;
                txtPhysical.Text = PHYSICAL.ToString();
                txtOnHold.Text = d.ToString();
                txtFree.Text = Convert.ToString(PHYSICAL - d);
                btnItem_Code.Enabled = true;
                txtItem_Code.Enabled = true;
                controls.Enabled_Control_False(txtLoc_Code1,txtLoc_Code2,btnLoc_Code2,btnLoc_Code1,txtQTY,txtCost);
                IS_EDIT = true;
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }

        }

        private void toolstripRemoveLine_Click(object sender, EventArgs e)
        {
            var lineNo = 0;
            if (security.CheckPermission(UserLogOn.Code, menuItems.MovementEntry, "V", subMenuItems.DeleteLine, true) ==
                false) 
                return;
            
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this item?", "Remove Line", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    dataGridViewX1.Rows.Remove(dataGridViewX1.SelectedRows[0]);
                    foreach (DataGridViewRow row in dataGridViewX1.Rows)
                    {
                        lineNo += 1;
                        row.Cells[0].Value = string.Format("{0:000}", lineNo);
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no selected item to remove.","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }

        private void HeldToolStripButton2_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.MovementEntry, "V", subMenuItems.HeldBatch, true) ==
                false)
                return;
            if (dataGridViewX1.Rows.Count > 0)
            {
                if (Condition.EmptyControl(txtMov_Ref))
                    return;

                if (
                    MessageBox.Show("Are you sure you want to held the movement ?", "Held Batch",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    try
                    {
                        if (HeldBatch() == false)
                            return;
                        MessageBox.Show("Movement have been held successfully.", "Successful", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("There are no items for posting!");
                }
            }
        }

        private bool HeldBatch()
        {
            int sequance = 1;
            Cursor = Cursors.WaitCursor;
           
            var command = new SqlCommand("",connection.Connect());
//            command.Transaction = connection.Connect().BeginTransaction();
            try
            {
                if (OPEN_HELD_SEQ != 0)
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM SIPINMOH WHERE [SEQUENCE]=@SEQ";
                    command.Parameters.AddWithValue("@SEQ", OPEN_HELD_SEQ);
                    command.ExecuteNonQuery();
                }
                try
                {
                    if (DataAccess.ReturnField("SELECT MAX(SEQUENCE) FROM dbo.SIPINMOH", 0) != "")
                    {
                        sequance = Convert.ToInt16(DataAccess.ReturnField("SELECT MAX(SEQUENCE) FROM dbo.SIPINMOH", 0)) + 1;
                    }
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                    return false;
                }
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SI_INSERT_SIPINMOH";
                var i = 1;
                var str = DateTime.Today.ToString("MM/dd/yyyy");
                foreach (DataGridViewRow row in dataGridViewX1.Rows)
                {
                    command.Parameters.Clear();
                    Commands.CreateParameter(command, "SEQUENCE_1", sequance, "REC_TYPE_2", "M", "MOV_PRD_3",
                                             txtPrd.Text,"MOV_DATE_4",dtpMov_Date.Value, "MOV_REF_5", txtMov_Ref.Text, "MOV_LINE_6",string.Format("{0:000}",i),
                                             "LOCATION_7", row.Cells[1].Value.ToString(), "LOC_TRAN_8",row.Cells[2].Value.ToString(),
                                             "ITEM_CODE_9", row.Cells[3].Value.ToString(), "STATUS_10", "10", "IR_STAT_11","T",
                                             "LINE_REF_12", "", "QUANTITY_13", Convert.ToInt64(row.Cells[5].Value), "COST_14",Convert.ToDecimal(row.Cells[6].Value.ToString()),
                                             "TOTAL_15", Convert.ToDecimal(row.Cells[7].Value.ToString()), "MOV_UNITS_16",row.Cells[8].Value.ToString(),
                                             "MOV_TYPE_17", "TRAN", "ID_ENTERED_18", UserLogOn.Code, "DATE_ENTERED", DateTime.Now, "ID_UPDATE_20", UserLogOn.Code, "DATE_UPDT", DateTime.Today.ToString("MM/dd/yyyy"));
                    command.ExecuteNonQuery();
                    i++;
                }
                StartMovement();
                txtMov_Ref.Text = "";
                txtMov_Ref.Enabled = true;
                txtPrd.Text = "";
                txtMov_Ref.Focus();
//                command.Transaction.Commit();
                dataGridViewX1.Rows.Clear();
                Cursor = Cursors.Default;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cursor = Cursors.Default;
                command.Transaction.Rollback();
                return false;
            }
        }

        private bool PostBatchMovement()
        {
            if (string.IsNullOrEmpty(txtFree.Text))
            {
                txtFree.Text = "0";
            }

            if (Convert.ToDecimal(txtFree.Text) < 0)
            {
                MessageBox.Show("None stock to post", "Not Enough", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {


                var sequance = 1;
                Cursor = Cursors.WaitCursor;
                try
                {
                    if (DataAccess.ReturnField("SELECT MAX(SEQUENCE) FROM dbo.SIPINMOV", 0) != "")
                    {
                        sequance =
                            Convert.ToInt16(DataAccess.ReturnField("SELECT MAX(SEQUENCE) FROM dbo.SIPINMOV", 0)) + 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                var commamd = new SqlCommand("", connection.Connect());
                try
                {
                    if (OPEN_HELD_SEQ != 0)
                    {
                        commamd.CommandType = CommandType.Text;
                        commamd.CommandText = "UPDATE SIPINMOH SET STATUS ='20' WHERE [SEQUENCE]=@SEQ";
                        Commands.CreateParameter(commamd, "SEQ", OPEN_HELD_SEQ);
                        commamd.ExecuteNonQuery();
                    }
                    commamd.CommandType = CommandType.StoredProcedure;
                    commamd.CommandText = "SI_INSERT_SIPINMOV_STOCK";
                    var i = 0;
                    foreach (DataGridViewRow row in dataGridViewX1.Rows)
                    {
                       
                            commamd.Parameters.Clear();
                            Commands.CreateParameter(commamd, "SEQUENCE_0", sequance, "REC_TYPE_1", "M", "MOV_DATE_7",
                                                     dtpMov_Date.Value,
                                                     "MOV_REF_3", txtMov_Ref.Text, "MOV_LINE_4",
                                                     string.Format("{0:000}", i + 1), "LOCATION_5",
                                                     row.Cells[1].Value.ToString(), "ITEM_CODE_6",
                                                     row.Cells[3].Value.ToString(),
                                                     "STATUS_8", "80", "IR_STAT_9", "T", "LINE_REF_12", "",
                                                     "QUANTITY_13",
                                                     Convert.ToDecimal(row.Cells[5].Value),
                                                     "COST_14", Convert.ToDecimal(row.Cells[6].Value), "TOTAL_15",
                                                     Convert.ToDecimal(row.Cells[7].Value),
                                                     "MOV_UNITS_16", row.Cells[8].Value.ToString(), "MOV_TYPE_17",
                                                     "TRAN",
                                                     "ALLOC_REF_20", "",
                                                     "ORIG_LINE_NO_33", "", "PO_VALUE_34", 0, "ID_ENTERED_35",
                                                     UserLogOn.Code,
                                                     "ID_ALLOC_36", "", "LOC_TRAN_48", row.Cells[2].Value.ToString());
                            commamd.ExecuteNonQuery();
                            controls.ClearControl(txtMov_Ref, txtPrd, lblTotalQuantity, lblInvoiceValue);
                            controls.EnabledControlTrue(txtMov_Ref, txtPrd, dtpMov_Date);
                            dataGridViewX1.Rows.RemoveAt(i);
                            //                        StartMovement();
                          
                        
                        i += 1;
                    }
                    StartMovement();
                    //                commamd.Transaction.Commit();
                    Cursor = Cursors.Default;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Cursor = Cursors.Default;
                    commamd.Transaction.Rollback();
                    return false;
                }
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.MovementEntry, "V", subMenuItems.PostBatch, true) ==
               false)
                return;
            if (dataGridViewX1.Rows.Count > 0 )
            {
                if (Condition.EmptyControl(txtMov_Ref, txtPrd))
                    return;
                if (MessageBox.Show("Are you sure you want to post the movement to current period: " + txtPrd.Text + " ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        listBox1.Visible = false;
                        label13.Visible = false;
                        listBox1.Items.Clear();
                       
                        foreach (DataGridViewRow row in dataGridViewX1.Rows)
                        {
                            var ongrid = Convert.ToDecimal(row.Cells[5].Value.ToString());
                            PHYSICAL = movement.GetItem("P", row.Cells[1].Value.ToString(),
                                                        row.Cells[3].Value.ToString());
                            //,"T");
                            OnHold = movement.GetItem("O", row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString());
                            //,"");
                            var qtyFree = PHYSICAL - OnHold - ongrid;
                            if (qtyFree < 0)
                            {
                                listBox1.Items.Add(row.Index + 1);
                            }
                           
                        }

                        if (listBox1.Items.Count > 0)
                        {
                            listBox1.Visible = true;
                            label13.Visible = true;
                            return;
                        }
                        if (PostBatchMovement() == false)
                            return;
                        MessageBox.Show("Movement have been posted successfully.", "Successfull", MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
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
                MessageBox.Show("There are no items for posting!", "No Items", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void SIMOVEMENTLINE_FRM_Activated(object sender, EventArgs e)
        {
           
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMov_Ref_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(txtMov_Ref))
                {
                    MessageBox.Show("Please Input data", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                toolStripButton2.Select();
                button2.Enabled = true;
                txtMov_Ref.Enabled = false;
                button2.Focus();   
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripButton2_Click(null, null);
            txtItem_Code.Focus();
            toolStripButton2.Checked = false;
        }

        private void txtLoc_Code1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(txtLoc_Code1))
                {
                    MessageBox.Show("Please Input data", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var dt = dataManager.GetData(
                                "SELECT LOC_CODE [Location Code], LOC_NAME [Location Name] FROM dbo.SIPLOCA", "LOC_CODE",
                                "LOC_CODE", txtLoc_Code1.Text, "LOC_STAT", "A");
                if (dt.Rows.Count > 0)
                {
                    txtLoc_Code1.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("Value" + txtLoc_Code1.Text + "Not Found", "Not Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtLoc_Code1.SelectionStart = 0;
                    txtLoc_Code1.SelectionLength = txtLoc_Code1.Text.Length;
                    txtLoc_Code1.Focus();
                    return;
                }
                PHYSICAL = movement.GetItem("P", txtLoc_Code1.Text, txtItem_Code.Text);
                OnHold = movement.GetItem("O", txtLoc_Code1.Text, txtItem_Code.Text);
                var d = SIDataGridView.Sum(dataGridViewX1, 5, txtLoc_Code1.Text, "1", txtItem_Code.Text, "3");
                d = d + OnHold;
                txtPhysical.Text = PHYSICAL.ToString();
                txtOnHold.Text = d.ToString();
                txtFree.Text = Convert.ToString(PHYSICAL - d);

                txtLoc_Code1.Enabled = false;
                btnLoc_Code1.Enabled = false;
                txtLoc_Code2.Enabled = true;
                btnLoc_Code2.Enabled = true;
                txtLoc_Code2.Focus();
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnLoc_Code1_Click(null,null);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtItem_Code.Enabled = true;
                btnItem_Code.Enabled = true;
                txtLoc_Code1.Enabled = false;
                btnLoc_Code1.Enabled = false;
                txtItem_Code.BackColor = Color.White;
                txtItem_Code.Focus();
             }
        }

        private void txtLoc_Code2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                if (Condition.EmptyControl(txtLoc_Code2))
                {
                    MessageBox.Show("Please Input data", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var dt = dataManager.GetData(
                             "SELECT LOC_CODE [Location Code], LOC_NAME [Location Name] FROM dbo.SIPLOCA", "LOC_CODE",
                             "LOC_CODE", txtLoc_Code2.Text, "LOC_STAT", "A");
                if (dt.Rows.Count > 0)
                {
                   
                    txtLoc_Code2.Text = dt.Rows[0][0].ToString();
                    if (txtLoc_Code1.Text == txtLoc_Code2.Text)
                    {
                        MessageBox.Show("Transfer location cannot the same as location!");
                        txtLoc_Code2.SelectionStart = 0;
                        txtLoc_Code2.SelectionLength = txtLoc_Code2.Text.Length;
                        txtLoc_Code2.Focus();
                        txtQTY.Enabled = false;
                        txtLoc_Code2.SelectAll();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Value" + txtLoc_Code1.Text + "Not Found", "Not Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtLoc_Code2.SelectionStart = 0;
                    txtLoc_Code2.SelectionLength = txtLoc_Code2.Text.Length;
                    txtLoc_Code2.Focus();
                    return;
                }
                txtLoc_Code2.Enabled = false;
                txtLoc_Code2.Enabled = false;
                txtQTY.Enabled = true;
                SelectNextControl(txtLoc_Code2, true, true, true, true);
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnLoc_Code2_Click(null,null);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtLoc_Code1.Enabled = true;
                btnLoc_Code1.Enabled = true;
                txtLoc_Code2.Enabled = false;
                btnLoc_Code2.Enabled = false;
                txtLoc_Code1.Focus();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && Keys.KeyCode == Keys.B)
            {
                txtQTY.Enabled = true;
                SelectNextControl(button1, false, true, true, true);
            }
        }
    }
}
