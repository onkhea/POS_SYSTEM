using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using POS.GUI.User;

namespace POS.GUI.User
{
    public class Connection :IConnection
    {
        private string connStr = "";// @"Integrated Security=True; Data Source=Hp; Initial Catalog=SIPDB1; Max Pool Size=5000;Connect Timeout=10000;";

        public string ConnStr
        {
            get { return connStr; }
            set { connStr = value; }
        }

        public override SqlConnection ConnectDB()
        {
             var  connection = new SqlConnection(ConnStr);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
           
           
            return connection;
        }

        public override string SetupConnection(string serverName, string database, string userId, string password)
        {
            return ConnStr = string.Format("SERVER={0};DATABASE={1};USER ID={2};PASSWORD={3};", serverName, database, userId,
                                           password);
        }

        public override void WriteConnectionToFile()
        {
            try
            {
                var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                var File = Path.Combine(path, "support.dll");
                var fileStream = new FileStream(File, FileMode.Create);
                var binaryWriter = new BinaryWriter(fileStream, Encoding.Unicode);
                var bytes = new byte[] {};
                bytes = Encoding.Unicode.GetBytes(ConnStr);
                for (int i = 0; i < bytes.Length - 1; i++)
                {
                    binaryWriter.Write(Convert.ToInt32((bytes[i])) + 10);
                }
                binaryWriter.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override void ReadConnectionFromFile()
        {
            try
            {
                var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                if (File.Exists(path))
                {
                    var fileStream = new FileStream(path,FileMode.Open);
                    var binaryReader = new BinaryReader(fileStream,Encoding.Unicode);
                    var j = binaryReader.ReadBytes(10000).Length;
                    binaryReader.Close();

                    var fs = new FileStream(path,FileMode.Open);
                    var br = new BinaryReader(fs,Encoding.Unicode);
                    var bytes = new byte[]{};
                    var Str = "";
                    bytes = br.ReadBytes(j);
                    for (int i = 0; i < j - 1; i = i + 8)
                    {
                        Str = Str + Convert.ToChar(Convert.ToInt32(bytes[i]) - 10);
                    }
                    ConnStr = Str;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}