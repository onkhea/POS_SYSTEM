namespace POS.GUI.Purchases
{
    partial class ADDSIPOPURCHASEORDER_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDSIPOPURCHASEORDER_FRM));
            this.Label14 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtStockQ = new System.Windows.Forms.TextBox();
            this.dtpE = new System.Windows.Forms.DateTimePicker();
            this.Label13 = new System.Windows.Forms.Label();
            this.cboPType = new System.Windows.Forms.ComboBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblLoc = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtLoc_Desc = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtItem_Desc = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtItem_Code = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtLoc_Code = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtPhysical = new System.Windows.Forms.TextBox();
            this.txtOnOrder = new System.Windows.Forms.TextBox();
            this.txtDisAmt = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDisP = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txtUnitofStock = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtUnitOfPurchase = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.BTN_U_PURCHASE = new System.Windows.Forms.Button();
            this.btnItem_Code = new System.Windows.Forms.Button();
            this.btnLoc_Code = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label14
            // 
            this.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label14.Location = new System.Drawing.Point(133, 148);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(406, 2);
            this.Label14.TabIndex = 72;
            this.Label14.Text = "Label14";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(294, 91);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 13);
            this.Label4.TabIndex = 52;
            this.Label4.Tag = "Second Commonts";
            this.Label4.Text = "Stock Qty";
            // 
            // txtStockQ
            // 
            this.txtStockQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockQ.Location = new System.Drawing.Point(411, 87);
            this.txtStockQ.MaxLength = 1;
            this.txtStockQ.Name = "txtStockQ";
            this.txtStockQ.ReadOnly = true;
            this.txtStockQ.Size = new System.Drawing.Size(126, 20);
            this.txtStockQ.TabIndex = 53;
            this.txtStockQ.TabStop = false;
            this.txtStockQ.Tag = "D/C";
            // 
            // dtpE
            // 
            this.dtpE.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpE.CustomFormat = "";
            this.dtpE.Enabled = false;
            this.dtpE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpE.Location = new System.Drawing.Point(411, 114);
            this.dtpE.Name = "dtpE";
            this.dtpE.ShowCheckBox = true;
            this.dtpE.Size = new System.Drawing.Size(126, 20);
            this.dtpE.TabIndex = 57;
            this.dtpE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpE_KeyDown);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(294, 116);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(68, 13);
            this.Label13.TabIndex = 56;
            this.Label13.Text = "Expired Date";
            // 
            // cboPType
            // 
            this.cboPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPType.Enabled = false;
            this.cboPType.FormattingEnabled = true;
            this.cboPType.Items.AddRange(new object[] {
            "P - Purchase",
            "F - Free"});
            this.cboPType.Location = new System.Drawing.Point(133, 113);
            this.cboPType.Name = "cboPType";
            this.cboPType.Size = new System.Drawing.Size(147, 21);
            this.cboPType.TabIndex = 55;
            this.cboPType.Tag = "Purchase Type";
            this.cboPType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboPType_KeyDown);
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(13, 13);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(55, 13);
            this.lblItemCode.TabIndex = 36;
            this.lblItemCode.Text = "Item Code";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(13, 40);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(76, 13);
            this.lblLoc.TabIndex = 40;
            this.lblLoc.Text = "Location Code";
            // 
            // Label8
            // 
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label8.Location = new System.Drawing.Point(16, 254);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(521, 2);
            this.Label8.TabIndex = 70;
            this.Label8.Text = "Label8";
            // 
            // txtLoc_Desc
            // 
            this.txtLoc_Desc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoc_Desc.Enabled = false;
            this.txtLoc_Desc.Location = new System.Drawing.Point(284, 35);
            this.txtLoc_Desc.MaxLength = 50;
            this.txtLoc_Desc.Name = "txtLoc_Desc";
            this.txtLoc_Desc.Size = new System.Drawing.Size(253, 20);
            this.txtLoc_Desc.TabIndex = 43;
            this.txtLoc_Desc.Tag = "Item Description";
            this.txtLoc_Desc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoc_Desc_KeyDown);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(294, 189);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(78, 13);
            this.Label6.TabIndex = 66;
            this.Label6.Text = "Discount(USD)";
            // 
            // txtItem_Desc
            // 
            this.txtItem_Desc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtItem_Desc.Enabled = false;
            this.txtItem_Desc.Location = new System.Drawing.Point(284, 9);
            this.txtItem_Desc.MaxLength = 50;
            this.txtItem_Desc.Name = "txtItem_Desc";
            this.txtItem_Desc.Size = new System.Drawing.Size(253, 20);
            this.txtItem_Desc.TabIndex = 39;
            this.txtItem_Desc.Tag = "Item Description";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(13, 64);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(65, 13);
            this.Label12.TabIndex = 44;
            this.Label12.Text = "Physical Qty";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(294, 64);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(98, 13);
            this.Label9.TabIndex = 46;
            this.Label9.Text = "On Purchase Order";
            // 
            // txtItem_Code
            // 
            this.txtItem_Code.BackColor = System.Drawing.Color.White;
            this.txtItem_Code.Location = new System.Drawing.Point(133, 9);
            this.txtItem_Code.MaxLength = 15;
            this.txtItem_Code.Name = "txtItem_Code";
            this.txtItem_Code.Size = new System.Drawing.Size(124, 20);
            this.txtItem_Code.TabIndex = 37;
            this.txtItem_Code.Tag = "Item Code";
            this.txtItem_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_Code_KeyDown);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(384, 266);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(156, 32);
            this.TableLayoutPanel1.TabIndex = 71;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Enabled = false;
            this.OK_Button.Location = new System.Drawing.Point(3, 4);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(72, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(81, 4);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(72, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 214);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 13);
            this.Label3.TabIndex = 62;
            this.Label3.Text = "Sub Amount";
            // 
            // txtLoc_Code
            // 
            this.txtLoc_Code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoc_Code.Enabled = false;
            this.txtLoc_Code.Location = new System.Drawing.Point(133, 35);
            this.txtLoc_Code.MaxLength = 15;
            this.txtLoc_Code.Name = "txtLoc_Code";
            this.txtLoc_Code.Size = new System.Drawing.Size(124, 20);
            this.txtLoc_Code.TabIndex = 41;
            this.txtLoc_Code.Tag = "Location Code";
            this.txtLoc_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoc_Code_KeyDown);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(13, 116);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(79, 13);
            this.Label11.TabIndex = 54;
            this.Label11.Tag = "Second Commonts";
            this.Label11.Text = "Purchase Type";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(13, 91);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(74, 13);
            this.Label10.TabIndex = 48;
            this.Label10.Tag = "Second Commonts";
            this.Label10.Text = "Unit Purchase";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(133, 211);
            this.txtSubTotal.MaxLength = 20;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(147, 20);
            this.txtSubTotal.TabIndex = 63;
            this.txtSubTotal.Tag = "Line Reference";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPhysical
            // 
            this.txtPhysical.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhysical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhysical.Enabled = false;
            this.txtPhysical.Location = new System.Drawing.Point(133, 61);
            this.txtPhysical.MaxLength = 20;
            this.txtPhysical.Name = "txtPhysical";
            this.txtPhysical.Size = new System.Drawing.Size(147, 20);
            this.txtPhysical.TabIndex = 45;
            this.txtPhysical.Tag = "Line Reference";
            this.txtPhysical.Text = "0.00";
            this.txtPhysical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOnOrder
            // 
            this.txtOnOrder.BackColor = System.Drawing.SystemColors.Control;
            this.txtOnOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOnOrder.Enabled = false;
            this.txtOnOrder.Location = new System.Drawing.Point(411, 61);
            this.txtOnOrder.MaxLength = 20;
            this.txtOnOrder.Name = "txtOnOrder";
            this.txtOnOrder.Size = new System.Drawing.Size(126, 20);
            this.txtOnOrder.TabIndex = 47;
            this.txtOnOrder.Tag = "Line Reference";
            this.txtOnOrder.Text = "0.00";
            this.txtOnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDisAmt
            // 
            this.txtDisAmt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDisAmt.Enabled = false;
            this.txtDisAmt.Location = new System.Drawing.Point(411, 186);
            this.txtDisAmt.MaxLength = 20;
            this.txtDisAmt.Name = "txtDisAmt";
            this.txtDisAmt.Size = new System.Drawing.Size(126, 20);
            this.txtDisAmt.TabIndex = 67;
            this.txtDisAmt.Tag = "Discount Amount";
            this.txtDisAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDisAmt_KeyDown);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(294, 214);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 13);
            this.Label7.TabIndex = 68;
            this.Label7.Tag = "Amount";
            this.Label7.Text = "Amount";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(133, 186);
            this.txtCost.MaxLength = 20;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(147, 20);
            this.txtCost.TabIndex = 61;
            this.txtCost.Tag = "Cost";
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCost_KeyDown);
            // 
            // txtDisP
            // 
            this.txtDisP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDisP.Enabled = false;
            this.txtDisP.Location = new System.Drawing.Point(411, 160);
            this.txtDisP.MaxLength = 5;
            this.txtDisP.Name = "txtDisP";
            this.txtDisP.Size = new System.Drawing.Size(126, 20);
            this.txtDisP.TabIndex = 65;
            this.txtDisP.Tag = "Discount Percent";
            this.txtDisP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDisP_KeyDown);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(411, 212);
            this.txtTotal.MaxLength = 20;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(126, 20);
            this.txtTotal.TabIndex = 69;
            this.txtTotal.Tag = "Line Reference";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQTY
            // 
            this.txtQTY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQTY.Enabled = false;
            this.txtQTY.Location = new System.Drawing.Point(133, 159);
            this.txtQTY.MaxLength = 20;
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(147, 20);
            this.txtQTY.TabIndex = 59;
            this.txtQTY.Tag = "Quantity";
            this.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQTY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQTY_KeyDown);
            // 
            // txtUnitofStock
            // 
            this.txtUnitofStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitofStock.Location = new System.Drawing.Point(217, 87);
            this.txtUnitofStock.MaxLength = 1;
            this.txtUnitofStock.Name = "txtUnitofStock";
            this.txtUnitofStock.ReadOnly = true;
            this.txtUnitofStock.Size = new System.Drawing.Size(63, 20);
            this.txtUnitofStock.TabIndex = 51;
            this.txtUnitofStock.TabStop = false;
            this.txtUnitofStock.Tag = "D/C";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(294, 163);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 13);
            this.Label5.TabIndex = 64;
            this.Label5.Tag = "Second Commonts";
            this.Label5.Text = "Discount(%)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 189);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(28, 13);
            this.Label1.TabIndex = 60;
            this.Label1.Tag = "Second Commonts";
            this.Label1.Text = "Cost";
            // 
            // txtUnitOfPurchase
            // 
            this.txtUnitOfPurchase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUnitOfPurchase.Enabled = false;
            this.txtUnitOfPurchase.Location = new System.Drawing.Point(133, 87);
            this.txtUnitOfPurchase.MaxLength = 5;
            this.txtUnitOfPurchase.Name = "txtUnitOfPurchase";
            this.txtUnitOfPurchase.Size = new System.Drawing.Size(62, 20);
            this.txtUnitOfPurchase.TabIndex = 49;
            this.txtUnitOfPurchase.Tag = "Unit Purchase";
            this.txtUnitOfPurchase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitOfPurchase_KeyDown);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 163);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 58;
            this.Label2.Text = "Quantity";
            // 
            // BTN_U_PURCHASE
            // 
            this.BTN_U_PURCHASE.Enabled = false;
            this.BTN_U_PURCHASE.ImageIndex = 0;
            this.BTN_U_PURCHASE.ImageList = this.ImageList1;
            this.BTN_U_PURCHASE.Location = new System.Drawing.Point(192, 87);
            this.BTN_U_PURCHASE.Name = "BTN_U_PURCHASE";
            this.BTN_U_PURCHASE.Size = new System.Drawing.Size(24, 20);
            this.BTN_U_PURCHASE.TabIndex = 50;
            this.BTN_U_PURCHASE.TabStop = false;
            this.BTN_U_PURCHASE.UseVisualStyleBackColor = true;
            this.BTN_U_PURCHASE.Click += new System.EventHandler(this.BTN_U_PURCHASE_Click);
            // 
            // btnItem_Code
            // 
            this.btnItem_Code.ImageIndex = 0;
            this.btnItem_Code.ImageList = this.ImageList1;
            this.btnItem_Code.Location = new System.Drawing.Point(256, 9);
            this.btnItem_Code.Name = "btnItem_Code";
            this.btnItem_Code.Size = new System.Drawing.Size(24, 20);
            this.btnItem_Code.TabIndex = 38;
            this.btnItem_Code.TabStop = false;
            this.btnItem_Code.UseVisualStyleBackColor = true;
            this.btnItem_Code.Click += new System.EventHandler(this.btnItem_Code_Click);
            // 
            // btnLoc_Code
            // 
            this.btnLoc_Code.Enabled = false;
            this.btnLoc_Code.ImageIndex = 0;
            this.btnLoc_Code.ImageList = this.ImageList1;
            this.btnLoc_Code.Location = new System.Drawing.Point(256, 35);
            this.btnLoc_Code.Name = "btnLoc_Code";
            this.btnLoc_Code.Size = new System.Drawing.Size(24, 20);
            this.btnLoc_Code.TabIndex = 42;
            this.btnLoc_Code.TabStop = false;
            this.btnLoc_Code.UseVisualStyleBackColor = true;
            this.btnLoc_Code.Click += new System.EventHandler(this.btnLoc_Code_Click);
            // 
            // ADDSIPOPURCHASEORDER_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 303);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtStockQ);
            this.Controls.Add(this.dtpE);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.cboPType);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.BTN_U_PURCHASE);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtLoc_Desc);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtItem_Desc);
            this.Controls.Add(this.btnItem_Code);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtItem_Code);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.btnLoc_Code);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtLoc_Code);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtPhysical);
            this.Controls.Add(this.txtOnOrder);
            this.Controls.Add(this.txtDisAmt);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDisP);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.txtUnitofStock);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtUnitOfPurchase);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDSIPOPURCHASEORDER_FRM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Item Entry";
            this.Load += new System.EventHandler(this.ADDSIPOPURCHASEORDER_FRM_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtStockQ;
        internal System.Windows.Forms.DateTimePicker dtpE;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.ComboBox cboPType;
        internal System.Windows.Forms.Label lblItemCode;
        internal System.Windows.Forms.Button BTN_U_PURCHASE;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.Label lblLoc;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtLoc_Desc;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtItem_Desc;
        internal System.Windows.Forms.Button btnItem_Code;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtItem_Code;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Button btnLoc_Code;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtLoc_Code;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtSubTotal;
        internal System.Windows.Forms.TextBox txtPhysical;
        internal System.Windows.Forms.TextBox txtOnOrder;
        internal System.Windows.Forms.TextBox txtDisAmt;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtCost;
        internal System.Windows.Forms.TextBox txtDisP;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.TextBox txtQTY;
        internal System.Windows.Forms.HelpProvider HelpProvider1;
        internal System.Windows.Forms.TextBox txtUnitofStock;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtUnitOfPurchase;
        internal System.Windows.Forms.Label Label2;
    }
}