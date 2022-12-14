using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisBudget
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public string DisplayLevelCode { get; set; } = null!;
        public decimal TotalBudget { get; set; }
        public decimal BudgetQuantityUsed { get; set; }
        public decimal NewTotalBudget { get; set; }
        public DateTime AdjustmentDate { get; set; }
        public string? AdjustmentsAccount { get; set; }
        public string? AdjustmentsReason { get; set; }
        public string? AdjustmentsFilePath { get; set; }
        public string? AdjustmentsFileName { get; set; }
        public int AdjustmentsCount { get; set; }
        public int Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public decimal BudgetQuantityWait { get; set; }
        public string? AdjustmentsFileExt { get; set; }
        public string? AdjustmentsFolderType { get; set; }
    }
}
