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
using POS.Utilities;

namespace POS.GUI.POS
{
    public partial class SALECASE_FRM : Form
    {
        public SALECASE_FRM()
        {
            InitializeComponent();
        }

        readonly DataManager dataManager = new DataManager();
        private string operate = "";
        private Decimal factor = 0;
        public Decimal SQty = 0;
        public string item_Type = "";
        public string item_Kh = "";
        public Decimal item_Price1 = 0;
        public Decimal item_Price2 = 0;
        public string item_Code = "";
        public string unit_Sale = "";
        public Decimal pro_Rate = 0;

        Connection.Connection connection = new Connection.Connection();

        private void txtUnitOfSale_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtUnitOfSale.Text != "")
                {
                    var dt = dataManager.GetData("SELECT CONV_FROM,OPERATOR,FACTOR FROM SIUNITCONV", "CONV_FROM",
                                                 "CONV_FROM", txtUnitOfSale.Text, "CONV_TO", txtUnitofStock.Text);
                    if (dt.Rows.Count > 0)
                    {
                        txtUnitOfSale.Text = dt.Rows[0][0].ToString();
                        operate = dt.Rows[0][1].ToString();
                        factor = Convert.ToDecimal(dt.Rows[0][2].ToString());
                        var dtPrice = dataManager.GetData("SELECT PRO_RATE FROM SIPOSPRICE", "ITEM_BCODE", "ITEM_BCODE",
                                                          txtBarcode.Text, "UNIT_SALE", txtUnitOfSale.Text, "PRO_TYPE",
                                                          "P");
                        if (dtPrice.Rows.Count > 0)
                        {
                            txtPrice.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(dtPrice.Rows[0][0]));
                        }
                        else
                        {
                            if (txtUnitOfSale.Text == txtUnitofStock.Text)
                            {
                                txtPrice.Text = string.Format("{0:0,0.00}", item_Price1);
                            }
                            else if (txtUnitOfSale.Text == unit_Sale)
                            {
                                txtPrice.Text = string.Format("{0:0,0.00}", item_Price2);
                            }
                            else
                            {
                                MessageBox.Show("There are no selling price on this unit of sale!");
                                txtUnitOfSale.Focus();
                                txtUnitOfSale.SelectAll();
                            }
                        } // end else if (dtPrice.rows.count > 0)
                        // select discount for sale
                        var dtDiscount =
                            dataManager.GetData(
                                "SELECT PRO_RATE,PRO_FDATE,PRO_TDATE,PRO_TIMES,PRO_TIMEE FROM SIPOSPRICE", "ITEM_BCODE",
                                "ITEM_BCODE", txtBarcode.Text, "LOCATION", SITempData.Loc_Code_POS, "UNIT_SALE", txtUnitOfSale.Text,
                                "PRO_TYPE", "D", "STATUS", "A");
                        if (dtDiscount.Rows.Count > 0)
                        {
                            var strings = new Strings();

                            if (strings.IsDateTime(dtDiscount.Rows[0][1].ToString()) && strings.IsDateTime(dtDiscount.Rows[0][2].ToString()))
                            {
                                if (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, Convert.ToDateTime(dtDiscount.Rows[0][1].ToString()), DateTime.Now, Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) >= 0)
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
                                    } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....

                                }// end if ( DataDiff..........)
                                else
                                {
                                    pro_Rate = 0;
                                }
                            }
                            else
                            {
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
                                } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                            }
                        }
                        txtUnitOfSale.Enabled = false;
                        txtQty.Enabled = true;
                        SelectNextControl(txtUnitOfSale, true, true, true, true);
                    }
                    else
                    {
                        txtUnitOfSale.SelectionStart = 0;
                        txtUnitOfSale.SelectionLength = txtUnitOfSale.ToString().Length;
                    }
                }   // end if (e.keycode == keys.enter)
                else if (e.KeyCode == Keys.F6)
                {
                    panel1_Click(null,null);
                }
                else if (e.Control == true && e.KeyCode == Keys.B)
                {
                    txtUnitOfSale.Enabled = false;
                    txtBarcode.Enabled = true;
                    txtBarcode.SelectAll();
                    SelectNextControl(txtUnitOfSale, true, true, true, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                txtQty.Enabled = false;
                txtUnitOfSale.Enabled = true; txtUnitOfSale.SelectAll();
                SelectNextControl(txtQty, false, true, true, true);
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            var strings = new Strings();
            if (e.KeyChar == (char)13)
            {
                if (strings.IsNumeric(txtQty.Text) == false) return;
                if (operate != "")
                {
                    if (operate == "*")
                    {
                        SQty = Convert.ToDecimal(txtQty.Text) * factor;
                    }
                    else
                    {
                        SQty = Convert.ToDecimal(txtQty.Text) / factor;
                    }
                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            var strings = new Strings();
            if (txtQty.Text.Trim() != "")
            {
                if (strings.IsNumeric(txtQty.Text))
                {
                    var Qty = Convert.ToDecimal(txtQty.Text);
                    if (strings.IsDecimal(txtPrice.Text))
                    {
                        var price = Convert.ToDecimal(txtPrice.Text);
                        var Amount = Qty * price;
                        txtAmount.Text = string.Format("{0:0,0.00}", Amount);
                        txtDiscount.Text = string.Format("{0:0,0.00}", Amount * (pro_Rate / 100));
                    }
                }
                else
                {
                    txtQty.Text = txtQty.Text.Substring(0, txtQty.Text.Length - 1);
                    txtQty.SelectionStart = txtQty.Text.Length;

                }
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtBarcode.Text == "")
                {
                    return;
                }
                else
                {
                    try
                    {
                        var dt =
                            dataManager.GetData(
                                "SELECT ITEM_CODE,ITEM_BCODE,ITEM_DESC,ITEM_CUS9_KH,UNIT_STOCK,UNIT_SALE,ITEM_TYPE,ITEM_PRICE1,ITEM_PRICE2 FROM SIPITEMS",
                                "ITEM_BCODE", "ITEM_BCODE", txtBarcode.Text);
                        if (dt.Rows.Count > 0)
                        {
                            item_Code = dt.Rows[0][0].ToString();
                            txtBarcode.Text = dt.Rows[0][1].ToString();
                            txtName.Text = dt.Rows[0][2].ToString();
                            txtUnitofStock.Text = dt.Rows[0][4].ToString();
                            txtUnitOfSale.Text = dt.Rows[0][5].ToString();
                            unit_Sale = dt.Rows[0][5].ToString();
                            item_Type = dt.Rows[0][6].ToString();
                            item_Kh = dt.Rows[0][3].ToString();
                            item_Price1 = Convert.ToDecimal(dt.Rows[0][7]);
                            item_Price2 = Convert.ToDecimal(dt.Rows[0][8]);
                            txtBarcode.Enabled = false;
                            txtUnitOfSale.Enabled = true;
                            SelectNextControl(txtBarcode, true, true, true, true);

                        }
                        else
                        {
                            MessageBox.Show("There are no item have been found!");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        var pointofsale_FRM = new POINTOFSALE_FRM { lblmessage = { Text = ex.Message } };
                    }

                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var droplist_FRM = new DROPLIST_FRM();
            droplist_FRM.Width = 328;
            droplist_FRM.Height = 200;
            droplist_FRM.DataGridView.RowTemplate.Height = 36;
            droplist_FRM.DataGridView.DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            droplist_FRM.DataGridView.DataSource =
                dataManager.GetData(
                    "SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV",
                    "CONV_FROM", "CONV_FROM", txtUnitOfSale.Text, "CONV_TO", txtUnitofStock.Text);
            droplist_FRM.Top = this.Top + txtUnitOfSale.Top + txtUnitOfSale.Height + 3;
            droplist_FRM.Left = this.Left + txtUnitOfSale.Left - 4;
            droplist_FRM.DataGridView.Columns[0].Width = droplist_FRM.Width * 24 / 100;
            droplist_FRM.DataGridView.Columns[1].Width = droplist_FRM.Width * 30 / 100;
            droplist_FRM.DataGridView.Columns[2].Visible = false;
            droplist_FRM.DataGridView.Columns[3].Visible = false;
            droplist_FRM.DataGridView.Columns[4].DefaultCellStyle.Font = new Font("Limon S1", 20, FontStyle.Regular);
            if (droplist_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //                txtUnitOfSale.Text = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[0].Value.ToString();
                //                operate = droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[2].Value.ToString();
                //                factor =
                //                    Convert.ToDecimal(droplist_FRM.DataGridView.Rows[droplist_FRM.SelectIndex].Cells[3].Value.ToString());
                //                // select price for sale

                GetPrice();

//                txtUnitOfSale_KeyDown(null, null);

                //                var dtPrice = DataManager.GetData("SELECT PRO_RATE FROM SIPOSPRICE", "ITEM_BCODE", "ITEM_BCODE",
                //                                                  txtBarcode.Text, "UNIT_SALE", txtUnitOfSale.Text, "PRO_TYPE",
                //                                                  "D");
                //                if (dtPrice.Rows.Count > 0)
                //                {
                //                    txtPrice.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(dtPrice.Rows[0][0]));
                //                }
                //                else
                //                {
                //                    if (txtUnitOfSale.Text == txtUnitofStock.Text)
                //                    {
                //                        txtPrice.Text = string.Format("{0:0,0.00}", item_Price1);
                //                    }
                //                    else if (txtUnitOfSale.Text == unit_Sale)
                //                    {
                //                        txtPrice.Text = string.Format("{0:0,0.00}", item_Price2);
                //                    }
                //                    else
                //                    {
                //                        MessageBox.Show("There are no selling price on this unit of sale!");
                //                        txtUnitOfSale.Focus();
                //                        txtUnitOfSale.SelectAll();
                //                    }
                //                } // end else if (dtPrice.rows.count > 0)
                //                // select discount for sale
                //                var dtDiscount =
                //                    DataManager.GetData(
                //                        "SELECT PRO_RATE,PRO_FDATE,PRO_TDATE,PRO_TIMES,PRO_TIMEE FROM SIPOSPRICE", "ITEM_BCODE",
                //                        "ITEM_BCODE", txtBarcode.Text, "LOCATION", SITempData.Loc_Code_POS, "UNIT_SALE",
                //                        txtUnitOfSale.Text,
                //                        "PRO_TYPE", "P", "STATUS", "A");
                //                if (dtDiscount.Rows.Count > 0)
                //                {
                //                    var strings = new Strings();
                //
                //                    if (strings.IsDateTime(dtDiscount.Rows[0][1].ToString()) &&
                //                        strings.IsDateTime(dtDiscount.Rows[0][2].ToString()))
                //                    {
                //                        if (
                //                            Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day,
                //                                                                       Convert.ToDateTime(
                //                                                                           dtDiscount.Rows[0][1].ToString()),
                //                                                                       DateTime.Now,
                //                                                                       Microsoft.VisualBasic.FirstDayOfWeek.System,
                //                                                                       Microsoft.VisualBasic.FirstWeekOfYear.System) >=
                //                            0)
                //                        {
                //                            pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                //                            if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                //                                Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                //                            {
                //                                if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                //                                    DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                //                                {
                //                                    pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                //                                }
                //                                // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                //                                else
                //                                {
                //                                    pro_Rate = 0;
                //                                }
                //                                // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                //                            } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                //
                //                        } // end if ( DataDiff..........)
                //                        else
                //                        {
                //                            pro_Rate = 0;
                //                        }
                //                    }
                //                }
                //                txtUnitOfSale.Enabled = false;
                //                txtQty.Enabled = true;
                //                SelectNextControl(txtUnitOfSale, true, true, true, true);
                //            }
                //            else
                //            {
                //                txtUnitOfSale.SelectionStart = 0;
                //                txtUnitOfSale.SelectionLength = txtUnitOfSale.ToString().Length;
                //            }

                //                var dt = new DataTable();
                //                var command =
                //                    new SqlCommand(
                //                        "SELECT ITEM_CODE,ITEM_BCODE,ITEM_DESC,ITEM_CUS9_KH,UNIT_STOCK,UNIT_SALE,ITEM_TYPE,ITEM_PRICE1 FROM SIPITEMS WHERE ITEM_BCODE=@ITEM_BCODE",
                //                        connection.Connect());
                //                command.Parameters.AddWithValue("@ITEM_BCODE", txtBarcode.Text);
                //                var dataAdapter = new SqlDataAdapter(command);
                //                dataAdapter.Fill(dt);
                //
                //                if (dt.Rows.Count > 0)
                //                {
                //                    var price = Convert.ToDecimal(string.Format("{0:00.00}", dt.Rows[0][7]));
                //                    Decimal pro_Rate = 0;
                //                    Decimal ATM = 0;
                //                    var dd = dt.Rows[0][5].ToString();
                //                    // get price set up
                //                    var dtP = dataManager.GetData("SELECT PRO_RATE FROM SIPOSPRICE", "ITEM_BCODE",
                //                                                  "ITEM_BCODE",
                //                                                  txtBarcode.Text, "UNIT_SALE", dt.Rows[0][5].ToString(),
                //                                                  "PRO_TYPE",
                //                                                  "P",
                //                                                  "LOCATION", SITempData.Loc_Code_POS);
                //
                //                    if (dtP.Rows.Count > 0)
                //                    {
                //                        price = Convert.ToDecimal(string.Format("{0:00.00}", dtP.Rows[0][0]));
                //                    }
                //                    else
                //                    {
                //                        dtP = new DataTable();
                //                        dtP = dataManager.GetData("SELECT PRO_RATE FROM SIPOSPRICE", "ITEM_BCODE",
                //                                                  "ITEM_BCODE",
                //                                                  txtBarcode.Text, "UNIT_SALE", dt.Rows[0][5].ToString(),
                //                                                  "PRO_TYPE",
                //                                                  "P");
                //                        if (dtP.Rows.Count > 0)
                //                        {
                //                            price = Convert.ToDecimal(string.Format("{0:00.00}", dtP.Rows[0][0]));
                //                        }
                //                    } // ==== end with else if (dtp.rows.count > 0)
                //
                //                    // ===== select discount for sale
                //                    var dtDiscount =
                //                        dataManager.GetData(
                //                            "SELECT PRO_RATE,PRO_FDATE,PRO_TDATE,PRO_TIMES,PRO_TIMEE FROM SIPOSPRICE",
                //                            "ITEM_BCODE",
                //                            "ITEM_BCODE", txtBarcode.Text, "LOCATION", SITempData.Loc_Code_POS, "UNIT_SALE",
                //                            dt.Rows[0][5].ToString(), "PRO_TYPE", "D", "STATUS", "A");
                //                    if (dtDiscount.Rows.Count > 0)
                //                    {
                //                        pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                //                        var strings = new Strings();
                //                        if (strings.IsDateTime(dtDiscount.Rows[0][1].ToString()) &&
                //                            strings.IsDateTime(dtDiscount.Rows[0][2].ToString()))
                //                        {
                //                            //                                        ========== Note : Not yet complete computer sound
                //                            if (
                //                                Microsoft.VisualBasic.DateAndTime.DateDiff(
                //                                    Microsoft.VisualBasic.DateInterval.Day,
                //                                    Convert.ToDateTime(dtDiscount.Rows[0][1].ToString()), DateTime.Now,
                //                                    Microsoft.VisualBasic.FirstDayOfWeek.System,
                //                                    Microsoft.VisualBasic.FirstWeekOfYear.System) >= 0)
                //                            {
                //                                pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                //                                if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                //                                    Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                //                                {
                //                                    if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                //                                        DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                //                                    {
                //                                        pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                //                                    }
                //                                    // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                //                                    else
                //                                    {
                //                                        pro_Rate = 0;
                //                                    }
                //                                    // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                //                                } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                //
                //
                //                            } // end if (DateDiff(DateInterval.Day.....)
                //                            else
                //                            {
                //                                pro_Rate = 0;
                //                            } // end else if (DateDiff(DateInterval.Day.....)
                //                        }
                //                        // end if (strings.IsDateTime(dtDiscount.Rows[0][1].tostring())&& string.IsDateTime(dtDiscount.Rows[0][2].toString())
                //                        else
                //                        {
                //                            if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                //                                Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                //                            {
                //                                if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                //                                    DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                //                                {
                //                                    pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                //                                }
                //                                // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                //                                else
                //                                {
                //                                    pro_Rate = 0;
                //                                }
                //                                // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                //                            } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                //                        }
                //                        // else if (strings.IsDateTime(dtDiscount.Rows[0][1].tostring())&& string.IsDateTime(dtDiscount.Rows[0][2].toString())
                //                    }
                //                    else
                //                    {
                //                        var dv = dt.Rows[0][5].ToString();
                //                        dtDiscount =
                //                            dataManager.GetData(
                //                                "SELECT PRO_RATE,PRO_FDATE,PRO_TDATE,PRO_TIMES,PRO_TIMEE FROM SIPOSPRICE",
                //                                "ITEM_BCODE", "ITEM_BCODE", txtBarcode.Text, "UNIT_SALE",
                //                                dt.Rows[0][5].ToString(),
                //                                "PRO_TYPE",
                //                                "D", "STATUS", "A");
                //                        if (dtDiscount.Rows.Count > 0)
                //                        {
                //                            pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                //                            var strings = new Strings();
                //                            if (strings.IsDateTime(dtDiscount.Rows[0][1].ToString()) &&
                //                                strings.IsDateTime(dtDiscount.Rows[0][2].ToString()))
                //                            {
                //                                //                                        ========== Note : Not yet complete computer sound
                //                                if (
                //                                    Microsoft.VisualBasic.DateAndTime.DateDiff(
                //                                        Microsoft.VisualBasic.DateInterval.Day,
                //                                        Convert.ToDateTime(dtDiscount.Rows[0][1].ToString()), DateTime.Now,
                //                                        Microsoft.VisualBasic.FirstDayOfWeek.System,
                //                                        Microsoft.VisualBasic.FirstWeekOfYear.System) >= 0)
                //                                {
                //                                    pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                //                                    if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                //                                        Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                //                                    {
                //                                        if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                //                                            DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                //                                        {
                //                                            pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                //                                        }
                //                                        // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                //                                        else
                //                                        {
                //                                            pro_Rate = 0;
                //                                        }
                //                                        // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                //                                    }
                //                                    // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                //                                } // end if (DateDiff(DateInterval.Day.....)
                //                                else
                //                                {
                //                                    pro_Rate = 0;
                //                                } // end else if (DateDiff(DateInterval.Day.....)
                //                            }
                //                            // end if (strings.IsDateTime(dtDiscount.Rows[0][1].tostring())&& string.IsDateTime(dtDiscount.Rows[0][2].toString())
                //                            else
                //                            {
                //                                if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 &&
                //                                    Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                //                                {
                //                                    if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) &&
                //                                        DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                //                                    {
                //                                        pro_Rate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                //                                    }
                //                                    // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                //                                    else
                //                                    {
                //                                        pro_Rate = 0;
                //                                    }
                //                                    // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                //                                } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                //                            } //
                //                        } // end else if (dtDiscount.Rows.Count > 0 ) and No LOCATION 
                //                    } // end else if (dtDiscount.Rows.Count > 0 ) and on this table have "Location Field" 
                //                    txtPrice.Text = price.ToString();
                //                }
                //
                //
            }

        }

        private void GetPrice()
        {
            var dt = dataManager.GetData("SELECT CONV_FROM,OPERATOR,FACTOR FROM SIUNITCONV", "CONV_FROM",
                                                    "CONV_FROM", txtUnitOfSale.Text, "CONV_TO", txtUnitofStock.Text);
            if (dt.Rows.Count > 0)
            {
                txtUnitOfSale.Text = dt.Rows[0][0].ToString();
                operate = dt.Rows[0][1].ToString();
                factor = Convert.ToDecimal(dt.Rows[0][2].ToString());
                var dtPrice = dataManager.GetData("SELECT PRO_RATE FROM SIPOSPRICE", "ITEM_BCODE", "ITEM_BCODE",
                                                  txtBarcode.Text, "UNIT_SALE", txtUnitOfSale.Text, "PRO_TYPE",
                                                  "P");
                if (dtPrice.Rows.Count > 0)
                {
                    txtPrice.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(dtPrice.Rows[0][0]));
                }
                else
                {
                    if (txtUnitOfSale.Text == txtUnitofStock.Text)
                    {
                        txtPrice.Text = string.Format("{0:0,0.00}", item_Price1);
                    }
                    else if (txtUnitOfSale.Text == unit_Sale)
                    {
                        txtPrice.Text = string.Format("{0:0,0.00}", item_Price2);
                    }
                    else
                    {
                        MessageBox.Show("There are no selling price on this unit of sale!");
                        txtUnitOfSale.Focus();
                        txtUnitOfSale.SelectAll();
                    }
                } // end else if (dtPrice.rows.count > 0)
                // select discount for sale
                var dtDiscount =
                    dataManager.GetData(
                        "SELECT PRO_RATE,PRO_FDATE,PRO_TDATE,PRO_TIMES,PRO_TIMEE FROM SIPOSPRICE", "ITEM_BCODE",
                        "ITEM_BCODE", txtBarcode.Text, "LOCATION", SITempData.Loc_Code_POS, "UNIT_SALE", txtUnitOfSale.Text,
                        "PRO_TYPE", "D", "STATUS", "A");
                if (dtDiscount.Rows.Count > 0)
                {
                    var strings = new Strings();

                    if (strings.IsDateTime(dtDiscount.Rows[0][1].ToString()) && strings.IsDateTime(dtDiscount.Rows[0][2].ToString()))
                    {
                        if (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, Convert.ToDateTime(dtDiscount.Rows[0][1].ToString()), DateTime.Now, Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) >= 0)
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
                            } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....

                        }// end if ( DataDiff..........)
                        else
                        {
                            pro_Rate = 0;
                        }
                    }
                    else
                    {
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
                        } // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                    }
                }
                txtUnitOfSale.Enabled = false;
                txtQty.Enabled = true;
                SelectNextControl(txtUnitOfSale, true, true, true, true);
            }
            else
            {
                txtUnitOfSale.SelectionStart = 0;
                txtUnitOfSale.SelectionLength = txtUnitOfSale.ToString().Length;
            }
        }
    }
}

