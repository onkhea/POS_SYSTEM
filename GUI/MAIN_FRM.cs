using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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
using POS.Transaction;
using POS.Transaction.Security;

namespace POS.GUI
{
    public partial class MAIN_FRM : DevComponents.DotNetBar.Office2007Form
    {
        public MAIN_FRM()
        {
            InitializeComponent();
        }
        Connection.Connection connection = new Connection.Connection();
        private bool ISLOG_OFF = false;
        DataManager _dataManager = new DataManager();
        private string posName = "S.I Inventory System";
        private void MAIN_FRM_Load(object sender, EventArgs e)
        {
            ToolStripStatusLabel3.Text = UserLogOn.Code;
            ToolStripStatusLabel4.Text = UserLogOn.Name;
            ToolStripStatusLabel2.Text = UserLogOn.Date.ToShortDateString();

//            ======================= Permission ==============
            var permissionFrm = new PERMISSION_FRM();
            var dt = new DataTable();
            var dataManager = new DataManager();

            #region File
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
                                FileToolStripMenuItem2.DropDownItems.Remove(GroupManagementToolStripMenuItem);
                                isTrue[0] = true;
                                break;
                            case "Users Management":
                                FileToolStripMenuItem2.DropDownItems.Remove(UserToolStripItem);
                                isTrue[1] = true;
                                break;
                        }
                    }
                }
                if (isTrue[0] && isTrue[1])
                {
                    FileToolStripMenuItem2.DropDownItems.Remove(ToolStripMenuItem3);
                }

#endregion

            #region Maintains

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
                                MaintainsToolStripMenuItem.DropDownItems.Remove(LocationStoreToolStripMenuItem);
                                isMaintains[0] = true;
                                break;
                            #region Items Setup
                            case "Unit Conversion":
                                ItemsSetupToolStripMenuItem.DropDownItems.Remove(UnitConverToolStripMenuItem);
                                isMaintains[1] = true;
                                break;
                            case "Item Category":
                                ItemsSetupToolStripMenuItem.DropDownItems.Remove(CategorySetupToolStripMenuItem);
                                isMaintains[2] = true;
                                break;
                            case "Item Record":
                                ItemsSetupToolStripMenuItem.DropDownItems.Remove(ItemSetupToolStripMenuItem);
                                isMaintains[3] = true;
                                break;
                            case "Item Price":
                                ItemsSetupToolStripMenuItem.DropDownItems.Remove(ItemPricesToolStripMenuItem);
                                isMaintains[4] = true;
                                break;
                            case "Item Promotion":
                                ItemsSetupToolStripMenuItem.DropDownItems.Remove(HappyToolStripMenuItem);
                                isMaintains[5] = true;
                                break;
                            case "Supplier Setup":
                                SupplierSetupToolStripMenuItem.DropDownItems.Remove(SupplierSetupToolStripMenuItem1);
                                isMaintains[6] = true;
                                break;
                            case "Deliveries Supplier":
                                SupplierSetupToolStripMenuItem.DropDownItems.Remove(DeliverySetupToolStripMenuItem1);
                                isMaintains[7] = true;
                                break;
                            case "Customer Setup":
                                CustomerToolStripMenuItem.DropDownItems.Remove(CustomerSetupToolStripMenuItem);
                                isMaintains[8] = true;
                                break;
                            case "Deliveries Customer":
                                CustomerToolStripMenuItem.DropDownItems.Remove(DeliveriesSetupToolStripMenuItem);
                                isMaintains[9] = true;
                                break;
                            case "Employee Setup":
                                MaintainsToolStripMenuItem.DropDownItems.Remove(EmployeeToolStrip);
                                isMaintains[10] = true;
                                break;
                            #endregion

                            case "Reports Format":
                                MaintainsToolStripMenuItem.DropDownItems.Remove(DesignReportsToolStripMenuItem);
                                isMaintains[11] = true;
                                break;
                            case "Options":
                                MaintainsToolStripMenuItem.DropDownItems.Remove(OptionsToolStripMenuItem);
                                isMaintains[12] = true;
                                break;
                        }
                    }

                    #region Remove Split line 

                    #region Items Setup

                    var isItemSetup = false;

                    if (isMaintains[1])
                    {
                        MaintainsToolStripMenuItem.DropDownItems.Remove(ToolStripMenuItem2);
                    }
                    if(isMaintains[2]&& isMaintains[3] && isMaintains[4] && isMaintains[5])
                    {
                        MaintainsToolStripMenuItem.DropDownItems.Remove(ToolStripMenuItem2);
                    }
                    if (isMaintains[1] && isMaintains[2] && isMaintains[3] && isMaintains[4] && isMaintains[5])
                    {
                        MaintainsToolStripMenuItem.DropDownItems.Remove(ItemsSetupToolStripMenuItem);
                        isItemSetup = true;
                    }
                    #endregion

                    if (isMaintains[0] && isItemSetup)
                    {
                        MaintainsToolStripMenuItem.DropDownItems.Remove(SplitToolStripMenuItem);
                    }

                    #region Supplier

                    var isSupplier = false;
                    if (isMaintains[6] && isMaintains[7])
                    {
                        MaintainsToolStripMenuItem.DropDownItems.Remove(SupplierSetupToolStripMenuItem);
                        isSupplier = true;
                    }

                    #endregion

                    #region Customer 

                    var isCustomer = false;
                    if (isMaintains[8] && isMaintains[9])
                    {
                        MaintainsToolStripMenuItem.DropDownItems.Remove(CustomerToolStripMenuItem);
                        isCustomer = true;
                    }

                    #endregion

                    if (isMaintains[10] && isCustomer && isSupplier)
                    {
                        MaintainsToolStripMenuItem.DropDownItems.Remove(ToolStripMenuItem6);
                    }

                    if (isMaintains[11] && isMaintains[12])
                    {
                        MaintainsToolStripMenuItem.DropDownItems.Remove(ToolStripMenuItem6);
                    }

                    if (isMaintains[0] && isItemSetup && isSupplier && isCustomer && isMaintains[10] && isMaintains[11] && isMaintains[12])
                    {
                        MenuStrip1.Items.Remove(MaintainsToolStripMenuItem);
                    }

                    

                    #endregion

                }
                #endregion

            #region Transactions

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

                            case  "Purchase Order":
                                PurchaseProcessingToolStripMenuItem.DropDownItems.Remove(PurchaseOrderToolStripMenuItem);
                                isTrans[0] = true;
                                break;
                            case "Purchase Matching":
                                PurchaseProcessingToolStripMenuItem.DropDownItems.Remove(PurchaseMatchingToolStripMenuItem);
                                isTrans[1] = true;
                                break;
                            case "Debit Note":
                                PurchaseProcessingToolStripMenuItem.DropDownItems.Remove(PurchaseDebitToolStripMenuItem);
                                isTrans[2] = true;
                                break;
                            case "Movement Entry":
                                InventoryProcessingToolStripMenuItem.DropDownItems.Remove(MovementImportToolStripMenuItem);
                                isTrans[3] = true;
                                break;
                            case "Inventory Balance":
                                InventoryProcessingToolStripMenuItem.DropDownItems.Remove(InventoryBalanceToolStripMenuItem);
                                isTrans[4] = true;
                                break;
                            case "Stock Adjustment":
                                InventoryProcessingToolStripMenuItem.DropDownItems.Remove(StockAdjToolStripMenuItem);
                                isTrans[5] = true;
                                break;
                            case "Sale Invoice":
                                SalesProcessinToolStripMenuItem.DropDownItems.Remove(SalesOrderToolStripMenuItem);
                                isTrans[6] = true;
                                break;
                            case "Credit Note":
                                SalesProcessinToolStripMenuItem.DropDownItems.Remove(CreditnoteToolStripMenuItem);
                                isTrans[7] = true;
                                break;
                            case "Bar Code":
                                PointOfSaleToolStripMenuItem.DropDownItems.Remove(SaleBarcodeToolStripMenuItem);
                                isTrans[8] = true;
                                break;
                            case "Exchange Rate":
                                PointOfSaleToolStripMenuItem.DropDownItems.Remove(ExchangeRateToolStripMenuItem);
                                isTrans[9] = true;
                                break;
                            case "Setup Customer In POS" :
                                PointOfSaleToolStripMenuItem.DropDownItems.Remove(setupCustomerInPOSToolStripMenuItem);
                                isTrans[10] = true;
                                break;

                        }
                    }

                    //==============  remove split line ======

                    #region Purchase Processing

                    var isPurProcess = false;
                    if (isTrans[0] && isTrans[1])
                    {
                        TransactionToolStripMenuItem17.DropDownItems.Remove(ToolStripMenuItem4);
                    }
                    if (isTrans[0] && isTrans[1] && isTrans[2])
                    {
                        TransactionToolStripMenuItem17.DropDownItems.Remove(PurchaseProcessingToolStripMenuItem);
                        isPurProcess = true;
                    }
                    if (isTrans[2])
                    {
                        PurchaseProcessingToolStripMenuItem.DropDownItems.Remove(ToolStripMenuItem4);
                    }
                    #endregion

                    #region Inventory Controls

                    var InvCtr = false;
                    
                    if (isTrans[3] && isTrans[4])
                    {
                        TransactionToolStripMenuItem17.DropDownItems.Remove(ToolStripMenuItem21);
                    }
                    if (isTrans[5])
                    {
                        InventoryProcessingToolStripMenuItem.DropDownItems.Remove(ToolStripMenuItem21);
                    }

                    if (isTrans[3]&& isTrans[4] && isTrans[5])
                    {
                        TransactionToolStripMenuItem17.DropDownItems.Remove(InventoryProcessingToolStripMenuItem);
                        InvCtr = true;
                    }

                   
                    #endregion

                    #region Sale Processing

                    var isSaleProces = false;

                    if (isTrans[6] && isTrans[7])
                    {
                        TransactionToolStripMenuItem17.DropDownItems.Remove(SalesProcessinToolStripMenuItem);
                        isSaleProces = true;
                    }
                    #endregion

                    #region Point of Sale

                    var isPOS = false;
                    if (isTrans[8] && isTrans[9] && isTrans[10])
                    {
                        TransactionToolStripMenuItem17.DropDownItems.Remove(PointOfSaleToolStripMenuItem);
                        isPOS = true;
                    }

                    if (isTrans[9] || isTrans[8] )
                    {
                        PointOfSaleToolStripMenuItem.DropDownItems.Remove(ToolStripMenuItem8);
                    }

                    #endregion

                    if (isPOS && isSaleProces && isPurProcess && InvCtr)
                    {
                        MenuStrip1.Items.Remove(TransactionToolStripMenuItem17);
                    }

                }

                

                #endregion

            #region Reports

                var isReports = new Boolean[9];

                #region remove sub item in menu Reports

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
                                PurchaseReportsToolStripMenuItem.DropDownItems.Remove(PurchaseListingToolStripMenuItem);
                                isReports[0] = true;
                                break;
                            case "Supplier Listing":
                                PurchaseReportsToolStripMenuItem.DropDownItems.Remove(SupplierListingToolStripMenuItem);
                                isReports[1] = true;
                                break;
                            case "Sale Listing":
                                SaleReportsToolStripMenuItem.DropDownItems.Remove(SalesListingToolStripMenuItem);
                                isReports[2] = true;
                                break;
                            case "Customer Listing" :
                                SaleReportsToolStripMenuItem.DropDownItems.Remove(CustomerListingToolStripMenuItem);
                                isReports[3] = true;
                                break;
                            case "Print Barcode":
                                SaleReportsToolStripMenuItem.DropDownItems.Remove(barCodeToolStripMenuItem);
                                isReports[4] = true;
                                break;
                            case "Movement Listing":
                                InventoryReportsToolStripMenuItem.DropDownItems.Remove(MovementListingToolStripMenuItem1);
                                isReports[5] = true;
                                break;
                            case "Inventory Listing":
                                InventoryReportsToolStripMenuItem.DropDownItems.Remove(InventoryStatusToolStripMenuItem);
                                isReports[6] = true;
                                break;
                            case "Inventory Movement":
                                InventoryReportsToolStripMenuItem.DropDownItems.Remove(InventoryListingToolStripMenuItem);
                                isReports[7] = true;
                                break;
                            case "Inventory Transfer":
                                InventoryReportsToolStripMenuItem.DropDownItems.Remove(InventoryTransferToolStripMenuItem);
                                isReports[8] = true;
                                break;

                        }
                    }
                }
                #endregion

                #region Remove main item in Menu Report

                var isPurchaseRpt = false;
                if (isReports[0] && isReports[1])
                {
                    ReportToolStripMenuItem32.DropDownItems.Remove(PurchaseReportsToolStripMenuItem);
                    isPurchaseRpt = true;
                }
                var isSaleRpt = false;
                if (isReports[2] && isReports[3] && isReports[4])
                {
                    ReportToolStripMenuItem32.DropDownItems.Remove(SaleReportsToolStripMenuItem);
                    isSaleRpt = true;
                }

                var isInventoryRpt = false;
                if (isReports[5]&& isReports[6] && isReports[7] && isReports[8] )
                {
                    ReportToolStripMenuItem32.DropDownItems.Remove(InventoryReportsToolStripMenuItem);
                    isInventoryRpt = true;
                }

                if (isPurchaseRpt && isInventoryRpt && isSaleRpt)
                {
                    MenuStrip1.Items.Remove(ReportToolStripMenuItem32);
                }

                #endregion
            #endregion
            }
        }

        private void GroupManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
          var groupFrm = new GROUP_FRM {MdiParent = this, Dock = DockStyle.Fill};
          this.Text = "";
          this.Text = groupFrm.Text + " - " + posName;
            groupFrm.Show();
            groupFrm.Closed += new EventHandler(groupFrm_Closed);
        }

        void groupFrm_Closed(object sender, EventArgs e)
        {
            this.Text = posName;
        }

        private void UserToolStripItem_Click(object sender, EventArgs e)
        {
            var userFrm =new USER_FRM {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = userFrm.Text + " - " + posName ;
            userFrm.Show();
            userFrm.Closed += new EventHandler(userFrm_Closed);
        }

        void userFrm_Closed(object sender, EventArgs e)
        {
            this.Text = posName;
        }

        private void LogOffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ISLOG_OFF = true;
                LogOFF();
                var loginFrm = new LOGIN_FRM();
                loginFrm.Show();
                Close();
            }

            catch
            {
                
            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LacationStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var locationFrm = new LOCATION_FRM {MdiParent = this};
            this.Text = "";
            this.Text = locationFrm.Text + " - " + posName ;
            locationFrm.Dock = DockStyle.Fill;
            locationFrm.Show();
            locationFrm.Closed += new EventHandler(locationFrm_Closed);

        }

        void locationFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }
        
        private void UnitConverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var unitCovert = new SIUNITCONVERT_FRM {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = unitCovert.Text + " - " + posName ;
            unitCovert.Show();
            unitCovert.Closed += new EventHandler(unitCovert_Closed);
        }

        void unitCovert_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void CategorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var progressbarFrm = new PROGRESSBAR_FRM();
            var sicatFrm = new SICAT_FRM(progressbarFrm) {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = sicatFrm.Text + " - " + posName ;
            sicatFrm.Show();
            sicatFrm.Closed += new EventHandler(sicatFrm_Closed);
        }

        void sicatFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void ItemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
        var siitemsFrm = new SIITEMS_FRM
                              {
                              MdiParent = this,
                              Dock = DockStyle.Fill
                              };
        this.Text = "";
        this.Text = siitemsFrm.Text + " - " + posName ;
            siitemsFrm.Show();
            siitemsFrm.Closed += new EventHandler(siitemsFrm_Closed);
        }

        void siitemsFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void ItemPricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var siposprices = new SIPOSPRICES {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = siposprices.Text + " - " + posName ;
            siposprices.Show();
            siposprices.Closed += new EventHandler(siposprices_Closed);
        }

        void siposprices_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void DeliverySetupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sisupdeliveryFrm = new SISUPDELIVERY_FRM {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = sisupdeliveryFrm.Text + " - " + posName ;
            sisupdeliveryFrm.Show();
            sisupdeliveryFrm.Closed += new EventHandler(sisupdeliveryFrm_Closed);
        }

        void sisupdeliveryFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void SupplierSetupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sisupplierFrm = new SISUPPLIER_FRM
                                    {
                                        MdiParent = this,
                                        WindowState = FormWindowState.Maximized,
                                        Dock = DockStyle.Fill
                                    };
            this.Text = "";
            this.Text = sisupplierFrm.Text + " - " + posName ;
            sisupplierFrm.Show();
            sisupplierFrm.Closed += new EventHandler(sisupplierFrm_Closed);
        }

        void sisupplierFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void ExchangeRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var  exchangerateFrm = new EXCHANGERATE_FRM {MdiParent = this};
            exchangerateFrm.Show();
            
        }

        private void PurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sipopurchaseorderFrm = new SIPOPURCHASEORDER_FRM {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = sipopurchaseorderFrm.Text + " - " + posName ;
            sipopurchaseorderFrm.Show();
            sipopurchaseorderFrm.Closed += new EventHandler(sipopurchaseorderFrm_Closed);
        }

        void sipopurchaseorderFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void CustomerSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sicustomerFrm = new SICUSTOMER_FRM {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = sicustomerFrm.Text + " - " + posName ;
            sicustomerFrm.Show();
            sicustomerFrm.Closed += new EventHandler(sicustomerFrm_Closed);
        }

        void sicustomerFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void DeliveriesSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sicusdeliveryFrm = new SICUSDELIVERY_FRM {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = sicusdeliveryFrm.Text + " - " + posName ;
            sicusdeliveryFrm.Show();
            sicusdeliveryFrm.Closed += new EventHandler(sicusdeliveryFrm_Closed);
        }

        void sicusdeliveryFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }


        private void PurchaseMatchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sipopurchasematchingFrm = new SIPOPURCHASEMATCHING_FRM {MdiParent = this,Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = sipopurchasematchingFrm.Text + " - " + posName ;
            sipopurchasematchingFrm.Show();
            sipopurchasematchingFrm.Closed += new EventHandler(sipopurchasematchingFrm_Closed);
        }

        void sipopurchasematchingFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void PurchaseDebitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sidebitNoteFrm = new SIDEBIT_NOTE_FRM {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = sidebitNoteFrm.Text + " - " + posName ;
            sidebitNoteFrm.Show();
            sidebitNoteFrm.Closed += new EventHandler(sidebitNoteFrm_Closed);
        }

        void sidebitNoteFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void InventoryBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sibalancestock = new SIBALANCESTOCK {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = sibalancestock.Text + " - " + posName ;
            sibalancestock.Show();
            sibalancestock.Closed += new EventHandler(sibalancestock_Closed);
        }

        void sibalancestock_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sioptions_FRM = new SIOPTIONS_FRM {MdiParent = this};
            sioptions_FRM.Show();
        }

        private void MovementImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var simovementlineFrm = new SIMOVEMENTLINE_FRM {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = simovementlineFrm.Text + " - " + posName ;
            simovementlineFrm.Show();
            simovementlineFrm.Closed += new EventHandler(simovementlineFrm_Closed);
        }

        void simovementlineFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void StockAdjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stockaddjustmentFrm = new STOCKADDJUSTMENT_FRM {MdiParent = this};
            this.Text = "";
            this.Text = stockaddjustmentFrm.Text + " - " + posName ;
            stockaddjustmentFrm.Show();
            
        }

        private void MAIN_FRM_FormClosing(object sender, FormClosingEventArgs e)
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

        private void LogOFF()
        {
            var command = new SqlCommand("SI_UPDATE_SIUSERS_LOG", connection.Connect());
            Commands.CreateParameter(command, "USER_CODE", UserLogOn.Code, "USER_LOG",
                                     System.Text.Encoding.UTF32.GetBytes("U"));
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
        }

        private void SaleBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (SITempData.Loc_Code_POS == "")
           {
               
               var terminal_FRM = new TERMINAL_FRM {txtLocCode = {Text = SITempData.Loc_Code_POS}};
               var condition = new[] {"LOC_CODE", SITempData.Loc_Code_POS};

               terminal_FRM.txtLocDesc.Text = DataAccess.ReturnField("SELECT LOC_NAME FROM SIPLOCA", "LOC_CODE",
                                                                     condition, 0);
               if (terminal_FRM.ShowDialog() == DialogResult.OK)
               {
                   SITempData.Loc_Code_POS = terminal_FRM.txtLocCode.Text;
                   MessageBox.Show("Location have been changed successfully.", "Changed Location", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
               }
               else
               {
                   return;
               }
           terminal_FRM.Close();
           }
           if (!_dataManager.Exists("SIPCUSPOS", UserLogOn.Location, "LOC_CODE", "USER_CODE", UserLogOn.Code))
           {
               MessageBox.Show("Please Setup Customer In POS first.", "Not Found Customer", MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
               return;
           }
            var pointofsaleFrm = new POINTOFSALE_FRM();
            pointofsaleFrm.Show();
        }

        private void HappyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var siposdiscountFrm = new SIPOSDISCOUNT_FRM {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = siposdiscountFrm.Text + " - " + posName ;
            siposdiscountFrm.Show();
            siposdiscountFrm.Closed += new EventHandler(siposdiscountFrm_Closed);
        }

        void siposdiscountFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void SalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saleprocessing = new SALEPROCESSING_FRM { MdiParent = this, Dock = DockStyle.Fill }; this.Text = "";
            this.Text = saleprocessing.Text + " - " + posName ;
            saleprocessing.Show();
            saleprocessing.Closed += new EventHandler(saleprocessing_Closed);

        }

        void saleprocessing_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void CreditnoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var creditnoteFrm = new CREDITNOTE_FRM {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = creditnoteFrm.Text + " - " + posName ;
            creditnoteFrm.Show();
            creditnoteFrm.Closed += new EventHandler(creditnoteFrm_Closed);
        }

        void creditnoteFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void EmployeeToolStrip_Click(object sender, EventArgs e)
        {
            var siemployeeFrm = new SIEMPLOYEE_FRM
                                    {
                                        MdiParent = this,
                                        Dock = DockStyle.Fill
                                        
                                    };
            this.Text = "";
            this.Text = siemployeeFrm.Text + " - " + posName ;
            siemployeeFrm.Show();
            siemployeeFrm.Closed += new EventHandler(siemployeeFrm_Closed);

        }

        void siemployeeFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void unitConvertReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportUnitConversion = new ReportUnitConversion {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = reportUnitConversion.Text + " - " + posName ;
            reportUnitConversion.Show();
            reportUnitConversion.Closed += new EventHandler(reportUnitConversion_Closed);    

        }

        void reportUnitConversion_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void ToolStripReportDesign_Click(object sender, EventArgs e)
        {
            var reportFrm = new ReportFrm {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = reportFrm.Text + " - " + posName ;
            reportFrm.Show();
            reportFrm.Closed += new EventHandler(reportFrm_Closed);
        }

        void reportFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void PurchaseListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var purchaselistingFrm = new PURCHASELISTING_FRM {MdiParent = this};
            purchaselistingFrm.Show();
            purchaselistingFrm.Closed += new EventHandler(purchaselistingFrm_Closed);
        }

        void purchaselistingFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void SupplierListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var supplierListing = new SUPPLIER_LISTING {MdiParent = this};
            supplierListing.Show();
            supplierListing.Closed += new EventHandler(supplierListing_Closed);
        }

        void supplierListing_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void MovementListingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var movementListingFrm = new MOVEMENT_LISTING_FRM {MdiParent = this};
            movementListingFrm.Show();
            movementListingFrm.Closed += new EventHandler(movementListingFrm_Closed);
        }

        void movementListingFrm_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void InventoryListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventory = new INVENTORY_MOVEMENT_FRM {MdiParent = this};
            inventory.Show();
            inventory.Closed += new EventHandler(inventory_Closed);

        }

        void inventory_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }

        private void InventoryTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventoryTransfer = new InventoryTransfer {MdiParent = this};
            inventoryTransfer.Show();
         
        }

        private void SalesListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saleListing = new SALE_LISTING {MdiParent = this};
            saleListing.Show();
        }

        private void CustomerListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerListing = new CUSTOMER_LISTING {MdiParent = this};
            customerListing.Show();
        }

        private void InventoryStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventoryListing = new INVENTORY_LISTING {MdiParent = this};
            inventoryListing.Show();
        }

        private void barCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var printBarcode = new PRINT_BARCODE {MdiParent = this};
            printBarcode.Show();
        }

        private void setupCustomerInPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var setupLocationCustomerPOS = new SetupLocationCustomerPos {MdiParent = this, Dock = DockStyle.Fill};
            this.Text = "";
            this.Text = setupLocationCustomerPOS.Text + " - " + posName ;
            setupLocationCustomerPOS.Show();
            setupLocationCustomerPOS.Closed += new EventHandler(setupLocationCustomerPOS_Closed);       
        }

        void setupLocationCustomerPOS_Closed(object sender, EventArgs e)
        {
            Text = posName;
        }
    }
}
