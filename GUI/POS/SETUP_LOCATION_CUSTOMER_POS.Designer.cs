using POS.DataLayer;

namespace POS.GUI.POS
{
    partial class SetupLocationCustomerPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupLocationCustomerPos));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("All Locations", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.EditToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.CloseTool = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PanelAnalM = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContextMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPriceBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label2 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DeleteToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.CloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.PanelAnalM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.ContextMain.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripButton.Image")));
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(57, 24);
            this.NewToolStripButton.Text = "&New  ";
            this.NewToolStripButton.ToolTipText = "New User";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(179, 22);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Location";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditToolStripButton1
            // 
            this.EditToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripButton1.Image")));
            this.EditToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton1.Name = "EditToolStripButton1";
            this.EditToolStripButton1.Size = new System.Drawing.Size(53, 24);
            this.EditToolStripButton1.Text = "&Edit  ";
            this.EditToolStripButton1.Click += new System.EventHandler(this.EditToolStripButton1_Click);
            // 
            // CloseTool
            // 
            this.CloseTool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseTool.Image = global::POS.Properties.Resources.Close_64;
            this.CloseTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseTool.Name = "CloseTool";
            this.CloseTool.Size = new System.Drawing.Size(23, 24);
            this.CloseTool.Text = "&Close";
            this.CloseTool.Click += new System.EventHandler(this.CloseTool_Click);
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
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.PanelAnalM);
            this.SplitContainer1.Size = new System.Drawing.Size(953, 519);
            this.SplitContainer1.SplitterDistance = 179;
            this.SplitContainer1.TabIndex = 3;
            // 
            // TreeView1
            // 
            this.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView1.HideSelection = false;
            this.TreeView1.ImageIndex = 0;
            this.TreeView1.ImageList = this.ImageList1;
            this.TreeView1.Location = new System.Drawing.Point(0, 22);
            this.TreeView1.Name = "TreeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node0";
            treeNode2.Tag = "ROOT";
            treeNode2.Text = "All Locations";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.TreeView1.SelectedImageIndex = 0;
            this.TreeView1.Size = new System.Drawing.Size(179, 497);
            this.TreeView1.TabIndex = 5;
            this.TreeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView1_BeforeExpand);
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "AllCustomer.ico");
            this.ImageList1.Images.SetKeyName(1, "Customer.ico");
            // 
            // PanelAnalM
            // 
            this.PanelAnalM.Controls.Add(this.DataGridView1);
            this.PanelAnalM.Controls.Add(this.Label2);
            this.PanelAnalM.Controls.Add(this.ToolStrip1);
            this.PanelAnalM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAnalM.Location = new System.Drawing.Point(0, 0);
            this.PanelAnalM.Name = "PanelAnalM";
            this.PanelAnalM.Size = new System.Drawing.Size(770, 519);
            this.PanelAnalM.TabIndex = 4;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Customercode,
            this.CustomerName,
            this.UserCode,
            this.UserName,
            this.Column13,
            this.Column21,
            this.Column12});
            this.DataGridView1.ContextMenuStrip = this.ContextMain;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 49);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(770, 470);
            this.DataGridView1.StandardTab = true;
            this.DataGridView1.TabIndex = 4;
            // 
            // ContextMain
            // 
            this.ContextMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionToolStripMenuItem,
            this.EditPriceBookToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.RefreshToolStripMenuItem});
            this.ContextMain.Name = "ContextMain";
            this.ContextMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMain.Size = new System.Drawing.Size(133, 76);
            // 
            // ActionToolStripMenuItem
            // 
            this.ActionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewsToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem";
            this.ActionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ActionToolStripMenuItem.Text = "&Actions";
            // 
            // NewsToolStripMenuItem
            // 
            this.NewsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NewsToolStripMenuItem.Image")));
            this.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem";
            this.NewsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.NewsToolStripMenuItem.Text = "&New";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripMenuItem.Image")));
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripMenuItem.Image")));
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.DeleteToolStripMenuItem.Text = "&Delete";
            // 
            // EditPriceBookToolStripMenuItem
            // 
            this.EditPriceBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloneToolStripMenuItem1,
            this.PasteToolStripMenuItem1});
            this.EditPriceBookToolStripMenuItem.Name = "EditPriceBookToolStripMenuItem";
            this.EditPriceBookToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.EditPriceBookToolStripMenuItem.Text = "&Tools";
            // 
            // CloneToolStripMenuItem1
            // 
            this.CloneToolStripMenuItem1.Name = "CloneToolStripMenuItem1";
            this.CloneToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CloneToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.CloneToolStripMenuItem1.Text = "&Clone";
            // 
            // PasteToolStripMenuItem1
            // 
            this.PasteToolStripMenuItem1.Enabled = false;
            this.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1";
            this.PasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.PasteToolStripMenuItem1.Text = "&Paste";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.RefreshToolStripMenuItem.Text = "&Refresh";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(0, 27);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(770, 22);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Relation Employee with Customer";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseTool,
            this.NewToolStripButton,
            this.EditToolStripButton1,
            this.DeleteToolStripButton2,
            this.ToolStripSplitButton1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(770, 27);
            this.ToolStrip1.TabIndex = 0;
            this.ToolStrip1.TabStop = true;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // DeleteToolStripButton2
            // 
            this.DeleteToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton2.Image")));
            this.DeleteToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton2.Name = "DeleteToolStripButton2";
            this.DeleteToolStripButton2.Size = new System.Drawing.Size(63, 24);
            this.DeleteToolStripButton2.Text = "&Delete ";
            this.DeleteToolStripButton2.Click += new System.EventHandler(this.DeleteToolStripButton2_Click);
            // 
            // ToolStripSplitButton1
            // 
            this.ToolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloneToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.ToolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripSplitButton1.Image")));
            this.ToolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            this.ToolStripSplitButton1.Size = new System.Drawing.Size(69, 24);
            this.ToolStripSplitButton1.Text = "T&ools";
            // 
            // CloneToolStripMenuItem
            // 
            this.CloneToolStripMenuItem.Name = "CloneToolStripMenuItem";
            this.CloneToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.CloneToolStripMenuItem.Text = "&Clone";
            this.CloneToolStripMenuItem.Click += new System.EventHandler(this.CloneToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Enabled = false;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.PasteToolStripMenuItem.Text = "&Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Location Code";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Location Name";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 120;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Employee Code";
            this.Column10.MinimumWidth = 2;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 120;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Employee Name";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 120;
            // 
            // Customercode
            // 
            this.Customercode.HeaderText = "Customer Code";
            this.Customercode.Name = "Customercode";
            this.Customercode.ReadOnly = true;
            this.Customercode.Width = 120;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 120;
            // 
            // UserCode
            // 
            this.UserCode.HeaderText = "User Code";
            this.UserCode.Name = "UserCode";
            this.UserCode.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Created Date";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            this.Column13.Width = 150;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Updated Date";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Visible = false;
            this.Column21.Width = 150;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "User Code";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // SetupLocationCustomerPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 519);
            this.Controls.Add(this.SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupLocationCustomerPos";
            this.Text = "Setup Location with customer";
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            this.PanelAnalM.ResumeLayout(false);
            this.PanelAnalM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ContextMain.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton NewToolStripButton;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ToolStripButton EditToolStripButton1;
        internal System.Windows.Forms.ToolStripButton CloseTool;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.TreeView TreeView1;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.Panel PanelAnalM;
        internal System.Windows.Forms.ContextMenuStrip ContextMain;
        internal System.Windows.Forms.ToolStripMenuItem ActionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem NewsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditPriceBookToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloneToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton DeleteToolStripButton2;
        internal System.Windows.Forms.ToolStripDropDownButton ToolStripSplitButton1;
        internal System.Windows.Forms.ToolStripMenuItem CloneToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private readonly DataManager dataManager = new DataManager();
        public System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}