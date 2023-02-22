namespace POS.Reports
{
    partial class PRINT_BARCODE
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
            this.Label6 = new System.Windows.Forms.Label();
            this.txt_Item_codeF = new System.Windows.Forms.TextBox();
            this.btn_Item_codeF = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(8, 9);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(54, 13);
            this.Label6.TabIndex = 35;
            this.Label6.Text = "Item code";
            // 
            // txt_Item_codeF
            // 
            this.txt_Item_codeF.Location = new System.Drawing.Point(131, 7);
            this.txt_Item_codeF.MaxLength = 50;
            this.txt_Item_codeF.Name = "txt_Item_codeF";
            this.txt_Item_codeF.Size = new System.Drawing.Size(120, 20);
            this.txt_Item_codeF.TabIndex = 37;
            this.txt_Item_codeF.Tag = "Account Link";
            this.txt_Item_codeF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Item_codeF_KeyDown);
            // 
            // btn_Item_codeF
            // 
            this.btn_Item_codeF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Item_codeF.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btn_Item_codeF.Location = new System.Drawing.Point(255, 7);
            this.btn_Item_codeF.Name = "btn_Item_codeF";
            this.btn_Item_codeF.Size = new System.Drawing.Size(24, 20);
            this.btn_Item_codeF.TabIndex = 38;
            this.btn_Item_codeF.TabStop = false;
            this.btn_Item_codeF.UseVisualStyleBackColor = true;
            this.btn_Item_codeF.Click += new System.EventHandler(this.btn_Item_codeF_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(283, 8);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(120, 20);
            this.txtDesc.TabIndex = 39;
            this.txtDesc.Tag = "Account Link";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(131, 33);
            this.txtBarcode.MaxLength = 50;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(272, 20);
            this.txtBarcode.TabIndex = 40;
            this.txtBarcode.Tag = "Account Link";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Item Barcode";
            // 
            // txtNumBarcode
            // 
            this.txtNumBarcode.Location = new System.Drawing.Point(131, 59);
            this.txtNumBarcode.MaxLength = 50;
            this.txtNumBarcode.Name = "txtNumBarcode";
            this.txtNumBarcode.Size = new System.Drawing.Size(120, 20);
            this.txtNumBarcode.TabIndex = 42;
            this.txtNumBarcode.Tag = "Account Link";
            this.txtNumBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumBarcode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Rows Copy BarCode";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(255, 83);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 44;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(336, 83);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PRINT_BARCODE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 111);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btn_Item_codeF);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txt_Item_codeF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PRINT_BARCODE";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print BarCode";
            this.Load += new System.EventHandler(this.PRINT_BARCODE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_Item_codeF;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txt_Item_codeF;
        internal System.Windows.Forms.TextBox txtDesc;
        internal System.Windows.Forms.TextBox txtBarcode;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtNumBarcode;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnClose;
    }
}