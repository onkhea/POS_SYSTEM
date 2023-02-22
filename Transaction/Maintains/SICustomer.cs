using System.Data;
using System.Data.SqlClient;
using POS.DataLayer;

namespace POS.Transaction.Maintains
{
    class SICustomer : IDataCRUD
    {
        DataTable  dtCustomer = new DataTable();
        Connection.Connection connection = new Connection.Connection();
        DataManager dataManager = new DataManager();
        
        // Constructor
        public SICustomer()
        {
            var command = new SqlCommand("SELECT * FROM SIPADDR WHERE ADD_TYPE = 0", connection.Connect());
            dtCustomer = dataManager.GetData(command);
        }

        public DataTable LoadData()
        {
            return dtCustomer;
        }

        public void Save(string[] values)
        {
            var fields = new string[]
                                  {
                                      "ADD_CODE", "ADD_LOOKUP", "ADD_NAME", "ADD_LINE_1", "ADD_LINE_2", "ADD_LINE_3",
                                      "ADD_LINE_4", "ADD_LINE_5", "ADD_TEL", "ADD_FAX", "ADD_EMAIL", "ADD_WEB", "ADD_CONT",
                                      "ADD_COM_1", "ADD_COM_2", "ADD_STAT", "ADD_TYPE", "TRANS_PRES", "USER_CREA",
                                      "USER_UPDT", "USER_CODE"
                                  };
            DataAccess.SaveData("SIPADDR",fields,values);
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string value)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string[] paramAndValue)
        {
            DataAccess.DeleteData("SIPADDR",paramAndValue);
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
            DataAccess.UpdateData("SIPADDR", paramAndValue, condition);
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Update(string[] value, string condition)
        {
            throw new System.NotImplementedException();
        }
    }
}