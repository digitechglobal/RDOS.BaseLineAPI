using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempProgramDetailReward
    {
        public Guid Id { get; set; }
        public string? ProgramDetailRewardCode { get; set; }
        public string? ProgramDetailsKey { get; set; }
        public string? Type { get; set; }
        public string? ItemCode { get; set; }
        public Guid? ItemId { get; set; }
        public string? Uomcode { get; set; }
        public int Quantities { get; set; }
        public decimal Amount { get; set; }
        public double DiscountPercented { get; set; }
        public bool IsDeleted { get; set; }
        public string? Description { get; set; }
        public int BaseQuantities { get; set; }
        public string? BaseUomCode { get; set; }
    }
}
