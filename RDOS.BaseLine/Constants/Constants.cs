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
        }
        public static class StatusSOConst
        {
            public const string CANCEL = "SO_ST_CANCEL";
            public const string FAILED = "SO_ST_FAILED";
            public const string DELIVERED = "SO_ST_DELIVERED";
            public const string PARTIALDELIVERED = "SO_ST_PARTIALDELIVERED";
        }
    }
}
