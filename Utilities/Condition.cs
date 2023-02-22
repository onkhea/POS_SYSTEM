using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POS.Utilities
{
    public class Condition : ICondition
    {
        public static bool EmptyControl(params Control[] controls)
        {
            var condition = false;
            foreach (var control in controls)
            {
                if (string.IsNullOrEmpty(control.Text))
                    condition = true;

            }
            return condition;
        }

        public static bool Check_Numeric(params Control[] controls)
        {
            var ctl = new Controls();
            var strings = new Strings();
            foreach (var control in controls)
            {
                if (!string.IsNullOrEmpty(control.Text))
                {
                    if (!strings.IsNumeric(control.Text))
                    {
                        control.BackColor = Color.Tomato;
                        if ((string) control.Tag != "")
                        {
                            MessageBox.Show((string) control.Tag + " must be numeric", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("This box must be numeric ", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        control.BackColor = Color.White;
                        control.Focus();
                        return true;
                    }
                }
                else
                {
                    control.Text = "0";
                }
            }
            return false;
        }

        public static bool Check_Decimal(params Control[] controls)
        {
            var ctl = new Controls();
            var strings = new Strings();
            foreach (var control in controls)
            {
                if (!string.IsNullOrEmpty(control.Text))
                {
                    if (!strings.IsDecimal(control.Text))
                    {
                        control.BackColor = Color.Tomato;
                        if ((string)control.Tag != "")
                        {
                            MessageBox.Show((string)control.Tag + "must be numeric", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("This box must be numeric", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        control.BackColor = Color.White;
                        control.Focus();
                        return true;
                    }
                }
                else
                {
                    control.Text = "0";
                }
            }
            return false;
        }

//        public bool ExistedRecord(DataTable dataTable, string FieldName, string condition)
//        {
//            if (string.IsNullOrEmpty(condition))
//                MessageBox.Show(Messages.ExistRecord, "Exist Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
//            string str = null;
//            var query = (from dt in dataTable.AsEnumerable()
//                         where dt.Field<string>(FieldName) == condition
//                         select dt);
//            var q = query.Count();
//            if (q == 0)
//            {
//                return false;
//            }
//            return true;
//        }
    }
}