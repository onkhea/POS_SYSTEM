namespace POS.GUI.Inventory
{
    partial class SIHELDMOVEMENT_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIHELDMOVEMENT_FRM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Sequance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move_Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToTalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.ToolStrip1.SuspendLayout();
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
            this.SplitContainer1.Panel1.Controls.Add(this.TreeView1);
            // 
            // SplitContainer1.Panel2
            // 
            resources.ApplyResources(this.SplitContainer1.Panel2, "SplitContainer1.Panel2");
            this.SplitContainer1.Panel2.Controls.Add(this.dataGridViewX1);
            this.SplitContainer1.Panel2.Controls.Add(this.ToolStrip1);
            // 
            // TreeView1
            // 
            resources.ApplyResources(this.TreeView1, "TreeView1");
            this.TreeView1.FullRowSelect = true;
            this.TreeView1.HideSelection = false;
            this.TreeView1.ImageList = this.ImageList1;
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("TreeView1.Nodes")))});
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "AllQuotation.ico");
            this.ImageList1.Images.SetKeyName(1, "Hold.ico");
            this.ImageList1.Images.SetKeyName(2, "Reject.ico");
            this.ImageList1.Images.SetKeyName(3, "Approve.ico");
            this.ImageList1.Images.SetKeyName(4, "Convert.ico");
            // 
            // dataGridViewX1
            // 
            resources.ApplyResources(this.dataGridViewX1, "dataGridViewX1");
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sequance,
            this.Move_Ref,
            this.TranType,
            this.MoveDate,
            this.Qty,
            this.ToTalAmount,
            this.UserCode});
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
            this.dataGridViewX1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewX1_KeyDown);
            // 
            // ToolStrip1
            // 
            resources.ApplyResources(this.ToolStrip1, "ToolStrip1");
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDropDownButton1,
            this.ToolStripSeparator1,
            this.ToolStripButton2});
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // ToolStripSeparator1
            // 
            resources.ApplyResources(this.ToolStripSeparator1, "ToolStripSeparator1");
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            // 
            // ToolStripDropDownButton1
            // 
            resources.ApplyResources(this.ToolStripDropDownButton1, "ToolStripDropDownButton1");
            this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            // 
            // DeleteToolStripMenuItem
            // 
            resources.ApplyResources(this.DeleteToolStripMenuItem, "DeleteToolStripMenuItem");
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ToolStripButton2
            // 
            resources.ApplyResources(this.ToolStripButton2, "ToolStripButton2");
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // Sequance
            // 
            resources.ApplyResources(this.Sequance, "Sequance");
            this.Sequance.Name = "Sequance";
            this.Sequance.ReadOnly = true;
            // 
            // Move_Ref
            // 
            resources.ApplyResources(this.Move_Ref, "Move_Ref");
            this.Move_Ref.Name = "Move_Ref";
            // 
            // TranType
            // 
            resources.ApplyResources(this.TranType, "TranType");
            this.TranType.Name = "TranType";
            this.TranType.ReadOnly = true;
            // 
            // MoveDate
            // 
            resources.ApplyResources(this.MoveDate, "MoveDate");
            this.MoveDate.Name = "MoveDate";
            this.MoveDate.ReadOnly = true;
            // 
            // Qty
            // 
            resources.ApplyResources(this.Qty, "Qty");
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // ToTalAmount
            // 
            resources.ApplyResources(this.ToTalAmount, "ToTalAmount");
            this.ToTalAmount.Name = "ToTalAmount";
            this.ToTalAmount.ReadOnly = true;
            // 
            // UserCode
            // 
            resources.ApplyResources(this.UserCode, "UserCode");
            this.UserCode.Name = "UserCode";
            this.UserCode.ReadOnly = true;
            // 
            // SIHELDMOVEMENT_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SIHELDMOVEMENT_FRM";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.SIHELDMOVEMENT_FRM_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton1;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        public System.Windows.Forms.TreeView TreeView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move_Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToTalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCode;
        //        private SkinSoft.OSSkin.OSSkin osSkin1;
    }
}