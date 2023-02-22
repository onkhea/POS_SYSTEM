namespace POS.GUI.Purchases
{
    partial class SISOSPLIT_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SISOSPLIT_FRM));
            this.txtField = new System.Windows.Forms.TextBox();
            this.txtOldValue = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.txtSplit = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtField
            // 
            this.txtField.Enabled = false;
            this.txtField.Location = new System.Drawing.Point(67, 9);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(123, 20);
            this.txtField.TabIndex = 4;
            this.txtField.Tag = "Values";
            // 
            // txtOldValue
            // 
            this.txtOldValue.Enabled = false;
            this.txtOldValue.Location = new System.Drawing.Point(194, 9);
            this.txtOldValue.Name = "txtOldValue";
            this.txtOldValue.Size = new System.Drawing.Size(142, 20);
            this.txtOldValue.TabIndex = 3;
            this.txtOldValue.Tag = "Values";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(190, 66);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 7;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // txtSplit
            // 
            this.txtSplit.Location = new System.Drawing.Point(194, 35);
            this.txtSplit.Name = "txtSplit";
            this.txtSplit.Size = new System.Drawing.Size(142, 20);
            this.txtSplit.TabIndex = 2;
            this.txtSplit.Tag = "Values";
            this.txtSplit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSplit_KeyDown);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Split Field";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(103, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "&Value to split";
            // 
            // SISOSPLIT_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 95);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.txtOldValue);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.txtSplit);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SISOSPLIT_FRM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split Values";
            this.Load += new System.EventHandler(this.SISOSPLIT_FRM_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtField;
        internal System.Windows.Forms.TextBox txtOldValue;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.TextBox txtSplit;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
    }
}