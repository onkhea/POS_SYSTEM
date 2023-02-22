using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace POS.DataLayer
{
    class Commands
    {
        public static SqlCommand CreateParameter(SqlCommand command, params string[] value)
        {
            command.CommandTimeout = 900;
            command.Parameters.Clear();
            for (int i = 0; i < value.Length; i+=2)
            {
                command.Parameters.AddWithValue("@" + value[i], value[i + 1]);
            }
            return command;
        }

        public static SqlCommand CreateParameter(SqlCommand command, params object[] values)
        {
            command.CommandTimeout = 900;
            command.Parameters.Clear();
            for (int i = 0; i < values.Length; i += 2)
            {
                command.Parameters.AddWithValue("@" + values[i], values[i + 1]);
            }
            return command;
        }

    }
}
