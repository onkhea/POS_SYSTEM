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

namespace POS.GUI.Purchases
{
    public partial class SIPOPURCHASEORDER_View : Form//DevComponents.DotNetBar.Office2007Form
    {
        public SIPOPURCHASEORDER_View()
        {
            InitializeComponent();
        }

        public TreeNode NODET;
        readonly DataManager dataManager = new DataManager();
        public int SELECT_INDEX;
        Connection.Connection connection = new Connection.Connection();

        private void SIPOPURCHASEORDER_View_Load(object sender, EventArgs e)
        {

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NODET = e.Node;
            try
            {
                Cursor = Cursors.WaitCursor;
                var dt = new DataTable();
                DataGridView1.Rows.Clear();
                string str = "";
                switch (NODET.Tag.ToString())
                {
                    case "ALL":
                        str = "ORM_STAT ='1' OR ORM_STAT='2'";
                        break;
                    case "Held":
                        str = "ORM_STAT='1'";
                        break;
                    case "Release":
                        str = "ORM_STAT='2'";
                        break;

                    case "A":
                        str = "ORM_STAT='1' AND ORM_REF='" + e.Node.Text + "'";
                        break;
                    case "B":
                        str = "ORM_STAT='2' AND ORM_REF='" + e.Node.Text + "'";
                        break;
                    case "ReleaseM":
                        str = "ORM_STAT='2'"; //AND VOID_STATUS='N'";
                        break;
                }
                if (str != "")
                {
                    const string strCom = "SELECT PM.ORM_REF,PM.ORM_DATE, PM.ORM_COM, SUP.ADD_CODE,SUP.ADD_NAME,SUP.DEL_CODE,SUP.DEL_NAME,ORM_TOTAL, PM.ORM_TOTID,ORM_TOTAD,PM.ORM_DISP, " +
                                          "PM.ORM_DISA,PM.ORM_TOTAI, PM.ORM_VAT, PM.ORM_GRAND, PM.ORM_STAT, PM.USER_CODE FROM " +
                                          "( SELECT ORM_REF,ORM_DATE, ORM_COM, SUP_CODE, ORM_TOTAL, ORM_TOTID,ORM_TOTAD,ORM_DISP,ORM_STAT, " +
                                          "ORM_DISA,ORM_TOTAI, ORM_VAT, ORM_GRAND,	USER_CODE FROM dbo.SIPPORM ) PM " +
                                          "INNER JOIN " +
                                          "(SELECT DA.ADD_CODE,DA.DEL_CODE,DA.DEL_NAME,AD.ADD_NAME FROM " +
                                          "(SELECT ADD_CODE,DEL_CODE,DEL_NAME FROM SIPDADD) DA INNER JOIN " +
                                          "(SELECT ADD_CODE,ADD_NAME  FROM SIPADDR WHERE ADD_TYPE = '1') AD ON DA.ADD_CODE = AD.ADD_CODE )SUP " +
                                          "ON PM.SUP_CODE = SUP.ADD_CODE WHERE ";
                    var command = new SqlCommand(strCom + str, connection.Connect());
                    dt = dataManager.GetData(command);
                }
                foreach (DataRow row in dt.Rows)
                {
                    DataGridView1.Rows.Add(row[0].ToString().Trim(), row[1], row[2], row[3], row[4],
                                           row[5].ToString().Trim(), row[6].ToString().Trim(), row[7].ToString().Trim(),
                                           row[8].ToString().Trim(), row[9].ToString().Trim(),
                                           row[10].ToString().Trim(),
                                           row[11].ToString().Trim(), row[12].ToString().Trim(),
                                           row[13].ToString().Trim(), row[14].ToString().Trim(), row[15], row[16].ToString().Trim());
                }
                Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                SELECT_INDEX = DataGridView1.SelectedRows[0].Index;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btn_Ok_Click(null, null);
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (DataGridView1.SelectedRows.Count > 0)
                {
                    SELECT_INDEX = DataGridView1.SelectedRows[0].Index;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        private void SIPOPURCHASEORDER_View_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = System.Windows.Forms.DialogResult.No;
            }
        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            if ((string)DataGridView1.SelectedRows[0].Cells[5].Value == "10")
            {
                MessageBox.Show("You can not print purchase order which helding.", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Would you like to Print purchase order?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                var sipopurchaseorder_PRINT_FRM = new SIPOPURCHASEORDER_PRINT_FRM();
                sipopurchaseorder_PRINT_FRM.btnRef1.Enabled = false;
                sipopurchaseorder_PRINT_FRM.txtRef1.Enabled = false;
                sipopurchaseorder_PRINT_FRM.txtRef1.Text = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                sipopurchaseorder_PRINT_FRM.ShowDialog();
                sipopurchaseorder_PRINT_FRM.Close();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((string)DataGridView1.SelectedRows[0].Cells[5].Value == "10")
            {
                MessageBox.Show("You can not print purchase order which helding.", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Are you sure you want to print Purchase order?", "Printing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (!dataManager.Exists("SIREPORT", "Print Purchase Form","REP_TYPE"))
                {
                    MessageBox.Show("Data '" + DataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' does not exists", "Existing", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                var tblDataTable = new DataTable();
                var dt = dataManager.GetData("SELECT REP_DATA FROM SIREPORT", "REP_CODE", "REP_TYPE",
                                             "Print Purchase Form");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0].ToString() != "")
                    {

                        tblDataTable =
                            dataManager.GetData("SELECT * FROM V_PurchaseOrder_Print WHERE [Order Code] = '" +
                                                DataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'");
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
                report.QuickPrint("Print Purchase Form", tblDataTable);
            }
        }

    }
}
