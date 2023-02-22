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
    class SISupplierDelivery : IDataCRUD
    {
        #region global variable

        readonly DataTable dtSupDelivery = new DataTable();
        readonly DataManager dataManager = new DataManager();
        private readonly IConnection connection = new Connection.Connection();
        
        #endregion

        public SISupplierDelivery()
        {
            var command = new SqlCommand(" SELECT * FROM SIPDADD WHERE DEL_TYPE='1'",connection.Connect());
            dtSupDelivery = dataManager.GetData(command);
        }
        
        public DataTable LoadData()
        {
            return dtSupDelivery;
        }

        public void Save(string[] values)
        {

            var fields = new string[]
                             {
                                 "ADD_CODE", "DEL_CODE", "DEL_NAME", "DEL_ADD_1", "DEL_ADD_2", "DEL_ADD_3", "DEL_ADD_4",
                                 "DEL_ADD_5", "DEL_TEL", "DEL_FAX", "DEL_EMAIL", "DEL_WEB", "DEL_CONT", "DEL_COM_1",
                                 "DEL_COM_2", "DEL_TYPE", "USER_CREA", "USER_UPDT", "USER_CODE"
                             };
            DataAccess.SaveData("SIPDADD",fields,values);
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
            DataAccess.DeleteData("SIPDADD",paramAndValue);
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
            DataAccess.UpdateData("SIPDADD", paramAndValue, condition);
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
