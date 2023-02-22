using System.Windows.Forms;
using NUnit.Framework;
using POS.Transaction.Maintains;
using System.Collections.Generic;

namespace POS.Test
{
    [TestFixture]
    public class TestUnitConversion
    {
        [Test]
        public void GetConversion_Should_Be_Return_List()
        {
            //===== Given=======
            var unitConversion = new SIUnitConversion();

            //===== When =======
            List<object> list = unitConversion.GetConvertTo();

            //===== Then =======
            Assert.AreEqual(2,list.Count);
            
        }
    }

   
}
