using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.GUI.Inventory;
using POS.Utilities;

namespace POS.Transaction.Inventory
{
    class MovementEntry
    {
        Connection.Connection connection = new Connection.Connection();
        public Decimal GetItem(string type, string location_Code, string Item_code)
        {
            Decimal QTY = 0;
            try
            {
                var movementLine = new SIMOVEMENTLINE_FRM();
               
                var command = new SqlCommand("", connection.Connect());
                if (type == "O")
                {
                    command.CommandText = "SELECT dbo.ON_HOLD(@LOCATION,@ITEM_CODE)";
                    Commands.CreateParameter(command, "LOCATION", location_Code, "ITEM_CODE", Item_code);
                }
                else
                {
                    command.CommandText = "SELECT dbo.PHYSICAL(@LOCATION,@ITEM_CODE)";
                    Commands.CreateParameter(command, "LOCATION", location_Code, "ITEM_CODE", Item_code);
                }

                var dataAdapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.Rows[0][0] != Convert.DBNull)
                {
                    QTY = Convert.ToDecimal(dt.Rows[0][0]);
                }
                if (type == "O")
                {
                    if (movementLine.IS_EDIT == false)
                    {
                        QTY = QTY + SIDataGridView.Sum(movementLine.dataGridViewX1, 5, location_Code, 1, Item_code, 3);
                    }
                    else
                    {
                        Decimal SEL_QTY = 0;
                        if ((string) movementLine.dataGridViewX1.SelectedRows[0].Cells[1].Value == location_Code &&
                            (string) movementLine.dataGridViewX1.SelectedRows[0].Cells[3].Value == Item_code)
                        {
                            SEL_QTY = Convert.ToDecimal(movementLine.dataGridViewX1.SelectedRows[0].Cells[5].Value);
                        }
                        QTY += SIDataGridView.Sum(movementLine.dataGridViewX1, 5, location_Code, 1, Item_code, 3) -
                               SEL_QTY;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " with Item_Inventory");
            }
            return QTY;
        }

        public Decimal Avaiable_Stock(string location, string itemCode, int Sequence)
        {
            var command = new SqlCommand("SELECT dbo.PHYSICAL(@location,@itemCode) - dbo.ON_HOLD(@location,@itemCode) - dbo.SIPINMOH_QTY(@location,@itemCode)",connection.Connect());
            Commands.CreateParameter(command, "location", location, "itemCode", itemCode);
            var dataAdapter = new SqlDataAdapter(command);
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            return Convert.ToDecimal(dt.Rows[0][0].ToString()) + Current_pickQty(Sequence, location, itemCode);
        }
        public Decimal Current_pickQty(int Sequence, string location, string itemCode)
        {
            var command =
                new SqlCommand(
                    "SELECT SUM(QUANTITY)  FROM SIPINMOH WHERE IR_STAT<>'I' AND STATUS='10' AND LOCATION=@LOCATION AND ITEM_CODE=@ITEM_CODE AND SEQUENCE=@SEQ",
                    connection.Connect());
            Commands.CreateParameter(command, "SEQ", Sequence, "LOCATION", location, "ITEM_CODE", itemCode);
            var dataAdapter = new SqlDataAdapter(command);
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            Decimal qty = 0;
            if (dt.Rows[0][0] != Convert.DBNull)
            {
                qty = Convert.ToDecimal(dt.Rows[0][0].ToString());
            }
            return qty;
        }

    }
}
