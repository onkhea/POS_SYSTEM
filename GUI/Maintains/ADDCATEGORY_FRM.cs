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
    public partial class ADDCATEGORY_FRM : Form //DevComponents.DotNetBar.Office2007Form
    {
        public ADDCATEGORY_FRM()
        {
            InitializeComponent();
        }
        readonly DataManager dataManager = new DataManager();

        private void ADDCATEGORY_FRM_Load(object sender, EventArgs e)
        {
            var  controls = new Controls();
            controls.AddEventHandler(txtCode,txtDes,cboStatus);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Condition.EmptyControl(txtCode, txtDes, cboStatus))
                return;
            if (this.Text != "Edit Category")
            {
                if (dataManager.Exists("SIPDATA", txtCode.Text, "SI_CODE", "SI_TYPE", "CATE"))
                {
                    MessageBox.Show("Category Code already exists!", "Existring Record", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtCode.SelectAll();
                    txtCode.Focus();
                    return;
                }
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
