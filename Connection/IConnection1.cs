namespace POS.Connection
{
    public interface IConnection1
    {
        string ConnStr { get; set; }

        void ReadConnectionFromFile();
        string SetupConnection(string serverName, string database, string userId, string password);
        void WriteConnectionToFile();
    }
}