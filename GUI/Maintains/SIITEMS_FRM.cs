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
using POS.Transaction.Maintains;
using POS.Transaction.Security;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class SIITEMS_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public SIITEMS_FRM()
        {
            InitializeComponent();
        }

        #region glbal variable

        readonly OutLook outLook = new OutLook();
        readonly SIItems siItems = new SIItems();
        readonly Controls controls = new Controls();
        readonly DataManager dataManager = new DataManager();
        readonly Connection.Connection  connection = new Connection.Connection();
        readonly DateTimes dateTimes = new DateTimes();
        private string STRTMP = "";
        readonly SISecurity security = new SISecurity();
        readonly SIMenuItems menuItems = new SIMenuItems();
        readonly SISubMenuItems subMenuItems = new SISubMenuItems();
// ReSharper disable FieldCanBeMadeReadOnly
        SIItems items = new SIItems();
// ReSharper restore FieldCanBeMadeReadOnly
        List<string> Clone = new List<string>();

        #endregion

        private void SIITEMS_FRM_Load(object sender, EventArgs e)
        {

            SplitContainer2.SplitterDistance = 200;
            SplitContainer2.Panel1Collapsed = true;
            SplitContainer1.Panel2Collapsed = true;
            tvSup.Dock = DockStyle.Fill;
            tvCat.Dock = DockStyle.Fill;

            var command =
                new SqlCommand(
                    "SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS ORDER BY ITEM_CODE",
                    connection.Connect());
            var dt = dataManager.GetData(command);
            int j;
            foreach (DataRow row in dt.Rows)
            {
                j = DataGridView1.Rows.Add(row[0]);
                for (int i = 1; i < dt.Columns.Count -1; i++)
                {
                    if (dt.Columns[i].ColumnName == "ITEM_STAT")
                    {
                        DataGridView1.Rows[j].Cells[i].Value = (string)row[i] == "D" ? "Disable" : "Active";
                        outLook.ChangeColorOnDisabledAndActive(DataGridView1, row[i].ToString(), j);
                    }
                    else if (dt.Columns[i].ColumnName == "ITEM_COST1" || dt.Columns[i].ColumnName == "ITEM_PRICE1" || dt.Columns[i].ColumnName == "ITEM_PRICE1" || dt.Columns[i].ColumnName == "ITEM_COST2" || dt.Columns[i].ColumnName == "ITEM_PRICE2")
                    {
                        DataGridView1.Rows[j].Cells[i].Value = row[i];
                    }
                    else if(dt.Columns[i].ColumnName == "ITEM_TYPE")
                    {
                        DataGridView1.Rows[j].Cells[i].Value = (string)row[i] == "S" ? "Stock Item":"Non-Stock";
                    }
                    else
                    {
                        DataGridView1.Rows[j].Cells[i].Value = row[i];
                    }
                }
            }
//                        siItems.LoadData()
            items.loadSearch(DataGridView1, dt, "ITEM_CODE", ListView1, ContextMenuStrip2, ToolStrip2,
                               SplitContainer1, SearchPanel);

            var sqlcommand = new SqlCommand("SELECT SI_DATA FROM SIPDATA WHERE SI_CODE='SYSTEM LABEL' AND SI_TYPE='<IC>'",connection.Connect());
            var tbl = dataManager.GetData(sqlcommand);
            if (tbl.Rows.Count > 0)
            {
                string X;
                int SID = 300;
                X = tbl.Rows[0][0].ToString();
                for (int i = 1; i <= 4; i++)
                {
                    if (X.Substring(SID,20).Trim() != "")
                    {
                        DataGridView1.Columns[4 + i].HeaderText = X.Substring(SID, 20).Trim();
                    }
                    SID = SID + 20;
                }
                for (int k = 0; k <= 4; k++)
                {
                    if (X.Substring(SID,20).Trim() != "")
                    {
                        DataGridView1.Columns[17 + k].HeaderText = X.Substring(SID, 20).Trim();
                    }
                    SID = SID + 20;
                }
            }
            Cursor = Cursors.Default;
        }

        #region Toolstrip1

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Items, "V", subMenuItems.NewLine, true) ==
           false)
                return;
           var additem_FRM = new ADDITEM_FRM();
            additem_FRM.Text = "New Item Record";
            additem_FRM.cboStatus.SelectedIndex = 0;
            additem_FRM.cbotype.SelectedIndex = 0;
//            for (int i = 0; i < 9; i++)
//            {
//                additem_FRM.tabCus.Name 
//            }
//             For I As Int16 = 0 To 9
//                .tabCus.Controls("lblcus" & I + 1).Text = DataGridView1.Columns(12 + I).HeaderText
//            Next1
            lbl:
            if (additem_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (dataManager.Exists("SIPITEMS", additem_FRM.txtCode.Text, "ITEM_CODE"))
                {
                    MessageBox.Show("Item Code already exists!", "Already", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    goto lbl;
                }
                if (dataManager.Exists("SIPITEMS", additem_FRM.txtBcode.Text, "ITEM_BCODE"))
                {
                    MessageBox.Show("Bar-Code already exists!", "Already", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    goto lbl;
                }
                var command = new SqlCommand("SI_INSERT_SIPITEMS_NON");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection.Connect();             
                try
                {
                    int j;
                    byte[] IMG = controls.ReturnImage(additem_FRM.PictureBox1);
                    PictureBox1.Image = additem_FRM.PictureBox1.Image;
                    if (additem_FRM.PictureBox1.Image == null)
                    {
                        IMG = System.Text.Encoding.UTF8.GetBytes("");
                    }
                    command.CommandText = "SI_INSERT_SIPUSERS";
                    command.Parameters.AddWithValue("@ITEM_CODE_1", additem_FRM.txtCode.Text);
                    command.Parameters.AddWithValue("@ITEM_BCODE_2", additem_FRM.txtBcode.Text);
                    command.Parameters.AddWithValue("@ITEM_DESC_3", additem_FRM.txtName.Text);
                    command.Parameters.AddWithValue("@ITEM_TYPE_4", additem_FRM.cbotype.Text.Substring(0, 1));
                    command.Parameters.AddWithValue("@UNIT_STOCK_5", additem_FRM.txtUnitStock.Text);
                    command.Parameters.AddWithValue("@ITEM_COST1_6", additem_FRM.txtCostUStock.Text);
                    command.Parameters.AddWithValue("@ITEM_PRICE1_7", additem_FRM.txtPriceUStock.Text);
                    command.Parameters.AddWithValue("@UNIT_SALE_8", additem_FRM.txtUnitSale.Text);
                    command.Parameters.AddWithValue("@ITEM_COST2_9", additem_FRM.txtCostUSale.Text);
                    command.Parameters.AddWithValue("@ITEM_PRICE2_10", additem_FRM.txtPriceUSale.Text);
                    command.Parameters.AddWithValue("@CAT_CODE_11", additem_FRM.txtCate.Text);
                    command.Parameters.AddWithValue("@ITEM_STAT_12", additem_FRM.cboStatus.Text.Substring(0, 1));
                    command.Parameters.AddWithValue("@ITEM_CUS1_13", additem_FRM.txtcus1.Text);
                    command.Parameters.AddWithValue("@ITEM_CUS2_14", additem_FRM.txtcus2.Text);
                    command.Parameters.AddWithValue("@ITEM_CUS3_15", additem_FRM.txtcus3.Text);
                    command.Parameters.AddWithValue("@ITEM_CUS4_16", additem_FRM.txtcus4.Text);
                    command.Parameters.AddWithValue("@ITEM_CUS5_17", additem_FRM.txtCus5.Text);
                    command.Parameters.AddWithValue("@ITEM_CUS6_18", additem_FRM.txtCus6.Text);
                    command.Parameters.AddWithValue("@ITEM_CUS7_19", additem_FRM.txtCus7.Text);
                    command.Parameters.AddWithValue("@ITEM_CUS8_20", additem_FRM.txtCus8.Text);
                    command.Parameters.AddWithValue("@ITEM_CUS9_KH_21", additem_FRM.txtcuskh1.Text);
                    command.Parameters.AddWithValue("@ITEM_CUS10_KH_22", additem_FRM.txtcuskh2.Text);
                    command.Parameters.AddWithValue("@USER_CREA_23", UserLogOn.Code);
                    command.Parameters.AddWithValue("@DATE_CREA_24", dateTimes.Now());
                    command.Parameters.AddWithValue("@USER_UPDT_25", "");
                    command.Parameters.AddWithValue("@DATE_UPDT_26", dateTimes.Now());
                    command.Parameters.AddWithValue("@ITEM_IMG_27", IMG);
                    command.ExecuteNonQuery();
//                    =============================== Item supplier =================
                    command = new SqlCommand("INSERT INTO SIPITEMSP VALUES(@ITEM_CODE,@SUPP_CODE,@SUPP_UNIT,@SUPP_COST)")
                                  {Connection = connection.Connect()};

                    foreach (ListViewItem item in additem_FRM.ListView1.Items)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("ITEM_CODE", additem_FRM.txtCode.Text);
                        command.Parameters.AddWithValue("SUPP_CODE", item.Text);
                        command.Parameters.AddWithValue("SUPP_UNIT", item.SubItems[2].Text);
                        command.Parameters.AddWithValue("SUPP_COST", item.SubItems[3].Text);
                        command.ExecuteNonQuery();
                    }
                    var str = new string[]
                                  {
                                      additem_FRM.txtCode.Text, additem_FRM.txtBcode.Text, additem_FRM.txtName.Text,
                                      additem_FRM.cbotype.Text.Substring(4, additem_FRM.cbotype.Text.Length - 4),
                                      additem_FRM.txtUnitStock.Text, additem_FRM.txtCostUStock.Text,
                                      additem_FRM.txtPriceUStock.Text, additem_FRM.txtUnitSale.Text,
                                      additem_FRM.txtCostUSale.Text, additem_FRM.txtPriceUSale.Text,
                                      additem_FRM.txtCate.Text,
                                      additem_FRM.cboStatus.Text.Substring(4, additem_FRM.cboStatus.Text.Length - 4),
                                      additem_FRM.txtcus1.Text, additem_FRM.txtcus2.Text, additem_FRM.txtcus3.Text,
                                      additem_FRM.txtcus4.Text, additem_FRM.txtCus5.Text, additem_FRM.txtCus6.Text,
                                      additem_FRM.txtCus7.Text, additem_FRM.txtCus8.Text, additem_FRM.txtcuskh1.Text,
                                      additem_FRM.txtcuskh2.Text, UserLogOn.Code, dateTimes.Now(), "", dateTimes.Now()
                                  };
                    controls.AddToDataGridView(DataGridView1,str);
                    var k = DataGridView1.Rows.Count - 1;
                    outLook.ChangeColorOnDisabledAndActive(DataGridView1,additem_FRM.cboStatus.Text,k);
                    DataGridView1.Rows[k].Selected = true;
                    Cursor = Cursors.Default;
                    additem_FRM.Close();
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Items, "V", subMenuItems.EditLine, true) ==
         false)
                return;
            if (DataGridView1.SelectedRows.Count > 0)
            {
                var additem_FRM = new ADDITEM_FRM();
//                  For I As Int16 = 0 To 9
//                    .tabCus.Controls("lblcus" & I + 1).Text = DataGridView1.Columns(12 + I).HeaderText
//                Next
                additem_FRM.Text = "Edit Item Record";
                additem_FRM.txtCode.Text = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                additem_FRM.txtCode.Enabled = false;
                additem_FRM.txtBcode.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                additem_FRM.txtName.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                additem_FRM.cbotype.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString().Substring(0, 1) +
                                           " - " + DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                additem_FRM.txtUnitStock.Text = DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                additem_FRM.txtCostUStock.Text = DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                additem_FRM.txtPriceUStock.Text = DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                additem_FRM.txtUnitSale.Text = DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                additem_FRM.txtCostUSale.Text = DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                additem_FRM.txtPriceUSale.Text = DataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                additem_FRM.txtCate.Text = DataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                additem_FRM.cboStatus.Text = DataGridView1.SelectedRows[0].Cells[11].Value.ToString().Substring(0, 1) +
                                             " - " + DataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                additem_FRM.txtcus1.Text = DataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                additem_FRM.txtcus2.Text = DataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                additem_FRM.txtcus3.Text = DataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                additem_FRM.txtcus4.Text = DataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                additem_FRM.txtCus5.Text = DataGridView1.SelectedRows[0].Cells[16].Value.ToString();
                additem_FRM.txtCus6.Text = DataGridView1.SelectedRows[0].Cells[17].Value.ToString();
                additem_FRM.txtCus7.Text = DataGridView1.SelectedRows[0].Cells[18].Value.ToString();
                additem_FRM.txtCus8.Text = DataGridView1.SelectedRows[0].Cells[19].Value.ToString();
                additem_FRM.txtcuskh1.Text = DataGridView1.SelectedRows[0].Cells[20].Value.ToString();
                additem_FRM.txtcuskh2.Text = DataGridView1.SelectedRows[0].Cells[21].Value.ToString();
                items.ShowImage("SELECT ITEM_IMG FROM SIPITEMS", additem_FRM.PictureBox1, "ITEM_CODE",
                                DataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                var command =
                    new SqlCommand(
                        "SELECT SUPP_CODE,ADD_NAME, SUPP_UNIT, SUPP_COST FROM SIPITEMSP I INNER JOIN SIPADDR A ON I.SUPP_CODE=A.ADD_CODE Where ITEM_CODE ='" +
                        DataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' AND ADD_TYPE ='1'",
                        connection.Connect());
                var tblitmsp = dataManager.GetData(command);
                foreach (DataRow r in tblitmsp.Rows)
                {
                    controls.Add_ListView(ListView1,4,r[0].ToString(),r[1].ToString(),r[2].ToString(),r[3].ToString());    
                }

            lbl:
                if (additem_FRM.ShowDialog() == DialogResult.OK)
                {
                    var cmd =
                        new SqlCommand("SELECT ITEM_BCODE FROM SIPITEMS WHERE ITEM_BCODE='" + additem_FRM.txtBcode.Text +
                                       "' AND ITEM_BCODE <>'" + DataGridView1.SelectedRows[0].Cells[1].Value + "'",connection.Connect());
                    var dt = dataManager.GetData(cmd);
                    if (dt.Rows.Count >0)
                    {
                        MessageBox.Show("Bar-Code already exists!", "Existing", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        goto lbl;
                    }
                    var sqlCmd =
                        new SqlCommand(
                            "UPDATE dbo.SIPITEMS SET ITEM_BCODE = @ITEM_BCODE_2,ITEM_DESC = @ITEM_DESC_3,ITEM_TYPE = @ITEM_TYPE_4 , UNIT_STOCK = @UNIT_STOCK_5, ITEM_COST1 = @ITEM_COST1_6,ITEM_PRICE1 = @ITEM_PRICE1_7,UNIT_SALE = @UNIT_SALE_8, ITEM_COST2 = @ITEM_COST2_9,ITEM_PRICE2 = @ITEM_PRICE2_10,CAT_CODE = @CAT_CODE_11 , ITEM_STAT = @ITEM_STAT_12,ITEM_CUS1 = @ITEM_CUS1_13 ,	ITEM_CUS2 =@ITEM_CUS2_14,ITEM_CUS3 = @ITEM_CUS3_15, ITEM_CUS4 = @ITEM_CUS4_16, ITEM_CUS5 =@ITEM_CUS5_17 ,ITEM_CUS6 = @ITEM_CUS6_18,ITEM_CUS7 = @ITEM_CUS7_19, ITEM_CUS8 = @ITEM_CUS8_20, ITEM_CUS9_KH = @ITEM_CUS9_KH_21 ,ITEM_CUS10_KH = @ITEM_CUS10_KH_22,USER_UPDT = @USER_UPDT_23,DATE_UPDT = @DATE_UPDT_24 ,ITEM_IMG = @ITEM_IMG_25 WHERE ITEM_CODE = @ITEM_CODE_1 	",
                            connection.Connect());
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Connection = connection.Connect();
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        byte[] IMG = controls.ReturnImage(additem_FRM.PictureBox1);
                        PictureBox1.Image = additem_FRM.PictureBox1.Image;
                        if (additem_FRM.PictureBox1.Image == null)
                        {
                            IMG = System.Text.Encoding.UTF8.GetBytes("");
                            PictureBox1.Image = null;
                        }
                        var dd = additem_FRM.cbotype.Text.Substring(0, 1);
                        var ddd = additem_FRM.cboStatus.Text.Substring(0, 1);
                            

                        sqlCmd.Parameters.AddWithValue("@ITEM_CODE_1", additem_FRM.txtCode.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_BCODE_2", additem_FRM.txtBcode.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_DESC_3", additem_FRM.txtName.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_TYPE_4", additem_FRM.cbotype.Text.Substring(0, 1));
                        sqlCmd.Parameters.AddWithValue("@UNIT_STOCK_5", additem_FRM.txtUnitStock.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_COST1_6", additem_FRM.txtCostUStock.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_PRICE1_7", additem_FRM.txtPriceUStock.Text);
                        sqlCmd.Parameters.AddWithValue("@UNIT_SALE_8", additem_FRM.txtUnitSale.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_COST2_9", additem_FRM.txtCostUSale.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_PRICE2_10", additem_FRM.txtPriceUSale.Text);
                        sqlCmd.Parameters.AddWithValue("@CAT_CODE_11", additem_FRM.txtCate.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_STAT_12", additem_FRM.cboStatus.Text.Substring(0, 1));
                        sqlCmd.Parameters.AddWithValue("@ITEM_CUS1_13", additem_FRM.txtcus1.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_CUS2_14", additem_FRM.txtcus2.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_CUS3_15", additem_FRM.txtcus3.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_CUS4_16", additem_FRM.txtcus4.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_CUS5_17", additem_FRM.txtCus5.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_CUS6_18", additem_FRM.txtCus6.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_CUS7_19", additem_FRM.txtCus7.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_CUS8_20", additem_FRM.txtCus8.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_CUS9_KH_21", additem_FRM.txtcuskh1.Text);
                        sqlCmd.Parameters.AddWithValue("@ITEM_CUS10_KH_22", additem_FRM.txtcuskh2.Text);
                        sqlCmd.Parameters.AddWithValue("@USER_UPDT_23", UserLogOn.Code);
                        sqlCmd.Parameters.AddWithValue("@DATE_UPDT_24", dateTimes.Now());
                        sqlCmd.Parameters.AddWithValue("@ITEM_IMG_25", IMG);
                        sqlCmd.ExecuteNonQuery();
//                        =========================  Delete and Insert new record of items supplier
                        sqlCmd.CommandText = "DELETE FROM SIPITEMSP WHERE ITEM_CODE='" + additem_FRM.txtCode.Text + "'";
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.ExecuteNonQuery();

//                        =============================  Insert item suppplier
                        sqlCmd.CommandText =
                            "INSERT INTO SIPITEMSP VALUES(@ITEM_CODE,@SUPP_CODE,@SUPP_UNIT,@SUPP_COST)";
                        sqlCmd.CommandType = CommandType.Text;
                        foreach (ListViewItem item in additem_FRM.ListView1.Items)
                        {
                            sqlCmd.Parameters.Clear();
                            sqlCmd.Parameters.AddWithValue("ITEM_CODE", additem_FRM.txtCode.Text);
                            sqlCmd.Parameters.AddWithValue("SUPP_CODE", item.Text);
                            sqlCmd.Parameters.AddWithValue("SUPP_UNIT", item.SubItems[2].Text);
                            sqlCmd.Parameters.AddWithValue("SUPP_COST", item.SubItems[3].Text);
                            sqlCmd.ExecuteNonQuery();
                        }
//                        ============================
                        var values = new string[]
                                         {
                                             additem_FRM.txtCode.Text, additem_FRM.txtBcode.Text, additem_FRM.txtName.Text,
                                             additem_FRM.cbotype.Text.Substring(4, additem_FRM.cbotype.Text.Length - 4),
                                             additem_FRM.txtUnitStock.Text, additem_FRM.txtCostUStock.Text,
                                             additem_FRM.txtPriceUStock.Text, additem_FRM.txtUnitSale.Text,
                                             additem_FRM.txtCostUSale.Text, additem_FRM.txtPriceUSale.Text,
                                             additem_FRM.txtCate.Text,
                                             additem_FRM.cboStatus.Text.Substring(4, additem_FRM.cboStatus.Text.Length - 4)
                                             , additem_FRM.txtcus1.Text, additem_FRM.txtcus2.Text, additem_FRM.txtcus3.Text
                                             , additem_FRM.txtcus4.Text, additem_FRM.txtCus5.Text, additem_FRM.txtCus6.Text
                                             , additem_FRM.txtCus7.Text, additem_FRM.txtCus8.Text,
                                             additem_FRM.txtcuskh1.Text, additem_FRM.txtcuskh2.Text, UserLogOn.Code,
                                             dateTimes.Now(), "", dateTimes.Now()
                                         };
                        controls.UpdateDataToGridView(DataGridView1, values);
                        outLook.Change_Color_On_Disabled_And_Active_On_Selected(DataGridView1,additem_FRM.cboStatus.Text);
                        MessageBox.Show("Item record have been edited.", "Edit", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message);
                    }
                    additem_FRM.Close();

                }
            }
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (security.CheckPermission(UserLogOn.Code, menuItems.Items, "V", subMenuItems.DeleteLine, true) ==
        false)
                    return;
                if (DataGridView1.SelectedRows.Count > 0)
                {
                    if (dataManager.Exists("SIPINMOV", DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), "ITEM_CODE"))
                    {
                        MessageBox.Show("Cannot delete this record. Transactions present!", "Can't Delete",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //                    ======== delete item supplier
                        var parAndVal = new string[] { "ITEM_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString() };
                        siItems.Delete(parAndVal);
                        siItems.DeleteItemsSupplier(parAndVal);
                        DataGridView1.Rows.Remove(DataGridView1.SelectedRows[0]);
                        MessageBox.Show("Item record was deleted successfully!", "Successfull Deleted", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloneToolStripMenuItem1_Click(sender,e);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clone.Count > 0)
            {
//                 ================ Note : Change and fix it later
//                For I As Int16 = 0 To 9
//                    .tabCus.Controls("lblcus" & I + 1).Text = DataGridView1.Columns(12 + I).HeaderText
//                Next
//            +++++++++++++++++++++++++++++++++++++++++++++++====
                if (security.CheckPermission(UserLogOn.Code, menuItems.Items, "V", subMenuItems.PasteLine, true) ==
        false)
                    return;
                var additem_FRM = new ADDITEM_FRM();
                additem_FRM.Text = "Paste Item Record";
                outLook.PasteData(Clone,additem_FRM.txtCode,additem_FRM.txtBcode,additem_FRM.txtName,additem_FRM.cbotype,
                    additem_FRM.txtUnitStock, additem_FRM.txtCostUStock, additem_FRM.txtPriceUStock,additem_FRM.txtUnitSale, additem_FRM.txtCostUSale,
                    additem_FRM.txtPriceUSale, additem_FRM.txtCate, additem_FRM.cboStatus, additem_FRM.txtcus1,
                    additem_FRM.txtcus2,additem_FRM.txtcus3,additem_FRM.txtcus4,additem_FRM.txtCus5,additem_FRM.txtCus6,
                    additem_FRM.txtCus7,additem_FRM.txtCus8,additem_FRM.txtcuskh1,additem_FRM.txtcuskh2);
                additem_FRM.cbotype.Text = Clone[3].Substring(0, 1) + " - " + Clone[3];
                additem_FRM.cboStatus.Text = Clone[11].Substring(0, 1) + " - " + Clone[11];

                items.ShowImage("SELECT ITEM_IMG FROM SIPITEMS", additem_FRM.PictureBox1, "ITEM_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                var dt =
                    dataManager.GetData(
                        "SELECT SUPP_CODE,ADD_NAME,SUPP_UNIT, SUPP_COST FROM SIPITEMSP I INNER JOIN SIPADDR A ON I.SUPP_CODE=A.ADD_CODE",
                        "SUPP_CODE", "ITEM_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), "ADD_TYPE", "1");
                foreach (DataRow r in dt.Rows)
                {
                    controls.Add_ListView(ListView1, 4, r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString());
                }
            lbl:
                if (additem_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (dataManager.Exists("SIPITEMS",additem_FRM.txtCode.Text,"ITEM_CODE"))
                    {
                        MessageBox.Show("Item Code already exists!", "Already", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        goto lbl;
                    }
                    if (dataManager.Exists("SIPITEMS",additem_FRM.txtBcode.Text,"ITEM_BCODE"))
                    {
                        additem_FRM.txtBcode.SelectAll();
                        additem_FRM.txtBcode.Focus();
                        MessageBox.Show("Bar-Code already exists!", "Already", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        goto lbl;
                    }
                    var command = new SqlCommand("SI_INSERT_SIPITEMS",connection.Connect());
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        int j;
                        byte[] IMG = controls.ReturnImage(additem_FRM.PictureBox1);

                        #region unused
                        //                        if (additem_FRM.PictureBox1.Image == null)
//                        {
//                            command.CommandText = "SI_INSERT_SIPITEMS";
//                            Commands.CreateParameter(command,"ITEM_CODE_1", additem_FRM.txtCode.Text, "ITEM_BCODE_2",
//                                                    additem_FRM.txtBcode.Text, "ITEM_DESC_3", additem_FRM.txtName.Text,
//                                                    "ITEM_TYPE_4", additem_FRM.cbotype.Text.Substring(0, 1),
//                                                    "UNIT_STOCK_5", additem_FRM.txtUnitStock.Text, "ITEM_COST1_6",
//                                                    additem_FRM.txtCostUStock.Text, "ITEM_PRICE1_7",
//                                                    additem_FRM.txtPriceUStock.Text, "UNIT_SALE_8",
//                                                    additem_FRM.txtUnitSale.Text, "ITEM_COST2_9",
//                                                    additem_FRM.txtCostUSale.Text, "ITEM_PRICE2_10",
//                                                    additem_FRM.txtPriceUSale.Text, "CAT_CODE_11",
//                                                    additem_FRM.txtCate.Text, "ITEM_STAT_12",
//                                                    additem_FRM.cboStatus.Text.Substring(0, 1), "ITEM_CUS1_13",
//                                                    additem_FRM.txtcus1.Text, "ITEM_CUS2_14", additem_FRM.txtcus2.Text,
//                                                    "ITEM_CUS3_15", additem_FRM.txtcus3.Text, "ITEM_CUS4_16",
//                                                    additem_FRM.txtcus4.Text, "ITEM_CUS5_17", additem_FRM.txtCus5.Text,
//                                                    "ITEM_CUS6_18", additem_FRM.txtCus6.Text, "ITEM_CUS7_19",
//                                                    additem_FRM.txtCus7.Text, "ITEM_CUS8_20", additem_FRM.txtCus8.Text,
//                                                    "ITEM_CUS9_KH_21", additem_FRM.txtcuskh1.Text, "ITEM_CUS10_KH_22",
//                                                    additem_FRM.txtcuskh2.Text, "USER_CREA_23", UserLogOn.Code,
//                                                    "DATE_CREA_24", dateTimes.Now(), "USER_UPDT_25", "", "DATE_UPDT_26",
//                                                    dateTimes.Now());
//                            
//                            
//                        }
//                        else
                        //                        {
                        #endregion

                        command.CommandText = "SI_INSERT_SIPUSERS";
                        command.Parameters.AddWithValue("@ITEM_CODE_1", additem_FRM.txtCode.Text);
                        command.Parameters.AddWithValue("@ITEM_BCODE_2", additem_FRM.txtBcode.Text);
                        command.Parameters.AddWithValue("@ITEM_DESC_3", additem_FRM.txtName.Text);
                        command.Parameters.AddWithValue("@ITEM_TYPE_4", additem_FRM.cbotype.Text.Substring(0, 1));
                        command.Parameters.AddWithValue("@UNIT_STOCK_5", additem_FRM.txtUnitStock.Text);
                        command.Parameters.AddWithValue("@ITEM_COST1_6", additem_FRM.txtCostUStock.Text);
                        command.Parameters.AddWithValue("@ITEM_PRICE1_7", additem_FRM.txtPriceUStock.Text);
                        command.Parameters.AddWithValue("@UNIT_SALE_8", additem_FRM.txtUnitSale.Text);
                        command.Parameters.AddWithValue("@ITEM_COST2_9", additem_FRM.txtCostUSale.Text);
                        command.Parameters.AddWithValue("@ITEM_PRICE2_10", additem_FRM.txtPriceUSale.Text);
                        command.Parameters.AddWithValue("@CAT_CODE_11", additem_FRM.txtCate.Text);
                        command.Parameters.AddWithValue("@ITEM_STAT_12", additem_FRM.cboStatus.Text.Substring(0, 1));
                        command.Parameters.AddWithValue("@ITEM_CUS1_13", additem_FRM.txtcus1.Text);
                        command.Parameters.AddWithValue("@ITEM_CUS2_14", additem_FRM.txtcus2.Text);
                        command.Parameters.AddWithValue("@ITEM_CUS3_15", additem_FRM.txtcus3.Text);
                        command.Parameters.AddWithValue("@ITEM_CUS4_16", additem_FRM.txtcus4.Text);
                        command.Parameters.AddWithValue("@ITEM_CUS5_17", additem_FRM.txtCus5.Text);
                        command.Parameters.AddWithValue("@ITEM_CUS6_18", additem_FRM.txtCus6.Text);
                        command.Parameters.AddWithValue("@ITEM_CUS7_19", additem_FRM.txtCus7.Text);
                        command.Parameters.AddWithValue("@ITEM_CUS8_20", additem_FRM.txtCus8.Text);
                        command.Parameters.AddWithValue("@ITEM_CUS9_KH_21", additem_FRM.txtcuskh1.Text);
                        command.Parameters.AddWithValue("@ITEM_CUS10_KH_22", additem_FRM.txtcuskh2.Text);
                        command.Parameters.AddWithValue("@USER_CREA_23", UserLogOn.Code);
                        command.Parameters.AddWithValue("@DATE_CREA_24", dateTimes.Now());
                        command.Parameters.AddWithValue("@USER_UPDT_25", "");
                        command.Parameters.AddWithValue("@DATE_UPDT_26", dateTimes.Now());
                        command.Parameters.AddWithValue("@ITEM_IMG_27", IMG);
                        #region unused
                        //                            Commands.CreateParameter(command, "ITEM_CODE_1", additem_FRM.txtCode.Text, "ITEM_BCODE_2",
//                                                    additem_FRM.txtBcode.Text, "ITEM_DESC_3", additem_FRM.txtName.Text,
//                                                    "ITEM_TYPE_4", additem_FRM.cbotype.Text.Substring(0, 1),
//                                                    "UNIT_STOCK_5", additem_FRM.txtUnitStock.Text, "ITEM_COST1_6",
//                                                    additem_FRM.txtCostUStock.Text, "ITEM_PRICE1_7",
//                                                    additem_FRM.txtPriceUStock.Text, "UNIT_SALE_8",
//                                                    additem_FRM.txtUnitSale.Text, "ITEM_COST2_9",
//                                                    additem_FRM.txtCostUSale.Text, "ITEM_PRICE2_10",
//                                                    additem_FRM.txtPriceUSale.Text, "CAT_CODE_11",
//                                                    additem_FRM.txtCate.Text, "ITEM_STAT_12",
//                                                    additem_FRM.cboStatus.Text.Substring(0, 1), "ITEM_CUS1_13",
//                                                    additem_FRM.txtcus1.Text, "ITEM_CUS2_14", additem_FRM.txtcus2.Text,
//                                                    "ITEM_CUS3_15", additem_FRM.txtcus3.Text, "ITEM_CUS4_16",
//                                                    additem_FRM.txtcus4.Text, "ITEM_CUS5_17", additem_FRM.txtCus5.Text,
//                                                    "ITEM_CUS6_18", additem_FRM.txtCus6.Text, "ITEM_CUS7_19",
//                                                    additem_FRM.txtCus7.Text, "ITEM_CUS8_20", additem_FRM.txtCus8.Text,
//                                                    "ITEM_CUS9_KH_21", additem_FRM.txtcuskh1.Text, "ITEM_CUS10_KH_22",
//                                                    additem_FRM.txtcuskh2.Text, "USER_CREA_23", UserLogOn.Code,
//                                                    "DATE_CREA_24", dateTimes.Now(), "USER_UPDT_25", "", "DATE_UPDT_26",
//                                                    dateTimes.Now(), "ITEM_IMG_27", IMG);
                        //                        }
                        #endregion 
                        command.ExecuteNonQuery();

                        var str = new string[]
                                  {
                                      additem_FRM.txtCode.Text, additem_FRM.txtBcode.Text, additem_FRM.txtName.Text,
                                      additem_FRM.cbotype.Text.Substring(4, additem_FRM.cbotype.Text.Length - 4),
                                      additem_FRM.txtUnitStock.Text, additem_FRM.txtCostUStock.Text,
                                      additem_FRM.txtPriceUStock.Text, additem_FRM.txtUnitSale.Text,
                                      additem_FRM.txtCostUSale.Text, additem_FRM.txtPriceUSale.Text,
                                      additem_FRM.txtCate.Text,
                                      additem_FRM.cboStatus.Text.Substring(4, additem_FRM.cboStatus.Text.Length - 4),
                                      additem_FRM.txtcus1.Text, additem_FRM.txtcus2.Text, additem_FRM.txtcus3.Text,
                                      additem_FRM.txtcus4.Text, additem_FRM.txtCus5.Text, additem_FRM.txtCus6.Text,
                                      additem_FRM.txtCus7.Text, additem_FRM.txtCus8.Text, additem_FRM.txtcuskh1.Text,
                                      additem_FRM.txtcuskh2.Text, UserLogOn.Code, dateTimes.Now(), "", dateTimes.Now()
                                  };
                        controls.AddToDataGridView(DataGridView1, str);
                        var k = DataGridView1.Rows.Count - 1;
                        outLook.ChangeColorOnDisabledAndActive(DataGridView1, additem_FRM.cboStatus.Text, k);
                        DataGridView1.Rows[k].Selected = true;

//                        ====================== Items Suppliers
                        command.CommandText =
                            "INSERT INTO SIPITEMSP VALUES(@ITEM_CODE,@SUPP_CODE,@SUPP_UNIT,@SUPP_COST)";
                        command.CommandType = CommandType.Text;
                        foreach (ListViewItem item in additem_FRM.ListView1.Items)
                        {
                            command.Parameters.Clear();
                            Commands.CreateParameter(command, "ITEM_CODE", additem_FRM.txtCode.Text, "SUPP_CODE",
                                                     item.Text, "SUPP_UNIT", item.SubItems[2].Text, "SUPP_COST",
                                                     item.SubItems[3].Text);
                            command.ExecuteNonQuery();
                        }
                        var i = DataGridView1.Rows.Count - 1 ;
                        outLook.ChangeColorOnDisabledAndActive(DataGridView1,additem_FRM.cboStatus.Text,i);
                        DataGridView1.Rows[i].Selected = true;
                        Cursor = Cursors.Default;

                    }
                    catch (Exception ex)
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message);
                    }
                    additem_FRM.Close();
                }
            }
            else
            {
                MessageBox.Show("Please clone before paste data.", "Can't Paste", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void DisplayImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (DisplayImageToolStripMenuItem.Checked == false)
            {
                DisplayImageToolStripMenuItem.Checked = true;
                DisplayImageToolStripMenuItem1.Checked = true;
                PictureBox1.Visible = true;
                if (DataGridView1.SelectedRows.Count > 0)
                {
                    siItems.ShowImage("SELECT ITEM_IMG FROM SIPITEMS", PictureBox1, "ITEM_CODE", DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                SplitContainer1.Panel2Collapsed = false;
            }
            else
            {
                DisplayImageToolStripMenuItem.Checked = false;
                DisplayImageToolStripMenuItem1.Checked = false;
                PictureBox1.Visible = false;
                if (ExcelTool.Checked == false && SearchTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = true;
                }
                Cursor = Cursors.Default;
            }
            Cursor = Cursors.Default;

        }

        private void ShowCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (ShowCategoryToolStripMenuItem.Checked == false)
            {
                ShowCategoryToolStripMenuItem.Checked = true;
                ShowCategoryToolStripMenuItem1.Checked = true;
                ShowSupplierToolStripMenuItem.Checked = false;
                ShowSupplierToolStripMenuItem1.Checked = false;
                SplitContainer2.Panel1Collapsed = false;
                tvCat.Visible = true;
                Panel1.Visible = true;
                tvSup.Visible = false;
            }
            else
            {
                ShowCategoryToolStripMenuItem.Checked = false;
                ShowCategoryToolStripMenuItem1.Checked = false;
                tvCat.Nodes[0].Collapse(true);
                Show_Data("");
                SplitContainer2.Panel1Collapsed = true;
            }
            Cursor = Cursors.Default;
        }

        private void ShowSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (ShowSupplierToolStripMenuItem.Checked == false)
            {
                ShowSupplierToolStripMenuItem.Checked = true;
                ShowSupplierToolStripMenuItem1.Checked = true;
                ShowCategoryToolStripMenuItem.Checked = false;
                ShowCategoryToolStripMenuItem1.Checked = false;
                SplitContainer2.Panel1Collapsed = false;
                tvCat.Visible = false;
                Panel1.Visible = false;
                tvSup.Visible = true;

            }
            else
            {
                ShowSupplierToolStripMenuItem.Checked = false;
                ShowSupplierToolStripMenuItem1.Checked = false;
                tvSup.Nodes[0].Collapse(true);
                Show_Data("");
                SplitContainer2.Panel1Collapsed = true;
            }
            Cursor = Cursors.Default;
        }

        private void ExcelTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Items, "V", subMenuItems.ExportDatatoExcel, true) ==
        false)
                return;
            if (ExcelTool.Checked == false)
            {
                ExcelTool.Checked = true;
                ExcelToolStripMenuItem.Checked = true;
                ExcelPanel.Visible = true;
                if (SearchTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = false;
                }
            }
            else
            {
                ExcelTool.Checked = false;
                ExcelToolStripMenuItem.Checked = false;
                ExcelPanel.Visible = false;
                if (SearchTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = true;
                }
            }
            Cursor = Cursors.Default;
        }

        private void SearchTool_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Items, "V", subMenuItems.SearchData, true) ==
        false)
                return;
            if (SearchTool.Checked == false)
            {
                SearchTool.Checked = true;
                SearchToolStripMenuItem.Checked = true;
                ToolStrip3.Visible = true;
                SearchPanel.Visible = true;
                Label5.Visible = true;
                if (ExcelTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = false;
                }
            }
            else
            {
                var items = new SIItems();
                outLook.showDGV(DataGridView1, items.LoadData(), "ITEM_STAT");
                DefaultAllToolStripMenuItem.Checked = true;
                ActiveToolStripMenuItem.Checked = false;
                DisableToolStripMenuItem.Checked = false;
                SearchTool.Checked = false;
                SearchToolStripMenuItem.Checked = false;
                SearchPanel.Visible = false;
                Label5.Visible = false;

                if (ExcelTool.Checked == false)
                {
                    SplitContainer1.Panel2Collapsed = true;
                }
                Cursor = Cursors.Default;
            }
            Cursor = Cursors.Default;
        }


        #endregion
  
        private void chbS_CheckedChanged(object sender, EventArgs e)
        {
            controls.CheckOnListView(ListView1, chbS);
        }

        private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            outLook.addcreteria(ContextMenuStrip2, ToolStrip2, SearchPanel, RemoveToolStripMenuItem, e, STRTMP);
        }

        private void ToolStrip2_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                var j = 0;
                var i = 0;
                var k = SearchPanel.Width / 200;
                if (k == 0) { j = 1; }
                else if (k < 3) { j = k; }
                else { j = 3; }
                for (i = 0; i <= ToolStrip2.Items.Count - 1; i++)
                {
                    if (ToolStrip2.Items[i].Name.Substring(0, 4) == "ttxt")
                    {
                        ToolStrip2.Items[i].Width = ((SearchPanel.Width - 125) * j) / j;
                        if (ToolStrip2.Height + ToolStrip3.Height + Label4.Height <= 380)
                        {
                            SearchPanel.Height = ToolStrip2.Height + ToolStrip3.Height + Label4.Height;
                        }
                        else
                        {
                            SearchPanel.Height = 380;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SelectNextControl(DataGridView1, true, true, true, true);
        }

        private void ToolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveToolStripMenuItem.Visible = false;
            removesep.Visible = false;
            foreach (ToolStripItem item in ContextMenuStrip2.Items)
            {
                item.Enabled = true;
            }       
        }

        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemoveToolStripMenuItem.Visible = true;
            removesep.Visible = true;
            STRTMP = e.ClickedItem.Name;
        }

        private void CloseToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Export To Excel

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            outLook.ExportToExcel(ListView1, bgwExcel);
        }

        private void bgwExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            outLook.BackGround_DdWork(DataGridView1, ListView1);
        }

        private void bgwExcel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            outLook.BackGroud_ProgressChanged(e);
        }

        private void bgwExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            outLook.BackGround_RunWorkedCompleted();
        }

        #endregion

        #region ContextMenu 1

        #region Actions

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewToolStripButton_Click(sender,e);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditToolStripButton1_Click(sender, e);
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteToolStripButton2_Click(sender,e);
        }

        #endregion

        #region Views

        private void DefaultAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
              DefaultAllToolStripMenuItem.Checked = true;
              ActiveToolStripMenuItem.Checked = false;
              DisableToolStripMenuItem.Checked = false;
              Show_Data("");
        }

        private void ActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultAllToolStripMenuItem.Checked = false;
            ActiveToolStripMenuItem.Checked = true;
            DisableToolStripMenuItem.Checked = false;
            Show_Data("A");
        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultAllToolStripMenuItem.Checked = false;
            ActiveToolStripMenuItem.Checked = false;
            DisableToolStripMenuItem.Checked = true;
            Show_Data("D");
        }

        #endregion

        #region Tools

        private void CloneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (security.CheckPermission(UserLogOn.Code, menuItems.Items, "V", subMenuItems.CloneLine, true) ==
        false)
                return;
            Clone.Clear();
            if(DataGridView1.SelectedRows.Count > 0)
            {
                outLook.CloneData(Clone, DataGridView1);
                PasteToolStripMenuItem1.Checked = true;
                PasteToolStripMenuItem.Checked = true;
                PasteToolStripMenuItem1.Enabled = true;
                PasteToolStripMenuItem.Enabled = true;
            }
            
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(sender,e);
        }

        private void DisplayImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayImageToolStripMenuItem_Click(sender,e);
        }

        private void ShowCategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
        if (ShowCategoryToolStripMenuItem.Checked == false)
            {
                ShowCategoryToolStripMenuItem.Checked = true;
                ShowCategoryToolStripMenuItem1.Checked = true;
                ShowSupplierToolStripMenuItem.Checked = false;
                ShowSupplierToolStripMenuItem1.Checked = false;
                SplitContainer2.Panel1Collapsed = false;
                tvCat.Visible = true;
                Panel1.Visible = true;
                tvSup.Visible = false;
            }
        else
        {
            ShowCategoryToolStripMenuItem.Checked = false;
            ShowCategoryToolStripMenuItem1.Checked = false;
            tvCat.Nodes[0].Collapse(true);
            Show_Data("");
            SplitContainer2.Panel1Collapsed = true;
        }
            Cursor = Cursors.Default;
        }

        private void ShowSupplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowSupplierToolStripMenuItem_Click(sender,e);
        }

        #endregion
        
        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelTool_Click(sender,e);
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTool_Click(sender,e);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            var command =
                 new SqlCommand(
                     "SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS ORDER BY ITEM_CODE",
                     connection.Connect());
            var dt = dataManager.GetData(command);
            int j;
            foreach (DataRow row in dt.Rows)
            {
                j = DataGridView1.Rows.Add(row[0]);
                for (int i = 1; i < dt.Columns.Count - 1; i++)
                {
                    if (dt.Columns[i].ColumnName == "ITEM_STAT")
                    {
                        if ((string) row[i] == "D")
                        {
                             DataGridView1.Rows[j].Cells[i].Value = "Disable";
                             DataGridView1.Rows[j].DefaultCellStyle.ForeColor = Color.DarkGray;
                             DataGridView1.Rows[j].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                        }
                        else
                        {DataGridView1.Rows[j].Cells[i].Value = "Active";
                             DataGridView1.Rows[j].DefaultCellStyle.ForeColor = Color.Black;
                             DataGridView1.Rows[j].DefaultCellStyle.SelectionForeColor = Color.Black;
                        }
                    }
                    else if (dt.Columns[i].ColumnName == "ITEM_COST1" || dt.Columns[i].ColumnName == "ITEM_PRICE1" || dt.Columns[i].ColumnName == "ITEM_PRICE1" || dt.Columns[i].ColumnName == "ITEM_COST2" || dt.Columns[i].ColumnName == "ITEM_PRICE2")
                    {
                        DataGridView1.Rows[j].Cells[i].Value = row[i];
                    }
                    else if (dt.Columns[i].ColumnName == "ITEM_TYPE")
                    {
                        DataGridView1.Rows[j].Cells[i].Value = (string)row[i] == "S" ? "Stock Item" : "Non-Stock";
                    }
                    else
                    {
                        DataGridView1.Rows[j].Cells[i].Value = row[i];
                    }
                }
            }
            
        }

        #endregion
        
        private void Show_Data(string status)
        {
            var dt = new DataTable();
            if (!string.IsNullOrEmpty(status))
            {
                if (ShowSupplierToolStripMenuItem.Checked == true)
                {
                    if (tvCat.SelectedNode == null || tvCat.Nodes[0].IsSelected == true)
                    {
                        dt =
                            dataManager.GetData(
                                "SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS",
                                "ITEM_CODE", "ITEM_STAT", status);
                    }
                    else
                    {
                        dt =
                            dataManager.GetData(
                                "SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS",
                                "ITEM_CODE", "ITEM_STAT", status, "CAT_CODE", tvCat.SelectedNode.Tag.ToString());
                    }
                }
                else if (ShowSupplierToolStripMenuItem.Checked == true)
                {
                    if (tvSup.SelectedNode == null || tvSup.Nodes[0].IsSelected == true)
                    {
                        dt =
                            dataManager.GetData(
                                "SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS",
                                "ITEM_CODE", "ITEM_STAT", status);
                    }
                    else
                    {
                        dt =
                            dataManager.GetData(
                                "SELECT I.ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS I INNER JOIN SIPITEMSP S ON I.ITEM_CODE=S.ITEM_CODE",
                                "I.ITEM_CODE", "ITEM_STAT", status, "SUPP_CODE", tvSup.SelectedNode.Tag.ToString());
                    }
                }
                else
                {
                    dt =
                        dataManager.GetData(
                            "SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS",
                            "ITEM_CODE", "ITEM_STAT", status);
                }
            }
            else
            {
                if (ShowCategoryToolStripMenuItem.Checked == true)
                {
                    if (tvCat.SelectedNode == null || tvCat.Nodes[0].IsSelected == true)
                    {
                        var  command = new SqlCommand("SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS ORDER BY ITEM_CODE",connection.Connect());
                        dt = dataManager.GetData(command);
                    }
                    else
                    {
                        dt =
                            dataManager.GetData(
                                "SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS",
                                "ITEM_CODE", "CAT_CODE", tvCat.SelectedNode.Tag.ToString());
                    }
                }
                else if(ShowSupplierToolStripMenuItem.Checked == true)
                {
                    if (tvSup.SelectedNode == null || tvSup.Nodes[0].IsSelected == true)
                    {
                        var command = new SqlCommand("SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS ORDER BY ITEM_CODE",connection.Connect());
                        dt = dataManager.GetData(command);
                    }
                    else
                    {
                        dt =
                            dataManager.GetData(
                                "SELECT I.ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS I INNER JOIN SIPITEMSP S ON I.ITEM_CODE=S.ITEM_CODE",
                                "I.ITEM_CODE", "SUPP_CODE", tvSup.SelectedNode.Tag.ToString());
                    }
                }
                else
                {
                    var command = new SqlCommand("SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS ORDER BY ITEM_CODE",connection.Connect());
                    dt = dataManager.GetData(command);
                }
            }
            DataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int j = DataGridView1.Rows.Add(row[0]);
                for (int i = 1; i < dt.Columns.Count -1; i++)
                {
                    switch (dt.Columns[i].ColumnName)
                    {
                        case "ITEM_STAT":
                            DataGridView1.Rows[j].Cells[i].Value = (string) row[i] == "D" ? "Disable" : "Active";
                            if ((string) row[i] == "D")
                            {
                                DataGridView1.Rows[j].DefaultCellStyle.ForeColor = Color.DarkGray;
                                DataGridView1.Rows[j].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                            }
                            break;
                        case "ITEM_TYPE":
                            DataGridView1.Rows[j].Cells[i].Value = (string) row[i] == "S" ? "Stock Item" : "Non-Stock";
                            break;
                        default:
                            DataGridView1.Rows[j].Cells[i].Value = row[i];
                            break;
                    }
                }
            }
            if (DataGridView1.Rows.Count == 0)
            {
                PictureBox1.Image = null;
            }
            Cursor = Cursors.Default;
        }

        private void ListView1_Resize(object sender, EventArgs e)
        {
            if (ListView1.Width > 25)
            {
                ListView1.Columns[0].Width = ListView1.Width - 25;
            }
        }
        
        #region label

        private void lnkCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var progressbar_FRM = new PROGRESSBAR_FRM();
            var sicat_FRM = new SICAT_FRM(progressbar_FRM);
            sicat_FRM.Dock = DockStyle.Fill;
            if (sicat_FRM.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                sicat_FRM.Close();
            }
        }

        private void lnkHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowCategoryToolStripMenuItem_Click(sender,e);
        }

        #endregion
        
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            var ss = new string[] { };
            var cod = new OutLook();
            cod.searching(connection.Connect(), DataGridView1,
                          "SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS ",
                          "ITEM_CODE", ToolStrip2, ToolStrip3, "ITEM_STAT", ss);

        }

        #region Treeview

        private void tvSup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (ActiveToolStripMenuItem.Checked == true)
                {
                    Show_Data("A");
                }
                else if (DisableToolStripMenuItem.Checked == true)
                {
                    Show_Data("D");
                }
                else
                {
                    Show_Data("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Default;

        }

        private void tvCat_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tvSup_AfterSelect(sender, e);
        }

        private void tvSup_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (tvCat.Visible == true)
                {
                    var dt = dataManager.GetData("SELECT SI_CODE,SI_DATA FROM SIPDATA", "SI_CODE", "SI_TYPE", "CATE",
                                                 "SI_LOOKUP", "A");
                    tvCat.Nodes[0].Nodes.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        var N = tvCat.Nodes[0].Nodes.Add(row[0].ToString().PadRight(18) + row[1].ToString().Trim());
                        N.Tag = row[0];
                    }
                }
                else
                {
                    var dt = dataManager.GetData("SELECT ADD_CODE,ADD_NAME FROM SIPADDR", "ADD_CODE", "ADD_TYPE", "1",
                                                 "ADD_STAT", "A");
                    tvSup.Nodes[0].Nodes.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        TreeNode N = tvSup.Nodes[0].Nodes.Add(row[0].ToString(),
                                                              row[0].ToString().PadRight(18) + row[1].ToString().Trim(),
                                                              1, 1);
                        N.Tag = row[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Default;

        }

        private void tvCat_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (tvCat.Visible == true)
                {
                    var command = new SqlCommand("SELECT SI_CODE,SI_DATA FROM SIPDATA WHERE SI_TYPE= 'CATE' AND SI_LOOKUP = 'A' ORDER BY SI_CODE Asc", connection.Connect());
                    var dt = dataManager.GetData(command);
                    tvCat.Nodes[0].Nodes.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        TreeNode Node =
                            tvCat.Nodes[0].Nodes.Add(row[0].ToString().PadRight(18) + row[1].ToString().Trim());
                        Node.Tag = row[0];
                    }
                }
                else
                {
                    var command = new SqlCommand("SELECT ADD_CODE,ADD_NAME FROM SIPADDR WHERE ADD_TYPE ='1' AND ADD_STAT = 'A' Order by ADD_CODE ASC ", connection.Connect());
                    var dt = dataManager.GetData(command);
                    tvSup.Nodes.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        TreeNode node =
                            tvSup.Nodes[0].Nodes.Add(row[0].ToString(), row[0].ToString().PadRight(18) + row[1].ToString().Trim(),
                                                     1, 1);
                        node.Tag = row[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Default;
        }

        #endregion

        #region datagridview 1

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (DataGridView1.SelectedRows.Count > 0)
            {
                if (DisplayImageToolStripMenuItem.Checked == true)
                {
                    siItems.ShowImage("SELECT ITEM_IMG FROM SIPITEMS", PictureBox1, "ITEM_CODE",
                                      DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    PictureBox1.Image = null;
                }

                
            }
            Cursor = Cursors.Default;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            EditToolStripButton1_Click(sender, e);
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteToolStripButton2_Click(sender,e);
            }
            else if(e.KeyCode == Keys.Apps)
            {
             ContextMenuStrip1.Show(MousePosition.X,MousePosition.Y);   
            }
            else if(e.KeyCode == Keys.F5)
            {
                RefreshToolStripMenuItem_Click(null,null);
            }
        }

        #endregion

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
