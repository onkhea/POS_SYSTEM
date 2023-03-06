namespace POS.GUI.Purchases
{
    partial class SIPOPURCHASEORDER_PRINT_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIPOPURCHASEORDER_PRINT_FRM));
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.btnRef1 = new System.Windows.Forms.Button();
            this.txtRef1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnF1 = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesc1
            // 
            resources.ApplyResources(this.txtDesc1, "txtDesc1");
            this.txtDesc1.Name = "txtDesc1";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // txtF1
            // 
            resources.ApplyResources(this.txtF1, "txtF1");
            this.txtF1.Name = "txtF1";
            this.txtF1.Tag = "Report Format";
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
            // 
            // btnRef1
            // 
            resources.ApplyResources(this.btnRef1, "btnRef1");
            this.btnRef1.Name = "btnRef1";
            this.btnRef1.UseVisualStyleBackColor = true;
            // 
            // txtRef1
            // 
            resources.ApplyResources(this.txtRef1, "txtRef1");
            this.txtRef1.Name = "txtRef1";
            this.txtRef1.Tag = "Sale Order Number: From";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // btnF1
            // 
            resources.ApplyResources(this.btnF1, "btnF1");
            this.btnF1.Image = global::POS.Properties.Resources.ico_alpha_Search_16x16;
            this.btnF1.Name = "btnF1";
            this.btnF1.TabStop = false;
            this.btnF1.UseVisualStyleBackColor = true;
            this.btnF1.Click += new System.EventHandler(this.btnF1_Click);
            // 
            // SIPOPURCHASEORDER_PRINT_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRef1);
            this.Controls.Add(this.txtRef1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtDesc1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnF1);
            this.Controls.Add(this.txtF1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SIPOPURCHASEORDER_PRINT_FRM";
            this.Load += new System.EventHandler(this.SIPOPURCHASEORDER_PRINT_FRM_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtDesc1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnF1;
        internal System.Windows.Forms.TextBox txtF1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Button btnRef1;
        internal System.Windows.Forms.TextBox txtRef1;
        internal System.Windows.Forms.Label Label5;
    }
}