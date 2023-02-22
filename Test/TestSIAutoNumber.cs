using System.Windows.Forms;
using NUnit.Framework;
using POS.Transaction;

namespace POS.Test
{
    [TestFixture]
    public class TestSIAutoNumber
    {
        [Test]
        public void Should_Be_Return_Auto_Number_PO()
        {
            var PO = SIAutoNumber.PO_AutoNumber();
            MessageBox.Show(PO);
        }

        [Test]
        public void Should_Be_Return_Auto_Number_POS()
        {
            var POS = SIAutoNumber.POS_AutoNumber();
            MessageBox.Show(POS);
        }

        [Test]
        public void Should_Be_Return_Auto_Number_SO()
        {
            var SO = SIAutoNumber.SO_AutoNumber();
            MessageBox.Show(SO);
        }
    }
}
