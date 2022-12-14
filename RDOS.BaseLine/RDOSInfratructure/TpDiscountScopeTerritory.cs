using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpDiscountScopeTerritory
    {
        public Guid Id { get; set; }
        public string DiscountCode { get; set; } = null!;
        public string SaleOrg { get; set; } = null!;
        public string ScopeSaleTerritoryLevel { get; set; } = null!;
        public string SalesTerritoryValue { get; set; } = null!;
    }
}
