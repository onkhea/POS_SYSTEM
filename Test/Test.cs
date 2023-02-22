using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
using POS.DataLayer;


namespace POS.Test
{
    [TestFixture]
    public class Test
    {
        Connection.Connection connection = new Connection.Connection();
        DataManager dataManager = new DataManager();

        [Test]
        public void GetYear()
        {
            var command = new SqlCommand("SELECT INV_DATE FROM dbo.SIPSINVM", connection.Connect());
            var dt = dataManager.GetData(command);
            int d = 0;
            foreach (DataRow  row in dt.Rows)
            {
                 d = Convert.ToDateTime(row[0]).Year;
            }
            MessageBox.Show(d.ToString());
            
        }
    }
}
