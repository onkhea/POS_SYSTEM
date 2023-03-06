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
            resources.ApplyResources(this.txtUnitofSale, "txtUnitofSale");
            this.txtUnitofSale.Name = "txtUnitofSale";
            this.txtUnitofSale.Tag = "Unit of Sale";
            this.txtUnitofSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitofSale_KeyDown);
            // 
            // Label11
            // 
            resources.ApplyResources(this.Label11, "Label11");
            this.Label11.Name = "Label11";
            // 
            // txtUnitofStock
            // 
            resources.ApplyResources(this.txtUnitofStock, "txtUnitofStock");
            this.txtUnitofStock.Name = "txtUnitofStock";
            this.txtUnitofStock.Tag = "Product ID";
            this.txtUnitofStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitofStock_KeyDown);
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // Label9
            // 
            resources.ApplyResources(this.Label9, "Label9");
            this.Label9.Name = "Label9";
            // 
            // Label8
            // 
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.Name = "Label8";
            // 
            // Cancel_Button
            // 
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
            // 
            // cboTimeF
            // 
            resources.ApplyResources(this.cboTimeF, "cboTimeF");
            this.cboTimeF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeF.FormattingEnabled = true;
            this.cboTimeF.Items.AddRange(new object[] {
            resources.GetString("cboTimeF.Items"),
            resources.GetString("cboTimeF.Items1"),
            resources.GetString("cboTimeF.Items2"),
            resources.GetString("cboTimeF.Items3"),
            resources.GetString("cboTimeF.Items4"),
            resources.GetString("cboTimeF.Items5"),
            resources.GetString("cboTimeF.Items6"),
            resources.GetString("cboTimeF.Items7"),
            resources.GetString("cboTimeF.Items8"),
            resources.GetString("cboTimeF.Items9"),
            resources.GetString("cboTimeF.Items10"),
            resources.GetString("cboTimeF.Items11"),
            resources.GetString("cboTimeF.Items12"),
            resources.GetString("cboTimeF.Items13"),
            resources.GetString("cboTimeF.Items14"),
            resources.GetString("cboTimeF.Items15"),
            resources.GetString("cboTimeF.Items16"),
            resources.GetString("cboTimeF.Items17"),
            resources.GetString("cboTimeF.Items18"),
            resources.GetString("cboTimeF.Items19"),
            resources.GetString("cboTimeF.Items20"),
            resources.GetString("cboTimeF.Items21"),
            resources.GetString("cboTimeF.Items22"),
            resources.GetString("cboTimeF.Items23"),
            resources.GetString("cboTimeF.Items24")});
            this.cboTimeF.Name = "cboTimeF";
            this.cboTimeF.Tag = "From";
            this.cboTimeF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTimeF_KeyDown);
            // 
            // Label10
            // 
            resources.ApplyResources(this.Label10, "Label10");
            this.Label10.Name = "Label10";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.Name = "Label7";
            // 
            // dtpDateT
            // 
            resources.ApplyResources(this.dtpDateT, "dtpDateT");
            this.dtpDateT.Checked = false;
            this.dtpDateT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateT.Name = "dtpDateT";
            this.dtpDateT.ShowCheckBox = true;
            this.dtpDateT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDateT_KeyDown);
            // 
            // Label6
            // 
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.Name = "Label6";
            // 
            // cboTimeT
            // 
            resources.ApplyResources(this.cboTimeT, "cboTimeT");
            this.cboTimeT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeT.FormattingEnabled = true;
            this.cboTimeT.Items.AddRange(new object[] {
            resources.GetString("cboTimeT.Items"),
            resources.GetString("cboTimeT.Items1"),
            resources.GetString("cboTimeT.Items2"),
            resources.GetString("cboTimeT.Items3"),
            resources.GetString("cboTimeT.Items4"),
            resources.GetString("cboTimeT.Items5"),
            resources.GetString("cboTimeT.Items6"),
            resources.GetString("cboTimeT.Items7"),
            resources.GetString("cboTimeT.Items8"),
            resources.GetString("cboTimeT.Items9"),
            resources.GetString("cboTimeT.Items10"),
            resources.GetString("cboTimeT.Items11"),
            resources.GetString("cboTimeT.Items12"),
            resources.GetString("cboTimeT.Items13"),
            resources.GetString("cboTimeT.Items14"),
            resources.GetString("cboTimeT.Items15"),
            resources.GetString("cboTimeT.Items16"),
            resources.GetString("cboTimeT.Items17"),
            resources.GetString("cboTimeT.Items18"),
            resources.GetString("cboTimeT.Items19"),
            resources.GetString("cboTimeT.Items20"),
            resources.GetString("cboTimeT.Items21"),
            resources.GetString("cboTimeT.Items22"),
            resources.GetString("cboTimeT.Items23"),
            resources.GetString("cboTimeT.Items24")});
            this.cboTimeT.Name = "cboTimeT";
            this.cboTimeT.Tag = "To";
            this.cboTimeT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTimeT_KeyDown);
            // 
            // dtpDateF
            // 
            resources.ApplyResources(this.dtpDateF, "dtpDateF");
            this.dtpDateF.Checked = false;
            this.dtpDateF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateF.Name = "dtpDateF";
            this.dtpDateF.ShowCheckBox = true;
            this.dtpDateF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDateF_KeyDown);
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            // 
            // cboStatus
            // 
            resources.ApplyResources(this.cboStatus, "cboStatus");
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            resources.GetString("cboStatus.Items"),
            resources.GetString("cboStatus.Items1")});
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Tag = "Status";
            this.cboStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboStatus_KeyDown);
            // 
            // txtDiscount
            // 
            resources.ApplyResources(this.txtDiscount, "txtDiscount");
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Tag = "Discount Rate";
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // txtProID
            // 
            resources.ApplyResources(this.txtProID, "txtProID");
            this.txtProID.Name = "txtProID";
            this.txtProID.Tag = "Product ID";
            this.txtProID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProID_KeyDown);
            // 
            // Label20
            // 
            resources.ApplyResources(this.Label20, "Label20");
            this.Label20.Name = "Label20";
            // 
            // TableLayoutPanel1
            // 
            resources.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            // 
            // txtProName
            // 
            resources.ApplyResources(this.txtProName, "txtProName");
            this.txtProName.Name = "txtProName";
            this.txtProName.Tag = "Employee Name";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // txtSellingPrice
            // 
            resources.ApplyResources(this.txtSellingPrice, "txtSellingPrice");
            this.txtSellingPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Tag = "Employee ID";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            this.Label2.Tag = "";
            // 
            // btnUnitofSale
            // 
            resources.ApplyResources(this.btnUnitofSale, "btnUnitofSale");
            this.btnUnitofSale.ImageList = this.ImageList1;
            this.btnUnitofSale.Name = "btnUnitofSale";
            this.btnUnitofSale.TabStop = false;
            this.btnUnitofSale.UseVisualStyleBackColor = true;
            this.btnUnitofSale.Click += new System.EventHandler(this.btnUnitofSale_Click);
            // 
            // btnProID
            // 
            resources.ApplyResources(this.btnProID, "btnProID");
            this.btnProID.ImageList = this.ImageList1;
            this.btnProID.Name = "btnProID";
            this.btnProID.TabStop = false;
            this.btnProID.UseVisualStyleBackColor = true;
            this.btnProID.Click += new System.EventHandler(this.btnProID_Click);
            // 
            // ADDSIPOSDISCOUNT
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDSIPOSDISCOUNT";
            this.ShowIcon = false;
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