using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisDefinitionStructure
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public string LevelCode { get; set; } = null!;
        public string LevelName { get; set; } = null!;
        public string DisplaySupportToolCode { get; set; } = null!;
        public string ProductTypeForDisplay { get; set; } = null!;
        public string? ItemHierarchyLevelDisplay { get; set; }
        public bool IsImagesOk { get; set; }
        public int? PercentImagesOk { get; set; }
        public bool IsRewardProduct { get; set; }
        public bool IsRewardDonate { get; set; }
        public bool IsRewardFixMoney { get; set; }
        public bool RewardRuleOfGiving { get; set; }
        public string? RewardProductType { get; set; }
        public string? ItemHierarchyLevelReward { get; set; }
        public decimal RewardAmountOfDonation { get; set; }
        public float RewardPercentageOfAmount { get; set; }
        public bool? IsCheckSalesOutput { get; set; }
        public decimal? SalesToBeAchieved { get; set; }
        public decimal? OutputToBeAchieved { get; set; }
        public string? Conditon { get; set; }
        public bool? IsAllProucts { get; set; }
        public bool IsSalesOutputProduct { get; set; }
        public bool IsSalesOutputDonate { get; set; }
        public bool IsSalesOutputFixMoney { get; set; }
        public bool SalesOutputRuleOfGiving { get; set; }
        public string? SalesOutputProductType { get; set; }
        public string? ItemHierarchyLevelSalesOut { get; set; }
        public decimal SalesOutputAmountOfDonation { get; set; }
        public float SalesOutputPercentageOfAmount { get; set; }
        public bool IsUseWeights { get; set; }
        public string? UseWeightsType { get; set; }
        public bool? IsBonusGiftProduct { get; set; }
        public bool? IsBonusDonate { get; set; }
        public bool? IsBonusFixMoney { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string? BonusGiftProductType { get; set; }
        public string? ItemHierarchyLevelBonusGift { get; set; }
        public string? ImagesRegisterFileExt { get; set; }
        public string? ImagesRegisterFolderType { get; set; }
        public string? ImagesRegisterName { get; set; }
        public string? ImagesRegisterNote { get; set; }
        public string? ImagesRegisterPath { get; set; }
        public bool ImagesRegisterRequired { get; set; }
    }
}
