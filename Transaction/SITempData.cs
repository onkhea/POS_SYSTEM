using System;

namespace POS.Transaction
{
    public static class SITempData
    {
        private static string code;

        private static string cnn;

        public static string Code
        {
            get { return code; }
            set { code = value; }
        }

        public static Int16 DB_SB_DECIMAL { get; set; }

        public static string PO_AUTO_NUM { get; set; }

        public static string Release_User { get; set; }

        public static bool Is_Edit
        {
            get { return is_Edit; }
            set { is_Edit = value; }
        }

        public static string LOC_CODE_PO
        {
            get { return lOC_CODE_PO; }
            set { lOC_CODE_PO = value; }
        }

        public static string Loc_Code_POS
        {
            get { return loc_Code_POS; }
            set { loc_Code_POS = value; }
        }

        public static string TRANS_REF
        {
            get { return tRANS_REF; }
            set { tRANS_REF = value; }
        }

        public static string SORD_REF
        {
            get { return sORD_REF; }
            set { sORD_REF = value; }
        }

        public static string CUST_POS
        {
            get { return cUST_POS; }
            set { cUST_POS = value; }
        }

        public static string DelcustPos { get; set; }

        public static string Sale_Order
        {
            get { return sale_Order; }
            set { sale_Order = value; }
        }

        public static string Cnn
        {
            get { return cnn; }
            set { cnn = value; }
        }

        private static bool is_Edit;
        private static string lOC_CODE_PO;
        private static string loc_Code_POS;
        private static string tRANS_REF;
        private static string sORD_REF;
        private static string cUST_POS;
        private static string sale_Order;
    }
}