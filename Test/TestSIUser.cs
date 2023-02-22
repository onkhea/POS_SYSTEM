using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using NUnit.Framework;
using POS.DataLayer;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.Test
{
    [TestFixture]
    public class TestSIUser
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            var user = new SIUser();
            var dateTimes = new DateTimes();
            SIUser.Code = "123";
            SIUser.Name = "ABC";
            SIUser.Password = System.Text.Encoding.UTF32.GetBytes("1");
            SIUser.Description = "asd";
            SIUser.CPAS = 1;
            SIUser.UState = 1;
            SIUser.ULog = System.Text.Encoding.UTF32.GetBytes("U");
            SIUser.CreateDate = dateTimes.Now();

        }
        [Test]
        public void Save ()
        {
            SIUser siUser = new SIUser();
            siUser.Save();
            var sqlCommand = new SqlCommand("SELECT TOP 1 * FROM SIPUSERS WHERE SI_CODE = '123'");
            var dt = DataAccess.LoadData(sqlCommand);
            Assert.AreEqual(dt.Rows.Count, 1);
        }

        
    }
}
