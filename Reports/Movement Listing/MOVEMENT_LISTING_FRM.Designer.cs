namespace POS.Reports.Movement_Listing
{
    partial class MOVEMENT_LISTING_FRM
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
            this.txtMovDescFrom = new System.Windows.Forms.TextBox();
            this.txtMovTypeFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMovDescTo = new System.Windows.Forms.TextBox();
            this.txtMovTypeTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMovRefTo = new System.Windows.Forms.TextBox();
            this.txtMovRefFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtDatTo = new System.Windows.Forms.DateTimePicker();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUnitReport = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUnitReport = new System.Windows.Forms.Button();
            this.btnMovTypeTo = new System.Windows.Forms.Button();
            this.btnMovTypeFrom = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFormatDesc
            // 
            this.txtFormatDesc.Location = new System.Drawing.Point(317, 18);
            this.txtFormatDesc.Name = "txtFormatDesc";
            this.txtFormatDesc.Size = new System.Drawing.Size(138, 20);
            this.txtFormatDesc.TabIndex = 7;
            // 
            // txtFormatCode
            // 
            this.txtFormatCode.Location = new System.Drawing.Point(158, 17);
            this.txtFormatCode.Name = "txtFormatCode";
            this.txtFormatCode.Size = new System.Drawing.Size(129, 20);
            this.txtFormatCode.TabIndex = 4;
            this.txtFormatCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFormatCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Report Format";
            // 
            // txtMovDescFrom
            // 
            this.txtMovDescFrom.Location = new System.Drawing.Point(317, 45);
            this.txtMovDescFrom.Name = "txtMovDescFrom";
            this.txtMovDescFrom.Size = new System.Drawing.Size(138, 20);
            this.txtMovDescFrom.TabIndex = 11;
            // 
            // txtMovTypeFrom
            // 
            this.txtMovTypeFrom.Location = new System.Drawing.Point(158, 44);
            this.txtMovTypeFrom.Name = "txtMovTypeFrom";
            this.txtMovTypeFrom.Size = new System.Drawing.Size(129, 20);
            this.txtMovTypeFrom.TabIndex = 8;
            this.txtMovTypeFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovTypeFrom_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Movement Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "To";
            // 
            // txtMovDescTo
            // 
            this.txtMovDescTo.Location = new System.Drawing.Point(317, 73);
            this.txtMovDescTo.Name = "txtMovDescTo";
            this.txtMovDescTo.Size = new System.Drawing.Size(138, 20);
            this.txtMovDescTo.TabIndex = 16;
            // 
            // txtMovTypeTo
            // 
            this.txtMovTypeTo.Location = new System.Drawing.Point(158, 72);
            this.txtMovTypeTo.Name = "txtMovTypeTo";
            this.txtMovTypeTo.Size = new System.Drawing.Size(129, 20);
            this.txtMovTypeTo.TabIndex = 13;
            this.txtMovTypeTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovTypeTo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Movement Reference";
            // 
            // txtMovRefTo
            // 
            this.txtMovRefTo.Location = new System.Drawing.Point(317, 100);
            this.txtMovRefTo.Name = "txtMovRefTo";
            this.txtMovRefTo.Size = new System.Drawing.Size(138, 20);
            this.txtMovRefTo.TabIndex = 20;
            this.txtMovRefTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovRefTo_KeyDown);
            // 
            // txtMovRefFrom
            // 
            this.txtMovRefFrom.Location = new System.Drawing.Point(158, 99);
            this.txtMovRefFrom.Name = "txtMovRefFrom";
            this.txtMovRefFrom.Size = new System.Drawing.Size(129, 20);
            this.txtMovRefFrom.TabIndex = 18;
            this.txtMovRefFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovRefFrom_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "From";
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFrom.Location = new System.Drawing.Point(159, 128);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(128, 20);
            this.dtDateFrom.TabIndex = 26;
            this.dtDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDateFrom_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "To";
            // 
            // dtDatTo
            // 
            this.dtDatTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatTo.Location = new System.Drawing.Point(317, 131);
            this.dtDatTo.Name = "dtDatTo";
            this.dtDatTo.Size = new System.Drawing.Size(138, 20);
            this.dtDatTo.TabIndex = 28;
            this.dtDatTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDatTo_KeyDown);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(292, 185);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 29;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(380, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUnitReport
            // 
            this.txtUnitReport.Location = new System.Drawing.Point(159, 154);
            this.txtUnitReport.Name = "txtUnitReport";
            this.txtUnitReport.Size = new System.Drawing.Size(129, 20);
            this.txtUnitReport.TabIndex = 31;
            this.txtUnitReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitReport_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Unit Of Report";
            // 
            // btnUnitReport
            // 
            this.btnUnitReport.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnUnitReport.Location = new System.Drawing.Point(288, 153);
            this.btnUnitReport.Name = "btnUnitReport";
            this.btnUnitReport.Size = new System.Drawing.Size(27, 22);
            this.btnUnitReport.TabIndex = 33;
            this.btnUnitReport.TabStop = false;
            this.btnUnitReport.UseVisualStyleBackColor = true;
            this.btnUnitReport.Click += new System.EventHandler(this.btnUnitReport_Click);
            // 
            // btnMovTypeTo
            // 
            this.btnMovTypeTo.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnMovTypeTo.Location = new System.Drawing.Point(287, 71);
            this.btnMovTypeTo.Name = "btnMovTypeTo";
            this.btnMovTypeTo.Size = new System.Drawing.Size(27, 22);
            this.btnMovTypeTo.TabIndex = 15;
            this.btnMovTypeTo.TabStop = false;
            this.btnMovTypeTo.UseVisualStyleBackColor = true;
            this.btnMovTypeTo.Click += new System.EventHandler(this.btnMovTypeTo_Click);
            // 
            // btnMovTypeFrom
            // 
            this.btnMovTypeFrom.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnMovTypeFrom.Location = new System.Drawing.Point(287, 43);
            this.btnMovTypeFrom.Name = "btnMovTypeFrom";
            this.btnMovTypeFrom.Size = new System.Drawing.Size(27, 22);
            this.btnMovTypeFrom.TabIndex = 10;
            this.btnMovTypeFrom.TabStop = false;
            this.btnMovTypeFrom.UseVisualStyleBackColor = true;
            this.btnMovTypeFrom.Click += new System.EventHandler(this.btnMovTypeFrom_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnFormat.Location = new System.Drawing.Point(287, 16);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(27, 22);
            this.btnFormat.TabIndex = 6;
            this.btnFormat.TabStop = false;
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // MOVEMENT_LISTING_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 216);
            this.Controls.Add(this.btnUnitReport);
            this.Controls.Add(this.txtUnitReport);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dtDatTo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtDateFrom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMovRefTo);
            this.Controls.Add(this.txtMovRefFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMovDescTo);
            this.Controls.Add(this.btnMovTypeTo);
            this.Controls.Add(this.txtMovTypeTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMovDescFrom);
            this.Controls.Add(this.btnMovTypeFrom);
            this.Controls.Add(this.txtMovTypeFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFormatDesc);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.txtFormatCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MOVEMENT_LISTING_FRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movement Listing";
            this.Load += new System.EventHandler(this.MOVEMENT_LISTING_FRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormatDesc;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.TextBox txtFormatCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovDescFrom;
        private System.Windows.Forms.Button btnMovTypeFrom;
        private System.Windows.Forms.TextBox txtMovTypeFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMovDescTo;
        private System.Windows.Forms.Button btnMovTypeTo;
        private System.Windows.Forms.TextBox txtMovTypeTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMovRefTo;
        private System.Windows.Forms.TextBox txtMovRefFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtDateFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtDatTo;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUnitReport;
        private System.Windows.Forms.TextBox txtUnitReport;
        private System.Windows.Forms.Label label11;
    }
}