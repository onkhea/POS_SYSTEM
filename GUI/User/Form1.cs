using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConnectionSetup
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            IConnection connection = new Connection();
            connection.ReadConnectionFromFile();
            var conn = connection.ConnectDB();
            var sqlCommand = new SqlCommand("Select * from Category",conn);
            var dataAdapter = new SqlDataAdapter(sqlCommand);
            var dt = new DataTable();
            dataAdapter.Fill(dt);
            
//            conn.Open();
        }
    }
}
