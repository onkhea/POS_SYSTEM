namespace POS.GUI.POS
{
    partial class CASHIN_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CASHIN_FRM));
            this.txtdiscount = new System.Windows.Forms.Label();
            this.txtexchange = new System.Windows.Forms.Label();
            this.txtchanger = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.txtchanged = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtgtotald = new System.Windows.Forms.Label();
            this.txtgtotalr = new System.Windows.Forms.Label();
            this.txtcashinr = new System.Windows.Forms.TextBox();
            this.txtcashind = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdiscount
            // 
            this.txtdiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiscount.BackColor = System.Drawing.Color.White;
            this.txtdiscount.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.ForeColor = System.Drawing.Color.Black;
            this.txtdiscount.Location = new System.Drawing.Point(345, 202);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(299, 36);
            this.txtdiscount.TabIndex = 21;
            this.txtdiscount.Text = "99.99";
            this.txtdiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtexchange
            // 
            this.txtexchange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtexchange.BackColor = System.Drawing.Color.White;
            this.txtexchange.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexchange.ForeColor = System.Drawing.Color.Black;
            this.txtexchange.Location = new System.Drawing.Point(345, 90);
            this.txtexchange.Name = "txtexchange";
            this.txtexchange.Size = new System.Drawing.Size(299, 36);
            this.txtexchange.TabIndex = 18;
            this.txtexchange.Text = "4,000";
            this.txtexchange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtchanger
            // 
            this.txtchanger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtchanger.BackColor = System.Drawing.Color.White;
            this.txtchanger.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtchanger.ForeColor = System.Drawing.Color.Black;
            this.txtchanger.Location = new System.Drawing.Point(345, 537);
            this.txtchanger.Name = "txtchanger";
            this.txtchanger.Size = new System.Drawing.Size(299, 36);
            this.txtchanger.TabIndex = 27;
            this.txtchanger.Text = "0";
            this.txtchanger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsubtotal.BackColor = System.Drawing.Color.White;
            this.txtsubtotal.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.ForeColor = System.Drawing.Color.Black;
            this.txtsubtotal.Location = new System.Drawing.Point(345, 146);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(299, 36);
            this.txtsubtotal.TabIndex = 20;
            this.txtsubtotal.Text = "9,999.99";
            this.txtsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(735, 209);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(45, 23);
            this.Button2.TabIndex = 28;
            this.Button2.TabStop = false;
            this.Button2.Text = "Button2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtchanged
            // 
            this.txtchanged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtchanged.BackColor = System.Drawing.Color.White;
            this.txtchanged.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtchanged.ForeColor = System.Drawing.Color.Black;
            this.txtchanged.Location = new System.Drawing.Point(345, 483);
            this.txtchanged.Name = "txtchanged";
            this.txtchanged.Size = new System.Drawing.Size(299, 36);
            this.txtchanged.TabIndex = 26;
            this.txtchanged.Text = "0.00";
            this.txtchanged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button1
            // 
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(726, 286);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(45, 23);
            this.Button1.TabIndex = 19;
            this.Button1.TabStop = false;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtgtotald
            // 
            this.txtgtotald.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgtotald.BackColor = System.Drawing.Color.White;
            this.txtgtotald.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgtotald.ForeColor = System.Drawing.Color.Black;
            this.txtgtotald.Location = new System.Drawing.Point(345, 258);
            this.txtgtotald.Name = "txtgtotald";
            this.txtgtotald.Size = new System.Drawing.Size(299, 36);
            this.txtgtotald.TabIndex = 22;
            this.txtgtotald.Text = "9,900.00";
            this.txtgtotald.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtgtotalr
            // 
            this.txtgtotalr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgtotalr.BackColor = System.Drawing.Color.White;
            this.txtgtotalr.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgtotalr.ForeColor = System.Drawing.Color.Black;
            this.txtgtotalr.Location = new System.Drawing.Point(345, 315);
            this.txtgtotalr.Name = "txtgtotalr";
            this.txtgtotalr.Size = new System.Drawing.Size(299, 36);
            this.txtgtotalr.TabIndex = 23;
            this.txtgtotalr.Text = "39,600,000";
            this.txtgtotalr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcashinr
            // 
            this.txtcashinr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcashinr.BackColor = System.Drawing.Color.White;
            this.txtcashinr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcashinr.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcashinr.ForeColor = System.Drawing.Color.Black;
            this.txtcashinr.Location = new System.Drawing.Point(345, 425);
            this.txtcashinr.MaxLength = 16;
            this.txtcashinr.Name = "txtcashinr";
            this.txtcashinr.Size = new System.Drawing.Size(299, 39);
            this.txtcashinr.TabIndex = 25;
            this.txtcashinr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcashinr.TextChanged += new System.EventHandler(this.txtcashinr_TextChanged);
            this.txtcashinr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcashinr_KeyPress);
            // 
            // txtcashind
            // 
            this.txtcashind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcashind.BackColor = System.Drawing.Color.White;
            this.txtcashind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcashind.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcashind.ForeColor = System.Drawing.Color.Black;
            this.txtcashind.Location = new System.Drawing.Point(345, 368);
            this.txtcashind.MaxLength = 16;
            this.txtcashind.Name = "txtcashind";
            this.txtcashind.Size = new System.Drawing.Size(299, 39);
            this.txtcashind.TabIndex = 24;
            this.txtcashind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcashind.TextChanged += new System.EventHandler(this.txtcashind_TextChanged);
            this.txtcashind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcashind_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // CASHIN_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 614);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtexchange);
            this.Controls.Add(this.txtchanger);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.txtchanged);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtgtotald);
            this.Controls.Add(this.txtgtotalr);
            this.Controls.Add(this.txtcashinr);
            this.Controls.Add(this.txtcashind);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CASHIN_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CASHIN_FRM";
            this.Load += new System.EventHandler(this.CASHIN_FRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label txtdiscount;
        internal System.Windows.Forms.Label txtexchange;
        internal System.Windows.Forms.Label txtchanger;
        internal System.Windows.Forms.Label txtsubtotal;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label txtchanged;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label txtgtotald;
        internal System.Windows.Forms.Label txtgtotalr;
        internal System.Windows.Forms.TextBox txtcashinr;
        internal System.Windows.Forms.TextBox txtcashind;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}