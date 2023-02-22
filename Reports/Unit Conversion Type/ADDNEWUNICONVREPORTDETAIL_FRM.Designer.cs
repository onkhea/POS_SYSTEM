namespace POS.Reports.Unit_Conversion_Type
{
    partial class ADDNEWUNICONVREPORTDETAIL_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDNEWUNICONVREPORTDETAIL_FRM));
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtUnitofSale = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtUnitofStock = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtComment2 = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.txtComment1 = new System.Windows.Forms.TextBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnitofSale = new System.Windows.Forms.Button();
            this.btnUnitofStock = new System.Windows.Forms.Button();
            this.btnItemCode = new System.Windows.Forms.Button();
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
            this.txtUnitofSale.Location = new System.Drawing.Point(303, 41);
            this.txtUnitofSale.MaxLength = 15;
            this.txtUnitofSale.Name = "txtUnitofSale";
            this.txtUnitofSale.Size = new System.Drawing.Size(144, 20);
            this.txtUnitofSale.TabIndex = 23;
            this.txtUnitofSale.Tag = "Unit of Sale";
            this.txtUnitofSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitofSale_KeyDown);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(236, 45);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(62, 13);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "Unit of Sale";
            // 
            // txtUnitofStock
            // 
            this.txtUnitofStock.Enabled = false;
            this.txtUnitofStock.Location = new System.Drawing.Point(87, 41);
            this.txtUnitofStock.MaxLength = 15;
            this.txtUnitofStock.Name = "txtUnitofStock";
            this.txtUnitofStock.Size = new System.Drawing.Size(124, 20);
            this.txtUnitofStock.TabIndex = 20;
            this.txtUnitofStock.Tag = "Unit of Stock";
            this.txtUnitofStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitofStock_KeyDown);
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Enabled = false;
            this.txtItemDescription.Location = new System.Drawing.Point(239, 10);
            this.txtItemDescription.MaxLength = 50;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(231, 20);
            this.txtItemDescription.TabIndex = 18;
            this.txtItemDescription.Tag = "Item Description";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(87, 10);
            this.txtItemCode.MaxLength = 15;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(124, 20);
            this.txtItemCode.TabIndex = 16;
            this.txtItemCode.Tag = "Item Code";
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 106);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(78, 13);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Sec Comments";
            // 
            // txtComment2
            // 
            this.txtComment2.Location = new System.Drawing.Point(87, 103);
            this.txtComment2.MaxLength = 100;
            this.txtComment2.Name = "txtComment2";
            this.txtComment2.Size = new System.Drawing.Size(383, 20);
            this.txtComment2.TabIndex = 28;
            this.txtComment2.Tag = "Sec Comments";
            this.txtComment2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComment2_KeyDown);
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
            // 
            // txtComment1
            // 
            this.txtComment1.Location = new System.Drawing.Point(87, 72);
            this.txtComment1.MaxLength = 100;
            this.txtComment1.Name = "txtComment1";
            this.txtComment1.Size = new System.Drawing.Size(383, 20);
            this.txtComment1.TabIndex = 26;
            this.txtComment1.Tag = "Comments";
            this.txtComment1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComment1_KeyDown);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 75);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 13);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Comments";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Unit of Stock";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "&Item Code";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(319, 126);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 29;
            // 
            // btnUnitofSale
            // 
            this.btnUnitofSale.ImageIndex = 0;
            this.btnUnitofSale.ImageList = this.ImageList1;
            this.btnUnitofSale.Location = new System.Drawing.Point(447, 41);
            this.btnUnitofSale.Name = "btnUnitofSale";
            this.btnUnitofSale.Size = new System.Drawing.Size(24, 20);
            this.btnUnitofSale.TabIndex = 24;
            this.btnUnitofSale.TabStop = false;
            this.btnUnitofSale.UseVisualStyleBackColor = true;
            this.btnUnitofSale.Click += new System.EventHandler(this.btnUnitofSale_Click);
            // 
            // btnUnitofStock
            // 
            this.btnUnitofStock.Enabled = false;
            this.btnUnitofStock.ImageIndex = 0;
            this.btnUnitofStock.ImageList = this.ImageList1;
            this.btnUnitofStock.Location = new System.Drawing.Point(212, 41);
            this.btnUnitofStock.Name = "btnUnitofStock";
            this.btnUnitofStock.Size = new System.Drawing.Size(24, 20);
            this.btnUnitofStock.TabIndex = 21;
            this.btnUnitofStock.TabStop = false;
            this.btnUnitofStock.UseVisualStyleBackColor = true;
            this.btnUnitofStock.Visible = false;
            this.btnUnitofStock.Click += new System.EventHandler(this.btnUnitofStock_Click);
            // 
            // btnItemCode
            // 
            this.btnItemCode.ImageIndex = 0;
            this.btnItemCode.ImageList = this.ImageList1;
            this.btnItemCode.Location = new System.Drawing.Point(212, 10);
            this.btnItemCode.Name = "btnItemCode";
            this.btnItemCode.Size = new System.Drawing.Size(24, 20);
            this.btnItemCode.TabIndex = 17;
            this.btnItemCode.TabStop = false;
            this.btnItemCode.UseVisualStyleBackColor = true;
            this.btnItemCode.Click += new System.EventHandler(this.btnItemCode_Click);
            // 
            // ADDNEWUNICONVREPORTDETAIL_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(484, 157);
            this.Controls.Add(this.btnUnitofSale);
            this.Controls.Add(this.txtUnitofSale);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.btnUnitofStock);
            this.Controls.Add(this.txtUnitofStock);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.btnItemCode);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtComment2);
            this.Controls.Add(this.txtComment1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDNEWUNICONVREPORTDETAIL_FRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Unit Conversion";
            this.Load += new System.EventHandler(this.ADDNEWUNICONVREPORTDETAIL_FRM_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnUnitofSale;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.TextBox txtUnitofSale;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnUnitofStock;
        internal System.Windows.Forms.TextBox txtUnitofStock;
        internal System.Windows.Forms.TextBox txtItemDescription;
        internal System.Windows.Forms.Button btnItemCode;
        internal System.Windows.Forms.TextBox txtItemCode;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtComment2;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.TextBox txtComment1;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
    }
}