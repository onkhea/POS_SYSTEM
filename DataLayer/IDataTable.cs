using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.DataLayer
{
    public interface IDataTable
    {
        DataTable Create(params string[] Column);
        DataTable GetData(SqlCommand command);
        void Save(DataTable dataTable, params Control[] controls);
        void Delete(DataTable dataTable, string condition);
        void Delete(DataTable dataTable, int row, string condition);
        void Delete(DataTable dataTable, int i, string condition1, int j, string Condition2);
        DataTable Update(DataTable dataTable, int row, params Control[] controls);
        DataTable Update(DataTable dataTable, string fieldName, string condition, params Control[] controls);
        bool Exists(string tableName, string condtion, string fieldName);
        bool Exists(string tableName, string[] paraAndValue);
        DataTable Filter(DataTable dt, string fieldName, string condition);
        
    }
}