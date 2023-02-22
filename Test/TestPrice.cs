using NUnit.Framework;
using POS.Transaction.Sale;

namespace POS.Test
{
    [TestFixture]
    public class TestPrice
    {
        [Test]
        public void GetPriceValue()
        {
            var price = new Price();
            var result = price.GetValue("1111");

            Assert.AreEqual(12,result);
        }
    }
}
