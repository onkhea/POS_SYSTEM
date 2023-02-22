namespace POS.GUI.Inventory
{
    partial class STOCKADDJUSTMENT_FRM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STOCKADDJUSTMENT_FRM));
            this.txtPrd = new System.Windows.Forms.TextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.LineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToTalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitOfStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovPrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolstripRemoveLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.LBLHEADER = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtFree = new System.Windows.Forms.TextBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StartToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.MovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.HeldToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btntranType = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtTranType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtLineNo = new System.Windows.Forms.TextBox();
            this.txtUnitofStock = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtOnHold = new System.Windows.Forms.TextBox();
            this.txtPhysical = new System.Windows.Forms.TextBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.btnItem_Code = new System.Windows.Forms.Button();
            this.btnLoc_Code1 = new System.Windows.Forms.Button();
            this.txtLoc_Code1 = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.txtItem_Code = new System.Windows.Forms.TextBox();
            this.txtItem_Desc = new System.Windows.Forms.TextBox();
            this.dtpMov_Date = new System.Windows.Forms.DateTimePicker();
            this.PanelTotalAmt = new System.Windows.Forms.Panel();
            this.Label16 = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.lblInvoiceValue = new System.Windows.Forms.Label();
            this.txtMov_Ref = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.PanelTotalAmt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrd
            // 
            this.txtPrd.Location = new System.Drawing.Point(127, 43);
            this.txtPrd.MaxLength = 15;
            this.txtPrd.Name = "txtPrd";
            this.txtPrd.Size = new System.Drawing.Size(147, 20);
            this.txtPrd.TabIndex = 51;
            this.txtPrd.Tag = "Movement Reference";
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.dataGridViewX1);
            this.Panel3.Controls.Add(this.button2);
            this.Panel3.Controls.Add(this.toolStrip2);
            this.Panel3.Controls.Add(this.LBLHEADER);
            this.Panel3.Controls.Add(this.button1);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(0, 258);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(900, 239);
            this.Panel3.TabIndex = 38;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineNo,
            this.Locations,
            this.ItemCode,
            this.ItemDesc,
            this.Qty,
            this.Cost,
            this.ToTalAmount,
            this.UnitOfStock,
            this.MovPrd,
            this.TransType});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(902, 209);
            this.dataGridViewX1.TabIndex = 2;
            // 
            // LineNo
            // 
            this.LineNo.HeaderText = "Line_No";
            this.LineNo.Name = "LineNo";
            this.LineNo.ReadOnly = true;
            this.LineNo.Width = 98;
            // 
            // Locations
            // 
            this.Locations.HeaderText = "Location";
            this.Locations.Name = "Locations";
            this.Locations.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ItemDesc
            // 
            this.ItemDesc.HeaderText = "Item Description";
            this.ItemDesc.Name = "ItemDesc";
            this.ItemDesc.ReadOnly = true;
            this.ItemDesc.Width = 200;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // ToTalAmount
            // 
            this.ToTalAmount.HeaderText = "Total Amount";
            this.ToTalAmount.Name = "ToTalAmount";
            this.ToTalAmount.ReadOnly = true;
            // 
            // UnitOfStock
            // 
            this.UnitOfStock.HeaderText = "Unit Of Stock";
            this.UnitOfStock.Name = "UnitOfStock";
            // 
            // MovPrd
            // 
            this.MovPrd.HeaderText = "MovPeriod";
            this.MovPrd.Name = "MovPrd";
            this.MovPrd.Visible = false;
            // 
            // TransType
            // 
            this.TransType.HeaderText = "Transaction Type";
            this.TransType.Name = "TransType";
            this.TransType.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolstripRemoveLine,
            this.toolStripButton5});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(3, 2);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(288, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::POS.Properties.Resources.ico_alpha_FolderOptions_16x16;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(101, 22);
            this.toolStripButton2.Text = "&Add New Line";
            this.toolStripButton2.CheckedChanged += new System.EventHandler(this.toolStripButton2_CheckedChanged);
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::POS.Properties.Resources.ico_alpha_Rename_16x16;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton3.Text = "&Edit";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolstripRemoveLine
            // 
            this.toolstripRemoveLine.Image = global::POS.Properties.Resources.ico_alpha_Delete_16x16;
            this.toolstripRemoveLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripRemoveLine.Name = "toolstripRemoveLine";
            this.toolstripRemoveLine.Size = new System.Drawing.Size(95, 22);
            this.toolstripRemoveLine.Text = "&Remove Line";
            this.toolstripRemoveLine.Click += new System.EventHandler(this.toolstripRemoveLine_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton5.Text = "&Ok";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // LBLHEADER
            // 
            this.LBLHEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBLHEADER.Location = new System.Drawing.Point(0, 0);
            this.LBLHEADER.Name = "LBLHEADER";
            this.LBLHEADER.Size = new System.Drawing.Size(900, 19);
            this.LBLHEADER.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(529, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Movement Period";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(286, 201);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(28, 13);
            this.Label5.TabIndex = 48;
            this.Label5.Text = "Free";
            // 
            // txtFree
            // 
            this.txtFree.BackColor = System.Drawing.SystemColors.Control;
            this.txtFree.Location = new System.Drawing.Point(405, 198);
            this.txtFree.MaxLength = 50;
            this.txtFree.Name = "txtFree";
            this.txtFree.ReadOnly = true;
            this.txtFree.Size = new System.Drawing.Size(147, 20);
            this.txtFree.TabIndex = 49;
            this.txtFree.TabStop = false;
            this.txtFree.Tag = "Other Amount";
            this.txtFree.Text = "0";
            this.txtFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripButton,
            this.ToolStripSeparator3,
            this.ToolStripSplitButton1,
            this.ToolStripSeparator2,
            this.HeldToolStripButton2,
            this.ToolStripSeparator4,
            this.ToolStripButton1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 4);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(313, 25);
            this.ToolStrip1.TabIndex = 36;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // StartToolStripButton
            // 
            this.StartToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("StartToolStripButton.Image")));
            this.StartToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartToolStripButton.Name = "StartToolStripButton";
            this.StartToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.StartToolStripButton.Text = "&Start";
            this.StartToolStripButton.ToolTipText = "Start new journal";
            this.StartToolStripButton.Click += new System.EventHandler(this.StartToolStripButton_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSplitButton1
            // 
            this.ToolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovementToolStripMenuItem});
            this.ToolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripSplitButton1.Image")));
            this.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            this.ToolStripSplitButton1.Size = new System.Drawing.Size(64, 22);
            this.ToolStripSplitButton1.Text = "&View";
            // 
            // MovementToolStripMenuItem
            // 
            this.MovementToolStripMenuItem.Name = "MovementToolStripMenuItem";
            this.MovementToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.MovementToolStripMenuItem.Text = "&Held Movement";
            this.MovementToolStripMenuItem.Click += new System.EventHandler(this.MovementToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // HeldToolStripButton2
            // 
            this.HeldToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("HeldToolStripButton2.Image")));
            this.HeldToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HeldToolStripButton2.Name = "HeldToolStripButton2";
            this.HeldToolStripButton2.Size = new System.Drawing.Size(85, 22);
            this.HeldToolStripButton2.Text = "&Held Batch";
            this.HeldToolStripButton2.Click += new System.EventHandler(this.HeldToolStripButton2_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(83, 22);
            this.ToolStripButton1.Text = "&Post Batch";
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(7, 203);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(43, 13);
            this.Label6.TabIndex = 46;
            this.Label6.Text = "Amount";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(285, 126);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 13);
            this.Label4.TabIndex = 42;
            this.Label4.Text = "Unit of Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cost";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 151);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "Quantity";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(7, 126);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(44, 13);
            this.Label12.TabIndex = 32;
            this.Label12.Text = "Line No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 39;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btntranType);
            this.Panel1.Controls.Add(this.txtTranType);
            this.Panel1.Controls.Add(this.label13);
            this.Panel1.Controls.Add(this.txtPrd);
            this.Panel1.Controls.Add(this.label10);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.txtFree);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label12);
            this.Panel1.Controls.Add(this.txtTotalAmount);
            this.Panel1.Controls.Add(this.txtLineNo);
            this.Panel1.Controls.Add(this.txtUnitofStock);
            this.Panel1.Controls.Add(this.txtCost);
            this.Panel1.Controls.Add(this.txtQTY);
            this.Panel1.Controls.Add(this.label7);
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Controls.Add(this.txtOnHold);
            this.Panel1.Controls.Add(this.txtPhysical);
            this.Panel1.Controls.Add(this.lblLoc);
            this.Panel1.Controls.Add(this.btnItem_Code);
            this.Panel1.Controls.Add(this.btnLoc_Code1);
            this.Panel1.Controls.Add(this.txtLoc_Code1);
            this.Panel1.Controls.Add(this.lblItemCode);
            this.Panel1.Controls.Add(this.txtItem_Code);
            this.Panel1.Controls.Add(this.txtItem_Desc);
            this.Panel1.Controls.Add(this.dtpMov_Date);
            this.Panel1.Controls.Add(this.PanelTotalAmt);
            this.Panel1.Controls.Add(this.txtMov_Ref);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 29);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(900, 229);
            this.Panel1.TabIndex = 37;
            // 
            // btntranType
            // 
            this.btntranType.ImageIndex = 0;
            this.btntranType.ImageList = this.ImageList1;
            this.btntranType.Location = new System.Drawing.Point(251, 15);
            this.btntranType.Name = "btntranType";
            this.btntranType.Size = new System.Drawing.Size(24, 20);
            this.btntranType.TabIndex = 54;
            this.btntranType.TabStop = false;
            this.btntranType.UseVisualStyleBackColor = true;
            this.btntranType.Click += new System.EventHandler(this.btntranType_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // txtTranType
            // 
            this.txtTranType.Location = new System.Drawing.Point(127, 15);
            this.txtTranType.MaxLength = 15;
            this.txtTranType.Name = "txtTranType";
            this.txtTranType.Size = new System.Drawing.Size(124, 20);
            this.txtTranType.TabIndex = 0;
            this.txtTranType.Tag = "Movement Reference";
            this.txtTranType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTranType_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Transaction Type";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(127, 197);
            this.txtTotalAmount.MaxLength = 1;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(147, 20);
            this.txtTotalAmount.TabIndex = 47;
            this.txtTotalAmount.TabStop = false;
            this.txtTotalAmount.Tag = "D/C";
            this.txtTotalAmount.Text = "0.00";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLineNo
            // 
            this.txtLineNo.Enabled = false;
            this.txtLineNo.Location = new System.Drawing.Point(127, 122);
            this.txtLineNo.MaxLength = 10;
            this.txtLineNo.Name = "txtLineNo";
            this.txtLineNo.ReadOnly = true;
            this.txtLineNo.Size = new System.Drawing.Size(147, 20);
            this.txtLineNo.TabIndex = 33;
            this.txtLineNo.Tag = "Lookup";
            this.txtLineNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitofStock
            // 
            this.txtUnitofStock.Location = new System.Drawing.Point(405, 123);
            this.txtUnitofStock.MaxLength = 1;
            this.txtUnitofStock.Name = "txtUnitofStock";
            this.txtUnitofStock.ReadOnly = true;
            this.txtUnitofStock.Size = new System.Drawing.Size(147, 20);
            this.txtUnitofStock.TabIndex = 43;
            this.txtUnitofStock.TabStop = false;
            this.txtUnitofStock.Tag = "D/C";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.White;
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(127, 172);
            this.txtCost.MaxLength = 20;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(147, 20);
            this.txtCost.TabIndex = 5;
            this.txtCost.Tag = "Line Reference";
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCost_KeyDown);
            // 
            // txtQTY
            // 
            this.txtQTY.BackColor = System.Drawing.Color.White;
            this.txtQTY.Enabled = false;
            this.txtQTY.Location = new System.Drawing.Point(127, 147);
            this.txtQTY.MaxLength = 20;
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(147, 20);
            this.txtQTY.TabIndex = 4;
            this.txtQTY.Tag = "Line Reference";
            this.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQTY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQTY_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "On Hold";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(285, 151);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(46, 13);
            this.Label11.TabIndex = 34;
            this.Label11.Text = "Physical";
            // 
            // txtOnHold
            // 
            this.txtOnHold.BackColor = System.Drawing.SystemColors.Control;
            this.txtOnHold.Location = new System.Drawing.Point(405, 174);
            this.txtOnHold.MaxLength = 50;
            this.txtOnHold.Name = "txtOnHold";
            this.txtOnHold.ReadOnly = true;
            this.txtOnHold.Size = new System.Drawing.Size(147, 20);
            this.txtOnHold.TabIndex = 38;
            this.txtOnHold.TabStop = false;
            this.txtOnHold.Tag = "Other Amount";
            this.txtOnHold.Text = "0";
            this.txtOnHold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPhysical
            // 
            this.txtPhysical.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhysical.Location = new System.Drawing.Point(405, 148);
            this.txtPhysical.MaxLength = 50;
            this.txtPhysical.Name = "txtPhysical";
            this.txtPhysical.ReadOnly = true;
            this.txtPhysical.Size = new System.Drawing.Size(147, 20);
            this.txtPhysical.TabIndex = 39;
            this.txtPhysical.TabStop = false;
            this.txtPhysical.Tag = "Other Amount";
            this.txtPhysical.Text = "0";
            this.txtPhysical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(7, 100);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(76, 13);
            this.lblLoc.TabIndex = 26;
            this.lblLoc.Text = "Location Code";
            // 
            // btnItem_Code
            // 
            this.btnItem_Code.Enabled = false;
            this.btnItem_Code.ImageIndex = 0;
            this.btnItem_Code.ImageList = this.ImageList1;
            this.btnItem_Code.Location = new System.Drawing.Point(251, 72);
            this.btnItem_Code.Name = "btnItem_Code";
            this.btnItem_Code.Size = new System.Drawing.Size(24, 20);
            this.btnItem_Code.TabIndex = 24;
            this.btnItem_Code.TabStop = false;
            this.btnItem_Code.UseVisualStyleBackColor = true;
            this.btnItem_Code.Click += new System.EventHandler(this.btnItem_Code_Click);
            // 
            // btnLoc_Code1
            // 
            this.btnLoc_Code1.Enabled = false;
            this.btnLoc_Code1.ImageIndex = 0;
            this.btnLoc_Code1.ImageList = this.ImageList1;
            this.btnLoc_Code1.Location = new System.Drawing.Point(251, 98);
            this.btnLoc_Code1.Name = "btnLoc_Code1";
            this.btnLoc_Code1.Size = new System.Drawing.Size(24, 20);
            this.btnLoc_Code1.TabIndex = 28;
            this.btnLoc_Code1.TabStop = false;
            this.btnLoc_Code1.UseVisualStyleBackColor = true;
            this.btnLoc_Code1.Click += new System.EventHandler(this.btnLoc_Code1_Click);
            // 
            // txtLoc_Code1
            // 
            this.txtLoc_Code1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoc_Code1.Enabled = false;
            this.txtLoc_Code1.Location = new System.Drawing.Point(127, 97);
            this.txtLoc_Code1.MaxLength = 15;
            this.txtLoc_Code1.Name = "txtLoc_Code1";
            this.txtLoc_Code1.Size = new System.Drawing.Size(124, 20);
            this.txtLoc_Code1.TabIndex = 3;
            this.txtLoc_Code1.Tag = "Location Code";
            this.txtLoc_Code1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoc_Code1_KeyDown);
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(7, 76);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(55, 13);
            this.lblItemCode.TabIndex = 22;
            this.lblItemCode.Text = "Item Code";
            // 
            // txtItem_Code
            // 
            this.txtItem_Code.Enabled = false;
            this.txtItem_Code.Location = new System.Drawing.Point(127, 72);
            this.txtItem_Code.MaxLength = 15;
            this.txtItem_Code.Name = "txtItem_Code";
            this.txtItem_Code.Size = new System.Drawing.Size(124, 20);
            this.txtItem_Code.TabIndex = 2;
            this.txtItem_Code.Tag = "Item Code";
            this.txtItem_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_Code_KeyDown);
            // 
            // txtItem_Desc
            // 
            this.txtItem_Desc.Enabled = false;
            this.txtItem_Desc.Location = new System.Drawing.Point(288, 72);
            this.txtItem_Desc.MaxLength = 50;
            this.txtItem_Desc.Name = "txtItem_Desc";
            this.txtItem_Desc.Size = new System.Drawing.Size(264, 20);
            this.txtItem_Desc.TabIndex = 25;
            this.txtItem_Desc.Tag = "Item Description";
            // 
            // dtpMov_Date
            // 
            this.dtpMov_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMov_Date.Location = new System.Drawing.Point(405, 43);
            this.dtpMov_Date.Name = "dtpMov_Date";
            this.dtpMov_Date.Size = new System.Drawing.Size(148, 20);
            this.dtpMov_Date.TabIndex = 7;
            // 
            // PanelTotalAmt
            // 
            this.PanelTotalAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTotalAmt.Controls.Add(this.Label16);
            this.PanelTotalAmt.Controls.Add(this.lblTotalQuantity);
            this.PanelTotalAmt.Controls.Add(this.Label14);
            this.PanelTotalAmt.Controls.Add(this.lblInvoiceValue);
            this.PanelTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTotalAmt.Location = new System.Drawing.Point(580, 8);
            this.PanelTotalAmt.Name = "PanelTotalAmt";
            this.PanelTotalAmt.Size = new System.Drawing.Size(308, 67);
            this.PanelTotalAmt.TabIndex = 10;
            // 
            // Label16
            // 
            this.Label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(13, 10);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(73, 13);
            this.Label16.TabIndex = 0;
            this.Label16.Text = "Total Amount:";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.Location = new System.Drawing.Point(134, 34);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(166, 21);
            this.lblTotalQuantity.TabIndex = 0;
            this.lblTotalQuantity.Text = "0.00";
            this.lblTotalQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            this.Label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(13, 38);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(76, 13);
            this.Label14.TabIndex = 0;
            this.Label14.Text = "Total Quantity:";
            // 
            // lblInvoiceValue
            // 
            this.lblInvoiceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoiceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceValue.Location = new System.Drawing.Point(134, 5);
            this.lblInvoiceValue.Name = "lblInvoiceValue";
            this.lblInvoiceValue.Size = new System.Drawing.Size(166, 21);
            this.lblInvoiceValue.TabIndex = 0;
            this.lblInvoiceValue.Text = "0.00";
            this.lblInvoiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMov_Ref
            // 
            this.txtMov_Ref.Location = new System.Drawing.Point(405, 10);
            this.txtMov_Ref.MaxLength = 15;
            this.txtMov_Ref.Name = "txtMov_Ref";
            this.txtMov_Ref.Size = new System.Drawing.Size(147, 20);
            this.txtMov_Ref.TabIndex = 1;
            this.txtMov_Ref.Tag = "Movement Reference";
            this.txtMov_Ref.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMov_Ref_KeyDown);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(288, 46);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(83, 13);
            this.Label8.TabIndex = 6;
            this.Label8.Text = "Movement Date";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(289, 13);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(110, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Movement Reference";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 29);
            this.panel2.TabIndex = 40;
            // 
            // STOCKADDJUSTMENT_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 497);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "STOCKADDJUSTMENT_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Addjustment";
            this.Load += new System.EventHandler(this.STOCKADDJUSTMENT_FRM_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.PanelTotalAmt.ResumeLayout(false);
            this.PanelTotalAmt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtPrd;
        internal System.Windows.Forms.Panel Panel3;
        public DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolstripRemoveLine;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        internal System.Windows.Forms.Label LBLHEADER;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtFree;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton StartToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripSplitButton ToolStripSplitButton1;
        internal System.Windows.Forms.ToolStripMenuItem MovementToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton HeldToolStripButton2;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txtTotalAmount;
        internal System.Windows.Forms.TextBox txtLineNo;
        internal System.Windows.Forms.TextBox txtUnitofStock;
        internal System.Windows.Forms.TextBox txtCost;
        internal System.Windows.Forms.TextBox txtQTY;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtOnHold;
        internal System.Windows.Forms.TextBox txtPhysical;
        internal System.Windows.Forms.Label lblLoc;
        internal System.Windows.Forms.Button btnItem_Code;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.Button btnLoc_Code1;
        internal System.Windows.Forms.TextBox txtLoc_Code1;
        internal System.Windows.Forms.Label lblItemCode;
        internal System.Windows.Forms.TextBox txtItem_Code;
        internal System.Windows.Forms.TextBox txtItem_Desc;
        internal System.Windows.Forms.DateTimePicker dtpMov_Date;
        internal System.Windows.Forms.Panel PanelTotalAmt;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label lblTotalQuantity;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label lblInvoiceValue;
        internal System.Windows.Forms.TextBox txtMov_Ref;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Button btntranType;
        internal System.Windows.Forms.TextBox txtTranType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locations;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToTalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitOfStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovPrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransType;
//        private SkinSoft.OSSkin.OSSkin osSkin1;
        private System.Windows.Forms.Button button2;
    }
}