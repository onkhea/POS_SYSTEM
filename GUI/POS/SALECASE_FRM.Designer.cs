namespace POS.GUI.POS
{
    partial class SALECASE_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SALECASE_FRM));
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUnitofStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUnitOfSale = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(848, 427);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 19;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.Location = new System.Drawing.Point(367, 419);
            this.txtAmount.MaxLength = 100;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(323, 34);
            this.txtAmount.TabIndex = 18;
            this.txtAmount.TabStop = false;
            this.txtAmount.Tag = "Amount";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.ForeColor = System.Drawing.Color.Black;
            this.txtBarcode.Location = new System.Drawing.Point(368, 81);
            this.txtBarcode.MaxLength = 15;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(323, 34);
            this.txtBarcode.TabIndex = 11;
            this.txtBarcode.Tag = "";
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.Location = new System.Drawing.Point(367, 370);
            this.txtDiscount.MaxLength = 100;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(323, 34);
            this.txtDiscount.TabIndex = 17;
            this.txtDiscount.TabStop = false;
            this.txtDiscount.Tag = "D/C";
            this.txtDiscount.Text = "0.00";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(59, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(631, 25);
            this.txtName.TabIndex = 12;
            // 
            // txtUnitofStock
            // 
            this.txtUnitofStock.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUnitofStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnitofStock.Enabled = false;
            this.txtUnitofStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitofStock.ForeColor = System.Drawing.Color.Black;
            this.txtUnitofStock.Location = new System.Drawing.Point(367, 178);
            this.txtUnitofStock.MaxLength = 5;
            this.txtUnitofStock.Name = "txtUnitofStock";
            this.txtUnitofStock.Size = new System.Drawing.Size(323, 34);
            this.txtUnitofStock.TabIndex = 13;
            this.txtUnitofStock.TabStop = false;
            this.txtUnitofStock.Tag = "";
            this.txtUnitofStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(367, 274);
            this.txtPrice.MaxLength = 100;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(323, 34);
            this.txtPrice.TabIndex = 15;
            this.txtPrice.TabStop = false;
            this.txtPrice.Tag = "Price";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnitOfSale
            // 
            this.txtUnitOfSale.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUnitOfSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnitOfSale.Enabled = false;
            this.txtUnitOfSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitOfSale.ForeColor = System.Drawing.Color.Black;
            this.txtUnitOfSale.Location = new System.Drawing.Point(369, 226);
            this.txtUnitOfSale.MaxLength = 5;
            this.txtUnitOfSale.Name = "txtUnitOfSale";
            this.txtUnitOfSale.Size = new System.Drawing.Size(274, 34);
            this.txtUnitOfSale.TabIndex = 14;
            this.txtUnitOfSale.Tag = "Unit of Sale";
            this.txtUnitOfSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitOfSale_KeyDown);
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.Enabled = false;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.Location = new System.Drawing.Point(367, 323);
            this.txtQty.MaxLength = 20;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(323, 34);
            this.txtQty.TabIndex = 16;
            this.txtQty.Tag = "Sale Quantity";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(643, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 46);
            this.panel1.TabIndex = 20;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // SALECASE_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUnitofStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtUnitOfSale);
            this.Controls.Add(this.txtQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SALECASE_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SALECASE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.TextBox txtBarcode;
        internal System.Windows.Forms.TextBox txtDiscount;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtUnitofStock;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.TextBox txtUnitOfSale;
        internal System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Panel panel1;

    }
}