using NUnit.Framework;
using POS.DataLayer;

namespace POS.Test
{
    [TestFixture]
    public class TestDataManager
    {
        DataManager dataManager = new DataManager();
        [Test]
        public void  Exists_Should_Be_Return_True()
        {
            dataManager = new DataManager();
            Assert.IsTrue(dataManager.Exists("CATEGORY", "B01", "CategoryID"));
        }

        [Test]
        public void Exists_Should_Be_Return_True_Dynamic()
        {
            dataManager = new DataManager();
            var value = new string[] { "SI_CODE", "123", "SI_TYPE", "CATE", "SI_LOOKUP","99999" };
            var d = dataManager.Exists("SIPDATA", value);
            Assert.IsTrue(d);
        }

        [Test]
        public void GetData_Should_Be_Return_True()
        {
            dataManager = new DataManager();
            var dt = dataManager.GetData("SELECT * FROM SIPITEMS", "ITEM_CODE", "ITEM_CODE", "T");
            Assert.AreEqual(dt.Rows.Count,3);
        }

        [Test]
        public void GetData_With_String_Should_Be_Return_Values()
        {
            var dt = dataManager.GetData("SELECT * FROM SIPITEMS");

            Assert.AreEqual(dt.Rows.Count,2);
        }

        [Test]
        public void GetData_Proc_Condtion_With_ItemCode()
        {
            var obj = new object[]
                          {
                              "REF", "", "REP", "", "REF_FROM", "", "REF_TO", "", "ITEM", 1, "ITEM_FROM", "0001", "ITEM_TO"
                              , "0001","DATE","","TRANDATE_FROM","","TRANDATE_TO",""
                          };
            var dt = dataManager.GetData_Proc("SI_SELECT_PURCHASE_LISTING", obj);

            Assert.AreEqual(dt.Rows.Count,2);
        }

        [Test]
        public void GetData_Proc_Condition_With_Date()
        {
            var obj = new object[]
                          {
                              "REF", "", "REP", "", "REF_FROM", "", "REF_TO", "", "ITEM", 1, "ITEM_FROM", "0001", "ITEM_TO"
                              , "0001","DATE",1,"TRANDATE_FROM","01/26/2010","TRANDATE_TO","01/26/2010"
                          };
            var dt = dataManager.GetData_Proc("SI_SELECT_PURCHASE_LISTING", obj);

            Assert.AreEqual(dt.Rows.Count, 2);
        }


    }
}