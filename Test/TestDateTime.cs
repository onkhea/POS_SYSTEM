using System;
using System.Windows.Forms;
using NUnit.Framework;
using POS.Utilities;

namespace POS.Test
{
    [TestFixture]
    public class TestDateTime
    {
        [Test]
        public void Should_Be_Show_Date_Differnce()
        {
            var dateTimes = new DateTimes();
            var d = dateTimes.DateDiff(DateTimes.DateInterval.Day, DateTime.Now,DateTime.Now.AddDays(1));
            Assert.AreEqual(1,d);

        }

        [Test]
        public void Should_Be_Show_Date_Difference_With_Visual_Studio_VB()
        {
            var d = Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day,
                                                       Convert.ToDateTime("11/25/2009"),
                                                       DateTime.Now, Microsoft.VisualBasic.FirstDayOfWeek.System,
                                                       Microsoft.VisualBasic.FirstWeekOfYear.System);
            Assert.AreEqual(1,d);
        }

        [Test]
        public void Concatenate_Year_Month_Hour_Minute_Second()
        {
            var year = DateTime.Now.Year.ToString();
            var month = DateTime.Now.Month.ToString();
            var hour = DateTime.Now.Hour.ToString();
            var minute = DateTime.Now.Minute.ToString();
            var second = DateTime.Now.Second.ToString();
            var concat = year + month + hour + minute + second;
            MessageBox.Show(concat);
        }
        

    }
}
