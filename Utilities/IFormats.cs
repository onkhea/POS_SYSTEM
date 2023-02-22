using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace POS.Utilities
{
    abstract class IFormats
    {
        public abstract string Now();
        public abstract long DateDiff(DateTimes.DateInterval interval, DateTime date1, DateTime date2);
        public abstract List<string> day(string SQLString);
        public abstract List<string >Month(string SQLString);
        public abstract List<string> Year(string SQLString);
             
    }
}
