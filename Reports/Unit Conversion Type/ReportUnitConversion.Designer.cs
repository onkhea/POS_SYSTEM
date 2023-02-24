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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportUnitConversion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDetail = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bgWork = new System.ComponentModel.BackgroundWorker();
            this.bgDetails = new System.ComponentModel.BackgroundWorker();
            this.contextMastExcel = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
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
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.TreeView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.dgDetail);
            this.splitContainer1.Panel2.Controls.Add(this.dgMaster);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            // 
            // TreeView1
            // 
            resources.ApplyResources(this.TreeView1, "TreeView1");
            this.TreeView1.HideSelection = false;
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("TreeView1.Nodes")))});
            this.TreeView1.ShowNodeToolTips = true;
            this.TreeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView1_BeforeExpand_1);
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect_1);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Name = "label1";
            // 
            // dgDetail
            // 
            resources.ApplyResources(this.dgDetail, "dgDetail");
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
            this.dgDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
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
            // 
            // dgMaster
            // 
            resources.ApplyResources(this.dgMaster, "dgMaster");
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
            this.dgMaster.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
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
            // 
            // ConvCode
            // 
            resources.ApplyResources(this.ConvCode, "ConvCode");
            this.ConvCode.Name = "ConvCode";
            this.ConvCode.ReadOnly = true;
            // 
            // Description
            // 
            resources.ApplyResources(this.Description, "Description");
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // FirstComment
            // 
            resources.ApplyResources(this.FirstComment, "FirstComment");
            this.FirstComment.Name = "FirstComment";
            this.FirstComment.ReadOnly = true;
            // 
            // SecondComment
            // 
            resources.ApplyResources(this.SecondComment, "SecondComment");
            this.SecondComment.Name = "SecondComment";
            this.SecondComment.ReadOnly = true;
            // 
            // UserUpdate
            // 
            resources.ApplyResources(this.UserUpdate, "UserUpdate");
            this.UserUpdate.Name = "UserUpdate";
            this.UserUpdate.ReadOnly = true;
            // 
            // UpdatedDate
            // 
            resources.ApplyResources(this.UpdatedDate, "UpdatedDate");
            this.UpdatedDate.Name = "UpdatedDate";
            this.UpdatedDate.ReadOnly = true;
            // 
            // UserCreate
            // 
            resources.ApplyResources(this.UserCreate, "UserCreate");
            this.UserCreate.Name = "UserCreate";
            this.UserCreate.ReadOnly = true;
            // 
            // CreatedDate
            // 
            resources.ApplyResources(this.CreatedDate, "CreatedDate");
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMastClone,
            this.contextMastPaste,
            this.contextMastExcel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // contextMastClone
            // 
            resources.ApplyResources(this.contextMastClone, "contextMastClone");
            this.contextMastClone.Name = "contextMastClone";
            this.contextMastClone.Click += new System.EventHandler(this.contextMastClone_Click);
            // 
            // contextMastPaste
            // 
            resources.ApplyResources(this.contextMastPaste, "contextMastPaste");
            this.contextMastPaste.Name = "contextMastPaste";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label2);
            this.panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Name = "label2";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
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
            this.toolStrip1.Name = "toolStrip1";
            // 
            // bgWork
            // 
            this.bgWork.WorkerReportsProgress = true;
            this.bgWork.WorkerSupportsCancellation = true;
            this.bgWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWork_DoWork);
            this.bgWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWork_ProgressChanged);
            this.bgWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWork_RunWorkerCompleted);
            // 
            // bgDetails
            // 
            this.bgDetails.WorkerReportsProgress = true;
            this.bgDetails.WorkerSupportsCancellation = true;
            this.bgDetails.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDetails_DoWork);
            this.bgDetails.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgDetails_ProgressChanged);
            this.bgDetails.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgDetails_RunWorkerCompleted);
            // 
            // contextMastExcel
            // 
            resources.ApplyResources(this.contextMastExcel, "contextMastExcel");
            this.contextMastExcel.Name = "contextMastExcel";
            this.contextMastExcel.Click += new System.EventHandler(this.contextMastExcel_Click);
            // 
            // ToolNewUnitType
            // 
            resources.ApplyResources(this.ToolNewUnitType, "ToolNewUnitType");
            this.ToolNewUnitType.Image = global::POS.Properties.Resources.ico_alpha_FolderOptions_16x16;
            this.ToolNewUnitType.Name = "ToolNewUnitType";
            this.ToolNewUnitType.Click += new System.EventHandler(this.ToolNewUnitType_Click);
            // 
            // toolStripEditUnitType
            // 
            resources.ApplyResources(this.toolStripEditUnitType, "toolStripEditUnitType");
            this.toolStripEditUnitType.Image = global::POS.Properties.Resources.ico_alpha_Rename_16x16;
            this.toolStripEditUnitType.Name = "toolStripEditUnitType";
            this.toolStripEditUnitType.Click += new System.EventHandler(this.toolStripEditUnitType_Click);
            // 
            // toolStripDeleteUnitType
            // 
            resources.ApplyResources(this.toolStripDeleteUnitType, "toolStripDeleteUnitType");
            this.toolStripDeleteUnitType.Image = global::POS.Properties.Resources.ico_alpha_Delete_16x16;
            this.toolStripDeleteUnitType.Name = "toolStripDeleteUnitType";
            this.toolStripDeleteUnitType.Click += new System.EventHandler(this.toolStripDeleteUnitType_Click);
            // 
            // toolStripToolUnType
            // 
            resources.ApplyResources(this.toolStripToolUnType, "toolStripToolUnType");
            this.toolStripToolUnType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCloneUnType,
            this.toolStripPastUnType,
            this.toolStripExcelUnType});
            this.toolStripToolUnType.Image = global::POS.Properties.Resources.ico_alpha_Nav_Down_24x24;
            this.toolStripToolUnType.Name = "toolStripToolUnType";
            // 
            // toolStripCloneUnType
            // 
            resources.ApplyResources(this.toolStripCloneUnType, "toolStripCloneUnType");
            this.toolStripCloneUnType.Name = "toolStripCloneUnType";
            this.toolStripCloneUnType.Click += new System.EventHandler(this.toolStripCloneUnType_Click);
            // 
            // toolStripPastUnType
            // 
            resources.ApplyResources(this.toolStripPastUnType, "toolStripPastUnType");
            this.toolStripPastUnType.Name = "toolStripPastUnType";
            this.toolStripPastUnType.Click += new System.EventHandler(this.toolStripPastUnType_Click);
            // 
            // toolStripExcelUnType
            // 
            resources.ApplyResources(this.toolStripExcelUnType, "toolStripExcelUnType");
            this.toolStripExcelUnType.Name = "toolStripExcelUnType";
            this.toolStripExcelUnType.Click += new System.EventHandler(this.toolStripExcelUnType_Click);
            // 
            // toolStripNewSubUnType
            // 
            resources.ApplyResources(this.toolStripNewSubUnType, "toolStripNewSubUnType");
            this.toolStripNewSubUnType.Image = global::POS.Properties.Resources.ico_alpha_FolderOptions_16x16;
            this.toolStripNewSubUnType.Name = "toolStripNewSubUnType";
            this.toolStripNewSubUnType.Click += new System.EventHandler(this.toolStripNewSubUnType_Click);
            // 
            // toolStripEditSubUnType
            // 
            resources.ApplyResources(this.toolStripEditSubUnType, "toolStripEditSubUnType");
            this.toolStripEditSubUnType.Image = global::POS.Properties.Resources.ico_alpha_Rename_16x16;
            this.toolStripEditSubUnType.Name = "toolStripEditSubUnType";
            this.toolStripEditSubUnType.Click += new System.EventHandler(this.toolStripEditSubUnType_Click);
            // 
            // toolStripDeleteUnType
            // 
            resources.ApplyResources(this.toolStripDeleteUnType, "toolStripDeleteUnType");
            this.toolStripDeleteUnType.Image = global::POS.Properties.Resources.ico_alpha_Delete_16x16;
            this.toolStripDeleteUnType.Name = "toolStripDeleteUnType";
            this.toolStripDeleteUnType.Click += new System.EventHandler(this.toolStripDeleteUnType_Click);
            // 
            // toolStripToolSubUnType
            // 
            resources.ApplyResources(this.toolStripToolSubUnType, "toolStripToolSubUnType");
            this.toolStripToolSubUnType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCloneSubUnType,
            this.toolStripPasteSubUnType,
            this.toolStripExcelSubUnType});
            this.toolStripToolSubUnType.Image = global::POS.Properties.Resources.ico_alpha_Nav_Down_24x24;
            this.toolStripToolSubUnType.Name = "toolStripToolSubUnType";
            // 
            // toolStripCloneSubUnType
            // 
            resources.ApplyResources(this.toolStripCloneSubUnType, "toolStripCloneSubUnType");
            this.toolStripCloneSubUnType.Name = "toolStripCloneSubUnType";
            this.toolStripCloneSubUnType.Click += new System.EventHandler(this.toolStripCloneSubUnType_Click);
            // 
            // toolStripPasteSubUnType
            // 
            resources.ApplyResources(this.toolStripPasteSubUnType, "toolStripPasteSubUnType");
            this.toolStripPasteSubUnType.Name = "toolStripPasteSubUnType";
            this.toolStripPasteSubUnType.Click += new System.EventHandler(this.toolStripPasteSubUnType_Click);
            // 
            // toolStripExcelSubUnType
            // 
            resources.ApplyResources(this.toolStripExcelSubUnType, "toolStripExcelSubUnType");
            this.toolStripExcelSubUnType.Name = "toolStripExcelSubUnType";
            this.toolStripExcelSubUnType.Click += new System.EventHandler(this.toolStripExcelSubUnType_Click);
            // 
            // toolStripButton7
            // 
            resources.ApplyResources(this.toolStripButton7, "toolStripButton7");
            this.toolStripButton7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::POS.Properties.Resources.Close_64;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // UserUpdated
            // 
            resources.ApplyResources(this.UserUpdated, "UserUpdated");
            this.UserUpdated.Name = "UserUpdated";
            this.UserUpdated.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // SecComment
            // 
            resources.ApplyResources(this.SecComment, "SecComment");
            this.SecComment.Name = "SecComment";
            this.SecComment.ReadOnly = true;
            // 
            // ReportUnitConversion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportUnitConversion";
            this.Load += new System.EventHandler(this.ReportUnitConversion_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
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
        private System.ComponentModel.BackgroundWorker bgDetails;
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
    }
}