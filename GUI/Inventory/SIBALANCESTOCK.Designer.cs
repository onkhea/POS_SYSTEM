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
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelPanel = new System.Windows.Forms.Panel();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chbS = new System.Windows.Forms.CheckBox();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chbList = new System.Windows.Forms.CheckBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bgExcel = new System.ComponentModel.BackgroundWorker();
            this.Label3 = new System.Windows.Forms.Label();
            this.ExcelTool = new System.Windows.Forms.ToolStripButton();
            this.RefreshTool = new System.Windows.Forms.ToolStripButton();
            this.CloseToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.ExcelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            resources.ApplyResources(this.SplitContainer1, "SplitContainer1");
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            resources.ApplyResources(this.SplitContainer1.Panel1, "SplitContainer1.Panel1");
            this.SplitContainer1.Panel1.Controls.Add(this.dataGridViewX1);
            // 
            // SplitContainer1.Panel2
            // 
            resources.ApplyResources(this.SplitContainer1.Panel2, "SplitContainer1.Panel2");
            this.SplitContainer1.Panel2.Controls.Add(this.ExcelPanel);
            this.SplitContainer1.Panel2Collapsed = true;
            // 
            // dataGridViewX1
            // 
            resources.ApplyResources(this.dataGridViewX1, "dataGridViewX1");
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
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.StandardTab = true;
            // 
            // ContextMenuStrip1
            // 
            resources.ApplyResources(this.ContextMenuStrip1, "ContextMenuStrip1");
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcelToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.RefreshToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // ExcelToolStripMenuItem
            // 
            resources.ApplyResources(this.ExcelToolStripMenuItem, "ExcelToolStripMenuItem");
            this.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem";
            this.ExcelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolStripMenuItem_Click);
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
            this.ExcelPanel.Controls.Add(this.LinkLabel1);
            this.ExcelPanel.Controls.Add(this.ListView1);
            this.ExcelPanel.Controls.Add(this.Label3);
            this.ExcelPanel.Controls.Add(this.chbS);
            this.ExcelPanel.Name = "ExcelPanel";
            // 
            // LinkLabel1
            // 
            resources.ApplyResources(this.LinkLabel1, "LinkLabel1");
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
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
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "All Location.ico");
            this.ImageList1.Images.SetKeyName(1, "Location.ico");
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // chbList
            // 
            resources.ApplyResources(this.chbList, "chbList");
            this.chbList.Name = "chbList";
            this.chbList.UseVisualStyleBackColor = true;
            this.chbList.CheckedChanged += new System.EventHandler(this.chbList_CheckedChanged);
            // 
            // ToolStrip1
            // 
            resources.ApplyResources(this.ToolStrip1, "ToolStrip1");
            this.ToolStrip1.AllowItemReorder = true;
            this.ToolStrip1.ContextMenuStrip = this.ContextMenuStrip1;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcelTool,
            this.ToolStripSeparator1,
            this.RefreshTool,
            this.CloseToolStripButton1});
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
            // TreeView1
            // 
            resources.ApplyResources(this.TreeView1, "TreeView1");
            this.TreeView1.HideSelection = false;
            this.TreeView1.ImageList = this.ImageList1;
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("TreeView1.Nodes")))});
            this.TreeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView1_BeforeExpand);
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.TreeView1.Resize += new System.EventHandler(this.TreeView1_Resize);
            // 
            // Panel1
            // 
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Controls.Add(this.chbList);
            this.Panel1.Name = "Panel1";
            // 
            // SplitContainer2
            // 
            resources.ApplyResources(this.SplitContainer2, "SplitContainer2");
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            resources.ApplyResources(this.SplitContainer2.Panel1, "SplitContainer2.Panel1");
            this.SplitContainer2.Panel1.Controls.Add(this.TreeView1);
            this.SplitContainer2.Panel1.Controls.Add(this.Panel1);
            // 
            // SplitContainer2.Panel2
            // 
            resources.ApplyResources(this.SplitContainer2.Panel2, "SplitContainer2.Panel2");
            this.SplitContainer2.Panel2.Controls.Add(this.SplitContainer1);
            this.SplitContainer2.Panel2.Controls.Add(this.ToolStrip1);
            // 
            // bgExcel
            // 
            this.bgExcel.WorkerReportsProgress = true;
            this.bgExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgExcel_DoWork);
            this.bgExcel.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgExcel_ProgressChanged);
            this.bgExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgExcel_RunWorkerCompleted);
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.BackColor = System.Drawing.Color.Khaki;
            this.Label3.Name = "Label3";
            // 
            // ExcelTool
            // 
            resources.ApplyResources(this.ExcelTool, "ExcelTool");
            this.ExcelTool.Name = "ExcelTool";
            this.ExcelTool.Click += new System.EventHandler(this.ExcelTool_Click);
            // 
            // RefreshTool
            // 
            resources.ApplyResources(this.RefreshTool, "RefreshTool");
            this.RefreshTool.Name = "RefreshTool";
            this.RefreshTool.Click += new System.EventHandler(this.RefreshTool_Click);
            // 
            // CloseToolStripButton1
            // 
            resources.ApplyResources(this.CloseToolStripButton1, "CloseToolStripButton1");
            this.CloseToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseToolStripButton1.Image = global::POS.Properties.Resources.Close_64;
            this.CloseToolStripButton1.Name = "CloseToolStripButton1";
            this.CloseToolStripButton1.Click += new System.EventHandler(this.CloseToolStripButton1_Click_1);
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column10
            // 
            resources.ApplyResources(this.Column10, "Column10");
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column0
            // 
            resources.ApplyResources(this.Column0, "Column0");
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // SIBALANCESTOCK
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SIBALANCESTOCK";
            this.Load += new System.EventHandler(this.SIBALANCESTOCK_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ExcelPanel.ResumeLayout(false);
            this.ExcelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            this.SplitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
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
        internal System.Windows.Forms.ToolStripButton CloseToolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}