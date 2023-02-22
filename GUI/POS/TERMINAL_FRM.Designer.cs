namespace POS.GUI.POS
{
    partial class TERMINAL_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TERMINAL_FRM));
            this.btnOK = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.txtLocDesc = new System.Windows.Forms.TextBox();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtLocCode = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnLocCode = new System.Windows.Forms.Button();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(328, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(408, 179);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 11;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // txtLocDesc
            // 
            this.txtLocDesc.Enabled = false;
            this.txtLocDesc.Location = new System.Drawing.Point(267, 87);
            this.txtLocDesc.Name = "txtLocDesc";
            this.txtLocDesc.Size = new System.Drawing.Size(201, 20);
            this.txtLocDesc.TabIndex = 9;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // txtLocCode
            // 
            this.txtLocCode.Location = new System.Drawing.Point(114, 86);
            this.txtLocCode.MaxLength = 15;
            this.txtLocCode.Name = "txtLocCode";
            this.txtLocCode.Size = new System.Drawing.Size(124, 20);
            this.txtLocCode.TabIndex = 0;
            this.txtLocCode.Tag = "Quotation Format";
            this.txtLocCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocCode_KeyDown);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(21, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(78, 20);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Location";
            // 
            // btnLocCode
            // 
            this.btnLocCode.ImageIndex = 0;
            this.btnLocCode.ImageList = this.ImageList1;
            this.btnLocCode.Location = new System.Drawing.Point(238, 87);
            this.btnLocCode.Name = "btnLocCode";
            this.btnLocCode.Size = new System.Drawing.Size(24, 20);
            this.btnLocCode.TabIndex = 8;
            this.btnLocCode.TabStop = false;
            this.btnLocCode.UseVisualStyleBackColor = true;
            this.btnLocCode.Click += new System.EventHandler(this.btnLocCode_Click);
            // 
            // txtCustName
            // 
            this.txtCustName.Enabled = false;
            this.txtCustName.Location = new System.Drawing.Point(267, 122);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(201, 20);
            this.txtCustName.TabIndex = 15;
            // 
            // btnCustomer
            // 
            this.btnCustomer.ImageIndex = 0;
            this.btnCustomer.ImageList = this.ImageList1;
            this.btnCustomer.Location = new System.Drawing.Point(238, 122);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(24, 20);
            this.btnCustomer.TabIndex = 14;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(114, 121);
            this.txtCustomer.MaxLength = 15;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(124, 20);
            this.txtCustomer.TabIndex = 1;
            this.txtCustomer.Tag = "Quotation Format";
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Customer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 167);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // TERMINAL_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 169);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.txtLocDesc);
            this.Controls.Add(this.btnLocCode);
            this.Controls.Add(this.txtLocCode);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TERMINAL_FRM";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TERMINAL_FRM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TERMINAL_FRM_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.TextBox txtLocDesc;
        internal System.Windows.Forms.Button btnLocCode;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.TextBox txtLocCode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCustName;
        internal System.Windows.Forms.Button btnCustomer;
        internal System.Windows.Forms.TextBox txtCustomer;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}