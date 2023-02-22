using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Utilities;

namespace POS.Transaction.Maintains
{
    class SIUnitConversion : IDataCRUD
    {
        #region Global variable

        readonly DataTable dtUnitCovnersion = new DataTable();
        readonly Connection.Connection  connection = new Connection.Connection();
        readonly DataManager dataManager = new DataManager();
        readonly OutLook outLook = new OutLook();
        #endregion 

        #region Constructor

        public SIUnitConversion()
        {
            var command = new SqlCommand("SELECT CONV_FROM, CONV_F_DESC, CONV_F_DESCKH, CONV_TO, CONV_T_DESC, CONV_T_DESCKH,(CASE WHEN OPERATOR='*' THEN 'Multiply' ELSE 'Divide' END) OPERATOR, FACTOR, TRANS_PRES, USER_CREA, USER_UPDT, USER_CODE FROM dbo.SIUNITCONV", connection.Connect());
            dtUnitCovnersion = dataManager.GetData(command);
        }

        #endregion

        #region Properties

        public string Conv_From { get; set; }
        public string Convert_From_Desc { get; set; }
        public string Convert_FromDescKh { get; set; }
        public string Convrt_To { get; set; }
        public string Convert_To_Desc { get; set; }
        public string Convert_To_DescKh { get; set; }
        public string Aggregation { get; set; }
        public string Factor { get; set; }
        public string Trans_Pres { get; set; }
        public string UserCreate { get; set; }
        public string UserUPDT { get; set; }
        public string UserCode { get; set; }

        #endregion

        public DataTable LoadData()
        {
            return dtUnitCovnersion;
        }

        public void Save(string[] values)
        {
            var fields = new string[]
                             {
                                 "CONV_FROM", "CONV_F_DESC", "CONV_F_DESCKH", "CONV_TO", "CONV_T_DESC", "CONV_T_DESCKH",
                                 "OPERATOR", "FACTOR", "TRANS_PRES", "USER_CREA", "USER_UPDT", "USER_CODE"
                             };
            DataAccess.SaveData("SIUNITCONV",fields,values);
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
            DataAccess.DeleteData("SIUNITCONV",paramAndValue);
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
            DataAccess.UpdateData("SIUNITCONV", paramAndValue, condition);
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Update(string[] value, string condition)
        {
            throw new System.NotImplementedException();
        }

        public List<object> GetConvertTo()
        {
            var qry = (from row in dtUnitCovnersion.AsEnumerable()
                       select row["CONV_TO"]).Distinct().ToList();
            
            return qry;
        }

        public void BindingDataToControl(Control[] controls, DataGridView dgw )
        {
           outLook.BindingDataToControl(controls,dgw);     
        }
    }
}
