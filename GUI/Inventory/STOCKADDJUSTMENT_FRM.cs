using System;
using System.Collections;
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
    public partial class STOCKADDJUSTMENT_FRM : Form
    {
        public STOCKADDJUSTMENT_FRM()
        {
            InitializeComponent();
        }

        readonly DataManager dataManager = new DataManager();
        private Decimal PHYSICAL;
        private Decimal OnHold;
        readonly MovementEntry movement = new MovementEntry();
        DataTable dt = new DataTable();
        private string NoteType = "";
        readonly Controls controls = new Controls();
        private int OPEN_HELD_SEQ = 0;
        private bool MAKE_CHANGE = false;
        private bool IS_EDIT = false;
        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        readonly Connection.Connection connection = new Connection.Connection();
        private string Mov_type = "";
        string[] type = new[]{"ADJ-","ADJ+","OB","LOSS","EPXR"};


        private void STOCKADDJUSTMENT_FRM_Load(object sender, EventArgs e)
        {
//            controls.AddEventHandler(txtMov_Ref,txtPrd,txtPhysical,txtFree,txtQTY,txtLoc_Code1,txtItem_Code);
            dt = dataManager.Create("Tran Type", "Description", "Note");
            dataManager.Save(dt, "ADJ-", "Reduce Stock","R");
            dataManager.Save(dt, "ADJ+", "Addjustment Stock","I");
            dataManager.Save(dt, "OB", "Opening Balance","O");
            dataManager.Save(dt, "LOSS", "Loss Stock","R");
            dataManager.Save(dt, "EPXR", "Expired Stock","R");
            controls.Only_Number_On_Control(txtCost);

        }

        private void btntranType_Click(object sender, EventArgs e)
        {
            try
            {
                var droplist_FRM = new DROPLIST_FRM();
                droplist_FRM.DataGridView.DataSource = dt;
                droplist_FRM.Top = (this.Top + txtItem_Code.Top + txtItem_Code.Height + 43);
                droplist_FRM.Left = (this.Left + txtItem_Code.Left + 3);
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width * 27 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width * 50 / 100;
                droplist_FRM.DataGridView.Columns[2].Visible = false;

                if (droplist_FRM.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    txtTranType.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    NoteType = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    controls.Enabled_Control_False(txtTranType,btntranType);
                    controls.EnabledControlTrue(txtMov_Ref,txtPrd);
                    txtMov_Ref.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    Top = (this.Top + txtItem_Code.Top + txtItem_Code.Height + 99),
                    Left = (this.Left + txtItem_Code.Left + 3)
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
                    txtCost.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[3].Value.ToString();
                    txtCost.Text = string.Format("{0:0,0.00}", txtCost.Text);
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
                            txtCost.Text = string.Format("{0:0,0.00}", dt.Rows[0][3]);
                            txtItem_Desc.Enabled = false;
                            txtItem_Code.BackColor = Color.WhiteSmoke;
                            btnItem_Code.Enabled = false;
                            txtLoc_Code1.Enabled = true;
                            txtItem_Code.Enabled = false;
                            btnItem_Code.Enabled = false;
                            txtLoc_Code1.BackColor = Color.White;
                            btnLoc_Code1.Enabled = true;
                            txtLoc_Code1.Focus();
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
                    Top = (this.Top + txtLoc_Code1.Top + txtLoc_Code1.Height + 102),
                    Left = (this.Left + txtLoc_Code1.Left + 5)
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
                    var d = SIDataGridView.Sum(dataGridViewX1, 5, txtLoc_Code1.Text, "1", txtItem_Code.Text, "3");
                    d = d + OnHold;
                    txtPhysical.Text = PHYSICAL.ToString();
                    txtOnHold.Text = d.ToString();
                    txtFree.Text = Convert.ToString(PHYSICAL - d);
                    txtLoc_Code1.Enabled = false;
                    btnLoc_Code1.Enabled = false;
                    txtQTY.Enabled = true;
                    SelectNextControl(txtLoc_Code1, true, true, true, true);
                }
                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
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
            controls.Enabled_Control_False(txtMov_Ref, txtPrd,dtpMov_Date,txtItem_Code,btnItem_Code,txtQTY,txtLoc_Code1,txtCost,btnLoc_Code1);
            controls.EnabledControlTrue(txtTranType,btntranType);
            dataGridViewX1.Rows.Clear();
            txtFree.Text = "0.00";
            txtOnHold.Text = "0.00";
            lblTotalQuantity.Text = "0.00";
            lblInvoiceValue.Text = "0.00";
            txtQTY.Text = "0";
            controls.ClearControl(txtItem_Code, txtPrd,txtItem_Desc, txtUnitofStock);
            StartMovement();
            txtTranType.Focus();
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
                controls.ClearControl(txtItem_Code, txtItem_Desc, txtLoc_Code1, txtLineNo, txtUnitofStock,
                                      txtQTY, txtPhysical, txtCost, txtTotalAmount);
                txtTotalAmount.Text = "0.00";
                txtFree.Text = "0";
                txtPhysical.Text = "0";
                txtQTY.Text = "0";
                txtCost.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMov_Ref_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                toolStripButton2.Select();
                button2.Enabled = true;
                button2.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtTranType.Enabled = true;
                btntranType.Enabled = true;
                txtTranType.Focus();
                txtMov_Ref.Enabled = false;

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.MovementEntry, "V", subMenuItems.NewLine, true) ==
                  false)
                return;
            if (txtTranType.Text == "")
            {
                txtTranType.ForeColor = Color.Red;
                MessageBox.Show("Please input into Tran Type", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTranType.Focus();
                return;
            }
            if (txtMov_Ref.Text == "")
            {
                txtMov_Ref.BackColor = Color.Red;
                MessageBox.Show("Please input into Move_Ref", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMov_Ref.Focus();
                return;
            }
           if (dataGridViewX1.Rows.Count > 0)
            {
                if (MessageBox.Show("Do you want to clear change this transaction?", "Clear Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            txtPrd.Text = DateTime.Now.Year + DateTime.Now.Month.ToString();
            controls.EnabledControlTrue(txtItem_Code, btnItem_Code);
            controls.Enabled_Control_False(txtLoc_Code1,btnLoc_Code1);
            txtMov_Ref.Enabled = false;
            controls.ClearControl(txtItem_Code, txtItem_Desc, txtLoc_Code1, txtLineNo, txtUnitofStock,
                                      txtQTY, txtPhysical, txtCost, txtTotalAmount);
            txtFree.Text = "";
            txtOnHold.Text = "";
            dtpMov_Date.Enabled = false;
            txtPrd.Enabled = false;
            txtCost.Enabled = false;
            txtQTY.Enabled = false;
            txtLineNo.Text = string.Format("{0:0000}", dataGridViewX1.Rows.Count + 1);
            IS_EDIT = false;
            txtItem_Code.Focus();
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
                var textBox = new TextBox();
                var textBox1 = new TextBox();
                SIDataGridView.BindingDataGird_OnSelect_Into_Textbox(dataGridViewX1, txtLineNo, txtLoc_Code1,txtItem_Code, txtItem_Desc, txtQTY, txtCost,
                                                                     txtTotalAmount,txtUnitofStock,textBox,textBox1);

                if (Mov_type != "" )
                {
                    txtTranType.Text = Mov_type;
                }
                txtUnitofStock.Text = dataGridViewX1.SelectedRows[0].Cells[7].Value.ToString();
//               ======= Note On Here ON HOLD Sale ===========
                PHYSICAL = movement.GetItem("P", txtLoc_Code1.Text, txtItem_Code.Text); //"T"
                dtpMov_Date.Value = DateTime.Now;
                OnHold = movement.GetItem("O", txtLoc_Code1.Text, txtItem_Code.Text);
                var d = SIDataGridView.Sum(dataGridViewX1, 4, txtLoc_Code1.Text, "1", txtItem_Code.Text, "2");
                d = d + OnHold;
                txtPhysical.Text = PHYSICAL.ToString();
                txtOnHold.Text = d.ToString();
                txtFree.Text = Convert.ToString(PHYSICAL - d);
                btnItem_Code.Enabled = true;
                txtItem_Code.Enabled = true;
                controls.Enabled_Control_False(txtLoc_Code1, txtTranType,btntranType,btnLoc_Code1, txtQTY, txtCost);
                IS_EDIT = true;
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtCost.Text == "")
                {
                    txtCost.Focus();

                }
//                if (Condition.Check_Decimal(txtCost))
//                {
                    txtTotalAmount.Text = Convert.ToString(Convert.ToDecimal(txtQTY.Text)*Convert.ToDecimal(txtCost.Text));
//                }
                toolStripButton5.Select();
                button1.Focus();    
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtQTY.Enabled = true;
                txtQTY.Focus();
                txtCost.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Condition.EmptyControl(txtItem_Code, txtLoc_Code1, txtTranType) && txtQTY.Text == "0")
                {
                    MessageBox.Show("Plaese Input data to add new line", "Empty", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                if (IS_EDIT == false)
                {
                    #region Add New Line

                    if (txtTotalAmount.Text == "")
                    {
                        txtTotalAmount.Text = "0";
                    }
                    if (txtCost.Text == "")
                    {
                        txtCost.Text = "0.00";
                    }
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

                    dataGridViewX1.Rows.Add(string.Format("{0:0000}", lineNo + 1), txtLoc_Code1.Text, txtItem_Code.Text,
                                            txtItem_Desc.Text, txtQTY.Text, txtCost.Text, txtTotalAmount.Text,
                                            txtUnitofStock.Text, txtPrd.Text,NoteType);
                    lblInvoiceValue.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 6));
                    lblTotalQuantity.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 4));
                    txtFree.Text = Convert.ToString(Convert.ToDecimal(txtFree.Text) - Convert.ToDecimal(txtQTY.Text));

                    #endregion
                }
                else
                {
                    SIDataGridView.BindingData_ToGrid_OnSelected(dataGridViewX1, txtLineNo.Text, txtLoc_Code1.Text,
                                                                 txtItem_Code.Text, txtItem_Desc.Text, txtQTY.Text,
                                                                 txtCost.Text, txtTotalAmount.Text,
                                                                 txtUnitofStock.Text,txtTranType.Text);
                }
                txtMov_Ref.Enabled = false;
                txtPrd.Enabled = false;
                dtpMov_Date.Enabled = false;
                txtTranType.Enabled = false;
                btntranType.Enabled = false;
                txtItem_Code.Enabled = true;
                btnItem_Code.Enabled = true;
                StartMovement();
                txtLineNo.Text = string.Format("{0:0000}", dataGridViewX1.Rows.Count + 1);
                txtFree.Text = "";
                txtOnHold.Text = "";
                lblInvoiceValue.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 6));
                lblTotalQuantity.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 4));
                txtQTY.Enabled = false;
                txtCost.Enabled = false;
                button2.Enabled = false;
                SelectNextControl(button1, true, true, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }

        private void txtQTY_KeyDown(object sender, KeyEventArgs e)
        
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtQTY.Text == "" || txtQTY.Text == "0")
                {
                    txtQTY.Focus();
                    return;
                }
                txtCost.Enabled = true;
                txtCost.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtQTY.Enabled = false;
                txtLoc_Code1.Enabled = true;
                btnLoc_Code1.Enabled = true;
                txtLoc_Code1.Focus();
                txtLoc_Code1.BackColor = Color.White;
                     
            }
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
                var cmd = new SqlCommand("SELECT DISTINCT MOV_PRD FROM SIPINMOH WHERE STATUS = '10' AND IR_STAT != 'T'",connection.Connect());
                var Adapter = new SqlDataAdapter(cmd);
                var dtTable = new DataTable();
                Adapter.Fill(dtTable);

                //                siheldmovement_FRM.TreeView1.Nodes[0].Text = CURRENT_PRD;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dtTable.Rows)
                    {
                        siheldmovement_FRM.TreeView1.Nodes[0].Nodes.Add(row[0].ToString(), row[0].ToString(), 1);
                    }
                }
                siheldmovement_FRM.TreeView1.Tag = "StockAdj";
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
//                    txtPrd.Text = siheldmovement_FRM.TreeView1.SelectedNode.Nodes[0].Text;
                    txtTranType.Text =
                        siheldmovement_FRM.dataGridViewX1.Rows[siheldmovement_FRM.SELECT_INDEX].Cells[2].Value.ToString();
                    controls.Enabled_Control_False(txtItem_Code, btnItem_Code, txtLoc_Code1, btnLoc_Code1, txtOnHold, txtFree, txtQTY);
                    OPEN_HELD_SEQ =
                        Convert.ToInt16(siheldmovement_FRM.dataGridViewX1.Rows[siheldmovement_FRM.SELECT_INDEX].Cells[0].Value.ToString());
                    cmd =
                        new SqlCommand(
                            "SELECT  H.MOV_LINE, H.LOCATION,H.ITEM_CODE, dbo.SIPITEMS.ITEM_DESC, H.QUANTITY, H.COST, H.TOTAL, H.MOV_UNITS,H.IR_STAT,H.MOV_PRD,H.MOV_TYPE FROM  SIPINMOH H INNER JOIN dbo.SIPITEMS ON H.ITEM_CODE = dbo.SIPITEMS.ITEM_CODE WHERE SEQUENCE = @SEQUENCE AND STATUS =@STATUS ",
                            connection.Connect());
                    cmd.Parameters.AddWithValue("@SEQUENCE", OPEN_HELD_SEQ);
                    cmd.Parameters.AddWithValue("@STATUS", "10");
                    var dtMov = new DataTable();
                    var dataAdapter = new SqlDataAdapter(cmd).Fill(dtMov);
                    dataGridViewX1.Rows.Clear();
                    foreach (DataRow row in dtMov.Rows)
                    {
                        dataGridViewX1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8],txtTranType.Text);
                        txtPrd.Text = row[9].ToString();
                    }
                    lblInvoiceValue.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 5));
                    lblTotalQuantity.Text = Convert.ToString(SIDataGridView.Sum(dataGridViewX1, 4));
                    txtTranType.Enabled = false;
                    txtMov_Ref.Enabled = false;
                    txtPrd.Enabled = false;
                    dtpMov_Date.Enabled = false;
                    txtCost.Enabled = false;
                    txtOnHold.Text = "0.00";
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

        private void toolstripRemoveLine_Click(object sender, EventArgs e)
        {
            var lineNo = 0;
            if (security.CheckPermission(UserLogOn.Code, menuItems.StockAddjustment, "V", subMenuItems.DeleteLine, true) ==
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
                        row.Cells[0].Value = string.Format("{0:0000}", lineNo);
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no selected item to remove.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.StockAddjustment, "V", subMenuItems.PostBatch, true) ==
               false)
                return;
            if (dataGridViewX1.Rows.Count > 0)
            {
                if (Condition.EmptyControl(txtMov_Ref, txtPrd))
                    return;
                if (MessageBox.Show("Are you sure you want to post the movement to current period: " + txtPrd.Text + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if (PostBatch_Movement() == false)
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
                MessageBox.Show("There are no items for postring!", "No Items", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private bool PostBatch_Movement()
        {
            //            var Computer = new Microsoft.VisualBasic.Devices.Computer();
            //            Computer.Audio.PlaySystemSound();
            var sequance = 1;
            Cursor = Cursors.WaitCursor;
            try
            {
                if (DataAccess.ReturnField("SELECT MAX(SEQUENCE) FROM dbo.SIPINMOV", 0) != "")
                {
                    sequance = Convert.ToInt16(DataAccess.ReturnField("SELECT MAX(SEQUENCE) FROM dbo.SIPINMOV", 0)) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            var commamd = new SqlCommand("", connection.Connect());
            //            commamd.Transaction = connection.Connect().BeginTransaction();
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
                                             string.Format("{0:0000}", i + 1), "LOCATION_5",
                                             row.Cells[1].Value.ToString(), "ITEM_CODE_6", row.Cells[2].Value.ToString(),
                                             "STATUS_8", "80", "IR_STAT_9", row.Cells[9].Value.ToString(), "LINE_REF_12",
                                             "", "QUANTITY_13", Convert.ToDecimal(row.Cells[4].Value),
                                             "COST_14", Convert.ToDecimal(row.Cells[5].Value), "TOTAL_15",
                                             Convert.ToDecimal(row.Cells[6].Value),
                                             "MOV_UNITS_16", row.Cells[7].Value.ToString(), "MOV_TYPE_17",
                                             txtTranType.Text,
                                             "ALLOC_REF_20", "",
                                             "ORIG_LINE_NO_33", "", "PO_VALUE_34", 0, "ID_ENTERED_35", UserLogOn.Code,
                                             "ID_ALLOC_36", "", "LOC_TRAN_48", "");
                    commamd.ExecuteNonQuery();
                    controls.ClearControl(txtMov_Ref, txtPrd, lblTotalQuantity, lblInvoiceValue);
//                    controls.EnabledControlTrue(txtMov_Ref, txtPrd, dtpMov_Date);
                    controls.EnabledControlTrue(txtTranType,btntranType);
                    dataGridViewX1.Rows.Clear();
                    StartMovement();
                    i += 1;
                }
                StartMovement();
                txtTranType.Text = "";
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

        private void HeldToolStripButton2_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.StockAddjustment, "V", subMenuItems.HeldBatch, true) ==
                false)
                return;
            if (dataGridViewX1.Rows.Count > 0)
            {
                if (Condition.EmptyControl(txtMov_Ref))
                    return;

                if (
                    MessageBox.Show("Are you sure you want to held the movement ?", "Held Batch",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    System.Windows.Forms.DialogResult.Yes)
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
            }
            else
            {
                MessageBox.Show("There are no items for posting!");
            }
            
        }

        private bool HeldBatch()
        {
            int sequance = 1;
            Cursor = Cursors.WaitCursor;

            var command = new SqlCommand("", connection.Connect());
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
                                             txtPrd.Text, "MOV_DATE_4", dtpMov_Date.Value, "MOV_REF_5", txtMov_Ref.Text,
                                             "MOV_LINE_6", string.Format("{0:0000}", i),
                                             "LOCATION_7", row.Cells[1].Value.ToString(), "LOC_TRAN_8", "",
                                             "ITEM_CODE_9", row.Cells[2].Value.ToString(), "STATUS_10", "10",
                                             "IR_STAT_11", NoteType,
                                             "LINE_REF_12", "", "QUANTITY_13", Convert.ToInt64(row.Cells[4].Value),
                                             "COST_14", Convert.ToDecimal(row.Cells[5].Value.ToString()),
                                             "TOTAL_15", Convert.ToDecimal(row.Cells[5].Value.ToString()),
                                             "MOV_UNITS_16", row.Cells[7].Value.ToString(),
                                             "MOV_TYPE_17", txtTranType.Text, "ID_ENTERED_18", UserLogOn.Code,
                                             "DATE_ENTERED", DateTime.Now, "ID_UPDATE_20", UserLogOn.Code, "DATE_UPDT",
                                             DateTime.Today.ToString("MM/dd/yyyy"));
                    command.ExecuteNonQuery();
                    i++;
                }
                StartMovement();
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

        private void txtLoc_Code1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Condition.EmptyControl(txtLoc_Code1))
                {
                    MessageBox.Show("Please input data", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var dt =
                            dataManager.GetData(
                                "SELECT LOC_CODE [Location Code], LOC_NAME [Location Name] FROM dbo.SIPLOCA", "LOC_CODE",
                                "LOC_CODE", txtLoc_Code1.Text, "LOC_STAT", "A");
                if (dt.Rows.Count > 0)
                {
                    txtLoc_Code1.Text = dt.Rows[0][0].ToString();
                    btnLoc_Code1.Enabled = false;
                    txtLoc_Code1.Enabled = false;
                    PHYSICAL = movement.GetItem("P", txtLoc_Code1.Text, txtItem_Code.Text);
                    OnHold = movement.GetItem("O", txtLoc_Code1.Text, txtItem_Code.Text);
                    var d = SIDataGridView.Sum(dataGridViewX1, 5, txtLoc_Code1.Text, "1", txtItem_Code.Text, "3");
                    d = d + OnHold;
                    txtPhysical.Text = PHYSICAL.ToString();
                    txtOnHold.Text = d.ToString();
                    txtFree.Text = Convert.ToString(PHYSICAL - d);
                    txtLoc_Code1.Enabled = false;
                    btnLoc_Code1.Enabled = false;
                    txtQTY.Enabled = true;
                    SelectNextControl(txtLoc_Code1, true, true, true, true);
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
               btnLoc_Code1_Click(null,null);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtItem_Code.Enabled = true;
                btnItem_Code.Enabled = true;
                txtLoc_Code1.Enabled = false;
                btnLoc_Code1.Enabled = false;
                txtItem_Code.Focus();
                txtLoc_Code1.BackColor = Color.White;
            }
        }

        private void toolStripButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripButton2_Click(sender,e);
        }

        private void txtTranType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var qry = type.Where(s => s.StartsWith(txtTranType.Text.ToUpper()));

                if (qry.Count() == 0)
                {
                    return;
                }
                foreach (string d in qry)
                {
                    txtTranType.Text = d;
                }
                txtMov_Ref.Enabled = true;
                txtMov_Ref.Focus();


            }
            else if (e.KeyCode == Keys.F6)
            {
                btntranType_Click(null,null);
            }
        }
    }
}
