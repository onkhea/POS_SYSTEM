using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Utilities;

namespace POS.Transaction.Security
{
    class SIUserGroups : IDataCRUD
    {
        #region Global variable 
        private DataTable dtUserGroup = new DataTable();
        DataManager dataManager = new DataManager();
        Connection.Connection connection = new Connection.Connection();
        #endregion

        #region Constructor
        public SIUserGroups()
        {
            var command =
                new SqlCommand(
                    "SELECT SI_CODE,RTRIM(SUBSTRING(SI_DATA,1,50)),(CASE WHEN SI_LOOKUP='A' THEN 'Active' ELSE 'Disable' END) STATUS FROM SIPDATA WHERE SI_TYPE = 'GROUP'", connection.Connect());
            dtUserGroup = dataManager.GetData(command);
        }

        #endregion 

        public DataTable LoadData()
        {
            return dtUserGroup;
        }

        public void Save(string[] values)
        {
            var fields = new string[]
                                 {"SI_CODE","SI_TYPE", "SI_LOOKUP", "SI_DATA", "USER_UPDT", "DATE_UPDT", "USER_CREA", "DATE_CREA"};

            DataAccess.SaveData("SIPDATA", fields,values);
        }

        public void Save()
        {
//          Me.Cursor = Cursors.WaitCursor
//                    Dim CMD As New SqlClient.SqlCommand("INSERT INTO SIPUSERG VALUES(@USER_CODE,@GR_DB_CODE,@PER_TYPE)", CN)
//                    CMD.Transaction = CN.BeginTransaction
//                    Try
//                        Dim Item As ListViewItem
//                        For Each Item In .ListView1.CheckedItems
//                            Dim ITM As ListViewItem
//                            ITM = ListView2.Items.Add(Item.Text)
//                            ITM.SubItems.Add(Item.SubItems(1).Text)
//                            CMD.Parameters.Clear()
//                            CreatePar(CMD, "USER_CODE", Item.Text, "GR_DB_CODE", ListView1.SelectedItems(0).Text, "PER_TYPE", "G")
//                            CMD.ExecuteNonQuery()
//                        Next
//                        CMD.Transaction.Commit()
//                        Me.Cursor = Cursors.Default
        }

        public void SaveUserGroup(ListView lv,ListView HeadListView)
        {
            try
            {
                var command = new SqlCommand("INSERT INTO SIPUSERG VALUES(@USER_CODE,@GR_DB_CODE,@PER_TYPE)", connection.Connect());
                foreach (ListViewItem item in lv.CheckedItems)
                {
                    command.Parameters.AddWithValue("@USER_CODE", item.Text);
                    command.Parameters.AddWithValue("@GR_DB_CODE", HeadListView.SelectedItems[0].Text);
                    command.Parameters.AddWithValue("@PER_TYPE", "G");
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void Delete(string value)
        {
            DataAccess.DeleteData("SIPDATA", value, "SI_CODE");
        }

        public void Delete(string[] paramAndValue)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUserGroup(ListView lv, ListView HeadListView)
        {
            var strings = new string[]{"USER_CODE",lv.SelectedItems[0].Text,"GR_DB_CODE",HeadListView.SelectedItems[0].Text,"PER_TYPE","G"};
            DataAccess.DeleteData("SIPUSERG", strings );
        }

        public void Update(string[] fieldAndValue, string[] condition)
        {
            DataAccess.UpdateData("SIPDATA", fieldAndValue, condition);
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Update(string[] value, string condition)
        {
            throw new System.NotImplementedException();
        }

        public void ShowListView(ListView lv)
        {
            try
            {
                lv.Items.Clear();
                ListViewItem lvItem;
                var siUserGroups =new SIUserGroups();
                dtUserGroup = siUserGroups.LoadData();
                foreach (DataRow row in dtUserGroup.Rows)
                {
                    lvItem = lv.Items.Add(row[0].ToString());
                    lvItem.SubItems.Add(row[1].ToString());
                    lvItem.SubItems.Add(row[2].ToString());
                    lvItem.ImageIndex = (string) row[2] == "Active" ? 0 : 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Show_Data_In_List_Of_ShowInter(ListView lv,ListView SelectHeadList)
        {
            try
            {
               var command =
               new SqlCommand(
                   "SELECT USER_CODE,USER_NAME FROM SIPUSERS WHERE USER_CODE NOT IN(SELECT USER_CODE FROM SIPUSERG WHERE GR_DB_CODE='" +
                   SelectHeadList.SelectedItems[0].Text + "' AND PER_TYPE='G')", connection.Connect());
                var dtUser = dataManager.GetData(command);
                var controls = new Controls();
                controls.Add_ListView(dtUser, lv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}

