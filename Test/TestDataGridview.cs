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
    public class TestDataGridview
    {
        [Test]
        public void Sum_Should_Be_True()
        {
            var  dataGridView = new DataGridView();
            dataGridView.Columns.Add("Test", "TEST");
            dataGridView.Rows.Add("1");
//            dataGridView.Rows[0].Cells[0].Value = "1";
            var dd  = dataGridView.Rows.Count;
            var dddd = dd;
//            dataGridView.Rows[1].Cells[0].Value = "2";
            var d = SIDataGridView.Sum(dataGridView, 0);
            Assert.AreEqual(1,d);

        }

        [Test]
        public void SumDataOnSelectedGrid_Should_Be_Return_True()
        {
            var datagrid = new DataGridView();
            datagrid.Columns.Add("Test","Test");
            datagrid.Rows.Add("10");
            datagrid.Rows.Add("10");
            var count = datagrid.Rows.Count;
            datagrid.SelectAll();
//            var d = SIDataGridView.SumDataOnSelectedGrid(datagrid, 0);
            
//            Assert.AreEqual(20,d);

        }
        

        [Test]
        public void BindingData_ToGrid_OnSelected_Should_Be_True()
        {
            var dataGridView = new DataGridView();
           
            SIDataGridView.BindingData_ToGrid_OnSelected(dataGridView,"1","2");

            Assert.AreEqual(1,dataGridView.Rows.Count);
        }

    }
}
