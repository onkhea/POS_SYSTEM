using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using POS.Utilities;

namespace POS.Transaction
{
    class Server : IFormats
    {
        readonly Connection.Connection _connection = new Connection.Connection();
        public override string Now()
        {
            var command = new SqlCommand("SELECT GETDATE()",_connection.Connect());
            var date = (DateTime) command.ExecuteScalar();
            return date.ToString("yyyy-MM-dd HH:mm:00");
        }

        public override long DateDiff(DateTimes.DateInterval interval, DateTime date1, DateTime date2)
        {
            throw new System.NotImplementedException();
        }

        public override List<string> day(string SQLString)
        {
            throw new System.NotImplementedException();
        }

        public override List<string> Month(string SQLString)
        {
            throw new System.NotImplementedException();
        }

        public override List<string> Year(string SQLString)
        {
            throw new System.NotImplementedException();
        }
    }

   
}
