namespace POS.GUI
{
    partial class LOGIN_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN_FRM));
            this.txtLocDesc = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnLocation = new System.Windows.Forms.Button();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocDesc
            // 
            this.txtLocDesc.Enabled = false;
            this.txtLocDesc.Location = new System.Drawing.Point(222, 143);
            this.txtLocDesc.MaxLength = 15;
            this.txtLocDesc.Name = "txtLocDesc";
            this.txtLocDesc.Size = new System.Drawing.Size(140, 20);
            this.txtLocDesc.TabIndex = 19;
            this.txtLocDesc.Tag = "Default Cost";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(7, 146);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Location";
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd/MMM/yyyy";
            this.dtpdate.Location = new System.Drawing.Point(102, 169);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(260, 20);
            this.dtpdate.TabIndex = 3;
            this.dtpdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpdate_KeyDown);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancel.Location = new System.Drawing.Point(278, 257);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OK.Location = new System.Drawing.Point(187, 257);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(84, 23);
            this.OK.TabIndex = 4;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(102, 117);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(260, 20);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // txtUserID
            // 
            this.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserID.Location = new System.Drawing.Point(102, 93);
            this.txtUserID.MaxLength = 15;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(260, 20);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.Tag = "User ID";
            this.txtUserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserID_KeyDown);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(7, 173);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 13);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "&Login Date";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordLabel.Location = new System.Drawing.Point(7, 120);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "&Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UsernameLabel.Location = new System.Drawing.Point(7, 96);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(43, 13);
            this.UsernameLabel.TabIndex = 12;
            this.UsernameLabel.Text = "&User ID";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label17
            // 
            this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label17.Location = new System.Drawing.Point(12, 82);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(345, 2);
            this.Label17.TabIndex = 34;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(102, 142);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(89, 20);
            this.txtLocation.TabIndex = 2;
            this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocation_KeyDown);
            // 
            // btnLocation
            // 
            this.btnLocation.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnLocation.Location = new System.Drawing.Point(191, 142);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(24, 22);
            this.btnLocation.TabIndex = 36;
            this.btnLocation.TabStop = false;
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLanguage.Location = new System.Drawing.Point(7, 198);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(55, 13);
            this.labelLanguage.TabIndex = 37;
            this.labelLanguage.Text = "&Language";
            this.labelLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(102, 195);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Khmer", "1", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("English", "0", 1)});
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(260, 26);
            this.imageComboBoxEdit1.TabIndex = 39;
            this.imageComboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit1_SelectedIndexChanged);
            // 
            // LOGIN_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 288);
            this.Controls.Add(this.imageComboBoxEdit1);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.txtLocDesc);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LOGIN_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOGIN_FRM_FormClosing);
            this.Load += new System.EventHandler(this.LOGIN_FRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtLocDesc;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtpdate;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.TextBox txtPwd;
        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox txtLocation;
        internal System.Windows.Forms.Button btnLocation;
        internal System.Windows.Forms.Label labelLanguage;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
    }
}