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
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chbS = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.ToolStrip3 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removesep = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.bgwExcel = new System.ComponentModel.BackgroundWorker();
            this.Label3 = new System.Windows.Forms.Label();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ExcelTool = new System.Windows.Forms.ToolStripButton();
            this.SearchTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.locationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
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
            resources.ApplyResources(this.ToolStrip1, "ToolStrip1");
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
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Stretch = true;
            this.ToolStrip1.TabStop = true;
            // 
            // ToolStripSeparator1
            // 
            resources.ApplyResources(this.ToolStripSeparator1, "ToolStripSeparator1");
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewX1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.ExcelPanel);
            this.splitContainer1.Panel2.Controls.Add(this.Label5);
            this.splitContainer1.Panel2.Controls.Add(this.SearchPanel);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // dataGridViewX1
            // 
            resources.ApplyResources(this.dataGridViewX1, "dataGridViewX1");
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
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // ContextMenuStrip1
            // 
            resources.ApplyResources(this.ContextMenuStrip1, "ContextMenuStrip1");
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
            // 
            // ActionToolStripMenuItem
            // 
            resources.ApplyResources(this.ActionToolStripMenuItem, "ActionToolStripMenuItem");
            this.ActionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem1});
            this.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem";
            // 
            // AddToolStripMenuItem
            // 
            resources.ApplyResources(this.AddToolStripMenuItem, "AddToolStripMenuItem");
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            resources.ApplyResources(this.EditToolStripMenuItem, "EditToolStripMenuItem");
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem1
            // 
            resources.ApplyResources(this.DeleteToolStripMenuItem1, "DeleteToolStripMenuItem1");
            this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
            this.DeleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // ViewToolStripMenuItem
            // 
            resources.ApplyResources(this.ViewToolStripMenuItem, "ViewToolStripMenuItem");
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefaultAllToolStripMenuItem,
            this.ActiveToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            // 
            // DefaultAllToolStripMenuItem
            // 
            resources.ApplyResources(this.DefaultAllToolStripMenuItem, "DefaultAllToolStripMenuItem");
            this.DefaultAllToolStripMenuItem.Checked = true;
            this.DefaultAllToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultAllToolStripMenuItem.Name = "DefaultAllToolStripMenuItem";
            this.DefaultAllToolStripMenuItem.Click += new System.EventHandler(this.AllUsersToolStripMenuItem_Click);
            // 
            // ActiveToolStripMenuItem
            // 
            resources.ApplyResources(this.ActiveToolStripMenuItem, "ActiveToolStripMenuItem");
            this.ActiveToolStripMenuItem.Name = "ActiveToolStripMenuItem";
            this.ActiveToolStripMenuItem.Click += new System.EventHandler(this.ActiveToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            resources.ApplyResources(this.disableToolStripMenuItem, "disableToolStripMenuItem");
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            resources.ApplyResources(this.ToolsToolStripMenuItem, "ToolsToolStripMenuItem");
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloneToolStripMenuItem1,
            this.PasteToolStripMenuItem1,
            this.AToolStripMenuItem,
            this.ExportToolStripMenuItem1});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            // 
            // CloneToolStripMenuItem1
            // 
            resources.ApplyResources(this.CloneToolStripMenuItem1, "CloneToolStripMenuItem1");
            this.CloneToolStripMenuItem1.Name = "CloneToolStripMenuItem1";
            this.CloneToolStripMenuItem1.Click += new System.EventHandler(this.CloneToolStripMenuItem1_Click);
            // 
            // PasteToolStripMenuItem1
            // 
            resources.ApplyResources(this.PasteToolStripMenuItem1, "PasteToolStripMenuItem1");
            this.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1";
            this.PasteToolStripMenuItem1.Click += new System.EventHandler(this.PasteToolStripMenuItem1_Click);
            // 
            // AToolStripMenuItem
            // 
            resources.ApplyResources(this.AToolStripMenuItem, "AToolStripMenuItem");
            this.AToolStripMenuItem.Name = "AToolStripMenuItem";
            // 
            // ExportToolStripMenuItem1
            // 
            resources.ApplyResources(this.ExportToolStripMenuItem1, "ExportToolStripMenuItem1");
            this.ExportToolStripMenuItem1.Name = "ExportToolStripMenuItem1";
            this.ExportToolStripMenuItem1.Click += new System.EventHandler(this.ExportToolStripMenuItem1_Click);
            // 
            // ExcelToolStripMenuItem
            // 
            resources.ApplyResources(this.ExcelToolStripMenuItem, "ExcelToolStripMenuItem");
            this.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem";
            this.ExcelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolStripMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            resources.ApplyResources(this.SearchToolStripMenuItem, "SearchToolStripMenuItem");
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            resources.ApplyResources(this.ToolStripMenuItem2, "ToolStripMenuItem2");
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            // 
            // RefreshToolStripMenuItem
            // 
            resources.ApplyResources(this.RefreshToolStripMenuItem, "RefreshToolStripMenuItem");
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // ExcelPanel
            // 
            resources.ApplyResources(this.ExcelPanel, "ExcelPanel");
            this.ExcelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExcelPanel.Controls.Add(this.ExportExcel);
            this.ExcelPanel.Controls.Add(this.ListView1);
            this.ExcelPanel.Controls.Add(this.Label3);
            this.ExcelPanel.Controls.Add(this.chbS);
            this.ExcelPanel.Name = "ExcelPanel";
            // 
            // ExportExcel
            // 
            resources.ApplyResources(this.ExportExcel, "ExportExcel");
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.TabStop = true;
            this.ExportExcel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExportExcel_LinkClicked);
            // 
            // ListView1
            // 
            resources.ApplyResources(this.ListView1, "ListView1");
            this.ListView1.CheckBoxes = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1});
            this.ListView1.FullRowSelect = true;
            this.ListView1.HideSelection = false;
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            resources.ApplyResources(this.ColumnHeader1, "ColumnHeader1");
            // 
            // chbS
            // 
            resources.ApplyResources(this.chbS, "chbS");
            this.chbS.Name = "chbS";
            this.chbS.UseVisualStyleBackColor = true;
            this.chbS.CheckedChanged += new System.EventHandler(this.chbS_CheckedChanged);
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // SearchPanel
            // 
            resources.ApplyResources(this.SearchPanel, "SearchPanel");
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.ToolStrip3);
            this.SearchPanel.Controls.Add(this.ToolStrip2);
            this.SearchPanel.Controls.Add(this.Label4);
            this.SearchPanel.Name = "SearchPanel";
            // 
            // ToolStrip3
            // 
            resources.ApplyResources(this.ToolStrip3, "ToolStrip3");
            this.ToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1,
            this.ToolStripButton2});
            this.ToolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolStrip3.Name = "ToolStrip3";
            this.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip3_ItemClicked);
            // 
            // contextMenuStrip2
            // 
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.removesep});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.OwnerItem = this.ToolStripButton1;
            this.contextMenuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip2_ItemClicked);
            // 
            // removeToolStripMenuItem
            // 
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            // 
            // removesep
            // 
            resources.ApplyResources(this.removesep, "removesep");
            this.removesep.Name = "removesep";
            // 
            // ToolStrip2
            // 
            resources.ApplyResources(this.ToolStrip2, "ToolStrip2");
            this.ToolStrip2.CanOverflow = false;
            this.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip2.TabStop = true;
            this.ToolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip2_ItemClicked);
            this.ToolStrip2.SizeChanged += new System.EventHandler(this.ToolStrip2_SizeChanged);
            // 
            // bgwExcel
            // 
            this.bgwExcel.WorkerReportsProgress = true;
            this.bgwExcel.WorkerSupportsCancellation = true;
            this.bgwExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExcel_DoWork);
            this.bgwExcel.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwExcel_ProgressChanged);
            this.bgwExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExcel_RunWorkerCompleted);
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.BackColor = System.Drawing.Color.Khaki;
            this.Label3.Name = "Label3";
            // 
            // ToolStripButton1
            // 
            resources.ApplyResources(this.ToolStripButton1, "ToolStripButton1");
            this.ToolStripButton1.DropDown = this.contextMenuStrip2;
            this.ToolStripButton1.Name = "ToolStripButton1";
            // 
            // ToolStripButton2
            // 
            resources.ApplyResources(this.ToolStripButton2, "ToolStripButton2");
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.BackColor = System.Drawing.Color.Khaki;
            this.Label4.Name = "Label4";
            // 
            // NewToolStripButton
            // 
            resources.ApplyResources(this.NewToolStripButton, "NewToolStripButton");
            this.NewToolStripButton.Image = global::POS.Properties.Resources.ico_alpha_FolderOptions_16x16;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // EditToolStripButton1
            // 
            resources.ApplyResources(this.EditToolStripButton1, "EditToolStripButton1");
            this.EditToolStripButton1.Image = global::POS.Properties.Resources.ico_alpha_Rename_16x16;
            this.EditToolStripButton1.Name = "EditToolStripButton1";
            this.EditToolStripButton1.Click += new System.EventHandler(this.EditToolStripButton1_Click);
            // 
            // DeleteToolStripButton2
            // 
            resources.ApplyResources(this.DeleteToolStripButton2, "DeleteToolStripButton2");
            this.DeleteToolStripButton2.Image = global::POS.Properties.Resources.ico_alpha_Delete_16x16;
            this.DeleteToolStripButton2.Name = "DeleteToolStripButton2";
            this.DeleteToolStripButton2.Click += new System.EventHandler(this.DeleteToolStripButton2_Click);
            // 
            // ExcelTool
            // 
            resources.ApplyResources(this.ExcelTool, "ExcelTool");
            this.ExcelTool.Name = "ExcelTool";
            this.ExcelTool.Click += new System.EventHandler(this.ExcelTool_Click);
            // 
            // SearchTool
            // 
            resources.ApplyResources(this.SearchTool, "SearchTool");
            this.SearchTool.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.SearchTool.Name = "SearchTool";
            this.SearchTool.Click += new System.EventHandler(this.SearchTool_Click);
            // 
            // toolStripButton3
            // 
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::POS.Properties.Resources.Close_64;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // locationCode
            // 
            resources.ApplyResources(this.locationCode, "locationCode");
            this.locationCode.Name = "locationCode";
            this.locationCode.ReadOnly = true;
            // 
            // locationName
            // 
            resources.ApplyResources(this.locationName, "locationName");
            this.locationName.Name = "locationName";
            this.locationName.ReadOnly = true;
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // UserCode
            // 
            resources.ApplyResources(this.UserCode, "UserCode");
            this.UserCode.Name = "UserCode";
            this.UserCode.ReadOnly = true;
            // 
            // LOCATION_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ToolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOCATION_FRM";
            this.Load += new System.EventHandler(this.LOCATION_FRM_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
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