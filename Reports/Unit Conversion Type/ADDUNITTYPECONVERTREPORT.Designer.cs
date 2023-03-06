namespace POS.Reports.Unit_Conversion_Type
{
    partial class ADDUNITTYPECONVERTREPORT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDUNITTYPECONVERTREPORT));
            this.Label4 = new System.Windows.Forms.Label();
            this.txtComment2 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtComment1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            // 
            // txtComment2
            // 
            resources.ApplyResources(this.txtComment2, "txtComment2");
            this.txtComment2.Name = "txtComment2";
            this.txtComment2.Tag = "Description";
            this.txtComment2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComment2_KeyDown);
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // txtComment1
            // 
            resources.ApplyResources(this.txtComment1, "txtComment1");
            this.txtComment1.Name = "txtComment1";
            this.txtComment1.Tag = "Description";
            this.txtComment1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComment1_KeyDown);
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // txtDesc
            // 
            resources.ApplyResources(this.txtDesc, "txtDesc");
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Tag = "Description";
            this.txtDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesc_KeyDown);
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // OK_Button
            // 
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
            // 
            // Cancel_Button
            // 
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // txtCode
            // 
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Name = "txtCode";
            this.txtCode.Tag = "No";
            // 
            // TableLayoutPanel1
            // 
            resources.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            // 
            // ADDUNITTYPECONVERTREPORT
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtComment2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtComment1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "ADDUNITTYPECONVERTREPORT";
            this.Load += new System.EventHandler(this.ADDUNITTYPECONVERTREPORT_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtComment2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtComment1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtDesc;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
    }
}