using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
using POS.Transaction.Sale;

namespace POS.Test
{
    [TestFixture]
    public class TestCreditNote
    {
        [Test]
        public void YearWithMonth()
        {
            var creditNote = new CreditNote();
            var YM = creditNote.YearWithMonth();

            Assert.Greater(0,YM.Count);
        }
    }
}
