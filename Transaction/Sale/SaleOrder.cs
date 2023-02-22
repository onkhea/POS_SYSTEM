using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POS.DataLayer;
using POS.GUI.SaleProcessing;
using POS.Utilities;

namespace POS.Transaction.Sale
{
    class SaleOrder
    {
        readonly Connection.Connection connection = new Connection.Connection();
        DataManager dataManager = new DataManager();
        public Decimal GetItem(string type, string location_Code, string Item_code)
        {
            Decimal QTY = 0;
            try
            {
                var saleprocessing_FRM = new SALEPROCESSING_FRM();

                var command = new SqlCommand("", connection.Connect());
                if (type == "O")
                {
                    command.CommandText = "SELECT dbo.ON_HOLD(@LOCATION,@ITEM_CODE)";
                    Commands.CreateParameter(command, "LOCATION", location_Code, "ITEM_CODE", Item_code);
                }
                else
                {
                    command.CommandText = "SELECT dbo.PHYSICAL(@LOCATION,@ITEM_CODE)";
                    Commands.CreateParameter(command, "LOCATION", location_Code, "ITEM_CODE", Item_code);
                }

                var dataAdapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.Rows[0][0] != Convert.DBNull)
                {
                    QTY = Convert.ToDecimal(dt.Rows[0][0]);
                }
                if (type == "O")
                {
                    if (saleprocessing_FRM.IS_EDIT == false)
                    {
                        QTY = QTY + SIDataGridView.Sum(saleprocessing_FRM.dataGridViewX1, 5, location_Code, 1, Item_code, 3);
                    }
                    else
                    {
                        Decimal SEL_QTY = 0;
                        if ((string)saleprocessing_FRM.dataGridViewX1.SelectedRows[0].Cells[1].Value == location_Code &&
                            (string)saleprocessing_FRM.dataGridViewX1.SelectedRows[0].Cells[3].Value == Item_code)
                        {
                            SEL_QTY = Convert.ToDecimal(saleprocessing_FRM.dataGridViewX1.SelectedRows[0].Cells[6].Value);
                        }
                        QTY += SIDataGridView.Sum(saleprocessing_FRM.dataGridViewX1, 6, location_Code, 1, Item_code, 3) -
                               SEL_QTY;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " with Item_Inventory");
            }
            return QTY;
        }

        public List<string> HoldDateTime()
        {
            var period = new List<string>();
            var dt =
                dataManager.GetData(
                    "SELECT DISTINCT CONVERT(char(6),INV_DATE,112) PERIOD " +
                    " FROM SIPSINVM WHERE INV_REF = '' AND INV_STAT = 'D' AND INV_PAY = 'N'	AND INV_POS = 'D' AND INV_CREDIT ='D'");
            foreach (DataRow row in dt.Rows)
            {
                period.Add(row[0].ToString());
            }
            return period;
        }

        public List<string> ReleaseDateTime()
        {
            var period = new List<string>();
            var dt =
                dataManager.GetData(
                    "SELECT DISTINCT CONVERT(char(6),INV_DATE,112) PERIOD  FROM dbo.SIPSINVM INNER JOIN  dbo.SIPADDR ON dbo.SIPSINVM.CUS_CODE COLLATE SQL_Latin1_General_CP1_CS_AS = dbo.SIPADDR.ADD_CODE " +
                    "  WHERE INV_REF = '' AND INV_STAT = 'A' AND INV_PAY = 'N' AND INV_POS = 'D' AND INV_CREDIT ='D'");
            foreach (DataRow row in dt.Rows)
            {
                period.Add(row[0].ToString());
            }
            return period;
        }

        public List<string> POSReleaseDateTime()
        {
            var period = new List<string>();
            var dt =
                dataManager.GetData(
                    "SELECT DISTINCT CONVERT(char(6),INV_DATE,112) PERIOD  FROM dbo.SIPSINVM INNER JOIN  dbo.SIPADDR ON dbo.SIPSINVM.CUS_CODE COLLATE SQL_Latin1_General_CP1_CS_AS = dbo.SIPADDR.ADD_CODE " +
                    " WHERE INV_REF = '' AND INV_STAT = 'A' AND INV_PAY = 'N' AND INV_POS = 'A' AND INV_CREDIT ='D'");
            foreach (DataRow row in dt.Rows)
            {
                period.Add(row[0].ToString());
            }
            return period;
        }

        public List<string> InvoiceDateTime()
        {
            var period = new List<string>();
            var dt =
                dataManager.GetData(
                    "SELECT DISTINCT CONVERT(char(6),INV_DATE,112) PERIOD  FROM dbo.SIPSINVM INNER JOIN  dbo.SIPADDR ON dbo.SIPSINVM.CUS_CODE COLLATE SQL_Latin1_General_CP1_CS_AS = dbo.SIPADDR.ADD_CODE " +
                    " WHERE INV_REF != '' AND INV_STAT = 'A' AND INV_PAY = 'N' AND INV_CREDIT ='D'");
            foreach (DataRow row in dt.Rows)
            {
                period.Add(row[0].ToString());
            }
            return period;
        }

        public List<string> CreditNoteDateTime()
        {
            var period = new List<string>();
            var dt =
                dataManager.GetData(
                    "SELECT DISTINCT CONVERT(char(6),INV_DATE,112) PERIOD " +
                    " FROM SIPSINVM WHERE INV_REF != '' AND INV_STAT = 'A' AND INV_PAY = 'N'	AND INV_CREDIT ='A'");
            foreach (DataRow row in dt.Rows)
            {
                period.Add(row[0].ToString());
            }
            return period;
        }
    }
}
