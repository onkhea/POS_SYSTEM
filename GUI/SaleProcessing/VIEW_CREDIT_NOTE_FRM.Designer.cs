namespace POS.GUI.SaleProcessing
{
    partial class VIEW_CREDIT_NOTE_FRM
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All Post Invoices");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("All Credit Notes");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEW_CREDIT_NOTE_FRM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewX1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(774, 420);
            this.splitContainer1.SplitterDistance = 159;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "AllPosts";
            treeNode1.Text = "All Post Invoices";
            treeNode2.Name = "AllCredit";
            treeNode2.Text = "All Credit Notes";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(159, 420);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "AQUA ICONS FOLDER (DROP).png");
            this.imageList1.Images.SetKeyName(1, "AQUA ICONS FOLDER OPENED.png");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
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
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(611, 395);
            this.dataGridViewX1.TabIndex = 2;
            this.dataGridViewX1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellDoubleClick);
            this.dataGridViewX1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
            // 
            // chk
            // 
            this.chk.HeaderText = ".";
            this.chk.Name = "chk";
            this.chk.ReadOnly = true;
            this.chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk.Width = 20;
            // 
            // ORD_Ref
            // 
            this.ORD_Ref.HeaderText = "Transaction Reference";
            this.ORD_Ref.Name = "ORD_Ref";
            this.ORD_Ref.ReadOnly = true;
            this.ORD_Ref.Width = 150;
            // 
            // INV_REF
            // 
            this.INV_REF.HeaderText = "INV REF";
            this.INV_REF.Name = "INV_REF";
            this.INV_REF.ReadOnly = true;
            this.INV_REF.Visible = false;
            // 
            // TransDate
            // 
            this.TransDate.HeaderText = "Trans. Date";
            this.TransDate.Name = "TransDate";
            this.TransDate.ReadOnly = true;
            this.TransDate.Width = 120;
            // 
            // CustomerCode
            // 
            this.CustomerCode.HeaderText = "CustomerCode";
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.ReadOnly = true;
            this.CustomerCode.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 120;
            // 
            // InvoiceValue
            // 
            this.InvoiceValue.HeaderText = "Invoice Value";
            this.InvoiceValue.Name = "InvoiceValue";
            this.InvoiceValue.ReadOnly = true;
            this.InvoiceValue.Width = 120;
            // 
            // UserCode
            // 
            this.UserCode.HeaderText = "User Code";
            this.UserCode.Name = "UserCode";
            this.UserCode.ReadOnly = true;
            // 
            // DELCODE
            // 
            this.DELCODE.HeaderText = "DELCODE";
            this.DELCODE.Name = "DELCODE";
            this.DELCODE.ReadOnly = true;
            this.DELCODE.Visible = false;
            // 
            // INVCOM
            // 
            this.INVCOM.HeaderText = "INVCOM";
            this.INVCOM.Name = "INVCOM";
            this.INVCOM.ReadOnly = true;
            this.INVCOM.Visible = false;
            // 
            // INVTOTID
            // 
            this.INVTOTID.HeaderText = "INVTOTID";
            this.INVTOTID.Name = "INVTOTID";
            this.INVTOTID.ReadOnly = true;
            this.INVTOTID.Visible = false;
            // 
            // INVTOTAD
            // 
            this.INVTOTAD.HeaderText = "INVTOTAD";
            this.INVTOTAD.Name = "INVTOTAD";
            this.INVTOTAD.ReadOnly = true;
            this.INVTOTAD.Visible = false;
            // 
            // INVDISP
            // 
            this.INVDISP.HeaderText = "INVDISP";
            this.INVDISP.Name = "INVDISP";
            this.INVDISP.ReadOnly = true;
            this.INVDISP.Visible = false;
            // 
            // INVDISA
            // 
            this.INVDISA.HeaderText = "INVDISA";
            this.INVDISA.Name = "INVDISA";
            this.INVDISA.ReadOnly = true;
            this.INVDISA.Visible = false;
            // 
            // INVTOTAI
            // 
            this.INVTOTAI.HeaderText = "INVTOTAI";
            this.INVTOTAI.Name = "INVTOTAI";
            this.INVTOTAI.ReadOnly = true;
            this.INVTOTAI.Visible = false;
            // 
            // INVVAT
            // 
            this.INVVAT.HeaderText = "INVVAT";
            this.INVVAT.Name = "INVVAT";
            this.INVVAT.ReadOnly = true;
            this.INVVAT.Visible = false;
            // 
            // INVGRAND
            // 
            this.INVGRAND.HeaderText = "INVGRAND";
            this.INVGRAND.Name = "INVGRAND";
            this.INVGRAND.ReadOnly = true;
            this.INVGRAND.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(611, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton1.Text = "&Ok";
            // 
            // VIEW_CREDIT_NOTE_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 420);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VIEW_CREDIT_NOTE_FRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Credit Note";
            this.Load += new System.EventHandler(this.VIEW_CREDIT_NOTE_FRM_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ImageList imageList1;
        public DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
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
        internal System.Windows.Forms.TreeView treeView1;

    }
}