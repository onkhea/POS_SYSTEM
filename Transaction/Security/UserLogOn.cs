using System;

namespace POS.Transaction.Security
{
    public static class UserLogOn
    {
        private static string code;
        public static string Name { get; set; }
        public static DateTime Date { get; set; }
        public static string UserLog { get; set; }
        public static string Location { get; set;  }
        public static string DB_DEFAULTDATE = ""; // if "L" logon date else "C" current date

        public static string Code
        {
            get { return code; }
            set { code = value; }
        }
    }
}