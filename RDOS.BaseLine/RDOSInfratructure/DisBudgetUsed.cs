using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisBudgetUsed
    {
        public Guid Id { get; set; }
        public Guid BudgetId { get; set; }
        public string? DisplayCode { get; set; }
        public string? DisplayLevel { get; set; }
        public string? ShiptoCode { get; set; }
        public string? RouteZoneCode { get; set; }
        public string? SaleOrgCode { get; set; }
        public string? CountryCode { get; set; }
        public string? BranchCode { get; set; }
        public string? RegionCode { get; set; }
        public string? SubRegionCode { get; set; }
        public string? AreaCode { get; set; }
        public string? SubAreaCode { get; set; }
        public string? DsacodeCode { get; set; }
        public string? Key { get; set; }
    }
}
