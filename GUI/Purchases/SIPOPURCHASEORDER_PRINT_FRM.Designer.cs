namespace POS.GUI.Purchases
{
    partial class SIPOPURCHASEORDER_PRINT_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIPOPURCHASEORDER_PRINT_FRM));
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnF1 = new System.Windows.Forms.Button();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.btnRef1 = new System.Windows.Forms.Button();
            this.txtRef1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesc1
            // 
            this.txtDesc1.Enabled = false;
            this.txtDesc1.Location = new System.Drawing.Point(262, 7);
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.Size = new System.Drawing.Size(207, 20);
            this.txtDesc1.TabIndex = 13;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Report Format";
            // 
            // btnF1
            // 
            this.btnF1.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnF1.Location = new System.Drawing.Point(232, 7);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(24, 20);
            this.btnF1.TabIndex = 12;
            this.btnF1.TabStop = false;
            this.btnF1.UseVisualStyleBackColor = true;
            this.btnF1.Click += new System.EventHandler(this.btnF1_Click);
            // 
            // txtF1
            // 
            this.txtF1.Location = new System.Drawing.Point(111, 7);
            this.txtF1.MaxLength = 10;
            this.txtF1.Name = "txtF1";
            this.txtF1.Size = new System.Drawing.Size(123, 20);
            this.txtF1.TabIndex = 11;
            this.txtF1.Tag = "Report Format";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(302, 60);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(167, 29);
            this.TableLayoutPanel1.TabIndex = 19;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(5, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(73, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(88, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(73, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            // 
            // btnRef1
            // 
            this.btnRef1.ImageKey = "(none)";
            this.btnRef1.Location = new System.Drawing.Point(233, 33);
            this.btnRef1.Name = "btnRef1";
            this.btnRef1.Size = new System.Drawing.Size(24, 20);
            this.btnRef1.TabIndex = 22;
            this.btnRef1.Text = "...";
            this.btnRef1.UseVisualStyleBackColor = true;
            // 
            // txtRef1
            // 
            this.txtRef1.Location = new System.Drawing.Point(111, 33);
            this.txtRef1.MaxLength = 10;
            this.txtRef1.Name = "txtRef1";
            this.txtRef1.Size = new System.Drawing.Size(123, 20);
            this.txtRef1.TabIndex = 21;
            this.txtRef1.Tag = "Sale Order Number: From";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(4, 36);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(101, 13);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Purchase Order Ref";
            // 
            // SIPOPURCHASEORDER_PRINT_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 101);
            this.Controls.Add(this.btnRef1);
            this.Controls.Add(this.txtRef1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtDesc1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnF1);
            this.Controls.Add(this.txtF1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SIPOPURCHASEORDER_PRINT_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printing Purchase Order";
            this.Load += new System.EventHandler(this.SIPOPURCHASEORDER_PRINT_FRM_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtDesc1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnF1;
        internal System.Windows.Forms.TextBox txtF1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Button btnRef1;
        internal System.Windows.Forms.TextBox txtRef1;
        internal System.Windows.Forms.Label Label5;
    }
}