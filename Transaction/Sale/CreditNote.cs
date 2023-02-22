using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.Utilities;

namespace POS.Transaction.Sale
{
    public class CreditNote
    {
        public List<string> YearWithMonth()
        {
            var formats = new SIFormats();
            var MY = new List<string>();
            var listYear = formats.Year("SELECT DISTINCT DATEPART(\"Year\",INV_DATE) FROM dbo.SIPSINVM");
            foreach (var year in listYear)
            {
                var listMonth = formats.Month("SELECT DISTINCT DATEPART(\"MM\",INV_DATE) FROM dbo.SIPSINVM WHERE YEAR(INV_DATE) = '" + year + "'");
                foreach (var month in listMonth)
                {
                    MY.Add(year + month);
                }
            }
            return MY;



        }
           
    }
}
