using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
namespace POS.Test
{
    [TestFixture]
    public class TestIDictionary
    {
        [Test]
        public void dte()
        {
            IDictionary<string,List<string>> t = new Dictionary<string, List<string>>();
            var list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            t.Add("A",list);
            var lists = new List<string>();
            lists.Add("4");
            lists.Add("5");
            t.Add("B",lists);

            foreach (var s in t["B"])
            {
                MessageBox.Show(s.ToString());
            }
        }
    }
}
