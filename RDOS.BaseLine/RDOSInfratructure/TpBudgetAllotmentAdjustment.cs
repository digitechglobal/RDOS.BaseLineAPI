using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpBudgetAllotmentAdjustment
    {
        public Guid Id { get; set; }
        public Guid BudgetAdjustmentId { get; set; }
        public string BudgetCode { get; set; }
        public string SalesTerritoryValueCode { get; set; }
        public decimal BudgetQuantityDetail { get; set; }
        public decimal BudgetQuantityDetailNew { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public decimal BudgetQuantityUsed { get; set; }
    }
}
