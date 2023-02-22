using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction.Maintains;
using POS.Utilities;

namespace POS.GUI.Maintains
{
    public partial class EXHCNANGERATE_FRM : DevComponents.DotNetBar.Office2007Form
    {
        SIExchangeRate exchangeRate = new SIExchangeRate();
        Controls control = new Controls();
        private bool IsUpdateWar = false;
        Strings strings = new Strings();
        DataManager dataManager = new DataManager();

        public EXHCNANGERATE_FRM()
        {
            InitializeComponent();
        }

        private void EXHCNANGERATE_FRM_Load(object sender, EventArgs e)
        {
            try
            {
                control.AddEventHandler(DTPDATE,txtExchange,txtdesc);
                control.Add_ListView(exchangeRate.LoadData(),Lvw);
                UseWaitCursor = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            Lvw.Enabled = true;
            DTPDATE.Enabled = true;
            control.ClearControl(txtExchange,txtdesc);
            DTPDATE.Focus();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if( Condition.EmptyControl(txtExchange)) return;
                if (!strings.IsNumeric(txtExchange.Text)) return;
                {
                    if (IsUpdateWar == false)
                    {
                        var value = new string[] { "EX_DATE",DTPDATE.Value.ToShortDateString()};
                        if (dataManager.Exists("SIPOSRATE",value))
                        {
                            MessageBox.Show("This date have exchange rate already.");
                            return;
                        }
                        var val = new string[] {DTPDATE.Value.ToShortDateString(),txtExchange.Text,txtdesc.Text};
                        exchangeRate.Save(val);
                        control.Add_ListView(Lvw,3,DTPDATE.Value.ToShortDateString(),txtExchange.Text,txtdesc.Text);
                   
                    }
                    else
                    {
                        var parAndVal = new string[] {txtExchange.Text, txtdesc.Text};
                        var condition = DTPDATE.Value.ToShortDateString();
                        exchangeRate.Update(parAndVal,condition);
                        control.Update_ListView(Lvw, DTPDATE.Value.ToShortDateString(),txtExchange.Text, txtdesc.Text);
                    }
                }
                IsUpdateWar = false;
                control.ClearControl(txtExchange, txtdesc);
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditToolStripButton1_Click(object sender, EventArgs e)
        {
            if (Lvw.SelectedItems.Count > 0)
            {
                IsUpdateWar = true;
                DTPDATE.Value = Convert.ToDateTime(Lvw.SelectedItems[0].SubItems[0].Text);
                DTPDATE.Enabled = false;
                txtExchange.Text = Lvw.SelectedItems[0].SubItems[1].Text;
                txtdesc.Text = Lvw.SelectedItems[0].SubItems[2].Text;
                txtExchange.Focus();
                Lvw.Enabled = false;
            }
        }

        private void DeleteToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Lvw.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to remove this item ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        var paramAndValue = new string[] { "EX_DATE", Lvw.SelectedItems[0].Text };
                        exchangeRate.Delete(paramAndValue);
                        var d = Lvw.SelectedItems[0].Index;
                        Lvw.Items.RemoveAt(Lvw.SelectedItems[0].Index);
                        Lvw.Focus();
                    }
                }
                IsUpdateWar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtdesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SaveToolStripButton_Click(sender,e);
            }
        }
    }
}
