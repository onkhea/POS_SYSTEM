namespace POS.GUI.Purchases
{
    partial class ADDSIPOPURCHASEORDER_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDSIPOPURCHASEORDER_FRM));
            this.Label14 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtStockQ = new System.Windows.Forms.TextBox();
            this.dtpE = new System.Windows.Forms.DateTimePicker();
            this.Label13 = new System.Windows.Forms.Label();
            this.cboPType = new System.Windows.Forms.ComboBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblLoc = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtLoc_Desc = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtItem_Desc = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtItem_Code = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtLoc_Code = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtPhysical = new System.Windows.Forms.TextBox();
            this.txtOnOrder = new System.Windows.Forms.TextBox();
            this.txtDisAmt = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDisP = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txtUnitofStock = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtUnitOfPurchase = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.BTN_U_PURCHASE = new System.Windows.Forms.Button();
            this.btnItem_Code = new System.Windows.Forms.Button();
            this.btnLoc_Code = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label14
            // 
            resources.ApplyResources(this.Label14, "Label14");
            this.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HelpProvider1.SetHelpKeyword(this.Label14, resources.GetString("Label14.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label14, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label14.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label14, resources.GetString("Label14.HelpString"));
            this.Label14.Name = "Label14";
            this.HelpProvider1.SetShowHelp(this.Label14, ((bool)(resources.GetObject("Label14.ShowHelp"))));
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.HelpProvider1.SetHelpKeyword(this.Label4, resources.GetString("Label4.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label4, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label4.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label4, resources.GetString("Label4.HelpString"));
            this.Label4.Name = "Label4";
            this.HelpProvider1.SetShowHelp(this.Label4, ((bool)(resources.GetObject("Label4.ShowHelp"))));
            this.Label4.Tag = "Second Commonts";
            // 
            // txtStockQ
            // 
            resources.ApplyResources(this.txtStockQ, "txtStockQ");
            this.txtStockQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HelpProvider1.SetHelpKeyword(this.txtStockQ, resources.GetString("txtStockQ.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtStockQ, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtStockQ.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtStockQ, resources.GetString("txtStockQ.HelpString"));
            this.txtStockQ.Name = "txtStockQ";
            this.txtStockQ.ReadOnly = true;
            this.HelpProvider1.SetShowHelp(this.txtStockQ, ((bool)(resources.GetObject("txtStockQ.ShowHelp"))));
            this.txtStockQ.TabStop = false;
            this.txtStockQ.Tag = "D/C";
            // 
            // dtpE
            // 
            resources.ApplyResources(this.dtpE, "dtpE");
            this.dtpE.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HelpProvider1.SetHelpKeyword(this.dtpE, resources.GetString("dtpE.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.dtpE, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("dtpE.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.dtpE, resources.GetString("dtpE.HelpString"));
            this.dtpE.Name = "dtpE";
            this.dtpE.ShowCheckBox = true;
            this.HelpProvider1.SetShowHelp(this.dtpE, ((bool)(resources.GetObject("dtpE.ShowHelp"))));
            this.dtpE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpE_KeyDown);
            // 
            // Label13
            // 
            resources.ApplyResources(this.Label13, "Label13");
            this.HelpProvider1.SetHelpKeyword(this.Label13, resources.GetString("Label13.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label13, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label13.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label13, resources.GetString("Label13.HelpString"));
            this.Label13.Name = "Label13";
            this.HelpProvider1.SetShowHelp(this.Label13, ((bool)(resources.GetObject("Label13.ShowHelp"))));
            // 
            // cboPType
            // 
            resources.ApplyResources(this.cboPType, "cboPType");
            this.cboPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPType.FormattingEnabled = true;
            this.HelpProvider1.SetHelpKeyword(this.cboPType, resources.GetString("cboPType.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.cboPType, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("cboPType.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.cboPType, resources.GetString("cboPType.HelpString"));
            this.cboPType.Items.AddRange(new object[] {
            resources.GetString("cboPType.Items"),
            resources.GetString("cboPType.Items1")});
            this.cboPType.Name = "cboPType";
            this.HelpProvider1.SetShowHelp(this.cboPType, ((bool)(resources.GetObject("cboPType.ShowHelp"))));
            this.cboPType.Tag = "Purchase Type";
            this.cboPType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboPType_KeyDown);
            // 
            // lblItemCode
            // 
            resources.ApplyResources(this.lblItemCode, "lblItemCode");
            this.HelpProvider1.SetHelpKeyword(this.lblItemCode, resources.GetString("lblItemCode.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.lblItemCode, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblItemCode.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.lblItemCode, resources.GetString("lblItemCode.HelpString"));
            this.lblItemCode.Name = "lblItemCode";
            this.HelpProvider1.SetShowHelp(this.lblItemCode, ((bool)(resources.GetObject("lblItemCode.ShowHelp"))));
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Icon_15.ico");
            // 
            // lblLoc
            // 
            resources.ApplyResources(this.lblLoc, "lblLoc");
            this.HelpProvider1.SetHelpKeyword(this.lblLoc, resources.GetString("lblLoc.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.lblLoc, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblLoc.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.lblLoc, resources.GetString("lblLoc.HelpString"));
            this.lblLoc.Name = "lblLoc";
            this.HelpProvider1.SetShowHelp(this.lblLoc, ((bool)(resources.GetObject("lblLoc.ShowHelp"))));
            // 
            // Label8
            // 
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HelpProvider1.SetHelpKeyword(this.Label8, resources.GetString("Label8.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label8, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label8.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label8, resources.GetString("Label8.HelpString"));
            this.Label8.Name = "Label8";
            this.HelpProvider1.SetShowHelp(this.Label8, ((bool)(resources.GetObject("Label8.ShowHelp"))));
            // 
            // txtLoc_Desc
            // 
            resources.ApplyResources(this.txtLoc_Desc, "txtLoc_Desc");
            this.txtLoc_Desc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HelpProvider1.SetHelpKeyword(this.txtLoc_Desc, resources.GetString("txtLoc_Desc.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtLoc_Desc, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtLoc_Desc.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtLoc_Desc, resources.GetString("txtLoc_Desc.HelpString"));
            this.txtLoc_Desc.Name = "txtLoc_Desc";
            this.HelpProvider1.SetShowHelp(this.txtLoc_Desc, ((bool)(resources.GetObject("txtLoc_Desc.ShowHelp"))));
            this.txtLoc_Desc.Tag = "Item Description";
            this.txtLoc_Desc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoc_Desc_KeyDown);
            // 
            // Label6
            // 
            resources.ApplyResources(this.Label6, "Label6");
            this.HelpProvider1.SetHelpKeyword(this.Label6, resources.GetString("Label6.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label6, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label6.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label6, resources.GetString("Label6.HelpString"));
            this.Label6.Name = "Label6";
            this.HelpProvider1.SetShowHelp(this.Label6, ((bool)(resources.GetObject("Label6.ShowHelp"))));
            // 
            // txtItem_Desc
            // 
            resources.ApplyResources(this.txtItem_Desc, "txtItem_Desc");
            this.txtItem_Desc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HelpProvider1.SetHelpKeyword(this.txtItem_Desc, resources.GetString("txtItem_Desc.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtItem_Desc, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtItem_Desc.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtItem_Desc, resources.GetString("txtItem_Desc.HelpString"));
            this.txtItem_Desc.Name = "txtItem_Desc";
            this.HelpProvider1.SetShowHelp(this.txtItem_Desc, ((bool)(resources.GetObject("txtItem_Desc.ShowHelp"))));
            this.txtItem_Desc.Tag = "Item Description";
            // 
            // Label12
            // 
            resources.ApplyResources(this.Label12, "Label12");
            this.HelpProvider1.SetHelpKeyword(this.Label12, resources.GetString("Label12.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label12, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label12.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label12, resources.GetString("Label12.HelpString"));
            this.Label12.Name = "Label12";
            this.HelpProvider1.SetShowHelp(this.Label12, ((bool)(resources.GetObject("Label12.ShowHelp"))));
            // 
            // Label9
            // 
            resources.ApplyResources(this.Label9, "Label9");
            this.HelpProvider1.SetHelpKeyword(this.Label9, resources.GetString("Label9.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label9, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label9.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label9, resources.GetString("Label9.HelpString"));
            this.Label9.Name = "Label9";
            this.HelpProvider1.SetShowHelp(this.Label9, ((bool)(resources.GetObject("Label9.ShowHelp"))));
            // 
            // txtItem_Code
            // 
            resources.ApplyResources(this.txtItem_Code, "txtItem_Code");
            this.txtItem_Code.BackColor = System.Drawing.Color.White;
            this.HelpProvider1.SetHelpKeyword(this.txtItem_Code, resources.GetString("txtItem_Code.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtItem_Code, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtItem_Code.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtItem_Code, resources.GetString("txtItem_Code.HelpString"));
            this.txtItem_Code.Name = "txtItem_Code";
            this.HelpProvider1.SetShowHelp(this.txtItem_Code, ((bool)(resources.GetObject("txtItem_Code.ShowHelp"))));
            this.txtItem_Code.Tag = "Item Code";
            this.txtItem_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_Code_KeyDown);
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
            // OK_Button
            // 
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.HelpProvider1.SetHelpKeyword(this.OK_Button, resources.GetString("OK_Button.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.OK_Button, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("OK_Button.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.OK_Button, resources.GetString("OK_Button.HelpString"));
            this.OK_Button.Name = "OK_Button";
            this.HelpProvider1.SetShowHelp(this.OK_Button, ((bool)(resources.GetObject("OK_Button.ShowHelp"))));
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_Button_KeyDown);
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
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.HelpProvider1.SetHelpKeyword(this.Label3, resources.GetString("Label3.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label3, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label3.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label3, resources.GetString("Label3.HelpString"));
            this.Label3.Name = "Label3";
            this.HelpProvider1.SetShowHelp(this.Label3, ((bool)(resources.GetObject("Label3.ShowHelp"))));
            // 
            // txtLoc_Code
            // 
            resources.ApplyResources(this.txtLoc_Code, "txtLoc_Code");
            this.txtLoc_Code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HelpProvider1.SetHelpKeyword(this.txtLoc_Code, resources.GetString("txtLoc_Code.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtLoc_Code, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtLoc_Code.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtLoc_Code, resources.GetString("txtLoc_Code.HelpString"));
            this.txtLoc_Code.Name = "txtLoc_Code";
            this.HelpProvider1.SetShowHelp(this.txtLoc_Code, ((bool)(resources.GetObject("txtLoc_Code.ShowHelp"))));
            this.txtLoc_Code.Tag = "Location Code";
            this.txtLoc_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoc_Code_KeyDown);
            // 
            // Label11
            // 
            resources.ApplyResources(this.Label11, "Label11");
            this.HelpProvider1.SetHelpKeyword(this.Label11, resources.GetString("Label11.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label11, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label11.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label11, resources.GetString("Label11.HelpString"));
            this.Label11.Name = "Label11";
            this.HelpProvider1.SetShowHelp(this.Label11, ((bool)(resources.GetObject("Label11.ShowHelp"))));
            this.Label11.Tag = "Second Commonts";
            // 
            // Label10
            // 
            resources.ApplyResources(this.Label10, "Label10");
            this.HelpProvider1.SetHelpKeyword(this.Label10, resources.GetString("Label10.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label10, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label10.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label10, resources.GetString("Label10.HelpString"));
            this.Label10.Name = "Label10";
            this.HelpProvider1.SetShowHelp(this.Label10, ((bool)(resources.GetObject("Label10.ShowHelp"))));
            this.Label10.Tag = "Second Commonts";
            // 
            // txtSubTotal
            // 
            resources.ApplyResources(this.txtSubTotal, "txtSubTotal");
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HelpProvider1.SetHelpKeyword(this.txtSubTotal, resources.GetString("txtSubTotal.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtSubTotal, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtSubTotal.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtSubTotal, resources.GetString("txtSubTotal.HelpString"));
            this.txtSubTotal.Name = "txtSubTotal";
            this.HelpProvider1.SetShowHelp(this.txtSubTotal, ((bool)(resources.GetObject("txtSubTotal.ShowHelp"))));
            this.txtSubTotal.Tag = "Line Reference";
            // 
            // txtPhysical
            // 
            resources.ApplyResources(this.txtPhysical, "txtPhysical");
            this.txtPhysical.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhysical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HelpProvider1.SetHelpKeyword(this.txtPhysical, resources.GetString("txtPhysical.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtPhysical, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtPhysical.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtPhysical, resources.GetString("txtPhysical.HelpString"));
            this.txtPhysical.Name = "txtPhysical";
            this.HelpProvider1.SetShowHelp(this.txtPhysical, ((bool)(resources.GetObject("txtPhysical.ShowHelp"))));
            this.txtPhysical.Tag = "Line Reference";
            // 
            // txtOnOrder
            // 
            resources.ApplyResources(this.txtOnOrder, "txtOnOrder");
            this.txtOnOrder.BackColor = System.Drawing.SystemColors.Control;
            this.txtOnOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HelpProvider1.SetHelpKeyword(this.txtOnOrder, resources.GetString("txtOnOrder.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtOnOrder, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtOnOrder.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtOnOrder, resources.GetString("txtOnOrder.HelpString"));
            this.txtOnOrder.Name = "txtOnOrder";
            this.HelpProvider1.SetShowHelp(this.txtOnOrder, ((bool)(resources.GetObject("txtOnOrder.ShowHelp"))));
            this.txtOnOrder.Tag = "Line Reference";
            // 
            // txtDisAmt
            // 
            resources.ApplyResources(this.txtDisAmt, "txtDisAmt");
            this.txtDisAmt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HelpProvider1.SetHelpKeyword(this.txtDisAmt, resources.GetString("txtDisAmt.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtDisAmt, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtDisAmt.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtDisAmt, resources.GetString("txtDisAmt.HelpString"));
            this.txtDisAmt.Name = "txtDisAmt";
            this.HelpProvider1.SetShowHelp(this.txtDisAmt, ((bool)(resources.GetObject("txtDisAmt.ShowHelp"))));
            this.txtDisAmt.Tag = "Discount Amount";
            this.txtDisAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDisAmt_KeyDown);
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.HelpProvider1.SetHelpKeyword(this.Label7, resources.GetString("Label7.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label7, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label7.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label7, resources.GetString("Label7.HelpString"));
            this.Label7.Name = "Label7";
            this.HelpProvider1.SetShowHelp(this.Label7, ((bool)(resources.GetObject("Label7.ShowHelp"))));
            this.Label7.Tag = "Amount";
            // 
            // txtCost
            // 
            resources.ApplyResources(this.txtCost, "txtCost");
            this.txtCost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HelpProvider1.SetHelpKeyword(this.txtCost, resources.GetString("txtCost.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtCost, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtCost.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtCost, resources.GetString("txtCost.HelpString"));
            this.txtCost.Name = "txtCost";
            this.HelpProvider1.SetShowHelp(this.txtCost, ((bool)(resources.GetObject("txtCost.ShowHelp"))));
            this.txtCost.Tag = "Cost";
            this.txtCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCost_KeyDown);
            // 
            // txtDisP
            // 
            resources.ApplyResources(this.txtDisP, "txtDisP");
            this.txtDisP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HelpProvider1.SetHelpKeyword(this.txtDisP, resources.GetString("txtDisP.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtDisP, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtDisP.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtDisP, resources.GetString("txtDisP.HelpString"));
            this.txtDisP.Name = "txtDisP";
            this.HelpProvider1.SetShowHelp(this.txtDisP, ((bool)(resources.GetObject("txtDisP.ShowHelp"))));
            this.txtDisP.Tag = "Discount Percent";
            this.txtDisP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDisP_KeyDown);
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HelpProvider1.SetHelpKeyword(this.txtTotal, resources.GetString("txtTotal.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtTotal, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtTotal.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtTotal, resources.GetString("txtTotal.HelpString"));
            this.txtTotal.Name = "txtTotal";
            this.HelpProvider1.SetShowHelp(this.txtTotal, ((bool)(resources.GetObject("txtTotal.ShowHelp"))));
            this.txtTotal.Tag = "Line Reference";
            // 
            // txtQTY
            // 
            resources.ApplyResources(this.txtQTY, "txtQTY");
            this.txtQTY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HelpProvider1.SetHelpKeyword(this.txtQTY, resources.GetString("txtQTY.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtQTY, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtQTY.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtQTY, resources.GetString("txtQTY.HelpString"));
            this.txtQTY.Name = "txtQTY";
            this.HelpProvider1.SetShowHelp(this.txtQTY, ((bool)(resources.GetObject("txtQTY.ShowHelp"))));
            this.txtQTY.Tag = "Quantity";
            this.txtQTY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQTY_KeyDown);
            // 
            // HelpProvider1
            // 
            resources.ApplyResources(this.HelpProvider1, "HelpProvider1");
            // 
            // txtUnitofStock
            // 
            resources.ApplyResources(this.txtUnitofStock, "txtUnitofStock");
            this.txtUnitofStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HelpProvider1.SetHelpKeyword(this.txtUnitofStock, resources.GetString("txtUnitofStock.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtUnitofStock, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtUnitofStock.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtUnitofStock, resources.GetString("txtUnitofStock.HelpString"));
            this.txtUnitofStock.Name = "txtUnitofStock";
            this.txtUnitofStock.ReadOnly = true;
            this.HelpProvider1.SetShowHelp(this.txtUnitofStock, ((bool)(resources.GetObject("txtUnitofStock.ShowHelp"))));
            this.txtUnitofStock.TabStop = false;
            this.txtUnitofStock.Tag = "D/C";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.HelpProvider1.SetHelpKeyword(this.Label5, resources.GetString("Label5.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label5, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label5.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label5, resources.GetString("Label5.HelpString"));
            this.Label5.Name = "Label5";
            this.HelpProvider1.SetShowHelp(this.Label5, ((bool)(resources.GetObject("Label5.ShowHelp"))));
            this.Label5.Tag = "Second Commonts";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.HelpProvider1.SetHelpKeyword(this.Label1, resources.GetString("Label1.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.Label1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Label1.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.Label1, resources.GetString("Label1.HelpString"));
            this.Label1.Name = "Label1";
            this.HelpProvider1.SetShowHelp(this.Label1, ((bool)(resources.GetObject("Label1.ShowHelp"))));
            this.Label1.Tag = "Second Commonts";
            // 
            // txtUnitOfPurchase
            // 
            resources.ApplyResources(this.txtUnitOfPurchase, "txtUnitOfPurchase");
            this.txtUnitOfPurchase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HelpProvider1.SetHelpKeyword(this.txtUnitOfPurchase, resources.GetString("txtUnitOfPurchase.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.txtUnitOfPurchase, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txtUnitOfPurchase.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.txtUnitOfPurchase, resources.GetString("txtUnitOfPurchase.HelpString"));
            this.txtUnitOfPurchase.Name = "txtUnitOfPurchase";
            this.HelpProvider1.SetShowHelp(this.txtUnitOfPurchase, ((bool)(resources.GetObject("txtUnitOfPurchase.ShowHelp"))));
            this.txtUnitOfPurchase.Tag = "Unit Purchase";
            this.txtUnitOfPurchase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitOfPurchase_KeyDown);
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
            // BTN_U_PURCHASE
            // 
            resources.ApplyResources(this.BTN_U_PURCHASE, "BTN_U_PURCHASE");
            this.HelpProvider1.SetHelpKeyword(this.BTN_U_PURCHASE, resources.GetString("BTN_U_PURCHASE.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.BTN_U_PURCHASE, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("BTN_U_PURCHASE.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.BTN_U_PURCHASE, resources.GetString("BTN_U_PURCHASE.HelpString"));
            this.BTN_U_PURCHASE.ImageList = this.ImageList1;
            this.BTN_U_PURCHASE.Name = "BTN_U_PURCHASE";
            this.HelpProvider1.SetShowHelp(this.BTN_U_PURCHASE, ((bool)(resources.GetObject("BTN_U_PURCHASE.ShowHelp"))));
            this.BTN_U_PURCHASE.TabStop = false;
            this.BTN_U_PURCHASE.UseVisualStyleBackColor = true;
            this.BTN_U_PURCHASE.Click += new System.EventHandler(this.BTN_U_PURCHASE_Click);
            // 
            // btnItem_Code
            // 
            resources.ApplyResources(this.btnItem_Code, "btnItem_Code");
            this.HelpProvider1.SetHelpKeyword(this.btnItem_Code, resources.GetString("btnItem_Code.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.btnItem_Code, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnItem_Code.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.btnItem_Code, resources.GetString("btnItem_Code.HelpString"));
            this.btnItem_Code.ImageList = this.ImageList1;
            this.btnItem_Code.Name = "btnItem_Code";
            this.HelpProvider1.SetShowHelp(this.btnItem_Code, ((bool)(resources.GetObject("btnItem_Code.ShowHelp"))));
            this.btnItem_Code.TabStop = false;
            this.btnItem_Code.UseVisualStyleBackColor = true;
            this.btnItem_Code.Click += new System.EventHandler(this.btnItem_Code_Click);
            // 
            // btnLoc_Code
            // 
            resources.ApplyResources(this.btnLoc_Code, "btnLoc_Code");
            this.HelpProvider1.SetHelpKeyword(this.btnLoc_Code, resources.GetString("btnLoc_Code.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this.btnLoc_Code, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnLoc_Code.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this.btnLoc_Code, resources.GetString("btnLoc_Code.HelpString"));
            this.btnLoc_Code.ImageList = this.ImageList1;
            this.btnLoc_Code.Name = "btnLoc_Code";
            this.HelpProvider1.SetShowHelp(this.btnLoc_Code, ((bool)(resources.GetObject("btnLoc_Code.ShowHelp"))));
            this.btnLoc_Code.TabStop = false;
            this.btnLoc_Code.UseVisualStyleBackColor = true;
            this.btnLoc_Code.Click += new System.EventHandler(this.btnLoc_Code_Click);
            // 
            // ADDSIPOPURCHASEORDER_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtStockQ);
            this.Controls.Add(this.dtpE);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.cboPType);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.BTN_U_PURCHASE);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtLoc_Desc);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtItem_Desc);
            this.Controls.Add(this.btnItem_Code);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtItem_Code);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.btnLoc_Code);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtLoc_Code);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtPhysical);
            this.Controls.Add(this.txtOnOrder);
            this.Controls.Add(this.txtDisAmt);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDisP);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.txtUnitofStock);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtUnitOfPurchase);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpProvider1.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.HelpProvider1.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
            this.HelpProvider1.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDSIPOPURCHASEORDER_FRM";
            this.HelpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ADDSIPOPURCHASEORDER_FRM_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtStockQ;
        internal System.Windows.Forms.DateTimePicker dtpE;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.ComboBox cboPType;
        internal System.Windows.Forms.Label lblItemCode;
        internal System.Windows.Forms.Button BTN_U_PURCHASE;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.Label lblLoc;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtLoc_Desc;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtItem_Desc;
        internal System.Windows.Forms.Button btnItem_Code;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtItem_Code;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Button btnLoc_Code;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtLoc_Code;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtSubTotal;
        internal System.Windows.Forms.TextBox txtPhysical;
        internal System.Windows.Forms.TextBox txtOnOrder;
        internal System.Windows.Forms.TextBox txtDisAmt;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtCost;
        internal System.Windows.Forms.TextBox txtDisP;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.TextBox txtQTY;
        internal System.Windows.Forms.HelpProvider HelpProvider1;
        internal System.Windows.Forms.TextBox txtUnitofStock;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtUnitOfPurchase;
        internal System.Windows.Forms.Label Label2;
    }
}