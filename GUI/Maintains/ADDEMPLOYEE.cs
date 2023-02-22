using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class ADDEMPLOYEE : Form//DevComponents.DotNetBar.Office2007Form
    {
        public ADDEMPLOYEE()
        {
            InitializeComponent();
        }
        
        private void ADDEMPLOYEE_Load(object sender, EventArgs e)
        {
            var controls = new Controls();
            controls.AddEventHandler(txtEmp_Code,txtEmp_Name,txtEmp_add,txtEmp_tel,cboEmp_Status);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            var dataManager = new DataManager();
            if (Condition.EmptyControl(txtEmp_Code,txtEmp_Name,cboEmp_Status))
                return;
            if (this.Text != "Edit Employee")
            {
                if (dataManager.Exists("SIPDATA", txtEmp_Code.Text, "SI_CODE", "SI_TYPE", "EMP"))
                {
                    MessageBox.Show("Employee Code already exists!", "Existring Record", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtEmp_Code.SelectAll();
                    txtEmp_Code.Focus();
                    return;
                }
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtEmp_Code.Text.PadLeft(20 - txtEmp_Code.Text.Length));
        }

        private void txtEmp_Code_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cboEmp_Status_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtEmp_Code.Focus();
            }
        }

        private void txtEmp_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                cboEmp_Status.Focus();
            }
        }

        private void txtEmp_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtEmp_Name.Focus();
            }
        }

        private void txtEmp_tel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtEmp_add.Focus();
            }
        }

        private void OK_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtEmp_tel.Focus();
            }
        }
    }
}