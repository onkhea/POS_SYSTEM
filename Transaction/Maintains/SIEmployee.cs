using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Utilities;

namespace POS.Transaction.Maintains
{
    class SIEmployee : IDataCRUD
    {
        #region Global Variable

        readonly Connection.Connection  _connection = new Connection.Connection();
        readonly DataTable dtEmp = new DataTable();
        readonly DataManager dataManager = new DataManager();
        readonly IControlOutLook outLook = new OutLook();
        #endregion

        #region Constructor

        public SIEmployee()
        {
            var command =
                new SqlCommand(
                    "SELECT  SI_CODE, RTRIM(SUBSTRING(SI_DATA, 1, 20)) [SI_NAME], RTRIM(SUBSTRING(SI_DATA, 21, 120)) [SI_Address], RTRIM(SUBSTRING(SI_DATA, 141, 15))[SI_Phone], SI_LOOKUP FROM SIPDATA WHERE SI_TYPE = 'EMP'",
                    _connection.Connect());
            dtEmp = dataManager.GetData(command);
        }

        #endregion

        #region Properties

        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tell { get; set; }
        public string Status { get; set; }

        #endregion

        public DataTable LoadData()
        {
            return dtEmp;
        }

        public void Save(string[] values)
        {
            var fields = new[]
                             {
                                 "SI_CODE", "SI_TYPE", "SI_LOOKUP", "SI_DATA", "USER_UPDT", "DATE_UPDT", "USER_CREA",
                                 "DATE_CREA"
                             };
            DataAccess.SaveData("SIPDATA", fields, values);
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string value)
        {
            DataAccess.DeleteData("SIPDATA", value, "SI_CODE");
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

        public void BindingDataToControl(Control[] controls,DataGridView dgv)
        {
            outLook.BindingDataToControl(controls,dgv);
        }
    }
}