using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class SoProProgramCustomersDetail
    {
        public Guid Id { get; set; }
        public string? ProgramCustomersDetailCode { get; set; }
        public string? ProgramCustomersKey { get; set; }
        public string? ProgramDetailsKey { get; set; }
        public string? PromotionRefNumber { get; set; }
        public int ActualQantities { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal RemainAmount { get; set; }
        public int RemainQuantities { get; set; }
        public int SuggestQantities { get; set; }
        public string? DetailLevel { get; set; }
        public string? DetailDescription { get; set; }
        public string? DetailType { get; set; }
        public int DetailQuantities { get; set; }
        public decimal DetailAmount { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntil { get; set; }
        public bool IsDeleted { get; set; }
        public string? ProgramsBuyType { get; set; }
        public string? ProgramsGivingType { get; set; }
        public string? ProductTypeForSale { get; set; }
        public string? ProductTypeForGift { get; set; }
        public string? ItemHierarchyLevelForGift { get; set; }
        public string? ItemHierarchyLevelForSale { get; set; }
        public int QuantityPurchased { get; set; }
        public int OnEachQuantity { get; set; }
        public int ValuePurchased { get; set; }
        public int OnEachValue { get; set; }
    }
}
