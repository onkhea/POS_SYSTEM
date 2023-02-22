using System;
using System.Data;
using System.Data.SqlClient;
using NUnit.Framework;
using POS.DataLayer;

namespace POS.Test
{
    [TestFixture]
    public class TestDataAccess
    {
        Connection.Connection  connection = new Connection.Connection();

        [Test]
        public void Load_Data_Should_Be_True()
        {
            var sqlCommand = new SqlCommand("SELECT TOP 1 * FROM SIPDATA");
            var dt = DataAccess.LoadData(sqlCommand);
            Assert.AreEqual(dt.Rows.Count,1);
        }
        
        [Test]
        public void Save_Data_Should_Be_True()
        {
            var fields = new string[]
                             {
                                 "SI_CODE", "SI_TYPE", "SI_LOOKUP", "SI_DATA", "USER_UPDT", "DATE_UPDT", "USER_CREA",
                                 "DATE_CREA"
                             };
            var da = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00");
            var values = new string[] {"123", "236", "11", "ddd", "", da, "123", da};
            DataAccess.SaveData("SIPDATA",fields,values);
            var sqlCommand = new SqlCommand("SELECT TOP 1 * FROM SIPDATA WHERE SI_CODE = '123'");
            var dt = DataAccess.LoadData(sqlCommand);
            Assert.AreEqual(dt.Rows.Count,1);
        }

        [Test]
        public void Delete_Data_Should_Be_True()
        {
            DataAccess.DeleteData("SIPDATA", "123","SI_CODE");
            var sqlCommand = new SqlCommand("SELECT TOP 1 * FROM SIPDATA WHERE SI_CODE = '123'");
            var dt = DataAccess.LoadData(sqlCommand);
            Assert.AreEqual(dt.Rows.Count, 0);
        }

        [Test]
        public void Delete_Data_Multi_Condition_Should_Be_True()
        {
            var strings = new string[]{"USER_CODE","TON","GR_DB_CODE","MARKETING","PER_TYPE","G"};
            DataAccess.DeleteData("SIPUSERG",strings);

            var sqlCommand = new SqlCommand("SELECT * FROM SIPUSERG WHERE USER_CODE = 'TON'");
            var dt = DataAccess.LoadData(sqlCommand);
            Assert.AreEqual(dt.Rows.Count, 0);
        }

        [Test]
        public void Update_Data_Should_Be_True ()
        {
            var fields = new string[]
                             {
                                 "SI_TYPE", "SI_LOOKUP", "SI_DATA", "USER_UPDT", "DATE_UPDT", "USER_CREA",
                                 "DATE_CREA"
                             };
            var da = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00");
            var values = new string[] {"CATE", "99999", "CCCCCCCC", "", da, "5656", da };
            DataAccess.UpdateData("SIPDATA", fields, values, "SI_CODE", "123");

            var sqlCommand = new SqlCommand("SELECT TOP 1 * FROM SIPDATA WHERE SI_CODE = '123' And SI_DATA = 'CCCCCCCC'");
            var dt = DataAccess.LoadData(sqlCommand);
            Assert.AreEqual(dt.Rows.Count, 1);
        }

        [Test]
        public void Update_Data_Multi_Condition_Should_Be_Tru()
        {
            var da = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00");
            var fields = new string[]
                             {
                                 "SI_LOOKUP","A", "SI_DATA","Accountant", "USER_UPDT","SISA", "DATE_UPDT",da, "USER_CREA","SISA",
                                 "DATE_CREA",da
                             };

            var condition = new string[] { "SI_CODE", "ACCOUTING", "SI_TYPE", "GROUP" };
            DataAccess.UpdateData("SIPDATA", fields,condition);

            var sqlCommand = new SqlCommand("SELECT TOP 1 * FROM SIPDATA WHERE SI_CODE = 'ACCOUTING' And SI_TYPE = 'GROUP'");
            var dt = DataAccess.LoadData(sqlCommand);
            Assert.AreEqual(dt.Rows.Count, 1);
        }

        [Test]
        public void ReturnField_Should_be_Return_Value_By_FieldName()
        {
            //===== Given=======
            var condition = new string[] {"ITEM_CODE","256"};
            //===== When =======
            var value = DataAccess.ReturnField("SELECT * FROM SIPITEMS", "ITEM_CODE", condition, "ITEM_BCODE");

            //===== Then =======
            
            Assert.AreEqual("3333",value);

        }

        [Test]
        public void ReturnField_Should_be_Return_Value_By_FieldInteger()
        {
            //===== Given=======
            var condition = new string[] { "ITEM_CODE", "256" };
            //===== When =======
            var value = DataAccess.ReturnField("SELECT * FROM SIPITEMS", "ITEM_CODE", condition, 1);

            //===== Then =======

            Assert.AreEqual("3333", value);

        }

        [Test]
        public void GetValue_With_LiKE_Operator_Should_Be_Return_Number_Of_Row()
        {
            var command = new SqlCommand("Select * from SIPPORD WHERE ORD_LINE LIKE @ORD_LINE", connection.Connect());
            command.Parameters.AddWithValue("@ORD_LINE", "00101%");
            var dataAdapter = new SqlDataAdapter(command);
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            Assert.AreEqual(2,dt.Rows.Count);
        }


    }
}