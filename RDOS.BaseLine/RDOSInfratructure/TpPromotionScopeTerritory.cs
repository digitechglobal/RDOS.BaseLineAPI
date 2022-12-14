﻿using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpPromotionScopeTerritory
    {
        public Guid Id { get; set; }
        public string PromotionCode { get; set; } = null!;
        public string SalesTerritoryValue { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string SaleOrg { get; set; } = null!;
        public string ScopeSaleTerritoryLevel { get; set; } = null!;
    }
}
