namespace POS.GUI.POS
{
    partial class AddcustomerPos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpCode = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtLocCode = new System.Windows.Forms.TextBox();
            this.txtLocName = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomerCode = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Code";
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Location = new System.Drawing.Point(98, 33);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Size = new System.Drawing.Size(100, 20);
            this.txtEmpCode.TabIndex = 1;
            this.txtEmpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpCode_KeyDown);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(226, 33);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(125, 20);
            this.txtEmpName.TabIndex = 5;
            // 
            // txtLocCode
            // 
            this.txtLocCode.Location = new System.Drawing.Point(98, 7);
            this.txtLocCode.Name = "txtLocCode";
            this.txtLocCode.Size = new System.Drawing.Size(100, 20);
            this.txtLocCode.TabIndex = 0;
            this.txtLocCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocCode_KeyDown);
            // 
            // txtLocName
            // 
            this.txtLocName.Location = new System.Drawing.Point(226, 6);
            this.txtLocName.Name = "txtLocName";
            this.txtLocName.Size = new System.Drawing.Size(125, 20);
            this.txtLocName.TabIndex = 7;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(98, 62);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerCode.TabIndex = 2;
            this.txtCustomerCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserCode_KeyDown);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(226, 62);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(125, 20);
            this.txtCustomerName.TabIndex = 9;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnEmployee.Location = new System.Drawing.Point(198, 33);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(25, 21);
            this.btnEmployee.TabIndex = 10;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerCode
            // 
            this.btnCustomerCode.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnCustomerCode.Location = new System.Drawing.Point(198, 61);
            this.btnCustomerCode.Name = "btnCustomerCode";
            this.btnCustomerCode.Size = new System.Drawing.Size(25, 21);
            this.btnCustomerCode.TabIndex = 11;
            this.btnCustomerCode.UseVisualStyleBackColor = true;
            this.btnCustomerCode.Click += new System.EventHandler(this.btnUsercode_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnLocation.Location = new System.Drawing.Point(198, 7);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(25, 21);
            this.btnLocation.TabIndex = 12;
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 122);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "&Ok\r\n";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "User code";
            // 
            // btnUser
            // 
            this.btnUser.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnUser.Location = new System.Drawing.Point(198, 87);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(25, 21);
            this.btnUser.TabIndex = 18;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(226, 88);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(125, 20);
            this.txtUserName.TabIndex = 17;
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(98, 87);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(100, 20);
            this.txtUserCode.TabIndex = 16;
            this.txtUserCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserCode_KeyDown_1);
            // 
            // AddcustomerPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 149);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnCustomerCode);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.txtLocName);
            this.Controls.Add(this.txtLocCode);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddcustomerPos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer In POS";
            this.Load += new System.EventHandler(this.AddcustomerPos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtEmpCode;
        internal System.Windows.Forms.TextBox txtEmpName;
        internal System.Windows.Forms.TextBox txtLocCode;
        internal System.Windows.Forms.TextBox txtLocName;
        internal System.Windows.Forms.TextBox txtCustomerCode;
        internal System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.Button btnEmployee;
        internal System.Windows.Forms.Button btnCustomerCode;
        internal System.Windows.Forms.Button btnLocation;
        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnUser;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.TextBox txtUserCode;

    }
}