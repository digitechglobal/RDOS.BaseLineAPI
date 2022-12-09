using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisPayRewardDetail
    {
        public Guid Id { get; set; }
        public string RewardType { get; set; }
        public string ItemHierarchyLevel { get; set; }
        public decimal? Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerShiptoCode { get; set; }
        public string DisPayRewardCode { get; set; }
        public string DisplayLevelCode { get; set; }
        public string PackingCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductType { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? RewardAcumulateAmount { get; set; }
        public bool RewardAcumulateGift { get; set; }
        public decimal? RewardAmountSum { get; set; }
        public decimal? RewardBonusAmount { get; set; }
        public bool RewardBonusGift { get; set; }
        public decimal? RewardDisplayAmount { get; set; }
        public bool RewardDisplayGift { get; set; }
    }
}
