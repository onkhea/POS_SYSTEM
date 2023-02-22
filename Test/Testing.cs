using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.GUI;
using POS.GUI.Maintains;
using POS.GUI.Purchases;
using POS.GUI.User;
using POS.Utilities;

namespace POS.Test
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sisupdelivery_FRM = new SISUPDELIVERY_FRM();
            sisupdelivery_FRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sicustomer_FRM = new SICUSTOMER_FRM();
            sicustomer_FRM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SISUPPLIER_FRM suFRM = new SISUPPLIER_FRM();
            suFRM.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LOCATION_FRM location_FRM = new LOCATION_FRM();
            location_FRM.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SIEMPLOYEE_FRM siemployee_FRM = new SIEMPLOYEE_FRM();
            siemployee_FRM.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SIITEMS_FRM iteFRM = new SIITEMS_FRM();
            iteFRM.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SIOPTIONS_FRM opFRM = new SIOPTIONS_FRM();
            opFRM.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           EXCHANGERATE_FRM exhcnangerate_FRM = new EXCHANGERATE_FRM();
            exhcnangerate_FRM.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var uFRM = new SIUNITCONVERT_FRM();
            uFRM.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var login_FRM = new LOGIN_FRM();
            login_FRM.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var connectionFrm = new ConnectionFrm();
            connectionFrm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GROUP_FRM group_FRM = new GROUP_FRM();
            group_FRM.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            USER_FRM user_FRM = new USER_FRM();
            user_FRM.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            INVOICE_OPTION_FRM invoice_OPTION_FRM = new INVOICE_OPTION_FRM();
            invoice_OPTION_FRM.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ADDDESCRIPTION_FRM adddescription_FRM = new ADDDESCRIPTION_FRM();
            adddescription_FRM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cuFRM  = new SICUSDELIVERY_FRM();
            cuFRM.ShowDialog();


        }

        private void button18_Click(object sender, EventArgs e)
        {
            var sipopurchaseorder_FRM = new SIPOPURCHASEORDER_FRM();
            sipopurchaseorder_FRM.ShowDialog();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            var sipopurchaseorder_FRM = new SIPOPURCHASEORDER_FRM();
            var addsipopurchaseorder_FRM = new ADDSIPOPURCHASEORDER_FRM(sipopurchaseorder_FRM);
            addsipopurchaseorder_FRM.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var sipopurchasematching_FRM = new SIPOPURCHASEMATCHING_FRM();
            sipopurchasematching_FRM.ShowDialog();
        }

        private void Testing_Load(object sender, EventArgs e)
        {
//            Controls controls = new Controls();
//            controls.Control_Back(textBox2,textBox1,textBox8,textBox3,textBox4,textBox5,textBox6,textBox7);

        }
       
    }
}
