using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using POS.Connection;
using POS.Utilities;

namespace POS.DataLayer
{
    abstract class DataAccess
    {
        static Strings strings = new Strings();
        private readonly static IConnection connection = new Connection.Connection();

        public static DataTable LoadData(SqlCommand command)
        {
            command.Connection = connection.Connect();
            var dataAdapter = new SqlDataAdapter(command);
//            var dataAdapter = new SqlDataAdapter(command,connection.Connect());
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        
        public static void ExecuteProc(string procedureName, params string[] values)
        {
            var command = new SqlCommand { CommandText = procedureName, CommandType = CommandType.StoredProcedure };
//            command.CreateParameter()
        }

        /// <summary>
        /// Saving data to database
        /// </summary>
        /// <param name="table">tblProduct</param>
        /// <param name="fields">proCode,proName...</param>
        /// <param name="values">"123","ABC"...</param>
        public static void SaveData(string table, string[] fields, string[] values)
        {
            try
            {
                var command = new SqlCommand {Connection = connection.Connect()};
                var cmd = new StringBuilder("INSERT INTO " + table + " ( " );
                int i = 1;
                foreach (string s in fields)
                {
                    if (i == fields.Length)
                    {
                        cmd.Append(s + " ");
                    }
                    else
                    {
                        cmd.Append(s + "," );
                    }

                    i++;
                }
                cmd.Append(") VALUES ( ");

                var j = 0;
                foreach (string o in values)
                {
                    if (j == fields.Length)
                    {
                            cmd.Append("'" + o + "'" + " ");
                    }
                    else
                    {
                            cmd.Append("'" + o + "'" + ",");
                       
                    }
                    j++;
                }
                
                
                cmd.Replace(",", "",cmd.Length - 1 ,1 );
                cmd.Append(" )");
                command.CommandText = cmd.ToString();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteData(string tableName, string value, string fieldName)
        {
            string str = string.Format("Delete " + tableName + " Where {0} = @{0}", fieldName);
            var command = new SqlCommand(str, connection.Connect());
            command.Parameters.AddWithValue("@" + fieldName, value);
            command.ExecuteNonQuery();
        }

        public static void DeleteData(string tableName, string[] fieldAndValue)
        {
            var command = new SqlCommand();
            var str = string.Format("Delete {0} WHERE " , tableName);
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < fieldAndValue.Length; i += 2)
            {
                if (i >=2)
                {
                    stringBuilder.Append(" And " + fieldAndValue[i] + "=@" + fieldAndValue[i]);
                }
                else
                {
                    stringBuilder.Append(fieldAndValue[i] + "=@" + fieldAndValue[i]);
                }
                command.Parameters.AddWithValue("@" + fieldAndValue[i], fieldAndValue[i + 1]);
            }
            command.CommandText = str + stringBuilder;
            command.Connection = connection.Connect();
            command.ExecuteNonQuery();
        }

        public static void UpdateData(string table, string[] fields, string[] values, string conditionField, string conditionValue)
        {
            try
            {
                var command = new SqlCommand {Connection = connection.Connect()};
                var cmd = new StringBuilder("UPDATE " + table + " SET ");

                int i = 1;
                foreach (string s in fields)
                {
                    if (i == fields.Length)
                    {
                        cmd.Append(s + " = @" + s + " ");
                    }
                    else
                    {
                        cmd.Append(s + " = @" + s + ", ");
                    }

                    i++;
                }

                cmd.Append("WHERE (" + conditionField + " = @" + conditionField + ")");

                command.CommandText = cmd.ToString();
                int j = 0;
                foreach (var o in values)
                {
                    command.Parameters.AddWithValue("@" + fields[j], o);
                    j++;
                }
                command.Parameters.AddWithValue("@" + conditionField, conditionValue);
               
                command.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        public static void UpdateData(string tableName, string[]fieldsAndValue,string[] conditions)
        {
            var str = string.Format("UPDATE {0} SET ", tableName );
            var stringBuilder = new StringBuilder();
            var strBuild = new StringBuilder();
            var commmand = new SqlCommand();
            for (int i = 0; i < fieldsAndValue.Length; i += 2)
            {
                if (i >= 2)
                {
                    stringBuilder.Append(" , " + fieldsAndValue[i] + "=@" + fieldsAndValue[i]);
                }
                else
                {
                    stringBuilder.Append(fieldsAndValue[i] + "=@" + fieldsAndValue[i]);
                }

                commmand.Parameters.AddWithValue("@" + fieldsAndValue[i], fieldsAndValue[i + 1]);
            }
            
//            === condition ======

            for (int j = 0; j < conditions.Length; j +=2)
            {
                if (j >= 2)
                {
                    strBuild.Append(" AND " + conditions[j] + "=@" + conditions[j]);
                }
                else
                {
                    strBuild.Append(conditions[j] + "=@" + conditions[j]);
                }
                commmand.Parameters.AddWithValue("@" + conditions[j], conditions[j + 1]);
            }
            var comStr = str + stringBuilder.ToString() + " WHERE " + strBuild.ToString();
            commmand.CommandText = comStr;
            commmand.Connection = connection.Connect();
            commmand.ExecuteNonQuery();
//            var dt = DataAccess.LoadData(commmand);
//            if (dt.Rows.Count != 0)
//                return true;
//            return false;
        }

        public static string ReturnField(string CommandString, string orderByFieldName, string[] fieldAndConditions , string returnValue)
        {
           var dataManager = new DataManager();
           var dt = dataManager.GetData(CommandString, orderByFieldName, fieldAndConditions);
            foreach (DataRow row in dt.Rows)
                return row[returnValue].ToString();
            return "";
        }

        public static string ReturnField(string CommandString, string orderByFieldName, string[] fieldAndConditions, int returnValue)
        {
            var dataManager = new DataManager();
            var dt = dataManager.GetData(CommandString, orderByFieldName, fieldAndConditions);
            foreach (DataRow row in dt.Rows)
                return row[returnValue].ToString();
            return "";
        }

        public static string ReturnField(string SqlString,int returnField)
        {
            var command = new SqlCommand(SqlString, connection.Connect());
            var dataManager = new DataManager();
            var dt = dataManager.GetData(command);
            foreach (DataRow row in dt.Rows)
                return row[returnField].ToString();
            return "";
        }
    }
}