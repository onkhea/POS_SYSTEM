using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction;
using POS.Transaction.Sale;
using POS.Transaction.Security;

namespace POS.GUI.SaleProcessing
{
    public partial class VIEW_SALEORDER_FRM : Form
    {
        public VIEW_SALEORDER_FRM()
        {
            InitializeComponent();
        }

        public TreeNode NoSNote;
        readonly Connection.Connection _connection = new Connection.Connection();
        public int SelectIndex;
        readonly DataManager _dataManager = new DataManager();

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NoSNote = e.Node;
            try
            {
                Cursor = Cursors.WaitCursor;
                dataGridViewX1.Rows.Clear();
                var dtSaleOrder = new DataTable();
                var command = new SqlCommand("",_connection.Connect());
                postInvoiceToolStrip.Enabled = true;
                postInvoicesToolStripMenuItem.Enabled = true;
//                saleOrderToolStrip.Enabled = true;
                saleOrderToolStripMenuItem.Enabled = true;
                if ((string) e.Node.Tag == "HoldDate")
                {

                    string str =
                        "SELECT  SINVM.ORD_REF, SINVM.INV_REF, SINVM.INV_DATE,SINVM.CUS_CODE,AD.ADD_NAME,SINVM.DEL_CODE, SINVM.EMP_CODE,SINVM.INV_COM,SINVM.INV_TOTAL,SINVM.INV_TOTID,SINVM.INV_TOTAD, SINVM.INV_DISP,SINVM.INV_DISA,SINVM.INV_TOTAI,SINVM.INV_VAT, SINVM.INV_GRAND, SINVM.USER_CODE,INV_STAT,INV_PAY,INV_POS FROM (SELECT  dbo.SIPSINVM.ORD_REF, dbo.SIPSINVM.INV_REF, dbo.SIPSINVM.INV_DATE, dbo.SIPSINVM.CUS_CODE,dbo.SIPSINVM.DEL_CODE, dbo.SIPSINVM.EMP_CODE, dbo.SIPSINVM.INV_COM, dbo.SIPSINVM.INV_TOTAL, dbo.SIPSINVM.INV_TOTID, dbo.SIPSINVM.INV_TOTAD,  dbo.SIPSINVM.INV_DISP, dbo.SIPSINVM.INV_DISA, dbo.SIPSINVM.INV_TOTAI, dbo.SIPSINVM.INV_VAT,  dbo.SIPSINVM.INV_GRAND, dbo.SIPSINVM.USER_CODE,INV_PAY,INV_POS,INV_STAT FROM dbo.SIPSINVM ) SINVM INNER JOIN (SELECT ADD_CODE,ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '0' ) AD ON SINVM.CUS_CODE = AD.ADD_CODE WHERE INV_REF = '' AND INV_STAT = 'D' AND INV_PAY = 'N' AND CONVERT(char(6),INV_DATE,112) ='" + e.Node.Text + "'";
                    command = new SqlCommand(str, _connection.Connect());
                    dtSaleOrder = _dataManager.GetData(command);
                    dataGridViewX1.Columns[0].Visible = false;
                    checkBox1.Visible = false;
                }
                else if ((string) e.Node.Tag == "ReleaseDate")
                {
                    string str =
                        "SELECT  SINVM.ORD_REF, SINVM.INV_REF, SINVM.INV_DATE,SINVM.CUS_CODE,AD.ADD_NAME,SINVM.DEL_CODE, SINVM.EMP_CODE,SINVM.INV_COM,SINVM.INV_TOTAL,SINVM.INV_TOTID,SINVM.INV_TOTAD, SINVM.INV_DISP,SINVM.INV_DISA,SINVM.INV_TOTAI,SINVM.INV_VAT, SINVM.INV_GRAND, SINVM.USER_CODE,INV_STAT,INV_PAY,INV_POS FROM (SELECT  dbo.SIPSINVM.ORD_REF, dbo.SIPSINVM.INV_REF, dbo.SIPSINVM.INV_DATE, dbo.SIPSINVM.CUS_CODE,dbo.SIPSINVM.DEL_CODE, dbo.SIPSINVM.EMP_CODE, dbo.SIPSINVM.INV_COM, dbo.SIPSINVM.INV_TOTAL, dbo.SIPSINVM.INV_TOTID, dbo.SIPSINVM.INV_TOTAD,  dbo.SIPSINVM.INV_DISP, dbo.SIPSINVM.INV_DISA, dbo.SIPSINVM.INV_TOTAI, dbo.SIPSINVM.INV_VAT,  dbo.SIPSINVM.INV_GRAND, dbo.SIPSINVM.USER_CODE,INV_PAY,INV_POS,INV_STAT FROM dbo.SIPSINVM ) SINVM INNER JOIN (SELECT ADD_CODE,ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '0' ) AD ON SINVM.CUS_CODE = AD.ADD_CODE WHERE INV_REF = '' AND INV_STAT = 'A' AND INV_PAY = 'N' AND INV_POS = 'D' AND CONVERT(char(6),INV_DATE,112) ='" + e.Node.Text + "'";
                    command = new SqlCommand(str, _connection.Connect());
                    dtSaleOrder = _dataManager.GetData(command);
                    dataGridViewX1.Columns[0].Visible = true;
                    checkBox1.Visible = true;
                }
                else if ((string) e.Node.Tag == "POSDate")
                {
                    
                    string str =
                        "SELECT  SINVM.ORD_REF, SINVM.INV_REF, SINVM.INV_DATE,SINVM.CUS_CODE,AD.ADD_NAME,SINVM.DEL_CODE, SINVM.EMP_CODE,SINVM.INV_COM,SINVM.INV_TOTAL,SINVM.INV_TOTID,SINVM.INV_TOTAD, SINVM.INV_DISP,SINVM.INV_DISA,SINVM.INV_TOTAI,SINVM.INV_VAT, SINVM.INV_GRAND, SINVM.USER_CODE,INV_STAT,INV_PAY,INV_POS FROM (SELECT  dbo.SIPSINVM.ORD_REF, dbo.SIPSINVM.INV_REF, dbo.SIPSINVM.INV_DATE, dbo.SIPSINVM.CUS_CODE,dbo.SIPSINVM.DEL_CODE, dbo.SIPSINVM.EMP_CODE, dbo.SIPSINVM.INV_COM, dbo.SIPSINVM.INV_TOTAL, dbo.SIPSINVM.INV_TOTID, dbo.SIPSINVM.INV_TOTAD,  dbo.SIPSINVM.INV_DISP, dbo.SIPSINVM.INV_DISA, dbo.SIPSINVM.INV_TOTAI, dbo.SIPSINVM.INV_VAT,  dbo.SIPSINVM.INV_GRAND, dbo.SIPSINVM.USER_CODE,INV_PAY,INV_POS,INV_STAT FROM dbo.SIPSINVM ) SINVM INNER JOIN (SELECT ADD_CODE,ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '0' ) AD ON SINVM.CUS_CODE = AD.ADD_CODE WHERE INV_REF = '' AND INV_STAT = 'A' AND INV_PAY = 'N' AND INV_POS = 'A' AND CONVERT(char(6),INV_DATE,112) ='" + e.Node.Text + "'";
                    command = new SqlCommand(str, _connection.Connect());
                    dtSaleOrder = _dataManager.GetData(command);
                    dataGridViewX1.Columns[0].Visible = true;
                    checkBox1.Visible = true;
                }
                else if((string)e.Node.Tag == "InvoiceDate")
                {
                    postInvoiceToolStrip.Enabled = false;
                    postInvoicesToolStripMenuItem.Enabled = false;
//                    saleOrderToolStrip.Enabled = false;
                    saleOrderToolStripMenuItem.Enabled = false;

                    string str =
                        "SELECT  SINVM.ORD_REF, SINVM.INV_REF, SINVM.INV_DATE,SINVM.CUS_CODE,AD.ADD_NAME,SINVM.DEL_CODE, SINVM.EMP_CODE,SINVM.INV_COM,SINVM.INV_TOTAL,SINVM.INV_TOTID,SINVM.INV_TOTAD, SINVM.INV_DISP,SINVM.INV_DISA,SINVM.INV_TOTAI,SINVM.INV_VAT, SINVM.INV_GRAND, SINVM.USER_CODE,INV_STAT,INV_PAY,INV_POS FROM (SELECT  dbo.SIPSINVM.ORD_REF, dbo.SIPSINVM.INV_REF, dbo.SIPSINVM.INV_DATE, dbo.SIPSINVM.CUS_CODE,dbo.SIPSINVM.DEL_CODE, dbo.SIPSINVM.EMP_CODE, dbo.SIPSINVM.INV_COM, dbo.SIPSINVM.INV_TOTAL, dbo.SIPSINVM.INV_TOTID, dbo.SIPSINVM.INV_TOTAD,  dbo.SIPSINVM.INV_DISP, dbo.SIPSINVM.INV_DISA, dbo.SIPSINVM.INV_TOTAI, dbo.SIPSINVM.INV_VAT,  dbo.SIPSINVM.INV_GRAND, dbo.SIPSINVM.USER_CODE,INV_PAY,INV_POS,INV_STAT FROM dbo.SIPSINVM ) SINVM INNER JOIN (SELECT ADD_CODE,ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '0' ) AD ON SINVM.CUS_CODE = AD.ADD_CODE " +
                        "WHERE INV_REF != '' AND INV_STAT = 'A' AND INV_PAY = 'N' AND CONVERT(char(6),INV_DATE,112) ='" +
                        e.Node.Text + "'";
                    command = new SqlCommand(str, _connection.Connect());
                    dtSaleOrder = _dataManager.GetData(command);
                }
                if (dtSaleOrder.Rows.Count == 0)
                {
                    Cursor = Cursors.Default;
                    return;
                }
                foreach (DataRow row in dtSaleOrder.Rows)
                {
                    dataGridViewX1.Rows.Add(false,row[0], row[1], Convert.ToDateTime(row[2]).ToShortDateString(), row[3],
                                            row[4], row[8], row[6], row[5], row[7], row[9], row[10], row[11], row[12],
                                            row[13],row[14], row[15]);
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewX1.Rows.Count > 0)
            {
                SelectIndex = dataGridViewX1.SelectedRows[0].Index;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void postInvoiceToolStrip_Click(object sender, EventArgs e)
        
        {
            try
            {
               
                Cursor = Cursors.WaitCursor;
                if (dataGridViewX1.Rows.Count == 0)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("No data to Post.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (_dataManager.Exists("SIPSINVM", dataGridViewX1.SelectedRows[0].Cells[1].Value.ToString(), "ORD_REF", "INV_STAT", "D"))
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Must be release first.", "Hold", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                for (int j = 0; j < dataGridViewX1.Rows.Count; j++)
                {
                    dataGridViewX1.EndEdit();
                    if (Convert.ToBoolean(dataGridViewX1.Rows[j].Cells[0].Value) == true)
                    {


                        var inv_Ref = SIAutoNumber.SO_AutoNumber();
                        var command =
                            new SqlCommand(
                                "UPDATE dbo.SIPSINVM SET INV_REF = '" + inv_Ref + "' WHERE ORD_REF = '" +
                                dataGridViewX1.Rows[j].Cells[1].Value.ToString() + "' AND INV_STAT = 'A'",
                                _connection.Connect());
                        command.ExecuteNonQuery();
                        command =
                            new SqlCommand(
                                "UPDATE dbo.SIPSINVD SET INV_REF = '" + inv_Ref + "' WHERE ORD_REF = '" +
                                dataGridViewX1.Rows[j].Cells[1].Value.ToString() + "'", _connection.Connect());
                        command.ExecuteNonQuery();

                        //                =================== Post into Stock ===================
                        var sequance = 1;
                        if (DataAccess.ReturnField("SELECT MAX(SEQUENCE) FROM dbo.SIPINMOV", 0) != "")
                        {
                            sequance =
                                Convert.ToInt16(DataAccess.ReturnField("SELECT MAX(SEQUENCE) FROM dbo.SIPINMOV", 0)) + 1;
                        }
                        var dtSIIPNVD = _dataManager.GetData("SELECT * FROM dbo.SIPSINVD", "ORD_REF", "ORD_REF",
                                                             dataGridViewX1.Rows[j].Cells[1].Value.ToString());
                        command = new SqlCommand("", _connection.Connect());
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "SI_INSERT_SIPINMOV_STOCK";
                        var i = 0;
                        //                ====================== GET COST ==============
                        //                SELECT COST FROM dbo.SIPINMOV WHERE LOCATION = '' AND MOV_UNITS = '' AND ITEM_CODE = ''
                        foreach (DataRow row in dtSIIPNVD.Rows)
                        {
                            command.Parameters.Clear();
                            var UNIT =
                                DataAccess.ReturnField(
                                    "SELECT UNIT_STOCK FROM SIPITEMS WHERE ITEM_CODE = '" + row[3] + "'", 0);
                            var condition = new string[]
                                                {
                                                    "LOCATION", row[2].ToString(), "MOV_UNITS", UNIT, "ITEM_CODE",
                                                    row[3].ToString()
                                                };
                            var cost = DataAccess.ReturnField("SELECT COST FROM dbo.SIPINMOV", "ITEM_CODE", condition, 0);

                            Commands.CreateParameter(command, "SEQUENCE_0", sequance, "REC_TYPE_1", row[13],
                                                     "MOV_DATE_7",
                                                     DateTime.Now,
                                                     "MOV_REF_3",
                                                     dataGridViewX1.Rows[j].Cells[1].Value.ToString(),
                                                     "MOV_LINE_4",
                                                     string.Format("{0:0000}", i + 1), "LOCATION_5",
                                                     row[2], "ITEM_CODE_6", row[3],
                                                     "STATUS_8", "80", "IR_STAT_9", "R", "LINE_REF_12", "",
                                                     "QUANTITY_13", Convert.ToDecimal(row[7]),
                                                     "COST_14", Convert.ToDecimal(cost), "TOTAL_15",
                                                     Convert.ToDecimal(row[12]),
                                                     "MOV_UNITS_16", UNIT, "MOV_TYPE_17", "", "ALLOC_REF_20", "",
                                                     "ORIG_LINE_NO_33", "", "PO_VALUE_34", 0, "ID_ENTERED_35",
                                                     UserLogOn.Code,
                                                     "ID_ALLOC_36", "", "LOC_TRAN_48", "");
                            command.ExecuteNonQuery();

                        }
                        
                        dataGridViewX1.Rows.RemoveAt(j);
                        j = j - 1;
                        Cursor = Cursors.Default;
                    }
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void OkToolStrip_Click(object sender, EventArgs e)
        {
            dataGridViewX1_CellDoubleClick(null,null);
        }

        private void postInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            postInvoiceToolStrip_Click(sender,e);
        }

        private void okToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OkToolStrip_Click(sender,e);
        }

        private void VIEW_SALEORDER_FRM_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

            var i = 0;
            SaleOrder saleOrder = new SaleOrder();
            Cursor = Cursors.WaitCursor;
            dataGridViewX1.Rows.Clear();
            var dtSaleOrder = new DataTable();
            treeView1.Nodes[0].Nodes[0].Nodes.Clear();
            treeView1.Nodes[0].Nodes[1].Nodes.Clear();
            treeView1.Nodes[0].Nodes[2].Nodes.Clear();
            treeView1.Nodes[0].Nodes[3].Nodes.Clear();
            
            foreach (var time in saleOrder.HoldDateTime())
            {

                treeView1.Nodes[0].Nodes[0].Nodes.Add(time, time, 1, 1).Tag = "HoldDate";
                treeView1.Nodes[0].Nodes[0].Nodes[i].ImageIndex = 5;
                treeView1.Nodes[0].Nodes[0].Nodes[i].SelectedImageIndex = 5;
                i++;
            }
            i = 0;
            foreach (var time in saleOrder.ReleaseDateTime())
            {
                treeView1.Nodes[0].Nodes[1].Nodes.Add(time, time, 1, 1).Tag = "ReleaseDate";
                treeView1.Nodes[0].Nodes[1].Nodes[i].ImageIndex = 5;
                treeView1.Nodes[0].Nodes[1].Nodes[i].SelectedImageIndex = 5;
                i++;
            }

            i = 0;
            foreach (var time in saleOrder.POSReleaseDateTime())
            {
                treeView1.Nodes[0].Nodes[2].Nodes.Add(time, time, 1, 1).Tag = "POSDate";
                treeView1.Nodes[0].Nodes[2].Nodes[i].ImageIndex = 5;
                treeView1.Nodes[0].Nodes[2].Nodes[i].SelectedImageIndex = 5;
                i++;
            }

            i = 0;
            foreach (var time in saleOrder.InvoiceDateTime())
            {
                treeView1.Nodes[0].Nodes[3].Nodes.Add(time, time, 1, 1).Tag = "InvoiceDate";
                treeView1.Nodes[0].Nodes[3].Nodes[i].ImageIndex = 5;
                treeView1.Nodes[0].Nodes[3].Nodes[i].SelectedImageIndex = 5;
                i++;
            }
            var command = new SqlCommand("", _connection.Connect());
            Cursor = Cursors.Default;
//            if ((string)e.Node.Tag == "HoldDate")
//            {
//
//                string str =
//                    "SELECT  SINVM.ORD_REF, SINVM.INV_REF, SINVM.INV_DATE,SINVM.CUS_CODE,AD.ADD_NAME,SINVM.DEL_CODE, SINVM.EMP_CODE,SINVM.INV_COM,SINVM.INV_TOTAL,SINVM.INV_TOTID,SINVM.INV_TOTAD, SINVM.INV_DISP,SINVM.INV_DISA,SINVM.INV_TOTAI,SINVM.INV_VAT, SINVM.INV_GRAND, SINVM.USER_CODE,INV_STAT,INV_PAY,INV_POS FROM (SELECT  dbo.SIPSINVM.ORD_REF, dbo.SIPSINVM.INV_REF, dbo.SIPSINVM.INV_DATE, dbo.SIPSINVM.CUS_CODE,dbo.SIPSINVM.DEL_CODE, dbo.SIPSINVM.EMP_CODE, dbo.SIPSINVM.INV_COM, dbo.SIPSINVM.INV_TOTAL, dbo.SIPSINVM.INV_TOTID, dbo.SIPSINVM.INV_TOTAD,  dbo.SIPSINVM.INV_DISP, dbo.SIPSINVM.INV_DISA, dbo.SIPSINVM.INV_TOTAI, dbo.SIPSINVM.INV_VAT,  dbo.SIPSINVM.INV_GRAND, dbo.SIPSINVM.USER_CODE,INV_PAY,INV_POS,INV_STAT FROM dbo.SIPSINVM ) SINVM INNER JOIN (SELECT ADD_CODE,ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '0' ) AD ON SINVM.CUS_CODE = AD.ADD_CODE WHERE INV_REF = '' AND INV_STAT = 'D' AND INV_PAY = 'N' AND CONVERT(char(6),INV_DATE,112) ='" + e.Node.Text + "'";
//                command = new SqlCommand(str, _connection.Connect());
//                dtSaleOrder = _dataManager.GetData(command);
//                dataGridViewX1.Columns[0].Visible = false;
//                checkBox1.Visible = false;
//            }
//            else if ((string)e.Node.Tag == "ReleaseDate")
//            {
//                string str =
//                    "SELECT  SINVM.ORD_REF, SINVM.INV_REF, SINVM.INV_DATE,SINVM.CUS_CODE,AD.ADD_NAME,SINVM.DEL_CODE, SINVM.EMP_CODE,SINVM.INV_COM,SINVM.INV_TOTAL,SINVM.INV_TOTID,SINVM.INV_TOTAD, SINVM.INV_DISP,SINVM.INV_DISA,SINVM.INV_TOTAI,SINVM.INV_VAT, SINVM.INV_GRAND, SINVM.USER_CODE,INV_STAT,INV_PAY,INV_POS FROM (SELECT  dbo.SIPSINVM.ORD_REF, dbo.SIPSINVM.INV_REF, dbo.SIPSINVM.INV_DATE, dbo.SIPSINVM.CUS_CODE,dbo.SIPSINVM.DEL_CODE, dbo.SIPSINVM.EMP_CODE, dbo.SIPSINVM.INV_COM, dbo.SIPSINVM.INV_TOTAL, dbo.SIPSINVM.INV_TOTID, dbo.SIPSINVM.INV_TOTAD,  dbo.SIPSINVM.INV_DISP, dbo.SIPSINVM.INV_DISA, dbo.SIPSINVM.INV_TOTAI, dbo.SIPSINVM.INV_VAT,  dbo.SIPSINVM.INV_GRAND, dbo.SIPSINVM.USER_CODE,INV_PAY,INV_POS,INV_STAT FROM dbo.SIPSINVM ) SINVM INNER JOIN (SELECT ADD_CODE,ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '0' ) AD ON SINVM.CUS_CODE = AD.ADD_CODE WHERE INV_REF = '' AND INV_STAT = 'A' AND INV_PAY = 'N' AND INV_POS = 'D' AND CONVERT(char(6),INV_DATE,112) ='" + e.Node.Text + "'";
//                command = new SqlCommand(str, _connection.Connect());
//                dtSaleOrder = _dataManager.GetData(command);
//                dataGridViewX1.Columns[0].Visible = true;
//                checkBox1.Visible = true;
//            }
//            else if ((string)e.Node.Tag == "POSDate")
//            {
//
//                string str =
//                    "SELECT  SINVM.ORD_REF, SINVM.INV_REF, SINVM.INV_DATE,SINVM.CUS_CODE,AD.ADD_NAME,SINVM.DEL_CODE, SINVM.EMP_CODE,SINVM.INV_COM,SINVM.INV_TOTAL,SINVM.INV_TOTID,SINVM.INV_TOTAD, SINVM.INV_DISP,SINVM.INV_DISA,SINVM.INV_TOTAI,SINVM.INV_VAT, SINVM.INV_GRAND, SINVM.USER_CODE,INV_STAT,INV_PAY,INV_POS FROM (SELECT  dbo.SIPSINVM.ORD_REF, dbo.SIPSINVM.INV_REF, dbo.SIPSINVM.INV_DATE, dbo.SIPSINVM.CUS_CODE,dbo.SIPSINVM.DEL_CODE, dbo.SIPSINVM.EMP_CODE, dbo.SIPSINVM.INV_COM, dbo.SIPSINVM.INV_TOTAL, dbo.SIPSINVM.INV_TOTID, dbo.SIPSINVM.INV_TOTAD,  dbo.SIPSINVM.INV_DISP, dbo.SIPSINVM.INV_DISA, dbo.SIPSINVM.INV_TOTAI, dbo.SIPSINVM.INV_VAT,  dbo.SIPSINVM.INV_GRAND, dbo.SIPSINVM.USER_CODE,INV_PAY,INV_POS,INV_STAT FROM dbo.SIPSINVM ) SINVM INNER JOIN (SELECT ADD_CODE,ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '0' ) AD ON SINVM.CUS_CODE = AD.ADD_CODE WHERE INV_REF = '' AND INV_STAT = 'A' AND INV_PAY = 'N' AND INV_POS = 'A' AND CONVERT(char(6),INV_DATE,112) ='" + e.Node.Text + "'";
//                command = new SqlCommand(str, _connection.Connect());
//                dtSaleOrder = _dataManager.GetData(command);
//                dataGridViewX1.Columns[0].Visible = true;
//                checkBox1.Visible = true;
//            }
//            else if ((string)e.Node.Tag == "InvoiceDate")
//            {
//                postInvoiceToolStrip.Enabled = false;
//                postInvoicesToolStripMenuItem.Enabled = false;
//                //                    saleOrderToolStrip.Enabled = false;
//                saleOrderToolStripMenuItem.Enabled = false;
//
//                string str =
//                    "SELECT  SINVM.ORD_REF, SINVM.INV_REF, SINVM.INV_DATE,SINVM.CUS_CODE,AD.ADD_NAME,SINVM.DEL_CODE, SINVM.EMP_CODE,SINVM.INV_COM,SINVM.INV_TOTAL,SINVM.INV_TOTID,SINVM.INV_TOTAD, SINVM.INV_DISP,SINVM.INV_DISA,SINVM.INV_TOTAI,SINVM.INV_VAT, SINVM.INV_GRAND, SINVM.USER_CODE,INV_STAT,INV_PAY,INV_POS FROM (SELECT  dbo.SIPSINVM.ORD_REF, dbo.SIPSINVM.INV_REF, dbo.SIPSINVM.INV_DATE, dbo.SIPSINVM.CUS_CODE,dbo.SIPSINVM.DEL_CODE, dbo.SIPSINVM.EMP_CODE, dbo.SIPSINVM.INV_COM, dbo.SIPSINVM.INV_TOTAL, dbo.SIPSINVM.INV_TOTID, dbo.SIPSINVM.INV_TOTAD,  dbo.SIPSINVM.INV_DISP, dbo.SIPSINVM.INV_DISA, dbo.SIPSINVM.INV_TOTAI, dbo.SIPSINVM.INV_VAT,  dbo.SIPSINVM.INV_GRAND, dbo.SIPSINVM.USER_CODE,INV_PAY,INV_POS,INV_STAT FROM dbo.SIPSINVM ) SINVM INNER JOIN (SELECT ADD_CODE,ADD_NAME FROM dbo.SIPADDR WHERE ADD_TYPE = '0' ) AD ON SINVM.CUS_CODE = AD.ADD_CODE " +
//                    "WHERE INV_REF != '' AND INV_STAT = 'A' AND INV_PAY = 'N' AND CONVERT(char(6),INV_DATE,112) ='" +
//                    e.Node.Text + "'";
//                command = new SqlCommand(str, _connection.Connect());
//                dtSaleOrder = _dataManager.GetData(command);
//            }
//            if (dtSaleOrder.Rows.Count == 0)
//            {
//                Cursor = Cursors.Default;
//                return;
//            }
//            foreach (DataRow row in dtSaleOrder.Rows)
//            {
//                dataGridViewX1.Rows.Add(false, row[0], row[1], Convert.ToDateTime(row[2]).ToShortDateString(), row[3],
//                                        row[4], row[8], row[6], row[5], row[7], row[9], row[10], row[11], row[12],
//                                        row[13], row[14], row[15]);
//            }
            Cursor = Cursors.Default;

//            if ((string) treeView1.SelectedNode.Tag == "Hold")
//            {
//                var dt =
//                    _dataManager.GetData(
//                        "SELECT CONVERT(NVARCHAR,YEAR(INV_DATE))+ CONVERT(NVARCHAR,MONTH(INV_DATE)) PERRIOD " +
//                        "FROM SIPSINVM WHERE INV_REF = '' AND INV_STAT = 'D' AND INV_PAY = 'N'	AND INV_POS = 'D' AND INV_CREDIT ='D'");
//                var N = new TreeNode();
//                treeView1.Nodes[0].Nodes.Clear();
//                foreach (DataRow row in dt.Rows)
//                {
//                    N = treeView1.Nodes[0].Nodes.Add(row[0].ToString(),row[0].ToString(), 1, 1);
//                    N.Tag = row[0];
//                   
//                }
//            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
                for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                {
                    if (checkBox1.Checked)
                    {
                        dataGridViewX1.Rows[i].Cells[0].Value = true;
                    }
                    else
                    {
                        dataGridViewX1.Rows[i].Cells[0].Value = false;
                    }
                }
            

          
        }

    }
}
