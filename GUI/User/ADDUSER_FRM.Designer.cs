namespace POS.GUI.User
{
    partial class ADDUSER_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDUSER_FRM));
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label21 = new System.Windows.Forms.Label();
            this.chbDisable = new System.Windows.Forms.CheckBox();
            this.chbChange = new System.Windows.Forms.CheckBox();
            this.chbLog = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.Label21);
            this.Panel3.Controls.Add(this.chbDisable);
            this.Panel3.Controls.Add(this.chbChange);
            this.Panel3.Controls.Add(this.chbLog);
            this.Panel3.Location = new System.Drawing.Point(2, 187);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(414, 92);
            this.Panel3.TabIndex = 7;
            // 
            // Label21
            // 
            this.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label21.Location = new System.Drawing.Point(13, 2);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(393, 2);
            this.Label21.TabIndex = 31;
            // 
            // chbDisable
            // 
            this.chbDisable.AutoSize = true;
            this.chbDisable.Location = new System.Drawing.Point(12, 60);
            this.chbDisable.Name = "chbDisable";
            this.chbDisable.Size = new System.Drawing.Size(100, 17);
            this.chbDisable.TabIndex = 2;
            this.chbDisable.Text = "User is disabled";
            this.chbDisable.UseVisualStyleBackColor = true;
            // 
            // chbChange
            // 
            this.chbChange.AutoSize = true;
            this.chbChange.Location = new System.Drawing.Point(12, 37);
            this.chbChange.Name = "chbChange";
            this.chbChange.Size = new System.Drawing.Size(171, 17);
            this.chbChange.TabIndex = 1;
            this.chbChange.Text = "User cannot change password";
            this.chbChange.UseVisualStyleBackColor = true;
            this.chbChange.CheckedChanged += new System.EventHandler(this.chbChange_CheckedChanged);
            // 
            // chbLog
            // 
            this.chbLog.AutoSize = true;
            this.chbLog.Location = new System.Drawing.Point(12, 14);
            this.chbLog.Name = "chbLog";
            this.chbLog.Size = new System.Drawing.Size(224, 17);
            this.chbLog.TabIndex = 0;
            this.chbLog.Text = "User must change password at next logon";
            this.chbLog.UseVisualStyleBackColor = true;
            this.chbLog.CheckedChanged += new System.EventHandler(this.chbLog_CheckedChanged);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.txtDes);
            this.Panel2.Controls.Add(this.txtUserName);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.txtCode);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Location = new System.Drawing.Point(2, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(414, 93);
            this.Panel2.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&User ID";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(80, 67);
            this.txtDes.MaxLength = 50;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(318, 20);
            this.txtDes.TabIndex = 2;
            this.txtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDes_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(80, 37);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(318, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "User &Name";
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Location = new System.Drawing.Point(80, 7);
            this.txtCode.MaxLength = 15;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(318, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 70);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "&Description";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.txtPass);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.txtConfirm);
            this.Panel1.Location = new System.Drawing.Point(2, 105);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(414, 79);
            this.Panel1.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(106, 12);
            this.txtPass.MaxLength = 50;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(292, 20);
            this.txtPass.TabIndex = 0;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 47);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(91, 13);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Con&firm Password";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 15);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 13);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "&Password";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(106, 44);
            this.txtConfirm.MaxLength = 50;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(292, 20);
            this.txtConfirm.TabIndex = 1;
            this.txtConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirm_KeyDown);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(251, 284);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(163, 29);
            this.TableLayoutPanel1.TabIndex = 6;
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
            // ADDUSER_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 317);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDUSER_FRM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.Load += new System.EventHandler(this.ADDUSER_FRM_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.CheckBox chbDisable;
        internal System.Windows.Forms.CheckBox chbChange;
        internal System.Windows.Forms.CheckBox chbLog;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDes;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txtPass;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtConfirm;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Label Label21;
    }
}