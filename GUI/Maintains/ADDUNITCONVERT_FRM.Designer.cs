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
            this.cboconvf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cboconvf.Location = new System.Drawing.Point(130, 5);
            this.cboconvf.Name = "cboconvf";
            this.cboconvf.Size = new System.Drawing.Size(87, 20);
            this.cboconvf.TabIndex = 0;
            this.cboconvf.Tag = "Unit Sale";
            this.cboconvf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboconvf_KeyDown);
            // 
            // txtconvt
            // 
            this.txtconvt.FormattingEnabled = true;
            this.txtconvt.Location = new System.Drawing.Point(130, 70);
            this.txtconvt.Name = "txtconvt";
            this.txtconvt.Size = new System.Drawing.Size(87, 21);
            this.txtconvt.TabIndex = 3;
            this.txtconvt.Tag = "Unit Stock";
            this.txtconvt.SelectedIndexChanged += new System.EventHandler(this.txtconvt_SelectedIndexChanged);
            this.txtconvt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtconvt_KeyDown);
            // 
            // txtDescT2
            // 
            this.txtDescT2.Font = new System.Drawing.Font("Limon S1", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescT2.Location = new System.Drawing.Point(130, 96);
            this.txtDescT2.MaxLength = 50;
            this.txtDescT2.Name = "txtDescT2";
            this.txtDescT2.Size = new System.Drawing.Size(319, 32);
            this.txtDescT2.TabIndex = 5;
            this.txtDescT2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescT2_KeyDown);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(8, 105);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(90, 13);
            this.Label8.TabIndex = 27;
            this.Label8.Text = "Unit Stock Khmer";
            // 
            // txtDescF2
            // 
            this.txtDescF2.Font = new System.Drawing.Font("Limon S1", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescF2.Location = new System.Drawing.Point(130, 32);
            this.txtDescF2.MaxLength = 50;
            this.txtDescF2.Name = "txtDescF2";
            this.txtDescF2.Size = new System.Drawing.Size(319, 32);
            this.txtDescF2.TabIndex = 2;
            this.txtDescF2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescF2_KeyDown);
            // 
            // txtDescT1
            // 
            this.txtDescT1.Location = new System.Drawing.Point(311, 70);
            this.txtDescT1.MaxLength = 15;
            this.txtDescT1.Name = "txtDescT1";
            this.txtDescT1.Size = new System.Drawing.Size(138, 20);
            this.txtDescT1.TabIndex = 4;
            this.txtDescT1.Tag = "Unit Stock Description";
            this.txtDescT1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescT1_KeyDown);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 41);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(83, 13);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Sale Unit Khmer";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(220, 74);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(85, 13);
            this.Label7.TabIndex = 25;
            this.Label7.Text = "Unit Stock Desc";
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
            // TxtdescF1
            // 
            this.TxtdescF1.Location = new System.Drawing.Point(311, 5);
            this.TxtdescF1.MaxLength = 15;
            this.TxtdescF1.Name = "TxtdescF1";
            this.TxtdescF1.Size = new System.Drawing.Size(138, 20);
            this.TxtdescF1.TabIndex = 1;
            this.TxtdescF1.Tag = "Unit Sale Description";
            this.TxtdescF1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtdescF1_KeyDown);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(220, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(78, 13);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Unit Sale Desc";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(223, 137);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(37, 13);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Factor";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 74);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 13);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Unit Stock";
            // 
            // txtfactor
            // 
            this.txtfactor.Location = new System.Drawing.Point(311, 134);
            this.txtfactor.MaxLength = 50;
            this.txtfactor.Name = "txtfactor";
            this.txtfactor.Size = new System.Drawing.Size(138, 20);
            this.txtfactor.TabIndex = 7;
            this.txtfactor.Tag = "Factor";
            this.txtfactor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfactor_KeyDown);
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
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 138);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 13);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "Operator";
            // 
            // cbooperator
            // 
            this.cbooperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbooperator.FormattingEnabled = true;
            this.cbooperator.Items.AddRange(new object[] {
            "* - Multiply",
            "/ - Divide"});
            this.cbooperator.Location = new System.Drawing.Point(130, 134);
            this.cbooperator.Name = "cbooperator";
            this.cbooperator.Size = new System.Drawing.Size(87, 21);
            this.cbooperator.TabIndex = 6;
            this.cbooperator.Tag = "Operator";
            this.cbooperator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbooperator_KeyDown);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(288, 163);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(163, 29);
            this.TableLayoutPanel1.TabIndex = 33;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(8, 8);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(50, 13);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "Unit Sale";
            // 
            // ADDUNITCONVERT_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 193);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Unit Conversion";
            this.Load += new System.EventHandler(this.ADDUNITCONVERT_FRM_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADDUNITCONVERT_FRM_FormClosing);
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