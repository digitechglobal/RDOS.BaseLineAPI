using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpBudgetUsed
    {
        public Guid Id { get; set; }
        public string BudgetCode { get; set; }
        public string BudgetType { get; set; }
        public decimal AmountUsed { get; set; }
        public int QuantityUsed { get; set; }
        public string CustomerCode { get; set; }
        public string ShiptoCode { get; set; }
        public string RouteZoneCode { get; set; }
        public string SaleOrgCode { get; set; }
        public string CountryCode { get; set; }
        public string BranchCode { get; set; }
        public string RegionCode { get; set; }
        public string SubRegionCode { get; set; }
        public string AreaCode { get; set; }
        public string SubAreaCode { get; set; }
        public string DsacodeCode { get; set; }
        public string Key { get; set; }
    }
}
