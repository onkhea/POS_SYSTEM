using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using POS.Utilities;

namespace POS.Transaction
{
    class Generator
    {
        Connection.Connection  connection = new Connection.Connection();
        Strings strings = new Strings();
        public string Prefix(string strPrefix)
        {
            if (strPrefix.Contains("!Y!"))
            {
                strPrefix = strPrefix.Replace("!Y!", DateTime.Now.Year.ToString().Substring(3));
            }
            else if(strPrefix.Contains("!YY!"))
            {
                strPrefix = strPrefix.Replace("!YY!", DateTime.Now.Year.ToString().Substring(2));
            }
            else if(strPrefix.Contains("!YYY!"))
            {
                strPrefix = strPrefix.Replace("!YYY!", DateTime.Now.Year.ToString().Substring(1));
            }
            else if (strPrefix.Contains("!YYYY!"))
            {
                strPrefix = strPrefix.Replace("!YYYY!",DateTime.Now.Year.ToString());
            }
            if (strPrefix.Contains("!MM!"))
            {
                strPrefix = strPrefix.Replace("!MM!", string.Format("{00}", DateTime.Now.Month.ToString()));
            }
            return strPrefix;
        }

        public string ID(string SQLStr,int length,string PreStr, string sufStr,int startN, int interval)
        {
            if (interval.ToString() == "")
                interval = 1;
            var  command = new SqlCommand(SQLStr, connection.Connect());
            command.CommandTimeout = 0;
            var dataAdapter = new SqlDataAdapter(command);
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                var rd = row[0].ToString();
            }

            string FormatStr = "{0}";
            for (int i = 1; i < length; i++)
            {
                FormatStr += "";
            }
            if (command.ExecuteScalar() == Convert.DBNull)
            {
                return PreStr + string.Format(FormatStr, startN) + sufStr;
            }
            else
            {
                decimal ID = 0;
//                var str = command.ex
                string st = Convert.ToString(command.ExecuteScalar());
                if (length == 0)
                {
                    if (strings.IsNumeric(st))
                    {
                        ID = Convert.ToDecimal(st) + interval;
                    }
                }
                else
                {
                    if (st.Length >= length && PreStr.Length <= st.Length)
                    {
                        if (strings.IsNumeric(st.Substring(PreStr.Length,length)))
                        {
                            var dd = Convert.ToDecimal(st.Substring(PreStr.Length, length));
                            ID = Convert.ToDecimal(st.Substring(PreStr.Length, length)) + interval;
                        }
                    }
                    else
                    {
                        if (strings.IsNumeric(st))
                        {
                            ID = Convert.ToDecimal(st) + interval;
                        }
                    }
                   
                }
                return PreStr + string.Format(FormatStr, ID) + sufStr;
            }
        }
    }
}
