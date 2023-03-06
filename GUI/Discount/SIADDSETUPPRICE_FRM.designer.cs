namespace POS.GUI.Discount
{
    partial class SIADDSETUPPRICE_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIADDSETUPPRICE_FRM));
            this.Label1 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtUnitofSale = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtUnitofStock = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnUnitofSale = new System.Windows.Forms.Button();
            this.btnProID = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // cboStatus
            // 
            resources.ApplyResources(this.cboStatus, "cboStatus");
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            resources.GetString("cboStatus.Items"),
            resources.GetString("cboStatus.Items1")});
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Tag = "Status";
            this.cboStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboStatus_KeyDown);
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // txtUnitofSale
            // 
            resources.ApplyResources(this.txtUnitofSale, "txtUnitofSale");
            this.txtUnitofSale.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnitofSale.Name = "txtUnitofSale";
            this.txtUnitofSale.Tag = "Unit of Sale";
            this.txtUnitofSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitofSale_KeyDown);
            // 
            // Label10
            // 
            resources.ApplyResources(this.Label10, "Label10");
            this.Label10.Name = "Label10";
            this.Label10.Tag = "Second Commonts";
            // 
            // txtUnitofStock
            // 
            resources.ApplyResources(this.txtUnitofStock, "txtUnitofStock");
            this.txtUnitofStock.Name = "txtUnitofStock";
            this.txtUnitofStock.ReadOnly = true;
            this.txtUnitofStock.TabStop = false;
            this.txtUnitofStock.Tag = "D/C";
            // 
            // txtSellingPrice
            // 
            resources.ApplyResources(this.txtSellingPrice, "txtSellingPrice");
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Tag = "Discount Rate";
            this.txtSellingPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSellingPrice_KeyDown);
            // 
            // OK_Button
            // 
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
            // 
            // txtProID
            // 
            resources.ApplyResources(this.txtProID, "txtProID");
            this.txtProID.Name = "txtProID";
            this.txtProID.Tag = "Item Code";
            this.txtProID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProID_KeyDown);
            // 
            // Label20
            // 
            resources.ApplyResources(this.Label20, "Label20");
            this.Label20.Name = "Label20";
            // 
            // Cancel_Button
            // 
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // TableLayoutPanel1
            // 
            resources.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            // 
            // txtProName
            // 
            resources.ApplyResources(this.txtProName, "txtProName");
            this.txtProName.Name = "txtProName";
            this.txtProName.Tag = "Product Name";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            this.Label2.Tag = "";
            // 
            // btnUnitofSale
            // 
            resources.ApplyResources(this.btnUnitofSale, "btnUnitofSale");
            this.btnUnitofSale.ImageList = this.ImageList1;
            this.btnUnitofSale.Name = "btnUnitofSale";
            this.btnUnitofSale.TabStop = false;
            this.btnUnitofSale.UseVisualStyleBackColor = true;
            this.btnUnitofSale.Click += new System.EventHandler(this.btnUnitofSale_Click);
            // 
            // btnProID
            // 
            resources.ApplyResources(this.btnProID, "btnProID");
            this.btnProID.ImageList = this.ImageList1;
            this.btnProID.Name = "btnProID";
            this.btnProID.TabStop = false;
            this.btnProID.UseVisualStyleBackColor = true;
            this.btnProID.Click += new System.EventHandler(this.btnProID_Click);
            // 
            // SIADDSETUPPRICE_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnUnitofSale);
            this.Controls.Add(this.txtUnitofSale);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtUnitofStock);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.btnProID);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SIADDSETUPPRICE_FRM";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.SIADDSETUPPRICE_FRM_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboStatus;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnUnitofSale;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.TextBox txtUnitofSale;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtUnitofStock;
        internal System.Windows.Forms.TextBox txtSellingPrice;
        internal System.Windows.Forms.Button btnProID;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.TextBox txtProID;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.TextBox txtProName;
        internal System.Windows.Forms.Label Label2;
    }
}