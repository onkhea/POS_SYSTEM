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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVENTORY_LISTING));
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
            resources.ApplyResources(this.Label11, "Label11");
            this.Label11.Name = "Label11";
            // 
            // btnPreview
            // 
            resources.ApplyResources(this.btnPreview, "btnPreview");
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Label12
            // 
            resources.ApplyResources(this.Label12, "Label12");
            this.Label12.Name = "Label12";
            // 
            // Label13
            // 
            resources.ApplyResources(this.Label13, "Label13");
            this.Label13.Name = "Label13";
            // 
            // txtMrefF
            // 
            resources.ApplyResources(this.txtMrefF, "txtMrefF");
            this.txtMrefF.Name = "txtMrefF";
            this.txtMrefF.Tag = "Transaction Reference: From";
            this.txtMrefF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMrefF_KeyDown);
            // 
            // txtMrefT
            // 
            resources.ApplyResources(this.txtMrefT, "txtMrefT");
            this.txtMrefT.Name = "txtMrefT";
            this.txtMrefT.Tag = "Transaction Reference: To";
            this.txtMrefT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMrefT_KeyDown);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // cbo_GroupBy
            // 
            resources.ApplyResources(this.cbo_GroupBy, "cbo_GroupBy");
            this.cbo_GroupBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_GroupBy.FormattingEnabled = true;
            this.cbo_GroupBy.Items.AddRange(new object[] {
            resources.GetString("cbo_GroupBy.Items"),
            resources.GetString("cbo_GroupBy.Items1")});
            this.cbo_GroupBy.Name = "cbo_GroupBy";
            // 
            // Label10
            // 
            resources.ApplyResources(this.Label10, "Label10");
            this.Label10.Name = "Label10";
            this.Label10.Tag = "";
            // 
            // dtTo
            // 
            resources.ApplyResources(this.dtTo, "dtTo");
            this.dtTo.Checked = false;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Name = "dtTo";
            this.dtTo.ShowCheckBox = true;
            this.dtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtTo_KeyDown);
            // 
            // dtpFrom
            // 
            resources.ApplyResources(this.dtpFrom, "dtpFrom");
            this.dtpFrom.Checked = false;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowCheckBox = true;
            this.dtpFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFrom_KeyDown);
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.Name = "Label7";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // Label9
            // 
            resources.ApplyResources(this.Label9, "Label9");
            this.Label9.Name = "Label9";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // txt_LocF
            // 
            resources.ApplyResources(this.txt_LocF, "txt_LocF");
            this.txt_LocF.Name = "txt_LocF";
            this.txt_LocF.Tag = "Transaction Reference: From";
            this.txt_LocF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_LocF_KeyDown);
            // 
            // Label8
            // 
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.Name = "Label8";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // Label6
            // 
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.Name = "Label6";
            // 
            // txt_Item_codeT
            // 
            resources.ApplyResources(this.txt_Item_codeT, "txt_Item_codeT");
            this.txt_Item_codeT.Name = "txt_Item_codeT";
            this.txt_Item_codeT.Tag = "Account Link";
            this.txt_Item_codeT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Item_codeT_KeyDown);
            // 
            // txt_Item_codeF
            // 
            resources.ApplyResources(this.txt_Item_codeF, "txt_Item_codeF");
            this.txt_Item_codeF.Name = "txt_Item_codeF";
            this.txt_Item_codeF.Tag = "Account Link";
            this.txt_Item_codeF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Item_codeF_KeyDown);
            // 
            // txt_LocT
            // 
            resources.ApplyResources(this.txt_LocT, "txt_LocT");
            this.txt_LocT.Name = "txt_LocT";
            this.txt_LocT.Tag = "Transaction Reference: To";
            this.txt_LocT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_LocT_KeyDown);
            // 
            // btn_locT
            // 
            resources.ApplyResources(this.btn_locT, "btn_locT");
            this.btn_locT.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btn_locT.Name = "btn_locT";
            this.btn_locT.TabStop = false;
            this.btn_locT.UseVisualStyleBackColor = true;
            this.btn_locT.Click += new System.EventHandler(this.btn_locT_Click);
            // 
            // btn_locF
            // 
            resources.ApplyResources(this.btn_locF, "btn_locF");
            this.btn_locF.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btn_locF.Name = "btn_locF";
            this.btn_locF.TabStop = false;
            this.btn_locF.UseVisualStyleBackColor = true;
            this.btn_locF.Click += new System.EventHandler(this.btn_locF_Click);
            // 
            // btn_Item_codeT
            // 
            resources.ApplyResources(this.btn_Item_codeT, "btn_Item_codeT");
            this.btn_Item_codeT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Item_codeT.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btn_Item_codeT.Name = "btn_Item_codeT";
            this.btn_Item_codeT.TabStop = false;
            this.btn_Item_codeT.UseVisualStyleBackColor = true;
            this.btn_Item_codeT.Click += new System.EventHandler(this.btn_Item_codeT_Click);
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
            // INVENTORY_LISTING
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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