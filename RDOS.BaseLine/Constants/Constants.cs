namespace RDOS.BaseLine.Constants
{
    public static class Constants
    {
        public static class BlProcessConst
        {
            public const string SOPROCESS = "PROS01";
            public const string POPROCESS = "PROS02";
            public const string IN_RECEIPT = "PROS03";
            public const string IN_ISSUE = "PROS04";
            public const string BL_CLOSE_QTY = "PROS05";
            public const string BL_SAFE_STOCK_ACESSMENT = "PROS06";
            public const string AVERATE_DAILY_RUNNING_SALE = "PROS07";
            public const string CAL_KPI = "PROS08";
            public const string CUS_PER_DAILY = "PROS09";
        }
        public class SO_SaleOrderTypeConst
        {
            public const string SalesOrder = "SalesOrder";
            public const string ReturnOrder = "ReturnOrder";
        }

        public static class StatusSOConst
        {
            public const string CANCEL = "SO_ST_CANCEL";
            public const string FAILED = "SO_ST_FAILED";
            public const string DELIVERED = "SO_ST_DELIVERED";
            public const string PARTIALDELIVERED = "SO_ST_PARTIALDELIVERED";
        }

        public static class SIIDConst
        {
            public const string ACTUALVOLUME = "ActualVolume";
            public const string ACTUALREVENUE = "ActualRevenue";
            public const string ACTUALPC = "ActualPC";
            public const string ACTUALLPPC = "ActualLPPC";
            public const string ASO = "ASO";
            public const string SKUBUYED = "SKUBuyed";
            public const string VPO = "VPO";
            public const string LPPC = "LPPC";
            public const string WEEKVISITED = "WeekVisited";
            public const string SPVISITED = "SPVisited";
            public const string QUATERVISITED = "QuaterVisited";
            public const string YEARVISITED = "YearVisited";
        }
    }
}
