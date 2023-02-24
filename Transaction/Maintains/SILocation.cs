using System.Data;
using System.Data.SqlClient;
using POS.Connection;
using POS.DataLayer;

namespace POS.Transaction.Maintains
{
    public class SILocation : IDataCRUD
    {
        readonly SqlCommand _command = new SqlCommand();
        private readonly Connection.Connection _connection = new Connection.Connection();
        readonly DataManager _dataManager = new DataManager();
        readonly DataTable _dtLocation = new DataTable();

        public SILocation()
        {
            //_command = new SqlCommand("SELECT * FROM dbo.SIPLOCA ORDER BY LOC_CODE ASC",_connection.Connect());
            //_dtLocation = _dataManager.GetData(_command);
        }

        public DataTable LoadData()
        {
            return _dtLocation;
        }

        public void Save(string[] values)
        {
            var fields = new[] { "LOC_CODE", "LOC_NAME", "LOC_STAT", "USER_CODE" };
            DataAccess.SaveData("SIPLOCA",fields,values);
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string value)
        {
            DataAccess.DeleteData("SIPLOCA", value,"LOC_CODE");
        }

        public void Delete(string[] paramAndValue)
        {
            throw new System.NotImplementedException();
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
            DataAccess.UpdateData("SIPLOCA", paramAndValue, condition);
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