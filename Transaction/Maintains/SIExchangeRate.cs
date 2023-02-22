using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using POS.Connection;
using POS.DataLayer;
using POS.GUI.User;

namespace POS.Transaction.Maintains
{
    class SIExchangeRate : IDataCRUD
    {
        private readonly IConnection connection = new Connection.Connection();
        DataTable dtExchangRate   = new DataTable();
        DataManager datamaManager = new DataManager();

        #region Constructor

        public SIExchangeRate()
        {
            var command = new SqlCommand("SELECT * FROM dbo.SIPOSRATE",connection.Connect());
            dtExchangRate = datamaManager.GetData(command);
        }

        #endregion

        public DataTable LoadData()
        {
            return dtExchangRate;
        }

        public void Save(string[] values)
        {
            var field = new string[] { "EX_DATE", "EX_RATE", "EX_DESC" };
            DataAccess.SaveData("SIPOSRATE",field,values);
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
            DataAccess.DeleteData("SIPOSRATE",paramAndValue);
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
            
        }

        public void Update()
        {
        }

        public void Update(string[] value, string condition)
        {
            string str = string.Format("UPDATE SIPOSRATE SET EX_RATE = {0}, EX_DESC = '{1}' WHERE EX_DATE = '{2}'",
                                       value[0], value[1], condition);
            var command = new SqlCommand(str,connection.Connect());
            command.ExecuteNonQuery();
        }
    }
}
