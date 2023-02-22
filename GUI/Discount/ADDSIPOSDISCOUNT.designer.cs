namespace POS.GUI.Discount
{
    partial class ADDSIPOSDISCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDSIPOSDISCOUNT));
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtUnitofSale = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtUnitofStock = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.cboTimeF = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.dtpDateT = new System.Windows.Forms.DateTimePicker();
            this.Label6 = new System.Windows.Forms.Label();
            this.cboTimeT = new System.Windows.Forms.ComboBox();
            this.dtpDateF = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnUnitofSale = new System.Windows.Forms.Button();
            this.btnProID = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // txtUnitofSale
            // 
            this.txtUnitofSale.Location = new System.Drawing.Point(295, 42);
            this.txtUnitofSale.MaxLength = 25;
            this.txtUnitofSale.Name = "txtUnitofSale";
            this.txtUnitofSale.Size = new System.Drawing.Size(118, 20);
            this.txtUnitofSale.TabIndex = 33;
            this.txtUnitofSale.Tag = "Unit of Sale";
            this.txtUnitofSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitofSale_KeyDown);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(233, 45);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(62, 13);
            this.Label11.TabIndex = 32;
            this.Label11.Text = "Unit of &Sale";
            // 
            // txtUnitofStock
            // 
            this.txtUnitofStock.Enabled = false;
            this.txtUnitofStock.Location = new System.Drawing.Point(84, 42);
            this.txtUnitofStock.MaxLength = 25;
            this.txtUnitofStock.Name = "txtUnitofStock";
            this.txtUnitofStock.Size = new System.Drawing.Size(136, 20);
            this.txtUnitofStock.TabIndex = 31;
            this.txtUnitofStock.Tag = "Product ID";
            this.txtUnitofStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitofStock_KeyDown);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 45);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 13);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Unit of Stock";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(233, 136);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(20, 13);
            this.Label9.TabIndex = 45;
            this.Label9.Text = "&To";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(48, 135);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(30, 13);
            this.Label8.TabIndex = 43;
            this.Label8.Text = "&From";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(85, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(74, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(74, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
            // 
            // cboTimeF
            // 
            this.cboTimeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeF.FormattingEnabled = true;
            this.cboTimeF.Items.AddRange(new object[] {
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboTimeF.Location = new System.Drawing.Point(84, 132);
            this.cboTimeF.Name = "cboTimeF";
            this.cboTimeF.Size = new System.Drawing.Size(136, 21);
            this.cboTimeF.TabIndex = 44;
            this.cboTimeF.Tag = "From";
            this.cboTimeF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTimeF_KeyDown);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(8, 135);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(38, 13);
            this.Label10.TabIndex = 42;
            this.Label10.Text = "Timing";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(48, 106);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(30, 13);
            this.Label7.TabIndex = 38;
            this.Label7.Text = "&From";
            // 
            // dtpDateT
            // 
            this.dtpDateT.Checked = false;
            this.dtpDateT.CustomFormat = "MM-dd-yyyy";
            this.dtpDateT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateT.Location = new System.Drawing.Point(295, 102);
            this.dtpDateT.Name = "dtpDateT";
            this.dtpDateT.ShowCheckBox = true;
            this.dtpDateT.Size = new System.Drawing.Size(137, 20);
            this.dtpDateT.TabIndex = 41;
            this.dtpDateT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDateT_KeyDown);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(233, 106);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(20, 13);
            this.Label6.TabIndex = 40;
            this.Label6.Text = "&To";
            // 
            // cboTimeT
            // 
            this.cboTimeT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeT.FormattingEnabled = true;
            this.cboTimeT.Items.AddRange(new object[] {
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboTimeT.Location = new System.Drawing.Point(295, 132);
            this.cboTimeT.Name = "cboTimeT";
            this.cboTimeT.Size = new System.Drawing.Size(137, 21);
            this.cboTimeT.TabIndex = 46;
            this.cboTimeT.Tag = "To";
            this.cboTimeT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTimeT_KeyDown);
            // 
            // dtpDateF
            // 
            this.dtpDateF.Checked = false;
            this.dtpDateF.CustomFormat = "MM-dd-yyyy";
            this.dtpDateF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateF.Location = new System.Drawing.Point(84, 102);
            this.dtpDateF.Name = "dtpDateF";
            this.dtpDateF.ShowCheckBox = true;
            this.dtpDateF.Size = new System.Drawing.Size(136, 20);
            this.dtpDateF.TabIndex = 39;
            this.dtpDateF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDateF_KeyDown);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 106);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(30, 13);
            this.Label5.TabIndex = 37;
            this.Label5.Text = "Date";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(233, 166);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(37, 13);
            this.Label4.TabIndex = 49;
            this.Label4.Text = "&Status";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "A - Active",
            "D - Disable"});
            this.cboStatus.Location = new System.Drawing.Point(295, 163);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(137, 21);
            this.cboStatus.TabIndex = 50;
            this.cboStatus.Tag = "Status";
            this.cboStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboStatus_KeyDown);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(84, 163);
            this.txtDiscount.MaxLength = 3;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(136, 20);
            this.txtDiscount.TabIndex = 48;
            this.txtDiscount.Tag = "Discount Rate";
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(84, 12);
            this.txtProID.MaxLength = 25;
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(117, 20);
            this.txtProID.TabIndex = 27;
            this.txtProID.Tag = "Product ID";
            this.txtProID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProID_KeyDown);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(8, 16);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(55, 13);
            this.Label20.TabIndex = 26;
            this.Label20.Text = "Item &Code";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(273, 195);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(163, 29);
            this.TableLayoutPanel1.TabIndex = 51;
            // 
            // txtProName
            // 
            this.txtProName.Enabled = false;
            this.txtProName.Location = new System.Drawing.Point(226, 12);
            this.txtProName.MaxLength = 50;
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(206, 20);
            this.txtProName.TabIndex = 29;
            this.txtProName.Tag = "Employee Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 75);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "Selling Price";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSellingPrice.Enabled = false;
            this.txtSellingPrice.Location = new System.Drawing.Point(84, 72);
            this.txtSellingPrice.MaxLength = 15;
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(348, 20);
            this.txtSellingPrice.TabIndex = 36;
            this.txtSellingPrice.Tag = "Employee ID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 166);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 13);
            this.Label2.TabIndex = 47;
            this.Label2.Tag = "";
            this.Label2.Text = "&Discount(%)";
            // 
            // btnUnitofSale
            // 
            this.btnUnitofSale.ImageIndex = 0;
            this.btnUnitofSale.ImageList = this.ImageList1;
            this.btnUnitofSale.Location = new System.Drawing.Point(408, 42);
            this.btnUnitofSale.Name = "btnUnitofSale";
            this.btnUnitofSale.Size = new System.Drawing.Size(24, 20);
            this.btnUnitofSale.TabIndex = 34;
            this.btnUnitofSale.TabStop = false;
            this.btnUnitofSale.UseVisualStyleBackColor = true;
            this.btnUnitofSale.Click += new System.EventHandler(this.btnUnitofSale_Click);
            // 
            // btnProID
            // 
            this.btnProID.ImageIndex = 0;
            this.btnProID.ImageList = this.ImageList1;
            this.btnProID.Location = new System.Drawing.Point(196, 12);
            this.btnProID.Name = "btnProID";
            this.btnProID.Size = new System.Drawing.Size(24, 20);
            this.btnProID.TabIndex = 28;
            this.btnProID.TabStop = false;
            this.btnProID.UseVisualStyleBackColor = true;
            this.btnProID.Click += new System.EventHandler(this.btnProID_Click);
            // 
            // ADDSIPOSDISCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 227);
            this.Controls.Add(this.btnUnitofSale);
            this.Controls.Add(this.txtUnitofSale);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtUnitofStock);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.cboTimeF);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.dtpDateT);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.cboTimeT);
            this.Controls.Add(this.dtpDateF);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.btnProID);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDSIPOSDISCOUNT";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Discount";
            this.Load += new System.EventHandler(this.ADDSIPOSDISCOUNT_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnUnitofSale;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.TextBox txtUnitofSale;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtUnitofStock;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.ComboBox cboTimeF;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DateTimePicker dtpDateT;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cboTimeT;
        internal System.Windows.Forms.DateTimePicker dtpDateF;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cboStatus;
        internal System.Windows.Forms.TextBox txtDiscount;
        internal System.Windows.Forms.Button btnProID;
        internal System.Windows.Forms.TextBox txtProID;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.TextBox txtProName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSellingPrice;
        internal System.Windows.Forms.Label Label2;
    }
}