using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpPromotionDefinitionStructure
    {
        public Guid Id { get; set; }
        public string PromotionCode { get; set; } = null!;
        public string LevelCode { get; set; } = null!;
        public string LevelName { get; set; } = null!;
        public int QuantityPurchased { get; set; }
        public string? ImageName1 { get; set; }
        public string? ImagePath1 { get; set; }
        public string? ImageName2 { get; set; }
        public string? ImagePath2 { get; set; }
        public string ProductTypeForSale { get; set; } = null!;
        public bool IsGiftProduct { get; set; }
        public bool IsDonate { get; set; }
        public bool IsFixMoney { get; set; }
        public bool RuleOfGiving { get; set; }
        public string? ProductTypeForGift { get; set; }
        public bool IsApplyBudget { get; set; }
        public decimal AmountOfDonation { get; set; }
        public float PercentageOfAmount { get; set; }
        public string? BudgetForDonation { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public decimal OnEach { get; set; }
        public decimal ValuePurchased { get; set; }
        public string? ItemHierarchyLevelForGift { get; set; }
        public string? ItemHierarchyLevelForSale { get; set; }
        public bool IsGiveSameProductSale { get; set; }
        public string? ImageFileExt1 { get; set; }
        public string? ImageFileExt2 { get; set; }
        public string? ImageFolderType1 { get; set; }
        public string? ImageFolderType2 { get; set; }
        public bool RuleOfGivingByProduct { get; set; }
        public string? RuleOfGivingByProductPacking { get; set; }
        public int RuleOfGivingByProductQuantity { get; set; }
    }
}
