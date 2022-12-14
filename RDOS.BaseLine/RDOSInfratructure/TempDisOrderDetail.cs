using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TempDisOrderDetail
    {
        public Guid Id { get; set; }
        public string OrdNbr { get; set; } = null!;
        public string? InventoryId { get; set; }
        public string? Uom { get; set; }
        public bool IsFree { get; set; }
        public decimal? ShippedQty { get; set; }
        public decimal UnitPrice { get; set; }
        public string? DiscountId { get; set; }
        public string? DiscountType { get; set; }
        public string? DiscountSchemeId { get; set; }
        public decimal? ShippedLineDiscAmt { get; set; }
        public string? PromotionLevel { get; set; }
        public string? DiscountName { get; set; }
        public string? DisplayLevel { get; set; }
        public string? DisplayLevelName { get; set; }
        public string? InventoryName { get; set; }
        public string? RewardPeriodCode { get; set; }
        public string? RewardPeriodName { get; set; }
        public string? Tmktype { get; set; }
        public string? UomName { get; set; }
        public decimal? ShippedLineExtendAmt { get; set; }
    }
}
