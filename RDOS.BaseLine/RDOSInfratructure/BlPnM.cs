using System;
using System.Collections.Generic;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class BlPnM
    {
        public Guid Id { get; set; }
        public string? SalesPeriod { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerShiptoId { get; set; }
        public string? CustomerShiptoName { get; set; }
        public string? ValueType { get; set; }
        public decimal? Value { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
