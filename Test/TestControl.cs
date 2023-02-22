using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnit.Framework;
using POS.Utilities;

namespace POS.Test
{
    [TestFixture]
    public class TestControl
    {
        [Test]
        public void AddItemToLVGroup_Should_Be_True()
        {
            var controls = new Controls();
            var lv = new ListView();
            var lvGroup = new ListViewGroup();
            var text = new string[]{"Test","Test1"};
            controls.AddItemToLVGroup(lv,lvGroup,text);
            Assert.AreEqual(lv.Items.Count,2);
            
        }

        [Test]
        public void AddDataToListView_Should_Be_True()
        {
            var controls = new Controls();
            var lv = new ListView();
            var str = new string[] {"test1", "test2"};
            controls.Add_ListView(lv,2,str);
            MessageBox.Show(lv.Items[0].Text);
            Assert.AreEqual(lv.Items.Count,2);
        }
    }
}
