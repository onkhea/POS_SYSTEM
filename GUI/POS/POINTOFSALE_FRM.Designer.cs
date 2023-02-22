using POS.Transaction;

namespace POS.GUI.POS
{
    partial class POINTOFSALE_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POINTOFSALE_FRM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            //this.axShockwaveFlash2 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblcashier = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            //this.AxShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemKhmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPecent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitOfSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.AxShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//            this.splitContainer1.Panel1.Controls.Add(this.axShockwaveFlash2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(933, 501);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.GotFocus += new System.EventHandler(this.splitContainer1_GotFocus);
            // 
            // axShockwaveFlash2
            // 
            //this.axShockwaveFlash2.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.axShockwaveFlash2.Enabled = true;
            //this.axShockwaveFlash2.Location = new System.Drawing.Point(0, 0);
            //this.axShockwaveFlash2.Name = "axShockwaveFlash2";
            //this.axShockwaveFlash2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash2.OcxState")));
            //this.axShockwaveFlash2.Size = new System.Drawing.Size(933, 110);
            //this.axShockwaveFlash2.TabIndex = 0;
            //this.axShockwaveFlash2.GotFocus += new System.EventHandler(this.axShockwaveFlash2_GotFocus);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2.Controls.Add(this.lblcashier);
            this.splitContainer2.Panel2.Controls.Add(this.lblTotal);
            this.splitContainer2.Panel2.Controls.Add(this.lblmessage);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Size = new System.Drawing.Size(933, 390);
            this.splitContainer2.SplitterDistance = 313;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.GotFocus += new System.EventHandler(this.splitContainer2_GotFocus);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer3.Panel1.BackgroundImage")));
            this.splitContainer3.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer3.Panel1.Controls.Add(this.pictureBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewX1);
            this.splitContainer3.Size = new System.Drawing.Size(933, 313);
            this.splitContainer3.SplitterDistance = 43;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(933, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AllowUserToResizeColumns = false;
            this.dataGridViewX1.AllowUserToResizeRows = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewX1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeight = 40;
            this.dataGridViewX1.ColumnHeadersVisible = false;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.No,
            this.ItemsDescription,
            this.ItemKhmer,
            this.Price,
            this.Quantity,
            this.AmountUSD,
            this.BCode,
            this.DiscountPecent,
            this.DiscountUSD,
            this.UnitOfSale,
            this.StockQ,
            this.UpdateStock});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.RowHeadersWidth = 60;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewX1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX1.RowTemplate.Height = 30;
            this.dataGridViewX1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(933, 269);
            this.dataGridViewX1.TabIndex = 1;
            this.dataGridViewX1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewX1_KeyDown);
            this.dataGridViewX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewX1_KeyPress);
            this.dataGridViewX1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
            // 
            // lblcashier
            // 
            this.lblcashier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcashier.AutoSize = true;
            this.lblcashier.BackColor = System.Drawing.Color.Transparent;
            this.lblcashier.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblcashier.Location = new System.Drawing.Point(108, 42);
            this.lblcashier.Name = "lblcashier";
            this.lblcashier.Size = new System.Drawing.Size(122, 29);
            this.lblcashier.TabIndex = 7;
            this.lblcashier.Text = "POS User";
            this.lblcashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(729, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 100);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblmessage
            // 
            this.lblmessage.BackColor = System.Drawing.Color.Transparent;
            this.lblmessage.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(260, 22);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(413, 29);
            this.lblmessage.TabIndex = 4;
            this.lblmessage.Text = "Waiting for barcode scan for sale...";
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::POS.Properties.Resources.MAIN_POS;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AxShockwaveFlash1
            // 
            //this.AxShockwaveFlash1.Enabled = true;
            //this.AxShockwaveFlash1.Location = new System.Drawing.Point(0, 0);
            //this.AxShockwaveFlash1.Name = "AxShockwaveFlash1";
            //this.AxShockwaveFlash1.Size = new System.Drawing.Size(75, 23);
            //this.AxShockwaveFlash1.TabIndex = 0;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Visible = false;
            this.ItemCode.Width = 5;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 83;
            // 
            // ItemsDescription
            // 
            this.ItemsDescription.HeaderText = "Items Desciption";
            this.ItemsDescription.Name = "ItemsDescription";
            this.ItemsDescription.ReadOnly = true;
            this.ItemsDescription.Width = 523;
            // 
            // ItemKhmer
            // 
            this.ItemKhmer.HeaderText = "Item Khmer";
            this.ItemKhmer.Name = "ItemKhmer";
            this.ItemKhmer.ReadOnly = true;
            this.ItemKhmer.Visible = false;
            this.ItemKhmer.Width = 5;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 92;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 93;
            // 
            // AmountUSD
            // 
            this.AmountUSD.HeaderText = "Amount(USD)";
            this.AmountUSD.Name = "AmountUSD";
            this.AmountUSD.ReadOnly = true;
            this.AmountUSD.Width = 186;
            // 
            // BCode
            // 
            this.BCode.HeaderText = "BCode";
            this.BCode.Name = "BCode";
            this.BCode.ReadOnly = true;
            this.BCode.Visible = false;
            this.BCode.Width = 5;
            // 
            // DiscountPecent
            // 
            this.DiscountPecent.HeaderText = "Discount (%)";
            this.DiscountPecent.Name = "DiscountPecent";
            this.DiscountPecent.ReadOnly = true;
            this.DiscountPecent.Visible = false;
            this.DiscountPecent.Width = 5;
            // 
            // DiscountUSD
            // 
            this.DiscountUSD.HeaderText = "Discount ( USD)";
            this.DiscountUSD.Name = "DiscountUSD";
            this.DiscountUSD.ReadOnly = true;
            this.DiscountUSD.Visible = false;
            this.DiscountUSD.Width = 5;
            // 
            // UnitOfSale
            // 
            this.UnitOfSale.HeaderText = "Unit Of Sale";
            this.UnitOfSale.Name = "UnitOfSale";
            this.UnitOfSale.ReadOnly = true;
            this.UnitOfSale.Visible = false;
            this.UnitOfSale.Width = 5;
            // 
            // StockQ
            // 
            this.StockQ.HeaderText = "StockQ";
            this.StockQ.Name = "StockQ";
            this.StockQ.ReadOnly = true;
            this.StockQ.Visible = false;
            this.StockQ.Width = 5;
            // 
            // UpdateStock
            // 
            this.UpdateStock.HeaderText = "Update Stock";
            this.UpdateStock.Name = "UpdateStock";
            this.UpdateStock.ReadOnly = true;
            this.UpdateStock.Visible = false;
            this.UpdateStock.Width = 5;
            // 
            // POINTOFSALE_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 501);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POINTOFSALE_FRM";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POINTOFSALE_FRM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POINTOFSALE_FRM_Load);
            this.Activated += new System.EventHandler(this.POINTOFSALE_FRM_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.POINTOFSALE_FRM_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.AxShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        internal System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label lblcashier;
        internal System.Windows.Forms.Label lblTotal;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash2;
        internal AxShockwaveFlashObjects.AxShockwaveFlash AxShockwaveFlash1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemKhmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn BCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitOfSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateStock;
        private string SO_INTERVAL;
        private string SO_SUFFIX;
        private string SO_START;
        private string SO_LENGHT;
        private bool ISLOG_OFF = false;
        private Generator generator = new Generator();
    }
}