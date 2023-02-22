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

namespace POS.GUI.Inventory
{
    public partial class SIHELDMOVEMENT_FRM : DevComponents.DotNetBar.Office2007Form
    {
        public SIHELDMOVEMENT_FRM()
        {
            InitializeComponent();
        }

        Connection.Connection connection = new Connection.Connection();
        DataManager dataManager = new DataManager();
        public int SELECT_INDEX = 0;

        private void SIHELDMOVEMENT_FRM_Load(object sender, EventArgs e)
        {

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var dt = new DataTable();
               dataGridViewX1.Rows.Clear();
                if ((string) TreeView1.Tag == "Tran")
                {
                    if (e.Node.Text == "All Held")
                    {
                        var command =
                            new SqlCommand(
                                "SELECT SEQUENCE,MOV_REF,MOV_TYPE ,MOV_DATE,SUM(QUANTITY) AS QUANTITY,SUM(TOTAL) AS TOTAL,ID_ENTERED FROM dbo.SIPINMOH WHERE STATUS = '10' AND IR_STAT = 'T' GROUP BY SEQUENCE,MOV_REF,MOV_TYPE,MOV_DATE,ID_ENTERED,REC_TYPE,TOTAL",
                                connection.Connect());

                        dt = dataManager.GetData(command);
                    }
                    else
                    {
                        var command =
                            new SqlCommand(
                                "SELECT SEQUENCE,MOV_REF,MOV_TYPE ,MOV_DATE,SUM(QUANTITY) AS QUANTITY,SUM(TOTAL) AS TOTAL,ID_ENTERED FROM dbo.SIPINMOH WHERE STATUS = '10' AND IR_STAT = 'T' AND MOV_PRD = '" + e.Node.Text + "'GROUP BY SEQUENCE,MOV_REF,MOV_TYPE,MOV_DATE,ID_ENTERED,REC_TYPE,TOTAL",
                                connection.Connect());

                        dt = dataManager.GetData(command);
                    }
                }
                else
                {
                    if (e.Node.Text == "All Held")
                    {
                        var command =
                            new SqlCommand(
                                "SELECT SEQUENCE,MOV_REF,MOV_TYPE ,MOV_DATE,SUM(QUANTITY) AS QUANTITY,SUM(TOTAL) AS TOTAL,ID_ENTERED FROM dbo.SIPINMOH WHERE STATUS = '10' AND IR_STAT != 'T' GROUP BY SEQUENCE,MOV_REF,MOV_TYPE,MOV_DATE,ID_ENTERED,REC_TYPE,TOTAL",
                                connection.Connect());

                        dt = dataManager.GetData(command);
                    }
                    else
                    {
                        var command =
                            new SqlCommand(
                                "SELECT SEQUENCE,MOV_REF,MOV_TYPE ,MOV_DATE,SUM(QUANTITY) AS QUANTITY,SUM(TOTAL) AS TOTAL,ID_ENTERED FROM dbo.SIPINMOH WHERE STATUS = '10' AND IR_STAT != 'T' AND MOV_PRD = '" + e.Node.Text + "'GROUP BY SEQUENCE,MOV_REF,MOV_TYPE,MOV_DATE,ID_ENTERED,REC_TYPE,TOTAL",
                                connection.Connect());

                        dt = dataManager.GetData(command);
                    }
                }
               

                foreach (DataRow row in dt.Rows)
                {
                    dataGridViewX1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5],row[6]);
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cursor = Cursors.Default;
            }
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count  > 0 )
            {
                SELECT_INDEX = dataGridViewX1.SelectedRows[0].Index;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridViewX1.SelectedRows.Count > 0)
                {
                    SELECT_INDEX = dataGridViewX1.SelectedRows[0].Index;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                SELECT_INDEX = dataGridViewX1.SelectedRows[0].Index;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewX1_CellContentClick(null,null);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand("", connection.Connect())
                              {
                                  CommandType = CommandType.Text,
                                  CommandText = "DELETE FROM SIPINMOH WHERE [SEQUENCE]=@SEQ"
                              };
            command.Parameters.AddWithValue("@SEQ", dataGridViewX1.SelectedRows[0].Cells[0].Value.ToString());
            command.ExecuteNonQuery();
            dataGridViewX1.Rows.RemoveAt(dataGridViewX1.SelectedRows[0].Cells[0].RowIndex);
        }
    }
}
