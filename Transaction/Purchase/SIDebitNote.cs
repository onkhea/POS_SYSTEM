using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using POS.Utilities;

namespace POS.Transaction.Purchase
{
    class SIDebitNote
    {
        readonly Connection.Connection connection = new Connection.Connection();
        public string Return_Line_Ref(string ORM_REF)
        {
            var command = new SqlCommand("SELECT * FROM dbo.SIPPORD WHERE ORM_REF='" + ORM_REF + "' ORDER BY ORD_LINE ASC",
                                         connection.Connect());
            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            var i = "";
            foreach (DataRow row in dataTable.Rows)
            {
                i = string.Format("{0:000}", Convert.ToInt16(row[1].ToString()) + 1);
            }
            return i;
        }

        public List<string> YearWithMonth()
        {
            var formats = new SIFormats();
            var MY = new List<string>();
            var listYear = formats.Year("SELECT DISTINCT DATEPART(\"Year\",ORM_DATE) FROM dbo.SIPPORM");
            foreach (var year in listYear)
            {
                var listMonth = formats.Month("SELECT DISTINCT DATEPART(\"MM\",ORM_DATE) FROM dbo.SIPPORM WHERE YEAR(ORM_DATE) = '" + year + "'");
                foreach (var month in listMonth)
                {
                    MY.Add(year+month);    
                }
            }
            return MY;
        }
    }
}
