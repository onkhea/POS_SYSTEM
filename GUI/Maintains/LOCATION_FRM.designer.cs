namespace POS.GUI.Maintains
{
    partial class LOCATION_FRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOCATION_FRM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExcelTool = new System.Windows.Forms.ToolStripButton();
            this.SearchTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.locationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelPanel = new System.Windows.Forms.Panel();
            this.ExportExcel = new System.Windows.Forms.LinkLabel();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Label3 = new System.Windows.Forms.Label();
            this.chbS = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.ToolStrip3 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removesep = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Label4 = new System.Windows.Forms.Label();
            this.bgwExcel = new System.ComponentModel.BackgroundWorker();
            this.ToolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.ExcelPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.ToolStrip3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AllowItemReorder = true;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.EditToolStripButton1,
            this.DeleteToolStripButton2,
            this.ToolStripSeparator1,
            this.ExcelTool,
            this.SearchTool,
            this.toolStripButton3});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(743, 25);
            this.ToolStrip1.Stretch = true;
            this.ToolStrip1.TabIndex = 3;
            this.ToolStrip1.TabStop = true;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.Image = global::POS.Properties.Resources.ico_alpha_FolderOptions_16x16;
            this.NewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(57, 22);
            this.NewToolStripButton.Text = "&New  ";
            this.NewToolStripButton.ToolTipText = "New User";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // EditToolStripButton1
            // 
            this.EditToolStripButton1.Image = global::POS.Properties.Resources.ico_alpha_Rename_16x16;
            this.EditToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton1.Name = "EditToolStripButton1";
            this.EditToolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.EditToolStripButton1.Text = "&Edit  ";
            this.EditToolStripButton1.Click += new System.EventHandler(this.EditToolStripButton1_Click);
            // 
            // DeleteToolStripButton2
            // 
            this.DeleteToolStripButton2.Image = global::POS.Properties.Resources.ico_alpha_Delete_16x16;
            this.DeleteToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton2.Name = "DeleteToolStripButton2";
            this.DeleteToolStripButton2.Size = new System.Drawing.Size(63, 22);
            this.DeleteToolStripButton2.Text = "&Delete ";
            this.DeleteToolStripButton2.Click += new System.EventHandler(this.DeleteToolStripButton2_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ExcelTool
            // 
            this.ExcelTool.Image = ((System.Drawing.Image)(resources.GetObject("ExcelTool.Image")));
            this.ExcelTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelTool.Name = "ExcelTool";
            this.ExcelTool.Size = new System.Drawing.Size(55, 22);
            this.ExcelTool.Text = "E&xcel";
            this.ExcelTool.Click += new System.EventHandler(this.ExcelTool_Click);
            // 
            // SearchTool
            // 
            this.SearchTool.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.SearchTool.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.SearchTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SearchTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchTool.Name = "SearchTool";
            this.SearchTool.Size = new System.Drawing.Size(62, 22);
            this.SearchTool.Text = "&Search";
            this.SearchTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchTool.Click += new System.EventHandler(this.SearchTool_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::POS.Properties.Resources.Close_64;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewX1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ExcelPanel);
            this.splitContainer1.Panel2.Controls.Add(this.Label5);
            this.splitContainer1.Panel2.Controls.Add(this.SearchPanel);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(743, 598);
            this.splitContainer1.SplitterDistance = 505;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationCode,
            this.locationName,
            this.Status,
            this.UserCode});
            this.dataGridViewX1.ContextMenuStrip = this.ContextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(743, 598);
            this.dataGridViewX1.TabIndex = 2;
            // 
            // locationCode
            // 
            this.locationCode.HeaderText = "Location Code";
            this.locationCode.Name = "locationCode";
            this.locationCode.ReadOnly = true;
            this.locationCode.Width = 150;
            // 
            // locationName
            // 
            this.locationName.HeaderText = "Location Name";
            this.locationName.Name = "locationName";
            this.locationName.ReadOnly = true;
            this.locationName.Width = 400;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // UserCode
            // 
            this.UserCode.HeaderText = "User Code";
            this.UserCode.Name = "UserCode";
            this.UserCode.ReadOnly = true;
            this.UserCode.Visible = false;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.ExcelToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.RefreshToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenuStrip1.Size = new System.Drawing.Size(133, 142);
            // 
            // ActionToolStripMenuItem
            // 
            this.ActionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem1});
            this.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem";
            this.ActionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ActionToolStripMenuItem.Text = "&Action";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AddToolStripMenuItem.Text = "&Add";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.EditToolStripMenuItem.Text = "&Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem1
            // 
            this.DeleteToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
            this.DeleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.DeleteToolStripMenuItem1.Text = "&Delete";
            this.DeleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefaultAllToolStripMenuItem,
            this.ActiveToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ViewToolStripMenuItem.Text = "&View";
            // 
            // DefaultAllToolStripMenuItem
            // 
            this.DefaultAllToolStripMenuItem.Checked = true;
            this.DefaultAllToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultAllToolStripMenuItem.Name = "DefaultAllToolStripMenuItem";
            this.DefaultAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.DefaultAllToolStripMenuItem.Text = "&Show All";
            this.DefaultAllToolStripMenuItem.Click += new System.EventHandler(this.AllUsersToolStripMenuItem_Click);
            // 
            // ActiveToolStripMenuItem
            // 
            this.ActiveToolStripMenuItem.Name = "ActiveToolStripMenuItem";
            this.ActiveToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ActiveToolStripMenuItem.Text = "&Active";
            this.ActiveToolStripMenuItem.Click += new System.EventHandler(this.ActiveToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.disableToolStripMenuItem.Text = "&Disabled";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloneToolStripMenuItem1,
            this.PasteToolStripMenuItem1,
            this.AToolStripMenuItem,
            this.ExportToolStripMenuItem1});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ToolsToolStripMenuItem.Text = "&Tools";
            // 
            // CloneToolStripMenuItem1
            // 
            this.CloneToolStripMenuItem1.Name = "CloneToolStripMenuItem1";
            this.CloneToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.CloneToolStripMenuItem1.Text = "&Clone";
            this.CloneToolStripMenuItem1.Click += new System.EventHandler(this.CloneToolStripMenuItem1_Click);
            // 
            // PasteToolStripMenuItem1
            // 
            this.PasteToolStripMenuItem1.Enabled = false;
            this.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1";
            this.PasteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.PasteToolStripMenuItem1.Text = "&Paste";
            this.PasteToolStripMenuItem1.Click += new System.EventHandler(this.PasteToolStripMenuItem1_Click);
            // 
            // AToolStripMenuItem
            // 
            this.AToolStripMenuItem.Name = "AToolStripMenuItem";
            this.AToolStripMenuItem.Size = new System.Drawing.Size(104, 6);
            // 
            // ExportToolStripMenuItem1
            // 
            this.ExportToolStripMenuItem1.Name = "ExportToolStripMenuItem1";
            this.ExportToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.ExportToolStripMenuItem1.Text = "E&xport";
            this.ExportToolStripMenuItem1.Click += new System.EventHandler(this.ExportToolStripMenuItem1_Click);
            // 
            // ExcelToolStripMenuItem
            // 
            this.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem";
            this.ExcelToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ExcelToolStripMenuItem.Text = "&Excel";
            this.ExcelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolStripMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.SearchToolStripMenuItem.Text = "&Search";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(129, 6);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.RefreshToolStripMenuItem.Text = "&Refresh";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // ExcelPanel
            // 
            this.ExcelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExcelPanel.Controls.Add(this.ExportExcel);
            this.ExcelPanel.Controls.Add(this.ListView1);
            this.ExcelPanel.Controls.Add(this.Label3);
            this.ExcelPanel.Controls.Add(this.chbS);
            this.ExcelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExcelPanel.Location = new System.Drawing.Point(0, 287);
            this.ExcelPanel.Name = "ExcelPanel";
            this.ExcelPanel.Size = new System.Drawing.Size(96, 299);
            this.ExcelPanel.TabIndex = 15;
            this.ExcelPanel.Visible = false;
            // 
            // ExportExcel
            // 
            this.ExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportExcel.AutoSize = true;
            this.ExportExcel.Location = new System.Drawing.Point(8, 278);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(77, 13);
            this.ExportExcel.TabIndex = 11;
            this.ExportExcel.TabStop = true;
            this.ExportExcel.Text = "&Export to excel";
            this.ExportExcel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExportExcel_LinkClicked);
            // 
            // ListView1
            // 
            this.ListView1.CheckBoxes = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1});
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListView1.FullRowSelect = true;
            this.ListView1.Location = new System.Drawing.Point(0, 29);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(94, 241);
            this.ListView1.TabIndex = 10;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Column Name";
            this.ColumnHeader1.Width = 200;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Khaki;
            this.Label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Image = ((System.Drawing.Image)(resources.GetObject("Label3.Image")));
            this.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label3.Location = new System.Drawing.Point(0, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 29);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "    Select columns to export";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chbS
            // 
            this.chbS.AutoSize = true;
            this.chbS.Location = new System.Drawing.Point(3, 276);
            this.chbS.Name = "chbS";
            this.chbS.Size = new System.Drawing.Size(70, 17);
            this.chbS.TabIndex = 2;
            this.chbS.Text = "&Select All";
            this.chbS.UseVisualStyleBackColor = true;
            this.chbS.CheckedChanged += new System.EventHandler(this.chbS_CheckedChanged);
            // 
            // Label5
            // 
            this.Label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label5.Location = new System.Drawing.Point(0, 273);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 14);
            this.Label5.TabIndex = 14;
            this.Label5.Visible = false;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.ToolStrip3);
            this.SearchPanel.Controls.Add(this.ToolStrip2);
            this.SearchPanel.Controls.Add(this.Label4);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(96, 273);
            this.SearchPanel.TabIndex = 2;
            this.SearchPanel.Visible = false;
            // 
            // ToolStrip3
            // 
            this.ToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1,
            this.ToolStripButton2});
            this.ToolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolStrip3.Location = new System.Drawing.Point(0, 25);
            this.ToolStrip3.Name = "ToolStrip3";
            this.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip3.Size = new System.Drawing.Size(94, 46);
            this.ToolStrip3.TabIndex = 1;
            this.ToolStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip3_ItemClicked);
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.DropDown = this.contextMenuStrip2;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(99, 20);
            this.ToolStripButton1.Text = "Add Criteria";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.removesep});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.OwnerItem = this.ToolStripButton1;
            this.contextMenuStrip2.Size = new System.Drawing.Size(118, 32);
            this.contextMenuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip2_ItemClicked);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "&Remove";
            // 
            // removesep
            // 
            this.removesep.Name = "removesep";
            this.removesep.Size = new System.Drawing.Size(114, 6);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(62, 20);
            this.ToolStripButton2.Text = "Search";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.CanOverflow = false;
            this.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolStrip2.Location = new System.Drawing.Point(0, 25);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip2.Size = new System.Drawing.Size(196, 19);
            this.ToolStrip2.TabIndex = 0;
            this.ToolStrip2.TabStop = true;
            this.ToolStrip2.Text = "ToolStrip2";
            this.ToolStrip2.Visible = false;
            this.ToolStrip2.SizeChanged += new System.EventHandler(this.ToolStrip2_SizeChanged);
            this.ToolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip2_ItemClicked);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Khaki;
            this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Image = ((System.Drawing.Image)(resources.GetObject("Label4.Image")));
            this.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 25);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "    Search";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bgwExcel
            // 
            this.bgwExcel.WorkerReportsProgress = true;
            this.bgwExcel.WorkerSupportsCancellation = true;
            this.bgwExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExcel_DoWork);
            this.bgwExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExcel_RunWorkerCompleted);
            this.bgwExcel.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwExcel_ProgressChanged);
            // 
            // LOCATION_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 623);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ToolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOCATION_FRM";
            this.Text = "Location";
            this.Load += new System.EventHandler(this.LOCATION_FRM_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ExcelPanel.ResumeLayout(false);
            this.ExcelPanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ToolStrip3.ResumeLayout(false);
            this.ToolStrip3.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton NewToolStripButton;
        internal System.Windows.Forms.ToolStripButton EditToolStripButton1;
        internal System.Windows.Forms.ToolStripButton DeleteToolStripButton2;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ExcelTool;
        internal System.Windows.Forms.ToolStripButton SearchTool;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ActionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DefaultAllToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ActiveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloneToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator AToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ExcelToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator removesep;
        internal System.Windows.Forms.Panel ExcelPanel;
        internal System.Windows.Forms.LinkLabel ExportExcel;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.CheckBox chbS;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Panel SearchPanel;
        internal System.Windows.Forms.ToolStrip ToolStrip3;
        internal System.Windows.Forms.ToolStripDropDownButton ToolStripButton1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.Label Label4;
        private System.ComponentModel.BackgroundWorker bgwExcel;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCode;
    }
}