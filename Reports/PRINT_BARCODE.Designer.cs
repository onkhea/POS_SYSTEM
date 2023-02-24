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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRINT_BARCODE));
            this.Label6 = new System.Windows.Forms.Label();
            this.txt_Item_codeF = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Item_codeF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label6
            // 
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.Name = "Label6";
            // 
            // txt_Item_codeF
            // 
            resources.ApplyResources(this.txt_Item_codeF, "txt_Item_codeF");
            this.txt_Item_codeF.Name = "txt_Item_codeF";
            this.txt_Item_codeF.Tag = "Account Link";
            this.txt_Item_codeF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Item_codeF_KeyDown);
            // 
            // txtDesc
            // 
            resources.ApplyResources(this.txtDesc, "txtDesc");
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Tag = "Account Link";
            // 
            // txtBarcode
            // 
            resources.ApplyResources(this.txtBarcode, "txtBarcode");
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Tag = "Account Link";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtNumBarcode
            // 
            resources.ApplyResources(this.txtNumBarcode, "txtNumBarcode");
            this.txtNumBarcode.Name = "txtNumBarcode";
            this.txtNumBarcode.Tag = "Account Link";
            this.txtNumBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumBarcode_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnPreview
            // 
            resources.ApplyResources(this.btnPreview, "btnPreview");
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_Item_codeF
            // 
            resources.ApplyResources(this.btn_Item_codeF, "btn_Item_codeF");
            this.btn_Item_codeF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Item_codeF.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btn_Item_codeF.Name = "btn_Item_codeF";
            this.btn_Item_codeF.TabStop = false;
            this.btn_Item_codeF.UseVisualStyleBackColor = true;
            this.btn_Item_codeF.Click += new System.EventHandler(this.btn_Item_codeF_Click);
            // 
            // PRINT_BARCODE
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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