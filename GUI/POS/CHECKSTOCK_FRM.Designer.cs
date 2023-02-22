namespace POS.GUI.POS
{
    partial class CHECKSTOCK_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHECKSTOCK_FRM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUnitofStock = new System.Windows.Forms.TextBox();
            this.txtPriceOfStock = new System.Windows.Forms.TextBox();
            this.txtUnitOfSale = new System.Windows.Forms.TextBox();
            this.txtPriceOfSale = new System.Windows.Forms.TextBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(816, 538);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 18;
            this.Cancel_Button.Text = "Cancel";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.ForeColor = System.Drawing.Color.Black;
            this.txtBarcode.Location = new System.Drawing.Point(297, 103);
            this.txtBarcode.MaxLength = 15;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(294, 31);
            this.txtBarcode.TabIndex = 11;
            this.txtBarcode.Tag = "";
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.Enabled = false;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.Location = new System.Drawing.Point(296, 483);
            this.txtQty.MaxLength = 100;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(295, 34);
            this.txtQty.TabIndex = 17;
            this.txtQty.TabStop = false;
            this.txtQty.Tag = "Quantity";
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(297, 162);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 31);
            this.txtName.TabIndex = 12;
            // 
            // txtUnitofStock
            // 
            this.txtUnitofStock.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUnitofStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnitofStock.Enabled = false;
            this.txtUnitofStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitofStock.ForeColor = System.Drawing.Color.Black;
            this.txtUnitofStock.Location = new System.Drawing.Point(297, 222);
            this.txtUnitofStock.MaxLength = 5;
            this.txtUnitofStock.Name = "txtUnitofStock";
            this.txtUnitofStock.Size = new System.Drawing.Size(294, 34);
            this.txtUnitofStock.TabIndex = 13;
            this.txtUnitofStock.TabStop = false;
            this.txtUnitofStock.Tag = "";
            // 
            // txtPriceOfStock
            // 
            this.txtPriceOfStock.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPriceOfStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceOfStock.Enabled = false;
            this.txtPriceOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceOfStock.ForeColor = System.Drawing.Color.Black;
            this.txtPriceOfStock.Location = new System.Drawing.Point(296, 348);
            this.txtPriceOfStock.MaxLength = 100;
            this.txtPriceOfStock.Name = "txtPriceOfStock";
            this.txtPriceOfStock.Size = new System.Drawing.Size(294, 34);
            this.txtPriceOfStock.TabIndex = 15;
            this.txtPriceOfStock.TabStop = false;
            this.txtPriceOfStock.Tag = "Price";
            this.txtPriceOfStock.Text = "0.00";
            this.txtPriceOfStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnitOfSale
            // 
            this.txtUnitOfSale.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUnitOfSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnitOfSale.Enabled = false;
            this.txtUnitOfSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitOfSale.ForeColor = System.Drawing.Color.Black;
            this.txtUnitOfSale.Location = new System.Drawing.Point(297, 285);
            this.txtUnitOfSale.MaxLength = 5;
            this.txtUnitOfSale.Name = "txtUnitOfSale";
            this.txtUnitOfSale.Size = new System.Drawing.Size(294, 34);
            this.txtUnitOfSale.TabIndex = 14;
            this.txtUnitOfSale.Tag = "Unit of Sale";
            // 
            // txtPriceOfSale
            // 
            this.txtPriceOfSale.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPriceOfSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceOfSale.Enabled = false;
            this.txtPriceOfSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceOfSale.ForeColor = System.Drawing.Color.Black;
            this.txtPriceOfSale.Location = new System.Drawing.Point(296, 413);
            this.txtPriceOfSale.MaxLength = 20;
            this.txtPriceOfSale.Name = "txtPriceOfSale";
            this.txtPriceOfSale.Size = new System.Drawing.Size(294, 34);
            this.txtPriceOfSale.TabIndex = 16;
            this.txtPriceOfSale.Tag = "Sale Quantity";
            this.txtPriceOfSale.Text = "0.00";
            this.txtPriceOfSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.ColumnHeadersVisible = false;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qty,
            this.ExpireDate});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(611, 141);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(297, 376);
            this.dataGridViewX1.TabIndex = 19;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // ExpireDate
            // 
            this.ExpireDate.HeaderText = "Expire Date";
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.Width = 193;
            // 
            // CHECKSTOCK_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 579);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUnitofStock);
            this.Controls.Add(this.txtPriceOfStock);
            this.Controls.Add(this.txtUnitOfSale);
            this.Controls.Add(this.txtPriceOfSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CHECKSTOCK_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHECKSTOCK_FRM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.TextBox txtBarcode;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtUnitofStock;
        internal System.Windows.Forms.TextBox txtPriceOfStock;
        internal System.Windows.Forms.TextBox txtUnitOfSale;
        internal System.Windows.Forms.TextBox txtPriceOfSale;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
    }
}