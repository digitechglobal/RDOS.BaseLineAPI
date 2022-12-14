using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisWeightGetExtraRewardsDetail
    {
        public Guid Id { get; set; }
        public string DisplayCode { get; set; } = null!;
        public string LevelCode { get; set; } = null!;
        public string? ProductCode { get; set; }
        public string? Packing { get; set; }
        public decimal? AmountOfDonation { get; set; }
        public float? PercentageOfAmount { get; set; }
        public float? PercentageToBeAchieved { get; set; }
        public decimal? SalesToBeAchieved { get; set; }
        public decimal? Quantiy { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string ProductType { get; set; } = null!;
        public string WeightCode { get; set; } = null!;
    }
}
