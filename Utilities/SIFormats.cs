using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;

namespace POS.Utilities
{
    class SIFormats : IFormats
    {
        private readonly DataManager dataManager = new DataManager();
        readonly Connection.Connection connection = new Connection.Connection();
        public string PO_Format
        {
            get { return "{0:0,0.00}";  }
            
        }

        public override string Now()
        {
            throw new System.NotImplementedException();
        }

        public override long DateDiff(DateTimes.DateInterval interval, DateTime date1, DateTime date2)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Function return day from database in table
        /// </summary>
        /// <param name="SQLString">SELECT DISTINCT DATEPART("DD",ORM_DATE) FROM dbo.SIPPORM </param>
        /// <returns>list of day in table</returns>
        public override List<string> day(string SQLString)
        {
            var list = new List<string>();
            var command = new SqlCommand(SQLString, connection.Connect());
            var dt = dataManager.GetData(command);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());    
            }
            return list;
        }

        public override List<string> Month(string SQLString)
        {
            var list = new List<string>();
            var command = new SqlCommand(SQLString, connection.Connect());
            var dt = dataManager.GetData(command);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }

        public override List<string> Year(string SQLString)
        {
            var list = new List<string>();
            var command = new SqlCommand(SQLString, connection.Connect());
            var dt = dataManager.GetData(command);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
    }
}
