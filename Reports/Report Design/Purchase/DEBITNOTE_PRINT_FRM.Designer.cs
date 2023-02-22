using POS.Reports.Report_Design.Purchase.DataSet1TableAdapters;

namespace POS.Reports.Report_Design.Purchase
{
    partial class DEBITNOTE_PRINT_FRM
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
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.XrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.XrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.XrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.XrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.XrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.XrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
           // this.dataSet11 = new POS.Reports.Report_Design.Purchase.DEBIT_NOTE();
            this.v_DEBITNOTE_PRINTTableAdapter = new POS.Reports.Report_Design.Purchase.DataSet1TableAdapters.V_DEBITNOTE_PRINTTableAdapter();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.XrTable5)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20,
            this.xrLabel17,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13});
            this.Detail.Height = 28;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Cost", "")});
            this.xrLabel20.Location = new System.Drawing.Point(600, 0);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.Size = new System.Drawing.Size(92, 25);
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "xrLabel20";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel17
            // 
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Item Total", "")});
            this.xrLabel17.Location = new System.Drawing.Point(700, 0);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.Size = new System.Drawing.Size(100, 25);
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "xrLabel17";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel15
            // 
            this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Quantity", "")});
            this.xrLabel15.Location = new System.Drawing.Point(508, 0);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.Size = new System.Drawing.Size(92, 25);
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "xrLabel15";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Item Description", "")});
            this.xrLabel14.Location = new System.Drawing.Point(117, 0);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.Size = new System.Drawing.Size(383, 25);
            this.xrLabel14.Text = "xrLabel14";
            // 
            // xrLabel13
            // 
            this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Item Code", "")});
            this.xrLabel13.Location = new System.Drawing.Point(8, 0);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.Size = new System.Drawing.Size(100, 25);
            this.xrLabel13.Text = "xrLabel13";
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
            this.PageFooter.Height = 33;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrLabel10,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.XrTable5,
            this.xrLabel11,
            this.xrLabel9,
            this.xrLabel2,
            this.xrLabel1});
            this.GroupHeader1.Height = 270;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel12
            // 
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Order Date", "")});
            this.xrLabel12.Location = new System.Drawing.Point(642, 100);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.Size = new System.Drawing.Size(158, 25);
            this.xrLabel12.Text = "xrLabel12";
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Order Code", "")});
            this.xrLabel10.Location = new System.Drawing.Point(642, 75);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.Size = new System.Drawing.Size(158, 25);
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrLabel8
            // 
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Supplier Address 5", "")});
            this.xrLabel8.Location = new System.Drawing.Point(8, 217);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.Size = new System.Drawing.Size(250, 25);
            this.xrLabel8.Text = "xrLabel8";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Sup_ Address 1", "")});
            this.xrLabel7.Location = new System.Drawing.Point(8, 117);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.Size = new System.Drawing.Size(250, 25);
            this.xrLabel7.Text = "xrLabel7";
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Supplier Name", "")});
            this.xrLabel6.Location = new System.Drawing.Point(108, 92);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.Size = new System.Drawing.Size(150, 25);
            this.xrLabel6.Text = "xrLabel6";
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Supplier Address 4", "")});
            this.xrLabel5.Location = new System.Drawing.Point(8, 192);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.Size = new System.Drawing.Size(250, 25);
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Supplier Address 3", "")});
            this.xrLabel4.Location = new System.Drawing.Point(8, 167);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.Size = new System.Drawing.Size(250, 25);
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Supplier Address 2", "")});
            this.xrLabel3.Location = new System.Drawing.Point(8, 142);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.Size = new System.Drawing.Size(250, 25);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // XrTable5
            // 
            this.XrTable5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.XrTable5.Location = new System.Drawing.Point(8, 242);
            this.XrTable5.Name = "XrTable5";
            this.XrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.XrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.XrTableRow16});
            this.XrTable5.Size = new System.Drawing.Size(790, 25);
            this.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XrTableRow16
            // 
            this.XrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.XrTableCell16,
            this.XrTableCell17,
            this.XrTableCell19,
            this.XrTableCell20,
            this.XrTableCell18});
            this.XrTableRow16.Name = "XrTableRow16";
            this.XrTableRow16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.XrTableRow16.Size = new System.Drawing.Size(790, 25);
            this.XrTableRow16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XrTableCell16
            // 
            this.XrTableCell16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.XrTableCell16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XrTableCell16.Location = new System.Drawing.Point(0, 0);
            this.XrTableCell16.Name = "XrTableCell16";
            this.XrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrTableCell16.Size = new System.Drawing.Size(100, 25);
            this.XrTableCell16.Text = "Code";
            this.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // XrTableCell17
            // 
            this.XrTableCell17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.XrTableCell17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XrTableCell17.Location = new System.Drawing.Point(100, 0);
            this.XrTableCell17.Name = "XrTableCell17";
            this.XrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrTableCell17.Size = new System.Drawing.Size(392, 25);
            this.XrTableCell17.Text = "Item Description";
            this.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // XrTableCell19
            // 
            this.XrTableCell19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.XrTableCell19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XrTableCell19.Location = new System.Drawing.Point(492, 0);
            this.XrTableCell19.Name = "XrTableCell19";
            this.XrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrTableCell19.Size = new System.Drawing.Size(100, 25);
            this.XrTableCell19.Text = "Quantity";
            this.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // XrTableCell20
            // 
            this.XrTableCell20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.XrTableCell20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XrTableCell20.Location = new System.Drawing.Point(592, 0);
            this.XrTableCell20.Name = "XrTableCell20";
            this.XrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrTableCell20.Size = new System.Drawing.Size(88, 25);
            this.XrTableCell20.Text = "Unit Price";
            this.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // XrTableCell18
            // 
            this.XrTableCell18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.XrTableCell18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XrTableCell18.Location = new System.Drawing.Point(680, 0);
            this.XrTableCell18.Name = "XrTableCell18";
            this.XrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrTableCell18.Size = new System.Drawing.Size(110, 25);
            this.XrTableCell18.Text = "Amount";
            this.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.Location = new System.Drawing.Point(517, 100);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.Size = new System.Drawing.Size(117, 25);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "Issue Date :";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.Location = new System.Drawing.Point(517, 75);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.Size = new System.Drawing.Size(117, 25);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Invoice Issue :";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.Location = new System.Drawing.Point(325, 8);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.Size = new System.Drawing.Size(100, 25);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Debit Note";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.Location = new System.Drawing.Point(8, 92);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.Size = new System.Drawing.Size(100, 25);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Return To :";
            // 
            // dataSet11
            // 
            //this.dataSet11.DataSetName = "DataSet1";
            //this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DEBITNOTE_PRINTTableAdapter
            // 
            this.v_DEBITNOTE_PRINTTableAdapter.ClearBeforeFill = true;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Height = 0;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel19,
            this.xrLabel18});
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel18.Location = new System.Drawing.Point(583, 8);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.Size = new System.Drawing.Size(67, 25);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.Text = "Total :";
            // 
            // xrLabel19
            // 
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_DEBITNOTE_PRINT.Item Total", "")});
            this.xrLabel19.Location = new System.Drawing.Point(675, 8);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.Size = new System.Drawing.Size(125, 25);
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel19.Summary = xrSummary1;
            this.xrLabel19.Text = "xrLabel19";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.Location = new System.Drawing.Point(0, 0);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Size = new System.Drawing.Size(800, 9);
            // 
            // DEBITNOTE_PRINT_FRM
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.GroupHeader1,
            this.GroupFooter1,
            this.ReportFooter});
            this.DataAdapter = this.v_DEBITNOTE_PRINTTableAdapter;
            this.DataMember = "V_DEBITNOTE_PRINT";
            //this.DataSource = this.dataSet11;
            this.Margins = new System.Drawing.Printing.Margins(22, 27, 100, 100);
            this.Version = "8.3";
            ((System.ComponentModel.ISupportInitialize)(this.XrTable5)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        internal DevExpress.XtraReports.UI.XRTable XrTable5;
        internal DevExpress.XtraReports.UI.XRTableRow XrTableRow16;
        internal DevExpress.XtraReports.UI.XRTableCell XrTableCell16;
        internal DevExpress.XtraReports.UI.XRTableCell XrTableCell17;
        internal DevExpress.XtraReports.UI.XRTableCell XrTableCell19;
        internal DevExpress.XtraReports.UI.XRTableCell XrTableCell20;
        internal DevExpress.XtraReports.UI.XRTableCell XrTableCell18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        //private DEBIT_NOTE dataSet11;
        private V_DEBITNOTE_PRINTTableAdapter v_DEBITNOTE_PRINTTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
    }
}
