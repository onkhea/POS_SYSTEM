namespace POS.GUI.Inventory
{
    partial class SIBALANCESTOCK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIBALANCESTOCK));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("All Locations", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ExcelPanel = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.chbS = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbList = new System.Windows.Forms.CheckBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExcelTool = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshTool = new System.Windows.Forms.ToolStripButton();
            this.CloseToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bgExcel = new System.ComponentModel.BackgroundWorker();
            this.ExcelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "All Location.ico");
            this.ImageList1.Images.SetKeyName(1, "Location.ico");
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Column Name";
            this.ColumnHeader1.Width = 200;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(-58, 364);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(77, 13);
            this.LinkLabel1.TabIndex = 11;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "&Export to excel";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // ListView1
            // 
            this.ListView1.CheckBoxes = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1});
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListView1.FullRowSelect = true;
            this.ListView1.Location = new System.Drawing.Point(0, 25);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(23, 329);
            this.ListView1.TabIndex = 10;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ExcelPanel
            // 
            this.ExcelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExcelPanel.Controls.Add(this.LinkLabel1);
            this.ExcelPanel.Controls.Add(this.ListView1);
            this.ExcelPanel.Controls.Add(this.Label3);
            this.ExcelPanel.Controls.Add(this.chbS);
            this.ExcelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExcelPanel.Location = new System.Drawing.Point(0, 0);
            this.ExcelPanel.Name = "ExcelPanel";
            this.ExcelPanel.Size = new System.Drawing.Size(25, 387);
            this.ExcelPanel.TabIndex = 13;
            this.ExcelPanel.Visible = false;
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
            this.Label3.Size = new System.Drawing.Size(23, 25);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "    Select columns to export";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chbS
            // 
            this.chbS.AutoSize = true;
            this.chbS.Location = new System.Drawing.Point(3, 363);
            this.chbS.Name = "chbS";
            this.chbS.Size = new System.Drawing.Size(70, 17);
            this.chbS.TabIndex = 2;
            this.chbS.Text = "Select A&ll";
            this.chbS.UseVisualStyleBackColor = true;
            this.chbS.CheckedChanged += new System.EventHandler(this.chbS_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcelToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.RefreshToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenuStrip1.Size = new System.Drawing.Size(133, 54);
            // 
            // ExcelToolStripMenuItem
            // 
            this.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem";
            this.ExcelToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ExcelToolStripMenuItem.Text = "&Excel";
            this.ExcelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolStripMenuItem_Click);
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
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 25);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.dataGridViewX1);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SplitContainer1.Panel1MinSize = 200;
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.ExcelPanel);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SplitContainer1.Panel2Collapsed = true;
            this.SplitContainer1.Size = new System.Drawing.Size(732, 505);
            this.SplitContainer1.SplitterDistance = 426;
            this.SplitContainer1.TabIndex = 3;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AllowUserToResizeRows = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column10,
            this.Column0,
            this.Column1,
            this.Column3,
            this.Column7,
            this.Column5});
            this.dataGridViewX1.ContextMenuStrip = this.ContextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(732, 505);
            this.dataGridViewX1.StandardTab = true;
            this.dataGridViewX1.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Location Code";
            this.Column4.MinimumWidth = 2;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Item Code";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 110;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "Item Description";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Width = 190;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Unit of Stock";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Physical";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column7
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column7.HeaderText = "On Order";
            this.Column7.MinimumWidth = 2;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Free";
            this.Column5.MinimumWidth = 2;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // chbList
            // 
            this.chbList.AutoSize = true;
            this.chbList.Location = new System.Drawing.Point(9, 4);
            this.chbList.Name = "chbList";
            this.chbList.Size = new System.Drawing.Size(108, 17);
            this.chbList.TabIndex = 0;
            this.chbList.Text = "Show list all items";
            this.chbList.UseVisualStyleBackColor = true;
            this.chbList.CheckedChanged += new System.EventHandler(this.chbList_CheckedChanged);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AllowItemReorder = true;
            this.ToolStrip1.ContextMenuStrip = this.ContextMenuStrip1;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcelTool,
            this.ToolStripSeparator1,
            this.RefreshTool,
            this.CloseToolStripButton1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(732, 25);
            this.ToolStrip1.Stretch = true;
            this.ToolStrip1.TabIndex = 2;
            this.ToolStrip1.TabStop = true;
            this.ToolStrip1.Text = "ToolStrip1";
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
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RefreshTool
            // 
            this.RefreshTool.Image = ((System.Drawing.Image)(resources.GetObject("RefreshTool.Image")));
            this.RefreshTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshTool.Name = "RefreshTool";
            this.RefreshTool.Size = new System.Drawing.Size(68, 22);
            this.RefreshTool.Text = "&Refresh";
            this.RefreshTool.Click += new System.EventHandler(this.RefreshTool_Click);
            // 
            // CloseToolStripButton1
            // 
            this.CloseToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseToolStripButton1.Image = global::POS.Properties.Resources.Close_64;
            this.CloseToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseToolStripButton1.Name = "CloseToolStripButton1";
            this.CloseToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.CloseToolStripButton1.Text = "&Close";
            this.CloseToolStripButton1.Click += new System.EventHandler(this.CloseToolStripButton1_Click_1);
            // 
            // TreeView1
            // 
            this.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView1.HideSelection = false;
            this.TreeView1.ImageIndex = 0;
            this.TreeView1.ImageList = this.ImageList1;
            this.TreeView1.Location = new System.Drawing.Point(0, 24);
            this.TreeView1.Name = "TreeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node0";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Node0";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "Node0";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Tag = "ALL";
            treeNode2.Text = "All Locations";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.TreeView1.SelectedImageIndex = 0;
            this.TreeView1.Size = new System.Drawing.Size(205, 506);
            this.TreeView1.TabIndex = 0;
            this.TreeView1.Resize += new System.EventHandler(this.TreeView1_Resize);
            this.TreeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView1_BeforeExpand);
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.chbList);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(205, 24);
            this.Panel1.TabIndex = 1;
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.TreeView1);
            this.SplitContainer2.Panel1.Controls.Add(this.Panel1);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.SplitContainer1);
            this.SplitContainer2.Panel2.Controls.Add(this.ToolStrip1);
            this.SplitContainer2.Size = new System.Drawing.Size(941, 530);
            this.SplitContainer2.SplitterDistance = 205;
            this.SplitContainer2.TabIndex = 2;
            // 
            // bgExcel
            // 
            this.bgExcel.WorkerReportsProgress = true;
            this.bgExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgExcel_DoWork);
            this.bgExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgExcel_RunWorkerCompleted);
            this.bgExcel.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgExcel_ProgressChanged);
            // 
            // SIBALANCESTOCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 530);
            this.Controls.Add(this.SplitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SIBALANCESTOCK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Balance";
            this.Load += new System.EventHandler(this.SIBALANCESTOCK_Load);
            this.ExcelPanel.ResumeLayout(false);
            this.ExcelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            this.SplitContainer2.Panel2.PerformLayout();
            this.SplitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.Panel ExcelPanel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.CheckBox chbS;
        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ExcelToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        internal System.Windows.Forms.CheckBox chbList;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ExcelTool;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton RefreshTool;
        internal System.Windows.Forms.TreeView TreeView1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        private System.ComponentModel.BackgroundWorker bgExcel;
//        private SkinSoft.OSSkin.OSSkin osSkin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.ToolStripButton CloseToolStripButton1;

    }
}