using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class DisSettlementDetail
    {
        public Guid Id { get; set; }
        public string DisSettlementCode { get; set; }
        public string OrdNbr { get; set; }
        public string DisplayCode { get; set; }
        public string DistributorCode { get; set; }
        public string ProductCode { get; set; }
        public string PackageCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int DeleteFlag { get; set; }
        public string CustomerId { get; set; }
        public string DisplayLevel { get; set; }
        public DateTime OrdDate { get; set; }
        public string ShiptoId { get; set; }
        public string Status { get; set; }
    }
}
