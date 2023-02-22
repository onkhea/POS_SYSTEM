namespace POS.Reports.Movement_Listing
{
    partial class INVENTORY_LISTING
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
            this.Label11 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtMrefF = new System.Windows.Forms.TextBox();
            this.txtMrefT = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbo_GroupBy = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_LocF = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txt_Item_codeT = new System.Windows.Forms.TextBox();
            this.txt_Item_codeF = new System.Windows.Forms.TextBox();
            this.txt_LocT = new System.Windows.Forms.TextBox();
            this.btn_locT = new System.Windows.Forms.Button();
            this.btn_locF = new System.Windows.Forms.Button();
            this.btn_Item_codeT = new System.Windows.Forms.Button();
            this.btn_Item_codeF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(86, 124);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(30, 13);
            this.Label11.TabIndex = 51;
            this.Label11.Text = "From";
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Location = new System.Drawing.Point(285, 148);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(78, 24);
            this.btnPreview.TabIndex = 29;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(6, 124);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(77, 13);
            this.Label12.TabIndex = 50;
            this.Label12.Text = "Movement Ref";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(273, 123);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(20, 13);
            this.Label13.TabIndex = 53;
            this.Label13.Text = "To";
            // 
            // txtMrefF
            // 
            this.txtMrefF.Location = new System.Drawing.Point(124, 120);
            this.txtMrefF.MaxLength = 15;
            this.txtMrefF.Name = "txtMrefF";
            this.txtMrefF.Size = new System.Drawing.Size(143, 20);
            this.txtMrefF.TabIndex = 52;
            this.txtMrefF.Tag = "Transaction Reference: From";
            this.txtMrefF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMrefF_KeyDown);
            // 
            // txtMrefT
            // 
            this.txtMrefT.Location = new System.Drawing.Point(306, 120);
            this.txtMrefT.MaxLength = 15;
            this.txtMrefT.Name = "txtMrefT";
            this.txtMrefT.Size = new System.Drawing.Size(143, 20);
            this.txtMrefT.TabIndex = 54;
            this.txtMrefT.Tag = "Transaction Reference: To";
            this.txtMrefT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMrefT_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(369, 148);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 24);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(86, 68);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(30, 13);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "From";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(86, 40);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(30, 13);
            this.Label3.TabIndex = 32;
            this.Label3.Text = "From";
            // 
            // cbo_GroupBy
            // 
            this.cbo_GroupBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_GroupBy.FormattingEnabled = true;
            this.cbo_GroupBy.Items.AddRange(new object[] {
            "Item Code",
            "Location Code"});
            this.cbo_GroupBy.Location = new System.Drawing.Point(124, 9);
            this.cbo_GroupBy.Name = "cbo_GroupBy";
            this.cbo_GroupBy.Size = new System.Drawing.Size(143, 21);
            this.cbo_GroupBy.TabIndex = 28;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(6, 12);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(51, 13);
            this.Label10.TabIndex = 27;
            this.Label10.Tag = "";
            this.Label10.Text = "&Group By";
            // 
            // dtTo
            // 
            this.dtTo.Checked = false;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(306, 90);
            this.dtTo.Name = "dtTo";
            this.dtTo.ShowCheckBox = true;
            this.dtTo.Size = new System.Drawing.Size(143, 20);
            this.dtTo.TabIndex = 49;
            this.dtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtTo_KeyDown);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = false;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(124, 90);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowCheckBox = true;
            this.dtpFrom.Size = new System.Drawing.Size(143, 20);
            this.dtpFrom.TabIndex = 47;
            this.dtpFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFrom_KeyDown);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 93);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(30, 13);
            this.Label7.TabIndex = 45;
            this.Label7.Text = "Date";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 68);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(76, 13);
            this.Label5.TabIndex = 38;
            this.Label5.Text = "Location Code";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(273, 93);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(20, 13);
            this.Label9.TabIndex = 48;
            this.Label9.Text = "To";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(273, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(20, 13);
            this.Label2.TabIndex = 42;
            this.Label2.Text = "To";
            // 
            // txt_LocF
            // 
            this.txt_LocF.Location = new System.Drawing.Point(124, 64);
            this.txt_LocF.MaxLength = 10;
            this.txt_LocF.Name = "txt_LocF";
            this.txt_LocF.Size = new System.Drawing.Size(120, 20);
            this.txt_LocF.TabIndex = 40;
            this.txt_LocF.Tag = "Transaction Reference: From";
            this.txt_LocF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_LocF_KeyDown);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(86, 94);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(30, 13);
            this.Label8.TabIndex = 46;
            this.Label8.Text = "From";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(273, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(20, 13);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "To";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 40);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(54, 13);
            this.Label6.TabIndex = 31;
            this.Label6.Text = "Item code";
            // 
            // txt_Item_codeT
            // 
            this.txt_Item_codeT.Location = new System.Drawing.Point(306, 36);
            this.txt_Item_codeT.MaxLength = 50;
            this.txt_Item_codeT.Name = "txt_Item_codeT";
            this.txt_Item_codeT.Size = new System.Drawing.Size(120, 20);
            this.txt_Item_codeT.TabIndex = 36;
            this.txt_Item_codeT.Tag = "Account Link";
            this.txt_Item_codeT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Item_codeT_KeyDown);
            // 
            // txt_Item_codeF
            // 
            this.txt_Item_codeF.Location = new System.Drawing.Point(124, 36);
            this.txt_Item_codeF.MaxLength = 50;
            this.txt_Item_codeF.Name = "txt_Item_codeF";
            this.txt_Item_codeF.Size = new System.Drawing.Size(120, 20);
            this.txt_Item_codeF.TabIndex = 33;
            this.txt_Item_codeF.Tag = "Account Link";
            this.txt_Item_codeF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Item_codeF_KeyDown);
            // 
            // txt_LocT
            // 
            this.txt_LocT.Location = new System.Drawing.Point(306, 64);
            this.txt_LocT.MaxLength = 10;
            this.txt_LocT.Name = "txt_LocT";
            this.txt_LocT.Size = new System.Drawing.Size(143, 20);
            this.txt_LocT.TabIndex = 43;
            this.txt_LocT.Tag = "Transaction Reference: To";
            this.txt_LocT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_LocT_KeyDown);
            // 
            // btn_locT
            // 
            this.btn_locT.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btn_locT.Location = new System.Drawing.Point(425, 64);
            this.btn_locT.Name = "btn_locT";
            this.btn_locT.Size = new System.Drawing.Size(24, 20);
            this.btn_locT.TabIndex = 44;
            this.btn_locT.TabStop = false;
            this.btn_locT.UseVisualStyleBackColor = true;
            this.btn_locT.Click += new System.EventHandler(this.btn_locT_Click);
            // 
            // btn_locF
            // 
            this.btn_locF.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btn_locF.Location = new System.Drawing.Point(243, 64);
            this.btn_locF.Name = "btn_locF";
            this.btn_locF.Size = new System.Drawing.Size(24, 20);
            this.btn_locF.TabIndex = 41;
            this.btn_locF.TabStop = false;
            this.btn_locF.UseVisualStyleBackColor = true;
            this.btn_locF.Click += new System.EventHandler(this.btn_locF_Click);
            // 
            // btn_Item_codeT
            // 
            this.btn_Item_codeT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Item_codeT.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btn_Item_codeT.Location = new System.Drawing.Point(425, 36);
            this.btn_Item_codeT.Name = "btn_Item_codeT";
            this.btn_Item_codeT.Size = new System.Drawing.Size(24, 20);
            this.btn_Item_codeT.TabIndex = 37;
            this.btn_Item_codeT.TabStop = false;
            this.btn_Item_codeT.UseVisualStyleBackColor = true;
            this.btn_Item_codeT.Click += new System.EventHandler(this.btn_Item_codeT_Click);
            // 
            // btn_Item_codeF
            // 
            this.btn_Item_codeF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Item_codeF.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btn_Item_codeF.Location = new System.Drawing.Point(243, 36);
            this.btn_Item_codeF.Name = "btn_Item_codeF";
            this.btn_Item_codeF.Size = new System.Drawing.Size(24, 20);
            this.btn_Item_codeF.TabIndex = 34;
            this.btn_Item_codeF.TabStop = false;
            this.btn_Item_codeF.UseVisualStyleBackColor = true;
            this.btn_Item_codeF.Click += new System.EventHandler(this.btn_Item_codeF_Click);
            // 
            // INVENTORY_LISTING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 176);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtMrefF);
            this.Controls.Add(this.txtMrefT);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btn_locT);
            this.Controls.Add(this.btn_locF);
            this.Controls.Add(this.cbo_GroupBy);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btn_Item_codeT);
            this.Controls.Add(this.txt_LocF);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.btn_Item_codeF);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txt_Item_codeT);
            this.Controls.Add(this.txt_Item_codeF);
            this.Controls.Add(this.txt_LocT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "INVENTORY_LISTING";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Listing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label11;
        protected System.Windows.Forms.Button btnPreview;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtMrefF;
        internal System.Windows.Forms.TextBox txtMrefT;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btn_locT;
        internal System.Windows.Forms.Button btn_locF;
        internal System.Windows.Forms.ComboBox cbo_GroupBy;
        protected System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.DateTimePicker dtTo;
        internal System.Windows.Forms.DateTimePicker dtpFrom;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btn_Item_codeT;
        internal System.Windows.Forms.TextBox txt_LocF;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btn_Item_codeF;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txt_Item_codeT;
        internal System.Windows.Forms.TextBox txt_Item_codeF;
        internal System.Windows.Forms.TextBox txt_LocT;
    }
}