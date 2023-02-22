namespace POS.Transaction
{
    class SIMenuItems 
    {
        private string groupsManagement;
        private string usersManagement;


        public string GroupsManagement
        {
            get { return "Groups Management"; }
        }

        public string UsersManagement
        {
            get { return "Users Management"; }
        }
            
        public string UnitConversion
        {
            get { return "Unit Conversion"; }
        }

        public string Employee
        {
            get { return "Employee Setup"; }
        }

        public string Supplier
        {
            get { return "Supplier Setup"; }
        }

        public string SupplierDeliveryAddresses
        {
            get { return "Deliveries Supplier"; }
        }

        public string CustomerDeliveryAddresses
        {
            get { return "Deliveries Customer"; }
        }

        public string Location
        {
            get { return "Locations"; }
        }

        public string Items
        {
            get { return "Item Record"; }
        }
          
        public  string Customer
        {
            get { return "Customer Setup"; }
        }
        
        public  string PurchaseOrder
        {
            get { return "Purchase Order"; }
        }

        public string PurchaseMatching
        {
            get { return "Purchase Matching"; }
        }

        public string InventoryBalance
        {
            get { return "Inventory Balance"; }
        }

        public string DebitNote
        {
            get { return "Debit Note"; }
        }

        public string MovementEntry
        {
            get { return "Movement Entry"; }
        }

        public string StockAddjustment
        {
            get { return "Stock Addjustment"; }
        }

        public string POSDiscount
        {
            get { return "Item Promotion"; }
        }

        public string SetupPrice
        {
            get { return "Item Price"; }
        }

        public string SaleOrder
        {
            get { return "Sale Order"; }
        }

        public string CreditNote
        {
            get { return "Credit Note"; }
        }

        public string Category
        {
            get { return "Item Category"; }
        }

        public  string ReportUnitConversion
        {
            get {  return "Unit Conversion Report"; }
        }

        public string AddCustomerInPOS
        {
            get { return "Setup Customer In POS"; }
        }
    }
}
