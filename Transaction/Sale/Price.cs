using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using POS.DataLayer;
using POS.Utilities;

namespace POS.Transaction.Sale
{
    public class Price
    {
        readonly Connection.Connection  connection = new Connection.Connection();
        readonly DataManager DataManager = new DataManager();
//        Utilities.Strings strings = new Strings();
        public decimal GetValue(string barCode)
        {
            decimal price = 0;
            var dt = new DataTable();
            var command =
                new SqlCommand(
                    "SELECT ITEM_CODE,ITEM_BCODE,ITEM_DESC,ITEM_CUS9_KH,UNIT_STOCK,UNIT_SALE,ITEM_TYPE,ITEM_PRICE1 FROM SIPITEMS WHERE ITEM_BCODE=@ITEM_BCODE",
                    connection.Connect());
            command.Parameters.AddWithValue("@ITEM_BCODE", barCode);
            var dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                price = Convert.ToDecimal(string.Format("{0:00.00}", dt.Rows[0][7]));
                Decimal pro_Rate = 0;
//                Decimal ATM = 0;
//                var dd = dt.Rows[0][5].ToString();
                // get price set up
                var dtP = DataManager.GetData("SELECT PRO_RATE FROM SIPOSPRICE", "ITEM_BCODE",
                                              "ITEM_BCODE",
                                              barCode, "UNIT_SALE", dt.Rows[0][5].ToString(), "PRO_TYPE",
                                              "P",
                                              "LOCATION", SITempData.Loc_Code_POS);

                if (dtP.Rows.Count > 0)
                {
                    price = Convert.ToDecimal(string.Format("{0:00.00}", dtP.Rows[0][0]));
                }
                else
                {
                    dtP = new DataTable();
                    dtP = DataManager.GetData("SELECT PRO_RATE FROM SIPOSPRICE", "ITEM_BCODE",
                                              "ITEM_BCODE",
                                              barCode, "UNIT_SALE", dt.Rows[0][5].ToString(), "PRO_TYPE",
                                              "P");
                    if (dtP.Rows.Count > 0)
                    {
                        price = Convert.ToDecimal(string.Format("{0:00.00}", dtP.Rows[0][0]));
                    }
                } // ==== end with else if (dtp.rows.count > 0)

                // ===== select discount for sale
                var dtDiscount =
                    DataManager.GetData(
                        "SELECT PRO_RATE,PRO_FDATE,PRO_TDATE,PRO_TIMES,PRO_TIMEE FROM SIPOSPRICE",
                        "ITEM_BCODE",
                        "ITEM_BCODE", barCode, "LOCATION", SITempData.Loc_Code_POS, "UNIT_SALE",
                        dt.Rows[0][5].ToString(), "PRO_TYPE", "D", "STATUS", "A");
                if (dtDiscount.Rows.Count > 0)
                {
                    pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                    var strings = new Strings();
                    if (strings.IsDateTime(dtDiscount.Rows[0][1].ToString()) &&
                        strings.IsDateTime(dtDiscount.Rows[0][2].ToString()))
                    {
                        //                                        ========== Note : Not yet complete computer sound
                        if (
                            Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day,
                                                                       Convert.ToDateTime(
                                                                           dtDiscount.Rows[0][1].ToString()),
                                                                       DateTime.Now,
                                                                       Microsoft.VisualBasic.FirstDayOfWeek.System,
                                                                       Microsoft.VisualBasic.FirstWeekOfYear.System) >=
                            0)
                        {
                            pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                                Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                            {
                                if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                                    DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                                {
                                    pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                                }
                                    // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                                else
                                {
                                    pro_Rate = 0;
                                } // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....


                        } // end if (DateDiff(DateInterval.Day.....)
                        else
                        {
                            pro_Rate = 0;
                        } // end else if (DateDiff(DateInterval.Day.....)
                    }
                        // end if (strings.IsDateTime(dtDiscount.Rows[0][1].tostring())&& string.IsDateTime(dtDiscount.Rows[0][2].toString())
                    else
                    {
                        if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                            Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                        {
                            if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                                DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                            {
                                pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            } // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            else
                            {
                                pro_Rate = 0;
                            } // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                        } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                    }
                        // else if (strings.IsDateTime(dtDiscount.Rows[0][1].tostring())&& string.IsDateTime(dtDiscount.Rows[0][2].toString())
                }
                else
                {
                    var dv = dt.Rows[0][5].ToString();
                    dtDiscount =
                        DataManager.GetData(
                            "SELECT PRO_RATE,PRO_FDATE,PRO_TDATE,PRO_TIMES,PRO_TIMEE FROM SIPOSPRICE",
                            "ITEM_BCODE", "ITEM_BCODE", barCode, "UNIT_SALE", dt.Rows[0][5].ToString(), "PRO_TYPE",
                            "D", "STATUS", "A");
                    if (dtDiscount.Rows.Count > 0)
                    {
                        pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                        var strings = new Strings();
                        if (strings.IsDateTime(dtDiscount.Rows[0][1].ToString()) &&
                            strings.IsDateTime(dtDiscount.Rows[0][2].ToString()))
                        {
                            //                                        ========== Note : Not yet complete computer sound
                            if (
                                Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day,
                                                                           Convert.ToDateTime(
                                                                               dtDiscount.Rows[0][1].ToString()),
                                                                           DateTime.Now,
                                                                           Microsoft.VisualBasic.FirstDayOfWeek.System,
                                                                           Microsoft.VisualBasic.FirstWeekOfYear.System) >=
                                0)
                            {
                                pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                                if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                                    Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                                {
                                    if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                                        DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                                    {
                                        pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                                    }
                                        // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                                    else
                                    {
                                        pro_Rate = 0;
                                    }
                                    // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                                }
                                // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                            } // end if (DateDiff(DateInterval.Day.....)
                            else
                            {
                                pro_Rate = 0;
                            } // end else if (DateDiff(DateInterval.Day.....)
                        }
                            // end if (strings.IsDateTime(dtDiscount.Rows[0][1].tostring())&& string.IsDateTime(dtDiscount.Rows[0][2].toString())
                        else
                        {
                            if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                                Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                            {
                                if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                                    DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                                {
                                    pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                                } // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                                else
                                {
                                    pro_Rate = 0;
                                } // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                        } //
                    } // end else if (dtDiscount.Rows.Count > 0 ) and No LOCATION 
                } // end else if (dtDiscount.Rows.Count > 0 ) and on this table have "Location Field" 

            }
            return price;

        }
    }
}
