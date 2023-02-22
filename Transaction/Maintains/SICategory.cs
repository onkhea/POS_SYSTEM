using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using POS.Connection;
using POS.DataLayer;
using POS.GUI.User;

namespace POS.Transaction
{
    public class SICategory : IDataCRUD
    {
        private readonly IConnection connection = new Connection.Connection();
        readonly DataTable dtCate = new DataTable();
        // properties
        public string Code { get; set; }
        public string Desc { get; set; }
        public string Statu { get;set; }

        // constructor
        public SICategory(string SI_TYPE)
        {
            var stringBuilder= new StringBuilder();
            stringBuilder.AppendFormat("SELECT SI_CODE,SI_DATA,SI_LOOKUP FROM SIPDATA WHERE SI_TYPE = '{0}'", SI_TYPE);
            var command = new SqlCommand(stringBuilder.ToString(),connection.Connect());
            var dataManager =new DataManager();
            dtCate = dataManager.GetData(command);
        }

        public DataTable LoadData()
        {
            return dtCate;
        }

        public void Save(string[] values)
        {
            var fields = new string[]
                             {
                                 "SI_CODE", "SI_TYPE", "SI_LOOKUP", "SI_DATA", "USER_UPDT", "DATE_UPDT", "USER_CREA",
                                 "DATE_CREA"
                             };
          DataAccess.SaveData("SIPDATA", fields, values);
        }

        public void Save()
        {
        }

        public void Delete(string value)
        {
            DataAccess.DeleteData("SIPDATA",value,"SI_CODE");
        }

        public void Delete(string[] paramAndValue)
        {
            throw new System.NotImplementedException();
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
            DataAccess.UpdateData("SIPDATA", paramAndValue, condition);
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Update(string[] value, string condition)
        {
           
        }
    }

}