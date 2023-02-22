using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;

namespace POS.DataLayer
{
    class DataManager : IDataTable
    {
        /// <summary>
        /// Create Datatable 
        /// </summary>
        /// <param name="Column">ProductId</param>
        /// <returns>DataTable</returns>
        public DataTable Create(params string[] Column)
        {
            var dataTable = new DataTable();
            foreach (var col in Column)
            {
                var dataColumn = new DataColumn(col);
                dataTable.Columns.Add(dataColumn);
            }
            return dataTable;
        }

        /// <summary>
        /// method for load data to datatable 
        /// </summary>
        /// <param name="command">Sqlcomand</param>
        /// <returns>datatable</returns>
        public DataTable GetData(SqlCommand command)
        {
            try
            {
                var dataAdapter = new SqlDataAdapter { SelectCommand = command };
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable GetData(string StrSelectCommand, string orderBy, params string[] condition)
        {
            var str = string.Format(StrSelectCommand);
            var stringBuilder = new StringBuilder();
            var commmand = new SqlCommand();
            for (int i = 0; i < condition.Length; i += 2)
            {
                if (i >= 2)
                {
                    stringBuilder.Append(" AND UPPER(" + condition[i] + ") Like UPPER(@" + condition[i] + ")");
                }
                else
                {
                    stringBuilder.Append("UPPER(" + condition[i] + " )Like UPPER(@" + condition[i] + ")");
                }

                commmand.Parameters.AddWithValue("@" + condition[i], condition[i + 1] + "%");
            }
            var comStr = str + " WHERE " + stringBuilder.ToString();
            commmand.CommandText = comStr;
            var dt = DataAccess.LoadData(commmand);
            return dt;
        }

        public DataTable GetData(string strCommand)
        {
            var dt = new DataTable();
            try
            {
                var connection = new Connection.Connection();
                var command = new SqlCommand(strCommand, connection.Connect());
                dt = DataAccess.LoadData(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        }

        public DataTable GetData_Proc(string proName, params object[] paramAndValues)
        {
            var dt = new DataTable();
            try
            {
                var command = new SqlCommand(proName) {CommandType = CommandType.StoredProcedure};
                Commands.CreateParameter(command, paramAndValues);
                dt = DataAccess.LoadData(command);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// Save data to datable
        /// </summary>
        /// <param name="dataTable">dataTable</param>
        /// <param name="controls">txtProductid,txtProductName...</param>
        public void Save(DataTable dataTable, params Control[] controls)
        {
            var i = 0;
            var row = dataTable.NewRow();

            foreach (var control in controls)
            {
                //                    row[i] = Convert.ToInt32(control.Text);
                row[i] = control.Text;
                i += 1;
            }
            dataTable.Rows.Add(row);
        }


        public void Save(DataTable dataTable, params string[] controls)
        {
            var i = 0;
            var row = dataTable.NewRow();

            foreach (var control in controls)
            {
                //                    row[i] = Convert.ToInt32(control.Text);
                row[i] = control;
                i += 1;
            }
            dataTable.Rows.Add(row);
        }

        /// <summary>
        /// Delete data from datatable
        /// </summary>
        /// <param name="dataTable">datatable</param>
        /// <param name="condition">txtProductId</param>
        /// <remarks> Only Code of datatable</remarks>
        public void Delete(DataTable dataTable, string condition)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if ((string)row[0] != condition) continue;
                row.Delete();
                break;
            }
            dataTable.AcceptChanges();
        }

        /// <summary>
        /// Data is deleted by row and condition
        /// </summary>
        /// <param name="dataTable">datatable</param>
        /// <param name="row">productid</param>
        /// <param name="condition">txtproductid.text</param>
        public void Delete(DataTable dataTable, int row, string condition)
        {
            foreach (DataRow drow in dataTable.Rows)
            {
                if ((string)drow[row] != condition) continue;
                drow.Delete();
                break;
            }
            dataTable.AcceptChanges();
        }

        /// <summary>
        /// delete with two condtion 
        /// </summary>
        /// <param name="dataTable">datatable</param>
        /// <remarks> i is row of datatable</remarks>
        /// <param name="i">1</param>
        /// <param name="condition1">txtproductId.text</param>
        /// <seealso cref="Condition2"/>
        /// <param name="j">3</param>
        /// <param name="Condition2">txtcategoryid.text</param>
        public void Delete(DataTable dataTable, int i, string condition1, int j, string Condition2)
        {
            var k = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                if ((string)row[i] == condition1 && (string)row[j] == Condition2)
                {
                    dataTable.Rows.RemoveAt(k);
                    break;
                }
                k++;
            }
            dataTable.AcceptChanges();
        }

        /// <summary>
        /// update data
        /// </summary>
        /// <param name="dataTable">datatable</param>
        /// <param name="row">2</param>
        /// <param name="controls">txtproductId</param>
        /// <returns>datatable</returns>
        public DataTable Update(DataTable dataTable, int row, params Control[] controls)
        {
            var i = 0;
            foreach (var control in controls)
            {
                dataTable.Rows[row][i] = control.Text;
                i += 1;
            }
            return dataTable;
        }

        /// <summary>
        /// update data with condition field
        /// </summary>
        /// <param name="dataTable">datatable</param>
        /// <param name="fieldName">productId</param>
        /// <param name="condition">"ABC0123"</param>
        /// <param name="controls">txtproductId</param>
        /// <returns>datatable</returns>
        public DataTable Update(DataTable dataTable, string fieldName, string condition, params Control[] controls)
        {
            try
            {
                var i = 0;
                var str = string.Format(fieldName + "= '{0}'", condition);
                foreach (var row in dataTable.Select(str))
                {
                    foreach (var control in controls)
                    {
                        row[i] = control.Text;
                        i += 1;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update");
            }

            return dataTable;
        }

        public bool Exists(string tableName, string para, string fieldName)
        {
            var str = string.Format("SELECT TOP 1 * FROM {0} WHERE {1}=@{1}", tableName,fieldName,fieldName);
            var command = new SqlCommand();
            command.Parameters.AddWithValue("@" + fieldName, para);
            command.CommandText = str;
            var dt = DataAccess.LoadData(command);
            if (dt.Rows.Count != 0)
                return true;
            return false;
        }

        public DataTable Filter(DataTable dt, string fieldName, string condition)
        {
            var dv = new DataView(dt);
            if (String.IsNullOrEmpty(condition)) return null;
//            var query = from dataRow in dt.AsEnumerable()
//                        where dataRow.Field<string>(fieldName).ToUpper() == condition.ToUpper() 
//                        select dataRow;
            dv.RowFilter = fieldName +" Like '%" + condition + "%'";
            var dts = dv.ToTable();
            return dts;
        }

        public bool Exists(string tableName, string para, string fieldName,string typeName, string typeValue)
        {
            var str = string.Format("SELECT TOP 1 * FROM {0} WHERE {1}=@{1} And {2} =@{2}", tableName, fieldName, typeName);
            var command = new SqlCommand();
            command.Parameters.AddWithValue("@" + fieldName, para);
            command.Parameters.AddWithValue("@" + typeName, typeValue);
            command.CommandText = str;
            var dt = DataAccess.LoadData(command);
            if (dt.Rows.Count != 0)
                return true;
            return false;
        }
        
        /// <summary>
        /// Function for check existing record with multiple column
        /// </summary>
        /// <param name="tableName">TBLProduct</param>
        /// <param name="ParaAndValue">"Procode","C0001","ProName","ABC"....</param>
        /// <returns>True/False</returns>
        public bool Exists(string tableName,params string[] ParaAndValue)
        {
            var str = string.Format("SELECT TOP 1 * FROM {0} ",tableName);
            var stringBuilder = new StringBuilder();
            var commmand = new SqlCommand();
            for (int i = 0; i < ParaAndValue.Length; i += 2)
            {
                if ( i >= 2)
                {
                    stringBuilder.Append(" AND " + ParaAndValue[i] + "=@" + ParaAndValue[i]);
                }
                else
                {
                    stringBuilder.Append(ParaAndValue[i] + "=@" + ParaAndValue[i]);
                }
                
                commmand.Parameters.AddWithValue("@" + ParaAndValue[i], ParaAndValue[i + 1]);
            }
            var comStr = str + " WHERE " + stringBuilder.ToString();
            commmand.CommandText = comStr;
            var dt = DataAccess.LoadData(commmand);
            if (dt.Rows.Count != 0)
                return true;
            return false;
        }

        public bool Exist(DataTable dataTable,string fieldName, string value)
        {
            var isTrue = false;
            var qry = dataTable.AsEnumerable().Where(dt => dt.Field<string>(fieldName) == value);
            if (qry.Count() > 0)
                isTrue = true;
            return isTrue;
        }

    }
}