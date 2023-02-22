using POS.DataLayer;

namespace POS.Transaction
{
    public static class SIAutoNumber
    {
        static readonly DataManager dataManager = new DataManager();

        #region properties

        public static string Prefix { get; set; }

        public static string Suffix { get; set; }

        public static string Interval { get; set; }

        public static string Length { get; set; }

        public static string Start { get; set; }

        public static string genPrefix { get; set; }

        public static string genSuffix { get; set; }

        #endregion

        public static string POS_AutoNumber()
        {
            var generator = new Generator();
            var dt = dataManager.GetData("SELECT SI_DATA FROM SIPDATA", "SI_CODE", "SI_CODE", "OS", "SI_TYPE", "AUTON");
            if (dt.Rows.Count > 0)
            {
                Prefix= dt.Rows[0][0].ToString().Substring(0, 10).Trim();
                Suffix = dt.Rows[0][0].ToString().Substring(10, 10).Trim();
                Interval = dt.Rows[0][0].ToString().Substring(20, 5);
                Length = dt.Rows[0][0].ToString().Substring(25, 2).Trim();
                Start = dt.Rows[0][0].ToString().Substring(27, 5).Trim();
                genPrefix = generator.Prefix(Prefix);
                genSuffix = generator.Prefix(Suffix);
            }
            else
            {
                genPrefix = "";
                genSuffix = "";
            }


            return generator.ID("SELECT MAX(ORD_REF) FROM dbo.SIPSINVM WHERE LEFT(ORD_REF," + genPrefix.Length + ")='" + genPrefix +
                        "' AND RIGHT(ORD_REF," + genSuffix.Length + ")='" + genSuffix + "'", int.Parse(Length) - (genPrefix.Length + genSuffix.Length), genPrefix, genSuffix,
                                int.Parse(Start), int.Parse(Interval));
        }


        public static string SO_AutoNumber()
        {
            var generator = new Generator();
            var dt = dataManager.GetData("SELECT SI_DATA FROM SIPDATA", "SI_CODE", "SI_CODE", "SO", "SI_TYPE", "AUTON");
            if (dt.Rows.Count > 0)
            {
                Prefix = dt.Rows[0][0].ToString().Substring(0, 10).Trim();
                Suffix = dt.Rows[0][0].ToString().Substring(10, 10).Trim();
                Interval = dt.Rows[0][0].ToString().Substring(20, 5);
                Length = dt.Rows[0][0].ToString().Substring(25, 2).Trim();
                Start = dt.Rows[0][0].ToString().Substring(27, 5).Trim();
            }

            genPrefix = generator.Prefix(Prefix);
            genSuffix = generator.Prefix(Suffix);

            return generator.ID("SELECT MAX(INV_REF) FROM dbo.SIPSINVM WHERE LEFT(INV_REF," + genPrefix.Length + ")='" + genPrefix +
                        "' AND RIGHT(INV_REF," + genSuffix.Length + ")='" + genSuffix + "'", int.Parse(Length) - (genPrefix.Length + genSuffix.Length), genPrefix, genSuffix,
                                int.Parse(Start), int.Parse(Interval));
        }

        public static string PO_AutoNumber()
        {
            var generator = new Generator();
            var dt = dataManager.GetData("SELECT SI_DATA FROM SIPDATA", "SI_CODE", "SI_CODE", "PO", "SI_TYPE", "AUTOP");
            if (dt.Rows.Count > 0)
            {
                Prefix = dt.Rows[0][0].ToString().Substring(0, 10).Trim();
                Suffix = dt.Rows[0][0].ToString().Substring(10, 10).Trim();
                Interval = dt.Rows[0][0].ToString().Substring(20, 5);
                Length = dt.Rows[0][0].ToString().Substring(25, 2).Trim();
                Start = dt.Rows[0][0].ToString().Substring(27, 5).Trim();
            }
            genPrefix = generator.Prefix(Prefix);
            genSuffix = generator.Prefix(Suffix);

            return generator.ID("SELECT MAX(ORM_REF) FROM dbo.SIPPORD WHERE LEFT(ORM_REF," + genPrefix.Length + ")='" + genPrefix +
                        "' AND RIGHT(ORM_REF," + genSuffix.Length + ")='" + genSuffix + "'", int.Parse(Length) - (genPrefix.Length + genSuffix.Length), genPrefix, genSuffix,
                                int.Parse(Start), int.Parse(Interval));
        }

        public static string PM_AutoNumber(string SqlStr)
        {
            var generator = new Generator();
            var dt = dataManager.GetData("SELECT SI_DATA FROM SIPDATA", "SI_CODE", "SI_CODE", "PM", "SI_TYPE", "AUTON");
            if (dt.Rows.Count > 0)
            {
                Prefix = dt.Rows[0][0].ToString().Substring(0, 10).Trim();
                Suffix = dt.Rows[0][0].ToString().Substring(10, 10).Trim();
                Interval = dt.Rows[0][0].ToString().Substring(20, 5);
                Length = dt.Rows[0][0].ToString().Substring(25, 2).Trim();
                Start = dt.Rows[0][0].ToString().Substring(27, 5).Trim();
            }
            genPrefix = generator.Prefix(Prefix);
            genSuffix = generator.Prefix(Suffix);
            return generator.ID(SqlStr, int.Parse(Length) - (genPrefix.Length + genSuffix.Length), genPrefix, genSuffix,
                                int.Parse(Start), int.Parse(Interval));
        }
    }
}
