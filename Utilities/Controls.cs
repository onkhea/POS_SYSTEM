using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using POS.Utilities;

namespace POS.Utilities
{
    public class Controls :IControls
    {
        
        public void ClearControl(params Control[] controls)
        {
            try
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                        control.Text = string.Empty;
                    else if (control is ComboBox)
                        control.Text = string.Empty;
                    else if (control is MaskedTextBox)
                        control.Text = string.Empty;
//                    else if (control is UIComboBox)
//                        control.Text = string.Empty;
//                    else if (control is Janus.Windows.GridEX.EditControls.MultiColumnCombo)
//                        control.Text = string.Empty;
                    else if (control is Label)
                        control.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show((string)ex.Message, Messages.EmptyControl);
            }
        }

        public void EnabledControlTrue(params Control[] controls)
        {

            try
            {
                foreach (var control in controls)
                {
                    if (control is Button)
                        control.Enabled = true;
                    if (control is TextBox)
                        control.Enabled = true;
                    if (control is GroupBox)
                        control.Enabled = true;
                    if (control is ListView)
                        control.Enabled = true;
                    if (control is Label)
                        control.Enabled = true;
                    if (control is DateTimePicker)
                        control.Enabled = true;
                    if (control is ComboBox)
                        control.Enabled = true;
                    if (control is Label)
                        control.Enabled = true;
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clear enable control");
            }
        }

        public void Enabled_Control_False(params Control[] controls)
        {
            try
            {
                foreach (var control in controls)
                {
                    if (control is Button)
                        control.Enabled = false;
                    if (control is TextBox)
                        control.Enabled = false;
                    if (control is GroupBox)
                        control.Enabled = false;
                    if (control is ListView)
                        control.Enabled = false;
                    if (control is DateTimePicker)
                        control.Enabled = false;
                    if (control is ComboBox)
                        control.Enabled = false;
                    if (control is Label)
                        control.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Enable Control");
            }
        }

        public void GridShow(DataTable dataTable, Control controls)
        {
//            var gridEX = (Janus.Windows.GridEX.GridEX)control;
//            dataTable.AcceptChanges();
//            gridEX.DataSource = dataTable;
//            gridEX.Refetch();
        }

        #region AddEventHandle

        public void AddEventHandler(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                //|| control is UIComboBox ||
                if (control is TextBox || control is ComboBox || control is MaskedTextBox || 
                    control is DateTimePicker)
                {
                    control.KeyDown += new KeyEventHandler(control_KeyDown);
                    control.Enter += new EventHandler(control_Enter);
                    control.Leave += new EventHandler(control_Leave);
                }
            }
        }

        internal void control_Leave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        internal void control_Enter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Khaki;
        }

        internal void control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Return) return;

            e.Handled = false;
            SendKeys.Send("{TAB}");
            }

        #endregion

        public void Only_Number_On_Control(params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox || control is MaskedTextBox)// || control is UIComboBox || control is Janus.Windows.GridEX.EditControls.MultiColumnCombo)
                    control.KeyPress += new KeyPressEventHandler(control_KeyPress);

                if (control.HasChildren)
                {
                    AddEventHandler(control);
                }
            }
        }

        internal void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            const char Backspace = (char)10;
            const char Minus = (char)45;
            const char dot = (char)46;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != Backspace && e.KeyChar != Minus && e.KeyChar != dot;
        }

        public void Only_Number_On_Control_Except_Dot(params Control[] controls)
        {
            foreach (var ctl in controls)
            {
                if (ctl is TextBox || ctl is MaskedTextBox )// || control is UIComboBox || control is Janus.Windows.GridEX.EditControls.MultiColumnCombo)
                    ctl.KeyPress += new KeyPressEventHandler(ctl_KeyPress);

                if (ctl.HasChildren)
                {
                    AddEventHandler(ctl);
                }
            }
        }

        void ctl_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            const char Backspace = (char)10;
            const char Minus = (char)45;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != Backspace && e.KeyChar != Minus;
        }

        public void Prevent_Input_Data(params Control[] controls)
        {
            foreach (var contl in controls)
            {
                if (contl is TextBox || contl is MaskedTextBox)// || ctl is UIComboBox || ctl is Janus.Windows.GridEX.EditControls.MultiColumnCombo)
                    contl.KeyPress += new KeyPressEventHandler(contl_KeyPress);

                if (contl.HasChildren)
                {
                    AddEventHandler(contl);
                }
            }
        }

        void contl_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Add_Comma_To_TextBox(params Control[] controls)
        {
            throw new System.NotImplementedException();
        }

        public void Add_ListView(DataTable dataTable, ListView listView)
        {
            var str = new string[dataTable.Columns.Count];
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i <= dataTable.Columns.Count -1; i++)
                {
                    str[i] = row[i].ToString();
                }
                var listViewItem = new ListViewItem(str);
                listView.Items.Add(listViewItem);
            }
            
        }

        public void Add_ListView(ListView listView, int totalControl,params string[] controls)
        {
            var list = new string[totalControl];
            var i = 0;
            foreach (var control in controls)
            {
                list[i] = control;
                i += 1;
            }
            var listViewItem = new ListViewItem(list);
            listView.Items.Add(listViewItem);
           
        }

        /// <summary>
        /// this method to update listview 
        /// </summary>
        /// <param name="listView">listViewName</param>
        /// <param name="headListview">Textbox1.text</param>
        /// <remarks>this headListview is data to set in listview.selectItem[0].text = headListView</remarks>
        /// <param name="values">Textbox2,Textbox3,...</param>
        /// 
        public void Update_ListView(ListView listView,params string[] values)
        {
            var i = 0;
//            var ls = listView.SelectedItems[0]
            foreach (var str in values)
            {
                listView.SelectedItems[0].SubItems[i].Text = str;
                i += 1;
            }
        }

        public void LoadPanelSearch(DataGridView DGViewData, DataTable SQLDatatbl, ListView LVSExcel, ContextMenuStrip DropdownCms, string FistSearch, ToolStrip SearchTool, SplitContainer SPC, Panel SearchPanel)
        {
            int J;
            int I;
            SPC.Panel2MinSize = 250;
            if (Convert.ToDouble(SPC.Width) > 200) { SPC.SplitterDistance = SPC.Width - 200; }
            Double pw = Convert.ToDouble(SearchPanel.Width / 200);
            if (pw == 0) { J = 1; }
            else if (pw < 3) { J = Convert.ToInt16(SearchPanel.Width / 200); }
            else { J = 3; }
            SearchTool.Visible = true;
            LVSExcel.Items.Clear();
//            DropdownCms.Items.Clear();
            for (I = 0; I <= DGViewData.Columns.Count - 1; I++)
            {
                var T = new ToolStripMenuItem
                            {
                                Name = ("CTX" + SQLDatatbl.Columns[I].ColumnName.ToString()),
                                Text = DGViewData.Columns[I].HeaderText
                            };
                if (SQLDatatbl.Columns[I].ColumnName == FistSearch)
                {
                    var D = new ToolStripDropDownButton
                                {
                                    AutoSize = false,
                                    DisplayStyle = ToolStripItemDisplayStyle.Text,
                                    ImageAlign = ContentAlignment.MiddleRight,
                                    ImageTransparentColor = Color.Magenta,
                                    Name = ("tlbl" + SQLDatatbl.Columns[I].ColumnName),
                                    TextAlign = ContentAlignment.MiddleLeft,
                                    Text = DGViewData.Columns[I].HeaderText,
                                    DropDown = DropdownCms,
                                    Height = 21,
                                    Width = 100
                                };
                    SearchTool.Items.Add(D);
                    var tt = new ToolStripTextBox
                                 {
                                     AutoSize = false,
                                     Name = ("ttxt" + SQLDatatbl.Columns[I].ColumnName),
                                     Height = 21
                                 };
                    int w = Convert.ToInt16(SearchPanel.Width);
                    tt.Width = (w - 125 * J) / J;
                    SearchTool.Items.Add(tt);
                    T.Visible = false;
                }
                DropdownCms.Items.Add(T);
                LVSExcel.Items.Add(DGViewData.Columns[I].HeaderText);
                if (DGViewData.Columns[I].Visible != true) continue;
                var k = Convert.ToInt16(LVSExcel.Items.Count) - 1;
                LVSExcel.Items[k].Checked = true;
            }
        }

        public void AddItemToLVGroup(ListView LV, ListViewGroup group, params string[] text)
        {
            var LvItem = new ListViewItem();
            int i = 0;
            foreach (var s in text)
            {
                LvItem = new ListViewItem(Convert.ToString(s));
                LV.Items.Add(LvItem);
                i += 1;
            }
        }

        public void CheckOnListView(ListView Lv,CheckBox checkBox)
        {
            if (checkBox.Checked == true)
            {
                foreach (ListViewItem item in Lv.Items)
                {
                    item.Checked = checkBox.Checked;
                }
            }
            else
            {
                foreach (ListViewItem item in Lv.Items)
                {
                    item.Checked = false;
                }
            }
        }

        public void AddToDataGridView(DataGridView dgv,params string[] values)
        {
            dgv.Rows.Add(values);
        }

        public void UpdateDataToGridView(DataGridView dataGridView, params string[] values)
        {
            DataGridViewRow dgRow = dataGridView.SelectedRows[0];
            dgRow.Cells[0].Value = values[0].Trim();
            for (int i = 1; i < values.Length; i++)
            {
                dgRow.Cells[i].Value = values[i];
            }
            dataGridView.Focus();
        }

        public byte[] ReturnImage(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
            {
                return null;
            }
            var memStream = new MemoryStream();
                pictureBox.Image.Save(memStream,System.Drawing.Imaging.ImageFormat.Jpeg);
                var byBLOBData = new byte[memStream.Length -1];
                memStream.Position = 0;
            
                memStream.Read(byBLOBData, 0, byBLOBData.Length);
                return byBLOBData;
        }

        public void BindingDataToDataGrid(DataGridView dgv, DataTable dataTable)
        {
            try
            {
                dgv.Rows.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    int j;
                    j = dgv.Rows.Add(row[0]);
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        dgv.Rows[j].Cells[i].Value = row[i];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public object DBNullValue(object sender)
        {
            if (sender == Convert.DBNull)
            {
                return "";
            }
            else
                return sender;
       }

        public void SelectNextControl(params Control[] controls )
        {
            foreach (var control in controls)
            {
                control.SelectNextControl(control, true, true, true, true);
            }
        }

     
           
    }
}