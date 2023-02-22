using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Utilities;

namespace POS.GUI.POS
{
    public partial class SALEFREE_FRM : Form
    {
        public SALEFREE_FRM()
        {
            InitializeComponent();
        }

        public string code = "";
        public string strCode = "";
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Label1.Text.Substring(Label1.Text.Length - 5,5) == ".....")
            {
                Label1.Text = Label1.Text.Substring(0, Label1.Text.Length - 5);
                Label2.Text = Label2.Text.Substring(0, Label2.Text.Length - 5);
            }
            else
            {
                Label1.Text = Label1.Text + ".";
                Label2.Text = Label2.Text + ">";
            }
        }

        private void SALEFREE_FRM_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)13)
            {
                if (strCode == "")
                    return;
                else
                {
                    code = strCode;
                    strCode = "";
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            else if(e.KeyChar == (char)27)
            {
                strCode = "";
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            else
            {
                strCode = strCode + e.KeyChar;
            }
        }

        private void SALEFREE_FRM_Load(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }
    }
}
