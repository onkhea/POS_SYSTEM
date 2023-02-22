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
using POS.Reports;
using POS.Transaction;
using POS.Transaction.Purchase;
using POS.Transaction.Sale;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.SaleProcessing
{
    public partial class CREDITNOTE_FRM : Form
    {
        public CREDITNOTE_FRM()
        {
            InitializeComponent();
        }
        
// ReSharper disable FieldCanBeMadeReadOnly
        Controls controls = new Controls();
// ReSharper restore FieldCanBeMadeReadOnly
        readonly DropDownList dropDownList = new DropDownList();
// ReSharper disable FieldCanBeMadeReadOnly
        DataManager dataManager = new DataManager();
// ReSharper restore FieldCanBeMadeReadOnly
        readonly Connection.Connection connection = new Connection.Connection();
        private SISecurity security = new SISecurity();
        SIMenuItems menuItems = new SIMenuItems();
        SISubMenuItems subMenuItems = new SISubMenuItems();

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var droplist_Frm = new DROPLIST_FRM();
            var dd = Convert.ToInt16(groupBox1.Top) + Convert.ToInt16(txtCustomer.Top) + Convert.ToInt16(btnCustomer.Top) + 28;
            dropDownList.BindingData(
                "SELECT ADD_CODE, ADD_NAME, ADD_LINE_1, ADD_LINE_2,ADD_LINE_3, ADD_LINE_4,ADD_LINE_5 FROM SIPADDR WHERE ADD_TYPE = 0 AND ADD_CODE LIKE '%" + txtCustomer.Text +
                "' AND ADD_STAT = 'A'", txtCustomer, this, droplist_Frm, btnCustomer, Convert.ToInt16(dd), 2, 3, 4, 5, 6);
            if (droplist_Frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                txtCustomer.Text = droplist_Frm.DataGridView.Rows[droplist_Frm.SelectIndex].Cells[0].Value.ToString();
                txtName.Text = droplist_Frm.DataGridView.Rows[droplist_Frm.SelectIndex].Cells[1].Value.ToString();
                txtAddress1.Text = droplist_Frm.DataGridView.Rows[droplist_Frm.SelectIndex].Cells[2].Value.ToString();
                txtAddress2.Text = droplist_Frm.DataGridView.Rows[droplist_Frm.SelectIndex].Cells[3].Value.ToString();
                txtAddress3.Text = droplist_Frm.DataGridView.Rows[droplist_Frm.SelectIndex].Cells[4].Value.ToString();
                txtAddress4.Text = droplist_Frm.DataGridView.Rows[droplist_Frm.SelectIndex].Cells[5].Value.ToString();
                txtAddress5.Text = droplist_Frm.DataGridView.Rows[droplist_Frm.SelectIndex].Cells[6].Value.ToString();
                txtCustomer.Enabled = false;
                btnCustomer.Enabled = false;
                txtDeliveries.Enabled = true;
                btnDeliveries.Enabled = true;
            }

        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            var droplist_FRM = new DROPLIST_FRM();
            var i = Convert.ToInt16(groupBox1.Top) + 49;//+ Convert.ToInt16(txtDeliveries.Top);// +Convert.ToInt16(btnDeliveries.Top) + 25;
            dropDownList.BindingData(
                "SELECT DEL_CODE, DEL_NAME,DEL_ADD_1,DEL_ADD_2,DEL_ADD_3, DEL_ADD_4,DEL_ADD_5 FROM dbo.SIPDADD WHERE ADD_CODE = '" +
                txtCustomer.Text + "' AND DEL_TYPE = 0", txtDeliveries, this, droplist_FRM, btnDeliveries, Convert.ToInt16(i), 2, 3, 4, 5, 6);
            if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDeliveries.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                txtDelName.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[1].Value.ToString();
                txtDelAddress1.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                txtDelAddress2.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[3].Value.ToString();
                txtDelAddress3.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[4].Value.ToString();
                txtDelAddress4.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[5].Value.ToString();
                txtDelAddress5.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[6].Value.ToString();
                txtDeliveries.Enabled = false;
                btnDeliveries.Enabled = false;
            }
        }

        private void StartToolStrip_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.CreditNote, "V", subMenuItems.Start, true) ==
        false)
                return;
            controls.ClearControl(txtDeliveries, txtDelName, txtDelAddress1, txtDelAddress2, txtDelAddress3,
                                  txtDelAddress4, txtDelAddress5, txtCustomer, txtName, txtAddress1, txtAddress2,
                                  txtAddress3, txtAddress4, txtAddress5,txtTranRef,txtComment);
            txtInvoiceValue.Text = "0.00";
            txtInvoiceQty.Text = "0";
            txtItemDisc.Text = "0.00";
            txtCreditNote.Text = "0.00";
            txtCreditQty.Text = "0";
        }

        private void splitLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.CreditNote, "V", subMenuItems.SplitLine, true) ==
        false)
                return;
            if (dataGridViewX1.Rows.Count == 0)
            {
                return;
            }
            var splitline_FRM = new SPLITLINE_FRM();
            splitline_FRM.txtOldQty.Text = dataGridViewX1.SelectedRows[0].Cells[6].Value.ToString();
            splitline_FRM.txtOldQty.Enabled = false;
            if (splitline_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    Double Split_AMT = Double.Parse(splitline_FRM.txtQty.Text);
                    //                            Double Rate = Double.Parse(string.Format("{0:0.00000}", Split_AMT / Convert.ToDouble(sisosplit_FRM.AMT)));

                    var fieldAndVal = new string[] { "ITEM_CODE", dataGridViewX1.SelectedRows[0].Cells[3].Value.ToString() };

                    string Unit_Stock = DataAccess.ReturnField("SELECT UNIT_STOCK FROM SIPITEMS", "UNIT_STOCK",
                                                               fieldAndVal, 0);
                    DataTable tbl = dataManager.GetData("SELECT OPERATOR, FACTOR FROM SIUNITCONV", "FACTOR",
                                                        "CONV_FROM",
                                                        dataGridViewX1.SelectedRows[0].Cells[15].Value.ToString(),
                                                        "CONV_TO", Unit_Stock);

                    decimal stock_NewQty = 0;
                    Decimal stock_OldQty = Decimal.Parse(splitline_FRM.txtQty.Text);

                    if (tbl.Rows.Count > 0)
                    {
                        switch (tbl.Rows[0][0].ToString())
                        {
                            case "*":
                                stock_NewQty = Convert.ToDecimal(stock_OldQty) * Convert.ToDecimal(tbl.Rows[0][1]);
                                break;
                            case "/":
                                stock_NewQty = Convert.ToDecimal(tbl.Rows[0][1]) / Convert.ToDecimal(stock_OldQty);
                                break;
                        }
                    }
                    var disc = Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[13].Value.ToString());

                    var line_Ref = "";
                    var j = 1;

                    //                            ===============
                    var dtSIPPORD = dataManager.GetData("SELECT ORD_LINE FROM dbo.SIPSINVD ", "ORD_LINE",
                                                        "ORD_REF", txtTranRef.Text, "ORD_LINE",
                                                        dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString());
                    foreach (DataRow row in dtSIPPORD.Rows)
                    {
                        if (row[0].ToString().Length == 3)
                        {
                            line_Ref = row[0].ToString() + "01";
                        }
                        else
                        {
                            line_Ref = row[0].ToString().Substring(0, 3) +
                                       string.Format("{0:00}", Convert.ToDecimal(row[0].ToString().Substring(3)) + 1);
                        }
                    }

                    var subtotal = Convert.ToDecimal(splitline_FRM.txtQty.Text) *
                                   Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[8].Value);

                    var discUsd = subtotal * disc / 100;
                    var total = subtotal - discUsd;
                    //
                    var g = dataGridViewX1.SelectedRows[0].Index + 1;
                    dataGridViewX1.Rows.Insert(g, true, line_Ref, dataGridViewX1.SelectedRows[0].Cells[2].Value,
                                               dataGridViewX1.SelectedRows[0].Cells[3].Value,
                                               dataGridViewX1.SelectedRows[0].Cells[4].Value,
                                               dataGridViewX1.SelectedRows[0].Cells[5].Value,
                                               Convert.ToInt16(stock_OldQty), Convert.ToDecimal(stock_NewQty),
                                               dataGridViewX1.SelectedRows[0].Cells[8].Value,
                                               string.Format("{0:0,0.00}", subtotal), disc,
                                               string.Format("{0:0,0.00}", total),
                                               dataGridViewX1.SelectedRows[0].Cells[12].Value,
                                               dataGridViewX1.SelectedRows[0].Cells[13].Value,
                                               dataGridViewX1.SelectedRows[0].Cells[14].Value,
                                               dataGridViewX1.SelectedRows[0].Cells[15].Value,
                                               dataGridViewX1.SelectedRows[0].Cells[16].Value,
                                               dataGridViewX1.SelectedRows[0].Cells[17].Value);
                    var command = new SqlCommand("", connection.Connect());

                    var old_Qty = Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[6].Value) - stock_OldQty;
                    var old_Stock = Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[7].Value) - stock_NewQty;
                    var sub_TotalOld = Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[8].Value) * old_Qty;
                    var old_Disc = sub_TotalOld * disc / 100;
                    var total_old = sub_TotalOld - old_Disc;


                    //                ================== update Split line ===============
                    command.CommandText =
                        "UPDATE dbo.SIPSINVD SET INV_QTY = @INV_QTY, INV_STOCK = @INV_STOCK , INV_SUB = @INV_SUB , INV_DISA = @INV_DISA ,INV_TOT = @INV_TOT WHERE ORD_LINE = @ORD_LINE AND ORD_REF = @ORD_REF";
                    Commands.CreateParameter(command, "INV_QTY", old_Qty, "INV_STOCK", old_Stock, "INV_SUB", sub_TotalOld,
                                             "INV_DISA", old_Disc, "INV_TOT", total_old, "ORD_LINE",
                                             dataGridViewX1.SelectedRows[0].Cells[1].Value, "ORD_REF", txtTranRef.Text);
                    var d = command.ExecuteNonQuery();
                    if (d == 0)
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show("There aren't data to update.");
                        return;
                    }

                    //                                      ================== Insert Split line ===========

                    command.CommandText = "SI_INSERT_SIPSINVD";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();

                    var price = Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[8].Value.ToString());
                    var saleQty = Convert.ToDecimal(stock_OldQty);
                    var stockQty = Convert.ToDecimal(stock_NewQty);
                    var amount = Convert.ToDecimal(subtotal);
                    var disc1 = Convert.ToDecimal(disc);
                    var discUSD = Convert.ToDecimal(discUsd);
                    var total1 = Convert.ToDecimal(total_old);
                    var saleType = dataGridViewX1.SelectedRows[0].Cells[12].Value.ToString();
                    var location = dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString();

                    Commands.CreateParameter(command, "ORD_REF_1", txtTranRef.Text,
                                             "ORD_LINE_2", line_Ref,
                                             "LOC_CODE_3", location, "ITEM_CODE_4",
                                             dataGridViewX1.SelectedRows[0].Cells[3].Value, "ITEM_DESC_5",
                                             dataGridViewX1.SelectedRows[0].Cells[4].Value,
                                             "INV_UNIT_6", dataGridViewX1.SelectedRows[0].Cells[5].Value, "INV_QTY_7",
                                             saleQty,
                                             "INV_STOCK_8", stockQty,
                                             "INV_PRICE_9", Convert.ToDecimal(price.ToString()),
                                             "INV_SUB_10", Convert.ToDecimal(amount.ToString()), "INV_DISP_11",
                                             Convert.ToDecimal(disc1.ToString()),
                                             "INV_DISA_12", Convert.ToDecimal(discUSD.ToString()), "INV_TOT_13",
                                             Convert.ToDecimal(total.ToString()), "INV_STAT_14",
                                             saleType,
                                             "INV_COM_15", txtComment.Text, "INV_REF_16",
                                             dataGridViewX1.Rows[0].Cells[17].Value.ToString(), "INV_CRE_17", "D","INV_POS_18","D");
                    command.ExecuteNonQuery();

                    dataGridViewX1.SelectedRows[0].Cells[6].Value = old_Qty;

                    dataGridViewX1.SelectedRows[0].Cells[7].Value = old_Stock;

                    dataGridViewX1.SelectedRows[0].Cells[9].Value = string.Format("{0:0,0.00}", sub_TotalOld);

                    dataGridViewX1.SelectedRows[0].Cells[10].Value = old_Disc;

                    dataGridViewX1.SelectedRows[0].Cells[11].Value = string.Format("{0:0,0.00}", total_old);

                    var i = dataGridViewX1.SelectedRows[0].Index;
                    dataGridViewX1.Rows[dataGridViewX1.SelectedRows[0].Index].Selected = false;
                    dataGridViewX1.Rows[i + 1].Selected = true;

                    Cursor = Cursors.Default;

                    dataGridViewX1_CellContentClick(null, null);
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void saleInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saleOrder = new SaleOrder();
            var view_CREDIT_NOTE_FRM = new VIEW_CREDIT_NOTE_FRM();
            var isChange = true;
            if (security.CheckPermission(UserLogOn.Code, menuItems.CreditNote, "V", subMenuItems.SalesInvoice, true) ==
            false)
                return;
            if (dataGridViewX1.Rows.Count > 0)
            {

                if (
                    MessageBox.Show("Do you want to change data?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.No)
                {
                    isChange = false;
                    return;
                }
               
            }
            if (isChange)
            {
                foreach (var time in saleOrder.CreditNoteDateTime())
                {
                    view_CREDIT_NOTE_FRM.treeView1.Nodes[1].Nodes.Add(time, time, 1, 1).Tag = "CDDate";
                }
                foreach (var time in saleOrder.InvoiceDateTime())
                {
                    view_CREDIT_NOTE_FRM.treeView1.Nodes[0].Nodes.Add(time, time, 1, 1).Tag = "OrderDate";
                }
                
                if (view_CREDIT_NOTE_FRM.ShowDialog() == DialogResult.OK)
                {
                    txtTranRef.Text =
                        view_CREDIT_NOTE_FRM.dataGridViewX1.Rows[view_CREDIT_NOTE_FRM.selectIndex].Cells[1].Value.
                            ToString();
                    txtItemDisc.Text = string.Format("{0:0,0.00}",
                                                     view_CREDIT_NOTE_FRM.dataGridViewX1.Rows[
                                                         view_CREDIT_NOTE_FRM.selectIndex].Cells[10].Value);
                    txtInvoiceValue.Text = string.Format("{0:0,0.00}",
                                                         view_CREDIT_NOTE_FRM.dataGridViewX1.Rows[
                                                             view_CREDIT_NOTE_FRM.selectIndex].Cells[6].Value);
                    //           ============  binding customer  =============
                    txtCustomer.Text =
                        view_CREDIT_NOTE_FRM.dataGridViewX1.Rows[view_CREDIT_NOTE_FRM.selectIndex].Cells[4].Value.
                            ToString();
                    txtName.Text =
                        view_CREDIT_NOTE_FRM.dataGridViewX1.Rows[view_CREDIT_NOTE_FRM.selectIndex].Cells[5].Value.
                            ToString();
                    var dtCustomer =
                        dataManager.GetData(
                            "SELECT ADD_CODE, ADD_NAME, ADD_LINE_1, ADD_LINE_2,ADD_LINE_3, ADD_LINE_4,ADD_LINE_5 FROM SIPADDR",
                            "ADD_CODE", "ADD_CODE", txtCustomer.Text);
                    foreach (DataRow row in dtCustomer.Rows)
                    {
                        txtAddress1.Text = row[2].ToString();
                        txtAddress2.Text = row[3].ToString();
                        txtAddress3.Text = row[4].ToString();
                        txtAddress4.Text = row[5].ToString();
                        txtAddress5.Text = row[6].ToString();
                    }

                    //                =================== binding data to deliveries ==================
                    txtDeliveries.Text =
                        view_CREDIT_NOTE_FRM.dataGridViewX1.Rows[view_CREDIT_NOTE_FRM.selectIndex].Cells[8].Value.
                            ToString();
                    var dtDeliveries =
                        dataManager.GetData(
                            "SELECT DEL_CODE, DEL_NAME,DEL_ADD_1,DEL_ADD_2,DEL_ADD_3, DEL_ADD_4,DEL_ADD_5 FROM dbo.SIPDADD",
                            "DEL_CODE", "DEL_CODE", txtDeliveries.Text);
                    foreach (DataRow row in dtDeliveries.Rows)
                    {
                        txtDelName.Text = row[1].ToString();
                        txtDelAddress1.Text = row[2].ToString();
                        txtDelAddress2.Text = row[3].ToString();
                        txtDelAddress3.Text = row[4].ToString();
                        txtDelAddress4.Text = row[5].ToString();
                        txtDelAddress5.Text = row[6].ToString();
                    }
                    //                ===================== binding into gridview ============

                    var dtSaleDetial = dataManager.GetData("SELECT ORD_REF, ORD_LINE,LOC_CODE,ITEM_CODE, ITEM_DESC,INV_UNIT,INV_QTY,INV_STOCK,INV_PRICE,INV_SUB,INV_DISP,INV_DISA,INV_TOT,INV_STAT,INV_COM,INV_REF,INV_CRE,INV_POS FROM dbo.SIPSINVD", "ORD_REF", "ORD_REF",
                                                           txtTranRef.Text, "INV_CRE", "D");
                    dataGridViewX1.Rows.Clear();
                    foreach (DataRow row in dtSaleDetial.Rows)
                    {

                        var condition = new string[] {"ITEM_CODE", row[3].ToString()};
                        var item_Detial = DataAccess.ReturnField("SELECT ITEM_DESC FROM dbo.SIPITEMS", "ITEM_CODE",
                                                                 condition, 0);
                        var unitOfSale = DataAccess.ReturnField("SELECT UNIT_SALE FROM dbo.SIPITEMS", "ITEM_CODE",
                                                                condition,
                                                                0);
                        dataGridViewX1.Rows.Add(false, row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8],
                                                string.Format("{0:0,0.00}", row[9]),
                                                row[11], string.Format("{0:0,0.00}", row[12]), row[13], row[10],
                                                item_Detial,
                                                unitOfSale,
                                                view_CREDIT_NOTE_FRM.dataGridViewX1.Rows[
                                                    view_CREDIT_NOTE_FRM.selectIndex].
                                                    Cells
                                                    [7].Value.ToString(), row[15].ToString());

                    }


                }
                txtInvoiceQty.Text = SIDataGridView.Sum(dataGridViewX1, 6).ToString();
            }
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewX1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewX1.Rows)
                {
                    if (ChkAll.Checked == true)
                        row.Cells[0].Value = true;
                    else
                        row.Cells[0].Value = false;
                }
                dataGridViewX1_CellContentClick(null,null);
                dataGridViewX1.EndEdit();
            }
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewX1.EndEdit();
            var d = dataGridViewX1.SelectedRows.Count;
            var da = dataGridViewX1.SelectedRows[0].Cells[8].Value.ToString();
               if (Decimal.Parse(dataGridViewX1.SelectedRows[0].Cells[8].Value.ToString()) > 0)
            {
                txtCreditNote.Text = SIDataGridView.SumDataOnSelectedGrid(dataGridViewX1, 11, e).ToString();
                txtCreditQty.Text = SIDataGridView.SumDataOnSelectedGrid(dataGridViewX1, 6, e).ToString();
            }
        }

        private void PostToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.CreditNote, "V", subMenuItems.Post, true) ==
        false)
                    return;

                var sequance = 1;
                var sisipinmov = new SISIPINMOV();
                if (DataAccess.ReturnField("SELECT MAX(SEQUENCE) FROM dbo.SIPINMOV", 0) != "")
                {
                    sequance = Convert.ToInt16(DataAccess.ReturnField("SELECT MAX(SEQUENCE) FROM dbo.SIPINMOV", 0)) + 1;
                }
                if (dataGridViewX1.Rows.Count > 0)
                {
                    var command = new SqlCommand("", connection.Connect());
                    var inv_Ref = "";
                    for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                    {
                        DataGridViewCell cell = dataGridViewX1.Rows[i].Cells[0];
                        bool check = (bool)cell.EditedFormattedValue;
                        if (check)
                        {
                            inv_Ref = dataGridViewX1.Rows[i].Cells[17].Value.ToString();
                            var condition = new string[]
                                                {
                                                    "LOCATION", dataGridViewX1.Rows[i].Cells[2].Value.ToString(), "IR_STAT"
                                                    , "I", "ITEM_CODE", dataGridViewX1.Rows[i].Cells[3].Value.ToString()
                                                };
                            var cost = DataAccess.ReturnField("SELECT COST FROM dbo.SIPINMOV", "SEQUENCE", condition, 0);
                            var UNIT = DataAccess.ReturnField("SELECT UNIT_STOCK FROM SIPITEMS WHERE ITEM_CODE = '" + dataGridViewX1.Rows[i].Cells[3].Value + "'", 0);
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandText = "SI_INSERT_SIPINMOV_STOCK";
                            Commands.CreateParameter(command, "SEQUENCE_0", sequance, "REC_TYPE_1", "C", "MOV_DATE_7",
                                                     comboDate.Value,
                                                     "MOV_REF_3", txtTranRef.Text, "MOV_LINE_4",
                                                     sisipinmov.Return_Line_Ref(txtTranRef.Text), "LOCATION_5",
                                                     dataGridViewX1.Rows[i].Cells[2].Value, "ITEM_CODE_6",
                                                     dataGridViewX1.Rows[i].Cells[3].Value,
                                                     "STATUS_8", "80", "IR_STAT_9", "I", "LINE_REF_12", "",
                                                     "QUANTITY_13",
                                                     Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[7].Value),
                                                     "COST_14", Convert.ToDecimal(cost), "TOTAL_15",
                                                     Convert.ToDecimal(cost)*
                                                     Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[7].Value),
                                                     "MOV_UNITS_16", UNIT ,
                                                     "MOV_TYPE_17", "", "ALLOC_REF_20", "",
                                                     "ORIG_LINE_NO_33", dataGridViewX1.Rows[i].Cells[1].Value,
                                                     "PO_VALUE_34", 0, "ID_ENTERED_35", UserLogOn.Code,
                                                     "ID_ALLOC_36", UserLogOn.Code, "LOC_TRAN_48", "");
                          var dd =  command.ExecuteNonQuery();
                          
                            command = new SqlCommand("",connection.Connect());
                            command.Parameters.Clear();
                            command.CommandType = CommandType.Text;
                            command.CommandText = "UPDATE dbo.SIPSINVD SET INV_CRE = 'A' WHERE ORD_REF = '" +
                                                  txtTranRef.Text + "' AND ORD_LINE = '" +
                                                  dataGridViewX1.Rows[i].Cells[1].Value.ToString() +
                                                  "' AND ITEM_CODE = '" +
                                                  dataGridViewX1.Rows[i].Cells[3].Value.ToString() +
                                                  "' AND LOC_CODE = '" +
                                                  dataGridViewX1.Rows[i].Cells[2].Value.ToString()
                                                  + "' AND INV_REF ='" + dataGridViewX1.Rows[i].Cells[17].Value.ToString() + "'";

                            command.ExecuteNonQuery();
                        

                        }
                        command = new SqlCommand("", connection.Connect());
                        command.CommandType = CommandType.Text;
                        command.CommandText = "UPDATE dbo.SIPSINVM SET INV_CREDIT = 'A' WHERE ORD_REF ='" + txtTranRef.Text + "' AND INV_STAT = 'A'  AND INV_REF ='" + inv_Ref + "'";
                        command.ExecuteNonQuery();

                        var dt = dataManager.GetData("SELECT * FROM dbo.SIPSINVD", "ORD_REF", "ORD_REF", txtTranRef.Text,
                                                     "INV_REF", inv_Ref, "INV_CRE", "D");
                        if (dt.Rows.Count == 0)
                        {
                            command = new SqlCommand("", connection.Connect());
                            command.CommandType = CommandType.Text;
                            command.CommandText = "UPDATE dbo.SIPSINVM SET INV_STAT = 'D' WHERE ORD_REF ='" + txtTranRef.Text + "' AND INV_STAT = 'A'  AND INV_REF ='" + inv_Ref + "'";
                            command.ExecuteNonQuery();
                        }
                    }
                }

//                =============  NOTE: Print report =========================
                var report = new Report();
                var dtCredit = dataManager.GetData("SELECT * FROM V_CREDIT_NOTE_PRINT WHERE [Head Order Reference]='" + txtTranRef.Text + "'");
                report.Preview("Print Credit Note Form",dtCredit);

                controls.ClearControl(txtDeliveries, txtDelName, txtDelAddress1, txtDelAddress2, txtDelAddress3,
                                  txtDelAddress4, txtDelAddress5, txtCustomer, txtName, txtAddress1, txtAddress2,
                                  txtAddress3, txtAddress4, txtAddress5, txtTranRef, txtComment);
                txtInvoiceValue.Text = "0.00";
                txtInvoiceQty.Text = "0";
                txtItemDisc.Text = "0.00";
                txtCreditNote.Text = "0.00";
                txtCreditQty.Text = "0";
                dataGridViewX1.Rows.Clear();
                
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtCustomer.Text))
                {
                  var dt =
                        dataManager.GetData(
                            "SELECT ADD_CODE, ADD_NAME, ADD_LINE_1, ADD_LINE_2,ADD_LINE_3, ADD_LINE_4,ADD_LINE_5 FROM SIPADDR WHERE ADD_TYPE = 0 AND ADD_CODE LIKE '%" +
                            txtCustomer.Text +
                            "' AND ADD_STAT = 'A'");
                    if (dt.Rows.Count > 0)
                    {
                        txtCustomer.Text = dt.Rows[0][0].ToString();
                        txtName.Text = dt.Rows[0][1].ToString();
                        txtAddress1.Text = dt.Rows[0][2].ToString();
                        txtAddress2.Text = dt.Rows[0][3].ToString();
                        txtAddress3.Text = dt.Rows[0][4].ToString();
                        txtAddress4.Text = dt.Rows[0][5].ToString();
                        txtAddress5.Text = dt.Rows[0][6].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Customer code '" + txtCustomer.Text + "' not found", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCustomer.SelectionStart = 0;
                        txtCustomer.SelectionLength = txtCustomer.Text.Length;
                        txtCustomer.Focus();
                        return;
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnCustomer_Click(null,null);
            }
        }
    }
}
