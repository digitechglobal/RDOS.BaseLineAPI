using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisBudgetForScopeTerritory
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public string DisplayLevelCode { get; set; } = null!;
        public string ScopeValue { get; set; } = null!;
        public decimal BudgetQuantity { get; set; }
        public decimal NewBudgetQuantity { get; set; }
        public decimal BudgetQuantityUsed { get; set; }
        public int Type { get; set; }
        public int AdjustmentsCount { get; set; }
        public DateTime AdjustmentDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public decimal BudgetQuantityWait { get; set; }
    }
}
