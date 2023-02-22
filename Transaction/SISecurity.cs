using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Connection;
using POS.DataLayer;

namespace POS.Transaction
{
    class SISecurity
    {
        private readonly IConnection connection = new Connection.Connection();

        /// <summary>
        /// this function for check permission in database 
        /// </summary>
        /// <param name="userCode">123</param>
        /// <param name="menuItem">Group Management</param>
        /// <param name="per_Type">New User</param>
        /// <param name="per_Action">V</param>
        /// <param name="mSG">True</param>
        /// <returns></returns>
        public bool CheckPermission(string userCode, string menuItem, string per_Type, string per_Action, bool mSG)
        {
            var dataManager = new DataManager();
            var command =
                new SqlCommand("SELECT * FROM (SELECT DISTINCT PER_ACTION FROM dbo.SIPUSERP WHERE USER_CODE='" +
                               userCode + "' AND PER_TYPE='V' AND GR_DB_CODE='" + menuItem +
                               "' UNION SELECT DISTINCT PER_ACTION FROM dbo.SIPUSERP WHERE GR_DB_CODE='" + menuItem +
                               "' AND PER_TYPE='V' AND USER_CODE IN(SELECT GR_DB_CODE FROM dbo.SIPUSERG WHERE USER_CODE='" +
                               userCode + "' AND PER_TYPE='G')) M WHERE M.PER_ACTION='" + per_Action + "'",connection.Connect());
            if (dataManager.GetData(command).Rows.Count == 0 && userCode != "SISA" )
            {
                if (mSG)
                {
                    MessageBox.Show("Your user id have no permission on" + per_Action + "!", "Not Allow",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return false;
            }
            return true;
        }
    }
}
