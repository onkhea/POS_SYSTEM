using System;
using System.Data;
using POS.DataLayer;

namespace POS.Transaction.Report
{
    class Report : IDataCRUD
    {
        DataTable _dtReport = new DataTable();
        readonly DataManager _dataManager = new DataManager();

        public DataTable LoadData()
        {
            _dtReport = _dataManager.GetData("SELECT [REP_CODE],[REP_DESC],[REP_TYPE],[REP_STAT],[USER_UPDT],[DATE_UPDT],[USER_CREA],[DATE_CREA] FROM SIREPORT");
            return _dtReport;
        }

        public void Save(string[] values)
        {
            var fields = new[]
                             {
                                 "REP_CODE", "REP_TYPE", "REP_DESC", "REP_STAT","REP_DATA", "USER_UPDT", "DATE_UPDT",
                                 "USER_CREA", "DATE_CREA"
                             };
            DataAccess.SaveData("SIREPORT",fields,values);   
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
            DataAccess.DeleteData("SIREPORT",paramAndValue);
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
            DataAccess.UpdateData("SIREPORT",paramAndValue,condition);
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
