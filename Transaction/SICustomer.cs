using System.Data;
using System.Data.SqlClient;
using POS.DataLayer;

namespace POS.Transaction
{
    class SICustomer
    {
       DataTable  dtCustomer = new DataTable();
       Connection.Connection connection = new Connection.Connection();
       DataManager dataManager = new DataManager();
        public SICustomer()
        {
            var command = new SqlCommand("SELECT * FROM SIPADDR",connection.Connect());
            dtCustomer = dataManager.GetData(command);
        }

        public DataTable LoadData()
        {
            return dtCustomer;
        }
    }
}
