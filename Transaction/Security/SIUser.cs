using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POS.Connection;
using POS.DataLayer;
using POS.GUI.User;

namespace POS.Transaction.Security
{
    public class SIUser : IDataCRUD
    {
        # region variable
        private static DataTable dtUser = new DataTable();
        static readonly DataManager   dataManager = new DataManager();
        private static readonly IConnection connection = new Connection.Connection();
        #endregion

        #region properties

        public static string Code { get; set; }
        public static string Name { get; set; }
        public static string LogOnDate { get; set; }
        public static byte[] Password { get; set; }
        public static string Description { get; set; }
        public static int CPAS { get; set; }
        public static int UState { get; set; }
        public static byte[] ULog { get; set; }
        public static string CreateDate { get; set; }

        #endregion

        #region Constructor

        public SIUser()
        {
            
            var command =
                new SqlCommand(
                    "SELECT USER_CODE,USER_NAME,USER_DESC,USER_CPAS,USER_STAT,USER_LOG, USER_PASS FROM SIPUSERS ORDER BY USER_CODE",
                    connection.Connect());
            dtUser = dataManager.GetData(command);

        }

        #endregion

        public DataTable LoadData()
        {
            return dtUser;
        }

        public void  ShowListView(ListView lv)
        {
            try
            {
                // TODO : Refactory in here
              
                // ============
//                if (UserLogOn.Code != "SISA")
//                {
//                    var concate =
//                        "SELECT USER_CODE,USER_NAME,USER_DESC,USER_CPAS,USER_STAT,USER_LOG FROM SIPUSERS " +
//                        "WHERE USER_CODE " + 
//                        "IN (SELECT USER_CODE FROM dbo.SIPUSERG WHERE PER_TYPE = 'D' AND USER_CODE='" +
//                        Code +
//                        "') UNION SELECT DISTINCT USER_CODE,USER_NAME,USER_DESC,USER_CPAS,USER_STAT," +
//                        "USER_LOG FROM SIPUSERS WHERE USER_CODE IN (SELECT USER_CODE FROM SIPUSERP " +
//                        "WHERE GR_DB_CODE IN (SELECT GR_DB_CODE FROM dbo.SIPUSERP WHERE PER_TYPE = 'D' "+
//                        "AND USER_CODE='" +
//                        Code + "')AND PER_TYPE='G') ORDER BY USER_CODE";
//                    var command = new SqlCommand(concate,connection.Connect());
//                    dtUser = dataManager.GetData(command);
//                }
                lv.Items.Clear();
                ListViewItem ls;
                var str = new string[dtUser.Columns.Count];
                foreach (DataRow row in dtUser.Rows)
                {
                    for (int i = 0; i <= dtUser.Columns.Count - 1; i++)
                    {
                        str[i] = row[i].ToString();
                        var d = System.Text.Encoding.UTF32.GetString((byte[]) row[5]);
                        var cd = d;
                        if (System.Text.Encoding.UTF32.GetString((byte[])row[5]).CompareTo("L") == 0)
                        {
                            str[5] = "Logon";
                        }
                        else
                        {
                            str[5] = "Logout";
                        }
                       
                    }
                    var listViewItem = new ListViewItem(str);
                    lv.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        public void Save(string[] values)
        {
        }

        public void Save()
        {
            try
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO dbo.SIPUSERS (USER_CODE,[USER_NAME],USER_PASS,USER_DESC,USER_CPAS,USER_STAT,USER_LOG) VALUES (@USER_CODE_1,@USER_NAME_2,@USER_PASS_3,@USER_DESC_4,@USER_CPAS_5,@USER_STAT_6,@USER_LOG_7) ",
                        connection.Connect());
                 
                command.Parameters.AddWithValue("@USER_CODE_1", Code);
                command.Parameters.AddWithValue("@USER_NAME_2", Name);
                command.Parameters.AddWithValue("@USER_PASS_3", Password);
                command.Parameters.AddWithValue("@USER_DESC_4", Description);
                command.Parameters.AddWithValue("@USER_CPAS_5", CPAS);
                command.Parameters.AddWithValue("@USER_STAT_6", UState);
                command.Parameters.AddWithValue("@USER_LOG_7", ULog);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void Delete(string value)
        {
            DataAccess.DeleteData("SIPUSERS", value, "USER_CODE");
            DataAccess.DeleteData("SIPUSERG", value, "USER_CODE");
        }

        public void Delete(string[] paramAndValue)
        {
            throw new System.NotImplementedException();
        }

        public void Update(string[] value, string[] condition)
        {
            throw new System.NotImplementedException();
        }

        public void Update()
        {
            try
            {
                var command =
                    new SqlCommand(
                        "UPDATE dbo.SIPUSERS SET USER_CODE = @USER_CODE_1,[USER_NAME] = @USER_NAME_2, USER_PASS = @USER_PASS_3,USER_DESC = @USER_DESC_4,USER_CPAS = @USER_CPAS_5,USER_STAT = @USER_STAT_6, USER_LOG = @USER_LOG_7 WHERE USER_CODE = @USER_CODE_1",
                        connection.Connect());
                command.Parameters.AddWithValue("@USER_CODE_1", Code);
                command.Parameters.AddWithValue("@USER_NAME_2", Name);
                command.Parameters.AddWithValue("@USER_PASS_3", Password);
                command.Parameters.AddWithValue("@USER_DESC_4", Description);
                command.Parameters.AddWithValue("@USER_CPAS_5", CPAS);
                command.Parameters.AddWithValue("@USER_STAT_6", UState);
                command.Parameters.AddWithValue("@USER_LOG_7", ULog);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update(string[] value, string condition)
        {
//            DataAccess.UpdateData("");
        }

        public void UpdateClearLoged(byte[] value, string condition)
        {
            try
            {
                var command = new SqlCommand(
                    "UPDATE dbo.SIPUSERS SET USER_LOG = @USER_LOG_7 WHERE USER_CODE = @USER_CODE_1", connection.Connect());
                command.Parameters.AddWithValue("@USER_CODE_1", condition);
                command.Parameters.AddWithValue("@USER_LOG_7", value);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateChangePassword(string usercode)
        {
            try
            {
                var command =
                    new SqlCommand(
                        "UPDATE dbo.SIPUSERS SET USER_PASS = @USER_PASS_3,USER_CPAS = 1 WHERE USER_CODE = @USER_CODE_1",
                        connection.Connect());
                command.Parameters.AddWithValue("@USER_CODE_1", usercode);
                command.Parameters.AddWithValue("@USER_PASS_3", Password);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateChangeUserLog()
        {
            try
            {
                var command =
                    new SqlCommand(
                        "UPDATE dbo.SIPUSERS SET USER_LOG = @USER_LOG_7 WHERE USER_CODE = @USER_CODE_1",
                        connection.Connect());
                command.Parameters.AddWithValue("@USER_CODE_1", Code);
                command.Parameters.AddWithValue("@USER_LOG_7", ULog);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}