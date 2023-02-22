using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using POS.DataLayer;

namespace POS.Transaction.Maintains
{
    class SIOptions : IDataCRUD
    {
        public DataTable LoadData()
        {
            throw new System.NotImplementedException();
        }

        public void Save(string[] values)
        {
            var fields = new string[] { "SI_CODE", "SI_TYPE", "SI_LOOKUP", "SI_DATA", "USER_UPDT", "DATE_UPDT", "USER_CREA", "DATE_CREA" };
            DataAccess.SaveData("SIPDATA",fields,values);
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
            throw new System.NotImplementedException();
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
            throw new System.NotImplementedException();
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
