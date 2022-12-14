using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpBudget
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Io { get; set; } = null!;
        public string SaleOrg { get; set; } = null!;
        public string BudgetType { get; set; } = null!;
        public string BudgetAllocationForm { get; set; } = null!;
        public string? BudgetAllocationLevel { get; set; }
        public bool FlagOverBudget { get; set; }
        public string? FilePath { get; set; }
        public string? FileName { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string? FileExt { get; set; }
        public string? FolderType { get; set; }
    }
}
