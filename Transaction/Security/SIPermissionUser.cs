using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POS.Connection;
using POS.DataLayer;
using POS.GUI.User;
using POS.Utilities;

namespace POS.Transaction.Security
{
    class SIPermissionUser
    {

        #region global varibale

        readonly DataManager dataManager = new DataManager();
        private readonly IConnection connection = new Connection.Connection();
        readonly DataTable  dtUsGroup = new DataTable();
        readonly IControls controls = new Controls();

        #endregion 

        # region global function

        public DataTable LoadData()
        {
            return dtUsGroup;
        }

        public void ShowListViewSISA(ListView lv)
        {
            var command =
                new SqlCommand(
                    "SELECT DISTINCT GR_DB_CODE, (SELECT RTRIM(SUBSTRING(SI_DATA,1,50)) FROM SIPDATA WHERE SI_CODE=GR_DB_CODE AND SI_TYPE='GROUP') AS DESCRIPTION FROM dbo.SIPUSERG WHERE PER_TYPE = 'G' AND USER_CODE='SISA'", connection.Connect());
            var dtgroup = dataManager.GetData(command);
            controls.Add_ListView(dtgroup, lv);
        }

        public void ShowListView(ListView lv)
        {
            string str =
                string.Format(
                    "SELECT DISTINCT GR_DB_CODE, (SELECT RTRIM(SUBSTRING(SI_DATA,1,50)) FROM SIPDATA WHERE SI_CODE=GR_DB_CODE AND SI_TYPE='GROUP') AS DESCRIPTION FROM dbo.SIPUSERG WHERE PER_TYPE = 'G' AND USER_CODE='{0}'",
                    SELECTED_USERCODE);
            var command = new SqlCommand(str, connection.Connect());
            var dtgroup = dataManager.GetData(command);
            controls.Add_ListView(dtgroup, lv);
        }

        #endregion

        #region Constructor

        public SIPermissionUser()
        {
            var command = new SqlCommand("SELECT * FROM SIPUSERG",connection.Connect());
            dtUsGroup = dataManager.GetData(command);
        }

        #endregion

        #region properties
        
        private static bool show_SYSTEM = false;
        private static bool action_Check = false; 

        public static string SELECTED_USERCODE { get; set; }
        public static string GR_DB_CODE { get; set; }
        public static string PER_TYPE { get; set; }
        public static string PERTYPEDET { get; set; }

        public static bool Action_Check
        {
            get { return action_Check; }
            set { action_Check = value;}
        }

        public static bool Show_SYSTEM
        {
            get { return show_SYSTEM; }
            set { show_SYSTEM = value; }
        }
        
        #endregion

        #region System

        public void LVWMainOnEachTab(ItemCheckedEventArgs e)
        {
          
          var command = new SqlCommand
                            {
                                Connection = connection.Connect(),
                            };
            try
            {
                command.CommandText = e.Item.Checked == true ? "INSERT INTO SIPUSERG VALUES(@USER_CODE,@GR_DB_CODE,@PER_TYPE)" : "DELETE FROM SIPUSERG WHERE USER_CODE=@USER_CODE AND GR_DB_CODE=@GR_DB_CODE AND PER_TYPE=@PER_TYPE";
                //Note: should be uncomment to this code here.
                command.Parameters.AddWithValue("@USER_CODE", SELECTED_USERCODE);
                command.Parameters.AddWithValue("@GR_DB_CODE", e.Item.Text);
                command.Parameters.AddWithValue("@PER_TYPE", "V");
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteUserPermission ()
        {
            try
            {
                var command = new SqlCommand("", connection.Connect())
                                  {
                                      CommandText =
                                          "DELETE FROM SIPUSERP WHERE USER_CODE=@USER_CODE AND GR_DB_CODE=@GR_DB_CODE AND PER_TYPE=@PER_TYPE"
                                  };
                command.Parameters.AddWithValue("@USER_CODE", SELECTED_USERCODE);
                command.Parameters.AddWithValue("@GR_DB_CODE", GR_DB_CODE);
                command.Parameters.AddWithValue("@PER_TYPE", PER_TYPE);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SaveUserPermission(ListView lv)
        {
            var command = new SqlCommand
                              {
                                  Connection = connection.Connect(),
                CommandText =
                    "INSERT INTO SIPUSERP VALUES(@USER_CODE,@GR_DB_CODE,@PER_TYPE,@PER_ACTION)"
            };
            foreach (ListViewItem item in lv.CheckedItems)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@USER_CODE", SIPermissionUser.SELECTED_USERCODE);
                command.Parameters.AddWithValue("@GR_DB_CODE", SIPermissionUser.GR_DB_CODE);
                command.Parameters.AddWithValue("@PER_TYPE", SIPermissionUser.PER_TYPE);
                command.Parameters.AddWithValue("@PER_ACTION", item.Text);
                command.ExecuteNonQuery();
                
            }
        }
            
        #endregion

        #region Groups

        public void SaveUserGroup(ListView lv)
        {
            var command = new SqlCommand
            {
                Connection =  connection.Connect(),
                CommandText =
                    "INSERT INTO dbo.SIPUSERG VALUES(@USER_CODE,@GR_DB_CODE,@PER_TYPE)"
            };
            foreach (ListViewItem item in lv.CheckedItems)
            {
                command.Parameters.AddWithValue("@USER_CODE", SIPermissionUser.SELECTED_USERCODE);
                command.Parameters.AddWithValue("@GR_DB_CODE", item.Text);
                command.Parameters.AddWithValue("@PER_TYPE", "G");
                command.ExecuteNonQuery();
            }
        }

        public void DeleteUserGroup ()
        {
            try
            {
                var command = new SqlCommand("", connection.Connect())
                {
                    CommandText =
                        "DELETE FROM SIPUSERG WHERE USER_CODE=@USER_CODE AND GR_DB_CODE=@GR_DB_CODE AND PER_TYPE=@PER_TYPE"
                };
                command.Parameters.AddWithValue("@USER_CODE", SELECTED_USERCODE);
                command.Parameters.AddWithValue("@GR_DB_CODE", GR_DB_CODE);
                command.Parameters.AddWithValue("@PER_TYPE", "G");
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
