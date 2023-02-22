using System;
using System.Windows.Forms;
using POS.DataLayer;
using POS.GUI;
using POS.Transaction;

namespace POS.Reports.Movement_Listing
{
    public partial class INVENTORY_LISTING : Form
    {
        public INVENTORY_LISTING()
        {
            InitializeComponent();
        }

        readonly DropDownList _downList = new DropDownList();
        readonly DataManager _dataManager = new DataManager();

        private void btn_Item_codeF_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 48;
            _downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txt_Item_codeF, this, droplistFrm, btn_Item_codeF, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txt_Item_codeF.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txt_Item_codeT.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
            }
        }

        private void txt_Item_codeF_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txt_Item_codeF.Text != "")
                    {
                        var dt =
                            _dataManager.GetData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS WHERE UPPER(ITEM_CODE) LIKE UPPER('" +
                                                txt_Item_codeF.Text + "%') ORDER BY ITEM_CODE ASC ");
                        if (dt.Rows.Count > 0)
                        {
                            txt_Item_codeF.Text = dt.Rows[0][0].ToString();
                            txt_Item_codeT.Text = dt.Rows[0][0].ToString();
                            txt_Item_codeT.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Item code '" + txt_Item_codeF.Text + "' not found!", "Not Found",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Item_codeF.SelectionStart = 0;
                            txt_Item_codeF.SelectionLength = txt_Item_codeF.Text.Length;
                            return;
                        }
                    }
                }
                else if (e.KeyCode == Keys.F6)
                {
                    var droplistFrm = new DROPLIST_FRM();
                    const short i = 48;
                    _downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txt_Item_codeF, this, droplistFrm, btn_Item_codeF, i);
                    if (droplistFrm.ShowDialog() == DialogResult.OK)
                    {
                        txt_Item_codeF.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                        txt_Item_codeT.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    }
              
            }
        }

        private void btn_Item_codeT_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 48;
            _downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txt_Item_codeT, this, droplistFrm, btn_Item_codeT, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txt_Item_codeT.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txt_LocF.Focus();
            }
        }

        private void txt_Item_codeT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Item_codeT.Text != "")
                {
                    var dt =
                        _dataManager.GetData(
                            "SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS WHERE UPPER(ITEM_CODE) LIKE UPPER('" +
                            txt_Item_codeT.Text + "%') ORDER BY ITEM_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txt_Item_codeT.Text = dt.Rows[0][0].ToString();
                        txt_LocF.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Item code '" + txt_Item_codeT.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Item_codeT.SelectionStart = 0;
                        txt_Item_codeT.SelectionLength = txt_Item_codeT.Text.Length;
                        return;
                    }
                }

            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                const short i = 48;
                _downList.BindingData("SELECT ITEM_CODE,ITEM_DESC FROM SIPITEMS ORDER BY ITEM_CODE ASC ", txt_Item_codeT, this, droplistFrm, btn_Item_codeT, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txt_Item_codeT.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txt_LocF.Focus();
                }
            }
        }

        private void btn_locF_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 48;

            _downList.BindingData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA ORDER BY LOC_CODE ASC ", txt_LocF, this, droplistFrm, btn_locF, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txt_LocF.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txt_LocT.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
            }
        }

        private void txt_LocF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_LocF.Text != "")
                {
                    var dt =
                        _dataManager.GetData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA WHERE UPPER(LOC_CODE) LIKE UPPER('" +
                                            txt_LocF.Text + "%') ORDER BY LOC_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txt_LocF.Text = dt.Rows[0][0].ToString();
                        txt_LocT.Text = dt.Rows[0][0].ToString();
                        txt_LocT.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Location code '" + txt_LocF.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_LocF.SelectionStart = 0;
                        txt_LocF.SelectionLength = txt_LocF.Text.Length;
                        return;
                    }
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                var droplistFrm = new DROPLIST_FRM();
                const short i = 48;
                _downList.BindingData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA ORDER BY LOC_CODE ASC ", txt_LocF, this, droplistFrm, btn_locF, i);
                if (droplistFrm.ShowDialog() == DialogResult.OK)
                {
                    txt_LocF.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    txt_LocT.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                    
                }
            }
        }

        private void btn_locT_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const short i = 48;
            _downList.BindingData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA ORDER BY LOC_CODE ASC ", txt_LocT, this, droplistFrm, btn_locT, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txt_LocT.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                dtpFrom.Focus();
            }
        }

        private void txt_LocT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_LocT.Text != "")
                {
                    var dt =
                        _dataManager.GetData("SELECT LOC_CODE,LOC_NAME FROM SIPLOCA WHERE UPPER(LOC_CODE) LIKE UPPER('" +
                                            txt_LocT.Text + "%') ORDER BY LOC_CODE ASC ");
                    if (dt.Rows.Count > 0)
                    {
                        txt_LocT.Text = dt.Rows[0][0].ToString();
                        dtpFrom.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Location code '" + txt_LocT.Text + "' not found!", "Not Found",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_LocT.SelectionStart = 0;
                        txt_LocT.SelectionLength = txt_LocT.Text.Length;
                        return;
                    }
                }
            }
            else
            {
                btn_locT_Click(null, null);
            }
        }

        private void dtpFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtTo.Focus();
            }
        }

        private void dtTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMrefF.Focus();
            }
        }

        private void txtMrefF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMrefT.Focus();
            }
        }

        private void txtMrefT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPreview.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var item = "1";
            var loc = "1";
            var date = "1";
            var dFrom = "";
            var dTo = "";
            if (txt_Item_codeT.Text == "" && txt_Item_codeF.Text == "")
            {
                item = "";
            }

            if (txt_LocF.Text== "" && txt_LocT.Text == "" )
            {
                loc = "";
            }
            if (!dtpFrom.Checked && !dtTo.Checked)
            {
                date = "";
            }
            else
            {
                dFrom = string.Format("{0:MM/dd/yyyy}", dtpFrom.Value);
                dTo = string.Format("{0:MM/dd/yyyy}", dtTo.Value);
                
            }
            var report = new Report();
            var dt = _dataManager.GetData_Proc("SELECT_INVENTORY_LISTING", "ITEM", item, "ITEM_FROM", txt_Item_codeF.Text,
                                               "ITEM_TO", txt_Item_codeT.Text, "LOC", loc, "LOC_FROM", txt_LocF.Text,
                                               "LOC_TO", txt_LocT.Text, "DATE", date, "DATE_FROM", dFrom, "DATE_TO", dTo);
            if (cbo_GroupBy.Text == "Item Code")
            {
                report.Preview("Inventory Listing Items", dt);    
            }
            else if (cbo_GroupBy.Text == "Location Code")
            {
                report.Preview("Inventory Listing Location",dt);
            }
        }
    }
}
