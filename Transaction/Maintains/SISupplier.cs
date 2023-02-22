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
    class SISupplier : IDataCRUD
    {
        private IConnection connection = new Connection.Connection();
        DataTable dtSupplier = new DataTable();
        DataManager dataManager = new DataManager();

        #region Constructor

        public SISupplier()
        {
            var command = new SqlCommand("SELECT * FROM dbo.SIPADDR WHERE ADD_TYPE = '1'", connection.Connect());
            dtSupplier = dataManager.GetData(command);
        }

        #endregion

        #region properties

        public string Code { get; set; }
        public string Suplookup { get;  set; }
        public string Name { get;  set; }
        public string Address1 { get;  set; }
        public string Address2 { get;  set; }
        public string Address3 { get;  set; }
        public string Address4 { get;  set; }
        public string Address5 { get;  set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Contact { get; set; }
        public string Commun1 { get; set; }
        public string Commun2 { get; set; }
        public string Status { get; set; }
        public string Add_Type { get; set; }
        public string TransPresent { get; set; }
        public string UserCreate { get; set; }
        public string UserUPDT { get; set; }
        public string UserCode { get; set; }

        #endregion


        public DataTable LoadData()
        {
            return dtSupplier;
        }

        public void Save(string[] values)
        {
            var fields = new string[]
                                  {
                                      "ADD_CODE", "ADD_LOOKUP", "ADD_NAME", "ADD_LINE_1", "ADD_LINE_2", "ADD_LINE_3",
                                      "ADD_LINE_4", "ADD_LINE_5", "ADD_TEL", "ADD_FAX", "ADD_EMAIL"
                                      ,"ADD_WEB", "ADD_CONT", "ADD_COM_1", "ADD_COM_2", "ADD_STAT", "ADD_TYPE",
                                      "TRANS_PRES", "USER_CREA", "USER_UPDT", "USER_CODE"
                                  };
            DataAccess.SaveData("SIPADDR",fields,values);
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string value)
        {
            DataAccess.DeleteData("SIPDELA",value,"ADD_CODE");
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

        public DataTable LoadDeleteSupplier()
        {
            var command = new SqlCommand("SELECT DEL_CODE,DEL_NAME FROM SIPDADD WHERE DEL_TYPE='1'",connection.Connect());
            var dtSup = dataManager.GetData(command);
            return dtSup;
        }

        public DataTable LoadInEditSupplier(string addCode)
        {
            var command = new SqlCommand("SELECT DL.ADD_CODE,DL.DEL_CODE,DD.DEL_NAME FROM (SELECT ADD_CODE,DEL_CODE FROM SIPDELA) DL INNER JOIN (SELECT DEL_CODE,DEL_NAME FROM SIPDADD)  DD ON DD.DEL_CODE = DL.DEL_CODE WHERE DL.ADD_CODE ='" + addCode + "'", connection.Connect());
            var dtSup = dataManager.GetData(command);
            return dtSup; 
        }

    }
}
