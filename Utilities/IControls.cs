using System;
using System.Data;
using System.Windows.Forms;

namespace POS.Utilities
{
    interface IControls
    {
        void ClearControl(params Control[] controls);
        void EnabledControlTrue(params Control[] controls);
        void Enabled_Control_False(params Control[] controls);
        void GridShow(DataTable dataTable, Control controls);
        void AddEventHandler(params Control[] controls);
        void Only_Number_On_Control(params Control[] controls);
        void Only_Number_On_Control_Except_Dot(params Control[] controls);
        void Prevent_Input_Data(params Control[] controls);
        void Add_Comma_To_TextBox(params Control[] controls);
        void Add_ListView(DataTable dataTable, ListView listView);
        void Add_ListView(ListView listView,int totalControl,params string[] controls);
        void Update_ListView(ListView listView, params string[] values);
        void LoadPanelSearch(DataGridView DGViewData, DataTable SQLDatatbl,
                             ListView LVSExcel, ContextMenuStrip DropdownCms,
                             String FistSearch, ToolStrip SearchTool,
                             SplitContainer SPC, Panel SearchPanel);

        void AddItemToLVGroup(ListView LV, ListViewGroup group, params string[] text);

        void UpdateDataToGridView(DataGridView dataGridView, params string[] values);
        byte[] ReturnImage(PictureBox pictureBox);

    }
}