using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using NUnit.Framework;
using POS.DataLayer;

namespace POS.Test
{
    [TestFixture]
    public class TestCommand
    {
        Connection.Connection connection = new Connection.Connection();
        DataManager dataManager = new DataManager();
        [Test]
        public void CreateParameter()
        {
            var command = new SqlCommand("INSERT INTO SIPLOCA (LOC_CODE,LOC_NAME,LOC_STAT,USER_CODE) VALUES(@1,@2,@3,@4)",connection.Connect());
            command.Transaction = connection.Connect().BeginTransaction();
            var str = new string[] {"@1","123", "@2","asd", "@3","asd", "@4","sdfa"};
            command = Commands.CreateParameter(command, str);
            command.ExecuteNonQuery();

            command = new SqlCommand("SELECT * FROM dbo.SIPLOCA WHERE LOC_CODE = '123'",connection.Connect());
            Assert.AreEqual(1, dataManager.GetData(command).Rows.Count);
            command.Transaction.Rollback();
            
        }
            
    }
}
