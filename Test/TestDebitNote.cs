using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
using POS.DataLayer;
using POS.Transaction.Purchase;

namespace POS.Test
{
    [TestFixture]
    public class TestDebitNote
    {
        readonly DataManager dataManager = new DataManager();
        Connection.Connection connection = new Connection.Connection();
        [Test]
        public void Split_Ref_Line_Should_Be_Return_Sub_Of_Line()
        {
            // Given
            var ORD_LINE = "001";
            var ORM_REF = "9";
            var line_Ref = "";

            // THEN
            var dtSIPPORD = dataManager.GetData("SELECT ORD_LINE FROM dbo.SIPPORD ", "ORD_LINE",
                                                                      "ORM_REF", ORM_REF, "ORD_LINE", ORD_LINE);
            foreach (DataRow row in dtSIPPORD.Rows)
            {
                if (row[0].ToString().Length == 3)
                {
                    line_Ref = row[0].ToString() + "01";
                }
                else
                {
                    line_Ref = row[0].ToString().Substring(0, 3) + string.Format("{0:00}", Convert.ToDecimal(row[0].ToString().Substring(3)) + 1);
                }
            }

            Assert.AreEqual("00102", line_Ref);
        }

        [Test]
        public void Return_Line_Ref_On_Table_SIPPORD()
        {
            var ORM_REF = "9";
            var debitNote = new SIDebitNote();
            var i = debitNote.Return_Line_Ref(ORM_REF);
            Assert.AreEqual("005",i);
        }

        [Test]
        public void MonthWithYear_Should_Be_Return_Month_And_Year()
        {
            var siDebitNote = new SIDebitNote();
            var list = siDebitNote.YearWithMonth();
            Assert.AreEqual(1,list.Count);
        }

    }
}
