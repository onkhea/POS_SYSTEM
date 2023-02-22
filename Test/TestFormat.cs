using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
namespace POS.Test
{
    [TestFixture]
    public class TestFormat
    {
        [Test]
        public void Should_Be_Return_FormatString()
        {
            //===== Given=======
            var d = string.Format("{0:0000}", 1);
            
            //===== When =======


            //===== Then =======
            MessageBox.Show(d);
        }

        [Test]
        public void Should_Be_ReturnFormate_Currnecy()
        {
            var d = string.Format("{0:0,0.00}", 1000);
            Assert.AreSame("1,000.00",d,ToString());
//            MessageBox.Show(d);
        }
    }
}
