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
            resources.ApplyResources(this.cboVAT, "cboVAT");
            this.cboVAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVAT.FormattingEnabled = true;
            this.cboVAT.Items.AddRange(new object[] {
            resources.GetString("cboVAT.Items"),
            resources.GetString("cboVAT.Items1")});
            this.cboVAT.Name = "cboVAT";
            // 
            // txtDisP
            // 
            resources.ApplyResources(this.txtDisP, "txtDisP");
            this.txtDisP.Name = "txtDisP";
            // 
            // txtDiscountA
            // 
            resources.ApplyResources(this.txtDiscountA, "txtDiscountA");
            this.txtDiscountA.Name = "txtDiscountA";
            this.txtDiscountA.Tag = "Discount (USD)";
            // 
            // txtGrandTotal
            // 
            resources.ApplyResources(this.txtGrandTotal, "txtGrandTotal");
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrandTotal.Name = "txtGrandTotal";
            // 
            // txtTotalA
            // 
            resources.ApplyResources(this.txtTotalA, "txtTotalA");
            this.txtTotalA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalA.Name = "txtTotalA";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // Label26
            // 
            resources.ApplyResources(this.Label26, "Label26");
            this.Label26.Name = "Label26";
            // 
            // txtVAT
            // 
            resources.ApplyResources(this.txtVAT, "txtVAT");
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Tag = "Quotation Format";
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            // 
            // OK_Button
            // 
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // TableLayoutPanel1
            // 
            resources.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            // 
            // Cancel_Button
            // 
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // INVOICE_OPTION_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "INVOICE_OPTION_FRM";
            this.ShowIcon = false;
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