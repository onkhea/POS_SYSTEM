using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.GUI.User;
using POS.Utilities;

namespace POS.GUI.User
{
    public partial class ConnectionFrm : DevComponents.DotNetBar.Office2007Form
    {
        public ConnectionFrm()
        {
            InitializeComponent();
        }
        Controls controls = new Controls();

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = new Connection.Connection();
                if (checkBox1.Checked)
                {
                    connection.ConnStr = @TXTCON.Text;
                }
                else
                {
                   var temp_connection = connection.SetupConnection(TXTS.Text, TXTD.Text, TXTU.Text, TXTP.Text);
                    Debug.WriteLine(temp_connection);
                    
                }
                connection.WriteConnectionToFile();
                MessageBox.Show("successfull");
                var login_FRM = new LOGIN_FRM();
                this.Hide();
                login_FRM.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TXTCON.Enabled = true;
                controls.Enabled_Control_False(TXTD,TXTU,TXTS,TXTP);
            }
            else
            {
                controls.EnabledControlTrue(TXTD, TXTU, TXTS, TXTP);
                TXTCON.Enabled = false;
            }
        }

        private void CMD_CANCEL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConnectionFrm_Load(object sender, EventArgs e)
        {
            controls.AddEventHandler(TXTU,TXTS,TXTP,TXTD,TXTCON);
        }
    }
}