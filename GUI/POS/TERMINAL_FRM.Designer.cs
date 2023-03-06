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
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Cancel_Button
            // 
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // txtLocDesc
            // 
            resources.ApplyResources(this.txtLocDesc, "txtLocDesc");
            this.txtLocDesc.Name = "txtLocDesc";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // txtLocCode
            // 
            resources.ApplyResources(this.txtLocCode, "txtLocCode");
            this.txtLocCode.Name = "txtLocCode";
            this.txtLocCode.Tag = "Quotation Format";
            this.txtLocCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocCode_KeyDown);
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Name = "Label1";
            // 
            // btnLocCode
            // 
            resources.ApplyResources(this.btnLocCode, "btnLocCode");
            this.btnLocCode.ImageList = this.ImageList1;
            this.btnLocCode.Name = "btnLocCode";
            this.btnLocCode.TabStop = false;
            this.btnLocCode.UseVisualStyleBackColor = true;
            this.btnLocCode.Click += new System.EventHandler(this.btnLocCode_Click);
            // 
            // txtCustName
            // 
            resources.ApplyResources(this.txtCustName, "txtCustName");
            this.txtCustName.Name = "txtCustName";
            // 
            // btnCustomer
            // 
            resources.ApplyResources(this.btnCustomer, "btnCustomer");
            this.btnCustomer.ImageList = this.ImageList1;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.TabStop = false;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // txtCustomer
            // 
            resources.ApplyResources(this.txtCustomer, "txtCustomer");
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Tag = "Quotation Format";
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // TERMINAL_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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