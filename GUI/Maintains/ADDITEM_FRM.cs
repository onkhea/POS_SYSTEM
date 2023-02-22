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
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class ADDITEM_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public ADDITEM_FRM()
        {
            InitializeComponent();
        }

        private void ADDITEM_FRM_Load(object sender, EventArgs e)
        {
            controls.AddEventHandler(txtCode, txtName, txtBcode, cbotype, txtcus1, txtcus2, txtcus3, txtcus4, txtCus5,
                                     txtCus6, txtCus7, txtCus8, txtcuskh1, txtcuskh2, txtCostUStock, txtPriceUStock,
                                     txtCostUSale, txtPriceUSale);
        }

        readonly DataManager dataManager = new DataManager();
        Controls controls = new Controls();
        Connection.Connection connection = new Connection.Connection();

        #region Image

        private void btnB_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF;*.jpeg";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PictureBox1.Image = null;
        }

        #endregion

        #region Supplier

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count >0)
            {
                ListView1.Items.Remove(ListView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("There is no selected item to delete!", "Delete", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "&Edit")
            {
                if (ListView1.SelectedItems.Count > 0)
                {
                    ListViewItem lvItem = ListView1.SelectedItems[0];
                    txtSuppierCode.Text = lvItem.Text;
                    txtSuppierCode.Enabled = false;
                    btnSuplierCode.Enabled = false;
                    txtSDesc.Text = lvItem.SubItems[1].Text;
                    txtUnitofPurchase.Text = lvItem.SubItems[2].Text;
                    txtPurchaseCost.Text = lvItem.SubItems[3].Text;
                    ListView1.Enabled = false;
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Text = "&Change";
                }
            }
            else
            {
                if (!Condition.EmptyControl(txtSuppierCode))
                {
                    if (dataManager.Exists("SIPADDR", "ADD_TYPE", "1", "ADD_STAT", "A", "ADD_CODE", txtSuppierCode.Text)== false)
                    {
                       txtSuppierCode.SelectAll();
                        txtSuppierCode.Focus();
                        return;
                    }
                    if (!Condition.Check_Numeric(txtPurchaseCost))
                    {
                        controls.Update_ListView(ListView1,txtSuppierCode.Text, txtSDesc.Text, txtUnitofPurchase.Text, txtPurchaseCost.Text);
                        txtSuppierCode.Enabled = true;
                        btnSuplierCode.Enabled = true;
                        ListView1.Enabled = true;
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnEdit.Text = "&Edit";
                    }
                }  
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Condition.EmptyControl(txtSuppierCode))
                {
                    if (dataManager.Exists("SIPADDR", "ADD_TYPE", "1", "ADD_STAT", "A", "ADD_CODE", txtSuppierCode.Text) == false)
                    {
                        MessageBox.Show("Data '" + txtSuppierCode.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSuppierCode.SelectAll();
                        txtSuppierCode.Focus();
                        return;
                    }
                    if (Condition.Check_Numeric(txtPurchaseCost))return;

                    foreach (ListViewItem item in ListView1.Items)
                    {
                        if (item.Text == txtSuppierCode.Text)
                        {
                            MessageBox.Show("Supplier code '" + txtSuppierCode.Text + "' already!", "Existing",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    ListViewItem lvItems = ListView1.Items.Add(txtSuppierCode.Text);
                    lvItems.SubItems.Add(txtSDesc.Text);
                    lvItems.SubItems.Add(txtUnitofPurchase.Text);
                    lvItems.SubItems.Add(txtPurchaseCost.Text);

                    controls.ClearControl(txtSuppierCode,txtSDesc,txtUnitofPurchase,txtPurchaseCost);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuplierCode_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var command =
                    new SqlCommand(
                        "SELECT ADD_CODE [Sup. Code],ADD_LOOKUP [Lookup],ADD_NAME [Supplier Name] FROM SIPADDR WHERE ADD_TYPE=1 AND ADD_STAT='A' AND ADD_CODE LIKE @ADD_CODE ORDER BY ADD_CODE",
                        connection.Connect());
                command.Parameters.AddWithValue("@ADD_CODE", txtSuppierCode.Text + "%");
                var dataAdapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                dataAdapter.Fill(dt);
                var droplist_FRM = new DROPLIST_FRM();

                droplist_FRM.DataGridView.DataSource = dt;

                droplist_FRM.Top = this.Top + txtSuppierCode.Top + 2 * btnSuplierCode.Height + 39;
                droplist_FRM.Left = this.Left + txtSuppierCode.Left + 7;
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.Width * 27 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.Width * 27 / 100;
                droplist_FRM.DataGridView.Columns[2].Width = droplist_FRM.Width * 40 / 100;
                droplist_FRM.ShowDialog();
                if (droplist_FRM.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    txtSuppierCode.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    txtSDesc.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    SelectNextControl(btnSuplierCode, true, true, true, true);
                }
                else if (droplist_FRM.DialogResult == DialogResult.No)
                {
                    txtSuppierCode.SelectAll();
                    txtSuppierCode.Focus();
                }
                droplist_FRM.Close();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSuppierCode_KeyDown(object sender, KeyEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtSuppierCode.Text == "")
                    {
                        if (Condition.EmptyControl(txtSuppierCode)) return;
                    }
                    var dt = dataManager.GetData("SELECT ADD_CODE,ADD_NAME FROM SIPADDR", "ADD_CODE", "ADD_CODE",
                                                     txtSuppierCode.Text, "ADD_TYPE", "1", "ADD_STAT", "A");
                        if (dt.Rows.Count > 0)
                        {
                            txtSuppierCode.Text = dt.Rows[0][0].ToString();
                            txtSDesc.Text = dt.Rows[0][1].ToString();
                            SelectNextControl(txtSuppierCode, true, true, true, true);
                        }
                        else
                        {
                            MessageBox.Show("Data '" + txtSuppierCode.Text + "' not found");
                            txtSuppierCode.SelectAll();
                            txtSuppierCode.Focus();
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnSuplierCode_Click(sender,e);
            }
            Cursor = Cursors.Default;
        }

        private void txtUnitofPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtUnitStock.Text != "")
                    {
                        if (txtUnitofPurchase.Text == "")
                        {
                            if (Condition.EmptyControl(txtUnitofPurchase)) return;
                        }
                        Cursor = Cursors.WaitCursor;
                        var dt = dataManager.GetData("SELECT CONV_FROM FROM SIUNITCONV", "CONV_FROM", "CONV_FROM",
                                                     txtUnitofPurchase.Text, "CONV_TO", txtUnitStock.Text);
                        if (dt.Rows.Count > 0)
                        {
                            txtUnitofPurchase.Text = dt.Rows[0][0].ToString();
                            SelectNextControl(txtUnitofPurchase, true, true, true, true);
                        }
                        else
                        {
                            MessageBox.Show("Data '" + txtUnitofPurchase.Text + "' not found!", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                            txtUnitofPurchase.SelectAll();
                            txtUnitofPurchase.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have to fill unit stock first!");
                    }
                    Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnUnitofPurchase_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtSuppierCode.Focus();
            }

        }

        #endregion

      
        private void btnUnitofPurchase_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            try
            {
                if (txtUnitStock.Text != "")
                {
                    Cursor = Cursors.WaitCursor;
                    var command =
                        new SqlCommand(
                            "SELECT CONV_FROM [Unit Pur.],OPERATOR + CONVERT(nvarchar,FACTOR) [Lookup],CONV_TO [Unit Stock] FROM SIUNITCONV WHERE CONV_FROM LIKE @CONV_FROM AND CONV_TO=@CONV_TO ORDER BY CONV_FROM",
                            connection.Connect());
                    command.Parameters.AddWithValue("@CONV_FROM", txtUnitofPurchase.Text + "%");
                    command.Parameters.AddWithValue("@CONV_TO", txtUnitStock.Text);
                    var dataAdapter = new SqlDataAdapter(command);
                    var dt = new DataTable();
                    dataAdapter.Fill(dt);
                    var droplist_FRM = new DROPLIST_FRM();
                    droplist_FRM.DataGridView.DataSource = dt;

                    droplist_FRM.Top = this.Top + btnUnitofPurchase.Top + 2*btnUnitofPurchase.Height + 39;
                    droplist_FRM.Left = this.Left + txtSuppierCode.Left + 7;
                    droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.Width*27/100;
                    droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.Width*27/100;
                    droplist_FRM.DataGridView.Columns[2].Width = droplist_FRM.Width*40/100;
                    droplist_FRM.ShowDialog();
                    if (droplist_FRM.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        txtUnitofPurchase.Text =
                            droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                        SelectNextControl(btnSuplierCode, true, true, true, true);
                    }
                    else if (droplist_FRM.DialogResult == DialogResult.No)
                    {
                        txtUnitofPurchase.SelectAll();
                        txtUnitofPurchase.Focus();
                    }
                    droplist_FRM.Close();
                    Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("You have to fill unit stock first!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Default;
        }

        private void btnUnitStock_Click(object sender, EventArgs e)
        {
            try
            {
                
                var droplist_FRM = new DROPLIST_FRM();
                var str = "";
                if (txtUnitSale.Text != "")
                {
                    str = " AND CONV_FROM=@CONV_FROM";
                }
                var command =
                    new SqlCommand(
                        "SELECT CONV_FROM [Unit of Sale],OPERATOR + CONVERT(nvarchar,FACTOR) [Lookup],CONV_TO [Unit of Stock] FROM SIUNITCONV WHERE CONV_TO>=@CONV_TO" +
                        str + " ORDER BY CONV_FROM", connection.Connect());
                if (txtUnitSale.Text != "")
                {
                    command.Parameters.AddWithValue("@CONV_FROM", txtUnitSale.Text);
                }
                command.Parameters.AddWithValue("@CONV_TO", txtUnitStock.Text);
                var dataAdapter = new SqlDataAdapter(command);
                var dt = new DataTable(); 
                dataAdapter.Fill(dt);
                droplist_FRM.DataGridView.DataSource = dt;
                droplist_FRM.Top = this.Top + txtUnitStock.Top + txtUnitStock.Height + 60;
                droplist_FRM.Left = this.Left + txtUnitStock.Left + 6;
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width*34/100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width*33/100;
                droplist_FRM.DataGridView.Columns[2].Width = droplist_FRM.DataGridView.Width*30/100;
                if (droplist_FRM.ShowDialog() == DialogResult.OK)
                {
                    txtUnitStock.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                    SelectNextControl(txtUnitStock, true, true, true, true);
                }
                else
                {
                    txtUnitStock.SelectAll();
                    txtUnitStock.Focus();
                }
                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUnitStock_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtUnitStock.Text == "")
                    {
                        if (cbotype.Text == "S - Stock Item")
                        {
                            if (Condition.EmptyControl(txtUnitStock)) return;
                        }
                        SelectNextControl(txtUnitStock, true, true, true, true);
                    }
                    else
                    {
                        string st = "";
                        if (txtUnitSale.Text !="")
                        {
                            st = " AND UPPER(CONV_FROM) LIKE UPPER(@CONV_FROM)";
                        }
                        var command = new SqlCommand("SELECT CONV_TO FROM SIUNITCONV WHERE UPPER(CONV_TO)LIKE UPPER(@CONV_TO)" + st,connection.Connect());
                        if (txtUnitSale.Text != "")
                        {
                            command.Parameters.AddWithValue("@CONV_FROM", txtUnitSale.Text + "%" );
                        }
                        command.Parameters.AddWithValue("@CONV_TO", txtUnitStock.Text + "%");
                        var dataAdapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            txtUnitStock.Text = dt.Rows[0][0].ToString();
                            SelectNextControl(txtUnitStock, true, true, true, true);
                        }
                        else
                        {
                            MessageBox.Show("Data '" + txtUnitStock.Text + "' not found", "Not Found",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUnitStock.SelectAll();
                            txtUnitStock.Focus();
                        }
                    }
                }
                else if(e.KeyCode == Keys.F6)
                {
                    btnUnitStock_Click(sender,e);
                }
                else if (e.Control && e.KeyCode == Keys.B)
                {
                    cbotype.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnitSale_Click(object sender, EventArgs e)
        {
            try
            {
                var droplist_FRM = new DROPLIST_FRM();
                var st = "";
                if (txtUnitStock.Text != "")
                {
                    st = " AND CONV_TO = @CONV_TO";
                }
                var command =
                    new SqlCommand(
                        "SELECT CONV_FROM [Unit of Sale],OPERATOR + CONVERT(nvarchar,FACTOR) [Lookup],CONV_TO [Unit of Stock] FROM SIUNITCONV WHERE CONV_FROM>=@CONV_FROM" +
                        st + " ORDER BY CONV_FROM", connection.Connect());
                if (txtUnitStock.Text != "")
                {
                    command.Parameters.AddWithValue("@CONV_TO", txtUnitStock.Text);
                }
                command.Parameters.AddWithValue("@CONV_FROM", txtUnitSale.Text);
                var dataAdapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                dataAdapter.Fill(dt);
                droplist_FRM.DataGridView.DataSource = dt;
                droplist_FRM.Top = this.Top + txtUnitSale.Top + txtUnitSale.Height + 60;
                droplist_FRM.Left = this.Left + txtUnitSale.Left + 6;
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width * 34 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width * 33 / 100;
                droplist_FRM.DataGridView.Columns[2].Width = droplist_FRM.DataGridView.Width * 30 / 100;
                if (droplist_FRM.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    txtUnitSale.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    SelectNextControl(txtUnitSale, true, true, true, true);
                }
                else
                {
                    txtUnitSale.SelectAll();
                    txtUnitSale.Focus();
                }
                droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUnitSale_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtUnitSale.Text == "")
                    {
                        if (Condition.EmptyControl(txtUnitSale)) return;
                    }
                    else
                    {
                        var st = "";
                        if (txtUnitStock.Text != "")
                        {
                            st = " AND UPPER(CONV_TO) LIKE UPPER(@CONV_TO)";
                        }
                        var command = new SqlCommand("SELECT CONV_FROM [Unit of Sale],OPERATOR + CONVERT(nvarchar,FACTOR) [Lookup],CONV_TO [Unit of Stock] FROM SIUNITCONV WHERE UPPER(CONV_FROM) LIKE UPPER(@CONV_FROM) " + st , connection.Connect());
                        if (txtUnitStock.Text != "")
                        {
                            command.Parameters.AddWithValue("@CONV_TO", txtUnitStock.Text + "%");
                        }
                        command.Parameters.AddWithValue("@CONV_FROM", txtUnitSale.Text + "%");
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            txtUnitSale.Text = dt.Rows[0][0].ToString();
                            SelectNextControl(txtUnitSale, true, true, true, true);
                        }
                        else
                        {
                            MessageBox.Show("Data '" + txtUnitSale.Text + "' not found", "", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            txtUnitSale.SelectAll();
                            txtUnitSale.Focus();
                        }
                    }
                }
                else if(e.KeyCode == Keys.F6)
                {
                    btnUnitSale_Click(sender,e);
                }
                else if (e.Control && e.KeyCode == Keys.B)
                {
                    txtPriceUStock.Focus();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnItemP_Click(object sender, EventArgs e)
        {
            try
            {
                var command =
                    new SqlCommand(
                        "SELECT SI_CODE [Category Code],SI_DATA [Description] FROM SIPDATA WHERE SI_CODE LIKE @CODE AND SI_TYPE='CATE' AND SI_LOOKUP='A' ORDER BY SI_CODE",
                        connection.Connect());
                command.Parameters.AddWithValue("@CODE", txtCate.Text + "%");
                var dataAdapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                dataAdapter.Fill(dt);
                var droplist_FRM = new DROPLIST_FRM();
                droplist_FRM.DataGridView.DataSource = dt;
                droplist_FRM.Top = this.Top + txtCate.Top + txtCate.Height + 60;
                droplist_FRM.Left = this.Left + txtCate.Left + 6;
                droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.DataGridView.Width * 30 / 100;
                droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.DataGridView.Width * 60 / 100;
                if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtCate.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                    SelectNextControl(btnItemP, true, true, true, true);
                }
                else
                {
                    txtCate.SelectAll();
                    txtCate.Focus();
                }
               droplist_FRM.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtCate.Text == "")
                    {
                        if (Condition.EmptyControl(txtCate)) return;
                    }
                    else
                    {
                        var command = new SqlCommand("SELECT SI_CODE FROM SIPDATA WHERE SI_TYPE='CATE' AND UPPER(SI_CODE) LIKE UPPER(@SI_CODE) AND SI_LOOKUP='A'", connection.Connect());
                        ;
                        command.Parameters.AddWithValue("@SI_CODE", txtCate.Text + "%");
                        var dataAdapter = new SqlDataAdapter(command);
                        var dt = new DataTable();
                        dataAdapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            txtCate.Text = dt.Rows[0][0].ToString();
                            SelectNextControl(txtCate, true, true, true, true);
                        }
                        else
                        {
                            MessageBox.Show("Data '" + txtCate.Text + "' not found");
                            txtCate.SelectAll();
                            txtCate.Focus();
                            return;
                        }
                    }
                }
                else if (e.KeyCode == Keys.F6)
                {
                    btnItemP_Click(sender,e);
                }
                else if (e.Control && e.KeyCode == Keys.B)
                {
                    txtPriceUSale.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPurchaseCost_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (Condition.Check_Numeric(txtPurchaseCost)) return;
                SelectNextControl(txtPurchaseCost, true, true, true, true);

            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtUnitofPurchase.Focus();
            }


        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Condition.EmptyControl(txtCode,txtName,cbotype,cboStatus)) return;
            if (Condition.Check_Decimal(txtCostUStock,txtPriceUStock,txtCostUSale,txtPriceUSale)) return;
            if (cbotype.Text == "S - Stock Item")
            {
                if (Condition.EmptyControl(txtUnitStock))return;
            }
                if (txtUnitSale.Text != "")
                {
                    if (dataManager.Exists("SIUNITCONV",txtUnitSale.Text,"CONV_FROM","CONV_TO",txtUnitStock.Text)== false)
                    {
                        MessageBox.Show("Data '" + txtUnitSale.Text + "' not found");
                        txtUnitSale.SelectAll();
                        txtUnitSale.Focus();
                        return;
                    }
                }
                if (txtUnitStock.Text != "")
                {
                    if (dataManager.Exists("SIUNITCONV", txtUnitStock.Text, "CONV_TO") == false)
                    {
                        MessageBox.Show("Data '" + txtUnitStock.Text + "' not found");
                        txtUnitStock.SelectAll();
                        txtUnitStock.Focus();
                        return;
                    }
                }
                if (txtCate.Text.Trim() != "")
                {
                    if (dataManager.Exists("SIPDATA",txtCate.Text,"SI_CODE","SI_TYPE","CATE") == false)
                    {
                        MessageBox.Show("Data '" + txtCate.Text + "' not found");
                        txtCate.SelectAll();
                        txtCate.Focus();
                        return;
                    }
                }
            txtCode.SelectAll();
            txtCode.Focus();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtCostUStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!Condition.Check_Decimal(txtCostUStock))return;
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtUnitStock.Focus();
            }

        }

        private void txtPriceUStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtCostUStock.Focus();
                return;
            }
            if (e.KeyCode != Keys.Enter) return;
            if(!Condition.Check_Decimal(txtPriceUStock)) return;
        }

        private void txtCostUSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                if (!Condition.Check_Decimal(txtCostUSale)) return;
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtUnitSale.Focus();
            }


        }

        private void txtPriceUSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!Condition.Check_Decimal(txtPriceUSale))return;
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtCostUSale.Focus();
            }

        }

        private void txtCate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Condition.EmptyControl(cbotype))
                    SelectNextControl(cboStatus,true,true,true,true);

            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                txtCate.Focus();
            }

        }

        private void txtPriceUSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBcode_KeyDown(object sender, KeyEventArgs e)
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
                txtBcode.Focus();
            }
        }

        private void cbotype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtName.Focus();
              
            }
        }

        private void btnB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                cboStatus.Focus();
            }

        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.Control && e.KeyCode == Keys.B)
            {
                txtPurchaseCost.Focus();
            }

        }
    }
}