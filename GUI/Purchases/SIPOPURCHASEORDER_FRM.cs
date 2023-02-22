using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Reports;
using POS.Transaction;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Purchases
{
    public partial class SIPOPURCHASEORDER_FRM :  Form //DevComponents.DotNetBar.Office2007Form
    {
        public SIPOPURCHASEORDER_FRM()
        {
            InitializeComponent();
        }

        #region Global Variable

        public bool IS_EDIT;
        public bool MAKE_CHANGE;
        public bool IS_UPDATE;
//        private string PO_AUTO_NUM = "";
        readonly DataManager dataManager = new DataManager();
        readonly Server server = new Server();
        readonly Utilities.Controls controls = new Controls();
        private string status = "";
        public string[] S = new string[53];
        readonly string[] CAL = new string[49]; // For Calculation value
        readonly Int16[] CAL_DEC = new short[16];// For Calculation value
        readonly Strings strings = new Strings();
        private int LINE_VAL_DECIMAL = SITempData.DB_SB_DECIMAL;
        public int Pur_L_Val, Pur_C_Val, Pur_S_Val, Pur_M_val1, Pur_M_val2, Pur_M_val3, Pur_M_val4, Pur_F_Val1, Pur_F_Val2, Pur_F_Val3;
        private string PO_PREFIX = "";
        private string PO_SUFFIX = "";
        private Int16 PO_LENGHT;
        private Int16 PO_START;
        Int16 PO_INTERVAL;  //Auto Number Sale Order
        readonly Connection.Connection connnection = new Connection.Connection();
        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        readonly Generator generator = new Generator();
        private string TRANS_REF = "";
        private readonly ArrayList DELR = new ArrayList();
        private bool is_Delete = false;

        #endregion

        private void SIPOPURCHASEORDER_FRM_Load(object sender, EventArgs e)
        {

//            controls.AddEventHandler(txtDelAdd1, txtDelAdd2, txtDelAdd3, txtDelAdd4, txtDelAdd5, txtComment, txt_p_orderN, dtpOrder_Date);
            try
            {
                var dt = dataManager.GetData("SELECT SI_LOOKUP FROM SIPDATA ", "SI_CODE", "SI_CODE", "PO",
                                             "SI_TYPE", "AUTOP");
                if (dt.Rows.Count > 0)
                {
                    SITempData.PO_AUTO_NUM = dt.Rows[0][0].ToString().Substring(0, 1);
                    if (SITempData.PO_AUTO_NUM == "Y")
                    {
                        txt_p_orderN.Enabled = false;
                    }
                }
                START_PURCHASEORDER();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void START_PURCHASEORDER()
        {
            try
            {
                //                =========== Note: Refactoring Here

                //                dtpOrder_Date.Value = UserLogOn.Date;
                dtpOrder_Date.Value = DateTime.Now;
                if (UserLogOn.DB_DEFAULTDATE == "C")
                {
                    var S_Date = Convert.ToDateTime(server.Now());
                    dtpOrder_Date.Value = S_Date;
                }
                panel1.Enabled = true;
                panel2.Enabled = true;
                IS_UPDATE = false;
                MAKE_CHANGE = false;
                status = "";
                txtGrandTotal.Text = "0.00";
                txtComment.Text = "";
                txtDiscountA.Text = "0.00";
                txtVAT.Text = "0.00";
                txtTotalA.Text = "0.00";
                txt_p_orderN.Text = "";
                panel4.Enabled = false;
                panel5.Enabled = false;
                controls.ClearControl(txtSupCode, txtSupName, txtSupAdd1, txtSupAdd2, txtSupAdd3, txtSupAdd4, txtSupAdd5);
                controls.ClearControl(txtDelCode, txtDelName, txtDelAdd1, txtDelAdd2, txtDelAdd3, txtDelAdd4, txtDelAdd5);
                dataGridView.Rows.Clear();
                var main_FRM = new MAIN_FRM();
                main_FRM.StatusStrip.Items[0].Text = "Ready";
                txt_p_orderN.SelectAll();
                txt_p_orderN.Focus();
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

        private void SIPOPURCHASEORDER_FRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MAKE_CHANGE)
            {
                if (MessageBox.Show("Are you sure you want to close without holding some change?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }

            }
        }

        private void Transcation_Type(string Type_Code)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Pur_L_Val = 0;
                Pur_C_Val = 0;
                Pur_S_Val = 0;
                Pur_M_val1 = 0;
                Pur_M_val2 = 0;
                Pur_M_val3 = 0;
                Pur_F_Val1 = 0;
                Pur_F_Val2 = 0;
                Pur_F_Val3 = 0;
                var dt =
                    dataManager.GetData(
                        "SELECT SI_CODE, SUBSTRING(SI_DATA,1,30) SI1, SUBSTRING(SI_DATA,31,1) SI2, SUBSTRING(SI_DATA,32,1) SI3, SUBSTRING(SI_DATA,33,1) SI4, SUBSTRING(SI_DATA,34,1) SI5, SUBSTRING(SI_DATA,35,1) SI6, SUBSTRING(SI_DATA,36,1) SI7, SUBSTRING(SI_DATA,37,1) SI8, SUBSTRING(SI_DATA,38,10) SI9, SUBSTRING(SI_DATA,48,30) SI10, SUBSTRING(SI_DATA,78,5) SI11, SUBSTRING(SI_DATA,83,5) SI12, SUBSTRING(SI_DATA,88,40) ANAL, SUBSTRING(SI_DATA,128,170) CAL FROM SIPDATA",
                        "SI_CODE", "SI_TYPE", "PTDEF", "CODE", Type_Code);
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    S[0] = row[0].ToString();
                    S[1] = row[1].ToString().Trim();
                    S[2] = row[2].ToString(); // ORDER/INVOICE STAR
                    S[3] = row[3].ToString(); // UPDATE STOCK
                    S[4] = row[4].ToString(); // DELIVERY DUE DATE
                    S[5] = row[5].ToString(); // ACCOUNT CODE PER LINE
                    S[6] = row[6].ToString(); // PERFERNCE LINE
                    S[7] = row[7].ToString(); // ASSET CODE PER LINE
                    S[8] = row[8].ToString(); // PRINT ORDER OR NOT
                    S[9] = row[9].ToString().Trim(); // FORM PRINT ORDER
                    S[10] = row[10].ToString().Trim(); // COST TOLERENT
                    S[11] = row[11].ToString().Trim(); // INTERFACE IVNOICE
                    S[12] = row[12].ToString().Trim(); // INTERFACE STOCK

                    #region Analysis Header
                    // Analysis Header
                    S[13] = row[13].ToString().Substring(0, 1);
                    S[14] = row[13].ToString().Substring(1, 1).Trim();
                    S[15] = row[14].ToString().Substring(2, 1);
                    S[16] = row[13].ToString().Substring(3, 1).Trim();
                    S[17] = row[13].ToString().Substring(4, 1);
                    S[18] = row[13].ToString().Substring(5, 1).Trim();
                    S[19] = row[13].ToString().Substring(6, 1);
                    S[20] = row[13].ToString().Substring(7, 1).Trim();
                    S[21] = row[13].ToString().Substring(8, 1);
                    S[22] = row[13].ToString().Substring(9, 1).Trim();
                    S[23] = row[13].ToString().Substring(10, 1);
                    S[24] = row[13].ToString().Substring(11, 1).Trim();
                    S[25] = row[13].ToString().Substring(12, 1);
                    S[26] = row[13].ToString().Substring(13, 1).Trim();
                    S[27] = row[13].ToString().Substring(14, 1);
                    S[28] = row[13].ToString().Substring(15, 1).Trim();
                    S[29] = row[13].ToString().Substring(16, 1);
                    S[30] = row[13].ToString().Substring(17, 1).Trim();
                    S[31] = row[13].ToString().Substring(18, 1);
                    S[32] = row[13].ToString().Substring(19, 1).Trim();

                    #endregion

                    #region By Line
                    // By line
                    S[33] = row[13].ToString().Substring(20, 1);
                    S[34] = row[13].ToString().Substring(21, 1).Trim();
                    S[35] = row[13].ToString().Substring(22, 1);
                    S[36] = row[13].ToString().Substring(23, 1).Trim();
                    S[37] = row[13].ToString().Substring(24, 1);
                    S[38] = row[13].ToString().Substring(25, 1).Trim();
                    S[39] = row[13].ToString().Substring(26, 1);
                    S[40] = row[13].ToString().Substring(27, 1).Trim();
                    S[41] = row[13].ToString().Substring(28, 1);
                    S[42] = row[13].ToString().Substring(29, 1).Trim();
                    S[43] = row[13].ToString().Substring(30, 1);
                    S[44] = row[13].ToString().Substring(31, 1).Trim();
                    S[45] = row[13].ToString().Substring(32, 1);
                    S[46] = row[13].ToString().Substring(33, 1).Trim();
                    S[47] = row[13].ToString().Substring(34, 1);
                    S[48] = row[13].ToString().Substring(35, 1).Trim();
                    S[49] = row[13].ToString().Substring(36, 1);
                    S[50] = row[13].ToString().Substring(37, 1).Trim();
                    S[51] = row[13].ToString().Substring(38, 1);
                    S[52] = row[13].ToString().Substring(39, 1).Trim();
                    S[53] = row[13].ToString();

                    #endregion

                    #region Calculation Code
                    // Calculation code
                    CAL[0] = S[53].ToString().Substring(0, 5).Trim(); // Purchase Qty
                    CAL[1] = S[53].ToString().Substring(5, 1).Trim(); // Purchase Qty
                    CAL[2] = S[53].ToString().Substring(6, 5).Trim(); // Purchase Stock
                    CAL[3] = S[53].ToString().Substring(11, 1).Trim();// Purchase Stock
                    CAL[4] = S[53].Substring(12, 5).Trim();// Purchase Cost
                    CAL[5] = S[53].Substring(17, 1).Trim();// Purchase Cost
                    CAL[6] = S[53].Substring(18, 5).Trim();
                    CAL[7] = S[53].Substring(23, 1).Trim();
                    CAL[8] = S[53].Substring(24, 5).Trim();
                    CAL[9] = S[53].Substring(29, 1).Trim();
                    CAL[10] = S[53].Substring(30, 5).Trim();
                    CAL[11] = S[53].Substring(35, 1).Trim();
                    CAL[12] = S[53].Substring(36, 5).Trim();
                    CAL[13] = S[53].Substring(41, 1).Trim();
                    CAL[14] = S[53].Substring(42, 5).Trim();
                    CAL[15] = S[53].Substring(47, 1).Trim();
                    CAL[16] = S[53].Substring(48, 5).Trim();
                    CAL[17] = S[53].Substring(53, 1).Trim();
                    CAL[18] = S[53].Substring(54, 5).Trim();
                    CAL[19] = S[53].Substring(53, 1).Trim(); // NOTE: IF error data maybe change here substring(55,1);
                    CAL[20] = S[53].Substring(60, 5).Trim();
                    CAL[21] = S[53].Substring(65, 1).Trim();
                    CAL[22] = S[53].Substring(66, 5).Trim();
                    CAL[23] = S[53].Substring(71, 1).Trim();
                    CAL[24] = S[53].Substring(72, 5).Trim();
                    CAL[25] = S[53].Substring(77, 1).Trim();
                    CAL[26] = S[53].Substring(78, 5).Trim();
                    CAL[27] = S[53].Substring(83, 1).Trim();
                    CAL[28] = S[53].Substring(84, 5).Trim();
                    CAL[29] = S[53].Substring(89, 1).Trim();
                    CAL[30] = S[53].Substring(90, 5).Trim();
                    CAL[31] = S[53].Substring(95, 1).Trim();
                    CAL[32] = S[53].Substring(96, 5).Trim();
                    CAL[33] = S[53].Substring(101, 1).Trim();
                    CAL[34] = S[53].Substring(102, 5).Trim();
                    CAL[35] = S[53].Substring(107, 1).Trim();
                    CAL[36] = S[53].Substring(108, 5).Trim();
                    CAL[37] = S[53].Substring(113, 1).Trim();
                    CAL[38] = S[53].Substring(114, 5).Trim();
                    CAL[39] = S[53].Substring(119, 1).Trim();

                    #endregion

                    #region Header Calculation
                    // Header calculation
                    CAL[40] = S[53].Substring(120, 5).Trim(); // Line and check value
                    CAL[41] = S[53].Substring(125, 5).Trim(); // Line and check value
                    CAL[42] = S[53].Substring(130, 5).Trim(); // Match val1 and split values
                    CAL[43] = S[53].Substring(135, 5).Trim(); // Match val1 and split values  
                    CAL[44] = S[53].Substring(140, 5).Trim(); // Match val2 and fixed value1
                    CAL[45] = S[53].Substring(145, 5).Trim(); // Match val2 and fixed value1
                    CAL[46] = S[53].Substring(150, 5).Trim(); // Match val3 and fixed value2
                    CAL[47] = S[53].Substring(155, 5).Trim(); // Match val3 and fixed value2
                    CAL[48] = S[53].Substring(160, 5).Trim(); // Match val4 and fixed value3
                    CAL[49] = S[53].Substring(165, 5).Trim(); // Match val4 and fixed value4

                    #endregion

                    Int16 NumValue = 0;
                    for (int i = 0; i < 16; i++)
                    {
                        dataGridView.Columns[10 + i].Visible = false;
                        CAL_DEC[i] = SITempData.DB_SB_DECIMAL;
                        if (CAL[6 + i * 2] != "" && CAL[6 + i * 2 + 1] != "H")
                        {
                            var condition = new string[]
                                                {
                                                    "SI_TYPE", "CALDE",
                                                    "CODE", CAL[6 + i*2]
                                                };
                            dataGridView.Columns[10 + i].HeaderText =
                                DataAccess.ReturnField("SELECT SI_LOOKUP FROM SIDATA", "SI_TYPE", condition, 0);
                            NumValue += 1;
                            dataGridView.Columns[10 + i].Visible = true;
                            //Calculation value decimal place
                            var tblCal = dataManager.GetData("SELECT SI_DATA FROM SIDATA", "SI_TYPE", "SI_TYPE", "CALDE", "CODE", CAL[6 + (i * 2)]);
                            if (tblCal.Rows.Count > 0)
                            {
                                string str = tblCal.Rows[0][0].ToString().Substring(110, 1).Trim();
                                if (str != "")
                                {
                                    if (strings.IsNumeric(str))
                                    {
                                        CAL_DEC[i] = Convert.ToInt16(str);
                                    }
                                }
                            }
                        }
                        //========================
                        // Line Value
                        if (CAL[40].Trim() != "")
                        {
                            if (CAL[6 + i * 2] == CAL[40])
                            {
                                Pur_L_Val = i + 1;
                                var tblCal = dataManager.GetData("SELECT SI_DATA FROM SIDATA ", "SI_TYPE", "SI_TYPE",
                                                                 "CALDE", "CODE", CAL[40]);
                                if (tblCal.Rows.Count > 0)
                                {
                                    string str = tblCal.Rows[0][0].ToString().Substring(110, 1).Trim();
                                    if (str != "")
                                    {
                                        if (strings.IsNumeric(str))
                                        {
                                            LINE_VAL_DECIMAL = Convert.ToInt16(str);
                                        }
                                    }
                                }
                            }
                        }
                        //                         ============== M1
                        if (CAL[41].Trim() != "")
                        {
                            if (CAL[6 + i * 2] == CAL[41])
                            {
                                Pur_C_Val = i + 1;
                            }
                        }

                        //                        ================ M1
                        if (CAL[42].Trim() != "")
                        {
                            if (CAL[6 + i * 2] == CAL[41])
                            {
                                Pur_C_Val = i + 1;
                            }
                        }
                        //                        =============== Split
                        if (CAL[43].Trim() != "")
                        {
                            if (CAL[6 + i * 2] == CAL[43])
                            {
                                Pur_S_Val = i + 1;
                            }
                        }

                        //                        ================ M2
                        if (CAL[44].Trim() != "")
                        {
                            if (CAL[6 + i * 2] == CAL[44])
                            {
                                if (CAL[6 + i + 2] == CAL[44])
                                {
                                    Pur_M_val2 = i + 1;
                                }
                            }
                        }

                        //                        ==================  F1
                        if (CAL[45].Trim() != "")
                        {
                            if (CAL[6 + i * 2] == CAL[45])
                            {
                                Pur_F_Val1 = i + 1;
                            }
                        }

                        //                        ============= MATCH 3
                        if (CAL[46].Trim() != "")
                        {
                            if (CAL[6 + i * 2] == CAL[46])
                            {
                                Pur_M_val3 = i + 1;
                            }
                        }
                        //                        =============== FIX 2
                        if (CAL[47].Trim() != "")
                        {
                            if (CAL[6 + i * 2] == CAL[47])
                            {
                                Pur_F_Val2 = i + 1;
                            }
                        }

                        //                        =============== MATCH 4
                        if (CAL[48].Trim() != "")
                        {
                            if (CAL[6 + i * 2] == CAL[48])
                            {
                                Pur_M_val4 = i + 1;
                            }
                        }

                        //                        =================  FIXED 3
                        if (CAL[49].Trim() != "")
                        {
                            if (CAL[6 + i * 2] == CAL[49])
                            {
                                Pur_F_Val3 = i + 1;
                            }
                        }
                    }
                    if (CAL[40].Trim() != "")
                    {
                        if (Pur_L_Val == 0)
                        {
                            MessageBox.Show(
                                "Please checking on purchase type definition. Line value not in calculation value.", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            START_PURCHASEORDER();
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                    //                    ======================== Auto(Number)
                    if (SITempData.PO_AUTO_NUM == "Y")
                    {
                        PO_PREFIX = "!y!!MM";
                        PO_SUFFIX = "";
                        PO_INTERVAL = 1;
                        PO_LENGHT = 10;
                        PO_START = 1;
                        var tbl = dataManager.GetData("SELECT SI_DATA FROM SIPDATA", "SI_TYPE", "SI_TYPE", "AUTOP",
                                                      "SI_CODE", "PURCHASE");
                        if (tbl.Rows.Count > 0)
                        {
                            string st = dt.Rows[0][0].ToString();
                            PO_PREFIX = st.Substring(0, 10).Trim();
                            PO_SUFFIX = st.Substring(10, 10).Trim();
                            PO_INTERVAL = Convert.ToInt16(st.Substring(20, 5).Trim());
                            PO_LENGHT = Convert.ToInt16(st.Substring(25, 2).Trim());
                            PO_START = Convert.ToInt16(st.Substring(27, 5).Trim());
                            PO_PREFIX = st.Substring(32, 10).Trim();
                            PO_SUFFIX = st.Substring(42, 10).Trim();
                            PO_INTERVAL = Convert.ToInt16(st.Substring(20, 5).Trim());
                            PO_LENGHT = Convert.ToInt16(st.Substring(25, 2).Trim());
                            PO_START = Convert.ToInt16(st.Substring(27, 5).Trim());
                            //                            ===================
                            PO_PREFIX = st.Substring(32, 10).Trim();
                            PO_SUFFIX = st.Substring(42, 10).Trim();
                            PO_INTERVAL = Convert.ToInt16(st.Substring(52, 5).Trim());
                            PO_LENGHT = Convert.ToInt16(st.Substring(57, 2));
                            PO_START = Convert.ToInt16(st.Substring(53, 5).Trim());
                        }
                        else
                        {
                            MessageBox.Show("You must set auto number format first!", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            START_PURCHASEORDER();
                        }
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

        private void btnCustCode_Click(object sender, EventArgs e)
        {
            try
            {
                var droplist_FRM = new DROPLIST_FRM();
                MAIN_FRM main_FRM = new MAIN_FRM();
                var command =
                    new SqlCommand(
                        "SELECT ADD_CODE [Sup. Code], ADD_LOOKUP [Lookup], ADD_NAME [Sup. Name],ADD_LINE_1, ADD_LINE_2, ADD_LINE_3, ADD_LINE_4, ADD_LINE_5 FROM dbo.SIPADDR WHERE ADD_TYPE='1' AND ADD_STAT='A' AND ADD_CODE>=@ADD_CODE ORDER BY ADD_CODE",
                        connnection.Connect());
                command.Parameters.AddWithValue("@ADD_CODE", txtSupCode.Text);
                var dataAdapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                dataAdapter.Fill(dt);
                droplist_FRM.DataGridView.DataSource = dt;
                droplist_FRM.Top = main_FRM.Top + this.Top + ToolStrip1.Height + panel2.Top + txtSupCode.Top +
                                   btnCustCode.Height + 21;
                droplist_FRM.Left = main_FRM.Left + this.Left + panel1.Left + txtSupCode.Left + 5;
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.Width * 27 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.Width * 20 / 100;
                droplist_FRM.DataGridView.Columns[2].Width = droplist_FRM.Width * 47 / 100;
                droplist_FRM.DataGridView.Columns[3].Visible = false;
                droplist_FRM.DataGridView.Columns[4].Visible = false;
                droplist_FRM.DataGridView.Columns[5].Visible = false;
                droplist_FRM.DataGridView.Columns[6].Visible = false;
                droplist_FRM.DataGridView.Columns[7].Visible = false;

                if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    panel4.Enabled = false;
                    txtSupCode.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    txtSupName.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    txtSupAdd1.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[3].Value.ToString();
                    txtSupAdd2.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[4].Value.ToString();
                    txtSupAdd3.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[5].Value.ToString();
                    txtSupAdd4.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[6].Value.ToString();
                    txtSupAdd5.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[7].Value.ToString();
                    txtSupCode.Enabled = true;
                    txtDelCode.Focus();
                }
                else
                {
                    txtSupCode.SelectAll();
                    txtSupCode.Focus();
                }
                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCustCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnCustCode.Text == "")
                    {
                        if (Condition.EmptyControl(txtSupCode))
                            return;
                        panel4.Enabled = true;
                        SelectNextControl(txtSupCode, true, true, true, true);
                    }
                    else
                    {
                        var tbl =
                            dataManager.GetData(
                                "SELECT ADD_CODE,ADD_NAME, ADD_LINE_1, ADD_LINE_2, ADD_LINE_3, ADD_LINE_4, ADD_LINE_5 FROM dbo.SIPADDR",
                                "ADD_CODE", "ADD_TYPE", "1", "ADD_STAT", "A", "ADD_CODE", txtSupCode.Text);
                        if (tbl.Rows.Count > 0)
                        {
                            panel4.Enabled = false;
                            txtSupCode.Text = tbl.Rows[0][0].ToString();
                            txtSupName.Text = tbl.Rows[0][1].ToString();
                            txtSupAdd1.Text = tbl.Rows[0][2].ToString();
                            txtSupAdd2.Text = tbl.Rows[0][3].ToString();
                            txtSupAdd3.Text = tbl.Rows[0][4].ToString();
                            txtSupAdd4.Text = tbl.Rows[0][5].ToString();
                            txtSupAdd5.Text = tbl.Rows[0][6].ToString();
                            SelectNextControl(txtSupCode, true, true, true, true);
                        }
                        else
                        {
                            controls.ClearControl(txtSupName, txtSupAdd5, txtSupAdd4, txtSupAdd3, txtSupAdd2, txtSupAdd1);
                            MessageBox.Show("Data '" + txtSupCode.Text + "' not found", "Not Found",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSupCode.SelectionStart = 0;
                            txtSupCode.SelectionLength = txtSupCode.ToString().Length;
                        }
                    }
                }
                else if (e.KeyCode == Keys.F6)
                {
                    btnCustCode_Click(sender, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelCode_Click(object sender, EventArgs e)
        {
            try
            {
                var droplist_FRM = new DROPLIST_FRM();
                MAIN_FRM main_FRM = new MAIN_FRM();
                droplist_FRM.DataGridView.DataSource =
                    dataManager.GetData(
                        "SELECT DEL_CODE [Del. Code],DEL_NAME [Del. Name],DEL_ADD_1, DEL_ADD_2, DEL_ADD_3, DEL_ADD_4, DEL_ADD_5 FROM (SELECT D.DEL_CODE,DEL_NAME,DEL_ADD_1, DEL_ADD_2, DEL_ADD_3, DEL_ADD_4, DEL_ADD_5,A.ADD_CODE FROM SIPDADD D INNER JOIN SIPDELA A ON D.DEL_CODE=A.DEL_CODE WHERE D.DEL_TYPE='1') T",
                        "DEL_CODE", "ADD_CODE", txtSupCode.Text);
                droplist_FRM.Top = main_FRM.Top + this.Top + ToolStrip1.Height + panel2.Top + txtDelCode.Top + txtDelCode.Height + 22;
                droplist_FRM.Left = main_FRM.Left + this.Left + txtDelCode.Left + panel3.Left + btnDelCode.Width - 18;
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width * 32 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width * 67 / 100;
                droplist_FRM.DataGridView.Columns[2].Visible = false;
                droplist_FRM.DataGridView.Columns[3].Visible = false;
                droplist_FRM.DataGridView.Columns[4].Visible = false;
                droplist_FRM.DataGridView.Columns[5].Visible = false;
                droplist_FRM.DataGridView.Columns[6].Visible = false;
                if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    panel5.Enabled = false;
                    txtDelCode.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    txtDelName.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[1].Value.ToString();
                    txtDelAdd1.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    txtDelAdd2.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[3].Value.ToString();
                    txtDelAdd3.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[4].Value.ToString();
                    txtDelAdd4.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[5].Value.ToString();
                    txtDelAdd5.Text =
                        droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[6].Value.ToString();
                    txtDelCode.Enabled = true;
                    mnAdd_New_Line_Click(null, null);
                }
                else
                {
                    txtDelCode.SelectAll();
                    txtDelCode.Focus();
                }

                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnAdd_New_Line_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    security.CheckPermission(UserLogOn.Code, menuItems.PurchaseOrder, "V", subMenuItems.NewLine, true) ==
                    false)
                    return;
                if (status != "" && status != "Held")
                {
                    MessageBox.Show("You cannot add new item to the purchase order. Purchase order " + status, "Add New",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (SITempData.PO_AUTO_NUM == "N")
                {
                    if (Condition.EmptyControl(txt_p_orderN) == true)
                        return;
                }
                if (Condition.EmptyControl(txtSupCode))
                    return;
                if (dataManager.Exists("SIPADDR", txtSupCode.Text, "ADD_CODE", "ADD_TYPE", "1") == false)
                {
                    MessageBox.Show("Data '" + txtSupCode.Text + "' not found!", "Not Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtSupCode.SelectAll();
                    txtSupCode.Focus();
                    return;
                }
                if (Condition.EmptyControl(txtDelCode))
                    return;
                if (txtDelCode.Text != "")
                {
                    if (dataManager.Exists("SIPDADD", txtDelCode.Text, "DEL_CODE", "DEL_TYPE", "1") == false)
                    {
                        MessageBox.Show("Data '" + txtDelCode.Text + "' not found!", "Not Found", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        txtDelCode.SelectAll();
                        txtDelCode.Focus();
                        return;
                    }
                }
                Cursor = Cursors.WaitCursor;
//                DROPLIST_FRM droplist_FRM = new DROPLIST_FRM();
                var addsipopurchaseorder_FRM = new ADDSIPOPURCHASEORDER_FRM(this);
                //                ================= update stock or not =========
                addsipopurchaseorder_FRM.cboPType.SelectedIndex = 0;
                addsipopurchaseorder_FRM.ShowDialog();
                addsipopurchaseorder_FRM.Close();
                Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDelCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtDelCode.Text == "")
                    {
                        if (Condition.EmptyControl(txtDelCode))
                            return;
                        panel5.Enabled = true;
                        SelectNextControl(txtDelCode, true, true, true, true);
                    }
                    else
                    {
                        var dt =
                            dataManager.GetData(
                                "SELECT DEL_CODE [Delivery Code],DEL_NAME [Delivery Name],DEL_ADD_1, DEL_ADD_2, DEL_ADD_3, DEL_ADD_4, DEL_ADD_5 FROM (SELECT D.DEL_CODE,DEL_NAME,DEL_ADD_1, DEL_ADD_2, DEL_ADD_3, DEL_ADD_4, DEL_ADD_5,A.ADD_CODE FROM SIPDADD D INNER JOIN SIPDELA A ON D.DEL_CODE=A.DEL_CODE WHERE D.DEL_TYPE='1') T",
                                "DEL_CODE", "DEL_CODE", txtDelCode.Text, "ADD_CODE", txtSupCode.Text);
                        if (dt.Rows.Count > 0)
                        {
                            panel5.Enabled = false;
                            txtDelCode.Text = dt.Rows[0][0].ToString();
                            txtDelName.Text = dt.Rows[0][1].ToString();
                            txtDelAdd1.Text = dt.Rows[0][2].ToString();
                            txtDelAdd2.Text = dt.Rows[0][3].ToString();
                            txtDelAdd3.Text = dt.Rows[0][4].ToString();
                            txtDelAdd4.Text = dt.Rows[0][5].ToString();
                            txtDelAdd5.Text = dt.Rows[0][6].ToString();
                            mnAdd_New_Line_Click(null, null);
                        }
                        else
                        {
                            controls.ClearControl(txtDelName, txtDelAdd1, txtDelAdd2, txtDelAdd3, txtDelAdd4, txtDelAdd5);
                            MessageBox.Show("Data '" + txtDelCode.Text + "' not found", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            txtDelCode.SelectionStart = 0;
                            txtDelCode.SelectionLength = txtDelCode.ToString().Length;
                        }
                    }
                }
                else if (e.KeyCode == Keys.F6)
                {
                    btnDelCode_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDelAdd5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mnAdd_New_Line_Click(sender, e);
            }
        }

        private void StartToolStripButton_Click(object sender, EventArgs e)
        {
            
            if (MAKE_CHANGE)
            {
                if (MessageBox.Show("Are you sure you want to start new transaction without saving some change?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            START_PURCHASEORDER();
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    security.CheckPermission(UserLogOn.Code, menuItems.PurchaseOrder, "V", subMenuItems.EditLine, true) ==
                    false)
                    return;
                if (status != "" && status != "Held")
                {
                    MessageBox.Show("You cannot edit item to the Purchase order." + status, "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
                if (txtSupCode.Text != "")
                {
                    if (!dataManager.Exists("SIPADDR", txtSupCode.Text, "ADD_CODE", "ADD_TYPE", "1"))
                    {
                        MessageBox.Show("Data '" + txtSupCode.Text + "' not found!", "", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    txtSupName.Text = "";
                    MessageBox.Show("Supplier's name can't be blank!", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtSupCode.SelectAll();
                    txtSupCode.Focus();
                    return;
                }
                SITempData.Is_Edit = true;
                if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("There are no selected item in the list!", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
                Cursor = Cursors.WaitCursor;
//                DROPLIST_FRM droplist_FRM = new DROPLIST_FRM();
                var addsipopurchaseorder_FRM = new ADDSIPOPURCHASEORDER_FRM(this);
                addsipopurchaseorder_FRM.txtLoc_Code.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                var fieldAndVal = new string[]
                                      {
                                          "LOC_CODE", addsipopurchaseorder_FRM.txtLoc_Code.
                                                          Text
                                      };
                addsipopurchaseorder_FRM.txtLoc_Desc.Text = DataAccess.ReturnField("SELECT LOC_NAME FROM SIPLOCA",
                                                                                   "LOC_CODE", fieldAndVal, 0);
                addsipopurchaseorder_FRM.txtItem_Code.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                addsipopurchaseorder_FRM.txtItem_Desc.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                addsipopurchaseorder_FRM.txtUnitOfPurchase.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                var condition = new string[] { "ITEM_CODE", addsipopurchaseorder_FRM.txtItem_Code.Text };
                addsipopurchaseorder_FRM.txtUnitofStock.Text = DataAccess.ReturnField(
                    "SELECT UNIT_STOCK FROM SIPITEMS", "ITEM_CODE", condition, 0);
                var cond = new string[]
                               {
                                   "ORM_REF", txt_p_orderN.Text
                               };
                dtpOrder_Date.Value = Convert.ToDateTime(DataAccess.ReturnField("SELECT ORM_DATE FROM dbo.SIPPORM ", "ORM_REF", cond, 0));
                if ((string) dataGridView.SelectedRows[0].Cells[5].Value == "P")
                    addsipopurchaseorder_FRM.cboPType.SelectedIndex = 0;
                else
                    addsipopurchaseorder_FRM.cboPType.SelectedIndex = 1;

                addsipopurchaseorder_FRM.txtQTY.Text = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                addsipopurchaseorder_FRM.txtStockQ.Text = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                addsipopurchaseorder_FRM.txtCost.Text = dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                addsipopurchaseorder_FRM.txtSubTotal.Text = dataGridView.SelectedRows[0].Cells[9].Value.ToString();
                addsipopurchaseorder_FRM.txtDisP.Text = dataGridView.SelectedRows[0].Cells[10].Value.ToString();
                addsipopurchaseorder_FRM.txtDisAmt.Text = dataGridView.SelectedRows[0].Cells[11].Value.ToString();
                addsipopurchaseorder_FRM.txtTotal.Text = dataGridView.SelectedRows[0].Cells[12].Value.ToString();
                addsipopurchaseorder_FRM.Text = "Edit Item Entry";
                
                addsipopurchaseorder_FRM.ShowDialog();
                addsipopurchaseorder_FRM.Close();
                Cursor = Cursors.Default;
                
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void PurchaseOrdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    security.CheckPermission(UserLogOn.Code, menuItems.PurchaseOrder, "V", subMenuItems.PurchaseOrder, true) ==
                    false)
                    return;
                if (MAKE_CHANGE)
                {
                    if (MessageBox.Show("Are you sure you want to view another transaction without saving some change?", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                        return;
                }
                START_PURCHASEORDER();
                var sipopurchaseorder_View = new SIPOPURCHASEORDER_View();
                var command = new SqlCommand("SELECT DISTINCT ORM_REF FROM SIPPORM WHERE month(ORM_DATE)=month(getdate()) and year(ORM_DATE)=year(getdate()) AND ORM_STAT='1' ORDER BY ORM_REF",connnection.Connect());
                var dt = dataManager.GetData(command);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sipopurchaseorder_View.TreeView1.Nodes[0].Nodes.Add(row[0].ToString(), row[0].ToString(), 1, 1).
                            Tag = "A";
                    }
                }
                command = new SqlCommand("SELECT DISTINCT ORM_REF FROM SIPPORM WHERE ORM_STAT='2' ORDER BY ORM_REF",connnection.Connect());
                var tbl = dataManager.GetData(command);
                if (tbl.Rows.Count > 0 )
                {
                    foreach (DataRow row in tbl.Rows)
                    {
                        sipopurchaseorder_View.TreeView1.Nodes[1].Nodes.Add(row[0].ToString(), row[0].ToString(), 2, 2).
                            Tag = "B";
                    }
                }

                if (sipopurchaseorder_View.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    string order_ref = sipopurchaseorder_View.DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    var dataAdapter = new SqlDataAdapter("SELECT * FROM SI_OPEN_HOLD1 WHERE ORM_REF='" + order_ref + "'",connnection.Connect());
                    DataTable dtHoldOpen = new DataTable();
                    dataAdapter.Fill(dtHoldOpen);
                    if (dtHoldOpen.Rows.Count > 0)
                    {
                        SIPOPURCHASEORDER_FRM_Load(sender, e);
                        var row = dtHoldOpen.Rows[0];
                        txt_p_orderN.Text = row[0].ToString();
                        dtpOrder_Date.Value = Convert.ToDateTime(row[1]);
                        txtComment.Text = row[2].ToString();
                        txtTotalA.Text = row[12].ToString();
                        txtDiscountA.Text = row[11].ToString();
                        txtVAT.Text = row[13].ToString();
                        txtGrandTotal.Text = row[14].ToString();
                        txtSupCode.Text = row[3].ToString();
                        if (row[3].ToString().Trim() != "")
                        {
                            var tblSupp =
                                dataManager.GetData(
                                    "SELECT ADD_NAME,ADD_LINE_1,ADD_LINE_2,ADD_LINE_3,ADD_LINE_4,ADD_LINE_5 FROM SIPADDR",
                                    "ADD_NAME", "ADD_TYPE", "1", "ADD_CODE", txtSupCode.Text);
                            if (tblSupp.Rows.Count > 0)
                            {
                                txtSupName.Text = tblSupp.Rows[0][0].ToString();
                                txtSupAdd1.Text = tblSupp.Rows[0][1].ToString();
                                txtSupAdd2.Text = tblSupp.Rows[0][2].ToString();
                                txtSupAdd3.Text = tblSupp.Rows[0][3].ToString();
                                txtSupAdd4.Text = tblSupp.Rows[0][4].ToString();
                                txtSupAdd5.Text = tblSupp.Rows[0][5].ToString();
                            }
                        }
                        if (row[5].ToString().Trim() != "")
                        {
                            txtDelCode.Text = row[5].ToString().Trim();
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
                        // Item detail line
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SI_SELECT_DETAIL WHERE ORM_REF='" + order_ref + "'",connnection.Connect());
                        var tbldeliv = new DataTable();
                        adapter.Fill(tbldeliv);
                        foreach ( DataRow r in tbldeliv.Rows)
                        {
                            string pur_Qty, stock_Qty, pur_Cost, total, conv, unit_Qty;
                            pur_Qty = r[6].ToString();
                            stock_Qty = r[7].ToString();
                            pur_Cost = r[8].ToString();
                            total = row[10].ToString();
                            DataTable tblTemp = dataManager.GetData("SELECT UNIT_STOCK FROM SIPITEMS", "UNIT_STOCK",
                                                                    "ITEM_CODE", r[3].ToString());
                            var tblUnit = dataManager.GetData("SELECT FACTOR,OPERATOR FROM SIUNITCONV", "FACTOR",
                                                              "CONV_FROM", r[5].ToString().Trim(), "CONV_TO",
                                                              tblTemp.Rows[0][0].ToString());
                            conv = "";
                            unit_Qty = "";
                            if (tblUnit.Rows.Count > 0)
                            {
                                conv = string.Format("{0:#0.00}", Convert.ToDecimal(tblUnit.Rows[0][0]));
                                unit_Qty = tblUnit.Rows[0][1].ToString().Trim();
                            }
                            dataGridView.Rows.Add(r[1], r[2], r[3], r[4],r[5],"P",pur_Qty, stock_Qty, pur_Cost,
                                                  r[9], r[10],r[11], r[12], r[13],0);
                        }
                        IS_UPDATE = true;
                        MAIN_FRM main_FRM = new MAIN_FRM();
                        if (row[15].ToString().Trim() == "1")
                        {
                            status = "Held";
                            main_FRM.StatusStrip.Items[0].Text = "Purchase Order:Held";
                        }
                        else
                        {
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            status = "Released";
                            main_FRM.StatusStrip.Items[0].Text = "Purchase order :" + status +
                                                                 ". Cannot be added, updated or deleted items!";
                        }
                        Cursor = Cursors.Default;
                    }
                    Cursor = Cursors.Default;
                }
                sipopurchaseorder_View.Close();
            }
            catch (Exception ex)
            {
               START_PURCHASEORDER();
                MessageBox.Show(ex.Message);
                Cursor = Cursors.Default;
            }
        }

        private bool SaveHeldPurchaseOrder(string status)
        {
            if (string.IsNullOrEmpty(status))
            {
                status = "10";
            }

            //            ========== check over expenditure of account purchase definition
            string REC_TYPE = "D";
            if (SITempData.PO_AUTO_NUM == "Y")
            {
                //                ====== Auto(Number)
//                PO_PREFIX = "!Y!!MM!";
                PO_PREFIX = "";
                PO_SUFFIX = "";
                PO_INTERVAL = 1;
                PO_LENGHT = 10;
                PO_START = 1;
                var dt = dataManager.GetData("SELECT SI_DATA FROM SIPDATA", "SI_DATA", "SI_TYPE", "AUTOP", "SI_CODE",
                                             "PO");
                if (dt.Rows.Count > 0)
                {
                    //                    ========= For purchase Order
                    string ss = dt.Rows[0][0].ToString();
                    PO_PREFIX = ss.Substring(0, 10).Trim();
                    PO_SUFFIX = ss.Substring(10, 10).Trim();
                    PO_INTERVAL = Convert.ToInt16(ss.Substring(20, 5).Trim());
                    PO_LENGHT = Convert.ToInt16(ss.Substring(25, 2).Trim());
                    PO_START = Convert.ToInt16(ss.Substring(27, 5).Trim());
                    //                    ========== For purchase order
//                    PO_PREFIX = ss.Substring(32, 10).Trim();
//                    PO_SUFFIX = ss.Substring(42, 10).Trim();
//                    PO_INTERVAL = Convert.ToInt16(ss.Substring(52, 5).Trim());
//                    PO_LENGHT = Convert.ToInt16(ss.Substring(57, 2).Trim());
//                    PO_START = Convert.ToInt16(ss.Substring(53, 5).Trim());
                }
                else
                {
                    MessageBox.Show("You must set auto number format first!", "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    START_PURCHASEORDER();
                }

                string P = generator.Prefix(PO_PREFIX);
                string S = generator.Prefix(PO_SUFFIX);

                TRANS_REF =
                    generator.ID(
                        "SELECT MAX(CAST(ORM_REF AS NUMERIC))AS ORM_REF  FROM SIPPORD WHERE LEFT(ORM_REF," + P.Length + ")='" + P +
                        "' AND RIGHT(ORM_REF," + S.Length + ")='" + S + "'", PO_LENGHT - (P.Length + S.Length), P, S,
                        PO_START, PO_INTERVAL);
            }
            else
            {
                TRANS_REF = txt_p_orderN.Text;
            }
            if (IS_UPDATE == false)
            {
                // Insert into purchase order new line
                if (dataManager.Exists("SIPPORD", TRANS_REF, "ORM_REF"))
                {
                    MessageBox.Show("This Purchase order number already exist!", "Already", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txt_p_orderN.SelectAll();
                    txt_p_orderN.Focus();
                    return false;
                }
                var command = new SqlCommand("",connnection.Connect())
                                  {
                                      CommandType = CommandType.StoredProcedure,
                                  };
                try
                {
                    // Insert into purchase order Master
                    command.CommandText = "SI_INSERT_SIPPORM";
                    command.Parameters.Clear();
                    // Note : Insert To Master Purchase Order
                    Commands.CreateParameter(command, "ORM_REF_1", TRANS_REF, "ORM_DATE_2",
                                             dtpOrder_Date.Value, "ORM_COM_3", txtComment.Text,
                                             "SUP_CODE_4", txtSupCode.Text, "DEL_CODE_5", txtDelCode.Text, "ORM_TOTAL_6",
                                             txtTotalA.Text, "ORM_TOTID_7", 0, "ORM_TOTAD_8", 0, "ORM_DISP_9", 0, "ORM_DISA_10",
                                             txtDiscountA.Text, "ORM_TOTAI_11", txtTotalA.Text, "ORM_VAT_12",
                                             txtVAT.Text, "ORM_GRAND_13", txtGrandTotal.Text, "ORM_STAT_14", status,
                                             "USER_CODE_15", UserLogOn.Code);
                    command.ExecuteNonQuery();

                    // Insert Into Purchase Order Detail
                    command.CommandText = "SI_INSERT_SIPPORD";
                    for (int k = 0; k < dataGridView.Rows.Count; k++)
                    {
                        command.Parameters.Clear();
                        Commands.CreateParameter(command, "ORM_REF_1", TRANS_REF, "ORD_LINE_2",
                                                 dataGridView.Rows[k].Cells[0].Value.ToString(),
                                                 "LOC_CODE_3", dataGridView.Rows[k].Cells[1].Value.ToString(), "ITEM_CODE_4",
                                                 dataGridView.Rows[k].Cells[2].Value.ToString(),
                                                 "ORD_UNIT_5", dataGridView.Rows[k].Cells[4].Value.ToString(), "ORD_QTY_6",
                                                 Convert.ToDecimal(dataGridView.Rows[k].Cells[6].Value.ToString()),
                                                 "ORD_STOCK_7", Convert.ToDecimal(dataGridView.Rows[k].Cells[7].Value.ToString()), "ORD_COST_8",
                                                 Convert.ToDecimal(dataGridView.Rows[k].Cells[8].Value.ToString()),
                                                 "ORD_SUB_9", Convert.ToDecimal(dataGridView.Rows[k].Cells[9].Value.ToString()), "ORD_DISP_10",
                                                 Convert.ToDecimal(dataGridView.Rows[k].Cells[10].Value.ToString()),
                                                 "ORD_DISA_11", Convert.ToDecimal(dataGridView.Rows[k].Cells[11].Value.ToString()), "ORD_TOT_12",
                                                 Convert.ToDecimal(dataGridView.Rows[k].Cells[12].Value.ToString()),
                                                 "ORD_STAT_13", "D", "ORD_TYPE_14", dataGridView.Rows[k].Cells[5].Value.ToString());
                        command.ExecuteNonQuery();
                    }

                    START_PURCHASEORDER();
                    return false;
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                // Update Purchase Order Recode
                SqlCommand command = new SqlCommand("",connnection.Connect());
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    //Update Purchase Order Master
                    command.CommandText = "SI_UPDATE_SIPPORM";
                    command.Parameters.Clear();
                    Commands.CreateParameter(command, "ORM_REF_1", txt_p_orderN.Text, "ORM_DATE_2",
                                             dtpOrder_Date.Value, "ORM_COM_3", txtComment.Text,
                                             "SUP_CODE_4", txtSupCode.Text, "DEL_CODE_5", txtDelCode.Text, "ORM_TOTAL_6",
                                             txtTotalA.Text, "ORM_TOTID_7", 0, "ORM_TOTAD_8", txtTotalA.Text, "ORM_DISP_9", 0,
                                             "ORM_DISA_10", txtDiscountA.Text, "ORM_TOTAI_11", txtTotalA.Text,
                                             "ORM_VAT_12", txtVAT.Text, "ORM_GRAND_13", txtGrandTotal.Text,
                                             "ORM_STAT_14", status, "USER_CODE_15", UserLogOn.Code);
                    int Insert_ORM = 0;
                    Insert_ORM = command.ExecuteNonQuery();
                    if (Insert_ORM == 0)
                    {
                        command.CommandText = "SI_INSERT_SIPPORM";
                        command.Parameters.Clear();
                        // Note : Insert To Master Purchase Order
                        Commands.CreateParameter(command, "ORM_REF_1", TRANS_REF, "ORM_DATE_2",
                                                 dtpOrder_Date.Value, "ORM_COM_3", txtComment.Text,
                                                 "SUP_CODE_4", txtSupCode.Text, "DEL_CODE_5", txtDelCode.Text, "ORM_TOTAL_6",
                                                 txtTotalA.Text, "ORM_TOTID_7", 0, "ORM_TOTAD_8", 0, "ORM_DISP_9", 0, "ORM_DISA_10",
                                                 txtDiscountA.Text, "ORM_TOTAI_11", txtTotalA.Text, "ORM_VAT_12",
                                                 txtVAT.Text, "ORM_GRAND_13", txtGrandTotal.Text, "ORM_STAT_14", status,
                                                 "USER_CODE_15", UserLogOn.Code);
                        command.ExecuteNonQuery();
                    }

                    // Update Purchase Detail
                    int INSERT_SUC = 0;
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        command.CommandText = "SI_UPDATE_SIPPORD";
                        command.Parameters.Clear();
                        Commands.CreateParameter(command, "ORM_REF_1", txt_p_orderN.Text, "ORD_LINE_2",
                                                 dataGridView.Rows[i].Cells[0].Value.ToString().Trim(), "LOC_CODE_3",
                                                 dataGridView.Rows[i].Cells[1].Value,
                                                 "ITEM_CODE_4", dataGridView.Rows[i].Cells[2].Value, "ORD_UNIT_5",
                                                 dataGridView.Rows[i].Cells[4].Value,
                                                 "ORD_QTY_6", Convert.ToDecimal(dataGridView.Rows[i].Cells[6].Value),
                                                 "ORD_STOCK_7",
                                                 Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value), "ORD_COST_8",
                                                 Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value),
                                                 "ORD_SUB_9", Convert.ToDecimal(dataGridView.Rows[i].Cells[9].Value),
                                                 "ORD_DISP_10",
                                                 Convert.ToDecimal(dataGridView.Rows[i].Cells[10].Value), "ORD_DISA_11",
                                                 Convert.ToDecimal(dataGridView.Rows[i].Cells[11].Value),
                                                 "ORD_TOT_12", Convert.ToDecimal(dataGridView.Rows[i].Cells[12].Value),
                                                 "ORD_STAT_13", dataGridView.Rows[i].Cells[13].Value, "ORD_TYPE_14",
                                                 dataGridView.Rows[i].Cells[5].Value);
                        INSERT_SUC = command.ExecuteNonQuery();
                        
                        if(txt_p_orderN.Text != "")
                        {
                            TRANS_REF = txt_p_orderN.Text;
                        }
//                       
                        if (INSERT_SUC == 0 )
                        {
                            if (TRANS_REF != "0")
                            {

                                command.CommandText = "SI_INSERT_SIPPORD";
                                command.Parameters.Clear();
                                Commands.CreateParameter(command, "ORM_REF_1", TRANS_REF, "ORD_LINE_2",
                                                         dataGridView.Rows[i].Cells[0].Value,
                                                         "LOC_CODE_3", dataGridView.Rows[i].Cells[1].Value, "ITEM_CODE_4",
                                                         dataGridView.Rows[i].Cells[2].Value,
                                                         "ORD_UNIT_5", dataGridView.Rows[i].Cells[4].Value, "ORD_QTY_6",
                                                         dataGridView.Rows[i].Cells[6].Value,
                                                         "ORD_STOCK_7", Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value), "ORD_COST_8",
                                                         Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value),
                                                         "ORD_SUB_9", Convert.ToDecimal(dataGridView.Rows[i].Cells[9].Value), "ORD_DISP_10",
                                                         Convert.ToDecimal(dataGridView.Rows[i].Cells[10].Value),
                                                         "ORD_DISA_11", Convert.ToDecimal(dataGridView.Rows[i].Cells[11].Value), "ORD_TOT_12",
                                                         Convert.ToDecimal(dataGridView.Rows[i].Cells[12].Value),
                                                         "ORD_STAT_13", "D", "ORD_TYPE_14",
                                                         dataGridView.Rows[i].Cells[5].Value);
                                command.ExecuteNonQuery();
                                TRANS_REF = TRANS_REF;
                            }
                            else
                            {
                                command.CommandText = "SI_INSERT_SIPPORD";
                                command.Parameters.Clear();
                                Commands.CreateParameter(command, "ORM_REF_1", txt_p_orderN.Text, "ORD_LINE_2",
                                                         dataGridView.Rows[i].Cells[0].Value,
                                                         "LOC_CODE_3", dataGridView.Rows[i].Cells[1].Value, "ITEM_CODE_4",
                                                         dataGridView.Rows[i].Cells[2].Value,
                                                         "ORD_UNIT_5", dataGridView.Rows[i].Cells[4].Value, "ORD_QTY_6",
                                                         dataGridView.Rows[i].Cells[6].Value,
                                                         "ORD_STOCK_7", Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value), "ORD_COST_8",
                                                         Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value),
                                                         "ORD_SUB_9", Convert.ToDecimal(dataGridView.Rows[i].Cells[9].Value), "ORD_DISP_10",
                                                         Convert.ToDecimal(dataGridView.Rows[i].Cells[10].Value),
                                                         "ORD_DISA_11", Convert.ToDecimal(dataGridView.Rows[i].Cells[11].Value), "ORD_TOT_12",
                                                         Convert.ToDecimal(dataGridView.Rows[i].Cells[12].Value),
                                                         "ORD_STAT_13", "D", "ORD_TYPE_14",
                                                         dataGridView.Rows[i].Cells[5].Value);
                                command.ExecuteNonQuery();
                            }
                         
                        }
                    }
                    START_PURCHASEORDER();
                    return true;
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if ( security.CheckPermission(UserLogOn.Code, menuItems.PurchaseOrder, "V", subMenuItems.DeleteLine, true) ==
                  false)
                    return;
                if (dataGridView.SelectedRows.Count > 0)
                {
                    if (status != "" && status !="Held")
                    {
                        MessageBox.Show("You cannot remove item from the Purchase order. Purchase Order: " + status,
                                        "Can't Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to remove this item?","Remove",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
//                        if (dataGridView.SelectedRows[0].Cells[13].Value.ToString().Trim() == "D")
//                        {
//                            int i = dataGridView.SelectedRows[0].Index;
//                            for (int k = 0; k < dataGridView.Rows.Count -1 ; k--)
//                            {
//                                if (dataGridView.Rows[k].Cells[0].Value.ToString().Substring(0,3).Trim() == dataGridView.SelectedRows[0].Cells[0].Value.ToString().Trim())
//                                {
//                                    if (dataGridView.Rows[k].Cells[12].Value.ToString() == "A")
//                                    {
//                                        dataGridView.Rows.Remove(dataGridView.Rows[k]);
//                                    }    
//                                }
//                            }
                        is_Delete = true;
                        dataGridView_CellContentClick(null, null);
                        DELR.Add(dataGridView.SelectedRows[0].Cells[0].Value);
                        dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
//                        }
//                        else
//                        {
//                            dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
//                        }
                        MAKE_CHANGE = true;
                    }
                }
                else
                {
                    MessageBox.Show("There are no selected item to remove.", "Empty Select", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InvoiceOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var invoice_OPTION_FRM = new INVOICE_OPTION_FRM
                                         {
                                             txtTotalA = {Text = txtTotalA.Text},
                                             txtDiscountA = {Text = txtDiscountA.Text},
//                                             txtVAT = {Text = txtVAT.Text},
                                             txtGrandTotal = {Text = txtGrandTotal.Text}
                                         };
            if (invoice_OPTION_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
//                txtTotalA.Text = invoice_OPTION_FRM.txtTotalA.Text;
                var disc = string.Format("{0:0.##}", Convert.ToDecimal(txtGrandTotal.Text) *
                                                  Convert.ToDecimal(invoice_OPTION_FRM.txtDisP.Text) / 100);
                txtDiscountA.Text = string.Format("{0:0.##}", Convert.ToDecimal(txtDiscountA.Text) +Convert.ToDecimal(txtGrandTotal.Text)*
                                                  Convert.ToDecimal(invoice_OPTION_FRM.txtDisP.Text)/100);
                var total = Convert.ToDecimal(txtGrandTotal.Text) - Convert.ToDecimal(disc);
                txtVAT.Text = string.Format("{0:0.##}",total * Convert.ToDecimal(invoice_OPTION_FRM.cboVAT.Text.Substring(0,invoice_OPTION_FRM.cboVAT.Text.Length - 1)) / 100);
                var grande = total - Convert.ToDecimal(txtVAT.Text);
                txtGrandTotal.Text = string.Format("{0:0.##}",grande);
            }
            invoice_OPTION_FRM.Close();
        }

        private void HoldToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.PurchaseOrder, "V", subMenuItems.Hold, true) ==
                 false)
                    return;
                if (dataGridView.Rows.Count > 0)
                {
                    if (status != "Held" && status != "" && status != "Released")
                    {
                        MessageBox.Show("You cannot hold the purchase order. Purchase " + status, "Can't Hold",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    // valid Data entry
                    bool approve = false;
                    if (ValidateHeader(approve) == false)
                        return;

                    if (status == "Released")
                    {
                        if (MessageBox.Show("Are you sure you want to return to hold?","Hold",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            SqlCommand command = new SqlCommand("",connnection.Connect());
                            try
                            {
                                Cursor = Cursors.WaitCursor;
                                command.CommandType = CommandType.Text;
                                command.CommandText = "UPDATE SIPPORM SET ORM_STAT='1' WHERE ORM_REF=@ORDER_REF";
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@ORDER_REF", txt_p_orderN.Text.Trim());
                                command.ExecuteNonQuery();
                                panel1.Enabled = true;
                                panel2.Enabled = true;
                                IS_UPDATE = true;
                                status = "";
                                MessageBox.Show("Purchase Order returned to held successfully!", "Successfull",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Cursor = Cursors.Default;
                                return;

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                Cursor = Cursors.Default;
                                command.Transaction.Rollback();
                                return;
                            }
                        }
                        return;
                    }
                    if (IS_UPDATE == false)
                    {
                        if (MessageBox.Show("Are you sure you want to hold this Purchase order?","Hold PurchaseOrder",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.Yes)
                        {
                            try
                            {
                                Cursor = Cursors.WaitCursor;
                                if (SaveHeldPurchaseOrder("") == false)
                                {
                                    Cursor = Cursors.Default;
                                    return;
                                }
                                MessageBox.Show(
                                    "Purchase order have been held successfully. Purchase order number: " + TRANS_REF, "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                
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
                        if (MessageBox.Show("Are you sure you want to update this Purchase order?","Update Purchase",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        {
                            try
                            {
                                Cursor = Cursors.WaitCursor;
                                for (int i = 0; i < DELR.Count ; i++)
                                {
                                    var command = new SqlCommand
                                                      {
                                                          Connection = connnection.Connect(),
                                                          CommandText =
                                                              ("DELETE FROM SIPPORD WHERE ORM_REF='" +
                                                               txt_p_orderN.Text.Trim() +
                                                               "' AND ORD_LINE='" + DELR[i].ToString().Trim() + "'")
                                                      };
                                    command.ExecuteNonQuery();
                                }
                                DELR.Clear();
                                if (SaveHeldPurchaseOrder("")== false)
                                {
                                    Cursor = Cursors.Default;
                                    return;
                                }
                                MessageBox.Show(
                                    "Purchase order have been update successfully. Purchase order number: " +
                                    txt_p_orderN.Text,"Successful Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                Cursor = Cursors.Default;
                            }
                            catch (Exception ex)
                            {
                                Cursor = Cursors.Default;
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("There are no items for holding!", "No Item", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private bool ValidateHeader(bool Approve)
        {
            try
            {
                if (Condition.EmptyControl(txtSupCode))
                    return false;
                if (dataManager.Exists("SIPADDR", txtSupCode.Text, "ADD_CODE", "ADD_TYPE", "1") == false)
                {
                    MessageBox.Show("Data '" + txtSupCode.Text + "' not found!", "Not Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtSupCode.SelectAll();
                    txtSupCode.Focus();
                    return false;
                }
                if (Condition.EmptyControl(txtDelCode))
                    return false;
                if (txtDelCode.Text != "")
                {
                    if (dataManager.Exists("V_SUPPLIER", "ADD_CODE", txtSupCode.Text, "DEL_CODE", txtDelCode.Text, "DEL_TYPE", "1") == false)
                    {
                        MessageBox.Show("Data '" + txtDelCode.Text + "' not found!", "Not Found", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        txtDelCode.SelectAll();
                        txtDelCode.Focus();
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.PurchaseOrder, "V", subMenuItems.Release, true) ==
                false)
                    return;
                if (dataGridView.Rows.Count > 0)
                {
                    if (status != "" && status !="Held")
                    {
                        MessageBox.Show("You cannot release the purchase order. Purchase order already " + status,
                                        "Already", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    // valid data entry
                    if (ValidateHeader(true) == false)
                    {
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to release this Purchase order?","Release",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            Cursor = Cursors.WaitCursor;
                            string Status = "2";
                            SITempData.Release_User = UserLogOn.Code;
                            IS_UPDATE = true;
                            for (int i = 0; i < DELR.Count -1; i++)
                            {
                                var command = new SqlCommand("DELETE FROM SIPPORD WHERE ORM_REF='" + txt_p_orderN.Text.Trim() +
                                                      "' AND ORD_LINE='" + DELR[i].ToString().Trim() + "'",connnection.Connect());
                                command.ExecuteNonQuery();
                            }
                            DELR.Clear();
                            if (SaveHeldPurchaseOrder(Status) == false)
                                return;
                            
                            MessageBox.Show("Purchase order have been release successfully. Purchase order number: " +
                                            TRANS_REF,"Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);

//                            ====================  Print report

                            var tblDataTable = new DataTable();
                            var dt = dataManager.GetData("SELECT REP_DATA FROM SIREPORT", "REP_CODE", "REP_TYPE",
                                                         "Print Purchase Form");
                            if (dt.Rows.Count > 0)
                            {
                                if (dt.Rows[0][0].ToString() != "")
                                {

                                    tblDataTable =
                                        dataManager.GetData(
                                            "SELECT PORM.ORM_REF [Order Code],PORM.ORM_DATE [Order Date], PORM.ORM_COM [Order Comment],PORM.ADD_CODE [Supplier Code], " +
                                            "PORM.DEL_CODE [Delivery Code], PORM.ORM_TOTAL [Invoice Total], PORM.ORM_TOTID [Invoice Discount], PORM.ORM_TOTAD [Total After Discount], " +
                                            "PORM.ORM_DISP [Discount Percent], PORM.ORM_DISA [Discount Amount],PORM.ORM_TOTAI [Total After Invoice], PORM.ORM_VAT [Invoice VAT], PORM.ORM_GRAND [Grand Total]," +
                                            "PORM.USER_CODE, PORD.ORD_LINE [Order Line], PORD.LOC_CODE [Location Code],PORD.ITEM_CODE [Item Code], PORD.ORD_UNIT [Unit],PORD.ORD_TYPE [Order Type], " +
                                            "PORD.ORD_QTY [Quantity],PORD.ORD_STOCK [Stock Quantity], PORD.ORD_COST [Cost],PORD.ORD_SUB [Sub Total], " +
                                            "PORD.ORD_DISP [Discount Percent], PORD.ORD_DISA [Discount Amount], PORD.ORD_TOT [Item Total], " +
                                            "PORM.ADD_NAME [Supplier Name], PORM.ADD_LINE_1 [Sup. Addrress 1], PORM.ADD_LINE_2 [Supplier Address 2], " +
                                            "PORM.ADD_LINE_3 [Supplier Address 3], PORM.ADD_LINE_4 [Supplier Address 4], PORM.ADD_LINE_5[Supplier Address 5], " +
                                            "PORM.DEL_NAME [Delivery Name], PORM.DEL_ADD_1[Delivery Address 1], PORM.DEL_ADD_2[Delivery Address 2], PORM.DEL_ADD_3 [Delivery Address 3]," +
                                            "PORM.DEL_ADD_4 [Delivery Address 4], PORM.DEL_ADD_5[Delivery Address 5],PORD.ITEM_DESC [Item Description],PORD.ITEM_BCODE " +
                                            "FROM " +
                                            "(SELECT PM.ORM_REF,PM.ORM_DATE, PM.ORM_COM, SUP.ADD_CODE,SUP.ADD_NAME,SUP.DEL_CODE,SUP.DEL_NAME,ORM_TOTAL, PM.ORM_TOTID,ORM_TOTAD,PM.ORM_DISP, " +
                                            "PM.ORM_DISA,PM.ORM_TOTAI, PM.ORM_VAT, PM.ORM_GRAND, PM.ORM_STAT, PM.USER_CODE, " +
                                            "SUP.DEL_ADD_1,SUP.DEL_ADD_2,SUP.DEL_ADD_3,SUP.DEL_ADD_4,SUP.DEL_ADD_5,SUP.DEL_COM_1,SUP.DEL_COM_2,SUP.DEL_CONT, " +
                                            "SUP.DEL_EMAIL,SUP.DEL_FAX,SUP.DEL_TEL,SUP.DEL_WEB, " +
                                            "SUP.ADD_LINE_1, SUP.ADD_LINE_2, SUP.ADD_LINE_3, SUP.ADD_LINE_4, SUP.ADD_LINE_5, SUP.ADD_TEL, SUP.ADD_FAX, SUP.ADD_EMAIL, SUP.ADD_WEB, SUP.ADD_CONT, SUP.ADD_COM_1, SUP.ADD_COM_2 FROM " +
                                            "(SELECT ORM_REF,ORM_DATE, ORM_COM, SUP_CODE, ORM_TOTAL, ORM_TOTID,ORM_TOTAD,ORM_DISP,ORM_STAT, " +
                                            "ORM_DISA,ORM_TOTAI, ORM_VAT, ORM_GRAND,	USER_CODE FROM dbo.SIPPORM ) PM " +
                                            "INNER JOIN  " +
                                            "(SELECT DA.ADD_CODE,DA.DEL_CODE,DA.DEL_NAME,DA.DEL_ADD_1,DA.DEL_ADD_2,DA.DEL_ADD_3,DA.DEL_ADD_4,DA.DEL_ADD_5,DA.DEL_COM_1,DA.DEL_COM_2,DA.DEL_CONT,DA.DEL_EMAIL,DA.DEL_FAX,DA.DEL_TEL,DA.DEL_WEB, " +
                                            "AD.ADD_NAME,AD.ADD_LINE_1, AD.ADD_LINE_2, AD.ADD_LINE_3, AD.ADD_LINE_4, AD.ADD_LINE_5, AD.ADD_TEL, AD.ADD_FAX, AD.ADD_EMAIL, AD.ADD_WEB, AD.ADD_CONT, AD.ADD_COM_1, AD.ADD_COM_2  FROM  " +
                                            "(SELECT ADD_CODE,DEL_CODE,DEL_NAME,DEL_ADD_1,DEL_ADD_2,DEL_ADD_3,DEL_ADD_4,DEL_ADD_5,DEL_COM_1,DEL_COM_2,DEL_CONT, " +
                                            "DEL_EMAIL,DEL_FAX,DEL_TEL,DEL_WEB FROM SIPDADD) DA INNER JOIN " +
                                            "(SELECT ADD_CODE,ADD_NAME, ADD_LINE_1, ADD_LINE_2, ADD_LINE_3, ADD_LINE_4, ADD_LINE_5, ADD_TEL, ADD_FAX, ADD_EMAIL, ADD_WEB, ADD_CONT, ADD_COM_1, ADD_COM_2 " +
                                            " FROM SIPADDR WHERE ADD_TYPE = '1') AD ON DA.ADD_CODE = AD.ADD_CODE )SUP " +
                                            " ON PM.SUP_CODE = SUP.ADD_CODE ) PORM INNER JOIN " +

                                            "(SELECT PD.ORM_REF, PD.ORD_LINE, PD.LOC_CODE, PD.ITEM_CODE, PD.ORD_UNIT, PD.ORD_TYPE, PD.ORD_QTY, PD.ORD_STOCK, PD.ORD_COST, " +
                                            "PD.ORD_SUB, PD.ORD_DISP, PD.ORD_DISA, PD.ORD_TOT, PD.ORD_STAT,ITM.ITEM_DESC,ITM.ITEM_BCODE FROM " +
                                            "(SELECT ORM_REF, ORD_LINE, LOC_CODE, ITEM_CODE, ORD_UNIT, ORD_TYPE, ORD_QTY, ORD_STOCK, ORD_COST, " +
                                            "ORD_SUB, ORD_DISP, ORD_DISA, ORD_TOT, ORD_STAT FROM dbo.SIPPORD ) PD INNER JOIN " +
                                            "(SELECT ITEM_CODE,ITEM_DESC,ITEM_BCODE FROM dbo.SIPITEMS )ITM ON PD.ITEM_CODE = ITM.ITEM_CODE) PORD " +
                                            " ON PORM.ORM_REF = PORD.ORM_REF " +
                                            " WHERE PORM.ORM_STAT = '2' AND PORM.ORM_REF = '" +
                                            TRANS_REF + "'");
                                    
                                    if (tblDataTable.Rows.Count <= 0)
                                    {
                                        MessageBox.Show("There are no purchase order data to be printed.", "No Purchase",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("There are no report format to print purchase order.", "Format Printing",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }

                            Report report = new Report();
                            report.Preview("Print Purchase Form", tblDataTable);





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
                    MessageBox.Show("There are no items for releasing!", "No Item", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (is_Delete)
            {
                var total = dataGridView.SelectedRows[0].Cells[9].Value.ToString();
                var disc = dataGridView.SelectedRows[0].Cells[11].Value.ToString();
                var grandT = dataGridView.SelectedRows[0].Cells[12].Value.ToString();
                txtTotalA.Text = Convert.ToString(Convert.ToDecimal(txtTotalA.Text) - Convert.ToDecimal(total));
                txtDiscountA.Text = Convert.ToString(Convert.ToDecimal(txtDiscountA.Text) - Convert.ToDecimal(disc));
                txtGrandTotal.Text = Convert.ToString(Convert.ToDecimal(txtGrandTotal.Text) - Convert.ToDecimal(grandT));
            }
        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSupCode.Focus();
            }
        }

        private void txtSupCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSupCode.Text != "")
                {
                    var dt =
                        dataManager.GetData(
                            "SELECT ADD_CODE [Sup. Code], ADD_LOOKUP [Lookup], ADD_NAME [Sup. Name],ADD_LINE_1, ADD_LINE_2, ADD_LINE_3, ADD_LINE_4, ADD_LINE_5 FROM dbo.SIPADDR WHERE ADD_TYPE='1' AND ADD_STAT='A' AND UPPER(ADD_CODE) LIKE UPPER('%" +
                            txtSupCode.Text + "') ORDER BY ADD_CODE");
                    txtSupCode.Text = dt.Rows[0][0].ToString();
                    txtSupName.Text = dt.Rows[0][2].ToString();
                    txtSupAdd1.Text = dt.Rows[0][3].ToString();
                    txtSupAdd2.Text = dt.Rows[0][4].ToString();
                    txtSupAdd3.Text = dt.Rows[0][5].ToString();
                    txtSupAdd4.Text = dt.Rows[0][6].ToString();
                    txtSupAdd5.Text = dt.Rows[0][7].ToString();
                    txtDelCode.Focus();
                }
              
             
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnCustCode_Click(null,null);
            }
        }

        private void dtpOrder_Date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComment.Focus();
            }
        }
    }
}
