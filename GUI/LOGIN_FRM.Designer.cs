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
            this.labelLanguage = new System.Windows.Forms.Label();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btnLocation = new System.Windows.Forms.Button();
            this.checkRememberMe = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRememberMe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocDesc
            // 
            resources.ApplyResources(this.txtLocDesc, "txtLocDesc");
            this.txtLocDesc.Name = "txtLocDesc";
            this.txtLocDesc.Tag = "Default Cost";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // dtpdate
            // 
            resources.ApplyResources(this.dtpdate, "dtpdate");
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpdate_KeyDown);
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Name = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            resources.ApplyResources(this.OK, "OK");
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.Name = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // txtPwd
            // 
            resources.ApplyResources(this.txtPwd, "txtPwd");
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // txtUserID
            // 
            resources.ApplyResources(this.txtUserID, "txtUserID");
            this.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Tag = "User ID";
            this.txtUserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserID_KeyDown);
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // UsernameLabel
            // 
            resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Name = "UsernameLabel";
            // 
            // Label17
            // 
            resources.ApplyResources(this.Label17, "Label17");
            this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label17.Name = "Label17";
            // 
            // txtLocation
            // 
            resources.ApplyResources(this.txtLocation, "txtLocation");
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocation_KeyDown);
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            // 
            // imageComboBoxEdit1
            // 
            resources.ApplyResources(this.imageComboBoxEdit1, "imageComboBoxEdit1");
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("imageComboBoxEdit1.Properties.Buttons"))))});
            this.imageComboBoxEdit1.Properties.GlyphAlignment = ((DevExpress.Utils.HorzAlignment)(resources.GetObject("imageComboBoxEdit1.Properties.GlyphAlignment")));
            this.imageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items"), resources.GetString("imageComboBoxEdit1.Properties.Items1"), ((int)(resources.GetObject("imageComboBoxEdit1.Properties.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items3"), resources.GetString("imageComboBoxEdit1.Properties.Items4"), ((int)(resources.GetObject("imageComboBoxEdit1.Properties.Items5"))))});
            this.imageComboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit1_SelectedIndexChanged);
            // 
            // btnLocation
            // 
            resources.ApplyResources(this.btnLocation, "btnLocation");
            this.btnLocation.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.TabStop = false;
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // checkRememberMe
            // 
            resources.ApplyResources(this.checkRememberMe, "checkRememberMe");
            this.checkRememberMe.EnterMoveNextControl = true;
            this.checkRememberMe.Name = "checkRememberMe";
            this.checkRememberMe.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("checkRememberMe.Properties.Appearance.Font")));
            this.checkRememberMe.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.checkRememberMe.Properties.Appearance.Options.UseFont = true;
            this.checkRememberMe.Properties.Appearance.Options.UseForeColor = true;
            this.checkRememberMe.Properties.Caption = resources.GetString("checkRememberMe.Properties.Caption");
            this.checkRememberMe.Properties.DisplayValueChecked = resources.GetString("checkRememberMe.Properties.DisplayValueChecked");
            this.checkRememberMe.Properties.DisplayValueGrayed = resources.GetString("checkRememberMe.Properties.DisplayValueGrayed");
            this.checkRememberMe.Properties.DisplayValueUnchecked = resources.GetString("checkRememberMe.Properties.DisplayValueUnchecked");
            this.checkRememberMe.Properties.GlyphAlignment = ((DevExpress.Utils.HorzAlignment)(resources.GetObject("checkRememberMe.Properties.GlyphAlignment")));
            this.checkRememberMe.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("checkRememberMe.Properties.GlyphVerticalAlignment")));
            // 
            // LOGIN_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkRememberMe);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LOGIN_FRM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOGIN_FRM_FormClosing);
            this.Load += new System.EventHandler(this.LOGIN_FRM_Load);
            this.Shown += new System.EventHandler(this.LOGIN_FRM_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRememberMe.Properties)).EndInit();
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
        private DevExpress.XtraEditors.CheckEdit checkRememberMe;
    }
}