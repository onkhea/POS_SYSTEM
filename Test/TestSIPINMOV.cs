using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
using POS.Transaction.Purchase;

namespace POS.Test
{
    [TestFixture]

    public class TestSIPINMOV
    {
        [Test]
        public void Return_Line_Ref_Should_Be_Line()
        {
            var sisipinmov = new SISIPINMOV();
            var i = sisipinmov.Return_Line_Ref("9");
            MessageBox.Show(i);
        }
    }
}
