using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using POS.GUI;
using POS.Utilities;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable=System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;
using Label=System.Windows.Forms.Label;

//using Microsoft.Office.Interop.Excel;

namespace POS.Utilities
{
    public class OutLook : IControlOutLook
    {
        #region Variable

        private Application Ea;
        private Workbook workbook;
        private Worksheet worksheet;
        public Boolean[] Col_Sel;

        #endregion

        public override void addcreteria(ContextMenuStrip cms, ToolStrip ts, Panel p, ToolStripMenuItem tsm, ToolStripItemClickedEventArgs e, string STRTMP)
        {
            if (tsm.Visible == false)
            {
                int j = 0, k = 0;
                k = p.Width / 200;
                if (k == 0) { j = 1; }
                else j = j < 3 ? k : 3;
                var d = new ToolStripDropDownButton
                            {
                                AutoSize = false,
                                DisplayStyle = ToolStripItemDisplayStyle.Text,
                                ImageAlign = System.Drawing.ContentAlignment.MiddleRight,
                                ImageTransparentColor = System.Drawing.Color.Magenta,
                                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                                Name = ("tlbl" + e.ClickedItem.Name.Substring(3, e.ClickedItem.Name.Length - 3)),
                                Text = e.ClickedItem.Text,
                                Height = 21,
                                Width = 120,
                                DropDown = cms
                            };
                ts.Items.Add(d);
                if (e.ClickedItem.Name == "ctxITEM_STAT")
                {
                    var t = new ToolStripComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
                    t.Items.Add(" ");
                    t.Items.Add("A - Active");
                    t.Items.Add("D - Disable");
                    t.AutoSize = false;
                    t.Name = "ttxt" + e.ClickedItem.Name.Substring(3, e.ClickedItem.Name.Length - 3);
                    t.Height = 21;
                    t.Width = (p.Width - 125 * j) / j;
                    ts.Items.Add(t);
                    e.ClickedItem.Visible = false;
                }
                else
                {
                    var t = new ToolStripTextBox
                                {
                                    AutoSize = false,
                                    Name = ("ttxt" + e.ClickedItem.Name.Substring(3, e.ClickedItem.Name.Length - 3)),
                                    Height = 21,
                                    Width = ((p.Width - 125 * j) / j)
                                };
                    ts.Items.Add(t);
                    e.ClickedItem.Visible = false;
                }
            }
            else
            {
                if (e.ClickedItem.Text == "&Remove")
                {
                    cms.Hide();
                    cms.Items["ctx" + STRTMP.Substring(4, STRTMP.Length - 4)].Visible = true;
                    ts.Items.Remove(ts.Items[STRTMP]);
                    ts.Items.Remove(ts.Items["ttxt" + STRTMP.Substring(4, STRTMP.Length - 4)]);
                }
                else
                {
                    ts.Items[STRTMP].Text = e.ClickedItem.Text;
                    ts.Items[STRTMP].Name = "tlbl" + e.ClickedItem.Name.Substring(3, e.ClickedItem.Name.Length - 3);
                    ts.Items["ttxt" + STRTMP.Substring(4, STRTMP.Length - 4)].Name = "ttxt" + e.ClickedItem.Name.Substring(3, e.ClickedItem.Name.Length - 3);
                    e.ClickedItem.Visible = false;
                    cms.Items["ctx" + STRTMP.Substring(4, STRTMP.Length - 4)].Visible = true;
                }
            }
        }

        public override void loadSearch(DataGridView dgv, DataTable tb, string fsearch, ListView lsv, ContextMenuStrip cms, ToolStrip tssearch, SplitContainer spc, Panel psearch)
        {
            int j = 0, i = 0;
            spc.Panel2MinSize = 300;
            int k = spc.Width;
            if (k > 200)
            {
                spc.SplitterDistance = k - 200;
            }
            if ((psearch.Width / 200) == 0) { j = 1; }
            else if ((psearch.Width / 200) < 3) { j = psearch.Width / 200; }
            else { j = 3; }
            tssearch.Visible = true;
            lsv.Items.Clear();
            tssearch.Items.Clear();
            for (i = 0; i <= dgv.ColumnCount - 1; i++)
            {
                var t = new ToolStripMenuItem();
                t.Name = "ctx" + tb.Columns[i].ColumnName;
                t.Text = dgv.Columns[i].HeaderText;
                if (tb.Columns[i].ColumnName == fsearch)
                {
                    var d = new ToolStripDropDownButton();
                    d.AutoSize = false;
                    d.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    d.ImageAlign = ContentAlignment.MiddleRight;
                    d.ImageTransparentColor = Color.Magenta;
                    d.Name = "tlbl" + tb.Columns[i].ColumnName;
                    d.TextAlign = ContentAlignment.MiddleLeft;
                    d.DropDown = cms;
                    d.Text = dgv.Columns[i].HeaderText;
                    d.Height = 21;
                    d.Width = 120;
                    tssearch.Items.Add(d);
                    var TT = new System.Windows.Forms.ToolStripTextBox();
                    TT.AutoSize = false;
                    TT.Name = "ttxt" + tb.Columns[i].ColumnName;
                    TT.Height = 21;
                    TT.Width = (psearch.Width - 125 * j) / j;
                    tssearch.Items.Add(TT);
                    t.Visible = false;
                }
                cms.Items.Add(t);
                lsv.Items.Add(dgv.Columns[i].HeaderText);
                if (dgv.Columns[i].Visible == true)
                {
                    lsv.Items[lsv.Items.Count - 1].Checked = true;
                }

            }
        }

        public override void searching(SqlConnection cn, DataGridView dgv, string SQLStr, string OrderByCol, ToolStrip tsSearch, ToolStrip tsCreteria, string Statu)
        {
            try
            {
                if (tsSearch.Items.Count > 0)
                {
                    String sql = "";
                    var cmd = new SqlCommand("", cn);
                    var j = 0; var i = 0;
                    for (i = 1; i <= tsSearch.Items.Count - 1; i = i + 2)
                    {
                        String strmp = tsSearch.Items[i].Name.Substring(4, tsSearch.Items[i].Name.Length - 4);
                        sql = sql + strmp + " like " + "@" + strmp + " and ";
                        String str = "";
                        if (tsSearch.Items[i].Name == "ttxtACC_STAT")
                        {
                            if (tsSearch.Items[i].Text.Trim() != "")
                            {
                                str = tsSearch.Items[i].Text.Substring(0, 2).Trim();
                            }

                        }
                        else
                        {
                            str = tsSearch.Items[i].Text;
                        }

                        cmd.Parameters.AddWithValue("@" + strmp, str + "%");
                    }
                    sql = sql.Substring(0, sql.Length - 5);
                    sql = SQLStr + " where " + sql + " order by " + OrderByCol;
                    cmd.CommandText = sql;
                    var dap = new SqlDataAdapter(cmd);
                    var tb = new DataTable();
                    dap.Fill(tb);
                    dgv.Rows.Clear();
                    cmd.Parameters.Clear();
                    foreach (DataRow r in tb.Rows)
                    {
                        j = dgv.Rows.Add(r[0]);
                        for (i = 0; i <= tb.Columns.Count - 1; i++)
                        {
                            if (tb.Columns[i].ColumnName == Statu)
                            {
                                String acc = "";
                                if (r[i].ToString() == "D")
                                {
                                    acc = "Disable";
                                    dgv.Rows[j].Cells[i].Value = acc;
                                    dgv.Rows[j].DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DarkGray;
                                }
                                else
                                {
                                    acc = "Active";
                                    dgv.Rows[j].Cells[i].Value = acc;
                                }

                            }
                            else
                            {
                                dgv.Rows[j].Cells[i].Value = r[i];
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("There are no criteria to search for!", "Error");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        public void searching(SqlConnection cn, DataGridView dgv, string SQLStr, string OrderByCol, ToolStrip tsSearch, ToolStrip tsCreteria, string Statu, params string[] condition)
        {
            try
            {
                if (tsSearch.Items.Count > 0)
                {
                    String sql = "";
                    var cmd = new SqlCommand("", cn);
                    var j = 0; var i = 0;
                    for (i = 1; i <= tsSearch.Items.Count - 1; i = i + 2)
                    {
                        String strmp = tsSearch.Items[i].Name.Substring(4, tsSearch.Items[i].Name.Length - 4);
                        sql = sql + "UPPER(" + strmp + ") like " + "UPPER(@" + strmp + ") and ";
                        String str = "";
                        if (tsSearch.Items[i].Name == "ttxtACC_STAT")
                        {
                            if (tsSearch.Items[i].Text.Trim() != "")
                            {
                                str = tsSearch.Items[i].Text.Substring(0, 2).Trim();
                            }

                        }
                        else
                        {
                            str = tsSearch.Items[i].Text;
                        }

                        cmd.Parameters.AddWithValue("@" + strmp, str + "%");
                    }
                    var Ss = "";
                    if (condition.Length != 0)
                    {
                        for (int k = 0; k < condition.Length - 1; k += 2)
                        {
                            Ss = Ss + condition[k] + "=@" + condition[k];
                            cmd.Parameters.AddWithValue("@" + condition[k], condition[k + 1]);
                        }
                        sql = sql.Substring(0, sql.Length - 5);
                        sql = SQLStr + " where " + sql + " And " + Ss + " order by " + OrderByCol;    
                    }
                    else
                    {
                        sql = sql.Substring(0, sql.Length - 5);
                        sql = SQLStr + " where " + sql + " order by " + OrderByCol;  
                    }
                    
                    cmd.CommandText = sql;
                    var dap = new SqlDataAdapter(cmd);
                    var tb = new DataTable();
                    dap.Fill(tb);
                    dgv.Rows.Clear();
                    cmd.Parameters.Clear();
                    foreach (DataRow r in tb.Rows)
                    {
                        j = dgv.Rows.Add(r[0]);
                        for (i = 0; i <= tb.Columns.Count - 1; i++)
                        {
                            if (tb.Columns[i].ColumnName == Statu)
                            {
                                String acc = "";
                                if (r[i].ToString() == "D")
                                {
                                    acc = "Disable";
                                    dgv.Rows[j].Cells[i].Value = acc;
                                    dgv.Rows[j].DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DarkGray;
                                }
                                else
                                {
                                    acc = "Active";
                                    dgv.Rows[j].Cells[i].Value = acc;
                                }

                            }
                            else
                            {
                                dgv.Rows[j].Cells[i].Value = r[i];
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("There are no criteria to search for!", "Error");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        public override void showDGV(DataGridView dgv, DataTable tb, string Statu)
        {
            var j = 0; var i = 0;
            dgv.Rows.Clear();
            foreach (DataRow r in tb.Rows)
            {
                j = dgv.Rows.Add(r[0]);
                for (i = 0; i <= tb.Columns.Count - 1; i++)
                {
                    if (tb.Columns[i].ColumnName == Statu)
                    {
                        String acc = "";
                        if (r[i].ToString() == "D")
                        {
                            acc = "Disable";
                            dgv.Rows[j].Cells[i].Value = acc;
                            dgv.Rows[j].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGray;
                        }
                        else
                        {
                            acc = "Active";
                            dgv.Rows[j].Cells[i].Value = acc;

                        }

                    }
                    else
                    {
                        dgv.Rows[j].Cells[i].Value = r[i];
                    }
                }
            }
        }

        public override void ChangeColorOnDisabledAndActive(DataGridView dgv,string status,int j)
        {
            switch (status.Substring(0,1))
            {
                case "D":
                    dgv.Rows[j].DefaultCellStyle.ForeColor = Color.DarkGray;
                    dgv.Rows[j].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                    break;
                default:
                    dgv.Rows[j].DefaultCellStyle.ForeColor = Color.Black;
                    dgv.Rows[j].DefaultCellStyle.SelectionForeColor = Color.Black;
                    break;
            }
        }

        public override void Change_Color_On_Disabled_And_Active_On_Selected(DataGridView dataGridView, string status)
        {
            switch (status.Substring(0,1))
            {
                case "D":
                    dataGridView.SelectedRows[0].DefaultCellStyle.ForeColor = Color.DarkGray;
                    dataGridView.SelectedRows[0].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                    break;
                default:
                    dataGridView.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView.SelectedRows[0].DefaultCellStyle.SelectionForeColor = Color.Black;
                    break;
                   
            }
        }

        public override void Active_And_Disable_On_GridView(DataGridView dgv, string status)
        {
            for (int j = 0; j < dgv.Rows.Count; j++)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Rows[j].Cells[i].Value.ToString() != null)
                    {
                        if (dgv.Rows[j].Cells[i].Value.GetType() != typeof(DateTime))
                        {
                            if ((string)dgv.Rows[j].Cells[i].Value == status)
                            {
                                dgv.Rows[j].Visible = false;
                            }
                        }
                    }
                    
                }
            }

        }

        public override void BindingDataToControl(Control[] controls, DataGridView dgv)
        {
            var list = new List<string>();
            if (dgv.SelectedRows.Count != 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    list.Add(dgv.SelectedRows[0].Cells[i].Value.ToString());
                }
            }
            var box = new ComboBox();
            var j = 0;
            foreach (var control in controls)
            {
                var d = list[j];
                switch (list[j].ToString())
                {
                    case "Active":
                        controls[j].Text = d.Substring(0, 1) + " - " + d.ToString();
                        break;
                    case "Disable":
                        controls[j].Text = d.Substring(0, 1) + " - " + d.ToString();
                        break;
                    case "Multiply":
                        controls[j].Text = "* - " + d.ToString();
                        break;
                    case "Divide":
                        controls[j].Text = "/ - " + d.ToString();
                        break;
                    default:
                        control.Text = list[j];
                        break;
                }
                j++;
            }

        }

        public override void ToolStrip2_SizeChanged(Panel SearchPanel,ToolStrip ToolStrip2, ToolStrip ToolStrip3,Label labels)
        {
            try
            {
                var j = 0;
                var i = 0;
                var k = SearchPanel.Width / 200;
                if (k == 0) { j = 1; }
                else if (k < 3) { j = k; }
                else { j = 3; }
                for (i = 0; i <= ToolStrip2.Items.Count - 1; i++)
                {
                    if (ToolStrip2.Items[i].Name.Substring(0, 4) == "ttxt")
                    {
                        ToolStrip2.Items[i].Width = ((SearchPanel.Width - 125) * j) / j;
                        if (ToolStrip2.Height + ToolStrip3.Height + labels.Height <= 380)
                        {
                            SearchPanel.Height = ToolStrip2.Height + ToolStrip3.Height + labels.Height;
                        }
                        else
                        {
                            SearchPanel.Height = 380;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void PasteData(List<string> list, params Control[] controls)
        {
            var i = 0;
            foreach (var control in controls)
            {
                control.Text = list[i];
                i++;
            }
        }

        public List<string> CloneData(List<string> list , DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    var d = dgv.SelectedRows[0].Cells[i].Value;
                    if (d ==null) 
                    {
                        list.Add("");
                    }
                    else
                    {
                        list.Add(d.ToString());
                    }
                    
                }
            }
            return list;
        }
    

        #region Export Excel ===================

        readonly PROGRESSBAR_FRM progressbar_FRM = new PROGRESSBAR_FRM();

        System.ComponentModel.BackgroundWorker bgwExcel = new BackgroundWorker();

        public override void ExportToExcel(ListView Lv, System.ComponentModel.BackgroundWorker bgExcel)
        {
            try
            {
                Ea = new Application();
//             
                bgwExcel = bgExcel;
                int i = 0;
                foreach (ListViewItem item in Lv.Items)
                    if (item.Checked == true)
                        i += 1;

                if (i <= 0)
                {
                    MessageBox.Show(Messages.ExportToExcel, "Error Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Lv.Focus();
                    return;
                }
                var d = 0;
                // ===============Header of excel=============

                object misValue = System.Reflection.Missing.Value;
                workbook = Ea.Workbooks.Add(misValue);
                worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                Col_Sel = new bool[Lv.Items.Count];
                for (int j = 0; j < Lv.Items.Count; j++)
                {
                    if (Lv.Items[j].Checked == true)
                    {
                        Col_Sel[j] = true;
                        d += 1;
                        worksheet.Cells[1, d] = Lv.Items[j].Text;
                    }
                    else
                    {
                        Col_Sel[j] = false;
                    }
                }

                progressbar_FRM.Text = "Export to excel...";
                progressbar_FRM.progressBar1.Value = 0;
                bgExcel.RunWorkerAsync();
                if (progressbar_FRM.ShowDialog() == DialogResult.Cancel)
                {
                    bgExcel.CancelAsync();
                    progressbar_FRM.Close();
                }

            }
            catch (Exception ex)
            {
//                throw ex;
//                MessageBox.Show(ex.Message, "Error Excel");
            }
        }

        public override void BackGroud_ProgressChanged(System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressbar_FRM.progressBar1.Value = e.ProgressPercentage;
            progressbar_FRM.Text = "Export to excel... (" + e.ProgressPercentage;
            progressbar_FRM.Refresh();
        }

        public override void BackGround_RunWorkedCompleted()
        {
            progressbar_FRM.Close();
//            progressbar_FRM.Dispose();
            Ea.Visible = true;
            worksheet.Columns.AutoFit();
            worksheet = null;
            workbook = null;
            Ea = null;
        }

        public override void BackGround_DdWork(DataGridView dgv, ListView lv)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count ; i++)
                {
                    int k = 0;

                    for (int j = 0; j < lv.Items.Count; j++)
                    {
                        if (Col_Sel[j] == true)
                        {
                            k += 1;
                            worksheet.Cells[i + 2, k] = dgv.Rows[i].Cells[j].Value;
                        }
                    }
                    var rowGrid = dgv.Rows.Count - 1;
                    if (rowGrid == 0)
                    {
                        rowGrid = 1;
                        i = 1;
                    }
                    bgwExcel.ReportProgress((int)Math.Round((Double)((((double)i) / ((double)rowGrid)) * 100.0)));
                    if (bgwExcel.CancellationPending)
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}