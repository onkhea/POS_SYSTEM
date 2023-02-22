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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Format";
            // 
            // txtFormatCode
            // 
            this.txtFormatCode.Location = new System.Drawing.Point(120, 20);
            this.txtFormatCode.Name = "txtFormatCode";
            this.txtFormatCode.Size = new System.Drawing.Size(129, 20);
            this.txtFormatCode.TabIndex = 0;
            this.txtFormatCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFormatCode_KeyDown);
            // 
            // txtFormatDesc
            // 
            this.txtFormatDesc.Location = new System.Drawing.Point(279, 21);
            this.txtFormatDesc.Name = "txtFormatDesc";
            this.txtFormatDesc.Size = new System.Drawing.Size(138, 20);
            this.txtFormatDesc.TabIndex = 11;
            // 
            // txtItemCode1
            // 
            this.txtItemCode1.Location = new System.Drawing.Point(305, 50);
            this.txtItemCode1.Name = "txtItemCode1";
            this.txtItemCode1.Size = new System.Drawing.Size(85, 20);
            this.txtItemCode1.TabIndex = 2;
            this.txtItemCode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode1_KeyDown);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(120, 49);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(129, 20);
            this.txtItemCode.TabIndex = 1;
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Transaction Ref. From";
            // 
            // txtTranTo
            // 
            this.txtTranTo.Location = new System.Drawing.Point(281, 80);
            this.txtTranTo.Name = "txtTranTo";
            this.txtTranTo.Size = new System.Drawing.Size(136, 20);
            this.txtTranTo.TabIndex = 4;
            this.txtTranTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTranTo_KeyDown);
            // 
            // txtTranFrom
            // 
            this.txtTranFrom.Location = new System.Drawing.Point(121, 80);
            this.txtTranFrom.Name = "txtTranFrom";
            this.txtTranFrom.Size = new System.Drawing.Size(129, 20);
            this.txtTranFrom.TabIndex = 3;
            this.txtTranFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTranFrom_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Purchase Type :";
            // 
            // cboPurhcaseType
            // 
            this.cboPurhcaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPurhcaseType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPurhcaseType.FormattingEnabled = true;
            this.cboPurhcaseType.Items.AddRange(new object[] {
            "O-Purchase Order",
            "I-Purchase Invoice",
            "D-Debit Note"});
            this.cboPurhcaseType.Location = new System.Drawing.Point(120, 109);
            this.cboPurhcaseType.Name = "cboPurhcaseType";
            this.cboPurhcaseType.Size = new System.Drawing.Size(129, 21);
            this.cboPurhcaseType.TabIndex = 5;
            this.cboPurhcaseType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboPurhcaseType_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Transaction Period :";
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFrom.Location = new System.Drawing.Point(120, 138);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(127, 20);
            this.dtDateFrom.TabIndex = 6;
            this.dtDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDateFrom_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "To";
            // 
            // dtDateTo
            // 
            this.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTo.Location = new System.Drawing.Point(279, 139);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Size = new System.Drawing.Size(138, 20);
            this.dtDateTo.TabIndex = 7;
            this.dtDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDateTo_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Unit Of Report";
            // 
            // txtUnitReport
            // 
            this.txtUnitReport.Location = new System.Drawing.Point(120, 169);
            this.txtUnitReport.Name = "txtUnitReport";
            this.txtUnitReport.Size = new System.Drawing.Size(129, 20);
            this.txtUnitReport.TabIndex = 8;
            this.txtUnitReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitReport_KeyDown);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(261, 206);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "From";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "To";
            // 
            // btnUnitReport
            // 
            this.btnUnitReport.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnUnitReport.Location = new System.Drawing.Point(249, 168);
            this.btnUnitReport.Name = "btnUnitReport";
            this.btnUnitReport.Size = new System.Drawing.Size(27, 22);
            this.btnUnitReport.TabIndex = 21;
            this.btnUnitReport.TabStop = false;
            this.btnUnitReport.UseVisualStyleBackColor = true;
            this.btnUnitReport.Click += new System.EventHandler(this.btnUnitReport_Click);
            // 
            // btnItemCode1
            // 
            this.btnItemCode1.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnItemCode1.Location = new System.Drawing.Point(390, 49);
            this.btnItemCode1.Name = "btnItemCode1";
            this.btnItemCode1.Size = new System.Drawing.Size(27, 22);
            this.btnItemCode1.TabIndex = 8;
            this.btnItemCode1.TabStop = false;
            this.btnItemCode1.UseVisualStyleBackColor = true;
            this.btnItemCode1.Click += new System.EventHandler(this.btnItemCode1_Click);
            // 
            // btnItemCode
            // 
            this.btnItemCode.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnItemCode.Location = new System.Drawing.Point(249, 48);
            this.btnItemCode.Name = "btnItemCode";
            this.btnItemCode.Size = new System.Drawing.Size(27, 22);
            this.btnItemCode.TabIndex = 6;
            this.btnItemCode.TabStop = false;
            this.btnItemCode.UseVisualStyleBackColor = true;
            this.btnItemCode.Click += new System.EventHandler(this.btnItemCode_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnFormat.Location = new System.Drawing.Point(249, 19);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(27, 22);
            this.btnFormat.TabIndex = 2;
            this.btnFormat.TabStop = false;
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // PURCHASELISTING_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 235);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Listing  Report";
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