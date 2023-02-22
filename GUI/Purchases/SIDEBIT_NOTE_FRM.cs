using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Reports;
using POS.Transaction;
using POS.Transaction.Purchase;
using POS.Transaction.Security;
using POS.Utilities;
using System.Data.SqlClient;
using SortOrder=System.Windows.Forms.SortOrder;

namespace POS.GUI.Purchases
{
    public partial class SIDEBIT_NOTE_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public SIDEBIT_NOTE_FRM()
        {
            InitializeComponent();
        }

        #region Global variable

        public bool IS_UPDATE;
        public bool MAKE_CHANGE;
        public string STATUS;
        Controls controls = new Controls();
        SISecurity security = new SISecurity();
        SIMenuItems menuItems = new SIMenuItems();
        SISubMenuItems subMenuItems = new SISubMenuItems();
        DataManager dataManager  = new DataManager();
        Strings strings = new Strings();
        Connection.Connection connection = new Connection.Connection();
        private string PO_PREFIX = "";
        private string PO_SUFFIX = "";
        private Int16 PO_LENGHT;
        private Int16 PO_START;
        private string TRANS_REF = "";
        Int16 PO_INTERVAL;
        SIDebitNote debitNote = new SIDebitNote();
        SISIPINMOV sisipinmov = new SISIPINMOV();

        #endregion

        private void SIDEBIT_NOTE_FRM_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = dataManager.GetData("SELECT SI_LOOKUP FROM SIPDATA ", "SI_CODE", "SI_CODE", "PM",
                                             "SI_TYPE", "AUTON");
                if (dt.Rows.Count > 0)
                {
                    SITempData.PO_AUTO_NUM = dt.Rows[0][0].ToString().Substring(0, 1);
                    if (SITempData.PO_AUTO_NUM == "Y")
                    {
                        txtInvoice_Ref.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void StartToolStripButton_Click(object sender, EventArgs e)
        {
            if (MAKE_CHANGE)
            {
                if (MessageBox.Show("Are you sure you want to start new transaction without saving some change?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.Yes)
                {
                   return; 
                }
            }
            Start_PurchaseInvoice();
        }

        private void Start_PurchaseInvoice()
        {
            try
            {
                // Note: Refactoring here uncomment on 
//                dtpDate.Value = UserLogOn.Date;
//                dtpInv_date.Value = UserLogOn.Date;
                dtpDate.Value = DateTime.Now;
                dtpInv_date.Value = DateTime.Now;                 
//                     If DB_DEFAULTDATE = "C" Then
//                Dim S_DATE As Date = RETURN_SERVER_DATETIME(CN)
//                dtpDate.Value = S_DATE
//                dtpInv_date.Value = S_DATE
//            End If

                CheckBox1.Checked = false;
                Panel1.Enabled = true;
                Panel2.Enabled = false;
                IS_UPDATE = false;
                MAKE_CHANGE = false;
                controls.ClearControl(txtDebit_Ref, txtGRN_ref, txtSubRef, txtInvoice_Ref,
                                      txtOrder_ref,txtComment,txtStatus);
                txtInvoice_Ref.Enabled = false;
                dtpInv_date.Value = DateTime.Now;
                dtpDate.Value = DateTime.Now;
                Panel4.Enabled = false;
                Panel5.Enabled = false;
                controls.ClearControl(txtSupCode, txtSupName, txtSupAdd1, txtSupAdd2, txtSupAdd3, txtSupAdd4, txtSupAdd5);
                controls.ClearControl(txtDelCode, txtDelName, txtDelAdd1, txtDelAdd2, txtDelAdd3, txtDelAdd4, txtDelAdd5);
                dataGridViewX1.Rows.Clear();
                controls.ClearControl(lblInvoiceValue,lblinvoiceQty);
                var main_FRM = new MAIN_FRM();
                main_FRM.StatusStrip.Items[0].Text = "Ready";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnTool_Invoice_Click(object sender, EventArgs e)
        {
             if (security.CheckPermission(UserLogOn.Code, menuItems.DebitNote, "V", subMenuItems.PurchaseInvoice, true) ==
                    false)
                 return;
                 if (MAKE_CHANGE)
                 {
                     if (MessageBox.Show("Are you sure you want to view another transaction without saving some change?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                     {
                         return;
                     }   
                 }
            Start_PurchaseInvoice();
            var sidebit_NOTE_VIEW = new SIDEBIT_NOTE_VIEW();
            Cursor = Cursors.WaitCursor;
            var list = debitNote.YearWithMonth();
            foreach (string s in list)
            {
                sidebit_NOTE_VIEW.TreeView1.Nodes[0].Nodes.Add(s,s,1,1).Tag = "A";
            }

            Cursor = Cursors.Default;
            if (sidebit_NOTE_VIEW.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;

                //var dd = sidebit_NOTE_VIEW.DataGridView1.Rows.Count;
                var Inv_Ref = sidebit_NOTE_VIEW.dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString();

                var dtInvoiceOrder = dataManager.GetData("SELECT * FROM dbo.SIPPORD ", "ORM_REF", "ORM_REF", Inv_Ref,"ORD_STAT","A");
                if (dtInvoiceOrder.Rows.Count  > 0)
                {
                    //===========  Binding data to control ==========
                    DataRow row = dtInvoiceOrder.Rows[0];
                    txtInvoice_Ref.Text = row[0].ToString();
                    txtOrder_ref.Text = row[0].ToString();
                    txtGRN_ref.Text = row[0].ToString();
                    var cond = new string[] {"ORM_REF",Inv_Ref};
                    dtpDate.Value = Convert.ToDateTime(DataAccess.ReturnField("SELECT ORM_DATE FROM dbo.SIPPORM", "ORM_REF", cond, 0));

                    foreach(DataRow r in dtInvoiceOrder.Rows)
                    {
                        var ro = r[12].ToString();
                        lblInvoiceValue.Text = "0";
                        lblinvoiceQty.Text = "0";
                        lblInvoiceValue.Text = Convert.ToString(Convert.ToDecimal(lblInvoiceValue.Text) + Convert.ToDecimal(r[12].ToString()));
                        lblinvoiceQty.Text = Convert.ToString(Convert.ToDecimal(lblinvoiceQty.Text) + Convert.ToDecimal(r[6]));
                        var condition = new string[]{"ITEM_CODE",r[3].ToString()};
                        var item_desc = DataAccess.ReturnField("SELECT ITEM_DESC FROM dbo.SIPITEMS","ITEM_CODE",condition,0);
                        var con = new string[]
                                       {
                                           "CONV_FROM",
                                           r[4].ToString()
                                       };
                        var UnitSTock = DataAccess.ReturnField("select CONV_TO FROM SIUNITCONV ", "CONV_FROM", con, 0);
                                                             
                        dataGridViewX1.Rows.Add(false, r[1], r[2], r[3], item_desc, r[4], r[6], r[7], r[8], r[0], string.Format("{0:000}", dataGridViewX1.Rows.Count + 1),UnitSTock);
                    }
                    var d = sidebit_NOTE_VIEW.SelectIndex;
                    txtSupCode.Text = sidebit_NOTE_VIEW.dataGridViewX1.SelectedRows[0].Cells[5].Value.ToString();
                    var tblSupp =
                                dataManager.GetData(
                                    "SELECT ADD_NAME,ADD_LINE_1,ADD_LINE_2,ADD_LINE_3,ADD_LINE_4,ADD_LINE_5 FROM SIPADDR",
                                    "ADD_NAME", "ADD_TYPE", "1", "ADD_CODE",txtSupCode.Text);

                    if (tblSupp.Rows.Count > 0)
                    {
                        txtSupName.Text = tblSupp.Rows[0][0].ToString();
                        txtSupAdd1.Text = tblSupp.Rows[0][1].ToString();
                        txtSupAdd2.Text = tblSupp.Rows[0][2].ToString();
                        txtSupAdd3.Text = tblSupp.Rows[0][3].ToString();
                        txtSupAdd4.Text = tblSupp.Rows[0][4].ToString();
                        txtSupAdd5.Text = tblSupp.Rows[0][5].ToString();
                    }
                  
                    txtDelCode.Text = sidebit_NOTE_VIEW.dataGridViewX1.SelectedRows[0].Cells[5].Value.ToString();
                        var tblDelivery =
                            dataManager.GetData(
                                "SELECT DEL_NAME,DEL_ADD_1, DEL_ADD_2, DEL_ADD_3, DEL_ADD_4, DEL_ADD_5 FROM dbo.SIPDADD",
                                "DEL_NAME", "DEL_TYPE", "1", "DEL_CODE", txtDelCode.Text);
                        if (tblDelivery.Rows.Count > 0)
                        {
                            txtDelName.Text = tblDelivery.Rows[0][0].ToString();
                            txtDelAdd1.Text = tblDelivery.Rows[0][1].ToString();
                            txtDelAdd2.Text = tblDelivery.Rows[0][2].ToString();
                            txtDelAdd3.Text = tblDelivery.Rows[0][3].ToString();
                            txtDelAdd4.Text = tblDelivery.Rows[0][4].ToString();
                            txtDelAdd5.Text = tblDelivery.Rows[0][5].ToString();
                        }
                    }
                IS_UPDATE = true;
                if(SITempData.PO_AUTO_NUM == "Y")
                {
                    //txtDebit_Ref.Enabled = false;
                }
                Panel2.Enabled = false;
                STATUS = "Posted";
                MAIN_FRM main_frm = new MAIN_FRM();
                main_frm.StatusStrip.Items[0].Text = "Purchas Invoice :" + STATUS + ". Cannot be added, updated or deleted items!";

                Cursor = Cursors.Default;
                sidebit_NOTE_VIEW.Close();
            }
        }

        private void mn_split_Line_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.DebitNote, "V", subMenuItems.SplitLine, true) ==
                   false)
                    return;
                if (dataGridViewX1.SelectedRows.Count > 0)
                {
                    var value_S = 0;
                    var fixed_Value = new short[2];
                    if(strings.IsNumeric(dataGridViewX1.SelectedRows[0].Cells[6].Value.ToString()))
                    {
                        value_S = Int16.Parse(dataGridViewX1.SelectedRows[0].Cells[6].Value.ToString());
                    }
                    if(value_S >= 0)
                    {
                        var sisoplit_Frm = new SISOSPLIT_FRM();
                        sisoplit_Frm.AMT = Decimal.Parse(dataGridViewX1.SelectedRows[0].Cells[6].Value.ToString());
                        sisoplit_Frm.txtField.Text = dataGridViewX1.Columns[6].HeaderText;
                        sisoplit_Frm.txtOldValue.Text = dataGridViewX1.SelectedRows[0].Cells[6].Value.ToString();
                        if(sisoplit_Frm.ShowDialog() == DialogResult.OK)
                        {
                            Cursor = Cursors.WaitCursor;
                            #region Check It later
                            //var fieldAndCon = new string[] { "ORD_STAT", "D" };
                            //var line_No = DataAccess.ReturnField("SELECT MAX(ORD_LINE) FROM SIPPORD", "ORD_LINE", fieldAndCon, 0);
                            //if (line_No == "")
                            //{
                            //    MessageBox.Show("There are no transaction present!", "", MessageBoxButtons.OK,
                            //                    MessageBoxIcon.Information);
                            //    return;
                            //}
                            //else
                            //{
                            //    if (line_No.Trim().Length == 3)
                            //    {
                            //        line_No = line_No.Trim() + "01";
                            //    }
                            //    else
                            //    {
                            //        line_No = string.Format("00000", int.Parse(line_No) + 1);
                            //    }
                            //}
                            //Cursor = Cursors.WaitCursor;
                            #endregion
                            Double Split_AMT = Double.Parse(sisoplit_Frm.txtSplit.Text);
                            //                            Double Rate = Double.Parse(string.Format("{0:0.00000}", Split_AMT / Convert.ToDouble(sisosplit_FRM.AMT)));

                            var fieldAndVal = new string[] { "ITEM_CODE", dataGridViewX1.SelectedRows[0].Cells[3].Value.ToString() };

                            string Unit_Stock = DataAccess.ReturnField("SELECT UNIT_STOCK FROM SIPITEMS", "UNIT_STOCK",
                                                                       fieldAndVal, 0);
                            DataTable tbl = dataManager.GetData("SELECT OPERATOR, FACTOR FROM SIUNITCONV", "FACTOR",
                                                                "CONV_FROM",
                                                                dataGridViewX1.SelectedRows[0].Cells[5].Value.ToString(),
                                                                "CONV_TO", Unit_Stock);

                            decimal stock_NewQty = 0;
                            Decimal stock_OldQty = Decimal.Parse(sisoplit_Frm.txtSplit.Text);

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
                            var fieldAndCond = new string[] { "ORM_REF", txtGRN_ref.Text, "ORD_LINE", dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString() };
                            var discPer = DataAccess.ReturnField("SELECT ORD_DISP FROM dbo.SIPPORD", "ORM_REF",
                                                                 fieldAndCond, 0);
                            var purchase_Cost = DataAccess.ReturnField("SELECT ORD_COST FROM dbo.SIPPORD", "ORM_REF",
                                                                 fieldAndCond, 0);
                            

                            var line_Ref = "";
                            var j = 1;
                           
//                            ===============
                            var dtSIPPORD = dataManager.GetData("SELECT ORD_LINE FROM dbo.SIPPORD ", "ORD_LINE",
                                                                      "ORM_REF", txtGRN_ref.Text, "ORD_LINE",
                                               dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString());
                            foreach (DataRow row in dtSIPPORD.Rows)
                            {
                                if (row[0].ToString().Length == 3)
                                {
                                    line_Ref = row[0].ToString() + "01";
                                }
                                else
                                {
                                    line_Ref = row[0].ToString().Substring(0, 3) + string.Format("{0:00}", Convert.ToDecimal(row[0].ToString().Substring(3)) + 1);
                                }
                            }

                           

                            var g = dataGridViewX1.SelectedRows[0].Index + 1;
                            var con = new string[]
                                       {
                                           "CONV_FROM",
                                          dataGridViewX1.SelectedRows[0].Cells[5].Value.ToString()
                                       };
                        var UnitSTock = DataAccess.ReturnField("select CONV_TO FROM SIUNITCONV ", "CONV_FROM", con, 0);
                            dataGridViewX1.Rows.Insert(g,true, line_Ref, dataGridViewX1.SelectedRows[0].Cells[2].Value,
                                                    dataGridViewX1.SelectedRows[0].Cells[3].Value,
                                                    dataGridViewX1.SelectedRows[0].Cells[4].Value,
                                                    dataGridViewX1.SelectedRows[0].Cells[5].Value,
                                                    Convert.ToInt16(stock_OldQty),Convert.ToDecimal(stock_NewQty),
                                                    purchase_Cost,
                                                    dataGridViewX1.SelectedRows[0].Cells[9].Value,
                                                    dataGridViewX1.SelectedRows[0].Cells[10].Value,UnitSTock);
                            var command = new SqlCommand("", connection.Connect());


                            var ord_Qty = Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[6].Value.ToString()) -
                                          stock_OldQty;
                            var ord_Stock = Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[7].Value.ToString()) - stock_NewQty;
                            var Sub_0rd = ord_Qty*Convert.ToDecimal(purchase_Cost);

                            var cond = new string[]
                                           {
                                                "ORM_REF", txtGRN_ref.Text, "ORD_LINE",
                                               dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString()
                                           };
                             var orddisc =
                                   DataAccess.ReturnField(
                                       "SELECT ORD_DISP FROM dbo.SIPPORD ",
                                       "ORM_REF", cond, 0);
                            Decimal tempDiscP;
                          
                            if (string.IsNullOrEmpty(orddisc))
                            {
                                   orddisc = DataAccess.ReturnField(
                                       "SELECT ORD_DISP FROM dbo.SIPPORD ",
                                       "ORM_REF", cond, 0);
                                tempDiscP = Sub_0rd - Convert.ToDecimal(orddisc);
                            }
                            else
                            {
                                tempDiscP = (Sub_0rd * Convert.ToDecimal(orddisc)) / 100;
                            }

                            var TOTAL = Sub_0rd - tempDiscP;
//                            ================== Update Split Line ===============
                            command.CommandText =
                                "UPDATE dbo.SIPPORD SET ORD_QTY = @ORD_QTY, ORD_STOCK = @ORD_STOCK, ORD_SUB = @ORD_SUB, ORD_DISA = @ORD_DISA, ORD_TOT = @ORD_TOT  WHERE ORM_REF = @ORM_REF AND ORD_LINE = @ORD_LINE";
                            Commands.CreateParameter(command, "ORD_QTY", ord_Qty, "ORD_STOCK", ord_Stock, "ORD_SUB", Sub_0rd, "ORD_DISA", tempDiscP, "ORD_TOT", TOTAL, "ORM_REF", txtGRN_ref.Text, "ORD_LINE",dataGridViewX1.SelectedRows[0].Cells[1].Value);
                            var d = command.ExecuteNonQuery();
                            if (d == 0)
                            {
                                MessageBox.Show("There aren't data to update");
                            }
//                            ================== Insert Split line ===========
                            
                            command.CommandText = "SI_INSERT_SIPPORD";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            var ord_Sub = Convert.ToDecimal(stock_OldQty)*Convert.ToDecimal(purchase_Cost);

                            var ord_disc =
                                   DataAccess.ReturnField(
                                       "SELECT ORD_DISP FROM dbo.SIPPORD ",
                                       "ORM_REF", cond, 0);

                            Decimal temp_DiscP;
                            if (ord_disc == "")
                            {
                                ord_disc =
                                    DataAccess.ReturnField(
                                        "SELECT ORD_DISA FROM dbo.SIPPORD ",
                                        "ORM_REF", cond, 0);
                                temp_DiscP = ord_Sub - Convert.ToDecimal(ord_disc);
                            }
                            else
                            {
                                temp_DiscP = (ord_Sub * Convert.ToDecimal(ord_disc)) / 100;
                            }

                            var total = ord_Sub - temp_DiscP;

                            Commands.CreateParameter(command, "ORM_REF_1", txtGRN_ref.Text, "ORD_LINE_2",
                                                     line_Ref,
                                                     "LOC_CODE_3",
                                                     dataGridViewX1.SelectedRows[0].Cells[2].Value.ToString(),
                                                     "ITEM_CODE_4",
                                                     dataGridViewX1.SelectedRows[0].Cells[3].Value.ToString(),
                                                     "ORD_UNIT_5",
                                                     dataGridViewX1.SelectedRows[0].Cells[5].Value.ToString(),
                                                     "ORD_QTY_6",
                                                     Convert.ToInt16(stock_OldQty),
                                                     "ORD_STOCK_7", Convert.ToDecimal(stock_NewQty), "ORD_COST_8",
                                                     purchase_Cost,
                                                     "ORD_SUB_9", ord_Sub,
                                                     "ORD_DISP_10", ord_disc,
                                                     "ORD_DISA_11", temp_DiscP, "ORD_TOT_12",
                                                     total,
                                                     "ORD_STAT_13", "A", "ORD_TYPE_14", "P");
                                command.ExecuteNonQuery();




                            dataGridViewX1.SelectedRows[0].Cells[6].Value =
                                Convert.ToString(Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[6].Value) -
                                                 Convert.ToDecimal(sisoplit_Frm.txtSplit.Text));
                            dataGridViewX1.SelectedRows[0].Cells[7].Value = Convert.ToString(Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[7].Value) - Convert.ToDecimal(stock_NewQty));//string.Format("{0:0.00}", stock_NewQty);
                            dataGridViewX1.SelectedRows[0].Cells[8].Value = purchase_Cost;
                            
//                           

                            dataGridViewX1.Rows[dataGridViewX1.SelectedRows[0].Index + 1].Selected = true;
                            dataGridViewX1_CellContentClick(null, null);
                            Cursor = Cursors.Default;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
            

        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewX1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewX1.Rows)
                {
                    if (chkAll.Checked == true)
                        row.Cells[0].Value = true;
                    else
                        row.Cells[0].Value = false;
                }
                dataGridViewX1.EndEdit();
                dataGridViewX1_CellContentClick(null, null);
            }
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewX1.EndEdit();
            var d = dataGridViewX1.SelectedRows.Count;
            var da = dataGridViewX1.SelectedRows[0].Cells[8].Value.ToString();
            if (Decimal.Parse(dataGridViewX1.SelectedRows[0].Cells[8].Value.ToString()) > 0)            {

                //                for (int i = 0; i < dataGridViewX1.Rows.Count -1; i++)
                //                {
                //                    var ddd = dataGridViewX1.Rows[i].Cells[0].Value;
                //                }
                lblDebit_val.Text = SIDataGridView.SumDataOnSelectedGrid(dataGridViewX1, 8, e).ToString();
            }
            lblDebitQty.Text = SIDataGridView.SumDataOnSelectedGrid(dataGridViewX1, 6, e).ToString();


            MAKE_CHANGE = true;
        }

        private void dataGridViewX1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewX1_CellContentClick(null, null);
        }

        private void tool_debitNote_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.DebitNote, "V", subMenuItems.PostDebitNote, true) ==
                   false)
                return;
            if (SITempData.PO_AUTO_NUM == "Y")
            {
                if (Condition.EmptyControl(txtDebit_Ref))
                {
                    return;
                }
                int S1 = 0;
                for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                {
                    DataGridViewCell cell = dataGridViewX1.Rows[i].Cells[0];
                    var check = (bool)cell.EditedFormattedValue;
                    if (check == true)
                    {
                        S1 = S1 + 1;
                    }
                }
                if (S1 == 0)
                {
                    MessageBox.Show("Please check item for debit note!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to debit note this purchase invoice?", "Debit Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Insert into purchase order new line
                    SqlCommand command = new SqlCommand("", connection.Connect());
                   
                    try
                    {
                        if (SITempData.PO_AUTO_NUM == "Y")
                            {
                                //                ====== Auto(Number)
                                //                PO_PREFIX = "!Y!!MM!";
                                PO_PREFIX = "";
                                PO_SUFFIX = "";
                                PO_INTERVAL = 1;
                                PO_LENGHT = 10;
                                PO_START = 1;
                                var dt = dataManager.GetData("SELECT SI_DATA FROM SIPDATA", "SI_DATA", "SI_TYPE",
                                                             "AUTON", "SI_CODE",
                                                             "PM");
                                if (dt.Rows.Count > 0)
                                {
                                    //                    ========= For purchase Order
                                    string ss = dt.Rows[0][0].ToString();
                                    PO_INTERVAL = Convert.ToInt16(ss.Substring(20, 5).Trim());
                                    PO_LENGHT = Convert.ToInt16(ss.Substring(25, 2).Trim());
                                    PO_START = Convert.ToInt16(ss.Substring(27, 5).Trim());
                                }
                                else
                                {
                                    MessageBox.Show("You must set auto number format first!", "", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                                    return;
                                }
                                var generator = new Generator();

                                string P = generator.Prefix(PO_PREFIX);
                                string S = generator.Prefix(PO_SUFFIX);

                                TRANS_REF =
                                    generator.ID(
                                        "SELECT MAX(SEQUENCE) FROM SIPINMOV WHERE LEFT(SEQUENCE," + P.Length + ")='" + P +
                                        "' AND RIGHT(SEQUENCE," + S.Length + ")='" + S + "'",
                                        PO_LENGHT - (P.Length + S.Length), P, S,
                                        PO_START, PO_INTERVAL);
                                txtInvoice_Ref.Text = TRANS_REF;
                            }


                        for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                        {
                            DataGridViewCell cell = dataGridViewX1.Rows[i].Cells[0];
                            var check = (bool)cell.EditedFormattedValue;
                            if (check)
                            {
                                Decimal DL = -1 * Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[6].Value) *
                                             Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[8].Value);
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "SI_INSERT_SIPINMOV";
                                command.Parameters.Clear();
                               
                                Commands.CreateParameter(command, "SEQUENCE_1", txtInvoice_Ref.Text, "REC_TYPE_2",
                                                         "P",
                                                         "MOV_DATE_3", DateTime.Now,
                                                         "MOV_REF_4", txtGRN_ref.Text,
                                                         "MOV_LINE_5",
                                                         sisipinmov.Return_Line_Ref(txtGRN_ref.Text),
                                                         "LOCATION_6",
                                                         dataGridViewX1.Rows[i].Cells[2].Value,
                                                         "ITEM_CODE_7",
                                                         dataGridViewX1.Rows[i].Cells[3].Value,
                                                         "STATUS_8", "80", "IR_STAT_9", "R",
                                                         "LINE_REF_10", "",
                                                         "QUANTITY_11",
                                                         -1* Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[7].Value), "COST_12",
                                                         DL/Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[7].Value),
                                                         "TOTAL_13", DL,
                                                         "MOV_UNITS_14",
                                                         dataGridViewX1.Rows[i].Cells[11].Value,
                                                         "MOV_TYPE_15", "", "ALLOC_REF_16", "",
                                                         "ORIG_LINE_NO_17",
                                                         dataGridViewX1.Rows[i].Cells[1].Value,
                                                         "PO_VALUE_18", 0,
                                                         "ID_ENTERED_19", UserLogOn.Code,
                                                         "ID_ALLOC_20", UserLogOn.Code, "ITEM_EXP_21", 0);
                                command.ExecuteNonQuery();

//                                =========================  INSERT SIPPORD ================

                                command.CommandText = "SI_INSERT_SIPPORD";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();

                                var ord_Sub = Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[6].Value.ToString())*
                                                          Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[8].Value.ToString());
                                var cond = new string[]
                                               {
                                                   "ORD_LINE", dataGridViewX1.Rows[i].Cells[1].Value.ToString(),
                                                   "ORM_REF", txtGRN_ref.Text
                                               };
                                            
                                var ord_disc = 
                                    DataAccess.ReturnField(
                                        "SELECT ORD_DISP FROM dbo.SIPPORD ",
                                        "ORM_REF", cond ,0);

                                Decimal temp_DiscP;
                                if (ord_disc  == "")
                                {
                                    ord_disc =
                                        DataAccess.ReturnField(
                                            "SELECT ORD_DISA FROM dbo.SIPPORD ",
                                            "ORM_REF", cond, 0);
                                    temp_DiscP = ord_Sub - Convert.ToDecimal(ord_disc);
                                }
                                else
                                {
                                    temp_DiscP = (ord_Sub*Convert.ToDecimal(ord_disc))/100;
                                }

                                var total = ord_Sub - temp_DiscP;
                                Commands.CreateParameter(command, "ORM_REF_1", txtGRN_ref.Text, "ORD_LINE_2",
                                                         debitNote.Return_Line_Ref(txtGRN_ref.Text),
                                                         "LOC_CODE_3", dataGridViewX1.Rows[i].Cells[2].Value.ToString(),
                                                         "ITEM_CODE_4",
                                                         dataGridViewX1.Rows[i].Cells[3].Value.ToString(),
                                                         "ORD_UNIT_5", dataGridViewX1.Rows[i].Cells[5].Value.ToString(),
                                                         "ORD_QTY_6",
                                                         -1*
                                                         Convert.ToDecimal(
                                                             dataGridViewX1.Rows[i].Cells[6].Value.ToString()),
                                                         "ORD_STOCK_7",
                                                         -1*
                                                         Convert.ToDecimal(
                                                             dataGridViewX1.Rows[i].Cells[7].Value.ToString()),
                                                         "ORD_COST_8",
                                                         Convert.ToDecimal(
                                                             dataGridViewX1.Rows[i].Cells[8].Value.ToString()),
                                                         "ORD_SUB_9", -1*ord_Sub,
                                                         "ORD_DISP_10", ord_disc,
                                                         "ORD_DISA_11", temp_DiscP, "ORD_TOT_12",
                                                         -1*total,
                                                         "ORD_STAT_13", "N", "ORD_TYPE_14", "P");
                                command.ExecuteNonQuery();


                                command.CommandType = CommandType.Text;


                                command.CommandType = CommandType.Text;
                                command.CommandText = "UPDATE dbo.SIPPORD SET ORD_STAT = 'N' WHERE ORM_REF='" + txtGRN_ref.Text + "' AND ORD_LINE='" + dataGridViewX1.Rows[i].Cells[1].Value.ToString() + "'";
                                command.ExecuteNonQuery();
//                                ======================================  update  SIPPORM ===============

                                
                                var condition = new string[] {"ORM_REF", txtGRN_ref.Text};
                                var ORMTotal = DataAccess.ReturnField("SELECT ORM_TOTAI FROM dbo.SIPPORM", "ORM_REF",
                                                                       condition, 0);
                                Decimal ORm_VAT;
                                Decimal ORM_Grand;
                                   
                                var ORM_Total = Convert.ToDecimal(ORMTotal) - total;
                                ORm_VAT = Convert.ToDecimal(ORM_Total)*10/100;
                                ORM_Grand = ORM_Total + ORm_VAT;
                                command.CommandType = CommandType.Text;
                                command.CommandText = "UPDATE dbo.SIPPORM SET ORM_TOTAI = @ORM_TOTAI, ORM_VAT = @ORM_VAT, ORM_GRAND = @ORM_GRAND WHERE ORM_REF = @ORM_REF";
                                command.Parameters.Clear();
                                Commands.CreateParameter(command, "ORM_TOTAI", ORM_Total, "ORM_VAT", ORm_VAT,
                                                         "ORM_GRAND", ORM_Grand, "ORM_REF", txtGRN_ref.Text);
                                command.ExecuteNonQuery();

                                var dtORM = dataManager.GetData(" SELECT * FROM dbo.SIPPORD Where ORD_STAT = 'A'");
                                if (dtORM.Rows.Count == 0)
                                {
                                    command.CommandType = CommandType.Text;
                                    command.CommandText = "UPDATE dbo.SIPPORM SET ORM_STAT ='4' WHERE ORM_REF = '" +
                                                          txtGRN_ref.Text + "'";
                                    command.ExecuteNonQuery();
                                    
                                }
                            }
                        }

//                        ============= Print Report ==============
                        Report report = new Reports.Report();
                        var dtDebitNote =
                            dataManager.GetData("SELECT * FROM V_DEBITNOTE_PRINT where [Order Code] = '" +
                                                txtOrder_ref.Text + "'");
                        if (dtDebitNote.Rows.Count > 0)
                        {
                            report.Preview("Print Debit Note Form", dtDebitNote);    
                        }
                        else
                        {
                            MessageBox.Show("No data to print", "No Data", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            return;
                        }
                        
                        

                        Start_PurchaseInvoice();
                    }
                    catch (Exception ex)
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message);
                        
                    }
                       
                       
                }

            }
            #region Unused
            //    If MsgBox("Are you sure you want to debit note this purchase invoice?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        //        '==============Is Auto Number
        //        If PO_AUTO_NUM = "Y" Then
        //            Dim P As String = GeneratePrefix(PO_PREFIX)
        //            Dim S As String = GeneratePrefix(PO_SUFFIX)
        //            TRANS_REF = GenerateID("SELECT MAX(INV_REF) FROM " & DBCODE & "SIPOINV WHERE LEFT(INV_REF," & P.Length & ")='" & P & "' AND RIGHT(INV_REF," & S.Length & ")='" & S & "'", PO_LENGHT - (P.Length + S.Length), P, S, PO_START, PO_INTERVAL)
        //        Else
        //            'Check Primarykey INV_REF
        //            If Exists(CN, DBCODE & "SIPOINV", "INV_REF", txtDebit_Ref.Text) Then
        //                Me.Cursor = Cursors.Default
        //                MsgBox("Debit note reference is already exists !", MsgBoxStyle.Critical)
        //                txtDebit_Ref.SelectAll()
        //                txtDebit_Ref.Focus()
        //                Exit Sub
        //            End If
        //            TRANS_REF = txtDebit_Ref.Text
            //        End If
            #endregion

           
        }

        private void ToolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

    }
}
