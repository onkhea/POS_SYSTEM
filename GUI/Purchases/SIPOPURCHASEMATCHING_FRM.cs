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

namespace POS.GUI.Purchases
{
    public partial class SIPOPURCHASEMATCHING_FRM : Form //DevComponents.DotNetBar.Office2007Form
    {

        #region variable global

        Connection.Connection connection  = new Connection.Connection();
        public bool make_Change;
        readonly Server server = new Server();
        public bool IS_EDIT;
        public bool MAKE_CHANGE;
        public bool IS_UPDATE;
        private string status = "";
        readonly Utilities.Controls controls = new Controls();
        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        DataManager dataManager = new DataManager();
        private string PO_PREFIX = "";
        private string PO_SUFFIX = "";
        private Int16 PO_LENGHT;
        private Int16 PO_START;
        private string TRANS_REF = "";
        Int16 PO_INTERVAL; 

        #endregion

        public SIPOPURCHASEMATCHING_FRM()
        {
            InitializeComponent();
        }

        private void SIPOPURCHASEMATCHING_FRM_Load(object sender, EventArgs e)
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
                        txtRef.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void StartToolStripButton_Click(object sender, EventArgs e)
        {
            if (make_Change == true)
            {
                if (MessageBox.Show("Are you sure you want to start new transaction without release some changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    return;
                }
            }
            START_New();
        }

        private void START_New()
        {
            Cursor = Cursors.WaitCursor;
          
            MAKE_CHANGE = false;
            controls.ClearControl(txtCom,txtRef,txtOrder_Ref,txtSupName,txtSupCode,txtDelCode,txtDelName,lblMatchQty,
                lblMatchVal,lblOrderValue,lblorderQty);
            dataGridViewX1.Rows.Clear();
            controls.EnabledControlTrue(txtRef,txtCom);
            txtRef.Focus();
            Cursor = Cursors.Default;
        }

        private void PurchaseOrdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.PurchaseMatching, "V", subMenuItems.PurchaseOrder, true) ==
                    false)
                    return;
               var sipopurchaseorder_View = new SIPOPURCHASEORDER_View();
                sipopurchaseorder_View.TreeView1.Nodes.Clear();
                sipopurchaseorder_View.TreeView1.Nodes.Add("ReleaseM", "Release", 2).Tag = "ReleaseM";
                if (sipopurchaseorder_View.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    Cursor = Cursors.WaitCursor;
                    DataTable tblSIPPORM =
                        dataManager.GetData(
                            "SELECT (SELECT SUP_CODE FROM SIPPORM WHERE SIPPORM.ORM_REF=SIPPORD.ORM_REF) SUP_CODE,(SELECT DEL_CODE FROM SIPPORM WHERE SIPPORM.ORM_REF=SIPPORD.ORM_REF) DEL_CODE FROM SIPPORD",
                            "ORM_REF", "ORM_REF",
                            sipopurchaseorder_View.DataGridView1.Rows[sipopurchaseorder_View.SELECT_INDEX].Cells[0].Value.ToString());

                    if (tblSIPPORM.Rows.Count > 0)
                    {
                        txtOrder_Ref.Text =
                            sipopurchaseorder_View.DataGridView1.Rows[sipopurchaseorder_View.SELECT_INDEX].Cells[0].
                                Value.ToString();
                        lblOrderValue.Text =
                            sipopurchaseorder_View.DataGridView1.Rows[sipopurchaseorder_View.SELECT_INDEX].Cells[14].
                                Value.ToString();
                        dtpOrder_Date.CustomFormat = "";
                        dtpOrder_Date.Value =
                            sipopurchaseorder_View.DataGridView1.SelectedRows[0].Cells[1].Value.ToString() == ""
                                ? DateTime.Now
                                : Convert.ToDateTime(sipopurchaseorder_View.DataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                        dtpPayDate.CustomFormat = "";
                        dtpPayDate.Value = DateTime.Now;
                        dtpDelDate.CustomFormat = "";
                        txtSupCode.Text = tblSIPPORM.Rows[0][0].ToString();
                        var condition = new string[]
                                            {
                                                "ORM_REF",
                                                sipopurchaseorder_View.DataGridView1.SelectedRows[0].Cells[0].Value.
                                                    ToString()
                                            };
                        LBVAT.Text = DataAccess.ReturnField("SELECT ORM_VAT FROM SIPPORM", "ORM_REF", condition, 0);

                        var condSup = new string[] {"ADD_TYPE", "1", "ADD_CODE", txtSupCode.Text};
                        txtSupName.Text = DataAccess.ReturnField("SELECT ADD_NAME FROM dbo.SIPADDR", "ADD_NAME", condSup, 0);
                        txtDelCode.Text = tblSIPPORM.Rows[0][1].ToString();
                        var condDel = new string[] { "DEL_TYPE", "1", "DEL_CODE", txtDelCode.Text, "ADD_CODE", txtSupCode.Text };
                        txtDelName.Text = DataAccess.ReturnField("SELECT DEL_NAME FROM dbo.SIPDADD", "DEL_NAME", condDel,
                                                                 0);
                        txtRef.Text = "";
//                        ================== is Auto Number
                        if (SITempData.PO_AUTO_NUM == "Y")
                        {
                            txtRef.Enabled = false;
                        }

//                        =================  Add Order Detail
                        dataGridViewX1.Rows.Clear();
                        var tblOrder =
                            dataManager.GetData(
                                "SELECT ORD_LINE,LOC_CODE,ITEM_CODE,(SELECT ITEM_DESC FROM SIPITEMS WHERE SIPITEMS.ITEM_CODE=SIPPORD.ITEM_CODE) ITEM_DESC,ORM_REF,ORD_UNIT,ORD_QTY,ORD_STOCK,ORD_COST,ORD_SUB,ORD_DISA,ORD_TOT,ORD_LINE FROM SIPPORD",
                                "ORD_LINE", "ORD_STAT", "D", "ORM_REF", txtOrder_Ref.Text.Trim());
                        foreach (DataRow row in tblOrder.Rows)
                        {
                            dataGridViewX1.Rows.Add(false, row[0], row[1], row[2], row[3], row[4], row[5], row[6], 
                                row[7],row[8],row[9],row[10],row[11],row[12]);
                        }
                        lblorderQty.Text = SIDataGridView.Sum(dataGridViewX1, 7).ToString();
                        Cursor = Cursors.Default;
                    }
                }
                sipopurchaseorder_View.Close();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
           
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewX1.EndEdit();
            var d = dataGridViewX1.SelectedRows.Count;
            var da = dataGridViewX1.SelectedRows[0].Cells[12].Value.ToString();
            if (Decimal.Parse(dataGridViewX1.SelectedRows[0].Cells[12].Value.ToString()) > 0)
            {

//                for (int i = 0; i < dataGridViewX1.Rows.Count -1; i++)
//                {
//                    var ddd = dataGridViewX1.Rows[i].Cells[0].Value;
//                }
                lblMatchVal.Text = SIDataGridView.SumDataOnSelectedGrid(dataGridViewX1, 12,e).ToString();
            }
            lblMatchQty.Text = SIDataGridView.SumDataOnSelectedGrid(dataGridViewX1, 7,e).ToString();
            
          
            MAKE_CHANGE = true;
        }

        private void dataGridViewX1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           dataGridViewX1_CellContentClick(sender,e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewX1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewX1.Rows)
                {
                    if (checkBox1.Checked == true)
                        row.Cells[0].Value = true;
                    else
                        row.Cells[0].Value = false;
                }
                dataGridViewX1.EndEdit();
                dataGridViewX1_CellContentClick(null,null);
            }
        }

        private void SplitToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Strings strings = new Strings();
                if (security.CheckPermission(UserLogOn.Code, menuItems.PurchaseMatching, "V", subMenuItems.SplitLine, true) ==
                    false)
                    return;
                if (dataGridViewX1.SelectedRows.Count > 0)
                {
                    var value_S = 0;
                   var fixed_val = new short[2];
                    if (strings.IsNumeric(dataGridViewX1.SelectedRows[0].Cells[13].Value.ToString()))
                    {
                        value_S = Int16.Parse(dataGridViewX1.SelectedRows[0].Cells[13].Value.ToString());
                    }
                    if (value_S >= 0)
                    {
                       var sisosplit_FRM = new SISOSPLIT_FRM();
                       sisosplit_FRM.AMT = Decimal.Parse(dataGridViewX1.SelectedRows[0].Cells[7].Value.ToString());
                       sisosplit_FRM.txtField.Text = dataGridViewX1.Columns[7].HeaderText;
                       sisosplit_FRM.txtOldValue.Text = dataGridViewX1.SelectedRows[0].Cells[7].Value.ToString();

                        if (sisosplit_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            var fieldAndCon = new string[] {"ORD_STAT", "D"};
                            var line_No = DataAccess.ReturnField("SELECT MAX(ORD_LINE) FROM SIPPORD", "ORD_LINE",fieldAndCon,0);
                            if (line_No == "")
                            {
                                MessageBox.Show("There are no transaction present!", "", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                if (line_No.Trim().Length == 3)
                                {
                                    line_No = line_No.Trim() + "01";
                                }
                                else
                                {
                                    line_No = string.Format("00000", int.Parse(line_No) + 1);
                                }
                            }
                            Cursor = Cursors.WaitCursor;
                            Double Split_AMT = Double.Parse(sisosplit_FRM.txtSplit.Text);
//                            Double Rate = Double.Parse(string.Format("{0:0.00000}", Split_AMT / Convert.ToDouble(sisosplit_FRM.AMT)));
                          
                           var fieldAndVal = new string[] {"ITEM_CODE", dataGridViewX1.SelectedRows[0].Cells[3].Value.ToString()};

                            string Unit_Stock = DataAccess.ReturnField("SELECT UNIT_STOCK FROM SIPITEMS", "UNIT_STOCK",
                                                                       fieldAndVal,0);
                            DataTable tbl = dataManager.GetData("SELECT OPERATOR, FACTOR FROM SIUNITCONV", "FACTOR",
                                                                "CONV_FROM",
                                                                dataGridViewX1.SelectedRows[0].Cells[6].Value.ToString(),
                                                                "CONV_TO", Unit_Stock);

                            decimal stock_NewQty = 0;
                            Decimal stock_OldQty = Decimal.Parse(sisosplit_FRM.txtSplit.Text);

                            if (tbl.Rows.Count > 0)
                            {
                                switch (tbl.Rows[0][0].ToString())
                                {
                                    case "*" :
                                        stock_NewQty = Convert.ToDecimal(stock_OldQty)*Convert.ToDecimal(tbl.Rows[0][1]);
                                        break;
                                    case "/":
                                        stock_NewQty = Convert.ToDecimal(tbl.Rows[0][1])/Convert.ToDecimal(stock_OldQty);
                                        break;
                                }
                            }
                            var fieldAndCond = new string[] {"ORM_REF",dataGridViewX1.SelectedRows[0].Cells[5].Value.ToString(),"ORD_LINE",dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString()};
                            var discPer = DataAccess.ReturnField("SELECT ORD_DISP FROM dbo.SIPPORD", "ORM_REF",
                                                                 fieldAndCond,0);
                            
                            dataGridViewX1.SelectedRows[0].Cells[7].Value = sisosplit_FRM.txtSplit.Text;
                            dataGridViewX1.SelectedRows[0].Cells[8].Value = string.Format("{0:0.00}",stock_NewQty);
                            dataGridViewX1.SelectedRows[0].Cells[10].Value =
                               Convert.ToString(Convert.ToInt16(sisosplit_FRM.txtSplit.Text) *
                                                Convert.ToDouble(
                                                    dataGridViewX1.SelectedRows[0].Cells[9].Value.ToString()));
                            dataGridViewX1.SelectedRows[0].Cells[11].Value =
                                Convert.ToString(Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[10].Value.ToString())* Convert.ToDecimal(discPer)/100);
                            var discUSD = "0";
                            if (discPer == "")
                            {
                                var fieldAndValue = new string[] {"ORM_REF",dataGridViewX1.SelectedRows[0].Cells[5].Value.ToString(),"ORD_LINE",dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString()};
                                discUSD = DataAccess.ReturnField("SELECT ORD_DISA FROM dbo.SIPPORD", "ORM_REF",
                                                                 fieldAndValue,0);
                                dataGridViewX1.SelectedRows[0].Cells[11].Value = discUSD;
                            }
                            else
                            {
                                dataGridViewX1.SelectedRows[0].Cells[12].Value =
                                    Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[10].Value) -
                                    Convert.ToDecimal(dataGridViewX1.SelectedRows[0].Cells[11].Value);
                            }
                           
                            Cursor = Cursors.Default;
                        }
                    }
                    else
                    {
                        MessageBox.Show("There are no value to split!", "", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
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
                if (security.CheckPermission(UserLogOn.Code, menuItems.PurchaseMatching, "V", subMenuItems.CancelLine, true) ==
                   false)
                    return;
                if (dataGridViewX1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to cancel this line?", "Cancel Line", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Cursor = Cursors.WaitCursor;
                        Int16 count = 0;
                        var command = new SqlCommand("", connection.Connect());
                        command.CommandType = CommandType.Text;
                        command.CommandText =
                            "UPDATE dbo.SIPPORD SET ORD_STAT = 'C' WHERE ORM_REF = @ORM_REF AND ORD_LINE = @ORD_LINE";
                        for (int i = 0; i < dataGridViewX1.SelectedRows.Count ; i++)
                        {
//                            DataGridViewCell cell = dataGridViewX1.Rows[i].Cells[0];
//                            var check = (bool) cell.EditedFormattedValue;
//                            if (check)
//                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@ORM_REF", dataGridViewX1.SelectedRows[0].Cells[5].Value);
                                command.Parameters.AddWithValue("@ORD_LINE", dataGridViewX1.SelectedRows[0].Cells[1].Value);
                                command.ExecuteNonQuery();
                                dataGridViewX1.Rows.RemoveAt(i);
//                            }
                        }
                        //                            ================ Refesh value ==========
                        dataGridViewX1_CellContentClick(null, null);
                        MessageBox.Show("This line was caceled successfully!", "", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(
                            "There are no line to cancel.\r\n" + "Make sure you have checked any records or not?",
                            "Cancel Line", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    security.CheckPermission(UserLogOn.Code, menuItems.PurchaseMatching, "V",
                                             subMenuItems.Release, true) ==
                    false)
                    return;
                if (SITempData.PO_AUTO_NUM == "Y")
                {
//                    if (Condition.EmptyControl(txtRef))
//                        return;
                    if (dataGridViewX1.Rows.Count > 0)
                    {
                        var bol = false;
                        for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                        {
                            DataGridViewCell cell = dataGridViewX1.Rows[i].Cells[0];
                            var check = (bool) cell.EditedFormattedValue;
                            if (check)
                            {
                                bol = check;
                                break;
                            }
                        }
                        if (bol ==false)
                            {
                                
                                Cursor = Cursors.Default;
                                MessageBox.Show("Please check any records to match!", "match", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                                return;
                            }
                        
                        Generator generator = new Generator();
                        var serverDate = server.Now();
                        if (
                            MessageBox.Show("Are you sure you want to release this matching?", "Release Matching",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                            System.Windows.Forms.DialogResult.Yes)
                        {
                            var command = new SqlCommand("", connection.Connect());
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandText = "SI_INSERT_SIPINMOV";
                            string Matching_Ref = txtRef.Text;
                            //                                ===============  Is Auto Number
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

                                string P = generator.Prefix(PO_PREFIX);
                                string S = generator.Prefix(PO_SUFFIX);

                                TRANS_REF =
                                    generator.ID(
                                        "SELECT MAX(SEQUENCE) FROM SIPINMOV WHERE LEFT(SEQUENCE," + P.Length + ")='" + P +
                                        "' AND RIGHT(SEQUENCE," + S.Length + ")='" + S + "'",
                                        PO_LENGHT - (P.Length + S.Length), P, S,
                                        PO_START, PO_INTERVAL);
                                txtRef.Text = TRANS_REF;
                            }

                            
                            for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                                {
                                    DataGridViewCell cell = dataGridViewX1.Rows[i].Cells[0];
                                    var check = (bool) cell.EditedFormattedValue;
                                    if (check)
                                    {
                                        Decimal DL = Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[7].Value)*
                                                     Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[9].Value);
                                        command.Parameters.Clear();
                                        var mov_line = 0;
                                        if (string.IsNullOrEmpty(DataAccess.ReturnField("SELECT MAX(CONVERT(INT,MOV_LINE)) + 1  FROM dbo.SIPINMOV ",0)))
                                        {
                                            mov_line = 1;
                                        }
                                        else
                                        {
                                            mov_line =
                                                Convert.ToInt32(
                                                    DataAccess.ReturnField(
                                                        "SELECT MAX(CONVERT(INT,MOV_LINE)) + 1  FROM dbo.SIPINMOV ", 0));
                                        }
                                        var condition = new string[]
                                                            {
                                                                "ITEM_CODE", dataGridViewX1.Rows[i].Cells[3].Value.ToString(),
                                                                "UNIT_SALE", dataGridViewX1.Rows[i].Cells[6].Value.ToString()
                                                            };
                                        var unitofStock = DataAccess.ReturnField("SELECT UNIT_STOCK FROM dbo.SIPITEMS",
                                                                                 "ITEM_CODE", condition, 0);
                                        Commands.CreateParameter(command, "SEQUENCE_1", txtRef.Text, "REC_TYPE_2",
                                                                 "P",
                                                                 "MOV_DATE_3", DateTime.Now,
                                                                 "MOV_REF_4", dataGridViewX1.Rows[i].Cells[5].Value,
                                                                 "MOV_LINE_5",
                                                                 string.Format("{0:0000}",mov_line),
                                                                 "LOCATION_6",
                                                                 dataGridViewX1.Rows[i].Cells[2].Value,
                                                                 "ITEM_CODE_7",
                                                                 dataGridViewX1.Rows[i].Cells[3].Value,
                                                                 "STATUS_8", "80", "IR_STAT_9", "I",
                                                                 "LINE_REF_10", "",
                                                                 "QUANTITY_11",
                                                                 Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[8].Value), "COST_12",
                                                                 Convert.ToDecimal(DL)/Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[8].Value),
                                                                 "TOTAL_13", DL,
                                                                 "MOV_UNITS_14",unitofStock
                                                                 ,
                                                                 "MOV_TYPE_15", "", "ALLOC_REF_16","", 	
                                                                 "ORIG_LINE_NO_17",
                                                                 dataGridViewX1.Rows[i].Cells[1].Value,
                                                                 "PO_VALUE_18", Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[8].Value),
                                                                 "ID_ENTERED_19", UserLogOn.Code,
                                                                 "ID_ALLOC_20", UserLogOn.Code, "ITEM_EXP_21", 0);
                                        var dassd = Convert.ToDecimal(DL)/
                                                    Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[8].Value);
                                        command.ExecuteNonQuery();

//                                        ==============================  update data to SIPPORD Table ============
                                        
                                        command.Parameters.Clear();

                                        var cmd =
                                            new SqlCommand("SELECT * FROM dbo.SIPPORD WHERE ORM_REF = '" +
                                                           dataGridViewX1.Rows[i].Cells[5].Value.ToString() +
                                                           "' AND ORD_LINE = '" +
                                                           dataGridViewX1.Rows[i].Cells[1].Value.ToString() + "'",connection.Connect());
                                        var dtOrderDetial = dataManager.GetData(cmd);
                                        foreach (DataRow row in dtOrderDetial.Rows)
                                        {
                                            if (Convert.ToDecimal(row[6].ToString()) != Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[7].Value))
                                            {
                                                var POQty =  decimal.Parse(row[6].ToString()) - decimal.Parse(dataGridViewX1.Rows[i].Cells[7].Value.ToString());

                                                var POStockQty = decimal.Parse(row[7].ToString()) - decimal.Parse(dataGridViewX1.Rows[i].Cells[8].Value.ToString());

                                                var subToTal = decimal.Parse(row[9].ToString()) -
                                                               decimal.Parse(dataGridViewX1.Rows[i].Cells[10].Value.ToString());
                                                decimal disc;
                                                if (Convert.ToDecimal(row[10]) !=  0)
                                                {
                                                    disc = subToTal*decimal.Parse(row[10].ToString())/100;
                                                }
                                                else
                                                {
                                                    disc = decimal.Parse(row[11].ToString());
                                                }

                                                var total = subToTal - disc;

//                                                =================  split item in sippord
                                                var ord_Ref = dataGridViewX1.Rows[i].Cells[5].Value.ToString();
                                                var ord_Line = dataGridViewX1.Rows[i].Cells[1].Value.ToString();
                                                var comd =
                                                    new SqlCommand(
                                                        "Update SIPPORD SET ORD_QTY = @ORD_QTY, ORD_STOCK=@ORD_STOCK,ORD_SUB=@ORD_SUB,ORD_DISA =@ORD_DISA,ORD_TOT=@ORD_TOT WHERE ORM_REF ='" +
                                                       ord_Ref + "' AND ORD_LINE ='" + ord_Line
                                                        + "'", connection.Connect());
                                                Commands.CreateParameter(comd, "ORD_QTY", POQty, "ORD_STOCK", POStockQty,
                                                                         "ORD_SUB", subToTal, "ORD_DISA", disc,
                                                                         "ORD_TOT", total);
                                                comd.ExecuteNonQuery();
                                                
                                                command.CommandText = "SI_INSERT_SIPPORD";
                                                command.CommandType = CommandType.StoredProcedure;
                                                command.Parameters.Clear();
                                                
                                                var dtordetail = dataManager.GetData("Select * from dbo.SIPPORD ",
                                                                                     "ORD_LINE", "ORM_REF",dataGridViewX1.Rows[i].Cells[5].Value.ToString());
                                                Commands.CreateParameter(command, "ORM_REF_1", dataGridViewX1.Rows[i].Cells[5].Value, "ORD_LINE_2",
                                                                         string.Format("{0:000}",dtordetail.Rows.Count + 1),
                                                                         "LOC_CODE_3", dataGridViewX1.Rows[i].Cells[2].Value, "ITEM_CODE_4",
                                                                         dataGridViewX1.Rows[i].Cells[3].Value,
                                                                         "ORD_UNIT_5", dataGridViewX1.Rows[i].Cells[6].Value, "ORD_QTY_6",
                                                                         Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[7].Value),
                                                                         "ORD_STOCK_7", Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[8].Value), "ORD_COST_8",
                                                                         Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[9].Value),
                                                                         "ORD_SUB_9", Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[10].Value),
                                                                         "ORD_DISP_10",
                                                                         Convert.ToDecimal(row[10].ToString()),
                                                                         "ORD_DISA_11", Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[11].Value), "ORD_TOT_12",
                                                                         Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[12].Value),
                                                                         "ORD_STAT_13", "A", "ORD_TYPE_14", "P");
                                                command.ExecuteNonQuery();


                                            }
                                            else
                                            {
                                                var ord_Ref = dataGridViewX1.Rows[i].Cells[5].Value.ToString();
                                                var ord_Line = dataGridViewX1.Rows[i].Cells[1].Value.ToString();
                                                var sqlCmd = new SqlCommand("Update dbo.SIPPORD SET ORD_STAT = 'A' WHERE ORM_REF ='" +
                                                       ord_Ref + "' AND ORD_LINE ='" + ord_Line
                                                        + "'", connection.Connect());
                                                sqlCmd.ExecuteNonQuery();

                                                sqlCmd = new SqlCommand("SELECT * FROM SIPPORD WHERE ORD_STAT = 'D' AND ORM_REF ='" +
                                                       ord_Ref + "'", connection.Connect());
                                                var dt = dataManager.GetData(sqlCmd);
                                                if (dt.Rows.Count == 0)
                                                {
                                                    sqlCmd = new SqlCommand("Update SIPPORM SET ORM_STAT = 3 WHERE ORM_REF = '" + ord_Ref + "'",connection.Connect());
                                                    sqlCmd.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                }

                            START_New();
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

        private void CloseToolStripButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
