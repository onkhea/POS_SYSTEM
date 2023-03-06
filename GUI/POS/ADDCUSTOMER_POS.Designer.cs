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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddcustomerPos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpCode = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtLocCode = new System.Windows.Forms.TextBox();
            this.txtLocName = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnCustomerCode = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtEmpCode
            // 
            resources.ApplyResources(this.txtEmpCode, "txtEmpCode");
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpCode_KeyDown);
            // 
            // txtEmpName
            // 
            resources.ApplyResources(this.txtEmpName, "txtEmpName");
            this.txtEmpName.Name = "txtEmpName";
            // 
            // txtLocCode
            // 
            resources.ApplyResources(this.txtLocCode, "txtLocCode");
            this.txtLocCode.Name = "txtLocCode";
            this.txtLocCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocCode_KeyDown);
            // 
            // txtLocName
            // 
            resources.ApplyResources(this.txtLocName, "txtLocName");
            this.txtLocName.Name = "txtLocName";
            // 
            // txtCustomerCode
            // 
            resources.ApplyResources(this.txtCustomerCode, "txtCustomerCode");
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserCode_KeyDown);
            // 
            // txtCustomerName
            // 
            resources.ApplyResources(this.txtCustomerName, "txtCustomerName");
            this.txtCustomerName.Name = "txtCustomerName";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            // 
            // txtUserCode
            // 
            resources.ApplyResources(this.txtUserCode, "txtUserCode");
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserCode_KeyDown_1);
            // 
            // btnUser
            // 
            resources.ApplyResources(this.btnUser, "btnUser");
            this.btnUser.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnUser.Name = "btnUser";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLocation
            // 
            resources.ApplyResources(this.btnLocation, "btnLocation");
            this.btnLocation.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnCustomerCode
            // 
            resources.ApplyResources(this.btnCustomerCode, "btnCustomerCode");
            this.btnCustomerCode.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnCustomerCode.Name = "btnCustomerCode";
            this.btnCustomerCode.UseVisualStyleBackColor = true;
            this.btnCustomerCode.Click += new System.EventHandler(this.btnUsercode_Click);
            // 
            // btnEmployee
            // 
            resources.ApplyResources(this.btnEmployee, "btnEmployee");
            this.btnEmployee.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // AddcustomerPos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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