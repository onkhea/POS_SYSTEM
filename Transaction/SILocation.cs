using System.Data;
using System.Data.SqlClient;
using POS.Connection;
using POS.DataLayer;

namespace POS.Transaction
{
    public class SILocation
    {
        readonly SqlCommand command = new SqlCommand();
        private readonly IConnection connection = new Connection.Connection();
        readonly DataManager dataManager = new DataManager();
        readonly DataTable dtLocation = new DataTable();

        public SILocation()
        {
            command = new SqlCommand("SELECT * FROM dbo.SIPLOCA ORDER BY LOC_CODE ASC",connection.Connect());
            dtLocation = dataManager.GetData(command);
        }

        public DataTable LoadData()
        {
            return dtLocation;
        }

    }
}