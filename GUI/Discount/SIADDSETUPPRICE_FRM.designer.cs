namespace POS.GUI.Discount
{
    partial class SIADDSETUPPRICE_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIADDSETUPPRICE_FRM));
            this.Label1 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtUnitofSale = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtUnitofStock = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnUnitofSale = new System.Windows.Forms.Button();
            this.btnProID = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(257, 79);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "&Status";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "A - Active",
            "D - Disable"});
            this.cboStatus.Location = new System.Drawing.Point(338, 76);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(118, 21);
            this.cboStatus.TabIndex = 26;
            this.cboStatus.Tag = "Status";
            this.cboStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboStatus_KeyDown);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 45);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 13);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Unit of Stock";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // txtUnitofSale
            // 
            this.txtUnitofSale.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnitofSale.Location = new System.Drawing.Point(338, 42);
            this.txtUnitofSale.MaxLength = 5;
            this.txtUnitofSale.Name = "txtUnitofSale";
            this.txtUnitofSale.Size = new System.Drawing.Size(95, 20);
            this.txtUnitofSale.TabIndex = 21;
            this.txtUnitofSale.Tag = "Unit of Sale";
            this.txtUnitofSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitofSale_KeyDown);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(257, 44);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(62, 13);
            this.Label10.TabIndex = 20;
            this.Label10.Tag = "Second Commonts";
            this.Label10.Text = "Unit of Sale";
            // 
            // txtUnitofStock
            // 
            this.txtUnitofStock.Enabled = false;
            this.txtUnitofStock.Location = new System.Drawing.Point(90, 42);
            this.txtUnitofStock.MaxLength = 1;
            this.txtUnitofStock.Name = "txtUnitofStock";
            this.txtUnitofStock.ReadOnly = true;
            this.txtUnitofStock.Size = new System.Drawing.Size(159, 20);
            this.txtUnitofStock.TabIndex = 19;
            this.txtUnitofStock.TabStop = false;
            this.txtUnitofStock.Tag = "D/C";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(90, 76);
            this.txtSellingPrice.MaxLength = 20;
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(159, 20);
            this.txtSellingPrice.TabIndex = 24;
            this.txtSellingPrice.Tag = "Discount Rate";
            this.txtSellingPrice.Text = "0";
            this.txtSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSellingPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSellingPrice_KeyDown);
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
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(90, 8);
            this.txtProID.MaxLength = 25;
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(136, 20);
            this.txtProID.TabIndex = 15;
            this.txtProID.Tag = "Item Code";
            this.txtProID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProID_KeyDown);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(9, 12);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(55, 13);
            this.Label20.TabIndex = 14;
            this.Label20.Text = "Item Code";
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
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(293, 128);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(163, 29);
            this.TableLayoutPanel1.TabIndex = 27;
            // 
            // txtProName
            // 
            this.txtProName.Enabled = false;
            this.txtProName.Location = new System.Drawing.Point(255, 9);
            this.txtProName.MaxLength = 50;
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(201, 20);
            this.txtProName.TabIndex = 17;
            this.txtProName.Tag = "Product Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 79);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Tag = "";
            this.Label2.Text = "Selling Price";
            // 
            // btnUnitofSale
            // 
            this.btnUnitofSale.ImageIndex = 0;
            this.btnUnitofSale.ImageList = this.ImageList1;
            this.btnUnitofSale.Location = new System.Drawing.Point(432, 42);
            this.btnUnitofSale.Name = "btnUnitofSale";
            this.btnUnitofSale.Size = new System.Drawing.Size(24, 20);
            this.btnUnitofSale.TabIndex = 22;
            this.btnUnitofSale.TabStop = false;
            this.btnUnitofSale.UseVisualStyleBackColor = true;
            this.btnUnitofSale.Click += new System.EventHandler(this.btnUnitofSale_Click);
            // 
            // btnProID
            // 
            this.btnProID.ImageIndex = 0;
            this.btnProID.ImageList = this.ImageList1;
            this.btnProID.Location = new System.Drawing.Point(225, 8);
            this.btnProID.Name = "btnProID";
            this.btnProID.Size = new System.Drawing.Size(24, 20);
            this.btnProID.TabIndex = 16;
            this.btnProID.TabStop = false;
            this.btnProID.UseVisualStyleBackColor = true;
            this.btnProID.Click += new System.EventHandler(this.btnProID_Click);
            // 
            // SIADDSETUPPRICE_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 159);
            this.ControlBox = false;
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnUnitofSale);
            this.Controls.Add(this.txtUnitofSale);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtUnitofStock);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.btnProID);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SIADDSETUPPRICE_FRM";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Price";
            this.Load += new System.EventHandler(this.SIADDSETUPPRICE_FRM_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboStatus;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnUnitofSale;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.TextBox txtUnitofSale;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtUnitofStock;
        internal System.Windows.Forms.TextBox txtSellingPrice;
        internal System.Windows.Forms.Button btnProID;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.TextBox txtProID;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.TextBox txtProName;
        internal System.Windows.Forms.Label Label2;
    }
}