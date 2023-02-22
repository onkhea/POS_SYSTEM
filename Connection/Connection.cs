using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using POS.GUI.User;
using POS.Transaction;


namespace POS.Connection
{
    public class Connection : IConnection
    {
//        public string cnn = @"server=.;database=SIPDB1;user id=sa;password=123456";
        //        public string cnn = @"Integrated Security=True; Data Source=Hp; Initial Catalog=SIPDB1;";

        private string connStr = "";//@"server=.;database=SIPDB1;user id=sa;password=123456";//@"Integrated Security=True; Data Source=Hp; Initial Catalog=SIPDB1; Max Pool Size=5000;Connect Timeout=10000;";
        
        //@"server=.;database=SIPDB1;user id=sa;password=123456";//
        public string ConnStr
        {
            get { return connStr; }
            set { connStr = value; }
        }

        public override SqlConnection Connect()
        {
           connStr = SITempData.Cnn;
           var connection = new SqlConnection(ConnStr);
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
                using (var fileStream = new FileStream(File, FileMode.Create))
                {
                    using (var binaryWriter = new BinaryWriter(fileStream, Encoding.Unicode))
                    {
                        byte[] bytes = Encoding.Unicode.GetBytes(ConnStr);
                        for (var i = 0; i < bytes.Length - 1; i++)
                            binaryWriter.Write(Convert.ToInt32((bytes[i])) + 10);
                        binaryWriter.Close();
                    }
                    fileStream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override void ReadConnectionFromFile()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            try
            {
                var fl = Path.Combine(path, "support.dll");
                if (File.Exists(fl))
                {
                    BinaryReader binaryReader;
                    var fileStream = new FileStream(fl, FileMode.Open);
                    
                    binaryReader = new BinaryReader(fileStream, Encoding.Unicode);
                    
                    var j = binaryReader.ReadBytes(10000).Length;
                    binaryReader.Close();

                    using (var fs = new FileStream(fl, FileMode.Open))
                    {
                        using (var br = new BinaryReader(fs, Encoding.Unicode))
                        {
                            var Str = "";
                            byte[] bytes = br.ReadBytes(j);
                            for (int i = 0; i < j - 1; i = i + 8)
                                Str = Str + Convert.ToChar(Convert.ToInt32(bytes[i]) - 10);
                            SITempData.Cnn = Str;
//                            ConnStr = Str;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}