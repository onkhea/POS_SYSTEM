using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Connection;
using POS.DataLayer;
using POS.GUI.User;
using POS.Utilities;

namespace POS.Transaction.Maintains
{
    class SIItems : OutLook,IDataCRUD
    {
        private IConnection connection = new Connection.Connection();
        DataManager dataManager = new DataManager();
        DataTable dtItems = new DataTable();

        public SIItems()
        {
            var command =
                new SqlCommand(
                    "SELECT ITEM_CODE, ITEM_BCODE, ITEM_DESC, ITEM_TYPE, UNIT_STOCK, ITEM_COST1, ITEM_PRICE1, UNIT_SALE, ITEM_COST2, ITEM_PRICE2, CAT_CODE, ITEM_STAT, ITEM_CUS1, ITEM_CUS2, ITEM_CUS3, ITEM_CUS4, ITEM_CUS5, ITEM_CUS6, ITEM_CUS7, ITEM_CUS8, ITEM_CUS9_KH, ITEM_CUS10_KH, USER_CREA, DATE_CREA, USER_UPDT, DATE_UPDT FROM SIPITEMS ORDER BY ITEM_CODE",connection.Connect());
            dtItems = dataManager.GetData(command);
        }
        public DataTable LoadData()
        {
            return dtItems;
        }

        public void Save(string[] values)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string value)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string[] paramAndValue)
        {
            DataAccess.DeleteData("SIPITEMS",paramAndValue);
        }

        public void Update(string[] paramAndValue, string[] condition)
        {
            throw new System.NotImplementedException();
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Update(string[] value, string condition)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteItemsSupplier(string[] paramAndValue)
        {
            DataAccess.DeleteData("SIPITEMSP",paramAndValue);
        }

        public void ShowImage(string str, PictureBox pictureBox, params string[] values)
        {
            string W = "";
            for (int i = 0; i < values.Length - 1; i+=2)
            {
                W = " WHERE " + values[i] + "=@" + values[i];
            }
            str = str + W;
            var command = new SqlCommand(str,connection.Connect()) {CommandTimeout = 0};
            Commands.CreateParameter(command, values);
//            ====== Note : Refactoring , it maybe wrong in here.
          
            if (command.ExecuteScalar() == Convert.DBNull)
            {
                pictureBox.Image = null;
            }
            else
            {
                SqlDataReader dataReader = command.ExecuteReader();
                var byt = new byte[] {};
                while (dataReader.Read())
                {
                    byt = (byte[]) dataReader[0];
                }
                if (byt.Length > 0)
                {
                    var  stream = new MemoryStream(byt);
                    pictureBox.Image = Image.FromStream(stream);
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
        }

        public override void loadSearch(DataGridView dgv, DataTable tb, string fsearch, ListView lsv, ContextMenuStrip cms, ToolStrip tssearch, SplitContainer spc, Panel psearch)
        {
            int j = 0, i = 0;
            spc.Panel2MinSize = 180;
            int k = spc.Width;
            if (k > 200)
            {
                spc.SplitterDistance = k - 200;
            }
            if ((psearch.Width / 200) == 0) { j = 1; }
            else if ((psearch.Width / 200) < 3) { j = psearch.Width / 200; }
            else { j = 3; }
            tssearch.Visible = true;
            lsv.Items.Clear();
            tssearch.Items.Clear();
            for (i = 0; i <= dgv.ColumnCount - 1; i++)
            {
                ToolStripMenuItem t = new ToolStripMenuItem();
                t.Name = "ctx" + tb.Columns[i].ColumnName;
                t.Text = dgv.Columns[i].HeaderText;
                if (tb.Columns[i].ColumnName == fsearch)
                {
                    var d = new ToolStripDropDownButton();
                    d.AutoSize = false;
                    d.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                    d.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                    d.ImageTransparentColor = System.Drawing.Color.Magenta;
                    d.Name = "tlbl" + tb.Columns[i].ColumnName;
                    d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    d.DropDown = cms;
                    d.Text = dgv.Columns[i].HeaderText;
                    d.Height = 21;
                    d.Width = 120;
                    tssearch.Items.Add(d);
                    var TT = new System.Windows.Forms.ToolStripTextBox();
                    TT.AutoSize = false;
                    TT.Name = "ttxt" + tb.Columns[i].ColumnName;
                    TT.Height = 21;
                    TT.Width = (psearch.Width - 125 * j) / j;
                    tssearch.Items.Add(TT);
                    t.Visible = false;
                }
                cms.Items.Add(t);
                lsv.Items.Add(dgv.Columns[i].HeaderText);
                if (dgv.Columns[i].Visible == true)
                {
                    lsv.Items[lsv.Items.Count - 1].Checked = true;
                }

            }
        }

        public string ReturnField_Item_Type(string valueCondition)
        {
            var condition = new string[] {"ITEM_TYPE", valueCondition};
            return DataAccess.ReturnField("SELECT ITEM_TYPE FROM SIPITEMS", "ITEM_TYPE", condition, 1);
        }
    }
}
