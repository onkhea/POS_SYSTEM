namespace POS.GUI.Maintains
{
    partial class ADDUNITCONVERT_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDUNITCONVERT_FRM));
            this.cboconvf = new System.Windows.Forms.TextBox();
            this.txtconvt = new System.Windows.Forms.ComboBox();
            this.txtDescT2 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtDescF2 = new System.Windows.Forms.TextBox();
            this.txtDescT1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.TxtdescF1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtfactor = new System.Windows.Forms.TextBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Label4 = new System.Windows.Forms.Label();
            this.cbooperator = new System.Windows.Forms.ComboBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label6 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboconvf
            // 
            resources.ApplyResources(this.cboconvf, "cboconvf");
            this.cboconvf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cboconvf.Name = "cboconvf";
            this.cboconvf.Tag = "Unit Sale";
            this.cboconvf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboconvf_KeyDown);
            // 
            // txtconvt
            // 
            resources.ApplyResources(this.txtconvt, "txtconvt");
            this.txtconvt.FormattingEnabled = true;
            this.txtconvt.Name = "txtconvt";
            this.txtconvt.Tag = "Unit Stock";
            this.txtconvt.SelectedIndexChanged += new System.EventHandler(this.txtconvt_SelectedIndexChanged);
            this.txtconvt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtconvt_KeyDown);
            // 
            // txtDescT2
            // 
            resources.ApplyResources(this.txtDescT2, "txtDescT2");
            this.txtDescT2.Name = "txtDescT2";
            this.txtDescT2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescT2_KeyDown);
            // 
            // Label8
            // 
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.Name = "Label8";
            // 
            // txtDescF2
            // 
            resources.ApplyResources(this.txtDescF2, "txtDescF2");
            this.txtDescF2.Name = "txtDescF2";
            this.txtDescF2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescF2_KeyDown);
            // 
            // txtDescT1
            // 
            resources.ApplyResources(this.txtDescT1, "txtDescT1");
            this.txtDescT1.Name = "txtDescT1";
            this.txtDescT1.Tag = "Unit Stock Description";
            this.txtDescT1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescT1_KeyDown);
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.Name = "Label7";
            // 
            // OK_Button
            // 
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
            // 
            // TxtdescF1
            // 
            resources.ApplyResources(this.TxtdescF1, "TxtdescF1");
            this.TxtdescF1.Name = "TxtdescF1";
            this.TxtdescF1.Tag = "Unit Sale Description";
            this.TxtdescF1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtdescF1_KeyDown);
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // txtfactor
            // 
            resources.ApplyResources(this.txtfactor, "txtfactor");
            this.txtfactor.Name = "txtfactor";
            this.txtfactor.Tag = "Factor";
            this.txtfactor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfactor_KeyDown);
            // 
            // Cancel_Button
            // 
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            // 
            // cbooperator
            // 
            resources.ApplyResources(this.cbooperator, "cbooperator");
            this.cbooperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbooperator.FormattingEnabled = true;
            this.cbooperator.Items.AddRange(new object[] {
            resources.GetString("cbooperator.Items"),
            resources.GetString("cbooperator.Items1")});
            this.cbooperator.Name = "cbooperator";
            this.cbooperator.Tag = "Operator";
            this.cbooperator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbooperator_KeyDown);
            // 
            // TableLayoutPanel1
            // 
            resources.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            // 
            // Label6
            // 
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.Name = "Label6";
            // 
            // ADDUNITCONVERT_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboconvf);
            this.Controls.Add(this.txtconvt);
            this.Controls.Add(this.txtDescT2);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtDescF2);
            this.Controls.Add(this.txtDescT1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TxtdescF1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtfactor);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cbooperator);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.Label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDUNITCONVERT_FRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADDUNITCONVERT_FRM_FormClosing);
            this.Load += new System.EventHandler(this.ADDUNITCONVERT_FRM_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox cboconvf;
        internal System.Windows.Forms.ComboBox txtconvt;
        internal System.Windows.Forms.TextBox txtDescT2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtDescF2;
        internal System.Windows.Forms.TextBox txtDescT1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.TextBox TxtdescF1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtfactor;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cbooperator;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Label Label6;
    }
}