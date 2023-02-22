using System;
using IS_POS.Utilities;

namespace POS.Utilities
{
    class Formats : IFormats
    {
        public override string FormatFrontEnd(string Str, int NumDecPlace, string DecimalSeparator, string ThousandSeparator, bool IsFromDB)
        {
            IControls controls = new Controls();
            var Num = new decimal();
            short Index_Dec = 0;
            string StrFor = "#,##0";
            if (NumDecPlace > 0)
            {
                StrFor = StrFor + ".";
            }
            int numDes = NumDecPlace;
            for (int i = 1; i <= numDes; i++)
            {
                StrFor = StrFor + "0";
            }
            if (Str.Trim() != "")
            {
                Str = Str.Replace(ThousandSeparator, "");
                if (DecimalSeparator != ".")
                {
                    Str = Str.Replace(DecimalSeparator, ".");
                }
                if (controls.IsNumeric(Str.Trim()))
                {
                    Num = Convert.ToDecimal(Str.Trim());
                }
            }
            Index_Dec = (short) Str.IndexOf(".");
            if ((Index_Dec >= 0) && (Str.Substring(Index_Dec + 1).Length > NumDecPlace))
            {
                Num = Convert.ToDecimal(Str.Substring(0, Index_Dec) + "." + Str.Substring(Index_Dec + 1, NumDecPlace));
            }
            return String.Format(StrFor,Num).Replace(".", "DoT").Replace(",", ThousandSeparator).Replace("DoT",
                                                                                                          DecimalSeparator);
        
        }
    }
}