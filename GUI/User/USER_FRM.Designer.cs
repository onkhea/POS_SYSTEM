namespace POS.GUI.User
{
    partial class USER_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_FRM));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStrip = new System.Windows.Forms.ToolStripButton();
            this.EditToolStrip = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStrip = new System.Windows.Forms.ToolStripButton();
            this.ChangePasswordToolStrip = new System.Windows.Forms.ToolStripButton();
            this.PermissionToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStrip,
            this.EditToolStrip,
            this.DeleteToolStrip,
            this.ChangePasswordToolStrip,
            this.PermissionToolStrip,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(735, 25);
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
            this.NewToolStrip.Click += new System.EventHandler(this.NewToolStrip_Click);
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
            // ChangePasswordToolStrip
            // 
            this.ChangePasswordToolStrip.Image = global::POS.Properties.Resources.ico_alpha_Nav_Down_24x24;
            this.ChangePasswordToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangePasswordToolStrip.Name = "ChangePasswordToolStrip";
            this.ChangePasswordToolStrip.Size = new System.Drawing.Size(121, 22);
            this.ChangePasswordToolStrip.Text = "Change Pass&word";
            this.ChangePasswordToolStrip.Click += new System.EventHandler(this.ChangePasswordToolStrip_Click);
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
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::POS.Properties.Resources.Close_64;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
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
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(735, 476);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.TabIndex = 1;
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader4});
            this.ListView1.ContextMenuStrip = this.contextMenuStrip1;
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.FullRowSelect = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(0, 0);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(735, 476);
            this.ListView1.TabIndex = 1;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "User ID";
            this.ColumnHeader1.Width = 100;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "User Name";
            this.ColumnHeader2.Width = 171;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Description";
            this.ColumnHeader3.Width = 203;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "User Change Pass";
            this.ColumnHeader5.Width = 0;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "User Status";
            this.ColumnHeader6.Width = 0;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Login Status";
            this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader4.Width = 182;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.permissionToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 92);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.clearLogedToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // clearLogedToolStripMenuItem
            // 
            this.clearLogedToolStripMenuItem.Name = "clearLogedToolStripMenuItem";
            this.clearLogedToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clearLogedToolStripMenuItem.Text = "Clear &Loged";
            this.clearLogedToolStripMenuItem.Click += new System.EventHandler(this.clearLogedToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Pass&word";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allUsersToolStripMenuItem,
            this.logonToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // allUsersToolStripMenuItem
            // 
            this.allUsersToolStripMenuItem.Checked = true;
            this.allUsersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            this.allUsersToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.allUsersToolStripMenuItem.Text = "&All Users";
            this.allUsersToolStripMenuItem.Click += new System.EventHandler(this.allUsersToolStripMenuItem_Click);
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.logonToolStripMenuItem.Text = "&Logon";
            this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.logoutToolStripMenuItem.Text = "Log&out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // permissionToolStripMenuItem
            // 
            this.permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            this.permissionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.permissionToolStripMenuItem.Text = "&Permission";
            this.permissionToolStripMenuItem.Click += new System.EventHandler(this.permissionToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // USER_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 501);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "USER_FRM";
            this.Text = "User";
            this.Load += new System.EventHandler(this.USER_FRM_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewToolStrip;
        private System.Windows.Forms.ToolStripButton EditToolStrip;
        private System.Windows.Forms.ToolStripButton DeleteToolStrip;
        private System.Windows.Forms.ToolStripButton ChangePasswordToolStrip;
        private System.Windows.Forms.ToolStripButton PermissionToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader6;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
//        private SkinSoft.OSSkin.OSSkin osSkin1;
    }
}