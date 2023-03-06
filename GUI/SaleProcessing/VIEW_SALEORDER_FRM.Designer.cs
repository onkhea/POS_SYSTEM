namespace POS.GUI.SaleProcessing
{
    partial class VIEW_SALEORDER_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEW_SALEORDER_FRM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.postInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.postInvoiceToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OkToolStrip = new System.Windows.Forms.ToolStripButton();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ORD_Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INV_REF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVCOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVTOTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVTOTAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVDISP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVDISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVTOTAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVGRAND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewX1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            // 
            // treeView1
            // 
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Name = "treeView1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes")))});
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Dossiers mises à jour.png");
            this.imageList1.Images.SetKeyName(1, "AQUA ICONS SYSTEM ALERT STOP.png");
            this.imageList1.Images.SetKeyName(2, "db_add.png");
            this.imageList1.Images.SetKeyName(3, "PublisherSZ.png");
            this.imageList1.Images.SetKeyName(4, "kexi.png");
            this.imageList1.Images.SetKeyName(5, "cal.png");
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridViewX1
            // 
            resources.ApplyResources(this.dataGridViewX1, "dataGridViewX1");
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.ORD_Ref,
            this.INV_REF,
            this.TransDate,
            this.CustomerCode,
            this.CustomerName,
            this.InvoiceValue,
            this.UserCode,
            this.DELCODE,
            this.INVCOM,
            this.INVTOTID,
            this.INVTOTAD,
            this.INVDISP,
            this.INVDISA,
            this.INVTOTAI,
            this.INVVAT,
            this.INVGRAND});
            this.dataGridViewX1.ContextMenuStrip = this.contextMenuStrip1;
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
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
            this.dataGridViewX1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postInvoicesToolStripMenuItem,
            this.saleOrderToolStripMenuItem,
            this.okToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // postInvoicesToolStripMenuItem
            // 
            resources.ApplyResources(this.postInvoicesToolStripMenuItem, "postInvoicesToolStripMenuItem");
            this.postInvoicesToolStripMenuItem.Name = "postInvoicesToolStripMenuItem";
            this.postInvoicesToolStripMenuItem.Click += new System.EventHandler(this.postInvoicesToolStripMenuItem_Click);
            // 
            // saleOrderToolStripMenuItem
            // 
            resources.ApplyResources(this.saleOrderToolStripMenuItem, "saleOrderToolStripMenuItem");
            this.saleOrderToolStripMenuItem.Name = "saleOrderToolStripMenuItem";
            // 
            // okToolStripMenuItem
            // 
            resources.ApplyResources(this.okToolStripMenuItem, "okToolStripMenuItem");
            this.okToolStripMenuItem.Name = "okToolStripMenuItem";
            this.okToolStripMenuItem.Click += new System.EventHandler(this.okToolStripMenuItem_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Name = "panel1";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.OkToolStrip});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postInvoiceToolStrip});
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // postInvoiceToolStrip
            // 
            resources.ApplyResources(this.postInvoiceToolStrip, "postInvoiceToolStrip");
            this.postInvoiceToolStrip.Name = "postInvoiceToolStrip";
            this.postInvoiceToolStrip.Click += new System.EventHandler(this.postInvoiceToolStrip_Click);
            // 
            // OkToolStrip
            // 
            resources.ApplyResources(this.OkToolStrip, "OkToolStrip");
            this.OkToolStrip.Name = "OkToolStrip";
            this.OkToolStrip.Click += new System.EventHandler(this.OkToolStrip_Click);
            // 
            // check
            // 
            this.check.FalseValue = "False";
            resources.ApplyResources(this.check, "check");
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.TrueValue = "True";
            // 
            // ORD_Ref
            // 
            resources.ApplyResources(this.ORD_Ref, "ORD_Ref");
            this.ORD_Ref.Name = "ORD_Ref";
            this.ORD_Ref.ReadOnly = true;
            // 
            // INV_REF
            // 
            resources.ApplyResources(this.INV_REF, "INV_REF");
            this.INV_REF.Name = "INV_REF";
            this.INV_REF.ReadOnly = true;
            // 
            // TransDate
            // 
            resources.ApplyResources(this.TransDate, "TransDate");
            this.TransDate.Name = "TransDate";
            this.TransDate.ReadOnly = true;
            // 
            // CustomerCode
            // 
            resources.ApplyResources(this.CustomerCode, "CustomerCode");
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.ReadOnly = true;
            // 
            // CustomerName
            // 
            resources.ApplyResources(this.CustomerName, "CustomerName");
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // InvoiceValue
            // 
            resources.ApplyResources(this.InvoiceValue, "InvoiceValue");
            this.InvoiceValue.Name = "InvoiceValue";
            this.InvoiceValue.ReadOnly = true;
            // 
            // UserCode
            // 
            resources.ApplyResources(this.UserCode, "UserCode");
            this.UserCode.Name = "UserCode";
            // 
            // DELCODE
            // 
            resources.ApplyResources(this.DELCODE, "DELCODE");
            this.DELCODE.Name = "DELCODE";
            // 
            // INVCOM
            // 
            resources.ApplyResources(this.INVCOM, "INVCOM");
            this.INVCOM.Name = "INVCOM";
            // 
            // INVTOTID
            // 
            resources.ApplyResources(this.INVTOTID, "INVTOTID");
            this.INVTOTID.Name = "INVTOTID";
            // 
            // INVTOTAD
            // 
            resources.ApplyResources(this.INVTOTAD, "INVTOTAD");
            this.INVTOTAD.Name = "INVTOTAD";
            // 
            // INVDISP
            // 
            resources.ApplyResources(this.INVDISP, "INVDISP");
            this.INVDISP.Name = "INVDISP";
            // 
            // INVDISA
            // 
            resources.ApplyResources(this.INVDISA, "INVDISA");
            this.INVDISA.Name = "INVDISA";
            // 
            // INVTOTAI
            // 
            resources.ApplyResources(this.INVTOTAI, "INVTOTAI");
            this.INVTOTAI.Name = "INVTOTAI";
            // 
            // INVVAT
            // 
            resources.ApplyResources(this.INVVAT, "INVVAT");
            this.INVVAT.Name = "INVVAT";
            // 
            // INVGRAND
            // 
            resources.ApplyResources(this.INVGRAND, "INVGRAND");
            this.INVGRAND.Name = "INVGRAND";
            // 
            // VIEW_SALEORDER_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VIEW_SALEORDER_FRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.VIEW_SALEORDER_FRM_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OkToolStrip;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem postInvoiceToolStrip;
        public DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        internal System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem postInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD_Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn INV_REF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVCOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVTOTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVTOTAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVDISP;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVDISA;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVTOTAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVGRAND;
    }
}