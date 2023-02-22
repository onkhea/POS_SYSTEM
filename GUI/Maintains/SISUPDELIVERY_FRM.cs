using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction;
using POS.Transaction.Maintains;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class SISUPDELIVERY_FRM : DevComponents.DotNetBar.Office2007Form
    {
        public SISUPDELIVERY_FRM()
        {
            InitializeComponent();
        }
        #region Global Variable

        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
        readonly SISupplierDelivery supplierDelivery = new SISupplierDelivery();
        readonly DateTimes dateTimes = new DateTimes();
        readonly Controls controls = new Controls();
        List<string> Clone = new List<string>();
        OutLook outLook = new OutLook();
        DataManager dataManager = new DataManager();
        #endregion

        private void SISUPDELIVERY_FRM_Load(object sender, EventArgs e)
        {
            try
            {
              controls.BindingDataToDataGrid(DataGridView1,supplierDelivery.LoadData());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            var adddelivery_FRM = new ADDDELIVERY_FRM();
            if (security.CheckPermission(UserLogOn.Code, menuItems.SupplierDeliveryAddresses, "V", subMenuItems.NewLine, true) ==
           false)
                return;
            adddelivery_FRM.Text = "Add Supplier Delivery Address";
            if (adddelivery_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    var values = new string[]
                                 {
                                     "", adddelivery_FRM.txtCode.Text, adddelivery_FRM.txtName.Text,
                                     adddelivery_FRM.txtadd1.Text,adddelivery_FRM.txtadd2.Text,adddelivery_FRM.txtadd3.Text,
                                     adddelivery_FRM.txtadd4.Text,adddelivery_FRM.txtadd5.Text,adddelivery_FRM.txttel.Text,
                                     adddelivery_FRM.txtfax.Text,adddelivery_FRM.txtemail.Text,adddelivery_FRM.txtweb.Text,
                                     adddelivery_FRM.txtContName.Text,adddelivery_FRM.txtCom1.Text,adddelivery_FRM.txtCom2.Text,
                                     "1",dateTimes.Now(),dateTimes.Now(),UserLogOn.Code
                                     
                                 };
                    supplierDelivery.Save(values);
                    controls.AddToDataGridView(DataGridView1,"", adddelivery_FRM.txtCode.Text, adddelivery_FRM.txtName.Text,
                                               adddelivery_FRM.txtadd1.Text, adddelivery_FRM.txtadd2.Text,
                                               adddelivery_FRM.txtadd3.Text, adddelivery_FRM.txtadd4.Text,
                                               adddelivery_FRM.txtadd5.Text, adddelivery_FRM.txttel.Text,
                                               adddelivery_FRM.txtfax.Text, adddelivery_FRM.txtemail.Text,
                                               adddelivery_FRM.txtweb.Text, adddelivery_FRM.txtContName.Text,
                                               adddelivery_FRM.txtCom1.Text, adddelivery_FRM.txtCom2.Text, "1",
                                               UserLogOn.Code, UserLogOn.Code, UserLogOn.Code);
                    Cursor = Cursors.Default;
                    MessageBox.Show("Record have been created!", "Already", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
                adddelivery_FRM.Close();
            }
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SupplierDeliveryAddresses, "V", subMenuItems.EditLine, true) ==
         false)
                return;
                var delivery_FRM = new ADDDELIVERY_FRM();
            delivery_FRM.Text = "Edit Supplier Delivery Address";
            delivery_FRM.txtCode.Enabled = false;
            delivery_FRM.txtCode.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            delivery_FRM.txtName.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            delivery_FRM.txtadd1.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            delivery_FRM.txtadd2.Text = DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            delivery_FRM.txtadd3.Text = DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            delivery_FRM.txtadd4.Text = DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            delivery_FRM.txtadd5.Text = DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            delivery_FRM.txttel.Text = DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            delivery_FRM.txtfax.Text = DataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            delivery_FRM.txtemail.Text = DataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            delivery_FRM.txtweb.Text = DataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            delivery_FRM.txtContName.Text = DataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            delivery_FRM.txtCom1.Text = DataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            delivery_FRM.txtCom2.Text = DataGridView1.SelectedRows[0].Cells[14].Value.ToString();

            if (delivery_FRM.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                     var fields = new[]
                             {
                                 "DEL_NAME", "DEL_ADD_1", "DEL_ADD_2", "DEL_ADD_3", "DEL_ADD_4",
                                 "DEL_ADD_5", "DEL_TEL", "DEL_FAX", "DEL_EMAIL", "DEL_WEB", "DEL_CONT", "DEL_COM_1",
                                 "DEL_COM_2", "DEL_TYPE", "USER_CREA", "USER_UPDT", "USER_CODE"
                             };
                    var paramAndValue = new[]
                                            {
                                                "DEL_NAME", delivery_FRM.txtName.Text, "DEL_ADD_1",
                                                delivery_FRM.txtadd1.Text, "DEL_ADD_2",delivery_FRM.txtadd2.Text,
                                                "DEL_ADD_3",delivery_FRM.txtadd3.Text,"DEL_ADD_4",delivery_FRM.txtadd4.Text,
                                                "DEL_ADD_5",delivery_FRM.txtadd5.Text,"DEL_TEL",delivery_FRM.txttel.Text,
                                                "DEL_FAX",delivery_FRM.txtfax.Text,"DEL_EMAIL",delivery_FRM.txtemail.Text,
                                                "DEL_WEB", delivery_FRM.txtweb.Text,"DEL_CONT",delivery_FRM.txtContName.Text,
                                                "DEL_COM_1",delivery_FRM.txtCom1.Text,"DEL_COM_2",delivery_FRM.txtCom2.Text,
                                                "USER_UPDT",dateTimes.Now(),"USER_CODE",UserLogOn.Code
                                            };
                    var conditions = new[]
                                         {
                                             "ADD_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                                             "DEL_CODE",delivery_FRM.txtCode.Text,"DEL_TYPE","1"
                                         };
                     
                    supplierDelivery.Update(paramAndValue,conditions);

                    controls.UpdateDataToGridView(DataGridView1,"", delivery_FRM.txtCode.Text,
                                                  delivery_FRM.txtName.Text, delivery_FRM.txtadd1.Text,
                                                  delivery_FRM.txtadd2.Text, delivery_FRM.txtadd3.Text,
                                                  delivery_FRM.txtadd4.Text, delivery_FRM.txtadd5.Text,
                                                  delivery_FRM.txttel.Text, delivery_FRM.txtfax.Text,
                                                  delivery_FRM.txtemail.Text, delivery_FRM.txtweb.Text,
                                                  delivery_FRM.txtContName.Text, delivery_FRM.txtCom1.Text,
                                                  delivery_FRM.txtCom2.Text, "0",
                                                  DataGridView1.SelectedRows[0].Cells[17].Value.ToString(),
                                                  dateTimes.Now(), UserLogOn.Code);
                    Cursor = Cursors.Default;
                    MessageBox.Show("Record have been edited!", "Successfull Edit", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
                delivery_FRM.Close();
            }
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.SupplierDeliveryAddresses, "V", subMenuItems.DeleteLine, true) ==
    false)
                    return;
                if (MessageBox.Show("Are you sure you want to delete this item?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    var paraAndValue = new string[] { "ADD_CODE", "", "DEL_CODE", DataGridView1.SelectedRows[0].Cells[1].Value.ToString(), "DEL_TYPE","1" };
                    supplierDelivery.Delete(paraAndValue);
                    DataGridView1.Rows.Remove(DataGridView1.SelectedRows[0]);
                    MessageBox.Show("Record was deleted successfully!", "Delete", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.SupplierDeliveryAddresses, "V", subMenuItems.CloneLine, true) ==
    false)
                return;
            Clone.Clear();
            outLook.CloneData(Clone, DataGridView1);
            PasteToolStripMenuItem1.Enabled = true;
            PasteToolStripMenuItem.Enabled = true;
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.SupplierDeliveryAddresses, "V", subMenuItems.PasteLine, true) ==
    false)
                    return;
                var adddelivery_FRM = new ADDDELIVERY_FRM();
                adddelivery_FRM.Text = "Paste Item Record";
                var textBox = new TextBox(){};
                textBox.Text = "";
                outLook.PasteData(Clone,textBox,adddelivery_FRM.txtCode, adddelivery_FRM.txtName,
                                  adddelivery_FRM.txtadd1, adddelivery_FRM.txtadd2,
                                  adddelivery_FRM.txtadd3, adddelivery_FRM.txtadd4,
                                  adddelivery_FRM.txtadd5, adddelivery_FRM.txttel, adddelivery_FRM.txtfax,
                                  adddelivery_FRM.txtemail,adddelivery_FRM.txtweb, adddelivery_FRM.txtContName,
                                  adddelivery_FRM.txtCom1, adddelivery_FRM.txtCom2);
            lbl:
                if (adddelivery_FRM.ShowDialog() ==DialogResult.OK )
                {
                    if (dataManager.Exists("SIPDADD", "1", "DEL_TYPE", "DEL_CODE",adddelivery_FRM.txtCode.Text))
                    {
                        MessageBox.Show("Code " + adddelivery_FRM.txtCode.Text + " already.", "Existing code",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        goto lbl;
                        
                    }
                    Cursor = Cursors.WaitCursor;

                    var values = new[]
                                 {
                                     "", adddelivery_FRM.txtCode.Text, adddelivery_FRM.txtName.Text,
                                     adddelivery_FRM.txtadd1.Text,adddelivery_FRM.txtadd2.Text,adddelivery_FRM.txtadd3.Text,
                                     adddelivery_FRM.txtadd4.Text,adddelivery_FRM.txtadd5.Text,adddelivery_FRM.txttel.Text,
                                     adddelivery_FRM.txtfax.Text,adddelivery_FRM.txtemail.Text,adddelivery_FRM.txtweb.Text,
                                     adddelivery_FRM.txtContName.Text,adddelivery_FRM.txtCom1.Text,adddelivery_FRM.txtCom2.Text,
                                     "1",dateTimes.Now(),dateTimes.Now(),UserLogOn.Code
                                     
                                 };
                  supplierDelivery.Save(values);
                    var val = new[]
                                  {
                                      "", adddelivery_FRM.txtCode.Text,
                                      adddelivery_FRM.txtName.Text, adddelivery_FRM.txtadd1.Text,
                                      adddelivery_FRM.txtadd2.Text, adddelivery_FRM.txtadd3.Text,
                                      adddelivery_FRM.txtadd4.Text, adddelivery_FRM.txtadd5.Text,
                                      adddelivery_FRM.txttel.Text, adddelivery_FRM.txtfax.Text,
                                      adddelivery_FRM.txtemail.Text, adddelivery_FRM.txtweb.Text,
                                      adddelivery_FRM.txtContName.Text, adddelivery_FRM.txtCom1.Text,
                                      adddelivery_FRM.txtCom2.Text, "1",UserLogOn.Code,dateTimes.Now(), UserLogOn.Code
                                  };
                  controls.AddToDataGridView(DataGridView1,val);
                    Cursor = Cursors.Default;
                    MessageBox.Show("Record have been pasted!", "Paste Successful", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    adddelivery_FRM.Close();
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var siSupplierDelivery = new SISupplierDelivery();
            controls.BindingDataToDataGrid(DataGridView1, siSupplierDelivery.LoadData());
        }

        private void NewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToolStripButton_Click(sender,e);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditToolStripButton1_Click(sender,e);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteToolStripButton2_Click(sender,e);
        }

        private void CloneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloneToolStripMenuItem_Click(sender,e);
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(sender,e);
        }

        private void CloseTool_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
