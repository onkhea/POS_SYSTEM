namespace POS.Reports.Inventory_Movement
{
    partial class InventoryTransfer
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
            this.txtFormatDesc = new System.Windows.Forms.TextBox();
            this.txtFormatCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtUnitReport = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocationTo = new System.Windows.Forms.TextBox();
            this.txtLocationFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemCode1 = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocDesFrom = new System.Windows.Forms.TextBox();
            this.txtLocDesTo = new System.Windows.Forms.TextBox();
            this.cboTransferInOut = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUnitReport = new System.Windows.Forms.Button();
            this.btnLocationTo = new System.Windows.Forms.Button();
            this.btnLocationFrom = new System.Windows.Forms.Button();
            this.btnItemCode1 = new System.Windows.Forms.Button();
            this.btnItemCode = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFormatDesc
            // 
            this.txtFormatDesc.Enabled = false;
            this.txtFormatDesc.Location = new System.Drawing.Point(277, 12);
            this.txtFormatDesc.Name = "txtFormatDesc";
            this.txtFormatDesc.Size = new System.Drawing.Size(203, 20);
            this.txtFormatDesc.TabIndex = 11;
            // 
            // txtFormatCode
            // 
            this.txtFormatCode.Location = new System.Drawing.Point(117, 11);
            this.txtFormatCode.Name = "txtFormatCode";
            this.txtFormatCode.Size = new System.Drawing.Size(129, 20);
            this.txtFormatCode.TabIndex = 8;
            this.txtFormatCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFormatCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Report Format";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(318, 183);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 70;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtUnitReport
            // 
            this.txtUnitReport.Location = new System.Drawing.Point(120, 149);
            this.txtUnitReport.Name = "txtUnitReport";
            this.txtUnitReport.Size = new System.Drawing.Size(129, 20);
            this.txtUnitReport.TabIndex = 67;
            this.txtUnitReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitReport_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Unit Of Report";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "To";
            // 
            // dtDateTo
            // 
            this.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTo.Location = new System.Drawing.Point(305, 122);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Size = new System.Drawing.Size(178, 20);
            this.dtDateTo.TabIndex = 65;
            this.dtDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDateTo_KeyDown);
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFrom.Location = new System.Drawing.Point(120, 121);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(156, 20);
            this.dtDateFrom.TabIndex = 64;
            this.dtDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDateFrom_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "From";
            // 
            // txtLocationTo
            // 
            this.txtLocationTo.Location = new System.Drawing.Point(117, 63);
            this.txtLocationTo.Name = "txtLocationTo";
            this.txtLocationTo.Size = new System.Drawing.Size(132, 20);
            this.txtLocationTo.TabIndex = 56;
            this.txtLocationTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocationTo_KeyDown);
            // 
            // txtLocationFrom
            // 
            this.txtLocationFrom.Location = new System.Drawing.Point(117, 37);
            this.txtLocationFrom.Name = "txtLocationFrom";
            this.txtLocationFrom.Size = new System.Drawing.Size(132, 20);
            this.txtLocationFrom.TabIndex = 55;
            this.txtLocationFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocationFrom_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "From";
            // 
            // txtItemCode1
            // 
            this.txtItemCode1.Location = new System.Drawing.Point(305, 93);
            this.txtItemCode1.Name = "txtItemCode1";
            this.txtItemCode1.Size = new System.Drawing.Size(148, 20);
            this.txtItemCode1.TabIndex = 49;
            this.txtItemCode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode1_KeyDown);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(117, 92);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(132, 20);
            this.txtItemCode.TabIndex = 48;
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Item Code";
            // 
            // txtLocDesFrom
            // 
            this.txtLocDesFrom.Enabled = false;
            this.txtLocDesFrom.Location = new System.Drawing.Point(277, 37);
            this.txtLocDesFrom.Name = "txtLocDesFrom";
            this.txtLocDesFrom.Size = new System.Drawing.Size(203, 20);
            this.txtLocDesFrom.TabIndex = 72;
            // 
            // txtLocDesTo
            // 
            this.txtLocDesTo.Enabled = false;
            this.txtLocDesTo.Location = new System.Drawing.Point(277, 63);
            this.txtLocDesTo.Name = "txtLocDesTo";
            this.txtLocDesTo.Size = new System.Drawing.Size(203, 20);
            this.txtLocDesTo.TabIndex = 73;
            // 
            // cboTransferInOut
            // 
            this.cboTransferInOut.FormattingEnabled = true;
            this.cboTransferInOut.Items.AddRange(new object[] {
            "I-Transfer-In",
            "R-Transfer-Out",
            " Transfer In / Out"});
            this.cboTransferInOut.Location = new System.Drawing.Point(368, 149);
            this.cboTransferInOut.Name = "cboTransferInOut";
            this.cboTransferInOut.Size = new System.Drawing.Size(113, 21);
            this.cboTransferInOut.TabIndex = 74;
            this.cboTransferInOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTransferInOut_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Transfer In/Out";
            // 
            // btnUnitReport
            // 
            this.btnUnitReport.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnUnitReport.Location = new System.Drawing.Point(249, 148);
            this.btnUnitReport.Name = "btnUnitReport";
            this.btnUnitReport.Size = new System.Drawing.Size(27, 22);
            this.btnUnitReport.TabIndex = 69;
            this.btnUnitReport.TabStop = false;
            this.btnUnitReport.UseVisualStyleBackColor = true;
            this.btnUnitReport.Click += new System.EventHandler(this.btnUnitReport_Click);
            // 
            // btnLocationTo
            // 
            this.btnLocationTo.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnLocationTo.Location = new System.Drawing.Point(249, 62);
            this.btnLocationTo.Name = "btnLocationTo";
            this.btnLocationTo.Size = new System.Drawing.Size(27, 22);
            this.btnLocationTo.TabIndex = 59;
            this.btnLocationTo.TabStop = false;
            this.btnLocationTo.UseVisualStyleBackColor = true;
            this.btnLocationTo.Click += new System.EventHandler(this.btnLocationTo_Click);
            // 
            // btnLocationFrom
            // 
            this.btnLocationFrom.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnLocationFrom.Location = new System.Drawing.Point(249, 36);
            this.btnLocationFrom.Name = "btnLocationFrom";
            this.btnLocationFrom.Size = new System.Drawing.Size(27, 22);
            this.btnLocationFrom.TabIndex = 58;
            this.btnLocationFrom.TabStop = false;
            this.btnLocationFrom.UseVisualStyleBackColor = true;
            this.btnLocationFrom.Click += new System.EventHandler(this.btnLocationFrom_Click);
            // 
            // btnItemCode1
            // 
            this.btnItemCode1.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnItemCode1.Location = new System.Drawing.Point(454, 92);
            this.btnItemCode1.Name = "btnItemCode1";
            this.btnItemCode1.Size = new System.Drawing.Size(26, 22);
            this.btnItemCode1.TabIndex = 52;
            this.btnItemCode1.TabStop = false;
            this.btnItemCode1.UseVisualStyleBackColor = true;
            this.btnItemCode1.Click += new System.EventHandler(this.btnItemCode1_Click);
            // 
            // btnItemCode
            // 
            this.btnItemCode.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnItemCode.Location = new System.Drawing.Point(249, 91);
            this.btnItemCode.Name = "btnItemCode";
            this.btnItemCode.Size = new System.Drawing.Size(27, 22);
            this.btnItemCode.TabIndex = 51;
            this.btnItemCode.TabStop = false;
            this.btnItemCode.UseVisualStyleBackColor = true;
            this.btnItemCode.Click += new System.EventHandler(this.btnItemCode_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnFormat.Location = new System.Drawing.Point(249, 10);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(27, 22);
            this.btnFormat.TabIndex = 10;
            this.btnFormat.TabStop = false;
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // InventoryTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 208);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboTransferInOut);
            this.Controls.Add(this.txtLocDesTo);
            this.Controls.Add(this.txtLocDesFrom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnUnitReport);
            this.Controls.Add(this.txtUnitReport);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtDateTo);
            this.Controls.Add(this.dtDateFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLocationTo);
            this.Controls.Add(this.txtLocationTo);
            this.Controls.Add(this.btnLocationFrom);
            this.Controls.Add(this.txtLocationFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
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
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Transfer";
            this.Load += new System.EventHandler(this.INVENTORY_TRANSFER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormatDesc;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.TextBox txtFormatCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnUnitReport;
        private System.Windows.Forms.TextBox txtUnitReport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtDateTo;
        private System.Windows.Forms.DateTimePicker dtDateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLocationTo;
        private System.Windows.Forms.TextBox txtLocationTo;
        private System.Windows.Forms.Button btnLocationFrom;
        private System.Windows.Forms.TextBox txtLocationFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnItemCode1;
        private System.Windows.Forms.TextBox txtItemCode1;
        private System.Windows.Forms.Button btnItemCode;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocDesFrom;
        private System.Windows.Forms.TextBox txtLocDesTo;
        private System.Windows.Forms.ComboBox cboTransferInOut;
        private System.Windows.Forms.Label label12;
    }
}