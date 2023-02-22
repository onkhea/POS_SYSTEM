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

namespace POS.GUI.Purchases
{
    public partial class SIDEBIT_NOTE_VIEW : Form//DevComponents.DotNetBar.Office2007Form
    {
        public SIDEBIT_NOTE_VIEW()
        {
            InitializeComponent();
        }
        public TreeNode NoDET;
        public int SelectIndex;
        readonly DataManager dataManager = new DataManager();
        Connection.Connection connection = new Connection.Connection();
        private bool isPost = false;

        private void SIDEBIT_NOTE_VIEW_Load(object sender, EventArgs e)
        {
         
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NoDET = e.Node;
            try
            {
                Cursor = Cursors.WaitCursor;
                dataGridViewX1.Rows.Clear();
                var dtInvoiceM = new DataTable();
                var command = new SqlCommand();
                isPost = true;
                if ((string)e.Node.Tag == "Posted Invoice")
                {
//                    command = new SqlCommand("SELECT dbo.SIPPORM.ORM_DATE, dbo.SIPPORM.ORM_REF,dbo.SIPADDR.ADD_NAME, SUM(dbo.SIPPORD.ORD_TOT)AS ORD_TOT, dbo.SIPPORM.USER_CODE, dbo.SIPPORM.SUP_CODE, dbo.SIPPORD.ORD_STAT  FROM dbo.SIPPORD INNER JOIN dbo.SIPPORM ON dbo.SIPPORD.ORM_REF = dbo.SIPPORM.ORM_REF INNER JOIN dbo.SIPADDR  ON dbo.SIPPORM.SUP_CODE = dbo.SIPADDR.ADD_CODE WHERE dbo.SIPPORD.ORD_STAT = 'A' AND dbo.SIPPORD.ORD_TOT > 0 GROUP BY dbo.SIPPORM.ORM_DATE, dbo.SIPPORM.SUP_CODE, dbo.SIPPORM.ORM_REF, dbo.SIPPORD.ORD_STAT, dbo.SIPPORM.USER_CODE, dbo.SIPADDR.ADD_NAME, dbo.SIPPORD.ORM_REF,dbo.SIPPORD.ORD_TOT ", connection.Connect());
                    command = new SqlCommand(String.Format("SELECT PORM.ORM_DATE,PORM.ORM_REF, PORM.ADD_NAME, PORD.Total [ORD_TOT],PORM.USER_CODE,PORM.SUP_CODE,PORM.ORM_STAT FROM (SELECT PM.ORM_REF,PM.ORM_DATE, SUP.ADD_NAME, PM.ORM_STAT, PM.USER_CODE,PM.SUP_CODE FROM(SELECT ORM_REF,ORM_DATE, ORM_COM, SUP_CODE, ORM_TOTAL, ORM_TOTID,ORM_TOTAD,ORM_DISP,ORM_STAT, ORM_DISA,ORM_TOTAI, ORM_VAT, ORM_GRAND,	USER_CODE FROM dbo.SIPPORM ) PM INNER JOIN (SELECT DA.ADD_CODE,DA.DEL_CODE,DA.DEL_NAME, AD.ADD_NAME FROM (SELECT ADD_CODE,DEL_CODE,DEL_NAME, DEL_EMAIL,DEL_FAX,DEL_TEL,DEL_WEB FROM SIPDADD) DA INNER JOIN (SELECT ADD_CODE,ADD_NAME  FROM SIPADDR WHERE ADD_TYPE = '1') AD ON DA.ADD_CODE = AD.ADD_CODE )SUP  ON PM.SUP_CODE = SUP.ADD_CODE ) PORM INNER JOIN (SELECT ORM_REF, SUM(ORD_TOT)[Total] FROM SIPPORD WHERE ORD_STAT = 'A' AND ORD_QTY  > 0 GROUP BY ORM_REF,ORD_TOT) PORD  ON  PORM.ORM_REF = PORD.ORM_REF"), connection.Connect());
                   dtInvoiceM = dataManager.GetData(command);
                }
                else if ((string) e.Node.Tag == "A")
                {
                    command = new SqlCommand("SELECT PORM.ORM_DATE,PORM.ORM_REF, PORM.ADD_NAME, PORD.Total [ORD_TOT],PORM.USER_CODE,PORM.SUP_CODE,PORM.ORM_STAT FROM (SELECT PM.ORM_REF,PM.ORM_DATE, SUP.ADD_NAME, PM.ORM_STAT, PM.USER_CODE,PM.SUP_CODE FROM(SELECT ORM_REF,ORM_DATE, ORM_COM, SUP_CODE, ORM_TOTAL, ORM_TOTID,ORM_TOTAD,ORM_DISP,ORM_STAT, ORM_DISA,ORM_TOTAI, ORM_VAT, ORM_GRAND,	USER_CODE FROM dbo.SIPPORM ) PM INNER JOIN (SELECT DA.ADD_CODE,DA.DEL_CODE,DA.DEL_NAME, AD.ADD_NAME FROM (SELECT ADD_CODE,DEL_CODE,DEL_NAME, DEL_EMAIL,DEL_FAX,DEL_TEL,DEL_WEB FROM SIPDADD) DA INNER JOIN (SELECT ADD_CODE,ADD_NAME  FROM SIPADDR WHERE ADD_TYPE = '1') AD ON DA.ADD_CODE = AD.ADD_CODE )SUP  ON PM.SUP_CODE = SUP.ADD_CODE ) PORM INNER JOIN (SELECT ORM_REF, SUM(ORD_TOT)[Total] FROM SIPPORD WHERE ORD_STAT = 'A' AND ORD_QTY  > 0 GROUP BY ORM_REF,ORD_TOT) PORD  ON  PORM.ORM_REF = PORD.ORM_REF" +
                      " WHERE  MONTH(PORM.ORM_DATE) = '" + e.Node.Text.Substring(4) + "' AND YEAR(PORM.ORM_DATE) ='" + e.Node.Text.Substring(0, 4) + "'",connection.Connect());
                    dtInvoiceM = dataManager.GetData(command);
                }
                else if ((string)e.Node.Tag == "Posted Debit Note")
                {
                    command =
                        new SqlCommand("SELECT PORM.ORM_DATE,PORM.ORM_REF, PORM.ADD_NAME, PORD.Total * -1 [ORD_TOT],PORM.USER_CODE,PORM.SUP_CODE,PORM.ORM_STAT FROM (SELECT PM.ORM_REF,PM.ORM_DATE, SUP.ADD_NAME, PM.ORM_STAT, PM.USER_CODE,PM.SUP_CODE FROM(SELECT ORM_REF,ORM_DATE, ORM_COM, SUP_CODE, ORM_TOTAL, ORM_TOTID,ORM_TOTAD,ORM_DISP,ORM_STAT, ORM_DISA,ORM_TOTAI, ORM_VAT, ORM_GRAND,	USER_CODE FROM dbo.SIPPORM ) PM INNER JOIN (SELECT DA.ADD_CODE,DA.DEL_CODE,DA.DEL_NAME, AD.ADD_NAME FROM (SELECT ADD_CODE,DEL_CODE,DEL_NAME, DEL_EMAIL,DEL_FAX,DEL_TEL,DEL_WEB FROM SIPDADD) DA INNER JOIN (SELECT ADD_CODE,ADD_NAME  FROM SIPADDR WHERE ADD_TYPE = '1') AD ON DA.ADD_CODE = AD.ADD_CODE )SUP  ON PM.SUP_CODE = SUP.ADD_CODE ) PORM INNER JOIN (SELECT ORM_REF, SUM(ORD_TOT)[Total] FROM SIPPORD WHERE ORD_STAT = 'N' AND ORD_QTY  < 0 GROUP BY ORM_REF,ORD_TOT) PORD  ON  PORM.ORM_REF = PORD.ORM_REF", connection.Connect());
                    dtInvoiceM = dataManager.GetData(command);
                    isPost = false;
                    
                }
                if (dtInvoiceM.Rows.Count == 0)
                {
                    Cursor = Cursors.Default;
                        return;
                   
                }
                
                foreach (DataRow row in dtInvoiceM.Rows)
                {
                    dataGridViewX1.Rows.Add(row[0],row[1],row[2],row[3],row[4],row[5],row[6]);
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
            if (dataGridViewX1.Rows.Count > 0)
            {
                if (isPost)
                {
                    SelectIndex = dataGridViewX1.SelectedRows[0].Index;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewX1_CellContentClick(null,null);
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            dataGridViewX1_CellContentClick(null,null);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
