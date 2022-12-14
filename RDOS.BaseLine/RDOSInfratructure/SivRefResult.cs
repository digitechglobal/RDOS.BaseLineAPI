using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class SivRefResult
    {
        public Guid Id { get; set; }
        public string? Sitype { get; set; }
        public string? Sicode { get; set; }
        public DateTime CalculatorTime { get; set; }
        public string? ObjectType { get; set; }
        public string? ObjectCode { get; set; }
        public string? RequestPurchaseOrder { get; set; }
        public string? PeriodCode { get; set; }
        public string? DistributorCode { get; set; }
        public string? Siccode { get; set; }
        public string? SocreateBy { get; set; }
        public string? SoowerCode { get; set; }
        public string? PcinvoiceValue { get; set; }
        public string? PcnoofSku { get; set; }
        public string? RecognizedDateForPc { get; set; }
        public string? ByProductGroup { get; set; }
        public bool Result { get; set; }
        public string? SalesOrgCode { get; set; }
        public string? SalesTerritoryCode { get; set; }
        public string? CountryCode { get; set; }
        public string? BranchCode { get; set; }
        public string? RegionCode { get; set; }
        public string? SubRegionCode { get; set; }
        public string? AreaCode { get; set; }
        public string? SubAreaCode { get; set; }
        public string? Dsacode { get; set; }
        public string? RouteZoneCode { get; set; }
        public decimal ValueOrder { get; set; }
    }
}
