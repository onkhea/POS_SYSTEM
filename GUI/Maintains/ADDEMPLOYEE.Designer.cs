namespace POS.GUI.Maintains
{
    partial class ADDEMPLOYEE
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
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtEmp_tel = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.cboEmp_Status = new System.Windows.Forms.ComboBox();
            this.txtEmp_Code = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtEmp_Name = new System.Windows.Forms.TextBox();
            this.txtEmp_add = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(5, 174);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(168, 13);
            this.Label18.TabIndex = 5;
            this.Label18.Text = "Please completed your information";
            // 
            // Label17
            // 
            this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label17.Location = new System.Drawing.Point(177, 185);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(341, 2);
            this.Label17.TabIndex = 6;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtEmp_tel);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.cboEmp_Status);
            this.GroupBox1.Controls.Add(this.txtEmp_Code);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtEmp_Name);
            this.GroupBox1.Controls.Add(this.txtEmp_add);
            this.GroupBox1.Location = new System.Drawing.Point(8, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(501, 157);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Personal Information";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Employee &Code";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Tag = "";
            this.Label2.Text = "Employee &Name";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(24, 92);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Address";
            // 
            // txtEmp_tel
            // 
            this.txtEmp_tel.Location = new System.Drawing.Point(109, 119);
            this.txtEmp_tel.MaxLength = 15;
            this.txtEmp_tel.Name = "txtEmp_tel";
            this.txtEmp_tel.Size = new System.Drawing.Size(363, 20);
            this.txtEmp_tel.TabIndex = 17;
            this.txtEmp_tel.Tag = "Telephone";
            this.txtEmp_tel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmp_tel_KeyDown);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(283, 35);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(37, 13);
            this.Label14.TabIndex = 2;
            this.Label14.Text = "&Status";
            // 
            // cboEmp_Status
            // 
            this.cboEmp_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmp_Status.FormattingEnabled = true;
            this.cboEmp_Status.Items.AddRange(new object[] {
            "A - Active",
            "D - Disable"});
            this.cboEmp_Status.Location = new System.Drawing.Point(326, 31);
            this.cboEmp_Status.Name = "cboEmp_Status";
            this.cboEmp_Status.Size = new System.Drawing.Size(146, 21);
            this.cboEmp_Status.TabIndex = 3;
            this.cboEmp_Status.Tag = "Status";
            this.cboEmp_Status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboEmp_Status_KeyDown);
            // 
            // txtEmp_Code
            // 
            this.txtEmp_Code.Location = new System.Drawing.Point(109, 31);
            this.txtEmp_Code.MaxLength = 15;
            this.txtEmp_Code.Name = "txtEmp_Code";
            this.txtEmp_Code.Size = new System.Drawing.Size(168, 20);
            this.txtEmp_Code.TabIndex = 1;
            this.txtEmp_Code.Tag = "Customer Code";
            this.txtEmp_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmp_Code_KeyDown);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(24, 119);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 13);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "&Telephone";
            // 
            // txtEmp_Name
            // 
            this.txtEmp_Name.Location = new System.Drawing.Point(108, 60);
            this.txtEmp_Name.MaxLength = 20;
            this.txtEmp_Name.Name = "txtEmp_Name";
            this.txtEmp_Name.Size = new System.Drawing.Size(363, 20);
            this.txtEmp_Name.TabIndex = 5;
            this.txtEmp_Name.Tag = "Customer Name";
            this.txtEmp_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmp_Name_KeyDown);
            // 
            // txtEmp_add
            // 
            this.txtEmp_add.Location = new System.Drawing.Point(109, 89);
            this.txtEmp_add.MaxLength = 120;
            this.txtEmp_add.Name = "txtEmp_add";
            this.txtEmp_add.Size = new System.Drawing.Size(363, 20);
            this.txtEmp_add.TabIndex = 7;
            this.txtEmp_add.Tag = "Address Line1";
            this.txtEmp_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmp_add_KeyDown);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(350, 194);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(163, 29);
            this.TableLayoutPanel1.TabIndex = 7;
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
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(74, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
            // 
            // ADDEMPLOYEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 228);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDEMPLOYEE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD EMPLOYEE";
            this.Load += new System.EventHandler(this.ADDEMPLOYEE_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtEmp_tel;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.ComboBox cboEmp_Status;
        internal System.Windows.Forms.TextBox txtEmp_Code;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtEmp_Name;
        internal System.Windows.Forms.TextBox txtEmp_add;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Button OK_Button;
    }
}