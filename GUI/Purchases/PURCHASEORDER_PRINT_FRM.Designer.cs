namespace POS.GUI.Purchases
{
    partial class PurchaseorderPrintFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseorderPrintFrm));
            this.OK_Button = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cboIn_item = new System.Windows.Forms.ComboBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.btnRef1 = new System.Windows.Forms.Button();
            this.txtRef1 = new System.Windows.Forms.TextBox();
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnF1 = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // cboIn_item
            // 
            this.cboIn_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIn_item.FormattingEnabled = true;
            this.cboIn_item.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboIn_item.Location = new System.Drawing.Point(122, 88);
            this.cboIn_item.Name = "cboIn_item";
            this.cboIn_item.Size = new System.Drawing.Size(145, 21);
            this.cboIn_item.TabIndex = 18;
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
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // btnRef1
            // 
            this.btnRef1.ImageKey = "(none)";
            this.btnRef1.ImageList = this.ImageList1;
            this.btnRef1.Location = new System.Drawing.Point(244, 55);
            this.btnRef1.Name = "btnRef1";
            this.HelpProvider1.SetShowHelp(this.btnRef1, true);
            this.btnRef1.Size = new System.Drawing.Size(24, 20);
            this.btnRef1.TabIndex = 16;
            this.btnRef1.Text = "...";
            this.btnRef1.UseVisualStyleBackColor = true;
            // 
            // txtRef1
            // 
            this.txtRef1.Location = new System.Drawing.Point(122, 55);
            this.txtRef1.MaxLength = 10;
            this.txtRef1.Name = "txtRef1";
            this.txtRef1.Size = new System.Drawing.Size(123, 20);
            this.txtRef1.TabIndex = 15;
            this.txtRef1.Tag = "Sale Order Number: From";
            // 
            // txtDesc1
            // 
            this.txtDesc1.Enabled = false;
            this.txtDesc1.Location = new System.Drawing.Point(273, 17);
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.Size = new System.Drawing.Size(207, 20);
            this.txtDesc1.TabIndex = 13;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(15, 91);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 13);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Show Details";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(15, 58);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(101, 13);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Purchase Order Ref";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Report Format";
            // 
            // txtF1
            // 
            this.txtF1.Location = new System.Drawing.Point(122, 17);
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
            this.TableLayoutPanel1.Location = new System.Drawing.Point(315, 105);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(167, 29);
            this.TableLayoutPanel1.TabIndex = 19;
            // 
            // btnF1
            // 
            this.btnF1.ImageIndex = 0;
            this.btnF1.ImageList = this.ImageList1;
            this.btnF1.Location = new System.Drawing.Point(243, 17);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(24, 20);
            this.btnF1.TabIndex = 12;
            this.btnF1.TabStop = false;
            this.btnF1.UseVisualStyleBackColor = true;
            // 
            // PurchaseorderPrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 138);
            this.Controls.Add(this.cboIn_item);
            this.Controls.Add(this.btnRef1);
            this.Controls.Add(this.txtRef1);
            this.Controls.Add(this.txtDesc1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnF1);
            this.Controls.Add(this.txtF1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "PurchaseorderPrintFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query Purchase Order";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ComboBox cboIn_item;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Button btnRef1;
        internal System.Windows.Forms.HelpProvider HelpProvider1;
        internal System.Windows.Forms.TextBox txtRef1;
        internal System.Windows.Forms.TextBox txtDesc1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnF1;
        internal System.Windows.Forms.TextBox txtF1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
    }
}