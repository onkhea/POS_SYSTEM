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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDEMPLOYEE));
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
            resources.ApplyResources(this.Label18, "Label18");
            this.Label18.Name = "Label18";
            // 
            // Label17
            // 
            resources.ApplyResources(this.Label17, "Label17");
            this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label17.Name = "Label17";
            // 
            // GroupBox1
            // 
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
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
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            this.Label2.Tag = "";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // txtEmp_tel
            // 
            resources.ApplyResources(this.txtEmp_tel, "txtEmp_tel");
            this.txtEmp_tel.Name = "txtEmp_tel";
            this.txtEmp_tel.Tag = "Telephone";
            this.txtEmp_tel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmp_tel_KeyDown);
            // 
            // Label14
            // 
            resources.ApplyResources(this.Label14, "Label14");
            this.Label14.Name = "Label14";
            // 
            // cboEmp_Status
            // 
            resources.ApplyResources(this.cboEmp_Status, "cboEmp_Status");
            this.cboEmp_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmp_Status.FormattingEnabled = true;
            this.cboEmp_Status.Items.AddRange(new object[] {
            resources.GetString("cboEmp_Status.Items"),
            resources.GetString("cboEmp_Status.Items1")});
            this.cboEmp_Status.Name = "cboEmp_Status";
            this.cboEmp_Status.Tag = "Status";
            this.cboEmp_Status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboEmp_Status_KeyDown);
            // 
            // txtEmp_Code
            // 
            resources.ApplyResources(this.txtEmp_Code, "txtEmp_Code");
            this.txtEmp_Code.Name = "txtEmp_Code";
            this.txtEmp_Code.Tag = "Customer Code";
            this.txtEmp_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmp_Code_KeyDown);
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // txtEmp_Name
            // 
            resources.ApplyResources(this.txtEmp_Name, "txtEmp_Name");
            this.txtEmp_Name.Name = "txtEmp_Name";
            this.txtEmp_Name.Tag = "Customer Name";
            this.txtEmp_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmp_Name_KeyDown);
            // 
            // txtEmp_add
            // 
            resources.ApplyResources(this.txtEmp_add, "txtEmp_add");
            this.txtEmp_add.Name = "txtEmp_add";
            this.txtEmp_add.Tag = "Address Line1";
            this.txtEmp_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmp_add_KeyDown);
            // 
            // TableLayoutPanel1
            // 
            resources.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
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
            // OK_Button
            // 
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
            // 
            // ADDEMPLOYEE
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDEMPLOYEE";
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