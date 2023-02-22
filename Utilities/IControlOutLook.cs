using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.Utilities
{
    public abstract class IControlOutLook
    {

        public abstract void  addcreteria(ContextMenuStrip cms, ToolStrip ts, Panel p, ToolStripMenuItem tsm,
                                          ToolStripItemClickedEventArgs e, String STRTMP);


        public abstract void loadSearch(DataGridView dgv, DataTable tb, String fsearch, ListView lsv, ContextMenuStrip cms,
                                        ToolStrip tssearch, SplitContainer spc, Panel psearch);

        public abstract void searching(SqlConnection cn, DataGridView dgv, String SQLStr, String OrderByCol, ToolStrip tsSearch,
                                       ToolStrip tsCreteria, String Statu);

        public abstract void showDGV(DataGridView dgv, DataTable tb, String Statu);


        public abstract void ChangeColorOnDisabledAndActive(DataGridView dgv, string status, int j);

        public abstract void Change_Color_On_Disabled_And_Active_On_Selected(DataGridView dataGridView, string status);
        

        public abstract void Active_And_Disable_On_GridView(DataGridView dgv, string status);

        public abstract void ExportToExcel(ListView Lv, System.ComponentModel.BackgroundWorker bgExcel);

        public abstract void BackGround_RunWorkedCompleted();

        public abstract void BackGround_DdWork(DataGridView dgv, ListView lv);

        public abstract void BackGroud_ProgressChanged(System.ComponentModel.ProgressChangedEventArgs e);

        public abstract void BindingDataToControl(Control[] controls, DataGridView dgv);

        public abstract void ToolStrip2_SizeChanged(Panel SearchPanel, ToolStrip ToolStrip2, ToolStrip ToolStrip3, Label labels);
    }
}