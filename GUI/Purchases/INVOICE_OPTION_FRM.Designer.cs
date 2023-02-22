namespace POS.GUI.Purchases
{
    partial class INVOICE_OPTION_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVOICE_OPTION_FRM));
            this.cboVAT = new System.Windows.Forms.ComboBox();
            this.txtDisP = new System.Windows.Forms.TextBox();
            this.txtDiscountA = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.Label();
            this.txtTotalA = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboVAT
            // 
            this.cboVAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVAT.FormattingEnabled = true;
            this.cboVAT.Items.AddRange(new object[] {
            "0%",
            "10%"});
            this.cboVAT.Location = new System.Drawing.Point(117, 59);
            this.cboVAT.Name = "cboVAT";
            this.cboVAT.Size = new System.Drawing.Size(54, 21);
            this.cboVAT.TabIndex = 21;
            // 
            // txtDisP
            // 
            this.txtDisP.Location = new System.Drawing.Point(117, 34);
            this.txtDisP.MaxLength = 10;
            this.txtDisP.Name = "txtDisP";
            this.txtDisP.Size = new System.Drawing.Size(54, 20);
            this.txtDisP.TabIndex = 17;
            // 
            // txtDiscountA
            // 
            this.txtDiscountA.Location = new System.Drawing.Point(216, 34);
            this.txtDiscountA.MaxLength = 15;
            this.txtDiscountA.Name = "txtDiscountA";
            this.txtDiscountA.Size = new System.Drawing.Size(73, 20);
            this.txtDiscountA.TabIndex = 19;
            this.txtDiscountA.Tag = "Discount (USD)";
            this.txtDiscountA.Text = "0.00";
            this.txtDiscountA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrandTotal.Location = new System.Drawing.Point(117, 86);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(172, 20);
            this.txtGrandTotal.TabIndex = 15;
            this.txtGrandTotal.Text = "0.00";
            this.txtGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalA
            // 
            this.txtTotalA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalA.Location = new System.Drawing.Point(117, 8);
            this.txtTotalA.Name = "txtTotalA";
            this.txtTotalA.Size = new System.Drawing.Size(172, 20);
            this.txtTotalA.TabIndex = 13;
            this.txtTotalA.Text = "0.00";
            this.txtTotalA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Total Amount";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(3, 36);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "&Discount (%)";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(177, 64);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(36, 13);
            this.Label5.TabIndex = 22;
            this.Label5.Text = "(U&SD)";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(177, 37);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(36, 13);
            this.Label26.TabIndex = 18;
            this.Label26.Text = "(&USD)";
            // 
            // txtVAT
            // 
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVAT.Location = new System.Drawing.Point(216, 60);
            this.txtVAT.MaxLength = 25;
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(73, 20);
            this.txtVAT.TabIndex = 23;
            this.txtVAT.Tag = "Quotation Format";
            this.txtVAT.Text = "0.00";
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(3, 62);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(42, 13);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "&VAT(%)";
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(3, 90);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 13);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Grand Total";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(144, 113);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 25;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // INVOICE_OPTION_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 143);
            this.Controls.Add(this.cboVAT);
            this.Controls.Add(this.txtDisP);
            this.Controls.Add(this.txtDiscountA);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtTotalA);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "INVOICE_OPTION_FRM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Option";
            this.Load += new System.EventHandler(this.INVOICE_OPTION_FRM_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboVAT;
        internal System.Windows.Forms.TextBox txtDisP;
        internal System.Windows.Forms.TextBox txtDiscountA;
        internal System.Windows.Forms.Label txtGrandTotal;
        internal System.Windows.Forms.Label txtTotalA;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.TextBox txtVAT;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button Cancel_Button;
    }
}