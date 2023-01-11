namespace RDOS.BaseLine.Models.Result
{
    public class MonthlyBaseLineReqModel
    {
        public string settingRef { get; set; }
        public int salesYear { get; set; }
        public string salesPeriod { get; set; }
        public string SalesOrgDesc { get; set; }
        public int ordinal { get; set; }
        public string saleOrgId { get; set; }
        // public string token { get; set; }
    }

}