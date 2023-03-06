namespace POS.GUI.Purchases
{
    partial class PurchaseorderPrintFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseorderPrintFrm));
            this.OK_Button = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cboIn_item = new System.Windows.Forms.ComboBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.btnRef1 = new System.Windows.Forms.Button();
            this.txtRef1 = new System.Windows.Forms.TextBox();
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnF1 = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK_Button
            // 
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.HelpProvider1.SetHelpKeyword(this.OK_Button, resources.GetString("OK_Button.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.OK_Button, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("OK_Button.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.OK_Button, resources.GetString("OK_Button.HelpString"));
            this.OK_Button.Name = "OK_Button";
            this.HelpProvider1.SetShowHelp(this.OK_Button, ((bool)(resources.GetObject("OK_Button.ShowHelp"))));
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // cboIn_item
            // 
            resources.ApplyResources(this.cboIn_item, "cboIn_item");
            this.cboIn_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIn_item.FormattingEnabled = true;
            this.HelpProvider1.SetHelpKeyword(this.cboIn_item, resources.GetString("cboIn_item.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.cboIn_item, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("cboIn_item.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.cboIn_item, resources.GetString("cboIn_item.HelpString"));
            this.cboIn_item.Items.AddRange(new object[] {
            resources.GetString("cboIn_item.Items"),
            resources.GetString("cboIn_item.Items1")});
            this.cboIn_item.Name = "cboIn_item";
            this.HelpProvider1.SetShowHelp(this.cboIn_item, ((bool)(resources.GetObject("cboIn_item.ShowHelp"))));
            // 
            // Cancel_Button
            // 
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HelpProvider1.SetHelpKeyword(this.Cancel_Button, resources.GetString("Cancel_Button.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Cancel_Button, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Cancel_Button.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Cancel_Button, resources.GetString("Cancel_Button.HelpString"));
            this.Cancel_Button.Name = "Cancel_Button";
            this.HelpProvider1.SetShowHelp(this.Cancel_Button, ((bool)(resources.GetObject("Cancel_Button.ShowHelp"))));
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // btnRef1
            // 
            resources.ApplyResources(this.btnRef1, "btnRef1");
            this.HelpProvider1.SetHelpKeyword(this.btnRef1, resources.GetString("btnRef1.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.btnRef1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnRef1.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.btnRef1, resources.GetString("btnRef1.HelpString"));
            this.btnRef1.ImageList = this.ImageList1;
            this.btnRef1.Name = "btnRef1";
            this.HelpProvider1.SetShowHelp(this.btnRef1, ((bool)(resources.GetObject("btnRef1.ShowHelp"))));
            this.btnRef1.UseVisualStyleBackColor = true;
            // 
            // txtRef1
            // 
            resources.ApplyResources(this.txtRef1, "txtRef1");
            this.HelpProvider1.SetHelpKeyword(this.txtRef1, resources.GetString("txtRef1.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtRef1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtRef1.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtRef1, resources.GetString("txtRef1.HelpString"));
            this.txtRef1.Name = "txtRef1";
            this.HelpProvider1.SetShowHelp(this.txtRef1, ((bool)(resources.GetObject("txtRef1.ShowHelp"))));
            this.txtRef1.Tag = "Sale Order Number: From";
            // 
            // HelpProvider1
            // 
            resources.ApplyResources(this.HelpProvider1, "HelpProvider1");
            // 
            // txtDesc1
            // 
            resources.ApplyResources(this.txtDesc1, "txtDesc1");
            this.HelpProvider1.SetHelpKeyword(this.txtDesc1, resources.GetString("txtDesc1.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtDesc1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtDesc1.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtDesc1, resources.GetString("txtDesc1.HelpString"));
            this.txtDesc1.Name = "txtDesc1";
            this.HelpProvider1.SetShowHelp(this.txtDesc1, ((bool)(resources.GetObject("txtDesc1.ShowHelp"))));
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.HelpProvider1.SetHelpKeyword(this.Label2, resources.GetString("Label2.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label2, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label2.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label2, resources.GetString("Label2.HelpString"));
            this.Label2.Name = "Label2";
            this.HelpProvider1.SetShowHelp(this.Label2, ((bool)(resources.GetObject("Label2.ShowHelp"))));
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.HelpProvider1.SetHelpKeyword(this.Label5, resources.GetString("Label5.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label5, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label5.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label5, resources.GetString("Label5.HelpString"));
            this.Label5.Name = "Label5";
            this.HelpProvider1.SetShowHelp(this.Label5, ((bool)(resources.GetObject("Label5.ShowHelp"))));
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.HelpProvider1.SetHelpKeyword(this.Label1, resources.GetString("Label1.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label1.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label1, resources.GetString("Label1.HelpString"));
            this.Label1.Name = "Label1";
            this.HelpProvider1.SetShowHelp(this.Label1, ((bool)(resources.GetObject("Label1.ShowHelp"))));
            // 
            // txtF1
            // 
            resources.ApplyResources(this.txtF1, "txtF1");
            this.HelpProvider1.SetHelpKeyword(this.txtF1, resources.GetString("txtF1.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtF1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtF1.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtF1, resources.GetString("txtF1.HelpString"));
            this.txtF1.Name = "txtF1";
            this.HelpProvider1.SetShowHelp(this.txtF1, ((bool)(resources.GetObject("txtF1.ShowHelp"))));
            this.txtF1.Tag = "Report Format";
            // 
            // TableLayoutPanel1
            // 
            resources.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.HelpProvider1.SetHelpKeyword(this.TableLayoutPanel1, resources.GetString("TableLayoutPanel1.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.TableLayoutPanel1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("TableLayoutPanel1.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.TableLayoutPanel1, resources.GetString("TableLayoutPanel1.HelpString"));
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.HelpProvider1.SetShowHelp(this.TableLayoutPanel1, ((bool)(resources.GetObject("TableLayoutPanel1.ShowHelp"))));
            // 
            // btnF1
            // 
            resources.ApplyResources(this.btnF1, "btnF1");
            this.HelpProvider1.SetHelpKeyword(this.btnF1, resources.GetString("btnF1.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.btnF1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnF1.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.btnF1, resources.GetString("btnF1.HelpString"));
            this.btnF1.ImageList = this.ImageList1;
            this.btnF1.Name = "btnF1";
            this.HelpProvider1.SetShowHelp(this.btnF1, ((bool)(resources.GetObject("btnF1.ShowHelp"))));
            this.btnF1.TabStop = false;
            this.btnF1.UseVisualStyleBackColor = true;
            // 
            // PurchaseorderPrintFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboIn_item);
            this.Controls.Add(this.btnRef1);
            this.Controls.Add(this.txtRef1);
            this.Controls.Add(this.txtDesc1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnF1);
            this.Controls.Add(this.txtF1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.HelpProvider1.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.Name = "PurchaseorderPrintFrm";
            this.HelpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ComboBox cboIn_item;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Button btnRef1;
        internal System.Windows.Forms.HelpProvider HelpProvider1;
        internal System.Windows.Forms.TextBox txtRef1;
        internal System.Windows.Forms.TextBox txtDesc1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnF1;
        internal System.Windows.Forms.TextBox txtF1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
    }
}