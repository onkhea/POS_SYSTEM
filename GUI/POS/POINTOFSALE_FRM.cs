using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using POS.DataLayer;
using POS.GUI.Inventory;
using POS.Reports;
using POS.Transaction;
using POS.Transaction.Security;
using Microsoft.VisualBasic.Devices;
using POS.Utilities;

namespace POS.GUI.POS
{
    public partial class POINTOFSALE_FRM : DevComponents.DotNetBar.Office2007Form//Form
    {
        public POINTOFSALE_FRM()
        {
            InitializeComponent();
        }

        readonly DataManager dataManager = new DataManager();
        readonly Connection.Connection connection = new Connection.Connection();
        private bool IsSIAuto = false;
        private string _soPrefix;
        private Int16 k = 1;
        DataTable datatable = new DataTable();
        readonly SIFormats formats = new SIFormats();
        Strings strings = new Strings();
        string strCode = "";
        Dictionary<string,int> dictionary = new Dictionary<string, int>();
        private string emp = "";
        XMLFLA xmlfla = new XMLFLA();
 

       

        public string SoSuffix
        {
            get { return SO_SUFFIX; }
        }

        public string SoLenght
        {
            get { return SO_LENGHT; }
        }

        public string SoPrefix
        {
            get { return _soPrefix; }
        }

        public bool IsSIAuto_
        {
            get { return IsSIAuto; }
        }

        private string UPDATE_STOCK_STATUS = "M"; /// default manual stock status

        private void POINTOFSALE_FRM_Load(object sender, EventArgs e)
        {
           
            splitContainer1.SplitterDistance = this.Height * 30 / 100;
            splitContainer2.SplitterDistance = splitContainer2.Height - 90;
            splitContainer3.SplitterDistance = 52;

            dataGridViewX1.Columns[0].Width = 0;
            dataGridViewX1.Columns[1].Width = Width * 9 / 100;
            dataGridViewX1.Columns[2].Width = Width * 56 / 100;
            dataGridViewX1.Columns[3].Width = Width * 10 / 100;
            dataGridViewX1.Columns[4].Width = Width * 10 / 100;
            dataGridViewX1.Columns[5].Width = Width * 10 / 100;
            dataGridViewX1.Columns[6].Width = Width * 15 / 100;
            lblTotal.Top = 13;
            lblTotal.Height = splitContainer2.Panel2.Height - 30;
            lblTotal.Width = splitContainer2.Panel2.Width * 19 / 100;
            lblTotal.Left = splitContainer3.Width - (lblTotal.Width);
            lblmessage.Top = splitContainer2.Panel2.Height / 2 - (lblmessage.Height / 2);
            lblmessage.Left = Width / 4;
            lblmessage.Width = Width / 2;
            var st = string.Format(@"{0}\banner\banner.swf", Application.StartupPath);
            //axShockwaveFlash2.LoadMovie(0, st);
            splitContainer1.Panel2.Show();
            lblcashier.Text = UserLogOn.Name;
            // Auto Number
            var dt = dataManager.GetData("SELECT SI_DATA FROM SIPDATA", "SI_CODE", "SI_CODE", "OS", "SI_TYPE", "AUTON");
            if (dt.Rows.Count > 0)
            {
                IsSIAuto = true;
                _soPrefix = dt.Rows[0][0].ToString().Substring(0, 10).Trim();
                SO_SUFFIX = dt.Rows[0][0].ToString().Substring(10, 10).Trim();
                SO_INTERVAL = dt.Rows[0][0].ToString().Substring(20, 5);
                SO_LENGHT = dt.Rows[0][0].ToString().Substring(25, 2).Trim();
                SO_START = dt.Rows[0][0].ToString().Substring(27, 5).Trim();

            }
            dataGridViewX1.Focus();
           
            SITempData.Loc_Code_POS = UserLogOn.Location;
            SITempData.CUST_POS =
            DataAccess.ReturnField(string.Format("SELECT ADD_CODE FROM SIPCUSPOS WHERE LOC_CODE = '{0}' AND USER_CODE = '{1}'", SITempData.Loc_Code_POS, UserLogOn.Code), 0);
            emp = DataAccess.ReturnField(string.Format("SELECT EMP_CODE FROM SIPCUSPOS WHERE LOC_CODE = '{0}' AND USER_CODE = '{1}'", SITempData.Loc_Code_POS, UserLogOn.Code), 0);
            SITempData.DelcustPos =
                DataAccess.ReturnField(string.Format("SELECT DEL_CODE FROM SIPDADD WHERE ADD_CODE = '{0}'", SITempData.CUST_POS), 0);
            datatable = dataManager.Create("Number");


//            ======================== Note: Create File Temp for SideBar Flash =============== 
            var path = string.Format("{0}\\TempFlash", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            var filepath = string.Format(@"{0}\banner\TempFlash\SlideBar.swf", Application.StartupPath);
            var fileXML = string.Format(@"{0}\banner\TempFlash\move_to_framenumber.xml", Application.StartupPath);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.Copy(filepath, string.Format("{0}\\SlideBar.swf", path));
                File.Copy(fileXML, string.Format("{0}\\move_to_framenumber.xml", path));
            }
//            ================= Create Flash Folder =============
            
            var pathFlash = string.Format(@"{0}\Flash", Application.StartupPath);
            
            if (Directory.Exists(pathFlash))
            {
                Directory.Delete(pathFlash,true);
            }
                Directory.CreateDirectory(pathFlash);
                var imagePath = string.Format(@"{0}\Flash\images", Application.StartupPath);
                File.Copy(string.Format("{0}\\move_to_framenumber.xml", path), string.Format("{0}\\Flash\\move_to_framenumber.xml", Application.StartupPath));
                File.Copy(string.Format("{0}\\SlideBar.swf", path),string.Format("{0}\\Flash\\SlideBar.swf", Application.StartupPath));
                Directory.CreateDirectory(imagePath);
           
        }

        private void POINTOFSALE_FRM_Activated(object sender, EventArgs e)
        {
            dataGridViewX1.Focus();
        }

        private void POINTOFSALE_FRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridViewX1.Rows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to exit without cash in?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            if (ISLOG_OFF == false)
            {
                try
                {
                    using (var command = new SqlCommand("UPDATE SIPUSERS SET USER_LOG=@USER_LOG WHERE USER_CODE=@USER_CODE", connection.Connect()))
                    {
                        Commands.CreateParameter(command, "USER_CODE", UserLogOn.Code, "USER_LOG",
                                                 System.Text.Encoding.UTF32.GetBytes("U"));
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void splitContainer1_GotFocus(object sender, System.EventArgs e)
        {
            dataGridViewX1.Focus();
        }

        private void axShockwaveFlash2_GotFocus(object sender, EventArgs e)
        {
            dataGridViewX1.Focus();
        }

        void splitContainer2_GotFocus(object sender, System.EventArgs e)
        {
            dataGridViewX1.Focus();
        }

        private void dataGridViewX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)13)
            {
                if (IsSIAuto )//&& SITempData.Loc_Code_POS.Trim() != "")
                {
                    if (UserLogOn.Code == "")
                    {
                        lblmessage.Text = "Please press Alt + F6 to change terminal.";
                        Sound.Beep(500, 100);
                        return;
                    } //end if == UserLogOn.C6ode == ""

                    if (strCode == "")
                    {
                        return;
                    }
                    else
                    {
                        try
                        {
                            Cursor = Cursors.WaitCursor;
                            using (var dt = new DataTable())
                            {
                            		using (var command = new SqlCommand("SELECT ITEM_CODE,ITEM_BCODE,ITEM_DESC,ITEM_CUS9_KH,UNIT_STOCK,UNIT_SALE,ITEM_TYPE,ITEM_PRICE1,ITEM_PRICE2 FROM SIPITEMS WHERE ITEM_BCODE=@ITEM_BCODE", connection.Connect()))
                            		{
                            				command.Parameters.AddWithValue("@ITEM_BCODE", strCode);
                            		    using (var dataAdapter = new SqlDataAdapter(command))
                            		    {
                            		        dataAdapter.Fill(dt);
                            		    }
                            		}
                            		if (dt.Rows.Count > 0)
                            		{
                            				var price = Convert.ToDecimal(string.Format("{0:00.00}", dt.Rows[0][8]));
                            				Decimal proRate = 0;
                            				Decimal ATM = 0;
                            				var dd = dt.Rows[0][5].ToString();
                            				// get price set up
                            				var dtP = dataManager.GetData("SELECT PRO_RATE FROM SIPOSPRICE", "ITEM_BCODE", "ITEM_BCODE", strCode, "UNIT_SALE", dt.Rows[0][5].ToString(), "PRO_TYPE", "P", "LOCATION", SITempData.Loc_Code_POS);
                            				if (dtP.Rows.Count > 0)
                            						price = Convert.ToDecimal(string.Format("{0:00.00}", dtP.Rows[0][0]));
                            				else
                            				{
                            						dtP = new DataTable();
                            						dtP = dataManager.GetData("SELECT PRO_RATE FROM SIPOSPRICE", "ITEM_BCODE", "ITEM_BCODE", strCode, "UNIT_SALE", dt.Rows[0][5].ToString(), "PRO_TYPE", "P");
                            						if (dtP.Rows.Count > 0)
                            								price = Convert.ToDecimal(string.Format("{0:00.00}", dtP.Rows[0][0]));
                            				} // ==== end with else if (dtp.rows.count > 0)
                            				// ===== select discount for sale
                            				var dtDiscount = dataManager.GetData("SELECT PRO_RATE,PRO_FDATE,PRO_TDATE,PRO_TIMES,PRO_TIMEE FROM SIPOSPRICE", "ITEM_BCODE", "ITEM_BCODE", strCode, "LOCATION", SITempData.Loc_Code_POS, "UNIT_SALE", dt.Rows[0][5].ToString(), "PRO_TYPE", "D", "STATUS", "A");
                            				if (dtDiscount.Rows.Count > 0)
                            				{
                            						proRate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            						var strings = new Strings();
                            						if (strings.IsDateTime(dtDiscount.Rows[0][1].ToString()) && strings.IsDateTime(dtDiscount.Rows[0][2].ToString()))
                            						{
                            								//                                        ========== Note : Not yet complete computer sound
                            								if (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, Convert.ToDateTime(dtDiscount.Rows[0][1].ToString()), DateTime.Now, Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) >= 0 && Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, Convert.ToDateTime(dtDiscount.Rows[0][2].ToString()), DateTime.Now, Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) <= 0)
                            								{
                            										proRate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            										if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 && Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                            												if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) && DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                            														proRate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            												// end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            												else
                            														proRate = 0;
                            												// end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            										 // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                            								} // end if (DateDiff(DateInterval.Day.....)
                            								else
                            										proRate = 0;
                            								 // end else if (DateDiff(DateInterval.Day.....)
                            						} // end if (strings.IsDateTime(dtDiscount.Rows[0][1].tostring())&& string.IsDateTime(dtDiscount.Rows[0][2].toString())
                            						else
                            								if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 && Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                            										if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) && DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                            												proRate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            										 // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            										else
                            												proRate = 0;
                            										 // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            								 // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                            						 // else if (strings.IsDateTime(dtDiscount.Rows[0][1].tostring())&& string.IsDateTime(dtDiscount.Rows[0][2].toString())
                            				}
                            				else
                            				{
                            						var dv = dt.Rows[0][5].ToString();
                            						dtDiscount = dataManager.GetData("SELECT PRO_RATE,PRO_FDATE,PRO_TDATE,PRO_TIMES,PRO_TIMEE FROM SIPOSPRICE", "ITEM_BCODE", "ITEM_BCODE", strCode, "UNIT_SALE", dt.Rows[0][5].ToString(), "PRO_TYPE", "D", "STATUS", "A");
                            						if (dtDiscount.Rows.Count > 0)
                            						{
                            								proRate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            								var strings = new Strings();
                            								if (strings.IsDateTime(dtDiscount.Rows[0][1].ToString()) && strings.IsDateTime(dtDiscount.Rows[0][2].ToString()))
                            								{
                            										//                                        ========== Note : Not yet complete computer sound
                            										if (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, Convert.ToDateTime(dtDiscount.Rows[0][1].ToString()), DateTime.Now, Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) >= 0)
                            										{
                            												proRate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            												if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 && Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                            														if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) && DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                            																proRate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            														// end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            														else
                            																proRate = 0;
                            														// end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            												// end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                            										} // end if (DateDiff(DateInterval.Day.....)
                            										else
                            												proRate = 0;
                            										 // end else if (DateDiff(DateInterval.Day.....)
                            								} // end if (strings.IsDateTime(dtDiscount.Rows[0][1].tostring())&& string.IsDateTime(dtDiscount.Rows[0][2].toString())
                            								else
                            										if (Convert.ToDouble(dtDiscount.Rows[0][3].ToString()) > -1 && Convert.ToDouble(dtDiscount.Rows[0][4].ToString()) > -1)
                            												if (DateTime.Now.Hour >= Convert.ToInt16(dtDiscount.Rows[0][3]) && DateTime.Now.Hour <= Convert.ToInt16(dtDiscount.Rows[0][4]))
                            														proRate = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                            												 // end if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            												else
                            														proRate = 0;
                            												 // end else if (datetime.now.hour >= convert.toint16(dtdiscount.rows[0][3] && ....
                            										 // end if (convert.todouble(dtdiscount.rows[0][3].tostring) > -1 && .....
                            								 //
                            						} // end else if (dtDiscount.Rows.Count > 0 ) and No LOCATION 
                            				} // end else if (dtDiscount.Rows.Count > 0 ) and on this table have "Location Field" 
                            				ATM = price;
                            				UPDATE_STOCK_STATUS = dt.Rows[0][6].ToString();
                            				var i = SIDataGridView.CheckOnGrid(dataGridViewX1, dt.Rows[0][0], 0, price, 4, dt.Rows[0][5], 10);
                            				var condition = new []{"CONV_FROM", dt.Rows[0][5].ToString(), "CONV_TO", dt.Rows[0][4].ToString()};
                            				var operate = DataAccess.ReturnField("SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV ", "CONV_FROM", condition, 2);
                            				var factor = Convert.ToDecimal(DataAccess.ReturnField("SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV ", "CONV_FROM", condition, 3));
                            				var unitStockQty = "";
                            				if (operate == "*")
                            						unitStockQty = string.Format("{0:0,0.00}", Convert.ToDecimal(1) * factor);
                            				else
                            						unitStockQty = string.Format("{0:0,0.00}", Convert.ToDecimal(1) / factor);
                            				if (i == -1)
                            						dataGridViewX1.Rows.Insert(0, dt.Rows[0][0], string.Format("{0:000}", dataGridViewX1.RowCount + 1), dt.Rows[0][2] + " - " + dt.Rows[0][5], dt.Rows[0][3], string.Format("{0:00.00}", price), string.Format("{0:n}", 1), string.Format("{0:00.00}", ATM), strCode, proRate, string.Format("{0:00.00}", price * (proRate / 100)), dt.Rows[0][5], unitStockQty, dt.Rows[0][6]);
                            				else
                            				{
                            						dataGridViewX1.Rows[i].Cells[5].Value = string.Format("{0:n}", Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[5].Value) + 1);
                            						dataGridViewX1.Rows[i].Cells[6].Value = string.Format("{0:00.00}", Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[6].Value) + ATM);
                            						dataGridViewX1.Rows[i].Cells[9].Value = string.Format("{0:00.00}", Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[9].Value) + (price * (price / 100)));
                            						dataGridViewX1.Rows[i].Cells[11].Value = string.Format("{0:00.00}", Convert.ToDecimal(dataGridViewX1.Rows[i].Cells[11].Value) + Convert.ToDecimal(unitStockQty));
                            				} // end else if (i == -1 )
                            				dataGridViewX1.Rows[0].Cells[1].Selected = true;
                            				lblTotal.Text = string.Format("{0:00.00}", SIDataGridView.Sum(dataGridViewX1, 6));
                            		}
                                    else
                                    {
                                        //                                ========= AUDIT (Now, LOC_CODE_POS,StrCode)
                                        lblmessage.Text = "Item " + strCode + " is not found!";
                                        Sound.Beep(500, 100);
                                    }
                            } // === end if (dt.rows.count > 0 )
                            


//                            ===========  NOTE: testing flash loading =========
                            // Create Images

                           
                            var images = new Images();
                            images.Create(string.Format("SELECT ITEM_IMG FROM SIPITEMS WHERE ITEM_BCODE = '{0}'", strCode), Application.StartupPath + @"\Flash\images\", strCode);
                           
                            
                            if (!dataManager.Exist(datatable,"Number",strCode))
                            {
                                dataManager.Save(datatable, strCode);
                                xmlfla.Write(string.Format(@"{0}\Flash\move_to_framenumber.xml", Application.StartupPath), datatable);

                            }
                            var j = k - 1;
                            var pathFile = string.Format(@"{0}\Flash\SlideBar.swf", Application.StartupPath);
                            if (File.Exists(pathFile))
                            {
                                File.Move(string.Format(@"{0}\Flash\SlideBar.swf", Application.StartupPath), string.Format(@"{0}\Flash\{1}.swf", Application.StartupPath, k.ToString()));
                            }
                            else
                            {
                                File.Move(string.Format(@"{0}\Flash\{1}.swf", Application.StartupPath, j.ToString()), string.Format(@"{0}\Flash\{1}.swf", Application.StartupPath, k.ToString()));    
                            }
                            
                            var st = string.Format(@"{0}\Flash\{1}.swf", Application.StartupPath, k.ToString());
                            //axShockwaveFlash2.LoadMovie(0, st);
                            
                            k++;
                            Cursor = Cursors.Default;
                        }
                        catch (Exception ex)
                        {
                            Cursor = Cursors.Default;
                            lblmessage.Text = ex.Message;
                        } // === end try catch
                    } // end if (strCode == "")

                } //end if (IsSIAuto && Loc_Code_POS)
                else
                {
                    lblmessage.Text = "Please check auto number and location!";
                }
                strCode = "";
            }
            else if (e.KeyChar == (char)27)  // === Key Esc
            {
                strCode = "";
            }
            else
            {
                strCode = strCode + e.KeyChar;
            }
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift == false && e.Control == false)
            {
                #region if (e.Alt == true && e.KeyCode == Keys.C)
                if (e.Alt == true && e.KeyCode == Keys.C)
                {
                    if (SITempData.Code == "")
                    {
                        MessageBox.Show("Please press Alt+F6 to change terminal", "", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }
                    var cmd =
                        new SqlCommand(
                            "SELECT SUM(TOTAL_USD) TOTAL_USD, SUM(TOTAL_RIEL) TOTAL_RIEL,SUM(DISC_INVUS + DISC_ITEMUS) DISC_USD, " +
                            "SUM(DISC_INVR + DISC_ITEMR) DISC_RIEL, SUM(CASHIN_USD - CHANGE_USD)CASHIN_USD, SUM(CASHIN_RIEL - CHANGE_RIEL) CASHIN_RIEL FROM dbo.SIPOSCASHCOLS " +
                            "WHERE STATUS='0' AND USERID = '" + UserLogOn.Code + "'",
                            connection.Connect());
                    var dtColection = dataManager.GetData(cmd);
                    var cashcollection_FRM = new CASHCOLLECTION_FRM();
//                    helppos_FRM.Top = splitContainer1.Panel1.Height + 5;
//                    helppos_FRM.Left = 0;
//                    helppos_FRM.Height = splitContainer3.Panel2.Height + splitContainer3.Panel1.Height;
//                    helppos_FRM.Width = this.Width;
//                    helppos_FRM.Label1.Left = this.Width / 2 - helppos_FRM.Label1.Width / 2;
//                    helppos_FRM.Label1.Top = helppos_FRM.Height / 2;
//                    helppos_FRM.ShowDialog();
                    cashcollection_FRM.Left = 0;
                    cashcollection_FRM.Top = splitContainer1.Panel1.Height;
                    cashcollection_FRM.Width = dataGridViewX1.Width;
                    cashcollection_FRM.Height = splitContainer3.Panel2.Height + splitContainer3.Panel1.Height + splitContainer2.Panel2.Height;

                    cashcollection_FRM.lblCashier.Text = UserLogOn.Name;
                    if (dtColection.Rows.Count > 0)
                    {
                        cashcollection_FRM.lbltotalUSD.Text = string.Format("{0:0,0.00}",
                                                                            dtColection.Rows[0][0] == Convert.DBNull
                                                                                ? 0
                                                                                : Convert.ToDecimal(
                                                                                      dtColection.Rows[0][0]));
                        cashcollection_FRM.lbltotalRIEL.Text = string.Format("{0:0,0}",dtColection.Rows[0][1] == Convert.DBNull
                                                                                           ? 0
                                                                                           : Convert.ToDecimal(
                                                                                                 dtColection.Rows[0][1]));
                        cashcollection_FRM.lblDiscountUSD.Text = string.Format("{0:0,0.00}", dtColection.Rows[0][2] == Convert.DBNull
                                                                                                 ? 0
                                                                                                 : Convert.ToDecimal(
                                                                                                       dtColection.Rows[0][2]));
                        cashcollection_FRM.lblDiscountRIEL.Text = string.Format("{0:0,0}", dtColection.Rows[0][3] == Convert.DBNull
                                                                                               ? 0
                                                                                               : Convert.ToDecimal(
                                                                                                     dtColection.Rows[0][3]));
                        cashcollection_FRM.lblCashUSD.Text = string.Format("{0:0,0.00}", dtColection.Rows[0][4] == Convert.DBNull
                                                                                             ? 0
                                                                                             : Convert.ToDecimal(
                                                                                                   dtColection.Rows[0][4]));
                        cashcollection_FRM.lblCashRIEL.Text = string.Format("{0:0,0}", dtColection.Rows[0][5] == Convert.DBNull
                                                                                           ? 0
                                                                                           : Convert.ToDecimal(
                                                                                                 dtColection.Rows[0][5]));

                    }
                    lblmessage.Text = "Cash collection...";
                    if (cashcollection_FRM.ShowDialog()== System.Windows.Forms.DialogResult.Cancel)
                    {
                        cmd = new SqlCommand("UPDATE SIPOSCASHCOLS SET STATUS='1' WHERE USERID='" + UserLogOn.Code + "'",
                                             connection.Connect());
                        cmd.ExecuteNonQuery();
                        ISLOG_OFF = true;
                    }
                    else
                    {
                        lblmessage.Text = "Cash collection is cancel...";
                    }
                 
                }// end if (e.Alt == true && e.KeyCode == Keys.C)
                    #endregion

                    #region if(e.keycode == keys.f5)
                else if (e.KeyCode == Keys.F5)
                {
                    #region Cash in
                    if (IsSIAuto && SITempData.Loc_Code_POS.Trim() != "")
                    {
                        if (UserLogOn.Code.Trim() == "")
                        {
                            lblmessage.Text = "Please press Alt + F6 to change terminal";
                            return;
                        }
                        if (dataManager.Exists("SIPREPTS", "POS", "REP_CODE", "REP_TYPE", "POS Invoice Form"))
                        {
                            if (MessageBox.Show("There are no reciept print form. Do you want ot continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                            {
                                return;
                            }
                        }
                        var cashin_FRM = new CASHIN_FRM();
                        if (dataGridViewX1.Rows.Count > 0)
                        {

                            cashin_FRM.Top = splitContainer1.Panel1.Height - splitContainer3.Panel1.Height - splitContainer2.Panel2.Height;
                            cashin_FRM.Left = dataGridViewX1.Width / 2 - cashin_FRM.Width / 2;
                            var command =
                                new SqlCommand("SELECT EX_RATE FROM SIPOSRATE WHERE EX_DATE<='" +
                                               DateTime.Now.ToShortDateString() + "'  ORDER BY EX_DATE DESC", connection.Connect());
                            var dtRate = dataManager.GetData(command);
                            if (dtRate.Rows.Count > 0)
                            {
                                cashin_FRM.txtexchange.Text = Convert.IsDBNull(dtRate.Rows[0][0])
                                                                  ? "0"
                                                                  : string.Format(formats.PO_Format, Convert.ToDecimal(dtRate.Rows[0][0]));
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Please set the exchange rate for database '' or change terminal by press Alt + F6",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            cashin_FRM.txtsubtotal.Text = lblTotal.Text;
                            cashin_FRM.txtdiscount.Text = string.Format(formats.PO_Format,
                                                                        SIDataGridView.Sum(dataGridViewX1, 9));
                            cashin_FRM.txtgtotald.Text = string.Format(formats.PO_Format,
                                                                       Convert.ToDecimal(cashin_FRM.txtsubtotal.Text) -
                                                                       Convert.ToDecimal(cashin_FRM.txtdiscount.Text));
                            cashin_FRM.txtgtotalr.Text = string.Format("{0:0,0}",
                                                                       Convert.ToDecimal(cashin_FRM.txtgtotald.Text) *
                                                                       Convert.ToDecimal(cashin_FRM.txtexchange.Text));
                            if (strings.IsNumeric(cashin_FRM.txtgtotalr.Text))
                            {
                                if (Convert.ToDecimal(cashin_FRM.txtgtotalr.Text) % 100 >= 50)
                                {
                                    cashin_FRM.txtgtotalr.Text =
                                        Convert.ToString(Convert.ToDecimal(cashin_FRM.txtgtotalr.Text) -
                                                         (Convert.ToDecimal(cashin_FRM.txtgtotalr.Text) % 100) + 100);
                                }
                                else
                                {
                                    cashin_FRM.txtgtotalr.Text =
                                        Convert.ToString(Convert.ToDecimal(cashin_FRM.txtgtotalr.Text) -
                                                         (Convert.ToDecimal(cashin_FRM.txtgtotalr.Text) % 100));
                                }
                            }
                            var dateTimes = new DateTimes();
                            var currentDate = DateTime.Now;
                            var strCode = ""; var cust_Code = "";
                            var del_Code = "";
                            var V = new string[7];
                            var VI = new Decimal[19];
                            lblmessage.Text = "Cash in...";

                            if (cashin_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                // ================ NOTE: Inset Data SIPSINVM ============
                                command = new SqlCommand("SI_INSERT_SIPSINVM", connection.Connect())
                                              {CommandType = CommandType.StoredProcedure};
                                try
                                {
                                    Cursor = Cursors.WaitCursor;
//                                    var SOAutoNum = SIAutoNumber.SO_AutoNumber();
                                    var POSAutoNum = SIAutoNumber.POS_AutoNumber();
//                                                                        ========== Note : customer need to refacting here.
                                    
                                    Commands.CreateParameter(command, "ORD_REF_1", POSAutoNum,
                                                             "INV_REF_2", "",
                                                             "INV_DATE_3", dateTimes.Now(), "CUS_CODE_4",
                                                             SITempData.CUST_POS,
                                                             "DEL_CODE_5", SITempData.DelcustPos, "EMP_CODE_6",emp,
                                                             "INV_COM_7", "", "INV_TOTAL_8",
                                                             Convert.ToDecimal(cashin_FRM.txtsubtotal.Text),
                                                             "INV_TOTID_9",
                                                             Convert.ToDecimal(cashin_FRM.txtdiscount.Text),
                                                             "INV_TOTAD_10",
                                                             Convert.ToDecimal(cashin_FRM.txtgtotald.Text),
                                                             "INV_DISP_11", 0, "INV_DISA_12", 0,
                                                             "INV_TOTAI_13",
                                                             Convert.ToDecimal(cashin_FRM.txtsubtotal.Text),
                                                             "INV_VAT_14", 0, "INV_GRAND_15",
                                                             Convert.ToDecimal(cashin_FRM.txtgtotald.Text),
                                                             "INV_STAT_16", "A", "INV_PAY_17", "N", "USER_CODE_18",
                                                             UserLogOn.Code,"INV_CREDIT_19","D","INV_POS_20","A");
                                    command.ExecuteNonQuery();

                                    // ============================ Insert Detail =======================
                                    command.CommandText = "SI_INSERT_SIPSINVD";
                                    var i = 1;
                                    foreach (DataGridViewRow row in dataGridViewX1.Rows)
                                    {
                                        command.Parameters.Clear();

                                        var price = Convert.ToDecimal(row.Cells[4].Value.ToString());
                                        var saleQty = Convert.ToDecimal(row.Cells[5].Value);
                                        var stockQty = Convert.ToDecimal(row.Cells[11].Value);
                                        var amount = Convert.ToDecimal(row.Cells[6].Value);
                                        var disc = Convert.ToDecimal(row.Cells[8].Value.ToString());
                                        var discUSD = Convert.ToDecimal(row.Cells[9].Value.ToString());
                                        var totalDisc = Convert.ToDecimal(Double.Parse(row.Cells[6].Value.ToString()) -
                                                                          Double.Parse(row.Cells[9].Value.ToString()));
                                        var grandTotal = Convert.ToDecimal(
                                            Double.Parse(row.Cells[6].Value.ToString()) -
                                            Double.Parse(row.Cells[9].Value.ToString()));
                                        Commands.CreateParameter(command, "ORD_REF_1", POSAutoNum,
                                                                 "ORD_LINE_2", string.Format("{0:000}", i),
                                                                 "LOC_CODE_3", SITempData.Loc_Code_POS, "ITEM_CODE_4",
                                                                 row.Cells[0].Value, "ITEM_DESC_5", row.Cells[2].Value,
                                                                 "INV_UNIT_6", row.Cells[10].Value, "INV_QTY_7", saleQty,
                                                                 "INV_STOCK_8", stockQty,
                                                                 "INV_PRICE_9", price,
                                                                 "INV_SUB_10", amount, "INV_DISP_11", disc,
                                                                 "INV_DISA_12", discUSD, "INV_TOT_13", totalDisc, "INV_STAT_14",
                                                                 "S",
                                                                 "INV_COM_15", "", "INV_REF_16","","INV_CRE_17","D","INV_POS_18","A");
                                        command.ExecuteNonQuery();

                                        i++;
                                    }

                                    // =========================    Insert Cash Collection ===================
                                    command.Parameters.Clear();
                                    command.CommandText = "SI_INSERT_SIPOSCASHCOLS";
                                    Commands.CreateParameter(command, "INV_CODE_1 ", POSAutoNum,
                                                             "EXCHANGE_2", Double.Parse(cashin_FRM.txtexchange.Text),
                                                             "CASHIN_USD_3",
                                                             cashin_FRM.txtcashind.Text.Trim() == ""
                                                                 ? 0
                                                                 : Convert.ToDecimal(cashin_FRM.txtcashind.Text),
                                                             "CASHIN_RIEL_4",
                                                             cashin_FRM.txtcashinr.Text.Trim() == ""
                                                                 ? 0
                                                                 : Convert.ToDecimal(cashin_FRM.txtcashinr.Text),
                                                             "CHANGE_USD_5", Double.Parse(cashin_FRM.txtchanged.Text),
                                                             "CHANGE_RIEL_6", Double.Parse(cashin_FRM.txtchanger.Text),
                                                             "USERID_7", UserLogOn.Code, "STATUS_8", "0", "CID_9", 0,
                                                             "TOTAL_USD10",
                                                             Convert.ToDecimal(cashin_FRM.txtsubtotal.Text),
                                                             "TOTAL_RIEL11",
                                                             Convert.ToDecimal(cashin_FRM.txtsubtotal.Text)*
                                                             Convert.ToDecimal(cashin_FRM.txtexchange.Text),
                                                             "DISC_INVUS12", 0, "DISC_INVR13", 0, "DISC_ITEMUS14",
                                                             Convert.ToDecimal(cashin_FRM.txtdiscount.Text),
                                                             "DISC_ITEMR15",
                                                             Convert.ToDecimal(cashin_FRM.txtdiscount.Text)*
                                                             Convert.ToDecimal(cashin_FRM.txtexchange.Text));
                                    command.ExecuteNonQuery();
                                    //                                    ============================== Note : CID Don't Understand about this field.
                                    // ================ Print Report =================
                                    var report = new Report();
                                    var dt =
                                        dataManager.GetData(string.Format("SELECT * FROM V_POS_PRINT WHERE [Invoice No]='{0}'", POSAutoNum));
                                    report.Preview("POS Print",dt);

                                    var path = string.Format("{0}\\TempFlash", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                                    var filepath = string.Format(@"{0}\banner\TempFlash\SlideBar.swf", Application.StartupPath);
                                    var fileXML = string.Format(@"{0}\banner\TempFlash\move_to_framenumber.xml", Application.StartupPath);
                                    if (!Directory.Exists(path))
                                    {
                                        Directory.CreateDirectory(path);
                                        File.Copy(filepath, string.Format("{0}\\SlideBar.swf", path));
                                        File.Copy(fileXML, string.Format("{0}\\move_to_framenumber.xml", path));
                                    }
                                    //            ================= Create Flash Folder =============

                                    var pathFlash = string.Format(@"{0}\Flash", Application.StartupPath);

                                    if (Directory.Exists(pathFlash))
                                    {
                                        Directory.Delete(pathFlash, true);
                                    }
                                    Directory.CreateDirectory(pathFlash);
                                    var imagePath = string.Format(@"{0}\Flash\images", Application.StartupPath);
                                    File.Copy(string.Format("{0}\\move_to_framenumber.xml", path), string.Format("{0}\\Flash\\move_to_framenumber.xml", Application.StartupPath));
                                    File.Copy(string.Format("{0}\\SlideBar.swf", path), string.Format("{0}\\Flash\\SlideBar.swf", Application.StartupPath));
                                    Directory.CreateDirectory(imagePath);

                                    datatable.Rows.Clear();
                                    lblmessage.Text = "";
                                    Cursor = Cursors.Default;

                                }
                                catch (Exception ex)
                                {
                                    Cursor = Cursors.Default;
                                    MessageBox.Show(ex.Message);
                                }
                                lblmessage.Text = "Money was collected!";
//                                ============== Note : Report In here ===========
// ReSharper disable UseObjectOrCollectionInitializer
                                using (var thankFrm = new THANK_FRM())
                                {
                                    thankFrm.Left = 0;
//                                thank_FRM.Top = splitContainer1.Panel1.Height;
                                    thankFrm.Width = dataGridViewX1.Width;
                                    thankFrm.Height = dataGridViewX1.Height + 3;
                                    thankFrm.txtsubtotal.Text = cashin_FRM.txtsubtotal.Text;
                                    thankFrm.txtdiscount.Text = cashin_FRM.txtdiscount.Text;
                                    thankFrm.txtgtotald.Text = cashin_FRM.txtgtotald.Text;
                                    thankFrm.txtgtotalr.Text = cashin_FRM.txtgtotalr.Text;
                                    thankFrm.txtexchange.Text = cashin_FRM.txtexchange.Text;
                                    thankFrm.txtcashind.Text = string.Format("{0:0,0.00}",
                                                                             cashin_FRM.txtcashind.Text.Trim() == ""
                                                                                 ? 0
                                                                                 : Convert.ToDecimal(cashin_FRM.txtcashind.Text));
                                    thankFrm.txtcashinr.Text = string.Format("{0:0,0.00}",
                                                                             cashin_FRM.txtcashinr.Text.Trim() == ""
                                                                                 ? 0
                                                                                 : Convert.ToDecimal(
                                                                                       cashin_FRM.txtcashinr.Text));
                                    thankFrm.txtchanged.Text = cashin_FRM.txtchanged.Text;
                                    thankFrm.txtchanger.Text = cashin_FRM.txtchanger.Text;
                                    dataGridViewX1.Rows.Clear();
                                    lblTotal.Text = "0.00";
                                    thankFrm.ShowDialog();
                                }

//                                ======================= Note: In here Should have a message =========
//                                lblmessage.Text = "There are no data to be print!";
                                cashin_FRM.Close();
                                  
                                #endregion
                            }// ElseIf e.Alt = True And e.KeyCode = Keys.L And DataGridView1.RowCount = 0 Then
                            #region
//         
//           
//
//            ElseIf e.KeyCode = Keys.F11 Then
//                Dim RPT As DevExpress.XtraReports.UI.XtraReport = New BLANK_RPT
//                RPT.Print()
//            ElseIf e.Alt = True And e.KeyCode = Keys.F12 Then
//                
//            End If
//        End If
                            #endregion       
                        }
                    }
                }  // if (e.keyCode == Keys.F5)
                    #endregion

                    #region if(e.Alt == true && e.keycode == keys.f6)

                else if (e.Alt == true && e.KeyCode == Keys.F6)
                {
                    DD:
                    using (var securityFrm = new SECURITY_FRM { txtCode = { Text = UserLogOn.Code, Enabled = false } })
                    {
                        if (securityFrm.ShowDialog() == DialogResult.OK)
                        {
                            var dtUser = dataManager.GetData("SELECT * FROM SIPUSERS ", "USER_CODE", "USER_CODE", securityFrm.txtCode.Text.Trim());
                            if (dtUser.Rows.Count > 0)
                            {
                                if (System.Text.Encoding.UTF32.GetString((byte[])dtUser.Rows[0][2]).CompareTo(securityFrm.txtPass.Text) != 0)
                                {
                                    MessageBox.Show("Your password was not recognized. Please check and try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    securityFrm.txtPass.Focus();
                                    goto DD;
                                }
                            }
                            else
                                goto DD;
                            securityFrm.Close();
                        }
                        else
                        {
                            securityFrm.Close();
                            return;
                        }
                    }
                    using (var terminal_FRM = new TERMINAL_FRM())
                    {
                        terminal_FRM.txtLocCode.Text = SITempData.Loc_Code_POS;
                        var condition = new string[] { "LOC_CODE", SITempData.Loc_Code_POS };
                        terminal_FRM.txtLocDesc.Text = DataAccess.ReturnField("SELECT LOC_NAME FROM SIPLOCA", "LOC_NAME", condition, 0);
                        if (terminal_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            SITempData.Loc_Code_POS = terminal_FRM.txtLocCode.Text;
                            MessageBox.Show("Location have been changed successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            return;
                        terminal_FRM.Close();
                    }
                }
                    #endregion

                    #region e.KeyCode == Keys.F3 && dataGridViewX1.RowCount > 0
                else if (e.KeyCode == Keys.F3 && dataGridViewX1.RowCount > 0)
                {
                    if (IsSIAuto && SITempData.Loc_Code_POS.Trim() != "")
                    {
                        var salefree_FRM = new SALEFREE_FRM();
                        salefree_FRM.Top = splitContainer1.Panel1.Height + splitContainer3.Panel1.Height + 2;
                        salefree_FRM.Left = 0;
                        salefree_FRM.Height = splitContainer3.Panel2.Height;
                        salefree_FRM.Width = this.Width;
                        salefree_FRM.Label1.Left = Width/2 - salefree_FRM.Label1.Width/2;
                        salefree_FRM.Label1.Top = salefree_FRM.Height/2;
                        salefree_FRM.Label2.Left = Width/2 - salefree_FRM.Label2.Width/2;
                        salefree_FRM.Label1.Text = "Waiting for barcode scan to remove item";
                        salefree_FRM.Label2.Text = "rg;caMkarbBa©Úlelx)akUdedIm,Ilub";
                        lblmessage.Text = "Scan item to remove, Esc to cancel.";
                        if (salefree_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            var i = SIDataGridView.CheckOnGrid(dataGridViewX1, salefree_FRM.code, 7);
                            var h = 0;
                            var D = 0;
                            while (i != -1)
                            {
                                for (int l = dataGridViewX1.Rows.Count-1 ; l > 0; l--)
                                {
                                    
                                    dataGridViewX1.Rows[D].Cells[1].Value = string.Format("{0:000}", l);
                                    D++;
                                }
                                dataGridViewX1.Rows.RemoveAt(i);
                                h = 1;
                                i = SIDataGridView.CheckOnGrid(dataGridViewX1, salefree_FRM.code, 7);

                                // NOTE :  Remove from  xml flash Banner 
//                                dataManager.Delete(datatable, strCode);
//                                xmlfla.Write(string.Format(@"{0}\Flash\move_to_framenumber.xml", Application.StartupPath), datatable);
//                                var j = k - 1;
//                                var pathFile = string.Format(@"{0}\Flash\SlideBar.swf", Application.StartupPath);
//                                if (File.Exists(pathFile))
//                                {
//                                    File.Move(string.Format(@"{0}\Flash\SlideBar.swf", Application.StartupPath), string.Format(@"{0}\Flash\{1}.swf", Application.StartupPath, k.ToString()));
//                                }
//                                else
//                                {
//                                    File.Move(string.Format(@"{0}\Flash\{1}.swf", Application.StartupPath, j.ToString()), string.Format(@"{0}\Flash\{1}.swf", Application.StartupPath, k.ToString()));
//                                }
//
//                                var st = string.Format(@"{0}\Flash\{1}.swf", Application.StartupPath, k.ToString());
//                                axShockwaveFlash2.LoadMovie(0, st);
//
//                                k++;
                            }
                            lblTotal.Text = string.Format("{0:0,0.00}", SIDataGridView.Sum(dataGridViewX1, 6));
                            if (h>0)
                            {
                                lblmessage.Text = "Item have been removed successfully.";
                            }
                            else
                            {
                                lblmessage.Text = "There are no item remove.";
                            }
                        }
                        else
                        {
                            lblmessage.Text = "Remove was cancel.";
                        }


                    }
                }  // end If (e.KeyCode == Keys.F3 && DataGridView1.RowCount > 0 )
                    #endregion

                    #region if(e.keycode == keys.f2)
                else if(e.KeyCode == Keys.F2)
                {
                    if (IsSIAuto && SITempData.Loc_Code_POS != "")
                    {
                        if (UserLogOn.Code.Trim() == "")
                        {
                            Sound.Beep(500, 100);
                            lblmessage.Text = "Please press Alt+F6 to change terminal";
                            return;
                        }
                        var salefree_FRM = new SALEFREE_FRM();
                        salefree_FRM.Top = splitContainer1.Panel1.Height + splitContainer3.Panel1.Height;
                        salefree_FRM.Left = 0;
                        salefree_FRM.Height = splitContainer3.Panel2.Height;
                        salefree_FRM.Width = this.Width;
                        salefree_FRM.Label1.Left = Width/2 - salefree_FRM.Label1.Width/2;
                        salefree_FRM.Label1.Top = salefree_FRM.Height/2;
                        salefree_FRM.Label2.Left = Width / 2 -salefree_FRM.Label2.Width/2;
                        salefree_FRM.Label2.Top = salefree_FRM.Height/2 - salefree_FRM.Label2.Height;
                        salefree_FRM.Label1.Text = "Waiting for barcode scan to sale for free";
                        salefree_FRM.Label2.Text = "rg;caMkarbBa©Úlelx)akUdedIm,Ilk;edayminKitéfø";
                        lblmessage.Text = "Scan item to sale for free, Esc to cancel.";
                        if (salefree_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            try
                            {
                                Cursor = Cursors.WaitCursor;
                                var dtItem = new DataTable();
                                var command = new SqlCommand("SELECT ITEM_CODE,ITEM_BCODE,ITEM_DESC,ITEM_CUS9_KH,UNIT_STOCK, UNIT_SALE,ITEM_TYPE,0 ITEM_PRICE1 FROM SIPITEMS WHERE ITEM_BCODE=@ITEM_BCODE", connection.Connect());
                                ;
                                command.Parameters.AddWithValue("@ITEM_BCODE", salefree_FRM.code);
                                var dataAdapter = new SqlDataAdapter(command);
                                dataAdapter.Fill(dtItem);
                                if (dtItem.Rows.Count > 0)
                                {
                                    UPDATE_STOCK_STATUS = dtItem.Rows[0][6].ToString();
//                                        'If UPDATE_STOCK_STATUS = "S" Then
//                                '    Dim ON_ORDER, PHYSICAL, FREE As Decimal : ON_ORDER = ITEM_INVENTORY("O", LOC_CODE, TBL.Rows(0)(0))
//                                '    PHYSICAL = ITEM_INVENTORY("P", LOC_CODE, TBL.Rows(0)(0))
//                                '    FREE = PHYSICAL - ON_ORDER
//                                '    If FREE < (1 + FormatBack(SumGrid(DataGridView1, 11, TBL.Rows(0)(0), 0), DECIMALSEP, THOUSANDSEP)) Then
//                                '        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
//                                '        Me.Cursor = Cursors.Default
//                                '        lblmessage.Text = "Item " & DBNULLVALUE(TBL.Rows(0)(1)) & " is out of stock!"
//                                '        Exit Sub
//                                '    End If
//                                'End If
                                    var i = SIDataGridView.CheckOnGrid(dataGridViewX1, dtItem.Rows[0][0], 0,"00.00", 4,
                                                                       dtItem.Rows[0][5], 10);
                                    var condition = new[] { "CONV_FROM", dtItem.Rows[0][5].ToString(), "CONV_TO", dtItem.Rows[0][4].ToString() };
                                    var operate =
                                        DataAccess.ReturnField(
                                            "SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV ",
                                            "CONV_FROM", condition, 2);
                                    var factor = Convert.ToDecimal(DataAccess.ReturnField(
                                                                       "SELECT CONV_FROM [Unit Sale], CONV_F_DESC [Description],OPERATOR,FACTOR,CONV_F_DESCKH [Khmer] FROM dbo.SIUNITCONV ",
                                                                       "CONV_FROM", condition, 3));
                                    var unitStockQty = "";
                                    if (operate == "*")
                                    {
                                        unitStockQty = string.Format("{0:0,0.00}", Convert.ToDecimal(1) * factor);
                                    }
                                    else
                                    {
                                        unitStockQty = string.Format("{0:0,0.00}", Convert.ToDecimal(1) / factor);
                                    }

                                    if (i == -1)
                                    {
                                        dataGridViewX1.Rows.Insert(0,dtItem.Rows[0][0],string.Format("{0:000}",dataGridViewX1.RowCount + 1),
                                                                   dtItem.Rows[0][2] + " - " + dtItem.Rows[0][5],dtItem.Rows[0][3],string.Format("{0:0,0.00}",dtItem.Rows[0][7]),
                                                                   string.Format("{0:n}", 1), string.Format("{0:0,0.00}", Convert.ToDecimal(dtItem.Rows[0][7]) * 1),
                                                                   salefree_FRM.code,"0","0",dtItem.Rows[0][5],unitStockQty,dtItem.Rows[0][6]);
                                    }
                                    else
                                    {
                                        dataGridViewX1.Rows[i].Cells[5].Value = string.Format("{0:n}",
                                                                                              Double.Parse(dataGridViewX1.Rows[i].Cells[5].Value.ToString()) + 1);
                                        dataGridViewX1.Rows[i].Cells[6].Value = string.Format("{0:0,0.00}",
                                                                                              Double.Parse(
                                                                                                  dataGridViewX1.Rows[i]
                                                                                                      .Cells[6].Value.
                                                                                                      ToString()) +
                                                                                              1*
                                                                                              Double.Parse(
                                                                                                  dtItem.Rows[0][7].
                                                                                                      ToString()));
                                        dataGridViewX1.Rows[i].Cells[11].Value = string.Format("{0:0,0.00}",
                                                                                               Double.Parse(
                                                                                                   dataGridViewX1.Rows[i
                                                                                                       ].Cells[11].Value
                                                                                                       .ToString()) + 1);
                                        dataGridViewX1.Rows[0].Cells[1].Selected = true;
                                        lblTotal.Text = string.Format("{0:0,0.00}",
                                                                      SIDataGridView.Sum(dataGridViewX1, 6));
                                    }

                                }
                                else
                                {
                                    // ========= Note : Not Clear about audit
//                                      AUDIT(Now, LOC_CODE_POS, SALEFREE_FRM.Code)
                                    lblmessage.Text = "Item " + salefree_FRM.code + " is not found!";
                                    Sound.Beep(500, 100);
                                }
                                Cursor = Cursors.Default;
                            }
                            catch (Exception ex)
                            {
                                Cursor = Cursors.Default;
                                lblmessage.Text = ex.Message;
                            }
                            lblmessage.Text = "Insert sale for free successully!";
                        }
                        else
                        {
                            lblmessage.Text = "Sale for free was cancel...";
                        }
                    }
                } //end if(e.KeyCode == Keys.F2)
                    #endregion

                    #region if (e.keycode == keys.f1)
                else if(e.KeyCode == Keys.F1)
                {
                    var helppos_FRM = new HELPPOS_FRM();
                    helppos_FRM.Top = splitContainer1.Panel1.Height + 5;
                    helppos_FRM.Left = 0;
                    helppos_FRM.Height = splitContainer3.Panel2.Height + splitContainer3.Panel1.Height;
                    helppos_FRM.Width = this.Width;
                    helppos_FRM.Label1.Left = this.Width/2 - helppos_FRM.Label1.Width/2;
                    helppos_FRM.Label1.Top = helppos_FRM.Height/2;
                    helppos_FRM.ShowDialog();
                }    // end if (e.keycode == keys.f1)
                    #endregion

                    #region if(e.Alt == true && e.KeyCode == Keys.L && datagridViewx1.RowCount == 0)

                else if(e.Alt == true && e.KeyCode ==Keys.L && dataGridViewX1.RowCount == 0)
                {
                    try
                    {
                        ISLOG_OFF = true;
                        var command =
                            new SqlCommand(
                                "UPDATE SIPUSERS SET USER_LOG=@USER_LOG WHERE USER_CODE=@USER_CODE",
                                connection.Connect());
                        Commands.CreateParameter(command, "USER_CODE", UserLogOn.Code, "USER_LOG",
                                                 System.Text.Encoding.UTF32.GetBytes("U"));
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        Close();
                        var security_FRM = new SECURITY_FRM();
                        DD:
                        if (security_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            var dtUser = dataManager.GetData("SELECT * FROM SIPUSERS ", "USER_CODE", "USER_CODE",
                                                             security_FRM.txtCode.Text.Trim());
                            if (dtUser.Rows.Count > 0)
                            {
                                if (
                                    System.Text.Encoding.UTF32.GetString((byte[]) dtUser.Rows[0][2]).CompareTo(
                                        security_FRM.txtPass.Text) != 0)
                                {
                                    MessageBox.Show("Your password was not recognized. Please check and try again.",
                                                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    security_FRM.txtPass.Focus();
                                    goto DD;
                                }
                            }
                            else
                            {
                                goto DD;
                            }
                            security_FRM.Close();
                            POINTOFSALE_FRM pointofsaleFrm = new POINTOFSALE_FRM();
                            pointofsaleFrm.ShowDialog();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
//                     
                } // 

                    #endregion

                    #region  if(e.Keycode == f7)
                else if(e.KeyCode == Keys.F7)  //=======  Sale By unit
                {
                    if (IsSIAuto && SITempData.Loc_Code_POS == "")
                    {
                        if (UserLogOn.Code =="")
                        {
                            lblmessage.Text = "Please press Alt+F6 to change termimal";
                            return;
                        } 
                    }
                    var salecase_FRM = new SALECASE_FRM();
                    salecase_FRM.Top = this.Height/2 - splitContainer3.Panel2.Height + splitContainer1.Panel1.Height;
                    salecase_FRM.Left = dataGridViewX1.Width/2 - salecase_FRM.Width/2;
                    lblmessage.Text = "Press Esc to cancel....";
                    OS:
                    if (salecase_FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var i = SIDataGridView.CheckOnGrid(dataGridViewX1, salecase_FRM.item_Code, 0,salecase_FRM.txtPrice.Text, 4,
                                                           salecase_FRM.txtUnitOfSale.Text, 10);
                        if (i == -1)
                        {
//                                       
                            dataGridViewX1.Rows.Insert(0, salecase_FRM.item_Code,
                                                       string.Format("{0:000}", dataGridViewX1.RowCount + 1),
                                                       salecase_FRM.txtName.Text + " - " +
                                                       salecase_FRM.txtUnitOfSale.Text, salecase_FRM.item_Kh,
                                                       string.Format("{0:0,0.00}",
                                                                     Convert.ToDecimal(
                                                                         salecase_FRM.txtPrice.Text)),
                                                       string.Format("{0:n}",salecase_FRM.txtQty.Text),
                                                       string.Format("{0:0,0.00}",
                                                                     Convert.ToDecimal(
                                                                         salecase_FRM.txtPrice.Text)*
                                                                     Convert.ToDecimal(
                                                                         salecase_FRM.txtQty.Text)),
                                                       salecase_FRM.txtBarcode.Text, salecase_FRM.pro_Rate,
                                                       salecase_FRM.txtDiscount.Text, salecase_FRM.txtUnitofStock.Text,
                                                       string.Format("{0:0,0.00}",Convert.ToDecimal(salecase_FRM.SQty)),
                                                       salecase_FRM.item_Type);
                        }
                        else
                        {
                            dataGridViewX1.Rows[i].Cells[5].Value = string.Format("{0:n}",
                                                                                  Double.Parse(dataGridViewX1.Rows[i].Cells[5].Value.ToString()) + Double.Parse(salecase_FRM.txtQty.Text));
                            dataGridViewX1.Rows[i].Cells[6].Value = string.Format("{0:0,0.00}",
                                                                                  Decimal.Parse(
                                                                                      dataGridViewX1.Rows[i]
                                                                                          .Cells[6].Value.
                                                                                          ToString()) + Decimal.Parse(salecase_FRM.txtAmount.Text));
                            dataGridViewX1.Rows[i].Cells[9].Value = string.Format("{0:0,0.00}",
                                                                                  Convert.ToDecimal(
                                                                                      dataGridViewX1.Rows[i]
                                                                                          .Cells[9].Value) +
                                                                                  Decimal.Parse(
                                                                                      salecase_FRM.
                                                                                          txtDiscount.Text));
                            dataGridViewX1.Rows[i].Cells[11].Value = string.Format("{0:0,0.00}",
                                                                                   Decimal.Parse(
                                                                                       dataGridViewX1.Rows[i
                                                                                           ].Cells[11].Value
                                                                                           .ToString()) + salecase_FRM.SQty);
                            dataGridViewX1.Rows[0].Cells[1].Selected = true;
                            lblTotal.Text = string.Format("{0:0,0.00}",
                                                          SIDataGridView.Sum(dataGridViewX1, 6));
                        }
                        dataGridViewX1.Rows[0].Cells[1].Selected = true;
                        lblTotal.Text = string.Format("{0:0,0.00}", SIDataGridView.Sum(dataGridViewX1, 6));
                    }
                }

                    #endregion

                    #region if (e.keyCode == keys.f10)
                else if(e.KeyCode == Keys.F10)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        var checkstock_FRM = new CHECKSTOCK_FRM();
                        checkstock_FRM.ShowDialog();
                        Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion
            }
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}