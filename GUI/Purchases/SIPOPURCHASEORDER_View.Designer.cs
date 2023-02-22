namespace POS.GUI.Purchases
{
    partial class SIPOPURCHASEORDER_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIPOPURCHASEORDER_View));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Held", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Held");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Release", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("All Purchases Order", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrintOrder = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Ok = new System.Windows.Forms.ToolStripButton();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
//            this.osSkin1 = new SkinSoft.OSSkin.OSSkin(this.components);
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.osSkin1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDropDownButton1,
            this.ToolStripSeparator1,
            this.btnPrintOrder,
            this.ToolStripSeparator2,
            this.btn_Ok});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(619, 25);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripDropDownButton1
            // 
            this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.ToolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripDropDownButton1.Image")));
            this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            this.ToolStripDropDownButton1.Size = new System.Drawing.Size(66, 22);
            this.ToolStripDropDownButton1.Text = "&Action";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripMenuItem.Image")));
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.DeleteToolStripMenuItem.Text = "Quick Print";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintOrder.Image")));
            this.btnPrintOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(80, 22);
            this.btnPrintOrder.Text = "Print Order";
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ok.Image")));
            this.btn_Ok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(53, 22);
            this.btn_Ok.Text = "&OK    ";
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.HeaderText = "Discount Amount";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            this.Column6.Width = 56;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.HeaderText = "Delivery Name";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 120;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Delivery Code";
            this.Column17.Name = "Column17";
            this.Column17.Visible = false;
            this.Column17.Width = 98;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "Supplier Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "Amount After Discount";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.HeaderText = "Discount Percent";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            this.Column9.Width = 120;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Status";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            this.Column13.Width = 62;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Grand Total";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "VAT";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            this.Column12.Width = 53;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column11.HeaderText = "Amount After Discount";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            this.Column11.Width = 150;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column10.HeaderText = "Discount Amount";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            this.Column10.Width = 120;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Suplier Code";
            this.Column16.Name = "Column16";
            this.Column16.Visible = false;
            this.Column16.Width = 92;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "Order Comment";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            this.Column3.Width = 120;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "AllQuotation.ico");
            this.ImageList1.Images.SetKeyName(1, "Hold.ico");
            this.ImageList1.Images.SetKeyName(2, "Post.ico");
            this.ImageList1.Images.SetKeyName(3, "Approve.ico");
            this.ImageList1.Images.SetKeyName(4, "Convert.ico");
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Order Date";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column15
            // 
            this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column15.HeaderText = "Order Ref";
            this.Column15.Name = "Column15";
            this.Column15.Width = 150;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column1,
            this.Column3,
            this.Column16,
            this.Column4,
            this.Column17,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column2,
            this.Column13,
            this.Column14});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView1.GridColor = System.Drawing.Color.Silver;
            this.DataGridView1.Location = new System.Drawing.Point(0, 25);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 40;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(619, 500);
            this.DataGridView1.StandardTab = true;
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column14.HeaderText = "User Code";
            this.Column14.Name = "Column14";
            // 
            // TreeView1
            // 
            this.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView1.FullRowSelect = true;
            this.TreeView1.HideSelection = false;
            this.TreeView1.ImageIndex = 0;
            this.TreeView1.ImageList = this.ImageList1;
            this.TreeView1.Location = new System.Drawing.Point(0, 0);
            this.TreeView1.Name = "TreeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node0";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Tag = "Held";
            treeNode1.Text = "Held";
            treeNode1.ToolTipText = "Held Quotation";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "00";
            treeNode2.SelectedImageKey = "Hold.ico";
            treeNode2.Tag = "Held";
            treeNode2.Text = "Held";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "70";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Tag = "Release";
            treeNode3.Text = "Release";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Node0";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Tag = "ALL";
            treeNode4.Text = "All Purchases Order";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4});
            this.TreeView1.SelectedImageIndex = 0;
            this.TreeView1.Size = new System.Drawing.Size(150, 525);
            this.TreeView1.TabIndex = 0;
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.TreeView1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.DataGridView1);
            this.SplitContainer1.Panel2.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Size = new System.Drawing.Size(773, 525);
            this.SplitContainer1.SplitterDistance = 150;
            this.SplitContainer1.TabIndex = 6;
            // 
            // osSkin1
            // 
//            this.osSkin1.Style = SkinSoft.OSSkin.SkinStyle.MacOSXAqua;
            // 
            // SIPOPURCHASEORDER_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 525);
            this.Controls.Add(this.SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SIPOPURCHASEORDER_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Purchase Order";
            this.Load += new System.EventHandler(this.SIPOPURCHASEORDER_View_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SIPOPURCHASEORDER_View_KeyDown);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            this.SplitContainer1.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.osSkin1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton1;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btnPrintOrder;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton btn_Ok;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        internal System.Windows.Forms.TreeView TreeView1;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
//        private SkinSoft.OSSkin.OSSkin osSkin1;
    }
}