using System.Data;
using System.Data.SqlClient;

namespace POS.DataLayer
{
    public interface IDataCRUD
    {
        DataTable LoadData();
        void Save(string[] values);
        void Save();
        void Delete(string value);
        void Delete(string[] paramAndValue);
        void Update(string[] paramAndValue, string[] condition);
        void Update();
        void Update(string[] value, string condition);
     
    }
}