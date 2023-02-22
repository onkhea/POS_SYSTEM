using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.Utilities
{
    class Strings 
    {
        public bool IsByte(string str)
        {
            try
            {
                byte.Parse(str);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool IsNumeric(string str)
        {
            try
            {
                Int32.Parse(str);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool  IsDecimal(string str)
        {
            try
            {
                decimal.Parse(str);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public bool IsDateTime(string str)
        {
            try
            {
                DateTime.Parse(str);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
