using NUnit.Framework;
using POS.Transaction;
using POS.Transaction.Security;

namespace POS.Test
{
    [TestFixture]
    public class TestSISecurity
    {
        [Test]
        public void Check_Permission_Should_Be_True()
        {
            var security = new SISecurity();
            var manuItems = new SIMenuItems();
            var subMenuItems = new SISubMenuItems();
            Assert.IsTrue(security.CheckPermission("SISA", manuItems.GroupsManagement, "V", subMenuItems.NewUser, true));
        }
    }
}
