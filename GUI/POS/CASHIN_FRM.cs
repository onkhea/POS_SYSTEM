using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Utilities;

namespace POS.GUI.POS
{
    public partial class CASHIN_FRM : Form
    {
        public CASHIN_FRM()
        {
            InitializeComponent();
        }

        private Controls controls = new Controls();
        SIFormats formats = new SIFormats();

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
//            var pos_FRM = new POS_FRM();
//           if(pos_FRM.dataGridViewX1.RowCount > 999)
//           {
//               pos_FRM.lblmessage.Text = "Exceed maximum line number of sales!";
//               return;
//           }
            var exchange = Convert.ToDecimal(txtexchange.Text);
            var AmountP = Convert.ToDecimal(txtgtotalr.Text);
            Decimal AmtTmp = 0;
            Decimal CinD = 0;
            Decimal CInR = 0; 
            var strings = new Strings();

            if (strings.IsNumeric(txtcashinr.Text))
            {
                CInR = Convert.ToDecimal(txtcashinr.Text);
                if (CInR % 100 != 0)
                {
                    return;
                }
            }
            CinD = txtcashind.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtcashind.Text);
            if((AmountP * exchange) - Convert.ToDecimal(txtgtotalr.Text) > 0 )
            {
                AmountP = AmountP - (((AmountP*exchange) - Convert.ToDecimal(txtgtotalr.Text)/exchange));
            }
            AmtTmp = (CinD + CInR/exchange) - AmountP;
            if(AmtTmp < 0)
            {
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void txtcashind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                SelectNextControl(txtcashind, true, true, true, true);
               
            }
            else if (e.KeyChar == (char) 27)
            {
                Close();
            }
            
        }

        private void txtcashinr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                SelectNextControl(txtcashinr, true, true, true, true);
                Button2_Click(null,null);
            }
            else if (e.KeyChar == (char)27)
            {
                Close();
            }
        }

        private void txtcashind_TextChanged(object sender, EventArgs e)
        {
            Strings strings = new Strings();
            var CashInd = txtcashind.Text == "" ? "0" : txtcashind.Text;
            if (strings.IsDecimal(CashInd))
            {
                var exchange = Convert.ToDecimal(txtexchange.Text);
                var AmountPrice = Convert.ToDecimal(txtgtotald.Text);
                Decimal AmtTemp = 0;
                Decimal CInD = 0;
                Decimal CinR = 0;
                if (strings.IsNumeric(txtcashinr.Text))
                {
                    CinR = Convert.ToDecimal(txtcashinr.Text);
                }
                CInD = Convert.ToDecimal(CashInd);
                AmtTemp = CInD - AmountPrice;
                var x = AmtTemp.ToString().Split((char)46);
                if (AmtTemp > 0)
                {
                    if (x.Length == 1)
                    {
                        txtchanged.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(x[0]));
                        txtchanger.Text = CinR.ToString();
                    }
                    else
                    {
                        txtchanged.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(x[0]));
                        txtchanger.Text = Convert.ToString(CinR + Math.Round(Convert.ToDecimal("0." + x[1])*exchange));
                    }
                }
                else if(AmtTemp == 0)
                {
                    txtchanged.Text = string.Format(formats.PO_Format, AmtTemp);
                    txtchanger.Text = CinR.ToString();
                }
                else
                {
                    if (x.Length == 1)
                    {
                        txtchanged.Text = string.Format(formats.PO_Format, Convert.ToDecimal(x[0]));
                        txtchanger.Text = CinR.ToString();
                    }
                    else
                    {
                        txtchanged.Text = string.Format(formats.PO_Format, Convert.ToDecimal(x[0]));
                       if(CinR + Math.Round(Convert.ToDecimal("0." + x[1])*exchange) == 0 )
                       {
                           txtchanger.Text = Convert.ToString(CinR + Math.Round(Convert.ToDecimal("0." + x[1])*exchange));
                       }
                       else
                       {
                           txtchanger.Text = Convert.ToString(CinR + Math.Round(Convert.ToDecimal("0." + x[1]) * exchange) * -1);   
                       }
                    }
                }
                if (Convert.ToDecimal(txtchanger.Text) >= exchange)
                {
                    var splitDR = Convert.ToDecimal(txtchanger.Text)/exchange;
                    var y = splitDR.ToString().Split((char) 46);
                    if (y.Length == 1)
                    {
                        txtchanged.Text = string.Format(formats.PO_Format,
                                                        Convert.ToDecimal(x[0]) + Convert.ToDecimal(y[0]));
                        txtchanger.Text = string.Format(formats.PO_Format, 0);
                    }
                    else
                    {
                        txtchanged.Text = string.Format(formats.PO_Format,
                                                       Convert.ToDecimal(x[0]) + Convert.ToDecimal(y[0]));
                        txtchanger.Text = string.Format("{0:0,0}", Convert.ToDecimal("0." + y[1])*exchange);
                    }
                }
                else
                {
                    txtchanger.Text = string.Format("{0:0,0}", Convert.ToDecimal(txtchanger.Text));
                }
                if (Convert.ToDecimal(txtchanger.Text) > 0)
                {
                    if (Convert.ToDecimal(txtchanger.Text) % 100 > 50)
                    {
                        txtchanger.Text =
                            Convert.ToString(Convert.ToDecimal(txtchanger.Text) -
                                             (Convert.ToDecimal(txtchanger.Text)%100) + 100);
                    }
                    else
                    {
                        txtchanger.Text =
                            Convert.ToString(Convert.ToDecimal(txtchanger.Text) -
                                             (Convert.ToDecimal(txtchanger.Text)%100));
                    }
                }
                else
                {
                    if(Convert.ToDecimal(txtchanger.Text) % 100 >= -5)
                    {
                        txtchanger.Text =
                            Convert.ToString(Convert.ToDecimal(txtchanger.Text) - Convert.ToDecimal(txtchanger.Text)%100);
                    }
                    else
                    {
                        txtchanger.Text =
                            Convert.ToString(Convert.ToDecimal(txtchanger.Text) -
                                             (Convert.ToDecimal(txtchanger.Text)%100) - 100);
                    }
                }
            }
            else
            {
                txtcashind.Text = txtcashind.Text.Substring(0, txtcashind.Text.Length - 1);
                txtcashind.SelectionStart = txtcashind.Text.Length;
            }
        }

        private void txtcashinr_TextChanged(object sender, EventArgs e)
        {
            Strings strings = new Strings();
            var cashInr = txtcashinr.Text == "" ? "0" : txtcashinr.Text;
            if(strings.IsNumeric(cashInr))
            {
                var AmountPrice = Convert.ToDecimal(txtgtotald.Text);
                var exchange = Convert.ToDecimal(txtexchange.Text);
                var changer = Convert.ToDecimal(txtchanger.Text);
                Decimal AmtTemp = 0;
                Decimal CInD = 0;
                Decimal CinR = 0;
                if (strings.IsNumeric(txtcashind.Text))
                {
                    CInD = Convert.ToDecimal(txtcashind.Text);
                }
                CinR = Convert.ToDecimal(cashInr);
                AmtTemp = CInD - AmountPrice;
                 var x = AmtTemp.ToString().Split((char)46);
                if (AmtTemp == 0)
                {
                    txtchanged.Text = string.Format(formats.PO_Format, AmtTemp);
                    txtchanger.Text = CinR.ToString();
                }
                else if (AmtTemp > 0)
                {
                    if (x.Length == 1)
                    {
                        txtchanged.Text = string.Format(formats.PO_Format, Convert.ToDecimal(x[0]));
                        txtchanger.Text = CinR.ToString();
                    }
                    else
                    {
                        txtchanged.Text = string.Format(formats.PO_Format, Convert.ToDecimal(x[0]));
                        txtchanger.Text = Convert.ToString(CinR + Math.Round(Convert.ToDecimal("0." + x[0])*exchange));
                    }
                }
                else
                {
                    if (x.Length == 1)
                    {
                        txtchanged.Text = string.Format(formats.PO_Format, Convert.ToDecimal(x[0]));
                        txtchanger.Text = CinR.ToString();
                    }
                    else
                    {
                        txtchanged.Text = string.Format(formats.PO_Format, Convert.ToDecimal(x[0]));
                        if (CinR + Math.Round(Convert.ToDecimal("0." + x[1]) * exchange) == 0)
                        {
                            txtchanger.Text = Convert.ToString(CinR + Math.Round(Convert.ToDecimal("0." + x[1]) * exchange));
                        }
                        else
                        {
                            txtchanger.Text = Convert.ToString(CinR + Math.Round(Convert.ToDecimal("0." + x[1]) * exchange) * -1);
                            var d = Math.Round(Convert.ToDecimal("0." + x[1]));
                            var dd =d;
                        }
                    }
                    if (Convert.ToDecimal(txtchanger.Text) > 0)
                    {
                        var d = Convert.ToDecimal(txtchanger.Text)%100;
                        if (Convert.ToDecimal(txtchanger.Text) % 100 > 50)
                        {
                            changer = Convert.ToDecimal(txtchanger.Text) -
                                      (Convert.ToDecimal(txtchanger.Text)%100 + 100);
                        }
                        else
                        {
                            changer = Convert.ToDecimal(txtchanger.Text) - (Convert.ToDecimal(txtchanger.Text)%100);
                        }
                    }
                    else
                    {
                        if (Convert.ToDecimal(txtchanger.Text) % 100 > -50)
                        {
                            changer = Convert.ToDecimal(txtchanger.Text) - (Convert.ToDecimal(txtchanger.Text)%100);
                        }
                        else
                        {
                            changer = Convert.ToDecimal(txtchanger.Text) - (Convert.ToDecimal(txtchanger.Text)%100) -
                                      100;
                        }
                    }
                    if (changer >= exchange)
                    {
                        Decimal splitDrR = changer/exchange;
                        var Y = splitDrR.ToString().Split((char) 46);
                        if (Y.Length == 1)
                        {
                            txtchanged.Text = string.Format(formats.PO_Format, Convert.ToDecimal(x[0]) + Convert.ToDecimal(Y[0]));
                            txtchanger.Text = string.Format(formats.PO_Format, 0);
                        }
                        else
                        {
                            txtchanged.Text = string.Format(formats.PO_Format,
                                                            Convert.ToDecimal(x[0]) + Convert.ToDecimal(Y[0]));
                            txtchanger.Text = string.Format(formats.PO_Format, Convert.ToDecimal("0." + Y[1])*exchange);
                                
                        }
                    }
                    else
                    {
                        txtchanger.Text = string.Format(formats.PO_Format, Convert.ToDecimal(txtchanger.Text));
                    }
                    if (strings.IsNumeric(txtchanger.Text))
                    {
                        if (Convert.ToDecimal(txtchanger.Text) > 0)
                        {
                            if (Convert.ToDecimal(txtchanger.Text) % 100 > 50)
                            {
                                txtchanger.Text =
                                    Convert.ToString(Convert.ToDecimal(txtchanger.Text) -
                                                     (Convert.ToDecimal(txtchanger.Text) % 100) + 100);
                            }
                            else
                            {
                                txtchanger.Text =
                                    Convert.ToString(Convert.ToDecimal(txtchanger.Text) -
                                                     (Convert.ToDecimal(txtchanger) % 100));
                            }    
                        }
                        else
                        {
                            if (Convert.ToDecimal(txtchanger.Text) % 100 > -50)
                            {
                                txtchanger.Text =
                                    Convert.ToString(Convert.ToDecimal(txtchanger.Text) -
                                                     (Convert.ToDecimal(txtchanger.Text)%100));
                            }
                            else
                            {
                                txtchanger.Text =
                                    Convert.ToString(Convert.ToDecimal(txtchanger.Text) -
                                                     (Convert.ToDecimal(txtchanger.Text)%100) - 100);
                                     
                            }
                        }
                    }
                }
            }
        }

        private void CASHIN_FRM_Load(object sender, EventArgs e)
        {
                controls.Only_Number_On_Control(txtcashinr);
        }

    }
}
