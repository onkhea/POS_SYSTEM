namespace POS.Reports
{
    partial class AddreportsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddreportsFrm));
            this.cboType = new System.Windows.Forms.ComboBox();
            this.chbInactive = new System.Windows.Forms.CheckBox();
            this.lblRepCode = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblRep_Type = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboType
            // 
            resources.ApplyResources(this.cboType, "cboType");
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            resources.GetString("cboType.Items"),
            resources.GetString("cboType.Items1"),
            resources.GetString("cboType.Items2"),
            resources.GetString("cboType.Items3"),
            resources.GetString("cboType.Items4"),
            resources.GetString("cboType.Items5"),
            resources.GetString("cboType.Items6"),
            resources.GetString("cboType.Items7"),
            resources.GetString("cboType.Items8"),
            resources.GetString("cboType.Items9"),
            resources.GetString("cboType.Items10"),
            resources.GetString("cboType.Items11"),
            resources.GetString("cboType.Items12"),
            resources.GetString("cboType.Items13"),
            resources.GetString("cboType.Items14"),
            resources.GetString("cboType.Items15"),
            resources.GetString("cboType.Items16")});
            this.cboType.Name = "cboType";
            this.cboType.Sorted = true;
            this.cboType.Tag = "Report Type";
            this.cboType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboType_KeyDown);
            // 
            // chbInactive
            // 
            resources.ApplyResources(this.chbInactive, "chbInactive");
            this.chbInactive.Name = "chbInactive";
            this.chbInactive.UseVisualStyleBackColor = true;
            this.chbInactive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbInactive_KeyDown);
            // 
            // lblRepCode
            // 
            resources.ApplyResources(this.lblRepCode, "lblRepCode");
            this.lblRepCode.Name = "lblRepCode";
            // 
            // TableLayoutPanel1
            // 
            resources.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            // 
            // OK_Button
            // 
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // txtDes
            // 
            resources.ApplyResources(this.txtDes, "txtDes");
            this.txtDes.Name = "txtDes";
            this.txtDes.Tag = "Description";
            this.txtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDes_KeyDown);
            // 
            // txtCode
            // 
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.Name = "txtCode";
            this.txtCode.Tag = "Report Code";
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblRep_Type
            // 
            resources.ApplyResources(this.lblRep_Type, "lblRep_Type");
            this.lblRep_Type.Name = "lblRep_Type";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // AddreportsFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.chbInactive);
            this.Controls.Add(this.lblRepCode);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblRep_Type);
            this.Controls.Add(this.Label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddreportsFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboType;
        internal System.Windows.Forms.CheckBox chbInactive;
        internal System.Windows.Forms.Label lblRepCode;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.TextBox txtDes;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.Label lblRep_Type;
        internal System.Windows.Forms.Label Label3;
    }
}