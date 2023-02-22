using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Transaction;
using POS.Utilities;

namespace POS.GUI.POS
{
    public partial class CHECKSTOCK_FRM : Form
    {
        public CHECKSTOCK_FRM()
        {
            InitializeComponent();
        }

        readonly Connection.Connection connection = new Connection.Connection();
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (Condition.EmptyControl(txtBarcode))
                    return;
                else
                {
                    try
                    {
                        var dt = new DataTable();
                        var str =
                            "SELECT  D.LOCATION, D.ITEM_CODE, D.ITEM_BCODE, D.ITEM_DESC, D.ITEM_PRICE1,D.ITEM_PRICE2, " +
                            "D.UNIT_STOCK,D.UNIT_SALE, ISNULL(D.PHYSICAL,0) - ISNULL(D.HOLD_SALE,0) - ISNULL(INMOVH.PICK_QTY,0) STOCKQTY FROM  " +
                            "(SELECT MOV.LOCATION,MOV.ITEM_CODE,MOV.ITEM_BCODE,MOV.ITEM_DESC,MOV.UNIT_STOCK,MOV.UNIT_SALE, " +
                            "MOV.ITEM_PRICE1,MOV.ITEM_PRICE2, MOV.PHYSICAL, TAB2.HOLD_SALE FROM " +
                            "(SELECT ITEM.ITEM_CODE,ITEM.ITEM_BCODE,ITEM.ITEM_DESC,ITEM.UNIT_STOCK,ITEM.UNIT_SALE,ITEM.ITEM_PRICE1," +
                            "ITEM.ITEM_PRICE2,MOVSTOCK.PHYSICAL,MOVSTOCK.LOCATION FROM  " +
                            "(SELECT I.ITEM_CODE,I.ITEM_BCODE,I.ITEM_DESC,I.UNIT_STOCK,I.UNIT_SALE,I.ITEM_PRICE1,I.ITEM_PRICE2 FROM dbo.SIPITEMS I " +
                            " WHERE I.ITEM_BCODE = @ITEM_BCODE) AS ITEM " +
                            "LEFT JOIN " +
                            "(SELECT LOCATION, ITEM_CODE, ISNULL(SUM(QUANTITY),0) PHYSICAL FROM dbo.SIPINMOV " +
                            " WHERE LOCATION = @LOCATION AND IR_STAT = 'I' AND STATUS = '80' AND ALLOC_REF = '' GROUP BY LOCATION,ITEM_CODE) AS MOVSTOCK " +
                            "ON ITEM.ITEM_CODE = MOVSTOCK.ITEM_CODE  COLLATE DATABASE_DEFAULT ) AS MOV " +
                            "LEFT JOIN " +
                            "(SELECT LOC_CODE LC, ITEM_CODE IC, ISNULL(SUM(INV_STOCK),0) HOLD_SALE FROM dbo.SIPSINVD " +
                            "WHERE LOC_CODE = @LOCATION AND INV_STAT = 'S' " +
                            "GROUP BY LOC_CODE, ITEM_CODE) AS TAB2 " +
                            "ON MOV.ITEM_CODE COLLATE DATABASE_DEFAULT = TAB2.IC COLLATE DATABASE_DEFAULT AND MOV.LOCATION COLLATE DATABASE_DEFAULT = TAB2.LC COLLATE DATABASE_DEFAULT )AS D " +
                            "LEFT JOIN " +
                            "(SELECT LOCATION, ITEM_CODE, ISNULL(SUM(QUANTITY),0) PICK_QTY FROM dbo.SIPINMOH WHERE LOCATION = @LOCATION AND " +
                            "IR_STAT <>'I' AND STATUS = '10' GROUP BY LOCATION,ITEM_CODE ) AS INMOVH " +
                            "ON " +
                            "D.ITEM_CODE = INMOVH.ITEM_CODE AND D.LOCATION = INMOVH.LOCATION " +
                            "WHERE D.LOCATION = @LOCATION ORDER BY D.ITEM_CODE";
                        var command = new SqlCommand(str,connection.Connect());
                        command.Parameters.AddWithValue("@LOCATION", SITempData.Loc_Code_POS);
                        command.Parameters.AddWithValue("@ITEM_BCODE", txtBarcode.Text);
                        var dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            var Qty = Decimal.Parse(dt.Rows[0][8].ToString());
                            txtBarcode.Text = dt.Rows[0][2].ToString();
                            txtName.Text = dt.Rows[0][3].ToString();
                            txtUnitofStock.Text = dt.Rows[0][6].ToString();
                            txtUnitOfSale.Text = dt.Rows[0][7].ToString();
                            txtPriceOfStock.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(dt.Rows[0][4]));
                            txtPriceOfSale.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(dt.Rows[0][5]));
                            txtQty.Text = string.Format("{0:0,0}", Convert.ToDecimal(Qty));
                            txtBarcode.SelectAll();
                        }
                        else
                        {
                            txtBarcode.SelectAll();
                            txtBarcode.Text = "";
                            txtUnitofStock.Text = "";
                            txtUnitOfSale.Text = "";
                            txtPriceOfStock.Text = string.Format("{0:0,0.00}", 0);
                            txtPriceOfSale.Text = string.Format("{0:0,0.00}", 0);
                            txtQty.Text = "";
                            txtName.Text = "";
                            MessageBox.Show("There are no item have been found!","", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            return;

                        }

                    }
                    catch (Exception ex)
                    {
                       var pointofsale_FRM = new POINTOFSALE_FRM {lblmessage = {Text = ex.Message}};
                    }
                }
            }
        }
    }
}
