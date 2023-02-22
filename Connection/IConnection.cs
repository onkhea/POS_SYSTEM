using System.Data.SqlClient;

namespace POS.Connection
{
    public abstract class IConnection
    {
        protected IConnection()
        {
            
        }

        public abstract SqlConnection Connect();
        public abstract string SetupConnection(string serverName, string database, string userId, string password);
        public abstract void WriteConnectionToFile();
        public abstract void ReadConnectionFromFile();

    }
}