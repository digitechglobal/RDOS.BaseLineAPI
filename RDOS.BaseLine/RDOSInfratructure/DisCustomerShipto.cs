using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisCustomerShipto
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public string DisplayLevelCode { get; set; } = null!;
        public string TypeSalePoint { get; set; } = null!;
        public bool? IsSales { get; set; }
        public decimal NumberSalesHas { get; set; }
        public decimal SaleUnit { get; set; }
        public decimal TotalSalePoint { get; set; }
        public decimal TotalSalePointWithPosm { get; set; }
        public decimal TotalSalePointWithoutPosm { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
    }
}
