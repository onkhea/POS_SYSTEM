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
            this.NewToolStrip = new System.Windows.Forms.ToolStripButton();
            this.EditToolStrip = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStrip = new System.Windows.Forms.ToolStripButton();
            this.PermissionToolStrip = new System.Windows.Forms.ToolStripButton();
            this.CloseToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListView2 = new System.Windows.Forms.ListView();
            this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.AddUserToolStrip = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveToolStrip = new System.Windows.Forms.ToolStripButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.ToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStrip,
            this.EditToolStrip,
            this.DeleteToolStrip,
            this.PermissionToolStrip,
            this.CloseToolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1024, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewToolStrip
            // 
            this.NewToolStrip.Image = global::POS.Properties.Resources.ico_alpha_FolderOptions_16x16;
            this.NewToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStrip.Name = "NewToolStrip";
            this.NewToolStrip.Size = new System.Drawing.Size(51, 22);
            this.NewToolStrip.Text = "&New";
            this.NewToolStrip.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // EditToolStrip
            // 
            this.EditToolStrip.Image = global::POS.Properties.Resources.ico_alpha_Rename_16x16;
            this.EditToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStrip.Name = "EditToolStrip";
            this.EditToolStrip.Size = new System.Drawing.Size(47, 22);
            this.EditToolStrip.Text = "&Edit";
            this.EditToolStrip.Click += new System.EventHandler(this.EditToolStrip_Click);
            // 
            // DeleteToolStrip
            // 
            this.DeleteToolStrip.Image = global::POS.Properties.Resources.ico_alpha_Delete_16x16;
            this.DeleteToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStrip.Name = "DeleteToolStrip";
            this.DeleteToolStrip.Size = new System.Drawing.Size(60, 22);
            this.DeleteToolStrip.Text = "&Delete";
            this.DeleteToolStrip.Click += new System.EventHandler(this.DeleteToolStrip_Click);
            // 
            // PermissionToolStrip
            // 
            this.PermissionToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("PermissionToolStrip.Image")));
            this.PermissionToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PermissionToolStrip.Name = "PermissionToolStrip";
            this.PermissionToolStrip.Size = new System.Drawing.Size(85, 22);
            this.PermissionToolStrip.Text = "&Permission";
            this.PermissionToolStrip.Click += new System.EventHandler(this.PermissionToolStrip_Click);
            // 
            // CloseToolStripButton1
            // 
            this.CloseToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseToolStripButton1.Image = global::POS.Properties.Resources.Close_64;
            this.CloseToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseToolStripButton1.Name = "CloseToolStripButton1";
            this.CloseToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.CloseToolStripButton1.Text = "&Close ";
            this.CloseToolStripButton1.Click += new System.EventHandler(this.CloseToolStripButton1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ListView2);
            this.splitContainer1.Panel2.Controls.Add(this.ToolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 675);
            this.splitContainer1.SplitterDistance = 705;
            this.splitContainer1.TabIndex = 1;
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader6});
            this.ListView1.ContextMenuStrip = this.ContextMenuStrip1;
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.FullRowSelect = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(0, 0);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(705, 675);
            this.ListView1.TabIndex = 1;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Group Code";
            this.ColumnHeader1.Width = 100;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Description";
            this.ColumnHeader2.Width = 200;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Status";
            this.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader6.Width = 80;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionToolStripMenuItem,
            this.PermissionToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.RefreshToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenuStrip1.Size = new System.Drawing.Size(133, 76);
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
            this.AddToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStripMenuItem.Image")));
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AddToolStripMenuItem.Text = "&Add";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripMenuItem.Image")));
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.EditToolStripMenuItem.Text = "&Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem1
            // 
            this.DeleteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripMenuItem1.Image")));
            this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
            this.DeleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.DeleteToolStripMenuItem1.Text = "&Delete";
            this.DeleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // PermissionToolStripMenuItem
            // 
            this.PermissionToolStripMenuItem.Name = "PermissionToolStripMenuItem";
            this.PermissionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.PermissionToolStripMenuItem.Text = "&Permission";
            this.PermissionToolStripMenuItem.Click += new System.EventHandler(this.PermissionToolStripMenuItem_Click);
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
            // ListView2
            // 
            this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.ListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView2.FullRowSelect = true;
            this.ListView2.Location = new System.Drawing.Point(0, 25);
            this.ListView2.MultiSelect = false;
            this.ListView2.Name = "ListView2";
            this.ListView2.Size = new System.Drawing.Size(315, 650);
            this.ListView2.TabIndex = 2;
            this.ListView2.UseCompatibleStateImageBehavior = false;
            this.ListView2.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "User ID";
            this.ColumnHeader3.Width = 100;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "User Name";
            this.ColumnHeader4.Width = 200;
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUserToolStrip,
            this.ToolStripSeparator3,
            this.RemoveToolStrip});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip2.Size = new System.Drawing.Size(315, 25);
            this.ToolStrip2.TabIndex = 1;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // AddUserToolStrip
            // 
            this.AddUserToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("AddUserToolStrip.Image")));
            this.AddUserToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddUserToolStrip.Name = "AddUserToolStrip";
            this.AddUserToolStrip.Size = new System.Drawing.Size(75, 22);
            this.AddUserToolStrip.Text = "&Add User";
            this.AddUserToolStrip.Click += new System.EventHandler(this.AddUserToolStrip_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // RemoveToolStrip
            // 
            this.RemoveToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("RemoveToolStrip.Image")));
            this.RemoveToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveToolStrip.Name = "RemoveToolStrip";
            this.RemoveToolStrip.Size = new System.Drawing.Size(96, 22);
            this.RemoveToolStrip.Text = "&Remove User";
            this.RemoveToolStrip.Click += new System.EventHandler(this.RemoveToolStrip_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "GROUP.ico");
            this.ImageList1.Images.SetKeyName(1, "GROUP-DIS.ico");
            // 
            // GROUP_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GROUP_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Group";
            this.Load += new System.EventHandler(this.GROUP_FRM_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
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