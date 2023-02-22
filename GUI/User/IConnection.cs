using System.Data.SqlClient;

namespace POS.GUI.User
{
    public abstract class IConnection
    {
        public abstract SqlConnection ConnectDB();
        public abstract string SetupConnection(string serverName, string database, string userId, string password);
        public abstract void WriteConnectionToFile();
        public abstract void ReadConnectionFromFile();
    }
}