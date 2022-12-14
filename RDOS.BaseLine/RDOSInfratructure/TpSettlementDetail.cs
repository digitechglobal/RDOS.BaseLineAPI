using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class TpSettlementDetail
    {
        public Guid Id { get; set; }
        public string SettlementCode { get; set; } = null!;
        public string ProgramType { get; set; } = null!;
        public string? OrdNbr { get; set; }
        public string? Status { get; set; }
        public string PromotionDiscountCode { get; set; } = null!;
        public string DistributorCode { get; set; } = null!;
        public string? ProductCode { get; set; }
        public decimal? Quantity { get; set; }
        public string? Package { get; set; }
        public decimal? Amount { get; set; }
        public DateTime OrdDate { get; set; }
        public string? PromotionDiscountName { get; set; }
        public string? PromotionLevel { get; set; }
        public string? PromotionLevelName { get; set; }
        public string? CustomerId { get; set; }
        public string? ShiptoId { get; set; }
        public string? ShiptoName { get; set; }
        public string? ReferenceLink { get; set; }
        public string? SalesRepCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
    }
}
