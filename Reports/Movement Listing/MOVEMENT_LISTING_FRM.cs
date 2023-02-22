using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using POS.DataLayer;
using POS.GUI;
using POS.Transaction;
using POS.Transaction.Inventory;
using POS.Utilities;

namespace POS.Reports.Movement_Listing
{
    public partial class MOVEMENT_LISTING_FRM : Form
    {
        public MOVEMENT_LISTING_FRM()
        {
            InitializeComponent();
        }

        #region global variable

        readonly DropDownList downList = new DropDownList();
        readonly DataManager dataManager = new DataManager();
        DataTable dt = new DataTable();

        #endregion

        private void btnFormat_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 45;
            downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Movement Listing'", txtFormatCode, this, droplistFrm, btnFormat, i, 2);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtFormatCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtFormatDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
            }
        }

        private void txtFormatCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txtFormatCode.Text != "")
                {
                    var dt = dataManager.GetData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE UPPER(REP_CODE) LIKE UPPER('" + txtFormatCode.Text + "%') AND REP_TYPE = 'Movement Listing'");
                    if (dt.Rows.Count > 0)
                    {
                        txtFormatCode.Text = dt.Rows[0][0].ToString();
                        txtFormatDesc.Text = dt.Rows[0][1].ToString();
                        txtMovTypeFrom.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Not found code '" + txtFormatCode.Text + "'", "Not Found", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        txtFormatCode.SelectAll();
                        txtFormatCode.SelectionStart = 0;
                        txtFormatCode.SelectionLength = txtFormatCode.Text.Length;
                        txtFormatCode.Focus();
                        return;
                    }

                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                Int16 i = 45;
                downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Movement Listing'", txtFormatCode, this, droplistFrm, btnFormat, i, 2);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtFormatCode.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtFormatDesc.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();

                }

            }
        }

        private void MOVEMENT_LISTING_FRM_Load(object sender, EventArgs e)
        {
            dt = dataManager.Create("TranType", "Description", "Note");
            dataManager.Save(dt, "ADJ-", "Reduce Stock", "R");
            dataManager.Save(dt, "ADJ+", "Addjustment Stock", "I");
            dataManager.Save(dt, "OB", "Opening Balance", "O");
            dataManager.Save(dt, "EPXR", "Expired Stock", "R");
            dataManager.Save(dt, "LOSS", "Loss Stock", "R");
           
        }

        private void btnMovTypeFrom_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 47;
            downList.BindingData(dt,txtMovTypeFrom,this,droplistFrm,btnMovTypeFrom,i,2);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtMovTypeFrom.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtMovDescFrom.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtMovTypeTo.Focus();
            }
        }

        private void txtMovTypeFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var qeury = from s in dt.AsEnumerable()
                            where s.Field<string>("TranType").Contains(txtMovTypeFrom.Text.ToUpper())
                            select s;
                if (qeury.Count() == 0)
                {
                    MessageBox.Show("Movement type '" + txtMovTypeFrom.Text + "' not found!", "Not Found",MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtMovTypeFrom.SelectionStart = 0;
                    txtMovTypeFrom.SelectionLength = txtMovTypeFrom.Text.Length;
                    txtMovTypeFrom.Focus();
                }

                foreach (var type in qeury)
                {
                    txtMovTypeFrom.Text = type[0].ToString();
                    txtMovDescFrom.Text = type[1].ToString();
                    txtMovTypeTo.Focus();
                }             

            }
            else if(e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                Int16 i = 47;
                downList.BindingData(dt, txtMovTypeFrom, this, droplistFrm, btnMovTypeFrom, i, 2);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtMovTypeFrom.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtMovDescFrom.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                    txtMovTypeTo.Focus();
                }
            }
        }

        private void btnMovTypeTo_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 47;
            downList.BindingData(dt, txtMovTypeTo, this, droplistFrm, btnMovTypeTo, i, 2);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtMovTypeTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtMovDescTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtMovTypeTo.Focus();
            }
        }

        private void txtMovTypeTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var qeury = from s in dt.AsEnumerable()
                            where s.Field<string>("TranType").Contains(txtMovTypeTo.Text.ToUpper())
                            select s;
                if (qeury.Count() == 0)
                {
                    MessageBox.Show("Movement type '" + txtMovTypeTo.Text + "' not found!", "Not Found", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtMovTypeTo.SelectionStart = 0;
                    txtMovTypeTo.SelectionLength = txtMovTypeTo.Text.Length;
                    txtMovTypeTo.Focus();
                }

                foreach (var type in qeury)
                {
                    txtMovTypeTo.Text = type[0].ToString();
                    txtMovDescTo.Text = type[1].ToString();
                    txtMovTypeTo.Focus();
                }

            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                Int16 i = 47;
                downList.BindingData(dt, txtMovTypeTo, this, droplistFrm, btnMovTypeTo, i, 2);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtMovTypeTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txtMovDescTo.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                    txtMovTypeTo.Focus();
                }
            }
        }

        private void txtMovRefFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Condition.EmptyControl(txtMovRefFrom))
                {
                    txtMovRefTo.Focus();
                }
            }
        }

        private void txtMovRefTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMovRefTo.Text != "")
                {
                    dtDateFrom.Focus();
                }
            }
        }

        private void dtDateFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtDatTo.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtDatTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPreview.Focus();
            }

        }

        private void btnUnitReport_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 47;
            downList.BindingData("SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP'", txtUnitReport, this, droplistFrm, btnUnitReport, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtUnitReport.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
            }
        }

        private void txtUnitReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUnitReport.Text != "")
                {
                    var dt =
                        dataManager.GetData(
                            "SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP' AND UPPER(SI_CODE) LIKE UPPER('" +
                            txtUnitReport.Text + "%')");
                    if (dt.Rows.Count > 0)
                    {
                        txtUnitReport.Text = dt.Rows[0][0].ToString();
                        btnPreview.Focus();
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                Int16 i = 47;
                downList.BindingData("SELECT SI_CODE,SUBSTRING(SI_DATA,0,100) as Descr  FROM SIPDATA WHERE SI_LOOKUP = '' AND SI_TYPE = 'UCREP'", txtUnitReport, this, droplistFrm, btnUnitReport, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txtUnitReport.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    btnPreview.Focus();
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string movType = "1";
            string movRef = "1";
            var report = new Report();
            if (txtMovTypeTo.Text == "" && txtMovTypeFrom.Text == "")
            {
                movType = "";
            }
            if (txtMovRefTo.Text == "" && txtMovRefFrom.Text == "")
            {
                movRef = "";
            }
           var dt = dataManager.GetData_Proc("SI_SELECT_MOVEMENT_LISTING", "REP", "1", "REPTYPE", txtUnitReport.Text, "MOV",
                                     movType, "MOVFROM", txtMovRefFrom.Text, "MOVTO", txtMovRefTo.Text, "DATEFROM",
                                     string.Format("{0:MM/dd/yyyy}",dtDateFrom.Value), "DATETO", string.Format("{0:MM/dd/yyyy}",dtDatTo.Value),
                                     "MOVREF", movRef, "MOV_TYPE_FROM", txtMovTypeFrom.Text, "MOV_TYPE_TO", txtMovTypeTo.Text);
            report.Preview("Movement Listing",dt);
        }
    }
}
