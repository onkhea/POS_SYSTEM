namespace POS.GUI.SaleProcessing
{
    partial class ADDNEW_FRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhysical = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFree = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOnOrder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiscUSD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cboSaleType = new System.Windows.Forms.ComboBox();
            this.txtUnitOfSale = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUnitOfStock = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLineNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnUnitOfSale = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnItemCode = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscountTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtlocat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // txtItemCode
            // 
            this.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItemCode.Location = new System.Drawing.Point(110, 20);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(122, 20);
            this.txtItemCode.TabIndex = 1;
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Enabled = false;
            this.txtItemDesc.Location = new System.Drawing.Point(350, 19);
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(256, 20);
            this.txtItemDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location";
            // 
            // txtEmployee
            // 
            this.txtEmployee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmployee.Enabled = false;
            this.txtEmployee.Location = new System.Drawing.Point(110, 78);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(122, 20);
            this.txtEmployee.TabIndex = 8;
            this.txtEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployee_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee / Sale";
            // 
            // txtPhysical
            // 
            this.txtPhysical.Enabled = false;
            this.txtPhysical.Location = new System.Drawing.Point(428, 152);
            this.txtPhysical.Name = "txtPhysical";
            this.txtPhysical.Size = new System.Drawing.Size(178, 20);
            this.txtPhysical.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Physical";
            // 
            // txtFree
            // 
            this.txtFree.Enabled = false;
            this.txtFree.Location = new System.Drawing.Point(428, 208);
            this.txtFree.Name = "txtFree";
            this.txtFree.Size = new System.Drawing.Size(179, 20);
            this.txtFree.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Free";
            // 
            // txtOnOrder
            // 
            this.txtOnOrder.Enabled = false;
            this.txtOnOrder.Location = new System.Drawing.Point(428, 179);
            this.txtOnOrder.Name = "txtOnOrder";
            this.txtOnOrder.Size = new System.Drawing.Size(178, 20);
            this.txtOnOrder.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "On Order";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(110, 180);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(150, 20);
            this.txtQuantity.TabIndex = 19;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quantity";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(110, 237);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 20);
            this.txtPrice.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Price";
            // 
            // txtDiscUSD
            // 
            this.txtDiscUSD.Enabled = false;
            this.txtDiscUSD.Location = new System.Drawing.Point(111, 290);
            this.txtDiscUSD.Name = "txtDiscUSD";
            this.txtDiscUSD.Size = new System.Drawing.Size(150, 20);
            this.txtDiscUSD.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Discount (USD)";
            // 
            // txtDiscP
            // 
            this.txtDiscP.Enabled = false;
            this.txtDiscP.Location = new System.Drawing.Point(111, 264);
            this.txtDiscP.Name = "txtDiscP";
            this.txtDiscP.Size = new System.Drawing.Size(150, 20);
            this.txtDiscP.TabIndex = 22;
            this.txtDiscP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscP_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Discount (%)";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(350, 80);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(256, 20);
            this.txtEmpName.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(7, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(600, 2);
            this.label12.TabIndex = 28;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(375, 325);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "&Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOK_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(536, 325);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "&Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(347, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Sale Type";
            // 
            // cboSaleType
            // 
            this.cboSaleType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSaleType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSaleType.Enabled = false;
            this.cboSaleType.FormattingEnabled = true;
            this.cboSaleType.Items.AddRange(new object[] {
            "Sale",
            "Free",
            "Owner Used",
            "Coupon"});
            this.cboSaleType.Location = new System.Drawing.Point(428, 124);
            this.cboSaleType.Name = "cboSaleType";
            this.cboSaleType.Size = new System.Drawing.Size(179, 21);
            this.cboSaleType.TabIndex = 36;
            this.cboSaleType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboSaleType_KeyDown);
            // 
            // txtUnitOfSale
            // 
            this.txtUnitOfSale.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnitOfSale.Enabled = false;
            this.txtUnitOfSale.Location = new System.Drawing.Point(110, 152);
            this.txtUnitOfSale.Name = "txtUnitOfSale";
            this.txtUnitOfSale.Size = new System.Drawing.Size(122, 20);
            this.txtUnitOfSale.TabIndex = 38;
            this.txtUnitOfSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitOfSale_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Unit Of Sale";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Location = new System.Drawing.Point(428, 290);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(181, 20);
            this.txtGrandTotal.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(344, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Grand Total ";
            // 
            // txtUnitOfStock
            // 
            this.txtUnitOfStock.Enabled = false;
            this.txtUnitOfStock.Location = new System.Drawing.Point(110, 124);
            this.txtUnitOfStock.Name = "txtUnitOfStock";
            this.txtUnitOfStock.Size = new System.Drawing.Size(151, 20);
            this.txtUnitOfStock.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Unit Of Stock";
            // 
            // txtLineNo
            // 
            this.txtLineNo.Enabled = false;
            this.txtLineNo.Location = new System.Drawing.Point(428, 52);
            this.txtLineNo.Name = "txtLineNo";
            this.txtLineNo.Size = new System.Drawing.Size(178, 20);
            this.txtLineNo.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(351, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Line No";
            // 
            // btnUnitOfSale
            // 
            this.btnUnitOfSale.Enabled = false;
            this.btnUnitOfSale.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnUnitOfSale.Location = new System.Drawing.Point(233, 150);
            this.btnUnitOfSale.Name = "btnUnitOfSale";
            this.btnUnitOfSale.Size = new System.Drawing.Size(27, 23);
            this.btnUnitOfSale.TabIndex = 39;
            this.btnUnitOfSale.TabStop = false;
            this.btnUnitOfSale.UseVisualStyleBackColor = true;
            this.btnUnitOfSale.Click += new System.EventHandler(this.btnUnitOfSale_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Enabled = false;
            this.btnEmployee.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnEmployee.Location = new System.Drawing.Point(234, 77);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(27, 23);
            this.btnEmployee.TabIndex = 9;
            this.btnEmployee.TabStop = false;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Enabled = false;
            this.btnLocation.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnLocation.Location = new System.Drawing.Point(234, 49);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(27, 23);
            this.btnLocation.TabIndex = 6;
            this.btnLocation.TabStop = false;
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnItemCode
            // 
            this.btnItemCode.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnItemCode.Location = new System.Drawing.Point(234, 19);
            this.btnItemCode.Name = "btnItemCode";
            this.btnItemCode.Size = new System.Drawing.Size(27, 23);
            this.btnItemCode.TabIndex = 5;
            this.btnItemCode.TabStop = false;
            this.btnItemCode.UseVisualStyleBackColor = true;
            this.btnItemCode.Click += new System.EventHandler(this.btnItemCode_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(455, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(428, 235);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(179, 20);
            this.txtAmount.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Amount";
            // 
            // txtDiscountTotal
            // 
            this.txtDiscountTotal.Enabled = false;
            this.txtDiscountTotal.Location = new System.Drawing.Point(428, 261);
            this.txtDiscountTotal.Name = "txtDiscountTotal";
            this.txtDiscountTotal.Size = new System.Drawing.Size(179, 20);
            this.txtDiscountTotal.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Total Disc (USD)";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(8, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(600, 2);
            this.label14.TabIndex = 50;
            // 
            // txtStockQty
            // 
            this.txtStockQty.Enabled = false;
            this.txtStockQty.Location = new System.Drawing.Point(110, 210);
            this.txtStockQty.Name = "txtStockQty";
            this.txtStockQty.Size = new System.Drawing.Size(150, 20);
            this.txtStockQty.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 213);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 51;
            this.label20.Text = "Stock Quantity";
            // 
            // txtlocat
            // 
            this.txtlocat.Enabled = false;
            this.txtlocat.Location = new System.Drawing.Point(110, 49);
            this.txtlocat.Name = "txtlocat";
            this.txtlocat.Size = new System.Drawing.Size(122, 20);
            this.txtlocat.TabIndex = 55;
            this.txtlocat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlocat_KeyDown_1);
            // 
            // ADDNEW_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 352);
            this.ControlBox = false;
            this.Controls.Add(this.txtlocat);
            this.Controls.Add(this.txtStockQty);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDiscountTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtUnitOfStock);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnUnitOfSale);
            this.Controls.Add(this.txtUnitOfSale);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cboSaleType);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLineNo);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtDiscP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDiscUSD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOnOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhysical);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnItemCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label1);
            this.Name = "ADDNEW_FRM";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Line";
            this.Load += new System.EventHandler(this.ADDNEW_FRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtItemCode;
        internal System.Windows.Forms.TextBox txtItemDesc;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnItemCode;
        internal System.Windows.Forms.Button btnLocation;
        internal System.Windows.Forms.Button btnEmployee;
        internal System.Windows.Forms.TextBox txtEmployee;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtPhysical;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtFree;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtOnOrder;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtDiscUSD;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtDiscP;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtEmpName;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.ComboBox cboSaleType;
        internal System.Windows.Forms.TextBox txtUnitOfSale;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Button btnUnitOfSale;
        internal System.Windows.Forms.TextBox txtGrandTotal;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox txtUnitOfStock;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox txtLineNo;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtDiscountTotal;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtStockQty;
        internal System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtlocat;

    }
}