namespace POS.Reports.Purchase
{
    partial class PURCHASELISTING_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PURCHASELISTING_FRM));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormatCode = new System.Windows.Forms.TextBox();
            this.txtFormatDesc = new System.Windows.Forms.TextBox();
            this.txtItemCode1 = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTranTo = new System.Windows.Forms.TextBox();
            this.txtTranFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPurhcaseType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtDateTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnitReport = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUnitReport = new System.Windows.Forms.Button();
            this.btnItemCode1 = new System.Windows.Forms.Button();
            this.btnItemCode = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtFormatCode
            // 
            resources.ApplyResources(this.txtFormatCode, "txtFormatCode");
            this.txtFormatCode.Name = "txtFormatCode";
            this.txtFormatCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFormatCode_KeyDown);
            // 
            // txtFormatDesc
            // 
            resources.ApplyResources(this.txtFormatDesc, "txtFormatDesc");
            this.txtFormatDesc.Name = "txtFormatDesc";
            // 
            // txtItemCode1
            // 
            resources.ApplyResources(this.txtItemCode1, "txtItemCode1");
            this.txtItemCode1.Name = "txtItemCode1";
            this.txtItemCode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode1_KeyDown);
            // 
            // txtItemCode
            // 
            resources.ApplyResources(this.txtItemCode, "txtItemCode");
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtTranTo
            // 
            resources.ApplyResources(this.txtTranTo, "txtTranTo");
            this.txtTranTo.Name = "txtTranTo";
            this.txtTranTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTranTo_KeyDown);
            // 
            // txtTranFrom
            // 
            resources.ApplyResources(this.txtTranFrom, "txtTranFrom");
            this.txtTranFrom.Name = "txtTranFrom";
            this.txtTranFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTranFrom_KeyDown);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cboPurhcaseType
            // 
            resources.ApplyResources(this.cboPurhcaseType, "cboPurhcaseType");
            this.cboPurhcaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPurhcaseType.FormattingEnabled = true;
            this.cboPurhcaseType.Items.AddRange(new object[] {
            resources.GetString("cboPurhcaseType.Items"),
            resources.GetString("cboPurhcaseType.Items1"),
            resources.GetString("cboPurhcaseType.Items2")});
            this.cboPurhcaseType.Name = "cboPurhcaseType";
            this.cboPurhcaseType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboPurhcaseType_KeyDown);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dtDateFrom
            // 
            resources.ApplyResources(this.dtDateFrom, "dtDateFrom");
            this.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDateFrom_KeyDown);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // dtDateTo
            // 
            resources.ApplyResources(this.dtDateTo, "dtDateTo");
            this.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDateTo_KeyDown);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtUnitReport
            // 
            resources.ApplyResources(this.txtUnitReport, "txtUnitReport");
            this.txtUnitReport.Name = "txtUnitReport";
            this.txtUnitReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitReport_KeyDown);
            // 
            // btnPreview
            // 
            resources.ApplyResources(this.btnPreview, "btnPreview");
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // btnUnitReport
            // 
            resources.ApplyResources(this.btnUnitReport, "btnUnitReport");
            this.btnUnitReport.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnUnitReport.Name = "btnUnitReport";
            this.btnUnitReport.TabStop = false;
            this.btnUnitReport.UseVisualStyleBackColor = true;
            this.btnUnitReport.Click += new System.EventHandler(this.btnUnitReport_Click);
            // 
            // btnItemCode1
            // 
            resources.ApplyResources(this.btnItemCode1, "btnItemCode1");
            this.btnItemCode1.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnItemCode1.Name = "btnItemCode1";
            this.btnItemCode1.TabStop = false;
            this.btnItemCode1.UseVisualStyleBackColor = true;
            this.btnItemCode1.Click += new System.EventHandler(this.btnItemCode1_Click);
            // 
            // btnItemCode
            // 
            resources.ApplyResources(this.btnItemCode, "btnItemCode");
            this.btnItemCode.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnItemCode.Name = "btnItemCode";
            this.btnItemCode.TabStop = false;
            this.btnItemCode.UseVisualStyleBackColor = true;
            this.btnItemCode.Click += new System.EventHandler(this.btnItemCode_Click);
            // 
            // btnFormat
            // 
            resources.ApplyResources(this.btnFormat, "btnFormat");
            this.btnFormat.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.TabStop = false;
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // PURCHASELISTING_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnUnitReport);
            this.Controls.Add(this.txtUnitReport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtDateTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtDateFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboPurhcaseType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTranTo);
            this.Controls.Add(this.txtTranFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnItemCode1);
            this.Controls.Add(this.txtItemCode1);
            this.Controls.Add(this.btnItemCode);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFormatDesc);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.txtFormatCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PURCHASELISTING_FRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PURCHASELISTING_FRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFormatCode;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.TextBox txtFormatDesc;
        private System.Windows.Forms.TextBox txtItemCode1;
        private System.Windows.Forms.Button btnItemCode;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnItemCode1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTranTo;
        private System.Windows.Forms.TextBox txtTranFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPurhcaseType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDateFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtDateTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUnitReport;
        private System.Windows.Forms.TextBox txtUnitReport;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}