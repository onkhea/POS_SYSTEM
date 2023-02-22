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
using POS.Transaction;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class ADDCUSTOMER_FRM : Form //DevComponents.DotNetBar.Office2007Form
    {
        public ADDCUSTOMER_FRM()
        {
            InitializeComponent();
        }

        readonly DataManager dataManager = new DataManager();
        DateTimes dateTimes = new DateTimes();
        private void ADDCUSTOMER_FRM_Load(object sender, EventArgs e)
        {
           Utilities.Controls controls = new Controls();
           controls.AddEventHandler(txtCode, txtName, txtweb, txttel, txtLookup, txtfax, txtemail, txtContName, txtCom2, txtCom1, txtadd5, txtadd4, txtadd3, txtadd2, txtadd1,cboStatus);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            SICUSTOMER_FRM sicustomer_FRM = new SICUSTOMER_FRM();
            if (!Condition.EmptyControl(txtCode, txtName, cboStatus))
            {
                if (this.Text == "Edit Customer Information")
                {
                    if (txtCode.Text != SITempData.Code)
                    {
                        if (dataManager.Exists("SIPADDR", txtCode.Text,"ADD_CODE", "ADD_TYPE", "0"))
                        {
                            MessageBox.Show("Customer Code already exists!", "Already", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            txtCode.Focus();
                            return;
                        }
                    }
                }
                else if (this.Text == "Edit Supplier Information")
                {
                    if (txtCode.Text != SITempData.Code)
                    {
                        if (dataManager.Exists("SIPADDR", "ADD_CODE", txtCode.Text, "ADD_TYPE", "1"))
                        {
                            MessageBox.Show("Supplier Code already exists!", "Already", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            txtCode.Focus();
                            return;
                        }
                    }
                }

                else  // =========== Action when add new
                {
                    if (dataManager.Exists("SIPADDR", txtCode.Text, "ADD_CODE","ADD_TYPE",
                                           this.Text.IndexOf("Supplier") > -1 ? "1" : "0" ))
                    {
                        MessageBox.Show(
                            this.Text.IndexOf("Supplier") > -1 ? "Supplier" : "Customer" + " Code already!", "Already",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCode.Focus();
                        return;
                    }
               
            var adddelivery_FRM = new ADDDELIVERY_FRM();
                    adddelivery_FRM.Text = this.Text.IndexOf("Supplier") > -1
                                               ? "Supplier"
                                               : "Customer" + "Delivery Address";
                    adddelivery_FRM.txtadd1.Text = txtadd1.Text;
                    adddelivery_FRM.txtadd2.Text = txtadd2.Text;
                    adddelivery_FRM.txtadd3.Text = txtadd3.Text;
                    adddelivery_FRM.txtadd4.Text = txtadd4.Text;
                    adddelivery_FRM.txtadd5.Text = txtadd5.Text;
                    adddelivery_FRM.txtCode.Text = txtCode.Text;
                    adddelivery_FRM.txtCom1.Text = txtCom1.Text;
                    adddelivery_FRM.txtCom2.Text = txtCom2.Text;
                    adddelivery_FRM.txtContName.Text = txtContName.Text;
                    adddelivery_FRM.txtemail.Text = txtemail.Text;
                    adddelivery_FRM.txtfax.Text = txtfax.Text;
                    adddelivery_FRM.txtName.Text = txtName.Text;
                    adddelivery_FRM.txttel.Text = txttel.Text;
                    adddelivery_FRM.txtweb.Text = txtweb.Text;
                    if (adddelivery_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var fields = new string[]
                                         {
                                             "ADD_CODE", "DEL_CODE", "DEL_NAME,DEL_ADD_1", "DEL_ADD_2", "DEL_ADD_3",
                                             "DEL_ADD_4", "DEL_ADD_5", "DEL_TEL", "DEL_FAX", "DEL_EMAIL", "DEL_WEB",
                                             "DEL_CONT",
                                             "DEL_COM_1", "DEL_COM_2", "DEL_TYPE", "USER_CREA", "USER_UPDT", "USER_CODE"
                                         };
                        var values = new string[]
                                         {
                                             txtCode.Text, adddelivery_FRM.txtCode.Text, adddelivery_FRM.txtName.Text,
                                             adddelivery_FRM.txtadd1.Text, adddelivery_FRM.txtadd2.Text,
                                             adddelivery_FRM.txtadd3.Text,
                                             adddelivery_FRM.txtadd4.Text, adddelivery_FRM.txtadd5.Text,
                                             adddelivery_FRM.txttel.Text,
                                             adddelivery_FRM.txtfax.Text, adddelivery_FRM.txtemail.Text,
                                             adddelivery_FRM.txtweb.Text,
                                             adddelivery_FRM.txtContName.Text, adddelivery_FRM.txtCom1.Text,
                                             adddelivery_FRM.txtCom2.Text,
                                             this.Text.IndexOf("Supplier") > -1 ? "1" : "0",
                                             dateTimes.Now(), dateTimes.Now(), UserLogOn.Code

                                         };
                        DataAccess.SaveData("SIPDADD", fields, values);
                        adddelivery_FRM.Close();
                    }
                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

       private void cboStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboStatus.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtCom2.Focus();
            }
        }

       private void txtLookup_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtCode.Focus();
           }
       }

       private void txtName_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtLookup.Focus();
           }
       }

       private void txtadd1_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtName.Focus();
           }
       }

       private void txtadd2_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtadd1.Focus();
           }
       }

       private void txtadd3_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtadd2.Focus();
           }
       }

       private void txtadd4_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtadd3.Focus();
           }
       }

       private void txtadd5_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtadd4.Focus();
           }
       }

       private void txttel_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtadd5.Focus();
           }
       }

       private void txtfax_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txttel.Focus();
           }
       }

       private void txtemail_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtfax.Focus();
           }
       }

       private void txtweb_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtemail.Focus();
           }
       }

       private void txtContName_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtweb.Focus();
           }
       }

       private void txtCom1_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtContName.Focus();
           }
       }

       private void txtCom2_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               txtCom1.Focus();
           }
       }

       private void OK_Button_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.B)
           {
               cboStatus.Focus();
           }
       }
    }
}
