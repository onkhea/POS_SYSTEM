using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.Utilities
{
    static class SIDataGridView
    {
        public static decimal Sum(DataGridView  dgv, int sumColumn )
        {
            var d = new decimal();
            d = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                d +=
                    Convert.ToDecimal(dgv.Rows[i].Cells[sumColumn].Value.ToString() == ""
                                          ? 0
                                          : dgv.Rows[i].Cells[sumColumn].Value);
            }
            return d;
        }
        public static decimal Sum(DataGridView dgv, int sumColumn, params object[] conditionAndCol)
        {
            Decimal value = 0;
            var cond = false;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < conditionAndCol.Length - 1; i +=2)
                {
                    if (conditionAndCol[i] == row.Cells[i+1].Value)
                    {
                        cond = true;
                    }
                    else
                    {
                        cond = false;
                        break;
                    }
                }
                if (cond == true)
                {
                    value +=
                        Convert.ToDecimal(row.Cells[sumColumn].Value.ToString() == ""
                                              ? 0
                                              : Convert.ToDecimal(row.Cells[sumColumn].Value.ToString()));
                    
                }
            }
            return value;
        }
        /// <summary>
        /// this function sum on datagridview with condition
        /// </summary>
        /// <param name="dgv">datagridview1</param>
        /// <param name="sumColumn">ADB</param>
        /// <param name="valueCondition">txtItemCode.text</param>
        /// <returns>10</returns>
        public static decimal Sum(DataGridView dgv, int sumColumn, params string[] valueCondition)
        {
            Decimal value = 0;
            var j = 0;
            var cond = false;

            for (int k = 0; k < dgv.Rows.Count; k++)
            {
                for (int i = 0; i < valueCondition.Length - 1; i +=2)
                {
                    var cel = Convert.ToInt16(valueCondition[i + 1]);
                    if (valueCondition[i] == (string) dgv.Rows[k].Cells[cel].Value)
                    {
                        cond = true;
                    }
                    else
                    {
                        cond = false;
                        break;

                    }
                    j++;

                }
                if (cond)
                {
                    value +=
                        Convert.ToDecimal(dgv.Rows[k].Cells[sumColumn].Value.ToString() == ""
                                              ? 0
                                              : Convert.ToDecimal(dgv.Rows[k].Cells[sumColumn].Value.ToString()));

                }
            }
            return value;
        }
              
        public static void BindingData_ToGrid_OnSelected(DataGridView dataGridView,params string[] value)
        {
            var i = 0;
            foreach (var val in value)
            {
                dataGridView.SelectedRows[0].Cells[i].Value = val;
                i++;
            }
        }

        public static Decimal  SumDataOnSelectedGrid(DataGridView dgv, int column,DataGridViewCellEventArgs e)
        {
            Decimal d = 0;
            var dd = dgv.Rows[0].Cells[0].Value;
                for (int i = 0; i < dgv.Rows.Count ; i++)
                {
                    DataGridViewCell cell = dgv.Rows[i].Cells[0];
                    bool check = (bool) cell.EditedFormattedValue;
                    if (check)
                    {
                        d += Decimal.Parse(dgv.Rows[i].Cells[column].Value.ToString());
                    }
                }
            return d;
        }

        public static void BindingDataGird_OnSelect_Into_Textbox(DataGridView dvg, params Control[] controls)
        {
            var i = 0;
            foreach (var control in controls)
            {
                control.Text = dvg.SelectedRows[0].Cells[i].Value.ToString();
                i++;
            }
        }

        public  static int CheckOnGrid(DataGridView dgv, params object[] conditionAndColumn)
        {
            var i = -1;
            var condition = false;
            var k = 0;
            var strings = new Strings();
            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    for (int j = 0; j < conditionAndColumn.Length - 1; j += 2)
                    {
                        var DDD = row.Cells[int.Parse(conditionAndColumn[j + 1].ToString())].Value.ToString();
                        var COND = conditionAndColumn[j].ToString();
                        if (strings.IsDecimal(DDD) == true)
                        {
                            var D =
                                Convert.ToDecimal(
                                    row.Cells[int.Parse(conditionAndColumn[j + 1].ToString())].Value.ToString());
                            var CON = Convert.ToDecimal(conditionAndColumn[j].ToString());
                            DDD = D.ToString();
                            COND = CON.ToString();
                        }

                        if (DDD.ToString() == COND)
                        {
                            condition = true;
                        }
                            //                    if (string.Compare(conditionAndColumn[j].ToString(),row.Cells[int.Parse(conditionAndColumn[j+1].ToString())].Value.ToString()) == 0)
                            //                    {
                            //                        condition = true;  
                            //                    }
                        else
                        {
                            condition = false;
                            break;
                        }
                    }
                    if (condition)
                    {
                        i = k;
                        break;
                        ;
                    }
                    k += 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Check Gridview");
            }
            
            return i;
        }
    }
}
