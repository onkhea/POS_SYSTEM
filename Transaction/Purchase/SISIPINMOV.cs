using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace POS.Transaction.Purchase
{
    class SISIPINMOV
    {
        readonly Connection.Connection connection = new Connection.Connection();
        public string Return_Line_Ref(string ORM_REF)
        {
            var command = new SqlCommand("SELECT * FROM dbo.SIPINMOV WHERE MOV_REF ='" + ORM_REF + "' ORDER BY MOV_LINE ASC",
                                         connection.Connect());
            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            var i = "";
            foreach (DataRow row in dataTable.Rows)
            {
                i = string.Format("{0:0000}", Convert.ToInt16(row[4].ToString()) + 1);
            }
            return i;
        }
    }
}
