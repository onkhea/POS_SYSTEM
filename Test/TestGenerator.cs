using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
using POS.Transaction;

namespace POS.Test
{
    [TestFixture]
    public class TestGenerator
    {
        Generator generator = new Generator();
        [Test]
        public void Prefix_Should_be_return_1_Number_of_Year()
        {
            //===== Given=======
            Generator generator = new Generator();
            var d = generator.Prefix("!Y!");

            //===== Then =======
            Assert.AreEqual("9",d);

        }
        [Test]
        public void Prefix_Should_be_return_2_Number_of_Year()
        {
            //===== Given=======
            Generator generator = new Generator();
            var d = generator.Prefix("!YY!");
       
            //===== Then =======
            Assert.AreEqual("09",d);
        }

        [Test]
        public void Prefix_Should_be_return_4_Number_of_Year()
        {
            //===== Given=======
            Generator generator = new Generator();
            var d = generator.Prefix("!YYYY!");

            //===== Then =======
            Assert.AreEqual("2009", d);
        }

        [Test]
        public void Prefix_Should_be_return_2_Number_of_Month()
        {
            //===== Given=======
           
            var d = generator.Prefix("!MM!");

            //===== Then =======
            Assert.AreEqual("11",d);
        }

        [Test]
        public void ID_Should_Be_Return_Number()
        {
            //===== Given=======
            string prefix = generator.Prefix("!YY!!MM!");
            string surfix = generator.Prefix("!YY!!MM!");
                        int PO_INTERVAL = 1;
                        int PO_LENGHT = 10;
                        int PO_START = 1;
                
            var id = generator.ID(
                "SELECT MAX(ORM_REF) FROM SIPPORD WHERE LEFT(ORM_REF," + prefix.Length + ")='" + prefix +
                "' AND RIGHT(ORM_REF," + surfix.Length + ")='" + surfix + "'",
                PO_LENGHT - (prefix.Length + surfix.Length), prefix, surfix, PO_START, PO_INTERVAL);
         
            //===== Then =======
            MessageBox.Show(id);
        }
    }
}
