using NUnit.Framework;
using POS.DataLayer;
using POS.Reports;

namespace POS.Test
{
   
    [TestFixture]
    public  class TestReport
    {
        [Test]
        public void Preview()
        {
            var  report = new Report();
            var dataManager = new DataManager();
            var d =
                dataManager.GetData(
                   "SELECT dbo.SIPSINVM.ORD_REF AS [Head Order Reference], dbo.SIPSINVM.INV_REF AS [Invoice No], dbo.SIPSINVM.INV_DATE AS [Invoice Date]," + 
                      "dbo.SIPSINVM.CUS_CODE AS [Customer Code], dbo.SIPSINVM.DEL_CODE AS [Delivery Code], dbo.SIPSINVM.EMP_CODE AS [Employee Code]," +
                      "dbo.SIPSINVM.INV_COM AS [Invoice Comment], dbo.SIPSINVM.INV_TOTAL AS [Invoice Total], dbo.SIPSINVM.INV_TOTID AS [Invoice Total Invoice Item Descount], " +
                      "dbo.SIPSINVM.INV_TOTAD AS [Invoice After Discount], dbo.SIPSINVM.INV_DISP AS [Invoice Dsicount Percent], dbo.SIPSINVM.INV_DISA AS [Invoice Discount], " +
                      "dbo.SIPSINVM.INV_TOTAI AS [Invoice Total After Discount], dbo.SIPSINVM.INV_VAT AS [Invoice VAT], dbo.SIPSINVM.INV_GRAND AS [Invoice Grand], " +
                      "dbo.SIPSINVM.INV_STAT AS [Invoice Type], dbo.SIPSINVM.USER_CODE AS [User Code], dbo.SIPSINVD.ORD_LINE AS [Order Line], " +
                      "dbo.SIPSINVD.LOC_CODE AS [Location Code], dbo.SIPSINVD.ITEM_CODE AS [Item Code], dbo.SIPSINVD.ITEM_DESC AS [Item Description], " +
                      "dbo.SIPSINVD.INV_UNIT AS Unit, dbo.SIPSINVD.INV_QTY AS Quantity, dbo.SIPSINVD.INV_STOCK AS [Stock Quantity], dbo.SIPSINVD.INV_PRICE AS Price, " +
                      "dbo.SIPSINVD.INV_SUB AS [Sub Total], dbo.SIPSINVD.INV_DISP AS [Item Discount], dbo.SIPSINVD.INV_DISA AS [Item Discount Amount], " +
                      "dbo.SIPSINVD.INV_TOT AS [Item Total], dbo.SIPSINVD.INV_COM AS Comment, dbo.SIPITEMS.ITEM_BCODE AS [Item Barcode], " +
                      "dbo.SIPLOCA.LOC_NAME AS [Location Name], dbo.SIPADDR.ADD_NAME AS [Customer Name], dbo.SIPADDR.ADD_LINE_1 AS [Customer Address 1], " +
                      "dbo.SIPADDR.ADD_LINE_2 AS [Customer Address 2], dbo.SIPADDR.ADD_LINE_3 AS [Customer Address 3], dbo.SIPADDR.ADD_LINE_4 AS [Customer Address 4], "+
                      "dbo.SIPADDR.ADD_LINE_5 AS [Customer Address 5], dbo.SIPADDR.ADD_TEL AS [Customer Tel], dbo.SIPADDR.ADD_FAX AS [Customer Fax], " +
                      "dbo.SIPADDR.ADD_EMAIL AS [Customer Email], dbo.SIPADDR.ADD_WEB AS [Customer Website], dbo.SIPADDR.ADD_CONT AS [Customer Contact]," + 
                      "dbo.SIPADDR.ADD_COM_1 AS [Customer Comment 1], dbo.SIPADDR.ADD_COM_2 AS [Customer Comment 2], dbo.SIPDADD.DEL_NAME AS [Delivery Name]," + 
                      "dbo.SIPDADD.DEL_ADD_1 AS [Delivery Address 1], dbo.SIPDADD.DEL_ADD_2 AS [Delivery Address 2], dbo.SIPDADD.DEL_ADD_3 AS [Delivery Address 3], "+
                      "dbo.SIPDADD.DEL_ADD_4 AS [Delivery Address 4], dbo.SIPDADD.DEL_ADD_5 AS [Delivery Address 5], dbo.SIPDADD.DEL_TEL AS [Delivery Tel], " +
                      "dbo.SIPDADD.DEL_FAX AS [Delivery Fax], dbo.SIPDADD.DEL_EMAIL AS [Delivery Email], dbo.SIPDADD.DEL_WEB AS [Delivery Website], "+
                      "dbo.SIPDADD.DEL_CONT AS [Delivery Contact], dbo.SIPDADD.DEL_COM_1 AS [Delivery Comment 1], dbo.SIPDADD.DEL_COM_2 AS [Delivery Comment 2], "+
                      "dbo.SIUNITCONV.CONV_F_DESC AS [Unit Name English], dbo.SIUNITCONV.CONV_F_DESCKH AS [Unit Name Khmer]"+
                      " FROM dbo.SIPSINVM INNER JOIN "+
                      " dbo.SIPSINVD ON dbo.SIPSINVM.ORD_REF = dbo.SIPSINVD.ORD_REF INNER JOIN " +
                      "dbo.SIPITEMS ON dbo.SIPSINVD.ITEM_CODE COLLATE SQL_Latin1_General_CP1_CS_AS = dbo.SIPITEMS.ITEM_CODE INNER JOIN "+
                      "dbo.SIPLOCA ON dbo.SIPSINVD.LOC_CODE COLLATE SQL_Latin1_General_CP1_CS_AS = dbo.SIPLOCA.LOC_CODE INNER JOIN " +
                      "dbo.SIPADDR ON dbo.SIPSINVM.CUS_CODE COLLATE SQL_Latin1_General_CP1_CS_AS = dbo.SIPADDR.ADD_CODE INNER JOIN " +
                      "dbo.SIPDADD ON dbo.SIPADDR.ADD_CODE = dbo.SIPDADD.ADD_CODE INNER JOIN " +
                      "dbo.SIUNITCONV ON dbo.SIPSINVD.INV_UNIT = dbo.SIUNITCONV.CONV_FROM " +
"WHERE     (dbo.SIPSINVD.INV_CRE = 'D')");
            report.Preview("Print Sale Form", d);
        }
    }
}
