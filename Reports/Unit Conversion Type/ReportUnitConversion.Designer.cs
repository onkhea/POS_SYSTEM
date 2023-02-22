using System.Windows.Forms;

namespace POS.Reports
{
    partial class ReportUnitConversion
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("All Convert Type", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportUnitConversion));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDetail = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMaster = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ConvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMastClone = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMastPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMastExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolNewUnitType = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditUnitType = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteUnitType = new System.Windows.Forms.ToolStripButton();
            this.toolStripToolUnType = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripCloneUnType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPastUnType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExcelUnType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNewSubUnType = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditSubUnType = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteUnType = new System.Windows.Forms.ToolStripButton();
            this.toolStripToolSubUnType = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripCloneSubUnType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPasteSubUnType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExcelSubUnType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.bgWork = new System.ComponentModel.BackgroundWorker();
            this.bgDetails = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaster)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.TreeView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgDetail);
            this.splitContainer1.Panel2.Controls.Add(this.dgMaster);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(917, 528);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 0;
            // 
            // TreeView1
            // 
            this.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView1.HideSelection = false;
            this.TreeView1.Location = new System.Drawing.Point(0, 38);
            this.TreeView1.Name = "TreeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node0";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.Tag = "ROOT";
            treeNode2.Text = "All Convert Type";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.TreeView1.ShowNodeToolTips = true;
            this.TreeView1.Size = new System.Drawing.Size(239, 490);
            this.TreeView1.TabIndex = 7;
            this.TreeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView1_BeforeExpand_1);
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 38);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert Report Types";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgDetail
            // 
            this.dgDetail.AllowUserToAddRows = false;
            this.dgDetail.AllowUserToDeleteRows = false;
            this.dgDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.UserUpdated,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.SecComment});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgDetail.Location = new System.Drawing.Point(0, 63);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDetail.RowHeadersVisible = false;
            this.dgDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetail.Size = new System.Drawing.Size(674, 465);
            this.dgDetail.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Unit Of Reports";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // UserUpdated
            // 
            this.UserUpdated.HeaderText = "User Update";
            this.UserUpdated.Name = "UserUpdated";
            this.UserUpdated.ReadOnly = true;
            this.UserUpdated.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Updated Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "User Create";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // SecComment
            // 
            this.SecComment.HeaderText = "Second Comment";
            this.SecComment.Name = "SecComment";
            this.SecComment.ReadOnly = true;
            this.SecComment.Width = 150;
            // 
            // dgMaster
            // 
            this.dgMaster.AllowUserToAddRows = false;
            this.dgMaster.AllowUserToDeleteRows = false;
            this.dgMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConvCode,
            this.Description,
            this.FirstComment,
            this.SecondComment,
            this.UserUpdate,
            this.UpdatedDate,
            this.UserCreate,
            this.CreatedDate});
            this.dgMaster.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMaster.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMaster.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgMaster.Location = new System.Drawing.Point(0, 63);
            this.dgMaster.Name = "dgMaster";
            this.dgMaster.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMaster.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgMaster.RowHeadersVisible = false;
            this.dgMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMaster.Size = new System.Drawing.Size(674, 465);
            this.dgMaster.TabIndex = 3;
            // 
            // ConvCode
            // 
            this.ConvCode.HeaderText = "Conv. Code";
            this.ConvCode.Name = "ConvCode";
            this.ConvCode.ReadOnly = true;
            this.ConvCode.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 350;
            // 
            // FirstComment
            // 
            this.FirstComment.HeaderText = "First Comment";
            this.FirstComment.Name = "FirstComment";
            this.FirstComment.ReadOnly = true;
            // 
            // SecondComment
            // 
            this.SecondComment.HeaderText = "Second Comment";
            this.SecondComment.Name = "SecondComment";
            this.SecondComment.ReadOnly = true;
            this.SecondComment.Width = 150;
            // 
            // UserUpdate
            // 
            this.UserUpdate.HeaderText = "User Update";
            this.UserUpdate.Name = "UserUpdate";
            this.UserUpdate.ReadOnly = true;
            this.UserUpdate.Visible = false;
            // 
            // UpdatedDate
            // 
            this.UpdatedDate.HeaderText = "Updated Date";
            this.UpdatedDate.Name = "UpdatedDate";
            this.UpdatedDate.ReadOnly = true;
            this.UpdatedDate.Visible = false;
            // 
            // UserCreate
            // 
            this.UserCreate.HeaderText = "User Create";
            this.UserCreate.Name = "UserCreate";
            this.UserCreate.ReadOnly = true;
            this.UserCreate.Visible = false;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "CreatedDate";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMastClone,
            this.contextMastPaste,
            this.contextMastExcel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 70);
            // 
            // contextMastClone
            // 
            this.contextMastClone.Name = "contextMastClone";
            this.contextMastClone.Size = new System.Drawing.Size(105, 22);
            this.contextMastClone.Text = "&Clone";
            this.contextMastClone.Click += new System.EventHandler(this.contextMastClone_Click);
            // 
            // contextMastPaste
            // 
            this.contextMastPaste.Enabled = false;
            this.contextMastPaste.Name = "contextMastPaste";
            this.contextMastPaste.Size = new System.Drawing.Size(105, 22);
            this.contextMastPaste.Text = "&Paste";
            // 
            // contextMastExcel
            // 
            this.contextMastExcel.Image = ((System.Drawing.Image)(resources.GetObject("contextMastExcel.Image")));
            this.contextMastExcel.Name = "contextMastExcel";
            this.contextMastExcel.Size = new System.Drawing.Size(105, 22);
            this.contextMastExcel.Text = "&Excel";
            this.contextMastExcel.Click += new System.EventHandler(this.contextMastExcel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 38);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Convert Report Types";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolNewUnitType,
            this.toolStripEditUnitType,
            this.toolStripDeleteUnitType,
            this.toolStripToolUnType,
            this.toolStripNewSubUnType,
            this.toolStripEditSubUnType,
            this.toolStripDeleteUnType,
            this.toolStripToolSubUnType,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(674, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolNewUnitType
            // 
            this.ToolNewUnitType.Image = global::POS.Properties.Resources.ico_alpha_FolderOptions_16x16;
            this.ToolNewUnitType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolNewUnitType.Name = "ToolNewUnitType";
            this.ToolNewUnitType.Size = new System.Drawing.Size(51, 22);
            this.ToolNewUnitType.Text = "&New";
            this.ToolNewUnitType.Click += new System.EventHandler(this.ToolNewUnitType_Click);
            // 
            // toolStripEditUnitType
            // 
            this.toolStripEditUnitType.Image = global::POS.Properties.Resources.ico_alpha_Rename_16x16;
            this.toolStripEditUnitType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditUnitType.Name = "toolStripEditUnitType";
            this.toolStripEditUnitType.Size = new System.Drawing.Size(47, 22);
            this.toolStripEditUnitType.Text = "&Edit";
            this.toolStripEditUnitType.Click += new System.EventHandler(this.toolStripEditUnitType_Click);
            // 
            // toolStripDeleteUnitType
            // 
            this.toolStripDeleteUnitType.Image = global::POS.Properties.Resources.ico_alpha_Delete_16x16;
            this.toolStripDeleteUnitType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteUnitType.Name = "toolStripDeleteUnitType";
            this.toolStripDeleteUnitType.Size = new System.Drawing.Size(60, 22);
            this.toolStripDeleteUnitType.Text = "&Delete";
            this.toolStripDeleteUnitType.Click += new System.EventHandler(this.toolStripDeleteUnitType_Click);
            // 
            // toolStripToolUnType
            // 
            this.toolStripToolUnType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCloneUnType,
            this.toolStripPastUnType,
            this.toolStripExcelUnType});
            this.toolStripToolUnType.Image = global::POS.Properties.Resources.ico_alpha_Nav_Down_24x24;
            this.toolStripToolUnType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripToolUnType.Name = "toolStripToolUnType";
            this.toolStripToolUnType.Size = new System.Drawing.Size(63, 22);
            this.toolStripToolUnType.Text = "&Tool";
            // 
            // toolStripCloneUnType
            // 
            this.toolStripCloneUnType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCloneUnType.Image")));
            this.toolStripCloneUnType.Name = "toolStripCloneUnType";
            this.toolStripCloneUnType.Size = new System.Drawing.Size(107, 22);
            this.toolStripCloneUnType.Text = "&Clone";
            this.toolStripCloneUnType.Click += new System.EventHandler(this.toolStripCloneUnType_Click);
            // 
            // toolStripPastUnType
            // 
            this.toolStripPastUnType.Enabled = false;
            this.toolStripPastUnType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPastUnType.Image")));
            this.toolStripPastUnType.Name = "toolStripPastUnType";
            this.toolStripPastUnType.Size = new System.Drawing.Size(107, 22);
            this.toolStripPastUnType.Text = "&Paste";
            this.toolStripPastUnType.Click += new System.EventHandler(this.toolStripPastUnType_Click);
            // 
            // toolStripExcelUnType
            // 
            this.toolStripExcelUnType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExcelUnType.Image")));
            this.toolStripExcelUnType.Name = "toolStripExcelUnType";
            this.toolStripExcelUnType.Size = new System.Drawing.Size(107, 22);
            this.toolStripExcelUnType.Text = "&Export";
            this.toolStripExcelUnType.Click += new System.EventHandler(this.toolStripExcelUnType_Click);
            // 
            // toolStripNewSubUnType
            // 
            this.toolStripNewSubUnType.Image = global::POS.Properties.Resources.ico_alpha_FolderOptions_16x16;
            this.toolStripNewSubUnType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewSubUnType.Name = "toolStripNewSubUnType";
            this.toolStripNewSubUnType.Size = new System.Drawing.Size(51, 22);
            this.toolStripNewSubUnType.Text = "&New";
            this.toolStripNewSubUnType.Click += new System.EventHandler(this.toolStripNewSubUnType_Click);
            // 
            // toolStripEditSubUnType
            // 
            this.toolStripEditSubUnType.Image = global::POS.Properties.Resources.ico_alpha_Rename_16x16;
            this.toolStripEditSubUnType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditSubUnType.Name = "toolStripEditSubUnType";
            this.toolStripEditSubUnType.Size = new System.Drawing.Size(47, 22);
            this.toolStripEditSubUnType.Text = "&Edit";
            this.toolStripEditSubUnType.Click += new System.EventHandler(this.toolStripEditSubUnType_Click);
            // 
            // toolStripDeleteUnType
            // 
            this.toolStripDeleteUnType.Image = global::POS.Properties.Resources.ico_alpha_Delete_16x16;
            this.toolStripDeleteUnType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteUnType.Name = "toolStripDeleteUnType";
            this.toolStripDeleteUnType.Size = new System.Drawing.Size(60, 22);
            this.toolStripDeleteUnType.Text = "&Delete";
            this.toolStripDeleteUnType.Click += new System.EventHandler(this.toolStripDeleteUnType_Click);
            // 
            // toolStripToolSubUnType
            // 
            this.toolStripToolSubUnType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCloneSubUnType,
            this.toolStripPasteSubUnType,
            this.toolStripExcelSubUnType});
            this.toolStripToolSubUnType.Image = global::POS.Properties.Resources.ico_alpha_Nav_Down_24x24;
            this.toolStripToolSubUnType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripToolSubUnType.Name = "toolStripToolSubUnType";
            this.toolStripToolSubUnType.Size = new System.Drawing.Size(63, 22);
            this.toolStripToolSubUnType.Text = "&Tool";
            // 
            // toolStripCloneSubUnType
            // 
            this.toolStripCloneSubUnType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCloneSubUnType.Image")));
            this.toolStripCloneSubUnType.Name = "toolStripCloneSubUnType";
            this.toolStripCloneSubUnType.Size = new System.Drawing.Size(107, 22);
            this.toolStripCloneSubUnType.Text = "&Clone";
            this.toolStripCloneSubUnType.Click += new System.EventHandler(this.toolStripCloneSubUnType_Click);
            // 
            // toolStripPasteSubUnType
            // 
            this.toolStripPasteSubUnType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPasteSubUnType.Image")));
            this.toolStripPasteSubUnType.Name = "toolStripPasteSubUnType";
            this.toolStripPasteSubUnType.Size = new System.Drawing.Size(107, 22);
            this.toolStripPasteSubUnType.Text = "&Paste";
            this.toolStripPasteSubUnType.Click += new System.EventHandler(this.toolStripPasteSubUnType_Click);
            // 
            // toolStripExcelSubUnType
            // 
            this.toolStripExcelSubUnType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExcelSubUnType.Image")));
            this.toolStripExcelSubUnType.Name = "toolStripExcelSubUnType";
            this.toolStripExcelSubUnType.Size = new System.Drawing.Size(107, 22);
            this.toolStripExcelSubUnType.Text = "&Export";
            this.toolStripExcelSubUnType.Click += new System.EventHandler(this.toolStripExcelSubUnType_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::POS.Properties.Resources.Close_64;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // bgWork
            // 
            this.bgWork.WorkerReportsProgress = true;
            this.bgWork.WorkerSupportsCancellation = true;
            this.bgWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWork_DoWork);
            this.bgWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWork_RunWorkerCompleted);
            this.bgWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWork_ProgressChanged);
            // 
            // bgDetails
            // 
            this.bgDetails.WorkerReportsProgress = true;
            this.bgDetails.WorkerSupportsCancellation = true;
            this.bgDetails.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDetails_DoWork);
            this.bgDetails.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgDetails_RunWorkerCompleted);
            this.bgDetails.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgDetails_ProgressChanged);
            // 
            // ReportUnitConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 528);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportUnitConversion";
            this.Text = "ReportUnitConversion";
            this.Load += new System.EventHandler(this.ReportUnitConversion_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaster)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolNewUnitType;
        private System.Windows.Forms.ToolStripButton toolStripEditSubUnType;
        private System.Windows.Forms.ToolStripButton toolStripDeleteUnitType;
        private System.Windows.Forms.ToolStripSplitButton toolStripToolSubUnType;
        private System.Windows.Forms.ToolStripMenuItem toolStripCloneSubUnType;
        private System.Windows.Forms.ToolStripMenuItem toolStripPasteSubUnType;
        private System.Windows.Forms.ToolStripMenuItem toolStripExcelSubUnType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgMaster;
        private System.Windows.Forms.ToolStripButton toolStripEditUnitType;
        private System.Windows.Forms.ToolStripSplitButton toolStripToolUnType;
        private System.Windows.Forms.ToolStripMenuItem toolStripCloneUnType;
        private System.Windows.Forms.ToolStripMenuItem toolStripPastUnType;
        private System.Windows.Forms.ToolStripMenuItem toolStripExcelUnType;
        private System.Windows.Forms.ToolStripButton toolStripNewSubUnType;
        private System.Windows.Forms.ToolStripButton toolStripDeleteUnType;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.ComponentModel.BackgroundWorker bgWork;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMastClone;
        private System.Windows.Forms.ToolStripMenuItem contextMastPaste;
        private System.Windows.Forms.ToolStripMenuItem contextMastExcel;
        private ListView listView = new ListView();
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgDetail;
        internal TreeView TreeView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn UserUpdated;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn SecComment;
        private System.ComponentModel.BackgroundWorker bgDetails;
    }
}