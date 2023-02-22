namespace POS.Reports.Inventory_Movement
{
    partial class INVENTORY_TRANSFER_RPT
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.inventorY_TRANSFER_DT1 = new POS.Reports.Inventory_Movement.INVENTORY_TRANSFER_DT();
            this.sELECT_INVENTORY_TRANSFERTableAdapter = new POS.Reports.Inventory_Movement.INVENTORY_TRANSFER_DTTableAdapters.SELECT_INVENTORY_TRANSFERTableAdapter();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorY_TRANSFER_DT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.Height = 25;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.Location = new System.Drawing.Point(0, 0);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.Size = new System.Drawing.Size(808, 25);
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Size = new System.Drawing.Size(808, 25);
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SELECT_INVENTORY_TRANSFER.Location", "")});
            this.xrTableCell8.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Size = new System.Drawing.Size(117, 25);
            this.xrTableCell8.Text = "xrTableCell8";
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SELECT_INVENTORY_TRANSFER.Movement Reference", "")});
            this.xrTableCell9.Location = new System.Drawing.Point(117, 0);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Size = new System.Drawing.Size(100, 25);
            this.xrTableCell9.Text = "xrTableCell9";
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SELECT_INVENTORY_TRANSFER.Movement Date", "{0:MM/dd/yyyy}")});
            this.xrTableCell10.Location = new System.Drawing.Point(217, 0);
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Size = new System.Drawing.Size(100, 25);
            this.xrTableCell10.Text = "xrTableCell10";
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SELECT_INVENTORY_TRANSFER.Item Code", "")});
            this.xrTableCell11.Location = new System.Drawing.Point(317, 0);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Size = new System.Drawing.Size(117, 25);
            this.xrTableCell11.Text = "xrTableCell11";
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SELECT_INVENTORY_TRANSFER.Item Description", "")});
            this.xrTableCell12.Location = new System.Drawing.Point(434, 0);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Size = new System.Drawing.Size(187, 25);
            this.xrTableCell12.Text = "xrTableCell12";
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SELECT_INVENTORY_TRANSFER.Report Covert Unit", "")});
            this.xrTableCell13.Location = new System.Drawing.Point(621, 0);
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Size = new System.Drawing.Size(93, 25);
            this.xrTableCell13.Text = "xrTableCell13";
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SELECT_INVENTORY_TRANSFER.Report Convert  Quantity", "")});
            this.xrTableCell14.Location = new System.Drawing.Point(714, 0);
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Size = new System.Drawing.Size(94, 25);
            this.xrTableCell14.Text = "xrTableCell14";
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 30;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
            this.PageFooter.Height = 25;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Location = new System.Drawing.Point(758, 0);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.Size = new System.Drawing.Size(50, 25);
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.xrLabel2,
            this.xrLabel1});
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable1
            // 
            this.xrTable1.Location = new System.Drawing.Point(0, 75);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.Size = new System.Drawing.Size(808, 25);
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell3,
            this.xrTableCell6,
            this.xrTableCell7});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Size = new System.Drawing.Size(808, 25);
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Size = new System.Drawing.Size(117, 25);
            this.xrTableCell1.Text = "Location Code";
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Location = new System.Drawing.Point(117, 0);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Size = new System.Drawing.Size(100, 25);
            this.xrTableCell2.Text = "Reference";
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Location = new System.Drawing.Point(217, 0);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Size = new System.Drawing.Size(100, 25);
            this.xrTableCell4.Text = "Date";
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Location = new System.Drawing.Point(317, 0);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Size = new System.Drawing.Size(117, 25);
            this.xrTableCell5.Text = "Item Code";
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Location = new System.Drawing.Point(434, 0);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Size = new System.Drawing.Size(187, 25);
            this.xrTableCell3.Text = "Item Description";
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Location = new System.Drawing.Point(621, 0);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Size = new System.Drawing.Size(93, 25);
            this.xrTableCell6.Text = "Unit";
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Location = new System.Drawing.Point(714, 0);
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Size = new System.Drawing.Size(94, 25);
            this.xrTableCell7.Text = "Quantity";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Location = new System.Drawing.Point(0, 26);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.Size = new System.Drawing.Size(808, 25);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Transfer In / Out";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Location = new System.Drawing.Point(0, 0);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.Size = new System.Drawing.Size(808, 25);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Company Name";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // inventorY_TRANSFER_DT1
            // 
            this.inventorY_TRANSFER_DT1.DataSetName = "INVENTORY_TRANSFER_DT";
            this.inventorY_TRANSFER_DT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sELECT_INVENTORY_TRANSFERTableAdapter
            // 
            this.sELECT_INVENTORY_TRANSFERTableAdapter.ClearBeforeFill = true;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.GroupFooter1.Height = 33;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrTable3
            // 
            this.xrTable3.Location = new System.Drawing.Point(0, 0);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.Size = new System.Drawing.Size(808, 33);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Size = new System.Drawing.Size(808, 33);
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Size = new System.Drawing.Size(717, 33);
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.Text = "Total";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SELECT_INVENTORY_TRANSFER.Report Convert  Quantity", "{0:#.00}")});
            this.xrTableCell17.Location = new System.Drawing.Point(717, 0);
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Size = new System.Drawing.Size(91, 33);
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:$0.00}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell17.Summary = xrSummary1;
            this.xrTableCell17.Text = "xrTableCell17";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // INVENTORY_TRANSFER_RPT
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.GroupHeader1,
            this.GroupFooter1});
            this.DataAdapter = this.sELECT_INVENTORY_TRANSFERTableAdapter;
            this.DataMember = "SELECT_INVENTORY_TRANSFER";
            this.DataSource = this.inventorY_TRANSFER_DT1;
            this.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            this.Version = "8.3";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorY_TRANSFER_DT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private INVENTORY_TRANSFER_DT inventorY_TRANSFER_DT1;
        private POS.Reports.Inventory_Movement.INVENTORY_TRANSFER_DTTableAdapters.SELECT_INVENTORY_TRANSFERTableAdapter sELECT_INVENTORY_TRANSFERTableAdapter;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
    }
}
