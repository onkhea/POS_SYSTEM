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

namespace POS.GUI.SaleProcessing
{
    public partial class VIEW_CREDIT_NOTE_FRM : Form
    {
        public VIEW_CREDIT_NOTE_FRM()
        {
            InitializeComponent();
        }

        public TreeNode node;
        readonly DataManager dataManager = new DataManager();
        readonly Connection.Connection connection = new Connection.Connection();
        public int selectIndex;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            node = e.Node;
            try
            {
                Cursor = Cursors.WaitCursor;
                dataGridViewX1.Rows.Clear();
                var dtSaleOrder = new DataTable();
                var command = new SqlCommand("", connection.Connect());
                if ((string)e.Node.Tag == "OrderDate")
                {

                    string str =
                        "SELECT SINV.ORD_REF, SINV.INV_REF, SINV.INV_DATE, SINV.CUS_CODE,AD.ADD_NAME, " +
                        "SINV.DEL_CODE, SINV.EMP_CODE, SINV.INV_COM, SINV.INV_TOTAL, " +
                        "SINV.INV_TOTID, SINV.INV_TOTAD,  SINV.INV_DISP, SINV.INV_DISA, " +
                        "SINV.INV_TOTAI, SINV.INV_VAT,  SINV.INV_GRAND, SINV.USER_CODE, " +
                        "SINV.INV_PAY,SINV.INV_POS,SINV.INV_STAT FROM(SELECT dbo.SIPSINVM.ORD_REF, dbo.SIPSINVM.INV_REF, dbo.SIPSINVM.INV_DATE, dbo.SIPSINVM.CUS_CODE, " +
                        "dbo.SIPSINVM.DEL_CODE, dbo.SIPSINVM.EMP_CODE, dbo.SIPSINVM.INV_COM, dbo.SIPSINVM.INV_TOTAL, " +
                        "dbo.SIPSINVM.INV_TOTID, dbo.SIPSINVM.INV_TOTAD,  dbo.SIPSINVM.INV_DISP, dbo.SIPSINVM.INV_DISA, " +
                        "dbo.SIPSINVM.INV_TOTAI, dbo.SIPSINVM.INV_VAT,  dbo.SIPSINVM.INV_GRAND, dbo.SIPSINVM.USER_CODE, " +
                        "INV_PAY,INV_POS,INV_STAT FROM SIPSINVM) SINV INNER JOIN (SELECT ADD_CODE,ADD_NAME FROM SIPADDR WHERE ADD_TYPE = '0') AD ON SINV.CUS_CODE = AD.ADD_CODE " +
                        "WHERE SINV.INV_REF != '' AND SINV.INV_STAT != 'D' AND SINV.INV_PAY = 'N' AND CONVERT(char(6),SINV.INV_DATE,112) = '" +
                        e.Node.Text + "'";
                    command = new SqlCommand(str, connection.Connect());
                    dtSaleOrder = dataManager.GetData(command);
                    dataGridViewX1.Columns[0].Visible = false;
                    checkBox1.Visible = false;
                }
                else if ((string)e.Node.Tag == "CDDate")
                {
                    string str =
                       "SELECT  SINVM.ORD_REF, SINVM.INV_REF, SINVM.INV_DATE,SINVM.CUS_CODE,AD.ADD_NAME,SINVM.DEL_CODE, SINVM.EMP_CODE,SINVM.INV_COM,SINVM.INV_TOTAL,SINVM.INV_TOTID,SINVM.INV_TOTAD, SINVM.INV_DISP,SINVM.INV_DISA,SINVM.INV_TOTAI,SINVM.INV_VAT, SINVM.INV_GRAND, SINVM.USER_CODE,INV_STAT,INV_PAY,INV_POS FROM (SELECT  dbo.SIPSINVM.ORD_REF, dbo.SIPSINVM.INV_REF, dbo.SIPSINVM.INV_DATE, dbo.SIPSINVM.CUS_CODE,dbo.SIPSINVM.DEL_CODE, dbo.SIPSINVM.EMP_CODE, dbo.SIPSINVM.INV_COM, dbo.SIPSINVM.INV_TOTAL, dbo.SIPSINVM.INV_TOTID, dbo.SIPSINVM.INV_TOTAD,  dbo.SIPSINVM.INV_DISP, dbo.SIPSINVM.INV_DISA, dbo.SIPSINVM.INV_TOTAI, dbo.SIPSINVM.INV_VAT,  dbo.SIPSINVM.INV_GRAND, dbo.SIPSINVM.USER_CODE,INV_PAY,INV_POS,INV_STAT FROM dbo.SIPSINVM ) SINVM INNER JOIN (SELECT ADD_CODE,ADD_NAME FROM dbo.SIPADDR " +
                       "WHERE INV_REF != '' AND INV_PAY = 'N' AND INV_CREDIT = 'A' AND CONVERT(char(6),SINVM.INV_DATE,112) = '" + e.Node.Text + "'";
                    command = new SqlCommand(str, connection.Connect());
                    dtSaleOrder = dataManager.GetData(command);
                    dataGridViewX1.Columns[0].Visible = false;
                    checkBox1.Visible = false;
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
                                            row[13], row[14], row[15]);
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void VIEW_CREDIT_NOTE_FRM_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewX1.Rows.Count > 0)
            {
                selectIndex = dataGridViewX1.SelectedRows[0].Index;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              dataGridViewX1_CellContentClick(null,null);
        }
    }
}
