using System.Data;
using System.Data.SqlClient;
using NUnit.Framework;
using POS.DataLayer;

namespace POS.Test
{
    [TestFixture]
    public class TestCheckStockOnSale
    {
        [Test] 
        public void Check_Stock_On_Sale()
        {
            var dataManager = new DataManager();
            var connection = new Connection.Connection();

            var str = "SELECT  D.LOCATION, D.ITEM_CODE, D.ITEM_BCODE, D.ITEM_DESC, D.ITEM_PRICE1,D.ITEM_PRICE2, " +
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
            command.Parameters.AddWithValue("@LOCATION", "LC001");
            command.Parameters.AddWithValue("@ITEM_BCODE", "TM");
            var dt = new DataTable();
            var dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dt);

            Assert.Greater(dt.Rows.Count,0);
        }
    }
}
