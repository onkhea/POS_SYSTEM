namespace POS.Reports.Inventory_Movement
{
    partial class INVENTORY_MOVEMENT_FRM
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
            this.btnFormat = new System.Windows.Forms.Button();
            this.txtFormatCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnItemCode1 = new System.Windows.Forms.Button();
            this.txtItemCode1 = new System.Windows.Forms.TextBox();
            this.btnItemCode = new System.Windows.Forms.Button();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLocationTo = new System.Windows.Forms.Button();
            this.txtLocationTo = new System.Windows.Forms.TextBox();
            this.btnLocationFrom = new System.Windows.Forms.Button();
            this.txtLocationFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtDateTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUnitReport = new System.Windows.Forms.Button();
            this.txtUnitReport = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFormatDesc
            // 
            this.txtFormatDesc.Location = new System.Drawing.Point(279, 13);
            this.txtFormatDesc.Name = "txtFormatDesc";
            this.txtFormatDesc.Size = new System.Drawing.Size(185, 20);
            this.txtFormatDesc.TabIndex = 7;
            // 
            // btnFormat
            // 
            this.btnFormat.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnFormat.Location = new System.Drawing.Point(249, 11);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(27, 22);
            this.btnFormat.TabIndex = 6;
            this.btnFormat.TabStop = false;
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // txtFormatCode
            // 
            this.txtFormatCode.Location = new System.Drawing.Point(120, 12);
            this.txtFormatCode.Name = "txtFormatCode";
            this.txtFormatCode.Size = new System.Drawing.Size(129, 20);
            this.txtFormatCode.TabIndex = 4;
            this.txtFormatCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFormatCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Report Format";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "From";
            // 
            // btnItemCode1
            // 
            this.btnItemCode1.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnItemCode1.Location = new System.Drawing.Point(438, 40);
            this.btnItemCode1.Name = "btnItemCode1";
            this.btnItemCode1.Size = new System.Drawing.Size(27, 22);
            this.btnItemCode1.TabIndex = 28;
            this.btnItemCode1.TabStop = false;
            this.btnItemCode1.UseVisualStyleBackColor = true;
            this.btnItemCode1.Click += new System.EventHandler(this.btnItemCode1_Click);
            // 
            // txtItemCode1
            // 
            this.txtItemCode1.Location = new System.Drawing.Point(305, 41);
            this.txtItemCode1.Name = "txtItemCode1";
            this.txtItemCode1.Size = new System.Drawing.Size(132, 20);
            this.txtItemCode1.TabIndex = 25;
            this.txtItemCode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode1_KeyDown);
            // 
            // btnItemCode
            // 
            this.btnItemCode.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnItemCode.Location = new System.Drawing.Point(249, 39);
            this.btnItemCode.Name = "btnItemCode";
            this.btnItemCode.Size = new System.Drawing.Size(27, 22);
            this.btnItemCode.TabIndex = 27;
            this.btnItemCode.TabStop = false;
            this.btnItemCode.UseVisualStyleBackColor = true;
            this.btnItemCode.Click += new System.EventHandler(this.btnItemCode_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(120, 40);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(129, 20);
            this.txtItemCode.TabIndex = 24;
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Item Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "From";
            // 
            // btnLocationTo
            // 
            this.btnLocationTo.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnLocationTo.Location = new System.Drawing.Point(438, 72);
            this.btnLocationTo.Name = "btnLocationTo";
            this.btnLocationTo.Size = new System.Drawing.Size(27, 22);
            this.btnLocationTo.TabIndex = 35;
            this.btnLocationTo.TabStop = false;
            this.btnLocationTo.UseVisualStyleBackColor = true;
            this.btnLocationTo.Click += new System.EventHandler(this.btnLocationTo_Click);
            // 
            // txtLocationTo
            // 
            this.txtLocationTo.Location = new System.Drawing.Point(305, 73);
            this.txtLocationTo.Name = "txtLocationTo";
            this.txtLocationTo.Size = new System.Drawing.Size(132, 20);
            this.txtLocationTo.TabIndex = 32;
            this.txtLocationTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocationTo_KeyDown);
            // 
            // btnLocationFrom
            // 
            this.btnLocationFrom.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnLocationFrom.Location = new System.Drawing.Point(249, 71);
            this.btnLocationFrom.Name = "btnLocationFrom";
            this.btnLocationFrom.Size = new System.Drawing.Size(27, 22);
            this.btnLocationFrom.TabIndex = 34;
            this.btnLocationFrom.TabStop = false;
            this.btnLocationFrom.UseVisualStyleBackColor = true;
            this.btnLocationFrom.Click += new System.EventHandler(this.btnLocationFrom_Click);
            // 
            // txtLocationFrom
            // 
            this.txtLocationFrom.Location = new System.Drawing.Point(120, 72);
            this.txtLocationFrom.Name = "txtLocationFrom";
            this.txtLocationFrom.Size = new System.Drawing.Size(129, 20);
            this.txtLocationFrom.TabIndex = 31;
            this.txtLocationFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocationFrom_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Date";
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFrom.Location = new System.Drawing.Point(120, 105);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(156, 20);
            this.dtDateFrom.TabIndex = 40;
            this.dtDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDateFrom_KeyDown);
            // 
            // dtDateTo
            // 
            this.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTo.Location = new System.Drawing.Point(314, 106);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Size = new System.Drawing.Size(151, 20);
            this.dtDateTo.TabIndex = 41;
            this.dtDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDateTo_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "To";
            // 
            // btnUnitReport
            // 
            this.btnUnitReport.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnUnitReport.Location = new System.Drawing.Point(249, 139);
            this.btnUnitReport.Name = "btnUnitReport";
            this.btnUnitReport.Size = new System.Drawing.Size(27, 22);
            this.btnUnitReport.TabIndex = 45;
            this.btnUnitReport.TabStop = false;
            this.btnUnitReport.UseVisualStyleBackColor = true;
            this.btnUnitReport.Click += new System.EventHandler(this.btnUnitReport_Click);
            // 
            // txtUnitReport
            // 
            this.txtUnitReport.Location = new System.Drawing.Point(120, 140);
            this.txtUnitReport.Name = "txtUnitReport";
            this.txtUnitReport.Size = new System.Drawing.Size(129, 20);
            this.txtUnitReport.TabIndex = 43;
            this.txtUnitReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitReport_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Unit Of Report";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(390, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(305, 160);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 46;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // INVENTORY_MOVEMENT_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 195);
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
            this.Name = "INVENTORY_MOVEMENT_FRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Movement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormatDesc;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.TextBox txtFormatCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnItemCode1;
        private System.Windows.Forms.TextBox txtItemCode1;
        private System.Windows.Forms.Button btnItemCode;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLocationTo;
        private System.Windows.Forms.TextBox txtLocationTo;
        private System.Windows.Forms.Button btnLocationFrom;
        private System.Windows.Forms.TextBox txtLocationFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtDateFrom;
        private System.Windows.Forms.DateTimePicker dtDateTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUnitReport;
        private System.Windows.Forms.TextBox txtUnitReport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
    }
}