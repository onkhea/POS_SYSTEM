using NUnit.Framework;
using POS.Transaction.Sale;

namespace POS.Test
{
    [TestFixture]
    public class TestSaleOrder
    {
        [Test]
        public void  Get_Hold_DateTime()
        {
            var saleOrder = new SaleOrder();
            Assert.AreEqual(saleOrder.HoldDateTime().Count,1);
        }
    }
}
