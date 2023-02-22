using System;
using System.Data;
using POS.DataLayer;

namespace POS.Transaction.Report.UnitConversion
{
    public class UnitConvertReport : IDataCRUD 
    {
        

        public DataTable LoadData()
        {
            throw new NotImplementedException();
        }

        public void Save(string[] values)
        {
            var field = new[]
                                 {
                                     "SI_CODE", "SI_TYPE", "SI_LOOKUP", "SI_DATA", "USER_UPDT", "DATE_UPDT", "USER_CREA",
                                     "DATE_CREA"
                                 };
            DataAccess.SaveData("SIPDATA",field,values);   
           
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Delete(string value)
        {
            throw new NotImplementedException();
        }

        public void Delete(string[] paramAndValue)
        { 
           DataAccess.DeleteData("SIPDATA",paramAndValue);
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
           DataAccess.UpdateData("SIPDATA",paramAndValue,condition);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Update(string[] value, string condition)
        {
            throw new NotImplementedException();
        }
    }
}