namespace POS.Reports
{
    partial class AddreportsFrm
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.chbInactive = new System.Windows.Forms.CheckBox();
            this.lblRepCode = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblRep_Type = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Customer Listing",
            "Inventory Listing Items",
            "Inventory Listing Location",
            "Inventory Movement",
            "Inventory Movement Amount",
            "Inventory Transfer",
            "Movement Listing",
            "POS Print",
            "Print Barcode",
            "Print Credit Note Form",
            "Print Debit Note Form",
            "Print Invoice Form",
            "Print Purchase Form",
            "Print Sale Form",
            "Purchase Listing",
            "Sale Listing",
            "Supplier Listing"});
            this.cboType.Location = new System.Drawing.Point(107, 78);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(274, 21);
            this.cboType.Sorted = true;
            this.cboType.TabIndex = 2;
            this.cboType.Tag = "Report Type";
            this.cboType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboType_KeyDown);
            // 
            // chbInactive
            // 
            this.chbInactive.AutoSize = true;
            this.chbInactive.Location = new System.Drawing.Point(107, 110);
            this.chbInactive.Name = "chbInactive";
            this.chbInactive.Size = new System.Drawing.Size(110, 17);
            this.chbInactive.TabIndex = 14;
            this.chbInactive.Text = "Report is disabled";
            this.chbInactive.UseVisualStyleBackColor = true;
            this.chbInactive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbInactive_KeyDown);
            // 
            // lblRepCode
            // 
            this.lblRepCode.AutoSize = true;
            this.lblRepCode.Location = new System.Drawing.Point(10, 15);
            this.lblRepCode.Name = "lblRepCode";
            this.lblRepCode.Size = new System.Drawing.Size(67, 13);
            this.lblRepCode.TabIndex = 8;
            this.lblRepCode.Text = "Report &Code";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(221, 129);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(163, 29);
            this.TableLayoutPanel1.TabIndex = 15;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(74, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "&OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(85, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(74, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(107, 45);
            this.txtDes.MaxLength = 30;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(274, 20);
            this.txtDes.TabIndex = 1;
            this.txtDes.Tag = "Description";
            this.txtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDes_KeyDown);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(107, 12);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(274, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.Tag = "Report Code";
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblRep_Type
            // 
            this.lblRep_Type.AutoSize = true;
            this.lblRep_Type.Location = new System.Drawing.Point(10, 81);
            this.lblRep_Type.Name = "lblRep_Type";
            this.lblRep_Type.Size = new System.Drawing.Size(66, 13);
            this.lblRep_Type.TabIndex = 12;
            this.lblRep_Type.Text = "Report &Type";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 49);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "&Description";
            // 
            // AddreportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 165);
            this.ControlBox = false;
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.chbInactive);
            this.Controls.Add(this.lblRepCode);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblRep_Type);
            this.Controls.Add(this.Label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddreportsFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Report";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboType;
        internal System.Windows.Forms.CheckBox chbInactive;
        internal System.Windows.Forms.Label lblRepCode;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.TextBox txtDes;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.Label lblRep_Type;
        internal System.Windows.Forms.Label Label3;
    }
}