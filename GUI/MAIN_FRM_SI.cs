using DevExpress.XtraBars;
using DevExpress.XtraBars.Localization;
using POS.DataLayer;
using POS.GUI.Discount;
using POS.GUI.Inventory;
using POS.GUI.Maintains;
using POS.GUI.POS;
using POS.GUI.Purchases;
using POS.GUI.SaleProcessing;
using POS.GUI.User;
using POS.Reports;
using POS.Reports.Inventory_Movement;
using POS.Reports.Movement_Listing;
using POS.Reports.Purchase;
using POS.Reports.Sale_Report;
using POS.Reports.Supplier;
using POS.Transaction.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.GUI
{
    public partial class MAIN_FRM_SI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region PRIVATE VARIABLE

        private const string posName = "S.I Inventory System";
        Connection.Connection connection = new Connection.Connection();
        private bool ISLOG_OFF = false;
        DataManager _dataManager = new DataManager();
        #endregion

        public MAIN_FRM_SI()
        {
            InitializeComponent();
        }

        #region PRIVATE FUNCTION

        private void LogOFF()
        {
            //var command = new SqlCommand("SI_UPDATE_SIUSERS_LOG", connection.Connect());
            //Commands.CreateParameter(command, "USER_CODE", UserLogOn.Code, "USER_LOG",
            //                         System.Text.Encoding.UTF32.GetBytes("U"));
            //command.CommandType = CommandType.StoredProcedure;
            //command.ExecuteNonQuery();
        }

        protected void OpenForm(Form openForm)
        {
            this.Text = openForm.Text + " - " + posName;
            openForm.Show();
            openForm.Closed += (sd, ev) => { Text = posName; };
        }

    //    #endregion


        private void MAIN_FRM_SI_Load(object sender, EventArgs e)
        {
            barStaticItemUserCode.Caption = UserLogOn.Code;
            barStaticItemUserName.Caption = UserLogOn.Name;
            barStaticItemPeroid.Caption = UserLogOn.Date.ToShortDateString();

          //  #region Permission

            //            ======================= Permission ==============
            var permissionFrm = new PERMISSION_FRM();
            var dt = new DataTable();
            var dataManager = new DataManager();

         //   #region File
            if (UserLogOn.Code != "SISA")
            {
                //                ================= 
                var isTrue = new bool[2];
                foreach (ListViewItem lvw in permissionFrm.SYSTEMLVWMAIN.Items)
                {
                    dt = new DataTable();
                    dt =
                        dataManager.GetData("SELECT * FROM (SELECT GR_DB_CODE FROM dbo.SIPUSERG WHERE USER_CODE='" + UserLogOn.Code +
                                            "' AND PER_TYPE='V' UNION SELECT DISTINCT GR_DB_CODE FROM dbo.SIPUSERG WHERE PER_TYPE='V' " +
                                            "AND USER_CODE IN(SELECT GR_DB_CODE FROM dbo.SIPUSERG WHERE " +
                                           " USER_CODE='" + UserLogOn.Code +
                                            "' AND PER_TYPE='G')) M WHERE M.GR_DB_CODE='" + lvw.Text + "'");
                    if (dt.Rows.Count == 0)
                    {
                        switch (lvw.Text)
                        {
                            case "Groups Management":
                               // ribbonPageGroupFileManagement.ItemLinks.Remove(buttonBarItemGroupManagement);
                                isTrue[0] = true;
                                break;
                            case "Users Management":
                               // ribbonPageGroupFileManagement.ItemLinks.Remove(buttonBarItemUsersManagement);
                                isTrue[1] = true;
                                break;
                        }
                    }
                }
                if (isTrue.All(p => p))
                {
                   // ribbonPageFile.Groups.Remove(ribbonPageGroupFileManagement);
                }
           //     #endregion


          //      #region Maintains

                var isMaintains = new Boolean[13];
                foreach (ListViewItem item in permissionFrm.MAITAINSLVWMAIN.Items)
                {
                    new DataTable();
                    dt =
                          dataManager.GetData("SELECT * FROM (SELECT GR_DB_CODE FROM dbo.SIPUSERG WHERE USER_CODE='" + UserLogOn.Code +
                                              "' AND PER_TYPE='V' UNION SELECT DISTINCT GR_DB_CODE FROM dbo.SIPUSERG WHERE PER_TYPE='V' " +
                                              "AND USER_CODE IN(SELECT GR_DB_CODE FROM dbo.SIPUSERG WHERE " +
                                             " USER_CODE='" + UserLogOn.Code +
                                              "' AND PER_TYPE='G')) M WHERE M.GR_DB_CODE='" + item.Text + "'");
                    if (dt.Rows.Count == 0)
                    {
                        switch (item.Text)
                        {
                            case "Locations":
                               // ribbonPageGroupLocation.ItemLinks.Remove(buttonBarItemLocationStore);
                                isMaintains[0] = true;
                                break;
                          //  #region Items Setup
                            case "Unit Conversion":
                             //   ribbonPageGroupItemSetup.ItemLinks.Remove(buttonBarItemUnitConverstion);
                                isMaintains[1] = true;
                                break;
                            case "Item Category":
                             //   ribbonPageGroupItemSetup.ItemLinks.Remove(buttonBarItemItemCategory);
                                isMaintains[2] = true;
                                break;
                            case "Item Record":
                             //   ribbonPageGroupItemSetup.ItemLinks.Remove(buttonBarItemItemRecord);
                                isMaintains[3] = true;
                                break;
                            case "Item Price":
                             //   ribbonPageGroupItemSetup.ItemLinks.Remove(buttonBarItemPricesList);
                                isMaintains[4] = true;
                                break;
                            case "Item Promotion":
                              //  ribbonPageGroupItemSetup.ItemLinks.Remove(buttonBarItemItemPromotion);
                                isMaintains[5] = true;
                                break;
                            case "Supplier Setup":
                               // ribbonPageGroupSupplier.ItemLinks.Remove(buttonBarItemSupplierRecords);
                                isMaintains[6] = true;
                                break;
                            case "Deliveries Supplier":
                               // ribbonPageGroupSupplier.ItemLinks.Remove(buttonBarItemSupplierDelivery);
                                isMaintains[7] = true;
                                break;
                            case "Customer Setup":
                              //  ribbonPageGroupCustomer.ItemLinks.Remove(buttonBarItemSetupCustomerInPOS);
                                isMaintains[8] = true;
                                break;
                            case "Deliveries Customer":
                             //   ribbonPageGroupCustomer.ItemLinks.Remove(buttonBarItemCustomerDelivery);
                                isMaintains[9] = true;
                                break;
                            case "Employee Setup":
                            //    ribbonPageGroupEmployee.ItemLinks.Remove(buttonBarItemEmployee);
                                isMaintains[10] = true;
                                break;
                           // #endregion

                            case "Reports Format":
                            //    ribbonPageGroupReport.ItemLinks.Remove(buttonBarItemReportDesign);
                                isMaintains[11] = true;
                                break;
                            case "Options":
                             //   ribbonPageGroupOption.ItemLinks.Remove(buttonBarItemOption);
                                isMaintains[12] = true;
                                break;
                        }
                    }

              //      #region Remove Split line 

              //      #region Items Setup

                    //var isItemSetup = false;

                    //if (isMaintains[1] && isMaintains[2] && isMaintains[3] && isMaintains[4] && isMaintains[5])
                    //{
                    //    ribbonPageMaintain.Groups.Remove(ribbonPageGroupItemSetup);
                    //    isItemSetup = true;
                    //}
                    //#endregion

                    ////if (isMaintains[0] && isItemSetup)
                    ////{
                    ////    MaintainsToolStripMenuItem.DropDownItems.Remove(SplitToolStripMenuItem);
                    ////}

                    //#region Supplier

                    //var isSupplier = false;
                    //if (isMaintains[6] && isMaintains[7])
                    //{
                    //    ribbonPageMaintain.Groups.Remove(ribbonPageGroupSupplier);
                    //    isSupplier = true;
                    //}

                    //#endregion

                    //#region Customer 

                    //var isCustomer = false;
                    //if (isMaintains[8] && isMaintains[9])
                    //{
                    //    ribbonPageMaintain.Groups.Remove(ribbonPageGroupCustomer);
                    //    isCustomer = true;
                    //}

                    //#endregion

                    //if (isMaintains[11] && isMaintains[12])
                    //{
                    //    ribbonPageMaintain.Groups.Remove(ribbonPageGroupReport);
                    //}

                    //if (isMaintains[0] && isItemSetup && isSupplier && isCustomer && isMaintains[10] && isMaintains[11] && isMaintains[12])
                    //{
                    //    ribbonControlMain.Pages.Remove(ribbonPageMaintain);
                    //}



               //     #endregion

                }
             //   #endregion


              //  #region Transactions

                var isTrans = new Boolean[11];

                foreach (ListViewItem item in permissionFrm.TRANSLVWMAIN.Items)
                {
                    new DataTable();
                    dt =
                          dataManager.GetData("SELECT * FROM (SELECT GR_DB_CODE FROM dbo.SIPUSERG WHERE USER_CODE='" + UserLogOn.Code +
                                              "' AND PER_TYPE='V' UNION SELECT DISTINCT GR_DB_CODE FROM dbo.SIPUSERG WHERE PER_TYPE='V' " +
                                              "AND USER_CODE IN(SELECT GR_DB_CODE FROM dbo.SIPUSERG WHERE " +
                                             " USER_CODE='" + UserLogOn.Code +
                                              "' AND PER_TYPE='G')) M WHERE M.GR_DB_CODE='" + item.Text + "'");
                    if (dt.Rows.Count == 0)
                    {
                        switch (item.Text)
                        {

                            case "Purchase Order":
                             //   ribbonPageGroupProccess.ItemLinks.Remove(buttonBarItemPurchaseOrder);
                                isTrans[0] = true;
                                break;
                            case "Purchase Matching":
                              //  ribbonPageGroupProccess.ItemLinks.Remove(buttonBarItemPurchaseInvoice);
                                isTrans[1] = true;
                                break;
                            case "Debit Note":
                             //   ribbonPageGroupProccess.ItemLinks.Remove(buttonBarItemDebitNote);
                                isTrans[2] = true;
                                break;
                            case "Movement Entry":
                              //  ribbonPageGroupInventory.ItemLinks.Remove(buttonBarItemInventoryMovement);
                                isTrans[3] = true;
                                break;
                            case "Inventory Balance":
                             //   ribbonPageGroupInventory.ItemLinks.Remove(buttonBarItemInventoryBalance);
                                isTrans[4] = true;
                                break;
                            case "Stock Adjustment":
                             //   ribbonPageGroupInventory.ItemLinks.Remove(buttonBarItemStockAdjustment);
                                isTrans[5] = true;
                                break;
                            case "Sale Invoice":
                            //    ribbonPageGroupSaleOrder.ItemLinks.Remove(buttonBarItemSalesOrder);
                                isTrans[6] = true;
                                break;
                            case "Credit Note":
                            //    ribbonPageGroupSaleOrder.ItemLinks.Remove(buttonBarItemCraditNote);
                                isTrans[7] = true;
                                break;
                            case "Bar Code":
                             //   ribbonPageGroupPointOfSale.ItemLinks.Remove(buttonBarItemBarcodeSales);
                                isTrans[8] = true;
                                break;
                            case "Exchange Rate":
                            //    ribbonPageGroupPointOfSale.ItemLinks.Remove(buttonBarItemExchangeRate);
                                isTrans[9] = true;
                                break;
                            case "Setup Customer In POS":
                             //   ribbonPageGroupPointOfSale.ItemLinks.Remove(buttonBarItemSetupCustomerInPOS);
                                isTrans[10] = true;
                                break;

                        }
                    }

                    //==============  remove split line ======
//
                 //   #region Purchase Processing

                    //var isPurProcess = false;
                    //if (isTrans[0] && isTrans[1] && isTrans[2])
                    //{
                    //    ribbonPageTransaction.Groups.Remove(ribbonPageGroupProccess);
                    //    isPurProcess = true;
                    //}

                    //#endregion

                    //#region Inventory Controls

                    //var InvCtr = false;


                    //if (isTrans[3] && isTrans[4] && isTrans[5])
                    //{
                    //    ribbonPageTransaction.Groups.Remove(ribbonPageGroupInventory);
                    //    InvCtr = true;
                    //}


                    //#endregion

                    //#region Sale Processing

                    //var isSaleProces = false;

                    //if (isTrans[6] && isTrans[7])
                    //{
                    //    ribbonPageTransaction.Groups.Remove(ribbonPageGroupSaleOrder);
                    //    isSaleProces = true;
                    //}
                //    #endregion

                //    #region Point of Sale

                 //   var isPOS = false;
                 //   if (isTrans[8] && isTrans[9] && isTrans[10])
                 //   {
                 //       ribbonPageTransaction.Groups.Remove(ribbonPageGroupPointOfSale);
                 //       isPOS = true;
                 //   }

                 ////   #endregion

                 //   if (isPOS && isSaleProces && isPurProcess && InvCtr)
                 //   {
                 //       ribbonControlMain.Pages.Remove(ribbonPageTransaction);
                 //   }

                }
               // #endregion


               // #region Reports

                var isReports = new Boolean[9];

              //  #region remove sub item in menu Reports

                foreach (ListViewItem item in permissionFrm.REPORTLVWMAIN.Items)
                {

                    new DataTable();
                    dt =
                        dataManager.GetData("SELECT * FROM (SELECT GR_DB_CODE FROM dbo.SIPUSERG WHERE USER_CODE='" +
                                            UserLogOn.Code +
                                            "' AND PER_TYPE='V' UNION SELECT DISTINCT GR_DB_CODE FROM dbo.SIPUSERG WHERE PER_TYPE='V' " +
                                            "AND USER_CODE IN(SELECT GR_DB_CODE FROM dbo.SIPUSERG WHERE " +
                                            " USER_CODE='" + UserLogOn.Code +
                                            "' AND PER_TYPE='G')) M WHERE M.GR_DB_CODE='" + item.Text + "'");
                    if (dt.Rows.Count == 0)
                    {
                        switch (item.Text)
                        {
                            case "Purchase Listing":
                             //   ribbonPageGroupSalePurchaseReport.ItemLinks.Remove(buttonBarItemPurchaseListing);
                                isReports[0] = true;
                                break;
                            case "Supplier Listing":
                              //  ribbonPageGroupSalePurchaseReport.ItemLinks.Remove(buttonBarItemSupplierListing);
                                isReports[1] = true;
                                break;
                            case "Sale Listing":
                              //  ribbonPageGroupSaleOrderReport.ItemLinks.Remove(buttonBarItemReportSaleListing);
                                isReports[2] = true;
                                break;
                            case "Customer Listing":
                              ///  ribbonPageGroupSaleOrderReport.ItemLinks.Remove(buttonBarItemReportCustomerListing);
                                isReports[3] = true;
                                break;
                            case "Print Barcode":
                              //  ribbonPageGroupSaleOrderReport.ItemLinks.Remove(buttonBarItemReportBarcode);
                                isReports[4] = true;
                                break;
                            case "Movement Listing":
                               // ribbonPageGroupInventoryReport.ItemLinks.Remove(buttonBarItemMovementListing);
                                isReports[5] = true;
                                break;
                            case "Inventory Listing":
                               // ribbonPageGroupInventoryReport.ItemLinks.Remove(buttonBarItemInventoryListing);
                                isReports[6] = true;
                                break;
                            case "Inventory Movement":
                               // ribbonPageGroupInventoryReport.ItemLinks.Remove(buttonBarItemInventoryMovement);
                                isReports[7] = true;
                                break;
                            case "Inventory Transfer":
                                //ribbonPageGroupInventoryReport.ItemLinks.Remove(buttonBarItemInventoryTransfer);
                                isReports[8] = true;
                                break;

                        }
                    }
                }
                //#endregion

                //#region Remove main item in Menu Report

                //var isPurchaseRpt = false;
                //if (isReports[0] && isReports[1])
                //{
                //    ribbonPageReport.Groups.Remove(ribbonPageGroupSalePurchaseReport);
                //    isPurchaseRpt = true;
                //}
                //var isSaleRpt = false;
                //if (isReports[2] && isReports[3] && isReports[4])
                //{
                //    ribbonPageReport.Groups.Remove(ribbonPageGroupInventoryReport);
                //    isSaleRpt = true;
                //}

                //var isInventoryRpt = false;
                //if (isReports[5] && isReports[6] && isReports[7] && isReports[8])
                //{
                //    ribbonPageReport.Groups.Remove(ribbonPageGroupSaleOrderReport);
                //    isInventoryRpt = true;
                //}

                //if (isPurchaseRpt && isInventoryRpt && isSaleRpt)
                //{
                //    ribbonControlMain.Pages.Remove(ribbonPageReport);
                //}

                //#endregion
                //#endregion


            }
            #endregion
        }

        private void buttonBarItemLanguageEnglish_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }

        private void buttonBarItemKhmer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("km-KH");

            this.Controls.Clear();
            InitializeComponent();
        }

        private void buttonBarItemLocationStore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var locationFrm = new LOCATION_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(locationFrm);
        }

        private void buttonBarItemGroupManagement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var groupFrm = new GROUP_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(groupFrm);
        }

        private void buttonBarItemUsersManagement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var openForm = new USER_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(openForm);
        }

        private void buttonBarItemPurchaseOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sipopurchaseorderFrm = new SIPOPURCHASEORDER_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(sipopurchaseorderFrm);
        }

        private void buttonBarItemPurchaseInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sipopurchasematchingFrm = new SIPOPURCHASEMATCHING_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(sipopurchasematchingFrm);
        }

        private void buttonBarItemDebitNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sidebitNoteFrm = new SIDEBIT_NOTE_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(sidebitNoteFrm);
        }

        private void buttonBarItemInventoryTransfer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var simovementlineFrm = new SIMOVEMENTLINE_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(simovementlineFrm);

        }

        private void buttonBarItemStockAdjustment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var stockaddjustmentFrm = new STOCKADDJUSTMENT_FRM { MdiParent = this };
            OpenForm(stockaddjustmentFrm);

        }

        private void buttonBarItemInventoryBalance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sibalancestock = new SIBALANCESTOCK { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(sibalancestock);

        }

        private void buttonBarItemSalesOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var saleprocessing = new SALEPROCESSING_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(saleprocessing);
        }

        private void buttonBarItemCraditNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var creditnoteFrm = new CREDITNOTE_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(creditnoteFrm);

        }

        private void buttonBarItemExchangeRate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var exchangerateFrm = new EXCHANGERATE_FRM { MdiParent = this };
            OpenForm(exchangerateFrm);

        }

        private void buttonBarItemSetupCustomerInPOS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var setupLocationCustomerPOS = new SetupLocationCustomerPos { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(setupLocationCustomerPOS);

        }

        private void buttonBarItemUnitConverstion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var unitCovert = new SIUNITCONVERT_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(unitCovert);

        }

        private void buttonBarItemItemCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var progressbarFrm = new PROGRESSBAR_FRM();
            var sicatFrm = new SICAT_FRM(progressbarFrm) { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(sicatFrm);

        }

        private void buttonBarItemItemRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var siitemsFrm = new SIITEMS_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(siitemsFrm);

        }

        private void buttonItemPricesList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var siitemsFrm = new SIITEMS_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(siitemsFrm);

        }

        private void buttonBarItemItemPromotion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var siposdiscountFrm = new SIPOSDISCOUNT_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(siposdiscountFrm);

        }

        private void buttonBarItemSupplierDelivery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sisupdeliveryFrm = new SISUPDELIVERY_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(sisupdeliveryFrm);

        }

        private void buttonBarItemSupplierRecords_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sisupplierFrm = new SISUPPLIER_FRM { MdiParent = this, WindowState = FormWindowState.Maximized, Dock = DockStyle.Fill };
            OpenForm(sisupplierFrm);
        }

        private void buttonBarItemEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var siemployeeFrm = new SIEMPLOYEE_FRM { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(siemployeeFrm);
        }

        private void buttonBarItemReportConverstion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var reportUnitConversion = new ReportUnitConversion { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(reportUnitConversion);

        }

        private void buttonBarItemReportDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var reportFrm = new ReportFrm { MdiParent = this, Dock = DockStyle.Fill };
            OpenForm(reportFrm);
        }

        private void buttonBarItemOption_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sioptions_FRM = new SIOPTIONS_FRM { MdiParent = this };
            sioptions_FRM.Show();
        }

        private void buttonBarItemPurchaseListing_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var purchaselistingFrm = new PURCHASELISTING_FRM { MdiParent = this };
            OpenForm(purchaselistingFrm);

        }

        private void buttonBarItemSupplierListing_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var supplierListing = new SUPPLIER_LISTING { MdiParent = this };
            OpenForm(supplierListing);

        }

        private void buttonBarItemMovementListing_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var movementListingFrm = new MOVEMENT_LISTING_FRM { MdiParent = this };
            OpenForm(movementListingFrm);

        }

        private void buttonBarItemInventoryMovement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var inventory = new INVENTORY_MOVEMENT_FRM { MdiParent = this };
            OpenForm(inventory);

        }

        private void buttonBarItemInventoryListing_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var inventoryListing = new INVENTORY_LISTING { MdiParent = this };
            OpenForm(inventoryListing);

        }

        private void buttonBarItemReportInventoryTransfer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var inventoryTransfer = new InventoryTransfer { MdiParent = this };
            OpenForm(inventoryTransfer);

        }

        private void buttonBarItemReportSaleListing_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var saleListing = new SALE_LISTING { MdiParent = this };
            OpenForm(saleListing);

        }

        private void buttonBarItemReportCustomerListing_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var inventoryTransfer = new InventoryTransfer { MdiParent = this };
            OpenForm(inventoryTransfer);

        }

        private void buttonBarItemReportBarcode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var printBarcode = new PRINT_BARCODE { MdiParent = this };
            printBarcode.Show();

        }

        private void MAIN_FRM_SI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ISLOG_OFF == false)
            {
                try
                {
                    LogOFF();
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBarItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBarItemLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("km-KH");
            this.Controls.Clear();
            InitializeComponent();

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            this.Controls.Clear();
            InitializeComponent();

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            var relogin = new LOGIN_FRM();
            relogin.ShowDialog();
        }
    }
}
