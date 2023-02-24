namespace POS.GUI.User
{
    partial class GROUP_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GROUP_FRM));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListView2 = new System.Windows.Forms.ListView();
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserToolStrip = new System.Windows.Forms.ToolStripButton();
            this.RemoveToolStrip = new System.Windows.Forms.ToolStripButton();
            this.NewToolStrip = new System.Windows.Forms.ToolStripButton();
            this.EditToolStrip = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStrip = new System.Windows.Forms.ToolStripButton();
            this.PermissionToolStrip = new System.Windows.Forms.ToolStripButton();
            this.CloseToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.ToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStrip,
            this.EditToolStrip,
            this.DeleteToolStrip,
            this.PermissionToolStrip,
            this.CloseToolStripButton1});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.ListView1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.ListView2);
            this.splitContainer1.Panel2.Controls.Add(this.ToolStrip2);
            // 
            // ListView1
            // 
            resources.ApplyResources(this.ListView1, "ListView1");
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader6});
            this.ListView1.ContextMenuStrip = this.ContextMenuStrip1;
            this.ListView1.FullRowSelect = true;
            this.ListView1.HideSelection = false;
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            resources.ApplyResources(this.ColumnHeader1, "ColumnHeader1");
            // 
            // ColumnHeader2
            // 
            resources.ApplyResources(this.ColumnHeader2, "ColumnHeader2");
            // 
            // ColumnHeader6
            // 
            resources.ApplyResources(this.ColumnHeader6, "ColumnHeader6");
            // 
            // ContextMenuStrip1
            // 
            resources.ApplyResources(this.ContextMenuStrip1, "ContextMenuStrip1");
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionToolStripMenuItem,
            this.PermissionToolStripMenuItem,
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
            // PermissionToolStripMenuItem
            // 
            resources.ApplyResources(this.PermissionToolStripMenuItem, "PermissionToolStripMenuItem");
            this.PermissionToolStripMenuItem.Name = "PermissionToolStripMenuItem";
            this.PermissionToolStripMenuItem.Click += new System.EventHandler(this.PermissionToolStripMenuItem_Click);
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
            // ListView2
            // 
            resources.ApplyResources(this.ListView2, "ListView2");
            this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.ListView2.FullRowSelect = true;
            this.ListView2.HideSelection = false;
            this.ListView2.MultiSelect = false;
            this.ListView2.Name = "ListView2";
            this.ListView2.UseCompatibleStateImageBehavior = false;
            this.ListView2.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader3
            // 
            resources.ApplyResources(this.ColumnHeader3, "ColumnHeader3");
            // 
            // ColumnHeader4
            // 
            resources.ApplyResources(this.ColumnHeader4, "ColumnHeader4");
            // 
            // ToolStrip2
            // 
            resources.ApplyResources(this.ToolStrip2, "ToolStrip2");
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUserToolStrip,
            this.ToolStripSeparator3,
            this.RemoveToolStrip});
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // ToolStripSeparator3
            // 
            resources.ApplyResources(this.ToolStripSeparator3, "ToolStripSeparator3");
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "GROUP.ico");
            this.ImageList1.Images.SetKeyName(1, "GROUP-DIS.ico");
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
            // AddUserToolStrip
            // 
            resources.ApplyResources(this.AddUserToolStrip, "AddUserToolStrip");
            this.AddUserToolStrip.Name = "AddUserToolStrip";
            this.AddUserToolStrip.Click += new System.EventHandler(this.AddUserToolStrip_Click);
            // 
            // RemoveToolStrip
            // 
            resources.ApplyResources(this.RemoveToolStrip, "RemoveToolStrip");
            this.RemoveToolStrip.Name = "RemoveToolStrip";
            this.RemoveToolStrip.Click += new System.EventHandler(this.RemoveToolStrip_Click);
            // 
            // NewToolStrip
            // 
            resources.ApplyResources(this.NewToolStrip, "NewToolStrip");
            this.NewToolStrip.Image = global::POS.Properties.Resources.ico_alpha_FolderOptions_16x16;
            this.NewToolStrip.Name = "NewToolStrip";
            this.NewToolStrip.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // EditToolStrip
            // 
            resources.ApplyResources(this.EditToolStrip, "EditToolStrip");
            this.EditToolStrip.Image = global::POS.Properties.Resources.ico_alpha_Rename_16x16;
            this.EditToolStrip.Name = "EditToolStrip";
            this.EditToolStrip.Click += new System.EventHandler(this.EditToolStrip_Click);
            // 
            // DeleteToolStrip
            // 
            resources.ApplyResources(this.DeleteToolStrip, "DeleteToolStrip");
            this.DeleteToolStrip.Image = global::POS.Properties.Resources.ico_alpha_Delete_16x16;
            this.DeleteToolStrip.Name = "DeleteToolStrip";
            this.DeleteToolStrip.Click += new System.EventHandler(this.DeleteToolStrip_Click);
            // 
            // PermissionToolStrip
            // 
            resources.ApplyResources(this.PermissionToolStrip, "PermissionToolStrip");
            this.PermissionToolStrip.Name = "PermissionToolStrip";
            this.PermissionToolStrip.Click += new System.EventHandler(this.PermissionToolStrip_Click);
            // 
            // CloseToolStripButton1
            // 
            resources.ApplyResources(this.CloseToolStripButton1, "CloseToolStripButton1");
            this.CloseToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseToolStripButton1.Image = global::POS.Properties.Resources.Close_64;
            this.CloseToolStripButton1.Name = "CloseToolStripButton1";
            this.CloseToolStripButton1.Click += new System.EventHandler(this.CloseToolStripButton1_Click);
            // 
            // GROUP_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GROUP_FRM";
            this.Load += new System.EventHandler(this.GROUP_FRM_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewToolStrip;
        private System.Windows.Forms.ToolStripButton EditToolStrip;
        private System.Windows.Forms.ToolStripButton DeleteToolStrip;
        private System.Windows.Forms.ToolStripButton PermissionToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader6;
        internal System.Windows.Forms.ListView ListView2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripButton AddUserToolStrip;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton RemoveToolStrip;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ActionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem PermissionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        internal System.Windows.Forms.ToolStripButton CloseToolStripButton1;
//        private SkinSoft.OSSkin.OSSkin osSkin1;
    }
}