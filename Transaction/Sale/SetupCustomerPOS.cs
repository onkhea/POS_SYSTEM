using System;
using System.Data;
using POS.DataLayer;

namespace POS.Transaction.Sale
{
    class SetupCustomerPOS :IDataCRUD
    {
        readonly DataManager _dataManager = new DataManager();
        readonly DataTable _data = new DataTable();

        #region Constructor

        public  SetupCustomerPOS()
        {
            var dt = _dataManager.GetData("SELECT * FROM SIPCUSPOS");
            _data = dt;
        }

        public SetupCustomerPOS(string locationCode)
        {
            var dt = _dataManager.GetData("SELECT * FROM SIPCUSPOS WHERE LOC_CODE = '" + locationCode + "'");
            _data = dt;
        }

        public SetupCustomerPOS(string location , string employeeCode)
        {
            var dt =
                _dataManager.GetData("SELECT * FROM SIPCUSPOS WHERE LOC_CODE ='" + location + "' AND EMP_CODE = '" +
                                    employeeCode + "'");
            _data = dt;
        }

        #endregion

        #region properties

        public string LocCode { get; set; }
        public string LocName { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserCreate { get; set; }
        public string UserUdpt { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdtDate { get; set; }

        #endregion

        public DataTable LoadData()
        {
            return _data;
        }

        public void Save(string[] values)
        {
            var field = new[]
                            {"EMP_CODE", "LOC_CODE", "ADD_CODE", "USER_CODE", "USER_CRE", "USER_UPDT", "CREA_DATE", "UPDT_DATE"};
            
            DataAccess.SaveData("SIPCUSPOS",field,values);
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
            DataAccess.DeleteData("SIPCUSPOS",paramAndValue);
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
            DataAccess.UpdateData("SIPCUSPOS",paramAndValue,condition);
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
