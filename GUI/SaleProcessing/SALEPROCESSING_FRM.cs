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
using POS.Transaction.Sale;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.SaleProcessing
{
    public partial class SALEPROCESSING_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public SALEPROCESSING_FRM()
        {
            InitializeComponent();
        }

        readonly DropDownList dropDownList = new DropDownList();
        public bool IS_EDIT = false;
        readonly DataManager dataManager = new DataManager();
        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
// ReSharper disable FieldCanBeMadeReadOnly
        Controls controls = new Controls();
// ReSharper restore FieldCanBeMadeReadOnly
        readonly SaleOrder saleOrder = new SaleOrder();
        readonly Connection.Connection connection = new Connection.Connection();
        readonly DateTimes dateTimes = new DateTimes();
        private bool Make_Change = false;


        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to terminate on this data?","Close",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        private void addNewLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SaleOrder, "V", subMenuItems.NewLine, true) ==
            false)
                return;

            if (string.IsNullOrEmpty(txtCustomer.Text) || string.IsNullOrEmpty(txtDeliveries.Text))
            {
                MessageBox.Show("Please, Select On Customer or Deliveries first.", "Empty", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }
            if (dataManager.Exists("SIPSINVM", "INV_REF", "", "INV_STAT", "A", "ORD_REF",txtTranRef.Text))
            {
                MessageBox.Show("Can't Add Data. It's already Release.");
                return;
            }
            IS_EDIT = false;
            var addnew_FRM = new ADDNEW_FRM(this);
            addnew_FRM.ShowDialog();
            addnew_FRM.Close();
           
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var droplist_Frm = new DROPLIST_FRM();
            var dd = Convert.ToInt16(groupBox1.Top) + Convert.ToInt16(txtCustomer.Top) + Convert.ToInt16(btnCustomer.Top) + 28;
            dropDownList.BindingData(
                "SELECT ADD_CODE, ADD_NAME, ADD_LINE_1, ADD_LINE_2,ADD_LINE_3, ADD_LINE_4,ADD_LINE_5 FROM SIPADDR WHERE ADD_TYPE = 0 AND ADD_CODE LIKE '%" + txtCustomer.Text +
                "' AND ADD_STAT = 'A'", txtCustomer, this, droplist_Frm, btnCustomer, Convert.ToInt16(dd),2,3,4,5,6);
            if (droplist_Frm.ShowDialog() == DialogResult.OK)
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

        private void SALEPROCESSING_FRM_Load(object sender, EventArgs e)
        {
            var dt = dataManager.GetData("SELECT SI_LOOKUP FROM SIPDATA ", "SI_CODE", "SI_CODE", "OS",
                                            "SI_TYPE", "AUTON");
            if (dt.Rows.Count > 0)
            {
                SITempData.Sale_Order = dt.Rows[0][0].ToString().Substring(0, 1);
                txtTranRef.Text = SIAutoNumber.POS_AutoNumber();
                if (SITempData.Sale_Order == "Y")
                {
                    txtTranRef.Enabled = false;
                }
            }
        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
              var droplist_FRM = new DROPLIST_FRM();
              var i = Convert.ToInt16(groupBox1.Top) + 49;//+ Convert.ToInt16(txtDeliveries.Top);// +Convert.ToInt16(btnDeliveries.Top) + 25;
            dropDownList.BindingData(
                "SELECT DEL_CODE, DEL_NAME,DEL_ADD_1,DEL_ADD_2,DEL_ADD_3, DEL_ADD_4,DEL_ADD_5 FROM dbo.SIPDADD WHERE ADD_CODE = '" +
                txtCustomer.Text + "' AND DEL_TYPE = 0", txtDeliveries, this, droplist_FRM, btnDeliveries,Convert.ToInt16(i), 2, 3, 4, 5, 6);
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
                ADDNEW_FRM addnew_FRM = new ADDNEW_FRM(this);
                addnew_FRM.ShowDialog();
            }

        }

        private void StartToolStrip_Click(object sender, EventArgs e)
        {
            ClearData();
            IS_EDIT = false;
            txtDeliveries.Enabled = false;
            btnDeliveries.Enabled = false;
//            txtTranRef.Text = SIAutoNumber.POS_AutoNumber();
            txtCustomer.Enabled = true;
            btnCustomer.Enabled = true;
            dataGridViewX1.Rows.Clear();
        }

        private void ClearData()
        {
            controls.ClearControl(txtCustomer, txtName, txtAddress1, txtAddress2, txtAddress3, txtAddress4, txtAddress5,
                                  txtDeliveries, txtDelName, txtDelAddress1, txtDelAddress2, txtDelAddress3,
                                  txtDelAddress4, txtDelAddress5);
            txtTranRef.Text = SIAutoNumber.POS_AutoNumber();
            txtTotalQty.Text = "0.00";
            txtTotalVAT.Text = "0.00";
            txtGrandTotal.Text = "0.00";
            txtInvoiceValue.Text = "0.00";
            txtInvoiceDisc.Text = "0.00";
            txtItemDisc.Text = "0.00";
            txtInvoiceP.Text = "0.00";
            Make_Change = false;
        }

        private void InvoiceOptToolStrip_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SaleOrder, "V", subMenuItems.InvoiceOptions, true) ==
           false)
                return;
            if (dataGridViewX1.Rows.Count == 0 && string.IsNullOrEmpty(txtInvoiceValue.Text))
            {
                MessageBox.Show("No value to discount.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataManager.Exists("SIPSINVM", "INV_REF", "", "INV_STAT", "A", "ORD_REF", txtTranRef.Text))
            {
                MessageBox.Show("Can't Option on this data. It's already release.");
                return;
            }
            var invoice_OPTIONS_FRM = new INVOICE_OPTIONS_FRM();
            invoice_OPTIONS_FRM.txtTotalInvoice.Text = txtGrandTotal.Text;
            invoice_OPTIONS_FRM.txtGrandTotal.Text = txtGrandTotal.Text;
            if (invoice_OPTIONS_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtInvoiceDisc.Text = invoice_OPTIONS_FRM.txtVAT.Text;
                txtGrandTotal.Text = invoice_OPTIONS_FRM.txtGrandTotal.Text;
                txtInvoiceP.Text = invoice_OPTIONS_FRM.txtDiscount.Text;
                txtTotalVAT.Text = invoice_OPTIONS_FRM.txtVAT.Text;
            }
        }

        private void editLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SaleOrder, "V", subMenuItems.EditLine, true) ==
            false)
                return;
            if (dataGridViewX1.Rows.Count ==0)
            {
                return;
            }
            if (dataManager.Exists("SIPSINVM", "INV_REF", "", "INV_STAT", "A", "ORD_REF", txtTranRef.Text))
            {
                MessageBox.Show("Can't Edit data. It's already release.");
                return;
            }
            var addnew_FRM = new ADDNEW_FRM(this);
            
//            ================= Copy Select On gridview ============
            addnew_FRM.txtLineNo.Text = dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString();
            var ddss = dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString();
            addnew_FRM.txtlocat.Text = ddss;
            addnew_FRM.txtItemCode.Text = dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString();
            addnew_FRM.txtItemDesc.Text = dataGridViewX1.SelectedRows[0].Cells[13].Value.ToString();
            addnew_FRM.txtUnitOfStock.Text = dataGridViewX1.SelectedRows[0].Cells[4].Value.ToString();
            addnew_FRM.txtQuantity.Text = dataGridViewX1.SelectedRows[0].Cells[5].Value.ToString();
            addnew_FRM.txtStockQty.Text = dataGridViewX1.SelectedRows[0].Cells[6].Value.ToString();
            addnew_FRM.txtPrice.Text = dataGridViewX1.SelectedRows[0].Cells[7].Value.ToString();
            addnew_FRM.txtAmount.Text = dataGridViewX1.SelectedRows[0].Cells[8].Value.ToString();
            addnew_FRM.txtDiscountTotal.Text = dataGridViewX1.SelectedRows[0].Cells[9].Value.ToString();
            addnew_FRM.txtGrandTotal.Text = dataGridViewX1.SelectedRows[0].Cells[10].Value.ToString();
            switch (dataGridViewX1.SelectedRows[0].Cells[11].Value.ToString())
            {
                case "S":
                    addnew_FRM.cboSaleType.Text = "Sale";
                    break;
                case "F":
                    addnew_FRM.cboSaleType.Text = "Free";
                    break;
                case "O":
                    addnew_FRM.cboSaleType.Text = "Owner Used";
                    break;
                case "C":
                    addnew_FRM.cboSaleType.Text = "Coupon";
                    break;
            }
            addnew_FRM.txtDiscP.Text = dataGridViewX1.SelectedRows[0].Cells[12].Value.ToString();
            addnew_FRM.txtUnitOfSale.Text = dataGridViewX1.SelectedRows[0].Cells[14].Value.ToString();
            addnew_FRM.txtEmployee.Text = dataGridViewX1.SelectedRows[0].Cells[15].Value.ToString();
                var physical = saleOrder.GetItem("", addnew_FRM.txtlocat.Text, addnew_FRM.txtItemCode.Text);
                var onOrder = saleOrder.GetItem("O", addnew_FRM.txtlocat.Text, addnew_FRM.txtItemCode.Text);
                var free = physical - onOrder;
            addnew_FRM.txtPhysical.Text = physical.ToString();
            addnew_FRM.txtOnOrder.Text = onOrder.ToString();
            addnew_FRM.txtFree.Text = free.ToString();
            addnew_FRM.txtDiscUSD.Text = "0";
            IS_EDIT = true;
            addnew_FRM.ShowDialog();
        }

        private void removeLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SaleOrder, "V", subMenuItems.DeleteLine, true) ==
           false)
                return;
            if (dataGridViewX1.Rows.Count == 0)
            {
                return;
            }
            if (dataGridViewX1.SelectedRows[0].Selected == false)
            {
                MessageBox.Show("Please Select data to remove line.", "Remove", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (dataManager.Exists("SIPSINVM", "INV_REF", "", "INV_STAT", "A", "ORD_REF", txtTranRef.Text))
            {
                MessageBox.Show("Can't remove this line. It's already release.", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Do you want to remove this line?","Remove Line",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dataGridViewX1.Rows.Remove(dataGridViewX1.SelectedRows[0]);
                txtInvoiceValue.Text = SIDataGridView.Sum(dataGridViewX1, 8).ToString();
                txtItemDisc.Text = SIDataGridView.Sum(dataGridViewX1, 9).ToString();
                txtTotalQty.Text = SIDataGridView.Sum(dataGridViewX1, 5).ToString();
                txtTotalVAT.Text = "0.00";
                txtInvoiceDisc.Text = "0.00";
                txtGrandTotal.Text = string.Format("{0:0,0.00}",
                                                   Convert.ToDecimal(txtInvoiceValue.Text) -
                                                   Convert.ToDecimal(txtInvoiceDisc.Text) -
                                                   Convert.ToDecimal(txtItemDisc.Text) + Convert.ToDecimal(txtTotalVAT.Text));
                for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                {
                    dataGridViewX1.Rows[i].Cells[0].Value = string.Format("{0:000}", i + 1);
                }
                
            }
        }

        private void HoldToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    security.CheckPermission(UserLogOn.Code, menuItems.SaleOrder, "V", subMenuItems.Hold, true) ==
                    false)
                    return;
                if (dataGridViewX1.Rows.Count == 0 && Condition.EmptyControl(txtDeliveries, txtCustomer))
                {
                    MessageBox.Show("No data to Hold.", "Hold", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (dataManager.Exists("SIPSINVM", "INV_REF", "", "ORD_REF", txtTranRef.Text, "INV_STAT", "A"))
                {
                    var cmd =
                        new SqlCommand(
                            "UPDATE dbo.SIPSINVM SET INV_STAT = 'D' WHERE ORD_REF = '" + txtTranRef.Text + "'",
                            connection.Connect());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Hold.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomer.Enabled = false;
                    btnCustomer.Enabled = false;
                }
                else
                {
//                    ============================== clear data before hold to database =====================
                    var command =
                        new SqlCommand(
                            "DELETE dbo.SIPSINVM WHERE ORD_REF = '" + txtTranRef.Text + "' AND INV_REF = ''",
                            connection.Connect());
                    command.ExecuteNonQuery();

                    command = new SqlCommand("DELETE dbo.SIPSINVD WHERE ORD_REF = '" + txtTranRef.Text + "'",
                                             connection.Connect());
                    command.ExecuteNonQuery();


                    //            ========================= Insert into SIPSINVM =============
                    command = new SqlCommand("SI_INSERT_SIPSINVM", connection.Connect())
                                      {CommandType = CommandType.StoredProcedure};
                    Cursor = Cursors.WaitCursor;
                    // ========== Note : customer need to refacting here.
                    var INV_TOTAD = Convert.ToDecimal(txtInvoiceValue.Text) - Convert.ToDecimal(txtItemDisc.Text);
                    var INV_TOTAI = Convert.ToDecimal(INV_TOTAD) - Convert.ToDecimal(txtInvoiceDisc.Text);
                    var EMP_CODE = dataGridViewX1.Rows[0].Cells[15].Value.ToString();
                    Commands.CreateParameter(command, "ORD_REF_1", txtTranRef.Text,
                                             "INV_REF_2", "",
                                             "INV_DATE_3", dateTimes.Now(), "CUS_CODE_4", txtCustomer.Text,
                                             "DEL_CODE_5", txtDeliveries.Text, "EMP_CODE_6", EMP_CODE,
                                             "INV_COM_7", txtComment.Text, "INV_TOTAL_8",
                                             Convert.ToDecimal(txtInvoiceValue.Text), "INV_TOTID_9",
                                             Convert.ToDecimal(txtItemDisc.Text),
                                             "INV_TOTAD_10", Convert.ToDecimal(INV_TOTAD), "INV_DISP_11",
                                             Convert.ToDecimal(txtInvoiceP.Text), "INV_DISA_12",
                                             Convert.ToDecimal(txtInvoiceDisc.Text),
                                             "INV_TOTAI_13", Convert.ToDecimal(INV_TOTAI), "INV_VAT_14",
                                             Convert.ToDecimal(txtTotalVAT.Text), "INV_GRAND_15",
                                             Convert.ToDecimal(txtGrandTotal.Text),
                                             "INV_STAT_16", "D", "INV_PAY_17", "N", "USER_CODE_18",
                                             UserLogOn.Code,"INV_CREDIT_19","D","INV_POS_20","D");
                    command.ExecuteNonQuery();

                    //                  =============================== Inset Into Sale Detail  ==========================

                    command.CommandText = "SI_INSERT_SIPSINVD";
                    var i = 1;
                    foreach (DataGridViewRow row in dataGridViewX1.Rows)
                    {
                        command.Parameters.Clear();

                        var price = Convert.ToDecimal(row.Cells[7].Value.ToString());
                        var saleQty = Convert.ToDecimal(row.Cells[5].Value);
                        var stockQty = Convert.ToDecimal(row.Cells[6].Value);
                        var amount = Convert.ToDecimal(row.Cells[8].Value);
                        var disc = Convert.ToDecimal(row.Cells[9].Value.ToString());
                        var discUSD = Convert.ToDecimal(row.Cells[12].Value.ToString());
                        var total = Convert.ToDecimal(row.Cells[10].Value.ToString());
                        var saleType = row.Cells[11].Value.ToString();
                        var location = row.Cells[1].Value.ToString();

                        Commands.CreateParameter(command, "ORD_REF_1", txtTranRef.Text,
                                                 "ORD_LINE_2", string.Format("{0:000}", i),
                                                 "LOC_CODE_3", location, "ITEM_CODE_4",
                                                 row.Cells[2].Value, "ITEM_DESC_5", row.Cells[3].Value,
                                                 "INV_UNIT_6", row.Cells[4].Value, "INV_QTY_7", saleQty,
                                                 "INV_STOCK_8", stockQty,
                                                 "INV_PRICE_9", Convert.ToDecimal(price.ToString()),
                                                 "INV_SUB_10", Convert.ToDecimal(amount.ToString()), "INV_DISP_11", Convert.ToDecimal(discUSD.ToString()),
                                                 "INV_DISA_12", Convert.ToDecimal(disc.ToString()), "INV_TOT_13", Convert.ToDecimal(total.ToString()), "INV_STAT_14",
                                                 saleType,
                                                 "INV_COM_15", txtComment.Text, "INV_REF_16", "","INV_CRE_17","D","INV_POS_18","D");
                        command.ExecuteNonQuery();

                        i++;
                    }
                    txtCustomer.Enabled = true;
                    btnCustomer.Enabled = true;
                }
                ClearData();
                dataGridViewX1.Rows.Clear();
                
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void ReleaseToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.SaleOrder, "V", subMenuItems.Release, true) ==
          false)
                    return;
                Cursor = Cursors.WaitCursor;
                if (dataManager.Exists("SIPSINVM", "ORD_REF", txtTranRef.Text, "INV_REF", "", "INV_STAT", "A"))
                {
                    MessageBox.Show("This Transaction reference already release.", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
                if (dataGridViewX1.Rows.Count == 0)
                {
                    MessageBox.Show("No data to release.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!dataManager.Exists("SIPSINVM", txtTranRef.Text, "ORD_REF", "INV_REF",""))
                {
                    //            ========================= Insert into SIPSINVM =============
                    var command = new SqlCommand("SI_INSERT_SIPSINVM", connection.Connect()) { CommandType = CommandType.StoredProcedure };
                    Cursor = Cursors.WaitCursor;
                    // ========== Note : customer need to refacting here.
                    var INV_TOTAD = Convert.ToDecimal(txtInvoiceValue.Text) - Convert.ToDecimal(txtItemDisc.Text);
                    var INV_TOTAI = Convert.ToDecimal(INV_TOTAD) - Convert.ToDecimal(txtInvoiceDisc.Text);
                    var EMP_CODE = dataGridViewX1.Rows[0].Cells[15].Value.ToString();
                    Commands.CreateParameter(command, "ORD_REF_1", txtTranRef.Text,
                                             "INV_REF_2", "",
                                             "INV_DATE_3", dateTimes.Now(), "CUS_CODE_4", txtCustomer.Text,
                                             "DEL_CODE_5", txtDeliveries.Text, "EMP_CODE_6", EMP_CODE,
                                             "INV_COM_7", txtComment.Text, "INV_TOTAL_8",
                                             Convert.ToDecimal(txtInvoiceValue.Text), "INV_TOTID_9",
                                             Convert.ToDecimal(txtItemDisc.Text),
                                             "INV_TOTAD_10", Convert.ToDecimal(INV_TOTAD), "INV_DISP_11",
                                             Convert.ToDecimal(txtInvoiceP.Text), "INV_DISA_12",
                                             Convert.ToDecimal(txtInvoiceDisc.Text),
                                             "INV_TOTAI_13", Convert.ToDecimal(INV_TOTAI), "INV_VAT_14",
                                             Convert.ToDecimal(txtTotalVAT.Text), "INV_GRAND_15",
                                             Convert.ToDecimal(txtGrandTotal.Text),
                                             "INV_STAT_16", "D", "INV_PAY_17", "N", "USER_CODE_18",
                                             UserLogOn.Code,"INV_CREDIT_19","D","INV_POS_20","D");
                    command.ExecuteNonQuery();

                    //                  =============================== Inset Into Sale Detail  ==========================

                    command.CommandText = "SI_INSERT_SIPSINVD";
                    var i = 1;
                    foreach (DataGridViewRow row in dataGridViewX1.Rows)
                    {
                        command.Parameters.Clear();

                        var price = Convert.ToDecimal(row.Cells[7].Value.ToString());
                        var saleQty = Convert.ToDecimal(row.Cells[5].Value);
                        var stockQty = Convert.ToDecimal(row.Cells[6].Value);
                        var amount = Convert.ToDecimal(row.Cells[8].Value);
                        var disc = Convert.ToDecimal(row.Cells[9].Value.ToString());
                        var discUSD = Convert.ToDecimal(row.Cells[12].Value.ToString());
                        var total = Convert.ToDecimal(row.Cells[10].Value.ToString());
                        var saleType = row.Cells[11].Value.ToString();
                        var location = row.Cells[1].Value.ToString();
                        if (saleType == "C")
                        {
                            saleType = "K";

                        }
                        Commands.CreateParameter(command, "ORD_REF_1", txtTranRef.Text,
                                                 "ORD_LINE_2", string.Format("{0:000}", i),
                                                 "LOC_CODE_3", location, "ITEM_CODE_4",
                                                 row.Cells[2].Value, "ITEM_DESC_5", row.Cells[3].Value,
                                                 "INV_UNIT_6", row.Cells[4].Value, "INV_QTY_7", saleQty,
                                                 "INV_STOCK_8", stockQty,
                                                 "INV_PRICE_9", Convert.ToDecimal(price.ToString()),
                                                 "INV_SUB_10", Convert.ToDecimal(amount.ToString()), "INV_DISP_11", Convert.ToDecimal(discUSD.ToString()),
                                                 "INV_DISA_12", Convert.ToDecimal(disc.ToString()), "INV_TOT_13", Convert.ToDecimal(total.ToString()), "INV_STAT_14",
                                                 saleType,
                                                 "INV_COM_15", txtComment.Text, "INV_REF_16", "","INV_CRE_17","D","INV_POS_18","D");
                        command.ExecuteNonQuery();

                        i++;
                    }  
                }
                var cmd =
                    new SqlCommand(
                        "UPDATE dbo.SIPSINVM SET INV_STAT = 'A',INV_VAT = " + Convert.ToDecimal(txtTotalVAT.Text) + ",INV_DISP = " +
                        Convert.ToDecimal(txtInvoiceP.Text) + ", INV_DISA = " + Convert.ToDecimal(txtInvoiceDisc.Text) +
                        ", INV_GRAND ="+ Convert.ToDecimal(txtGrandTotal.Text) +"  WHERE ORD_REF = '" + txtTranRef.Text + "'",
                        connection.Connect());
                cmd.ExecuteNonQuery();
                
//                ====================  Print Sale  Form ==========

                var dt =
                    dataManager.GetData("select * from V_SALE_PROCESS_PRINT WHERE [Head Order Reference] ='" +
                                        txtTranRef.Text + "'");
                Reports.Report report = new Report();
                report.Preview("Print Sale Form",dt);

                MessageBox.Show("Successfull Release.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
                dataGridViewX1.Rows.Clear();
                txtCustomer.Enabled = true;
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);               
            }
        }

        private void transactionOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SaleOrder, "V", subMenuItems.TransactionOrder, true) ==
         false)
                return;
            if (Make_Change)
            {
                if (MessageBox.Show("Are you sure you want to clear current change?","Clear",MessageBoxButtons.OK,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            var view_SALEORDER_FRM = new VIEW_SALEORDER_FRM();
            var i = 0;
            foreach (var time in saleOrder.HoldDateTime())
            {
                
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[0].Nodes.Add(time, time, 1, 1).Tag = "HoldDate";
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[0].Nodes[i].ImageIndex = 5;
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[0].Nodes[i].SelectedImageIndex = 5;
                i++;
            }
            i = 0;
            foreach (var time in saleOrder.ReleaseDateTime())
            {
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[1].Nodes.Add(time, time, 1, 1).Tag = "ReleaseDate";
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[1].Nodes[i].ImageIndex = 5;
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[1].Nodes[i].SelectedImageIndex = 5;
                i++;
            }

            i = 0;
            foreach (var time in saleOrder.POSReleaseDateTime())
            {
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[2].Nodes.Add(time, time, 1, 1).Tag = "POSDate";
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[2].Nodes[i].ImageIndex = 5;
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[2].Nodes[i].SelectedImageIndex = 5;
                i++;
            }

            i = 0;
            foreach (var time in saleOrder.InvoiceDateTime())
            {
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[3].Nodes.Add(time, time, 1, 1).Tag = "InvoiceDate";
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[3].Nodes[i].ImageIndex = 5;
                view_SALEORDER_FRM.treeView1.Nodes[0].Nodes[3].Nodes[i].SelectedImageIndex = 5;
                i++;
            }
            
            if (view_SALEORDER_FRM.ShowDialog() == DialogResult.OK)
            {
                if ((string) view_SALEORDER_FRM.NoSNote.Tag == "InvoiceDate" || (string) view_SALEORDER_FRM.NoSNote.Tag == "POSDate")
                {
                    return;                    
                }
                txtTranRef.Text =
                    view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[1].Value.ToString();
                comboDate.Value =
                    Convert.ToDateTime(
                        view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[3].Value.ToString());
                txtComment.Text =
                    view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[9].Value.ToString();
//                ============  binding customer  =============
                txtCustomer.Text =
                    view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[4].Value.ToString();
                txtName.Text =
                    view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[5].Value.ToString();
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
                    view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[8].Value.ToString();
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

//                ========================= binding data to gridview =====================
//                 ORD_REF, ORD_LINE,LOC_CODE, ITEM_CODE,ITEM_DESC,INV_UNIT,INV_QTY,INV_STOCK,INV_PRICE,INV_SUB,INV_DISP,INV_DISA,INV_TOT,INV_STAT,INV_COM,INV_REF
                var dtSaleDetial = dataManager.GetData("SELECT * FROM dbo.SIPSINVD", "ORD_REF", "ORD_REF",
                                                       txtTranRef.Text,"INV_CRE","D");
                dataGridViewX1.Rows.Clear();
                foreach (DataRow row in dtSaleDetial.Rows)
                {
                   
                    var condition = new[] {"ITEM_CODE",row[3].ToString()};
                    var item_Detial = DataAccess.ReturnField("SELECT ITEM_DESC FROM dbo.SIPITEMS","ITEM_CODE",condition,0);
                    var unitOfSale   = DataAccess.ReturnField("SELECT UNIT_SALE FROM dbo.SIPITEMS","ITEM_CODE",condition,0);
                    dataGridViewX1.Rows.Add(row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],
                                            row[11], row[12], row[14], row[10], item_Detial, unitOfSale,
                                            view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells
                                                [6].Value.ToString());
                }
//                =======================  Total =============

                txtTotalVAT.Text =
                    view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[15].Value.ToString();
                txtInvoiceValue.Text =
                    view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[6].Value.ToString();
                txtTotalQty.Text = SIDataGridView.Sum(dataGridViewX1, 5).ToString();
                txtInvoiceP.Text =
                    view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[12].Value.ToString();

                txtInvoiceDisc.Text =
                    view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[13].Value.ToString();
                txtGrandTotal.Text =
                    view_SALEORDER_FRM.dataGridViewX1.Rows[view_SALEORDER_FRM.SelectIndex].Cells[16].Value.ToString();
                txtItemDisc.Text = SIDataGridView.Sum(dataGridViewX1, 9).ToString();

                txtCustomer.Enabled = false;
                btnCustomer.Enabled = false;
                txtDeliveries.Enabled = false;
                btnDeliveries.Enabled = false;


            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var dt =
                    dataManager.GetData(
                        "SELECT ADD_CODE, ADD_NAME, ADD_LINE_1, ADD_LINE_2,ADD_LINE_3, ADD_LINE_4,ADD_LINE_5 FROM SIPADDR WHERE ADD_TYPE = 0 AND UPPER(ADD_CODE) LIKE UPPER('%" +
                        txtCustomer.Text + "') AND ADD_STAT = 'A'");
                if (dt.Rows.Count > 0)
                {
                        txtCustomer.Text = dt.Rows[0][0].ToString();
                    txtName.Text = dt.Rows[0][1].ToString();
                    txtAddress1.Text = dt.Rows[0][2].ToString();
                    txtAddress2.Text = dt.Rows[0][3].ToString();
                    txtAddress3.Text = dt.Rows[0][4].ToString();
                    txtAddress4.Text = dt.Rows[0][5].ToString();
                    txtAddress5.Text = dt.Rows[0][6].ToString();
                    txtCustomer.Enabled = false;
                    btnCustomer.Enabled = false;
                    txtDeliveries.Enabled = true;
                    btnDeliveries.Enabled = true;
                    txtDeliveries.Focus();
                }
                else
                {
                    MessageBox.Show("Customer code '" + txtCustomer.Text + "' not found.", "Not Found",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomer.SelectionStart = 0;
                    txtCustomer.SelectionLength = txtCustomer.Text.Length;
                    txtCustomer.Focus();
                    return;
                }
            }
            else if(e.KeyCode == Keys.F6)
            {
                 if (txtCustomer.Text == "")
                {
                    var droplist_Frm = new DROPLIST_FRM();
                    var dd = Convert.ToInt16(groupBox1.Top) + Convert.ToInt16(txtCustomer.Top) + Convert.ToInt16(btnCustomer.Top) + 28;
                    dropDownList.BindingData(
                        "SELECT ADD_CODE, ADD_NAME, ADD_LINE_1, ADD_LINE_2,ADD_LINE_3, ADD_LINE_4,ADD_LINE_5 FROM SIPADDR WHERE ADD_TYPE = 0 AND ADD_CODE LIKE '%" + txtCustomer.Text +
                        "' AND ADD_STAT = 'A'", txtCustomer, this, droplist_Frm, btnCustomer, Convert.ToInt16(dd), 2, 3, 4, 5, 6);
                    if (droplist_Frm.ShowDialog() == DialogResult.OK)
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
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtCustomer.Enabled = false;
                btnCustomer.Enabled = false;
                txtComment.Enabled = true;
                txtComment.Focus();
            }
        }

        private void txtDeliveries_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDeliveries.Text != "")
                {
                    var dt =
                        dataManager.GetData(
                            "SELECT DEL_CODE, DEL_NAME,DEL_ADD_1,DEL_ADD_2,DEL_ADD_3, DEL_ADD_4,DEL_ADD_5 FROM dbo.SIPDADD WHERE UPPER(ADD_CODE) LIKE UPPER('%" +
                            txtDeliveries.Text + "') AND DEL_TYPE = 0");
                    if (dt.Rows.Count > 0)
                    {
                        txtDeliveries.Text = dt.Rows[0][0].ToString();
                        txtDelName.Text = dt.Rows[0][1].ToString();
                        txtDelAddress1.Text = dt.Rows[0][2].ToString();
                        txtDelAddress2.Text = dt.Rows[0][3].ToString();
                        txtDelAddress3.Text = dt.Rows[0][4].ToString();
                        txtDelAddress4.Text = dt.Rows[0][5].ToString();
                        txtDelAddress5.Text = dt.Rows[0][6].ToString();
                        txtDeliveries.Enabled = false;
                        btnDeliveries.Enabled = false;
                        var addnew_FRM = new ADDNEW_FRM(this);
                        addnew_FRM.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Delivery Code '" + txtDeliveries.Text + "' not found.", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDeliveries.SelectionStart = 0;
                        txtDeliveries.SelectionLength = txtDeliveries.Text.Length;
                        txtDeliveries.Focus();
                        return;
                            
                    }
                }
               
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnDeliveries_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtCustomer.Enabled = true;
                btnDeliveries.Enabled = true;
                txtCustomer.SelectionStart = 0;
                txtCustomer.SelectionLength = txtCustomer.Text.Length;
                txtCustomer.Focus();
                txtDeliveries.Enabled = false;
                btnDeliveries.Enabled = false;
            }

        }

        private void comboDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(comboDate, true, true, true, true);
            }
        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(txtComment, true, true, true, true);
            }
        }
    
    }
}
